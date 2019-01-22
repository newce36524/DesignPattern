using System;
using System.Linq;

namespace CompositePattern
{
    public class Class1
    {
        public void SHow()
        {
            var data = TreeDataProvider.CreateTreeItemList();

            data.GroupBy(t => t.ParentId).;

        }
    }
}
