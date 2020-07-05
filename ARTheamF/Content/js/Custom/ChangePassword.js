var LoginProvider = function () {
    var self = this;
    self.UserName = "";
    self.UserPassword = "";
    self.NewPassword = "";
    self.HomeURL = "";

    self.loginSubmit = function () {
        fnShowLoader();
        $.ajax({
            url: $("#ForgotPURL").val(),
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
        if (self.UserName !== "" && self.UserPassword !== "" && self.NewPassword !== "")
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
$(document).on('focus', '.err-val-ctrl', function () {
    $('.err-msg').css('visibility', 'hidden');
});