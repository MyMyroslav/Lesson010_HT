using System;
namespace Lesson010_HT_2
{
    public class Converter
    {
        public decimal usd;
        public decimal eur;
        public decimal zlt;
        public Converter()
        {
        }
        public Converter(decimal usd, decimal eur, decimal zlt)
        {
            this.usd = usd;
            this.eur = eur;
            this.zlt = zlt;
        }
        public void GetInfo()
        {
            Console.WriteLine($"USD: {usd}, EUR: {eur}, ZLT: {zlt}");
        }
        public void FromHrn(decimal grn)
        {
            decimal grnIntoUsd = grn * usd;
            decimal grnIntoEur = grn * eur;
            decimal grnIntoZlt = grn * zlt;
            Console.WriteLine($"Grn {grn} into usd: {grnIntoUsd}, eur:{grnIntoEur}, zlt: {grnIntoZlt}");
        }
        public void FromUsd(decimal usd)
        {
            decimal grn = usd / 28;
            Console.WriteLine($"{usd} usd into grn: {grn}");
        }
        public void FromEur(decimal eur)
        {
            decimal grn = usd / 30;
            Console.WriteLine($"{eur} usd into grn: {grn}");
        }
        public void FromZlt(decimal usd)
        {
            decimal grn = usd / 7;
            Console.WriteLine($"{zlt} usd into grn: {grn}");
        }
    }
}

