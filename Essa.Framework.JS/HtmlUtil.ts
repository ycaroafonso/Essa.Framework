// import * as Convert from "./Convert/Convert"

class HtmlUtil {
    static TextBox(id: string): Helpers.TextBoxBuilder {
        return new Helpers.TextBoxBuilder(id);
    }

    static Modal(id: string): Helpers.Modal {
        return new Helpers.Modal(id);
    }

    static BlockUI(): Helpers.BlockUI {
        return new Helpers.BlockUI();
    }

    static Noty(): Helpers.Noty {
        return new Helpers.Noty();
    }
}