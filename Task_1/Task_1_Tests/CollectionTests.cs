using Task_1;

namespace Task_1_Tests
{
    public class CollectionTests
    {
        [Fact]
        public void Ctor()
        {
            var collection = new MyCollection<int>();
            var collection100 = new MyCollection<int>(100);
        }
    }
}