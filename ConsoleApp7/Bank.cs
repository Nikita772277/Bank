using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private bool _truthfulnessscore=false;
        public Bank()
        {
            _contribution = 10000;
            _about = 5;
        }
        public bool OpenScore() //открыть счёт
        {
            Human human = new Human();
            Console.Write($"денег с собой: ");
            string a = Console.ReadLine();
            decimal amountmoney = decimal.Parse(a);
            human.SetMoney(amountmoney);
            Human human1 = new Human(amountmoney);
            if (human.GetAmounMoney() > _contribution)
            {
                _truthfulnessscore = false;
                human1.SetName();
                Random ran = new Random();
                for (int i = 0; i < _score.Length; i++)
                {
                    _score[i] = ran.Next(0, 9);
                }
                Console.WriteLine();
                Console.WriteLine($"Счёт открыт");
                _moneyintheaccount = _moneyintheaccount + _contribution;
                human1.CalculationOfFunds();
                    GetScore();
                return  true;
                
            }
         else
            {
                Console.WriteLine();
                Console.WriteLine($"недостаточно средств для открытия счёта");
                Console.WriteLine();
               return false;
            }
            
        }
        public void GetScore()//выовд номера счёта
        {
            
            if (_truthfulnessscore = true)
            {
                Console.Write($"Номер счёта: ");
            foreach (int i in _score)
            {
                Console.Write($"{i}"); //номер открытого счёта
            }
            Console.WriteLine();
            Console.WriteLine();
            }
           else 
            {
                Console.WriteLine();
                Console.WriteLine($"У вас нет номера счёта");
                Console.WriteLine();
            }
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
            Human human=new Human();
            Console.WriteLine($"Сколько снять");
            string mone = Console.ReadLine();
            decimal moneu=decimal.Parse(mone);
            
            if (_moneyintheaccount >= moneu)
            {
_moneyintheaccount = _moneyintheaccount - moneu;
            human.Aakgh(moneu);
                Console.WriteLine($"деньги сняты");
                Console.WriteLine($"на счёте осталось: {_moneyintheaccount}") ;
            }
            else if (_moneyintheaccount < moneu)
            {
                Console.WriteLine($"на счёте недостаточно средств");
            }
            else
            {
                Console.WriteLine($"непредвиденная ошибка");
            }
        }
        public void SummScore() //сумма через год
        {
            decimal moneymonth = _moneyintheaccount * _about/100;
            decimal ayearlater = _moneyintheaccount + moneymonth * 12;
            Console.WriteLine();
            Console.WriteLine($"через год {ayearlater}");
            Console.WriteLine();
        }
        public void DeleteNumberContribution()
        {
            Console.WriteLine($"Вы уверены 1.да 2.нет");
            string a=Console.ReadLine();
            int b=int.Parse(a);
            if (b == 1)
            {
                foreach (int i in _score)
                {
                    _score[i] = 0;
                }
            }
            else if (b == 2)
            {
                Console.WriteLine();
            }
            //if (true == _truthfulnessscore)
            //{
            //    foreach (int i in _score)
            //    {
            //        _score[i] = 0;
            //    }
            //}
            //else if (false == _truthfulnessscore)
            //{
            //    Console.WriteLine($"ошибка");
            //}
        }
        public int MinContribution()
        {
            return _contribution;
        }
    }
}
