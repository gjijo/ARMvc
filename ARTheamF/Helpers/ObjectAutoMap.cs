using AutoMapper;
using Mapster;

namespace ARTheamF.Helpers
{
    public class ObjectAutoMap
    {
        public static TData Getmapper<TSource, TData>(TSource Obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TData>();
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<TSource, TData>(Obj);
        }
        public static TData Map<TSource, TData>(TSource Obj)
        {
            return Obj.Adapt<TSource, TData>();
        }
    }
}