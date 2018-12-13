// import * as $ from "jquery";
namespace Helpers {
    export class BlockUI {
        static _config: JQBlockUIOptions = {
            baseZ: 200000
        }

        static Bloquear(): BlockUI {
            $.blockUI(BlockUI._config);

            return this;
        }

        static Desbloquear(): BlockUI {
            $.unblockUI(this._config);

            return this;
        }

        //Config(): BlockUI {
        //    if (pConfig == undefined) return config;
        //    config = $.extend(config, pConfig)
        //    return this;
        //}
    }
}