//import * as $ from "jquery";
//import * as moment from "moment";
namespace Convert {
    export class Date {
        static ToString(valor: Date, formato: string = "DD/MM/YYYY"): string {
            if (valor === null) return null;

            return moment(valor).format(formato);
        }
        static ToAnoMes(valor: Date): number {
            return parseInt(this.ToString(valor, "YYYYMM"));
        }
    }
}