using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {


        [Test]
        public void Test_Collection_EmptyConstructor() {  

            //ARRANGE and ACT
            var coll = new Collection<int>();

            //ASSERT
            Assert.AreEqual(coll.ToString(), "[]");           

        }

        [Test]
        public void Test_Collection_ConstructorSingleItem() 
        {
        var coll = new Collection<int>(5);
            Assert.AreEqual(coll.ToString(), "[5]");
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems() 
        {
            var coll = new Collection<int>(5, 6);
            Assert.AreEqual(coll.ToString(), "[5, 6]");
        }

        [Test]
        public void Test_Collection_CountAndCapacity() 
        {
            var coll = new Collection<int>(5, 6);

            //ASSERT
            Assert.AreEqual(coll.Count, 2);
            Assert.That(coll.Capacity, Is.GreaterThan(coll.Count));
        }


        [Test]
        public void Test_Collection_Add()
        {
            //ARRANGE
            
            var coll = new Collection<string>("Ivan", "Georgi");

            //ACT
            
            coll.Add("Stefan");

            //ASSERT

            Assert.AreEqual(coll.ToString(), "[Ivan, Georgi, Stefan]");

        }

        [Test]
        public void Test_GetByInvalidIndex() 
        {
            var coll = new Collection<int>(5, 6, 7);
            var item = coll[1];

            Assert.That(item.ToString(), Is.EqualTo("6"));
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);
            coll[1] = 666;

            Assert.That(coll.ToString(), Is.EqualTo("[5, 666, 7]"));
        }

        [Test]
        public void Test_Collection_GetByInvalidIndex() 
        {
        //ARRANGE
        var coll = new Collection<string>("Ivan", "Stefan");
            Assert.That(() => { var item = coll[2]; }, Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

    }
}