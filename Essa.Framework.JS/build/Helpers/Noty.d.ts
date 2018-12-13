declare namespace Helpers {
    class Noty {
        _config: NotyOptions;
        obj: any;
        constructor();
        Config(pConfig: any): Noty;
        Layout(valor: any): Noty;
        Type(valor: any): Noty;
        TopRight(): Noty;
        Bottom(): Noty;
        BottomRight(): Noty;
        Success(): Noty;
        Error(): Noty;
        FecharTodos(): Noty;
        Show(txt: any): void;
    }
}
