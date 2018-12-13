// import * as $ from "jquery";
// import * as moment from "moment";
var Convert;
(function (Convert) {
    var Decimal = /** @class */ (function () {
        function Decimal() {
        }
        Decimal.ToString = function (valor, casas) {
            casas = casas === undefined ? 2 : casas;
            return new Intl.NumberFormat("pt-BR", { minimumFractionDigits: casas }).format(valor);
        };
        return Decimal;
    }());
    Convert.Decimal = Decimal;
})(Convert || (Convert = {}));
//# sourceMappingURL=Decimal.js.map