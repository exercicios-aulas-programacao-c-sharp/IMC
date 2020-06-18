using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pesoEmKg;
            decimal alturaEmM;
            decimal imc;

            string situacao;

            string pesoEmKgDigitado;
            string alturaEmMDigitado;

            Console.WriteLine("-- Calculadora de IMC --");
            Console.WriteLine();

            Console.Write("Digite seu peso em kg...: ");
            pesoEmKgDigitado = Console.ReadLine();

            if (!Decimal.TryParse(pesoEmKgDigitado, out pesoEmKg)){
               ConsoleColor cor = Console.ForegroundColor;
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine($"O peso digitado \"{pesoEmKgDigitado}\" não é um número válido.");
               Console.ForegroundColor = cor;
               Environment.Exit(1);
            }

            Console.Write("Digite sua altura em m..: ");
            alturaEmMDigitado = Console.ReadLine();

            if (!Decimal.TryParse(alturaEmMDigitado, out alturaEmM)){
               ConsoleColor cor = Console.ForegroundColor;
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine($"A altura digitada \"{alturaEmMDigitado}\" não é um número válido.");
               Console.ForegroundColor = cor;
               Environment.Exit(1);
            }            

            imc = pesoEmKg / (alturaEmM * alturaEmM) ;

            if (imc < 17m){
                situacao = "Muito abaixo do peso";
            }else if (imc < 18.5m){
               situacao = "Abaixo do peso";     
            }else if (imc < 25m){
               situacao = "Peso normal";    
            }else if (imc < 30m){
               situacao = "Acima do peso";   
            }else if (imc < 35m){
               situacao = "Obesidade I";  
            }else if (imc < 40m){
               situacao = "Obesidade II (severa)";     
            }else {
               situacao = "Obesidade III (mórbida)";     
            }

            Console.WriteLine();
            Console.WriteLine($"Seu IMC é {imc:N2} kg/m²");
            Console.WriteLine($"Diagnóstico: {situacao}");

        }
    }
}
