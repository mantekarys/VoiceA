using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace VoiceAssistant
{
    public class MantasOnlineWrapper//is called but visual studio doesn't show it. It was called 9 times
    {
        public virtual string GetClipBoradData()
        {
            return MantasOnline.GetClipBoradData();
        }
    }
    public class MantasOnline
    {
        public static string Translate(MantasOnlineWrapper test = null)
        {
            string clipboardText;
            if (test == null)
            {
                SendKeys.SendWait("^c");
                clipboardText = GetClipBoradData();
            }
            else
            {
                clipboardText = test.GetClipBoradData();
            }
            if (clipboardText == "")
            {
                return "text not selected";
            }
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            using (IWebDriver driver = new ChromeDriver(service, option))
            {
                if (false)
                {
                    driver.Navigate().GoToUrl("https://translate.google.com/?hl=en&sl=auto&tl=lt&op=translate");
                }
                else
                {
                    driver.Navigate().GoToUrl("https://translate.google.com/?hl=en");
                }
                IWebElement elementButton = driver.FindElement(By.CssSelector("#yDmH0d > c-wiz > div > div > div > div.NIoIEf > div.G4njw > div.AIC7ge > div.CxJub > div.VtwTSb > form:nth-child(2) > div > div > button"));

                elementButton.Click();

                IWebElement element = driver.FindElement(By.CssSelector("#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb > div.AxqVh > div.OPPzxe > c-wiz.rm1UF.UnxENd > span > span > div > textarea"));

                element.SendKeys(clipboardText);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement element2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("#yDmH0d > c-wiz > div > div.WFnNle > c-wiz > div.OlSOob > c-wiz > div.ccvoYb.EjH7wc > div.AxqVh > div.OPPzxe > c-wiz.sciAJc > div > div.usGWQd > div > div.lRu31 > span.HwtZe > span > span")));

                Console.WriteLine("translation: " + element2.Text);
                if (clipboardText == element2.Text)
                {
                    Console.WriteLine("Translation is " + element2.Text + ". Are you sure you selected an existing word, that is not in English?");
                    return "Translation is " + element2.Text + ". Are you sure you selected an existing word, that is not in English?";
                }
                return element2.Text;
            }            
        }
        public static string Definition(MantasOnlineWrapper test = null)
        {
            string clipboardText;
            if (test == null)
            {
                SendKeys.SendWait("^c");
                clipboardText = GetClipBoradData();
            }
            else
            {
                clipboardText = test.GetClipBoradData();
            }

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            ChromeOptions option = new ChromeOptions();
            option.AddArgument("headless");


            //IWebDriver driver = new ChromeDriver(service, option);
            using (IWebDriver driver = new ChromeDriver(service, option))
            {
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
            
        }
        public static string GetClipBoradData()//mocked so it is not used
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
