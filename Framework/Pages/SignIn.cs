using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using static Framework.Global.GlobalDefinitions;


namespace Framework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }
        #endregion

        public void LoginSteps()
        {
            try
            {
                // Code here
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}