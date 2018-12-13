declare namespace Helpers {
    class TextBoxBuilder {
        _obj: JQuery;
        constructor(id: string);
        Val(value: string): TextBoxBuilder;
        SetTimestamp(valor: string): TextBoxBuilder;
        Get(): JQuery;
        Enabled(sit: string): TextBoxBuilder;
    }
}
