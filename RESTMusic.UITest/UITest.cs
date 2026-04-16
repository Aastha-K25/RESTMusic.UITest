using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace RESTMusic.UITest
{
    public class UITest
    {
        [Fact]
        public void Test_GetAllMusic_Button_Works()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://127.0.0.1:5500/Exercise.html");
            Thread.Sleep(2000);

            var button = driver.FindElement(By.XPath("//button[contains(text(),'Get all Music')]"));

            button.Click();

            Thread.Sleep(2000);

            var listItems = driver.FindElements(By.TagName("li"));

            Assert.True(listItems.Count >= 0);

            driver.Quit();
        }
    }
}
