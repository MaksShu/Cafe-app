using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozraha
{
    public interface IBuilder
    {
        void Reset();
        void AddType(string type);
        void AddFirstAdd();
        void AddSecondAdd();
        void AddThirdAdd();
        void AddFourthAdd();
        void AddSugar();
        void AddSubType(string subType);
        Drink GetResult();
    }

    class TeaBuilder : IBuilder
    {
        private Drink _drink = new Drink();

        public void AddFirstAdd()
        {
            _drink.Add("Mint");
        }

        public void AddSecondAdd()
        {
            _drink.Add("Lemon");
        }

        public void AddThirdAdd()
        {
            _drink.Add("Orange");
        }

        public void AddFourthAdd()
        {
            _drink.Add("Milk");
        }

        public void AddSugar()
        {
            _drink.Add("Sugar");
        }

        public void AddType(string type)
        {
            _drink.Type = type;
        }

        public void AddSubType(string subType)
        {
            _drink.SubType = subType;
        }

        public Drink GetResult()
        {
            return _drink;
        }

        public void Reset()
        {
            _drink = new Drink();
        }
    }

    class CoffeeBuilder : IBuilder
    {
        private Drink _drink = new Drink();

        public void AddFirstAdd()
        {
            _drink.Add("Cinnamon");
        }
        public void AddSecondAdd()
        {
            _drink.Add("Chocolate");
        }
        public void AddThirdAdd()
        {
            _drink.Add("Marshshmallows");
        }

        public void AddFourthAdd()
        {
            _drink.Add("Vanilla");
        }     

        public void AddSugar()
        {
            _drink.Add("Sugar");
        }

        public void AddSubType(string subType)
        {
            _drink.SubType = subType;
        }

        public void AddType(string type)
        {
            _drink.Type = type;
        }

        public Drink GetResult()
        {
            return _drink;
        }

        public void Reset()
        {
            _drink = new Drink();
        }
    }

    class PriceCounter {
        public int FindPrice(List<string> comps, bool isSugar, string type) {
            int price = 0;
            int addPrice = 0;
            if (type == "Coffee") {
                addPrice = 20;
                price += 80;
            }
            else
            {
                addPrice = 15;
                price += 40;
            }
            price += comps.Count * addPrice;
            price += (isSugar ? 1 : 0) * 10;
            return price;
        }
    }

    public class Drink
    {     
        public string Type { get; set; }
        public string SubType { get; set; }
        public int Price { get; set; }

        private List<string> _comps = new List<string>();
        
        public void Add(string part) { 
            _comps.Add(part);
        }
        public List<string> GetInfo() { 
            return _comps;
        }

        public void CalcPrice()
        {
            PriceCounter count = new PriceCounter();
            this.Price = count.FindPrice(_comps, _comps.Count>0&&_comps[0]=="Sugar"?true:false, Type);
        }        

    }

    public class Director { 
        public void Make(IBuilder builder, Dictionary<string, bool> adds, bool isSugar, string type, string subType)
        {
            builder.Reset();
            builder.AddType(type);
            builder.AddSubType(subType);  

            if (isSugar)
            {
                builder.AddSugar();
            }
            
            if (adds["First"]) 
            {
                builder.AddFirstAdd();
            }

            if (adds["Second"])
            {
                builder.AddSecondAdd();
            }

            if (adds["Third"])
            {
                builder.AddThirdAdd();
            }

            if (adds["Fourth"])
            {
                builder.AddFourthAdd();
            }

        }
    }

    public interface ICounter
    {
        int FindPrice(int type, int size);
    }

    public class SimpleCounter : ICounter
    {
        public int FindPrice(int type, int size)
        {
            int price = 0;
            switch (type)
            {
                case 0:
                    price += 90;
                    break;
                case 1:
                    price += 120;
                    break;
                case 2:
                    price += 60;
                    break;
                case 3:
                    price += 50;
                    break;
                default:
                    break;
            }
            return price * size;
        }
    }

    public class SaleCounter : ICounter
    {
        public int FindPrice(int type, int size)
        {
            int price = 0;
            switch (type)
            {
                case 0:
                    price += 70;
                    break;
                case 1:
                    price += 80;
                    break;
                case 2:
                    price += 40;
                    break;
                case 3:
                    price += 35;
                    break;
                default:
                    break;
            }
            return price * size;
        }
    }

    public class Food
    {
        private readonly ICounter _counter;

        public int Type { get; set; }

        public int Size { get; set; }

        public int Price { get; set; }

        public Food(ICounter counter, int type, int size)
        {
            _counter = counter;
            Type = type;
            Size = size;
        }

        public void FindPrice()
        {
            Price =  _counter.FindPrice(type: Type,size: Size);
        }
    }
}
