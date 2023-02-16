using System;

namespace AprendendoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float em c# termina com f
                float ff = 123.123f;
            //var se comporta semelhantemente ao JS 
                var variavel = "aaaaaaa";
            //dynamic parece ser o let do JS, assumindo qualquer valor que for atribuido 
                dynamic dynmc = ff;
                Console.WriteLine(dynmc);
                dynmc = variavel;
                Console.WriteLine(dynmc);
                dynmc = 309;
                Console.WriteLine(dynmc);
            //a utilização de classes funciona semelhantemente ao Java
                Class1 clss = new Class1();
                clss.Funcao();
                Console.ReadLine();
            
            
        }
    }
}
