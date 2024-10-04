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

            //Conceito de Casting: Para você definir no C# que precisa converter a variável
            int a;
            double b;
            b = 5.0;
            a = (int) b;

            Console.WriteLine("\n" + "Casting para INT (de DOUBLE para INT): " + a);

            //Casting de int para double
            int c;
            double r;
            c = 2;
            a = 5;
            //O casting vai antes da operação de divisão
            r = (double) a / c;

            Console.WriteLine("\n" + "Casting para double (de int para double): " + r);

            //Comando para entrada de dados
            string frase = Console.ReadLine();

            Console.WriteLine("Você digitou: " + frase);

            //Entrada de dados com vetor string comando split para a cada espaço gravar no vetor "vet"
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p0 = vet[0];
            string p1 = vet[1];
            string p2 = vet[2];
            //Para imprimir igual eu preciso colocar cada posição do vetor que guardou a informação
            Console.WriteLine("Você escreveu a frase: " + p0 + " " + p1 + " " + p2);

            //Para fazer uma entrada como número inteiro: Fazer a conversão com Parse
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você colocou o número inteiro: " + n1);
            //Log de erro se a entrada for string numa variável int:
            /*Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
            at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
            at System.Int32.Parse(String s)
            at Primeiro.Program.Main(String[] args) in C:\Users\filipe.padilha\source\repos\ConsoleApp1\ConsoleApp1\Program.cs:line 80*/

            //Outras conversões para salvar em variável:

            char c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o char: " + c);

            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o double: " + d);

            //e também em vetor:
            string[] vet2 = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char idade = char.Parse(vet[1]);
            int numSorte = int.Parse(vet[2]);
            double salario = double.Parse(vet[3]);

            Console.WriteLine("Suas informações: " + "Nome: " + nome + "\nIdade: " + idade + "\nNúmero da Sorte: " + numSorte + "\nSalário: R$" + salario);

        }
    }
}
