declare namespace Helpers {
    class Modal {
        _id: string;
        obj: JQuery;
        constructor(id: string);
        config: {
            backdrop: string;
            keyboard: boolean;
        };
        Abrir(): void;
        Ajax(url: string): Modal;
        Fechar(): void;
        Config(pConfig: any): Modal;
        NaoBloquearFundo(): Modal;
        IsOpen(): boolean;
    }
}
