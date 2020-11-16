using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Linked_List list = new Linked_List();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }
    }
}
