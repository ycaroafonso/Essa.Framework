namespace Helpers {
    export class TextBoxBuilder {

        _obj: JQuery;

        constructor(id: string) {
            this._obj = $(id);
        }

        Val(value: string): TextBoxBuilder {
            this._obj.val(value);
            return this;
        }

        SetTimestamp(valor: string): TextBoxBuilder {
            this._obj.val(Convert.Date.ToString(Convert.TimeStamp.ToDate(valor), "YYYY-MM-DD"));
            return this;
        }

        Get(): JQuery {
            return this._obj;
        }

        Enabled(sit: string): TextBoxBuilder {
            this._obj.prop("readonly", !sit);

            return this;
        }
    }
}