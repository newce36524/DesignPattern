namespace MediatorPattern
{
    public class Tianmao : ShoppingBase
    {
        public Tianmao()
        {
            this.Appliances = new Commodity() { Univalence = 33, Amount = 123 };
            this.GameMachine = new Commodity() { Univalence = 12, Amount = 241 };
            this.Fruits = new Commodity() { Univalence = 5, Amount = 152 };
        }
    }
}
