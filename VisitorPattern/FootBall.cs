using System;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public class FootBall : BallBase
    {
        public override void Play(BallVisitorBase commonVisitor)
        {
            commonVisitor.PlayFootBall(this);
        }
    }
}
