using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._4
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;
        private string article;
        private int quantity;
        private double zPdf, bezPdf;
        private Random random = new Random();

        public string Article
        {
            get { return article; }
        }
        public double ZPDF
        {
            get { return zPdf; }
        }
        public double BezPDF
        {
            get { return bezPdf; }
        }

        public Invoice(int account, string customer, string provider )
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void Paying(int summa, int quantity)
        {
            article = random.Next(1000000, 9999999).ToString();
            bezPdf = summa * quantity;
            zPdf = bezPdf / 0.8;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(2233, "Rozetka", "Dsl");
            invoice.Paying(500, 4);
            Console.WriteLine($"Артикул вашого замовлення: {invoice.Article}");
            Console.WriteLine($"Вартість замовлення з ПДФ: {invoice.ZPDF}");
            Console.WriteLine($"Вартість замовлення без ПДФ: {invoice.BezPDF}");
            Console.ReadLine();
        }
    }
}
