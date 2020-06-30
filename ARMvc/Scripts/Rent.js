
var AppViewModel = {
    DueInvoice: ko.observableArray(),
    HistoryInvoice: ko.observableArray(),
    addInvoice : function () {
        var a = this;
    },
    payInvoices: function () {
        var UDF2 = '', UDF3 = '', UDF4 = '', UDF5 = '';
        var lsInv = this.DueInvoice();
        for (var DueInvoiceCount = 0; DueInvoiceCount < lsInv.length; DueInvoiceCount++) {
            UDF2 += lsInv[DueInvoiceCount].DocEntryNo + "_";
            UDF3 += lsInv[DueInvoiceCount].DocNumber + "_";
            UDF4 += lsInv[DueInvoiceCount].DocTotal + "_";
            UDF5 += lsInv[DueInvoiceCount].BranchID + "_";
        }
        $("#frm_PayRent input[name=UDF2]").val(UDF2.slice(0, -1));
        $("#frm_PayRent input[name=UDF3]").val(UDF3.slice(0, -1));
        $("#frm_PayRent input[name=UDF4]").val(UDF4.slice(0, -1));
        $("#frm_PayRent input[name=UDF5]").val(UDF5.slice(0, -1));
        $("#frm_PayRent").submit();
        return false;
    }
};
ko.applyBindings(AppViewModel);

$.get($("#hdf_rent_duelist").val(), function (rsp) {
    AppViewModel.DueInvoice(rsp.Data);
});