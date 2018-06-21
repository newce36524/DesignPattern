namespace MediatorPattern
{
    public class Jd : ShoppingBase
    {
        public Jd()
        {
            this.Appliances = new Commodity() { Univalence = 10, Amount = 100 };
            this.GameMachine = new Commodity() { Univalence = 10, Amount = 100 };
            this.Fruits = new Commodity() { Univalence = 10, Amount = 100 };
        }
    }
}
