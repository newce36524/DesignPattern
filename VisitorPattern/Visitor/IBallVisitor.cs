using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.Visitor
{
    public abstract class BallVisitorBase
    {
         public abstract void PlayBasketBall(BasketBall ballType);

        public abstract void PlayFootBall(FootBall ballType);
    }
}
