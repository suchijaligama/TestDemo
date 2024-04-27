using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Opem Chrome Browser

IWebDriver webdriver = new ChromeDriver();
webdriver.Manage().Window.Maximize();

//Launch TurnUJp Portal and Navigate to login page
webdriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify Username textbox and enter valid username
IWebElement usernameTextbox = webdriver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = webdriver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

Thread.Sleep(5000);

//Identify login button and click on the button
IWebElement loginButton = webdriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

//Check if user has loged in successfully

IWebElement helloHarilink = webdriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHarilink.Text == "Hello hari!")
{
    Console.WriteLine("user has logged in successfully");
}
else
{
    Console.WriteLine("user hasn't been logged in.");
}
// Check if user has logged in successful

