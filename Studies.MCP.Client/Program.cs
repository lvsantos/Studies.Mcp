using ModelContextProtocol.Client;

try
{
    var transport = new StdioClientTransport(new StdioClientTransportOptions
    {
        Name = "Studies MCP Client",
        Command = "dotnet",
        Arguments = ["run", "--project", "../Studies.MCP.Server/Studies.MCP.Server.csproj"]
    });

    Task<IMcpClient> clientTask = McpClientFactory.CreateAsync(
        cancellationToken: default,
        clientTransport: transport);
    Task consoleTask = ConsoleHandler.LoadingConsoleAsync("Iniciando Studies MCP Client...", 4000);
    await Task.WhenAll(clientTask, consoleTask);

    IMcpClient client = clientTask.Result;
    PromptsService promptService = new(client);

    await new PrincipalMenuHandler(promptService).Handle();
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao criar MCP client: " + ex.Message);
}