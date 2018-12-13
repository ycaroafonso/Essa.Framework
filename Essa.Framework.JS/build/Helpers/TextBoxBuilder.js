var Helpers;
(function (Helpers) {
    var TextBoxBuilder = /** @class */ (function () {
        function TextBoxBuilder(id) {
            this._obj = $(id);
        }
        TextBoxBuilder.prototype.Val = function (value) {
            this._obj.val(value);
            return this;
        };
        TextBoxBuilder.prototype.SetTimestamp = function (valor) {
            this._obj.val(Convert.Date.ToString(Convert.TimeStamp.ToDate(valor), "YYYY-MM-DD"));
            return this;
        };
        TextBoxBuilder.prototype.Get = function () {
            return this._obj;
        };
        TextBoxBuilder.prototype.Enabled = function (sit) {
            this._obj.prop("readonly", !sit);
            return this;
        };
        return TextBoxBuilder;
    }());
    Helpers.TextBoxBuilder = TextBoxBuilder;
})(Helpers || (Helpers = {}));
//# sourceMappingURL=TextBoxBuilder.js.map