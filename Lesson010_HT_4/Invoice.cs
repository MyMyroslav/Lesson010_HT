using System;
namespace Lesson010_HT_4
{
    public class Invoice
    {
        public int account;
        public string customer;
        public string provider;
        private string article;
        private int quantity;
        public Invoice()
        {
        }
        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{account}, {customer}, {provider}, {article}, {quantity}");
        }
        public void payWithPDV(string thing)
        {
            if (thing == "Bag")
            {
                double payment = 2000 * 0.15;
                Console.WriteLine($"Bag with pdv - 0.15 cost: {payment}");
            }
            else if (thing == "Shirt")
            {
                double payment = 1350 * 0.12;
                Console.WriteLine($"Shirt with pdv - 0.12 cost: {payment}");
            }
        }
        public void payWithoutPDV(string thing)
        {
            if (thing == "Bag")
            {
                double payment = 2000;
                Console.WriteLine($"Bag without pdv cost: {payment}");
            }
            else if (thing == "Shirt")
            {
                double payment = 1350 * 0.12;
                Console.WriteLine($"Bag without pdv cost: {payment}");
            }
        }
    }
}

