var Convert;
(function (Convert) {
    var String = /** @class */ (function () {
        function String() {
        }
        String.ToDate = function (valor, formato) {
            if (formato === void 0) { formato = "DD/MM/YYYY"; }
            return moment(valor, formato).toDate();
        };
        String.ToDecimal = function (valor) {
            var valor = valor == undefined || valor == null || valor == "" ? "0" : valor;
            return parseFloat(valor.replace(",", "."));
        };
        return String;
    }());
    Convert.String = String;
})(Convert || (Convert = {}));
//# sourceMappingURL=String.js.map