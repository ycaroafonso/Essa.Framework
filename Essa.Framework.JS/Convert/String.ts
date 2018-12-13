namespace Convert {
    export class String {
        static ToDate(valor: string, formato: string = "DD/MM/YYYY"): Date {
            return moment(valor, formato).toDate();
        }
        static ToDecimal(valor): number {
            var valor = valor == undefined || valor == null || valor == "" ? "0" : valor;
            return parseFloat(valor.replace(",", "."));
        }
    }
}