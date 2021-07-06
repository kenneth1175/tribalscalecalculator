using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTribalscale_Automation
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //Create a refrerence for Chrome Browser
            IWebDriver driver = new ChromeDriver();

        // Go to Tribal App
        driver.Navigate().GoToUrl("https://qainterview.pythonanywhere.com");
    

        // Make the browser full screen
            driver.Manage().Window.Maximize();

        //Find the element
            IWebElement searchBox = driver.FindElement(By.Name("number"));

         // Type something in the search bar
            searchBox.SendKeys("7");
        

         //Close the browser
            driver.Quit();
        }


    }
}
