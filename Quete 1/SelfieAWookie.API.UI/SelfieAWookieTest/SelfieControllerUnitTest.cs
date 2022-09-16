using SelfieAWookie.API.UI.Controllers;

namespace SelfieAWookieTest
{
    public class SelfieControllerUnitTest
    {
        [Fact]
        public void ShouldReturnListOfSelfies()
        {
            //ARRANGE

            var controller = new SelfieController();

            //ACT

            var result = controller.Get();

            //ASSERT

            Assert.NotNull(result);
            Assert.True(result.GetEnumerator().MoveNext());

        }
    }
}