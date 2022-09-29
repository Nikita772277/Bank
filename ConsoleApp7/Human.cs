using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Human
    {
        private string _name;//имя
        private int _numbercontribution;//номер счёта
        private decimal _amountmoney;//количество денег(не в банке)
         
        Bank bank= new Bank();
        public Human()
        {
            Random ran= new Random();
            _amountmoney = ran.Next(5000, 100000);
        }
        public void GetMoney()
        {
            Console.WriteLine($"денег: {_amountmoney}");
        }
        public void GetName()// Получить имя
        {
            bank.InformationScore();
        }
        public void DeleteNumberContribution()// Удалить номер счёта
        {

        }
        public void GetContributionNumber()// Получить номер счёта
        {
           
        }
        public void GetAmounmoney()// Получить информацию о количестве денег на счёте
        {

        }
    }
}
