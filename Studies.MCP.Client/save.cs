// using ModelContextProtocol.Client;
// using ModelContextProtocol.Protocol;

// Console.WriteLine($"Hello, Studies for MCP Client!");

// var transport = new StdioClientTransport(new StdioClientTransportOptions
// {
//     Name = "Studies MCP Client",
//     Command = "dotnet",
//     Arguments = ["run", "--project", "../Studies.MCP.Server/Studies.MCP.Server.csproj"]
// });

// try
// {
//     var client = await McpClientFactory.CreateAsync(cancellationToken: default, clientTransport: transport);

//     foreach (McpClientPrompt prompt in await client.ListPromptsAsync())
//     {
//         bool hasArguments = prompt.ProtocolPrompt.Arguments is not null && prompt.ProtocolPrompt.Arguments.Count > 0;
//         if(hasArguments)
//         {
//             Console.WriteLine($"Available prompt: {prompt.Name} - {prompt.Description} - " +
//                 $"Parameters: {string.Join(", ", prompt.ProtocolPrompt.Arguments!.Select(p => p.Name))}");
//         }
//         else
//         {
//             Console.WriteLine($"Available prompt: {prompt.Name} - {prompt.Description}");
//         }

//         IReadOnlyDictionary<string, object> promptArguments = new Dictionary<string, object>()
//         {
//             { "protagonistaNome", "Jordão" },
//             { "antagonistaNome", "John" }
//         };

//         GetPromptResult promptResult = await prompt.GetAsync(promptArguments!);

//         foreach (PromptMessage message in promptResult.Messages)
//         {
//             Console.WriteLine($"Message Role: {message.Role}, Content: {((TextContentBlock)message.Content).Text}");
//         }
//     }

//     foreach (McpClientTool tool in await client.ListToolsAsync())
//     {
//         bool hasArguments = tool.AdditionalProperties is not null && tool.AdditionalProperties.Count > 0;
//         if (hasArguments)
//         {
//             Console.WriteLine($"Available tool: {tool.Name} - {tool.Description} - " +
//                 $"Parameters: {string.Join(", ", tool.AdditionalProperties!.Select(p => p.Key))}");
//         }
//         else
//         {
//             Console.WriteLine($"Available tool: {tool.Name} - {tool.Description}");
//         }

//         var toolResult = await tool.CallAsync();

//         foreach (ContentBlock res in toolResult.Content)
//         {
//             Console.WriteLine($"Tool Result: {((TextContentBlock)res).Text}");
//         }
        
//     }

//     foreach (McpClientResource resource in await client.ListResourcesAsync())
//     {
//         Console.WriteLine($"Available resource: {resource.Name} - {resource.Description}");

//         ReadResourceResult resourceResult = await resource.ReadAsync();

//         foreach (ResourceContents res in resourceResult.Contents)
//     {
//         Console.WriteLine($"Resource Content: {((TextResourceContents)res)?.Text}");
//     }
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Error creating MCP client: " + ex.Message);
//     return;
// }