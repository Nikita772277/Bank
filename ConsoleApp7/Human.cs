    using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public Human(decimal amountmoney)
        {
            _amountmoney = amountmoney;
            //_amountmoney = 15000;
           
        }
        public Human()
        {

        }
        public void GetMoney()
        {
            Console.WriteLine($"денег: {_amountmoney}");
        }
        public void SetMoney(decimal amountmoney)
        {
            _amountmoney=amountmoney;
        }
        public void SetName()
        {
            Console.WriteLine($"Введите имя");
            string name = Console.ReadLine();
            _name = name;
        }
        public void GetName()// Получить имя
        {
            Console.WriteLine($"имя владельца счёта: {_name}");
        }
        public void DeleteNumberContribution()// Удалить номер счёта
        {
           bank.DeleteNumberContribution();
        }
        public void GetContributionNumber()// Получить номер счёта
        {
            Console.WriteLine($"{_numbercontribution}");
        }
        public void Aakgh(decimal a)
        {
            _amountmoney = _amountmoney + a;
        }
        public decimal GetAmounMoney()// Получить информацию о количестве денег с собой
        {
            return _amountmoney;
        }
        public decimal CalculationOfFunds()
        {
            _amountmoney = _amountmoney - bank.MinContribution();
            Console.WriteLine($"У вас осталось: {_amountmoney}");
            return _amountmoney;
        }
    }
}
