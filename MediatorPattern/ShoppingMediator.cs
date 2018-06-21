using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    public class ShoppingMediator : ICustomer
    {
        Jd jd = new Jd();
        Taobao taobao = new Taobao();
        Tianmao tianmao = new Tianmao();
        static ShoppingMediator _shoppingMediator = new ShoppingMediator();
        ShoppingMediator()
        {
            Console.WriteLine($"京东：家电数量{jd.Appliances.Amount} 游戏机数量{jd.GameMachine.Amount} 水果数量{jd.Fruits.Amount}");
            Console.WriteLine($"淘宝：家电数量{taobao.Appliances.Amount} 游戏机数量{taobao.GameMachine.Amount} 水果数量{taobao.Fruits.Amount}");
            Console.WriteLine($"天猫：家电数量{tianmao.Appliances.Amount} 游戏机数量{tianmao.GameMachine.Amount} 水果数量{tianmao.Fruits.Amount}");
        }
        public static ShoppingMediator GetShoppingMediator() => _shoppingMediator;
        public void Shopping(int AppliancesCount, int GameMachineCount, int Fruits)
        {
            //找三家商城中价格最便宜的买
            ShoppingBase[] shoppingsUnivalenceArr = new ShoppingBase[] { jd, taobao, tianmao };
            ShoppingBase AppliancesShopping = shoppingsUnivalenceArr.OrderBy(x => x.Appliances.Univalence).First();
            ShoppingBase GameMachineShopping = shoppingsUnivalenceArr.OrderBy(x => x.GameMachine.Univalence).First();
            ShoppingBase FruitShopping = shoppingsUnivalenceArr.OrderBy(x => x.Fruits.Univalence).First();

            AppliancesShopping.Appliances.Consume(AppliancesCount);
            GameMachineShopping.GameMachine.Consume(GameMachineCount);
            FruitShopping.Fruits.Consume(Fruits);
            Console.WriteLine($"京东：家电数量{jd.Appliances.Amount} 游戏机数量{jd.GameMachine.Amount} 水果数量{jd.Fruits.Amount}");
            Console.WriteLine($"淘宝：家电数量{taobao.Appliances.Amount} 游戏机数量{taobao.GameMachine.Amount} 水果数量{taobao.Fruits.Amount}");
            Console.WriteLine($"天猫：家电数量{tianmao.Appliances.Amount} 游戏机数量{tianmao.GameMachine.Amount} 水果数量{tianmao.Fruits.Amount}");
        }
    }
}
