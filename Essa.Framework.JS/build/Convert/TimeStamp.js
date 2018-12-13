// import * as $ from "jquery";
// import * as moment from "moment";
// import * as Convert from "./Date";
var Convert;
(function (Convert) {
    var TimeStamp = /** @class */ (function () {
        function TimeStamp() {
        }
        TimeStamp.ToDate = function (valor) {
            if (valor === null || valor === "")
                return null;
            if (valor.toString().indexOf("Date") > -1)
                return moment(eval("new " + valor.replace(/\//gi, ""))).toDate();
            else
                return moment(valor).toDate();
        };
        TimeStamp.ToString = function (valor, formato) {
            return Convert.Date.ToString(this.ToDate(valor), formato);
        };
        return TimeStamp;
    }());
    Convert.TimeStamp = TimeStamp;
})(Convert || (Convert = {}));
//# sourceMappingURL=TimeStamp.js.map