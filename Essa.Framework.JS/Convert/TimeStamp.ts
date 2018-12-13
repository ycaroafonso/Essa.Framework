// import * as $ from "jquery";
// import * as moment from "moment";
// import * as Convert from "./Date";

namespace Convert {
    export class TimeStamp {
        static ToDate(valor: string): Date {
            if (valor === null || valor === "") return null;

            if (valor.toString().indexOf("Date") > -1)
                return moment(eval("new " + valor.replace(/\//gi, ""))).toDate();
            else
                return moment(valor).toDate();
        }

        static ToString(valor: string, formato: string): string {
            return Convert.Date.ToString(this.ToDate(valor), formato);
        }
    }
}