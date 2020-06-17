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

            Console.WriteLine("-- Calculadora de IMC --");
            Console.WriteLine();

            Console.Write("Digite seu peso em kg...: ");
            pesoEmKg = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite sua altura em m..: ");
            alturaEmM = Convert.ToDecimal(Console.ReadLine());

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
