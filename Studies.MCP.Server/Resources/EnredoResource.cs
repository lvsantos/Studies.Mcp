using ModelContextProtocol.Server;
using System.ComponentModel;

namespace Studies.Mcp.Resource.Resources;

[McpServerResourceType]
public class EnredoResource
{
    [McpServerResource, Description("Recurso para buscar o que é essencial na construção de um enredo")]
    public static string BuscarEnredoResource() => @"
        ## Estrutura Essencial de um Enredo

        1.  **Premissa Clara:** Qual é a ideia central da sua história? Uma premissa forte e concisa serve como âncora 
        para o desenvolvimento.
        2.  **Personagens Cativantes:** Crie personagens com motivações claras, falhas e qualidades que os tornem 
        realistas e com os quais o público possa se identificar ou se interessar.
        3.  **Conflito Envolvente:** O que seus personagens desejam e quais obstáculos eles enfrentam para alcançar seus 
        objetivos? O conflito é o motor da narrativa.
        4.  **Estrutura Narrativa Sólida:** Um começo, meio e fim bem definidos, com um arco de desenvolvimento para os 
        personagens e a trama. Pense em pontos de virada, clímax e resolução.
        5.  **Tema Significativo:** Qual mensagem ou exploração mais profunda sua história oferece? Um tema bem trabalhado 
        adiciona camadas de significado.
        6.  **Ambientação Imersiva:** Onde e quando a história se passa? Um cenário detalhado e bem descrito pode se 
        tornar quase um personagem em si.
        ---
        ## Gêneros de Enredo Populares

        A escolha do gênero definirá o tom, a atmosfera e as expectativas do público. Abaixo, alguns exemplos comuns:

        * **Infantil:** Foco em aprendizado, amizade, moralidade e aventura. Linguagem simples e temas leves.
        * **Terror:** Explora o medo, o suspense, o sobrenatural ou o psicológico. Busca gerar tensão e apreensão.
        * **Comédia:** Visa o humor e o riso, utilizando situações absurdas, diálogos espirituosos ou personagens 
        excêntricos.
        * **Drama:** Concentra-se em conflitos emocionais, realismo e desenvolvimento de personagens, explorando temas 
        sérios e relacionamentos complexos.
        * **Aventura:** Envolve jornadas, descobertas, perigos e exploração, muitas vezes em cenários exóticos.
        * **Ficção Científica:** Aborda temas como tecnologia avançada, espaço, futuro e suas implicações sociais e 
        filosóficas.
        * **Fantasia:** Apresenta elementos mágicos, seres míticos e mundos imaginários, muitas vezes com lutas entre o 
        bem e o mal.
        * **Romance:** Explora relacionamentos amorosos, seus desafios e a busca pela conexão emocional.

        ---

        ## Elementos Adicionais a Considerar

        Além da estrutura e do gênero, outros recursos podem enriquecer seu prompt e, consequentemente, o enredo:

        * **Público-alvo:** Para quem você está escrevendo? Isso influenciará a linguagem, a complexidade e os temas.
        * **Tom:** O tom pode variar dentro de um gênero (ex: comédia romântica vs. comédia pastelão).
        * **Estilo de Escrita:** Você prefere descrições detalhadas, diálogos rápidos, narração em primeira ou terceira 
        pessoa?
        * **Mensagem ou Moral:** O que você quer que o público leve da sua história?";
}