// This is just a placeholder file.s

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Global
{
    public class GlobalDefinitions
    {
        // Initialize web driver
        public static IWebDriver driver { get; set; } = null!;

        // Driver path
        // Grab a copy of chromedriver.exe from
        // https://chromedriver.storage.googleapis.com/index.html
        // and place it inside Framework folder
        public static string DriverPath = AbsolutePath.setup(@"\..\..\..\..\");

        public void Initialize()
        {
            // Open and maximise chrome browser
            driver = GetChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            // options.AddArguments("--headless");

            return new ChromeDriver(DriverPath, options, TimeSpan.FromSeconds(300));
        }

        // Go to home page
        public static void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }     
    }

    class AbsolutePath
    {
        public static string setup(string path)
        {
            return Path.GetFullPath(Directory.GetCurrentDirectory()) + path;
        }
    }
}