// import * as $ from "jquery";
namespace Helpers {
    export class Noty {
        _config: NotyOptions;
        obj;

        constructor() {
            this._config = {
                maxVisible: 3
            };
        }

        // ----------------------------

        Config(pConfig): Noty {
            this._config = $.extend(this._config, pConfig)
            return this;
        }

        Layout(valor): Noty {
            this.Config({ layout: valor })
            return this;
        }
        Type(valor): Noty {
            this.Config({ type: valor });
            return this;
        }

        // -----------------------------

        TopRight(): Noty {
            return this.Layout("topRight");
        }

        Bottom(): Noty {
            return this.Layout("bottom");
        }

        BottomRight(): Noty {
            return this.Layout("bottomRight");
        }

        Success(): Noty {
            this.Config({ type: "success" });
            return this;
        }

        Error(): Noty {
            return this.Type("error");
        }

        FecharTodos(): Noty {
            $.noty.closeAll();
            return this;
        }

        Show(txt): void {
            this.Config({ text: txt });
            this.obj = noty(this._config);
        }
    }
}