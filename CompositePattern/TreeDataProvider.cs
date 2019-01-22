using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class TreeDataProvider
    {
        public static IEnumerable<TreeItem> CreateTreeItemList()
        {
            var result = new List<TreeItem>() {
                new TreeItem { Id=1,Content="顶层数据"},
                new TreeItem { Id=2,ParentId=1,Content="测试数据"},
                new TreeItem { Id=3,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=4,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=5,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=6,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=7,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=8,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=9,ParentId=1,Content="第二层数据"},
                new TreeItem { Id=10,ParentId=2,Content="第三层数据"},
                new TreeItem { Id=11,ParentId=2,Content="第三层数据"},
                new TreeItem { Id=12,ParentId=2,Content="第三层数据"},
                new TreeItem { Id=13,ParentId=2,Content="第三层数据"},
                new TreeItem { Id=14,ParentId=2,Content="第三层数据"},
                new TreeItem { Id=15,ParentId=10,Content="测试数据"},
                new TreeItem { Id=16,ParentId=3,Content="测试数据"},
                new TreeItem { Id=17,ParentId=3,Content="测试数据"},
                new TreeItem { Id=18,ParentId=3,Content="测试数据"},
                new TreeItem { Id=19,ParentId=3,Content="测试数据"},
                new TreeItem { Id=20,ParentId=3,Content="测试数据"},
                new TreeItem { Id=21,ParentId=4,Content="测试数据"},
                new TreeItem { Id=22,ParentId=15,Content="测试数据"},
                new TreeItem { Id=23,ParentId=4,Content="测试sss数据"},
                new TreeItem { Id=24,ParentId=4,Content="测试sss数据"},
                new TreeItem { Id=25,ParentId=4,Content="测试sss数据"},
                new TreeItem { Id=26,ParentId=4,Content="测试sss数据"},
                new TreeItem { Id=27,ParentId=4,Content="测试sss数据"},
                new TreeItem { Id=28,ParentId=5,Content="测试sss数据"},
                new TreeItem { Id=29,ParentId=5,Content="测试sss数据"},
                new TreeItem { Id=30,ParentId=5,Content="测试sss数据"},
                new TreeItem { Id=31,ParentId=2,Content="测试sss数据"},
                new TreeItem { Id=32,ParentId=5,Content="测试sss数据"},
                new TreeItem { Id=33,ParentId=3,Content="测试sss数据"},
                new TreeItem { Id=34,ParentId=3,Content="测试sss数据"},
                new TreeItem { Id=35,ParentId=3,Content="测试sss数据"},
                new TreeItem { Id=36,ParentId=3,Content="测试sss数据"},
            };
            return result;
        }
    }
    public class TreeItem
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Content { get; set; }
        public TreeItem GetParentTree()
        {

        }
    }

}
