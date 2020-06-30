function fnChangeCulture(absURL) {
	$.get($("#hdf_Culture_URL").val() + "?url=" + absURL, function (URLdata) {
		window.location.href = URLdata;
	});
	return false;
}