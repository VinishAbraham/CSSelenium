using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Launch MDA in Chrome Incognito

            var options = new ChromeOptions();
            options.AddArgument("incognito");     
            IWebDriver driver = new ChromeDriver(@"C:\libraries\",options);
            driver.Url = "https://usnconeboxax1aos.cloud.onebox.dynamics.com/";


            #endregion






        }
    }
}
