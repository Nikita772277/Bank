using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Human
    {
        private string _name;//имя
        private int _numbercontribution;//номер счёта
        private decimal _amountmoney;//количество денег(не в банке)
        private bool _checMoney = false;

        Bank bank = new Bank();
        public Human()
        {

        }
        public void GetMoney(Human human)
        {
            if (_checMoney == true)
            {
                Console.WriteLine($"Денег: {_amountmoney}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Сначала откройти счёт в банке");
                Console.WriteLine();
            }
        }
        public void SetMoney(decimal amountmoney)
        {
            _amountmoney = amountmoney;
            _checMoney = true;

        }
        public void SetName()
        {
            Console.Write($"Введите ваше имя:");
            string name = Console.ReadLine();
            _name = name;
            Console.WriteLine();
        }
        public void GetName(Human human)// Получить имя
        {
            Console.WriteLine($"Имя владельца счёта: {_name}");
            Console.WriteLine();
        }
        public void DeleteNumberContribution(Human human)// Удалить номер счёта
        {
            bank.DeleteScore(human);
        }
        public void GetContributionNumber(Human human)// Получить номер счёта
        {
            Console.WriteLine($"{_numbercontribution}");
            Console.WriteLine();
        }
        public void WithdrawalOfMoney(decimal a, Human human)//снятие с счёта
        {
            _amountmoney = _amountmoney + a;
        }
        public void EnteringMoney(decimal a, Human human)//внесение на счёт
        {
            _amountmoney -= a;
        }
        public decimal GetAmounMoney(Human human)// Получить информацию о количестве денег с собой
        {
            return _amountmoney;
        }
        public decimal CalculationOfFunds(Human human)
        {
            _amountmoney = _amountmoney - bank.MinContribution(human);
            Console.WriteLine($"У вас осталось: {_amountmoney}");
            Console.WriteLine();
            return _amountmoney;
        }
    }
}
