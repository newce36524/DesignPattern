using System;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public class BasketBall : BallBase
    {
        public override void Play(BallVisitorBase commonVisitor)
        {
            commonVisitor.PlayBasketBall(this);
        }
    }
}
