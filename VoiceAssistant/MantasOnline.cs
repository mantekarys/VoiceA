using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public class MantasOnline
    {
        public static string Translate()
        {
            SendKeys.SendWait("^c");
            string clipboardText = GetClipBoradData();
            ChromeOptions option = new ChromeOptions();
            //option.AddArgument("--headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service, option);
            //https://translate.google.com/?hl=en&sl=auto&tl=en&op=translate
            if (false)
            {
                driver.Navigate().GoToUrl("https://translate.google.com/?hl=en&sl=auto&tl=lt&op=translate");
            }
            else
            {
                driver.Navigate().GoToUrl("https://translate.google.com/?hl=en");
            }
            IWebElement elementButton = driver.FindElement(By.CssSelector("#yDmH0d > c-wiz > div > div > div > div.NIoIEf > div.G4njw > div.AIC7ge > form > div.lssxud > div > button > div.VfPpkd-RLmnJb"));
            elementButton.Click();

            //#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb > div.AxqVh > div.OPPzxe > c-wiz.rm1UF.UnxENd.dHeVVb > span > span > div > textarea
            IWebElement element = driver.FindElement(By.CssSelector("#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb > div.AxqVh > div.OPPzxe > c-wiz.rm1UF.UnxENd > span > span > div > textarea"));
            //IWebElement element = driver.FindElement(By.CssSelector("#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb > div.AxqVh > div.OPPzxe > c-wiz.rm1UF.UnxENd.dHeVVb > span > span > div > textarea"));

            element.SendKeys(clipboardText);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb > div.AxqVh > div.OPPzxe > c-wiz.P6w8m.BDJ8fb > div.dePhmb > div > div.J0lOec > span.VIiyi > span > span")));

            Console.WriteLine("translation: " + element2.Text);
            if (clipboardText == element2.Text)
            {
                Console.WriteLine("Translation is " + element2.Text + ". Are you sure you selected an existing word, that is not in English?");
                return "Translation is " + element2.Text + ". Are you sure you selected an existing word, that is not in English?";
            }
            return element2.Text;
        }
        public static string Definition()
        {
            SendKeys.SendWait("^c");
            string clipboardText = GetClipBoradData();

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("headless");

            IWebDriver driver = new ChromeDriver(service, option);
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");
            IWebElement element = driver.FindElement((By.CssSelector("#searchInput")));
            element.SendKeys(clipboardText);
            element.Submit();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement element2 = null;
            try
            {
                element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("#mw-content-text > div.mw-parser-output")));
                var el = element2.FindElements(By.TagName("p"));
                foreach (var e in el)
                {
                    if (e.Text != "")
                    {
                        Console.WriteLine("Definition: " + e.Text);
                        return e.Text;
                    }
                }
            }
            catch
            {
            }
            return "no definition";
        }
        private static string GetClipBoradData()
        {
            try
            {
                string clipboardData = null;
                Exception threadEx = null;
                Thread staThread = new Thread(
                    delegate ()
                    {
                        try
                        {
                            clipboardData = Clipboard.GetText();
                        }

                        catch (Exception ex)
                        {
                            threadEx = ex;
                        }
                    });
                staThread.SetApartmentState(ApartmentState.STA);
                staThread.Start();
                staThread.Join();
                return clipboardData;
            }
            catch (Exception exception)
            {
                return string.Empty;
            }
        }
    }
}
