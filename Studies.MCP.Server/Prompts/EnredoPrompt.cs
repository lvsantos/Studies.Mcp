using ModelContextProtocol.Server;
using System.ComponentModel;

namespace Studies.MCP.Server.Prompts;

[McpServerPromptType]
public class EnredoPrompt
{
    [McpServerPrompt, Description("Prompt para criação de enredos")]
    public static string BuscarEnredoPrompt(
        string protagonistaNome,
        string antagonistaNome) => @"
        Você é um mestre contador de histórias. Sua tarefa é criar um cenário paara um enredo cativante e original,
        contendo a protagonista que deve ter sua descrição também criada, e o antagonista que também deve ter sua descrição
        criada. O nome do protagonista deve ser " + protagonistaNome + @" e o nome do antagonista deve ser 
        " + antagonistaNome + ". Utilize as tools disponíveis para criar cada personalidade de cada personagem e a " +
        "descrição detalhada do cenário";
}