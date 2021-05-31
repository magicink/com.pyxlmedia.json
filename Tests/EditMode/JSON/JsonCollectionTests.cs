using System.Linq;
using NUnit.Framework;
using PyxlMedia.JSON;

namespace Tests.EditMode.JSON
{
    public class JsonCollectionTests
    {
        [Test]
        public void FromJsonTests()
        {
            var result = JsonCollection.FromJson<TestItem>("[{\"id\":\"test1\"}, {\"id\":\"test2\"}]");
            var list = result.ToList();
            Assert.That(list.Count, Is.EqualTo(2));
            var item = list.Where(i => i.id == "test2");
            Assert.That(item, Is.Not.EqualTo(null));
            var invalidItem = list.Where(i => i.id == "test0");
            Assert.That(invalidItem, Is.Empty);
        }
    }
}
