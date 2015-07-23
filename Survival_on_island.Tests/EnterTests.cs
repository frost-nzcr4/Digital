using System.Collections.Generic;  // IEnumerable
using Xunit;
using Xunit.Extensions;

namespace Survival_on_island.Tests
{
    public class EnterTests
    {
        [Fact]
        public void EnterCreation()
        {
            Enter form = new Enter();
            Assert.Equal("Enter", form.Name);
        }

        [Fact]
        public void Enter2()
        {
            Assert.True(false);
        }

        [Theory]
        [InlineData("foo", "bar")]
        public void TestMethod(string data1, string data2)
        {
            Assert.Equal("foo", data1);
            Assert.Equal("bar", data2);
        }

        [Fact(Skip = "Skipped test")]
        public void SkippedMethod()
        {
        }

        /*public static IEnumerable<object[]> AddData = new[] {
            new object[] {new Vector3(2, 5, -2), new Vector3(9, -1, 54), new Vector3(11, 4, 52)},
            new object[] {new Vector3(5, -1, -7), new Vector3(9, -1, 54), new Vector3(14, -2, 47)},
            new object[] {new Vector3(22, 55, -24), new Vector3(19, 49, 0), new Vector3(41, 104, -24)}
        };

        [Theory, MemberData("AddData")]
        public void Add_SampleVectors_AddsXyz(Vector3 left, Vector3 right, Vector3 expected)
        {
            // Arrange

            // Act
            var result = Vector3.Add(left, right);

            // Assert
            Assert.Equal(expected, result);
        }*/
    }
}
