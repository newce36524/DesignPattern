using System;

namespace VisitorPattern.Visitor
{
    public class NewVisitor : BallVisitorBase
    {
        public override void PlayBasketBall(BasketBall ballType)
        {
            Console.WriteLine("篮球是用来踢的");
        }

        public override void PlayFootBall(FootBall ballType)
        {
            Console.WriteLine("足球是用来打的");
        }
    }
}
