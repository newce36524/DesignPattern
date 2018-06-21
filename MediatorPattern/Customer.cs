namespace MediatorPattern
{
    public class Customer : ICustomer
    {
        public void Shopping(int AppliancesCount, int GameMachineCount, int Fruits)
        {
            ShoppingMediator.GetShoppingMediator().Shopping(AppliancesCount, GameMachineCount, Fruits);
        }
    }
}
