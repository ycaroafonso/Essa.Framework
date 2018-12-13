// import * as $ from "jquery";
var Helpers;
(function (Helpers) {
    var Modal = /** @class */ (function () {
        function Modal(id) {
            this.config = {
                backdrop: 'static',
                keyboard: false
            };
            this._id = id;
            this.obj = $((this._id.substr(0, 1) === "#" ? "" : "#") + this._id);
        }
        Modal.prototype.Abrir = function () {
            this.obj.modal(this.config);
        };
        Modal.prototype.Ajax = function (url) {
            this.obj.find(".modal-body").load(url);
            return this;
        };
        Modal.prototype.Fechar = function () {
            this.obj.modal("hide");
        };
        // ----------
        Modal.prototype.Config = function (pConfig) {
            this.config = $.extend(this.config, pConfig);
            return this;
        };
        Modal.prototype.NaoBloquearFundo = function () {
            this.Config({
                backdrop: 'dynamic',
                keyboard: true,
            });
            return this;
        };
        // ----------
        Modal.prototype.IsOpen = function () {
            return this.obj.css("display") === "block";
        };
        return Modal;
    }());
    Helpers.Modal = Modal;
})(Helpers || (Helpers = {}));
//# sourceMappingURL=Modal.js.map