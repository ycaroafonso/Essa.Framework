// import * as $ from "jquery";
var Helpers;
(function (Helpers) {
    var BlockUI = /** @class */ (function () {
        function BlockUI() {
        }
        BlockUI.Bloquear = function () {
            $.blockUI(BlockUI._config);
            return this;
        };
        BlockUI.Desbloquear = function () {
            $.unblockUI(this._config);
            return this;
        };
        BlockUI._config = {
            baseZ: 200000
        };
        return BlockUI;
    }());
    Helpers.BlockUI = BlockUI;
})(Helpers || (Helpers = {}));
//# sourceMappingURL=BlockUI.js.map