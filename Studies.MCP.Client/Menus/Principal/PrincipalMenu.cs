
internal sealed class PrincipalMenu : OptionMenu
{

    protected override bool IsInputValid() => base.IsInputValid() && (SelectedOption == 0 || SelectedOption == 1);

    protected override string GetLoadingMessage() => "Carregando menu principal...";

    protected override string GetMenuTitle() => "Menu Principal";

    protected override Dictionary<int, string> GetMenuOptions() => new()
    {
        { 1, "Prompt" },
        { 0, "Sair" }
    };
}