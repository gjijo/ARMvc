var LoginProvider = function () {
    var self = this;
    self.UserName = "";
    self.Password = "";
    self.HomeURL = "";

    self.loginSubmit = function () {
        $.ajax({
            url: $("#LoginURL").val(),
            type: "POST",
            data: ko.toJSON(self),
            contentType: "application/json; charset=utf-8",
            async: false,
            success: function (result) {
                if (result.Status && result.Data) {
                    location.href = document.getElementById('HomeURL').value;
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