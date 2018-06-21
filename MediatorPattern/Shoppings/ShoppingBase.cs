using System;

namespace MediatorPattern
{
    public class ShoppingBase
    {
        public Commodity Appliances { get; set; }
        public Commodity GameMachine { get; set; }
        public Commodity Fruits { get; set; }

    }
    public class Commodity
    {
        /// <summary>
        /// 商品单价
        /// </summary>
        public int Univalence { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int Amount { get; set; }
        public void Consume(int Count)
        {
            this.Amount -= Count;
        }
    }
}
