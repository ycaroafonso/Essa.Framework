declare namespace Convert {
    class String {
        static ToDate(valor: string, formato?: string): Date;
        static ToDecimal(valor: any): number;
    }
}
