

using SmallAPI.Data;

namespace TinyApi.Tests
{
    public class DataTests
    {
        [Fact]
        public void Number_Of_Countries_ShouldBe_8()
        {
            Assert.Equal(9, Countries.CountryList.Count());
        }
    }
}