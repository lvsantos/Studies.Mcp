internal sealed class HandlePromptMenu(PromptsService promptsService)
{
    private readonly PromptsService _promptsService = promptsService;

    public async Task<string> Handle()
    {
        List<Prompt> _prompts = await _promptsService.GetAllAsync();
        PromptMenu menu = new(_prompts);
        await menu.HandleAsync();
        if (!menu.HasOptions())
        {
            return string.Empty;
        }

        Prompt selectedPrompt = _prompts[menu.SelectedOption - 1];
        if (selectedPrompt.HasArguments())
        {
            var argumentHandler = new HandleArgumentMenu(selectedPrompt.Arguments);
            Dictionary<string, object?> arguments = await argumentHandler.HandleAsync();
            foreach (var argument in arguments)
            {
                selectedPrompt.DefineArgumentValue(argument.Key, argument.Value!.ToString()!);
            }
        }

        Task loadingTask =  ConsoleHandler.LoadingConsoleAsync("Gerando prompt...", 3000);
        Task<Prompt> generateTask = _promptsService.Generate(selectedPrompt);
        await Task.WhenAll(loadingTask, generateTask);
        selectedPrompt = generateTask.Result;

        await ConsoleHandler.LoadingConsoleAsync("Prompt gerado com sucesso!", 2000);
        return selectedPrompt.Content;
    }
}