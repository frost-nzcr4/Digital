using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests
{
    public class ItemsTests
    {
        [Theory]
        [InlineData("Каменный нож", "Самодельный каменный нож.\nУрон: +1", 0, 1, 1)]
        public void Items(string name, string text, int value, int maxValue, int type)
        {
            Items item = new Items(name, text, value, maxValue, type);
            Assert.Equal(name, item.name);
            Assert.Equal(text, item.text);
            Assert.Equal(value, item.value);
            Assert.Equal(maxValue, item.maxValue);
            Assert.Equal(type, item.type);
            Assert.Equal(0, item.equip);
        }

        [Theory]
        [InlineData("Каменный нож", "Самодельный каменный нож.\nУрон: +1", 0, 1, 1)]
        public void ItemAdd(string name, string text, int value, int maxValue, int type)
        {
            Items item = new Items(name, text, value, maxValue, type);
            item.ItemAdd();
			Assert.Equal(value + 1, item.value);
			item.ItemAdd();
			Assert.Equal(value + 1, item.value);
        }

        [Theory]
        [InlineData("Каменный нож", "Самодельный каменный нож.\nУрон: +1", 1, 1, 1)]
        public void ItemMinus(string name, string text, int value, int maxValue, int type)
        {
            Items item = new Items(name, text, value, maxValue, type);
            item.ItemMinus();
			Assert.Equal(value - 1, item.value);
			item.ItemMinus();
			Assert.Equal(0, item.value);
        }
    }
}
