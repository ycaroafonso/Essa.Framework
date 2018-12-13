// import * as $ from "jquery";

namespace Helpers {
    export class Modal {
        _id: string;
        obj: JQuery;

        constructor(id: string) {
            this._id = id;
            this.obj = $((this._id.substr(0, 1) === "#" ? "" : "#") + this._id);
        }

        config = {
            backdrop: 'static',
            keyboard: false
        };

        Abrir(): void {
            this.obj.modal(this.config);
        }

        Ajax(url: string): Modal {
            this.obj.find(".modal-body").load(url);
            return this;
        }
        Fechar(): void {
            this.obj.modal("hide");
        }
        // ----------
        Config(pConfig): Modal {
            this.config = $.extend(this.config, pConfig)
            return this;
        }
        NaoBloquearFundo(): Modal {
            this.Config({
                backdrop: 'dynamic',
                keyboard: true,
            });
            return this;
        }
        // ----------
        IsOpen(): boolean {
            return this.obj.css("display") === "block";
        }
    }
}