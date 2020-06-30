
var AppViewModel = {
    DueInvoice: ko.observableArray(),
    HistoryInvoice: ko.observableArray(),
    addInvoice: function (data, event) {
        data.IsSelected(!data.IsSelected());
        AppViewModel.calcServiceCharge();
    },
    payInvoices: function () {
        var UDF2 = '', UDF3 = '', UDF4 = '', UDF5 = '';
        var lsInv = this.DueInvoice();
        for (var DueInvoiceCount = 0; DueInvoiceCount < lsInv.length; DueInvoiceCount++) {
            if (lsInv[DueInvoiceCount].IsSelected()) {
                UDF2 += lsInv[DueInvoiceCount].DocEntryNo + "_";
                UDF3 += lsInv[DueInvoiceCount].DocNumber + "_";
                UDF4 += lsInv[DueInvoiceCount].DocTotal + "_";
                UDF5 += lsInv[DueInvoiceCount].BranchID + "_";
            }
        }
        if (UDF2.length > 0) {
            $("#frm_PayRent input[name=UDF2]").val(UDF2.slice(0, -1));
            $("#frm_PayRent input[name=UDF3]").val(UDF3.slice(0, -1));
            $("#frm_PayRent input[name=UDF4]").val(UDF4.slice(0, -1));
            $("#frm_PayRent input[name=UDF5]").val(UDF5.slice(0, -1));
            $("#frm_PayRent").submit();
        }
        return false;
    },
    calcServiceCharge: function () {
        var lsInv = this.DueInvoice();
        var payAmount = 0;
        for (var DueInvoiceCount = 0; DueInvoiceCount < lsInv.length; DueInvoiceCount++) {
            if (lsInv[DueInvoiceCount].IsSelected()) {
                payAmount += parseFloat(lsInv[DueInvoiceCount].DocTotal);
            }
        }
        var Finaltotal = parseFloat(payAmount) + parseFloat($('#hdf_knet_serviceCharge').val());
        $('#inp_invTotal').val('KWD ' + payAmount.toFixed(3));
        $('#inp_servChrg').val('KWD ' + parseFloat($('#hdf_knet_serviceCharge').val()).toFixed(3));
        $('#inv_payAmount').val('KWD ' + Finaltotal.toFixed(3));
    }
};
ko.applyBindings(AppViewModel);

$.get($("#hdf_rent_duelist").val(), function (rsp) {
    for (var inv = 0; inv < rsp.Data.length; inv++) {
        rsp.Data[inv].IsSelected = ko.observable(false);
    }
    AppViewModel.DueInvoice(rsp.Data);
});
$.get($("#hdf_rent_duelist").val(), function (rsp) {
    for (var inv = 0; inv < rsp.Data.length; inv++) {
        rsp.Data[inv].IsSelected = ko.observable(false);
    }
    AppViewModel.HistoryInvoice(rsp.Data);
});