using System;

namespace semana2_aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verifica placa rodizio");
            Console.WriteLine("Digite sua placa: ");
            string placa = Console.ReadLine();

            if(placa == "1" || placa == "2")
                Console.WriteLine("Segunda-Feira");
            else if(placa == "3" || placa == "4")
                Console.WriteLine("Terça-Feira");
            else if(placa == "5" || placa == "6")
                Console.WriteLine("Quarta-Feira");
            else if(placa == "7" || placa == "8")
                Console.WriteLine("Quinta-Feira");
            else if(placa == "9" || placa == "0")
                Console.WriteLine("Sexta-Feira");           
        }
    }
}
