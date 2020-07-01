var LoginProvider = function () {
    var self = this;
    self.UserName = "";
    self.Password = "";
    self.HomeURL = "";

    self.loginSubmit = function () {
        fnShowLoader();
        $.ajax({
            url: $("#LoginURL").val(),
            type: "POST",
            data: ko.toJSON(self),
            contentType: "application/json; charset=utf-8",
            async: false,
            success: function (result) {
                if (result.Status && result.Data && result.Data.IsLoggedIn) {
                    location.href = document.getElementById('HomeURL').value;
                }
                else {
                    $('.err-msg').css('visibility', 'visible');
                    fnHideLoader();
                }
            }
        });
    };

    self.loginValidate = function () {
        if (self.UserName !== "" && self.Password !== "")
            return true;
        return false;
    };
};

var providerForUpdate = new LoginProvider();
ko.applyBindings(providerForUpdate);

function fnChangeCulture(absURL) {
    $.get($("#hdf_Culture_URL").val() + "?url=" + absURL, function (URLdata) {
        window.location.href = URLdata;
    });
    return false;
}
$(document).on('blur', '.err-val-ctrl', function () {
    $('.err-msg').css('visibility', 'hidden');
});