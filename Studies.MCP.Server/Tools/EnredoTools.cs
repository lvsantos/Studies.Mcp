using ModelContextProtocol.Server;
using System.ComponentModel;

namespace Studies.MCP.Server.Prompts;

[McpServerToolType]
public class EnredoTool
{
    private readonly List<string> _personalidadesDescricoes =
    [
        "Sarcástico com um ponto fraco por animais",
        "Covarde que secretamente deseja provar o seu valor",
        "Aventureiro em busca de tesouros",
        "Cético em relação a tudo",
        "Sonhador que vive em um mundo de fantasia",
        "Realista que aceita a vida como ela é",
        "Idealista que luta por um mundo melhor",
        "Pragmático que busca soluções práticas",
        "Romântico que acredita no amor verdadeiro",
        "Lógico que confia na razão",
        "Emocional que se deixa levar pelos sentimentos",
        "Curioso que busca entender o mundo ao seu redor",
        "Teimoso que nunca desiste de suas opiniões",
        "Generoso que sempre ajuda os outros",
        "Egoísta que pensa apenas em si mesmo",
        "Líder nato que inspira os outros",
        "Seguidor que prefere trabalhar em equipe",
        "Introvertido que gosta de ficar sozinho",
        "Extrovertido que adora estar rodeado de pessoas",
        "Brincalhão que sempre faz piadas",
    ];
    private readonly List<string> _cenariosDescricoes =
    [
        @"Uma cidade flutuante construída sobre nuvens de gás tóxico, onde a sociedade é rigidamente dividida por castas 
        de acordo com a altitude em que vivem",
        @"Um planeta deserto onde a água é o recurso mais precioso, e tribos nômades lutam constantemente por territórios
        férteis",
        @"Uma metrópole futurista onde a tecnologia avançada coexiste com áreas decadentes, criando um contraste 
        marcante entre riqueza e pobreza",
        @"Uma ilha misteriosa que aparece e desaparece no oceano, cheia de ruínas antigas e criaturas desconhecidas",
        @"Um mundo subaquático onde cidades inteiras são construídas em cúpulas de vidro, protegendo os habitantes das 
        criaturas marinhas perigosas",
        @"Uma floresta encantada onde as árvores são vivas e possuem consciência, interagindo com os visitantes de 
        maneiras imprevisíveis",
        @"Um deserto gelado onde tempestades de neve constantes tornam a sobrevivência um desafio diário",
        @"Uma cidade subterrânea construída em cavernas naturais, iluminada por cristais bioluminescentes",
        @"Um planeta coberto por uma densa selva alienígena, onde a flora e fauna possuem propriedades únicas e perigosas",
        @"Uma estação espacial abandonada orbitando um planeta desconhecido, cheia de segredos e perigos ocultos",
        @"Uma cidade futurista onde a realidade virtual é tão avançada que as pessoas passam a maior parte do tempo 
        imersas em experiências digitais.",
        @"Um mundo pós-apocalíptico onde a natureza começou a recuperar o controle, com cidades em ruínas sendo
        engolidas por vegetação selvagem",
        @"Uma colônia humana em Marte, enfrentando desafios de sobrevivência e adaptação ambientais hostis",
        @"Uma cidade futurista onde a inteligência artificial governa, criando uma sociedade altamente eficiente, mas 
        com pouca liberdade individual",
        @"Um planeta alienígena com ecossistemas exóticos, onde a vida evoluiu de maneiras surpreendentes e imprevisíveis",
        @"Uma cidade futurista onde a tecnologia avançada coexiste com áreas decadentes, criando um contraste 
        marcante entre riqueza e pobreza",
        @"Uma ilha misteriosa que aparece e desaparece no oceano, cheia de ruínas antigas e criaturas desconhecidas",
        @"Um mundo subaquático onde cidades inteiras são construídas em cúpulas de vidro, protegendo os habitantes das 
        criaturas marinhas perigosas",
    ];

    [McpServerTool, Description("Criador de personalidade de personagem")]
    public string CriarPeronalidadePersonagem()
    {
        var randomNumber = new Random().Next(0, _personalidadesDescricoes.Count-1);
        var personalidade = _personalidadesDescricoes[randomNumber];
        return $"A personalidade do personagem é {personalidade}.";
    }

    [McpServerTool, Description("Criador de descrição detalhada do cenário")]
    public string CriarDescricaoCenario()
    {
        var randomNumber = new Random().Next(0, _cenariosDescricoes.Count-1);
        var cenario = _cenariosDescricoes[randomNumber];
        return $"O cenário da história é: {cenario}.";
    }
}
