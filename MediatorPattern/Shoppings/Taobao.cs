namespace MediatorPattern
{
    public class Taobao : ShoppingBase
    {
        public Taobao()
        {
            this.Appliances = new Commodity() { Univalence = 15, Amount = 200 };
            this.GameMachine = new Commodity() { Univalence = 20, Amount = 200 };
            this.Fruits = new Commodity() { Univalence = 11, Amount = 300 };
        }
    }
}
