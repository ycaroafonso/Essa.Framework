//import * as $ from "jquery";
//import * as moment from "moment";
var Convert;
(function (Convert) {
    var Date = /** @class */ (function () {
        function Date() {
        }
        Date.ToString = function (valor, formato) {
            if (formato === void 0) { formato = "DD/MM/YYYY"; }
            if (valor === null)
                return null;
            return moment(valor).format(formato);
        };
        Date.ToAnoMes = function (valor) {
            return parseInt(this.ToString(valor, "YYYYMM"));
        };
        return Date;
    }());
    Convert.Date = Date;
})(Convert || (Convert = {}));
//# sourceMappingURL=Date.js.map