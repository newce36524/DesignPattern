using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Composite
    {

        public IEnumerable<Composite> Composites { get; set; }

    }

    public class Branch
    {

    }
}
