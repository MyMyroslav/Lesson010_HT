using System;

namespace Lesson010_HT_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(2, "Myroslav", "Lviv`s shop", "Gucci", 12);
            Invoice invoice2 = new Invoice(7, "Oleh", "Kyiv`s shop", "LV", 74);
            invoice1.GetInfo();
            invoice1.payWithPDV("Bag");
            invoice1.payWithPDV("Shirt");
            invoice2.GetInfo();
            invoice2.payWithoutPDV("Shirt");
            invoice2.payWithoutPDV("Bag");
        }
    }
}
