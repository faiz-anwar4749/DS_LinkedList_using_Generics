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
        [TestMethod]
        public void TestInsert()
        {
            Linked_List list = new Linked_List();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.InsertAtParticularPosition(3, 40);
            Assert.IsTrue(list.Search(40));
        }
    }
}
