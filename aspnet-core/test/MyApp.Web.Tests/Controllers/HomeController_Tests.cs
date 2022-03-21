using System.Threading.Tasks;
using MyApp.Models.TokenAuth;
using MyApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyApp.Web.Tests.Controllers
{
    public class HomeController_Tests: MyAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}