using System;

namespace VisitorPattern.Visitor
{
    public class OldVisitor : BallVisitorBase
    {
        public override void PlayBasketBall(BasketBall ballType)
        {
            Console.WriteLine("篮球是用来打的");
        }

        public override void PlayFootBall(FootBall ballType)
        {
            Console.WriteLine("足球是用来踢的");
        }
    }
}
