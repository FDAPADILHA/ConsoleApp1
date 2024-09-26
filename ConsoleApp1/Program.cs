using System;
using System.Globalization;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Test Visual Studio 2");
            //<type> <name> = <inicial value> opcional  
            int n = 25;

            /* VARIAVEIS EM C#
             Não pode conter:
             1 - Dígito no começo da variável - ex: int 5filipe
             2 - Não pode conter espaços em branco - ex: int "Filipe Padilha"
             3 - Não usar acentuação - ex: int Âncora 

             Explos de variáveis corretas:
             1 - Pode conter _ - ex: int _Filipe
             2 - int _5Filipe
             3 - int FilipePadilha
             4 - int filipePadilha

             Uma boa prática é seguir o padrão CamelCase*/

            //Escrevendo variáveis em C# na tela
            double x = 10.5243;
            
            //Se eu quiser pular uma linha é "Console.WriteLine"
            Console.WriteLine(x);

            //Se eu quiser imprimir tudo na mesma linha, sem pular uma linha é somente "Console.Write"
            Console.Write(x);
            Console.Write(" Mesma Linha");

            //Se eu quiser alterar o número de casas decimais
            Console.WriteLine("\n");
            Console.WriteLine(x.ToString("F2")); //Aqui está saindo com vírgula por causa da linguagem do Visual Studio em pt-br

            //Se quiser que saia com "." na quebra de casa decimal então eu preciso importar a bb using System.Globalization
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //Como concatenar os elementos
            Console.WriteLine("Troco do pedido é: " + "R$" + x.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
