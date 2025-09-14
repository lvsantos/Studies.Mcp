internal sealed class PrincipalMenuHandler
{
    private readonly PromptsService _promptsService;

    internal PrincipalMenuHandler(PromptsService promptsService) => _promptsService = promptsService;

    public async Task Handle()
    {
        string prompt = string.Empty;
        bool exitPrincipalMenu = false;
        while (!exitPrincipalMenu)
        {
            PrincipalMenu menu = new();
            await menu.HandleAsync();

            switch (menu.SelectedOption)
            {
                case 0:
                    await ConsoleHandler.LoadingConsoleAsync("Encerrando aplicação...", 2000);
                    exitPrincipalMenu = true;
                    break;
                case 1:
                    prompt = await new HandlePromptMenu(_promptsService).Handle();
                    ConsoleHandler.WriteLine(prompt);
                    ConsoleHandler.WaitForKeyPress();
                    break;
            }
        }
    }
}