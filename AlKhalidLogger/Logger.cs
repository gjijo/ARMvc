using AlkhalidUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;

namespace AlKhalidLogger
{
    public class Logger
    {
        internal static void Error(Exception exception, string message, string fileName, string errorUrl, string folderName)
        {
            LogData data = new LogData()
            {
                Message = ErrorFormat(exception, message, errorUrl),
                Path = LogPaths.ErrorPath,
                FileName = string.IsNullOrEmpty(fileName)
                    ? string.Format("{0}_{1}", DateTime.Now.ToString("dd-mm-yyyy-HH-MM"), "ErrorLog.txt") 
                    : fileName,
                FolderName = folderName
            };
            FileQueueLogger.Instance().Enqueue(data);
        }

        internal static void Message(string title, string message, string fileName, string folderName)
        {
            fileName = string.IsNullOrEmpty(fileName)
                    ? string.Format("{0}_{1}", DateTime.Now.ToString("dd-mm-yyyy-HH-MM"), "InfoLog.txt")
                    : fileName;

            LogData data = new LogData()
            {
                Message = title + message,
                Path = LogPaths.InfoPath,
                FileName = fileName,
                FolderName = folderName
            };

            FileQueueLogger.Instance().Enqueue(data);
        }


        internal static void JSON<T>(T content, string fileName, string folderName)
        {
            LogData data = new LogData()
            {
                Message = JsonConvert.SerializeObject(content),
                Path = LogPaths.APILogPath,
                FileName = string.Format("{0}_{1}.json", DateTime.Now.Ticks.ToString(), fileName),
                FolderName = folderName
            };

            FileQueueLogger.Instance().Enqueue(data);
        }

        static string ErrorFormat(Exception exception, string message, string url)
        {
            return string.Format("{1}{8}{1}Error : {0}{1}Url: {2}{1}Stack Trace: {3}{1}Exception Details : {4}{1}HelpLink:{5}{1}InnerException:{6}{1}Data:{7}",
                message,
                Environment.NewLine,
                url,
                exception.StackTrace,
                exception.Message,
                exception.HelpLink,
                exception.InnerException,
                exception.Data,
                DateTime.Now.ToString("o"));
        }
    }
    class FileQueueLogger
    {
        private static readonly Lazy<FileQueueLogger> _FileQueueLogger;

        static FileQueueLogger()
        {
            _FileQueueLogger = new Lazy<FileQueueLogger>(() =>
            {
                return new FileQueueLogger();
            });
        }

        private FileQueueLogger()
        {
            Thread thread = new Thread(new ThreadStart(OnStart));
            thread.IsBackground = true;
            thread.Start();
        }

        internal static FileQueueLogger Instance()
        {
            return _FileQueueLogger.Value;
        }

        private BlockingCollection<LogData> _Logs = new BlockingCollection<LogData>();


        internal void Enqueue(LogData log)
        {
            _Logs.Add(log);
        }

        private void OnStart()
        {
            foreach (LogData log in _Logs.GetConsumingEnumerable(CancellationToken.None))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(
                string.Format("{0}---------------------------------------------------------------------------------------{0}{1}", Environment.NewLine, log.Message));
                using (FileStream sourceStream = new FileStream(Path.Combine(log.Path, log.FolderName, string.Format("{0}--------------{1}", DateTime.Now.ToString("yyyy.MM.dd.hh.mm.tt"), log.FileName)),
                    FileMode.Append, FileAccess.Write, FileShare.None,
                    bufferSize: 4096, useAsync: true))
                {
                    sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
                };
            }
        }
    }
    public class LogData
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public int Type { get; set; }
        public DateTime Time { get; set; }

    }

    class LogPaths
    {
        private static readonly string applnPath;
        private static readonly string applnLogPath;

        static LogPaths()
        {
            applnPath = ConfigSettings.LogsPath;
            Directory.CreateDirectory(applnPath);
            applnLogPath = CombineAndCreate(applnPath, "Logs");
            ErrorPath = CombineAndCreate(applnLogPath, LogTypes.Error.ToString());
            APILogPath = CombineAndCreate(applnLogPath, LogTypes.ExternalAPI.ToString());
            PGPath = CombineAndCreate(applnLogPath, LogTypes.PaymentGateWay.ToString());
            InfoPath = CombineAndCreate(applnLogPath, LogTypes.Messages.ToString());
        }


        /// <summary>
        /// Creates path and directory
        /// </summary>
        /// <param name="path"></param>
        private static string CombineAndCreate(string basePath, string folder)
        {
            string path = Path.Combine(basePath, folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }


        internal static string ErrorPath { get; private set; }
        internal static string InfoPath { get; private set; }
        internal static string PGPath { get; private set; }
        internal static string APILogPath { get; private set; }

    }
}
