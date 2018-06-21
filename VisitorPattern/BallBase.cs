using System.Collections.Generic;
using System.Text;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public abstract class BallBase
    {
        public string BallType { get; set; }
        public int Size { get; set; }
        public abstract void Play(BallVisitorBase commonVisitor);
    }
}
