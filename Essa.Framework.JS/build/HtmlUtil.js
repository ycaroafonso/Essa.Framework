// import * as Convert from "./Convert/Convert"
var HtmlUtil = /** @class */ (function () {
    function HtmlUtil() {
    }
    HtmlUtil.TextBox = function (id) {
        return new Helpers.TextBoxBuilder(id);
    };
    HtmlUtil.Modal = function (id) {
        return new Helpers.Modal(id);
    };
    HtmlUtil.BlockUI = function () {
        return new Helpers.BlockUI();
    };
    HtmlUtil.Noty = function () {
        return new Helpers.Noty();
    };
    return HtmlUtil;
}());
//# sourceMappingURL=HtmlUtil.js.map