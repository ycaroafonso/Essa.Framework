// import * as $ from "jquery";
var Helpers;
(function (Helpers) {
    var Noty = /** @class */ (function () {
        function Noty() {
            this._config = {
                maxVisible: 3
            };
        }
        // ----------------------------
        Noty.prototype.Config = function (pConfig) {
            this._config = $.extend(this._config, pConfig);
            return this;
        };
        Noty.prototype.Layout = function (valor) {
            this.Config({ layout: valor });
            return this;
        };
        Noty.prototype.Type = function (valor) {
            this.Config({ type: valor });
            return this;
        };
        // -----------------------------
        Noty.prototype.TopRight = function () {
            return this.Layout("topRight");
        };
        Noty.prototype.Bottom = function () {
            return this.Layout("bottom");
        };
        Noty.prototype.BottomRight = function () {
            return this.Layout("bottomRight");
        };
        Noty.prototype.Success = function () {
            this.Config({ type: "success" });
            return this;
        };
        Noty.prototype.Error = function () {
            return this.Type("error");
        };
        Noty.prototype.FecharTodos = function () {
            $.noty.closeAll();
            return this;
        };
        Noty.prototype.Show = function (txt) {
            this.Config({ text: txt });
            this.obj = noty(this._config);
        };
        return Noty;
    }());
    Helpers.Noty = Noty;
})(Helpers || (Helpers = {}));
//# sourceMappingURL=Noty.js.map