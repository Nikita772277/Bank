using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Bank
    {
        private string _name; // название банка
        private decimal _moneyintheaccount;//денег на счёте
        private int _contribution;//мин взнос
        private int _about;//процент по вкладу
        private int[] _score=new int[20];//номер счёта
        public Bank()
        {
            _contribution = 10000;
            _about = 5;
        }
        public void OpenScore() //открыть счёт
        {
           Human human = new Human();
            human.SetName();
            Random ran = new Random();
            for (int i=0; i< _score.Length; i++)
            {
                _score[i] = ran.Next(0,9);
            }
            Console.WriteLine();
            GetScore();
        }
        public void GetScore()//выовд номера счёта
        {
            Console.Write($"Номер счёта: ");
            foreach (int i in _score)
            {
                Console.Write($"{i}"); //номер открытого счёта
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void ReplenishScore() //пополнить счёт
        {
            Console.WriteLine();
            Console.WriteLine($"Введите сумму пополнения");
            string moneyccount = Console.ReadLine();
            decimal moneyintheaccount = Convert.ToDecimal(moneyccount);
            _moneyintheaccount = _moneyintheaccount + moneyintheaccount;
        }
        public void InformationScore() //посмотреть инф о счёте
        {
            Human human = new Human();
            human.GetName();//имя владельца счёта
            GetScore();//номер счёта
            Console.WriteLine($"Денег на счёте: {_moneyintheaccount}");
            Console.WriteLine($"Процент по вкладу: {_about}");
            
        }
        public void CloseScore() //закрыть счёт
        {

        }
        public void WithdrawMoney() //снять деньги
        {

        }
        public void SummScore() //сумма через год
        {

        } 
    }
}
