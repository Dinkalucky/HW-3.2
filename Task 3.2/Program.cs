using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    public class Converter
    {
        private double usd, eur, rub;
        private char sign = '*';
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void Convert(int money, string valuta1, string valuta2)
        {
            if (valuta1 != "uah")
            {
                Console.Write($"{money} {valuta1} = ");
                switch (valuta1)
                {
                    case "usd":
                        Console.WriteLine($"{money * usd} грн");
                        break;
                    case "eur":
                        Console.WriteLine($"{money * eur} грн");
                        break;
                    case "rub":
                        Console.WriteLine($"{money * rub} грн");
                        break;
                }
            }
            else
            {
                Console.Write($"{money} {valuta1} = ");
                switch (valuta2)
                {
                    case "usd":
                        Console.WriteLine($"{money / usd} {valuta2}");
                        break;
                    case "eur":
                        Console.WriteLine($"{money / eur} {valuta2}");
                        break;
                    case "rub":
                        Console.WriteLine($"{money / rub} {valuta2}");
                        break;
                }
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            string valuta1;
            string valuta2;
            Converter converter = new Converter(36.6, 39.2, 0.5);
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Яку суму ви хотіли б конвертувати?");
                Int32.TryParse(Console.ReadLine(), out money);

                Console.WriteLine("З якої валюти? (usd, eur, rub, uah)");
                valuta1 = Console.ReadLine();

                if (valuta1 == "uah")
                {
                    Console.WriteLine("В яку валюту? (usd, eur, rub)");
                    valuta2 = Console.ReadLine();
                }
                else
                {
                    valuta2 = "uah";
                }

                converter.Convert(money, valuta1, valuta2);
            }
            
        }
    }
}
