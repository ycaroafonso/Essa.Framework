// import * as $ from "jquery";
// import * as moment from "moment";
namespace Convert {
    export class Decimal {
        static ToString(valor, casas): string {
            casas = casas === undefined ? 2 : casas;

            return new Intl.NumberFormat("pt-BR", { minimumFractionDigits: casas }).format(valor);
        }
    }
}