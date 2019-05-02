using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Timmy
{
    class Selenium
    {
        public void selenium()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.naver.com/";//주소 입력
           // driver.Url = "https://www.melon.com/chart/index.htm";

            driver.Manage().Window.Maximize();  //창크기 최대
                                                /*
                                                Thread.Sleep(500);

                                                driver.FindElement(By.XPath("//*[@id='account']/div/a/i")).Click();
                                                Thread.Sleep(500);

                                                driver.FindElement(By.Id("id")).SendKeys("a");
                                                Thread.Sleep(500);
                                                driver.FindElement(By.Id("pw")).SendKeys("a");
                                                Thread.Sleep(500);
                                                driver.FindElement(By.XPath("//*[@id='frmNIDLogin']/fieldset/input")).Click();

                                                Thread.Sleep(500);
                                                driver.Navigate().Back();
                                                *//*
                                                 //구글 로그인
                                                driver.FindElement(By.XPath("//*[@id='gb_70']")).Click();
                                                Thread.Sleep(1000);
                                                driver.FindElement(By.Id("identifierId")).SendKeys("xoals5566@gmail.com");
                                                Thread.Sleep(500);
                                                driver.FindElement(By.XPath("//*[@id='identifierNext']/content/span")).Click();
                                                Thread.Sleep(1000);
                                                driver.FindElement(By.Name("password")).SendKeys("비밀번호*");
                                                Thread.Sleep(1500);
                                                driver.FindElement(By.XPath("//*[@id='passwordNext']/content/span")).Click();
                                                */
                                                  /* driver.Navigate().Back(); //뒷페이지
                                                  // driver.Navigate().Forward(); //앞페이지
                                                  // driver.Navigate().Refresh(); //새로고침
                                                   Thread.Sleep(10000);
                                                   driver.FindElement(By.Id("id")).SendKeys("taemin5566");
                                                   Thread.Sleep(1500);
                                                   driver.FindElement(By.Id("pw")).SendKeys("비밀번호!");
                                                   Thread.Sleep(1500);
                                                   driver.FindElement(By.XPath("//*[@id='frmNIDLogin']/fieldset/input")).Click();
                                                   Thread.Sleep(1000);
                                                   */

            /*
            //페이스북 로그인
            IWebDriver driver = new InternetExplorerDriver();

            driver.Url = "https://www.facebook.com/";

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("alex@csharpstudy.com");
            driver.FindElement(By.Id("pass")).SendKeys("");
            driver.FindElement(By.Id("loginbutton")).Click();
            Thread.Sleep(5000);

            driver.Close();
            */
            // 최신노래제목 (네이버1~10위 )
            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("노래순위"); 
            driver.FindElement(By.Id("search_btn")).Click();
            Thread.Sleep(5000);

            var rank = driver.FindElement(By.ClassName("list_top_music"));


            string song;
            string sing;
            for (int i = 1; i <= 10; i++)
            {

                var ranksong = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[1]/a"));  //노래 이름
                var ranksinger = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[2]/a[1]")); //가수

                song = ranksong.Text;
                sing = ranksinger.Text;

                Console.Write(i+"위  "+sing+"  -  ");
                Console.WriteLine(song);
            }
            
            /*
            // 최신노래제목 (네이버1~100위 )
             //미완성
            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("노래순위");
            driver.FindElement(By.Id("search_btn")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[3]/a")).Click();
            Thread.Sleep(5000);
            //var rank = driver.FindElement(By.ClassName(""));

            string song; //노래제목
            string sing; //가수
                         
                         for (int i = 2; i <= 50; i++)
                         {

                             var ranksong = rank.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/table/tbody/tr[" + i + "]/td[4]/a[4]/span"));  //노래 이름
                             var ranksinger = rank.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/table/tbody/tr["+i +"]/td[5]/a/span")); //가수
                             //*[@id="content"]/div[2]/div[1]/table/tbody/tr[2]/td[4]/a[4]/span
                             //*[@id="content"]/div[2]/div[1]/table/tbody/tr[3]/td[4]/a[4]/span
                             //*[@id="content"]/div[2]/div[1]/table/tbody/tr[4]/td[4]/a[4]/span

                             //*[@id="content"]/div[2]/div[1]/table/tbody/tr[2]/td[5]/a/span
                             //*[@id="content"]/div[2]/div[1]/table/tbody/tr[3]/td[5]/a/span
                             song = ranksong.Text;
                             sing = ranksinger.Text;
                             Console.Write(i + "위  " + sing + "  -  ");
                             Console.WriteLine(song);
                         }
                         

            //var ranksong = rank
            var ranksong = driver.FindElement(By.XPath("//*[@id='content']/div[2]/div[1]/table/tbody/tr[2]/td[4]/a[4]"));  //노래 이름
            song = ranksong.Text;
            Console.WriteLine(song);
            */
            // 최신노래제목 (네이버1~10위 )
            /*
            Thread.Sleep(1000);

            var rank = driver.FindElement(By.XPath("//*[@id='frm']/div/table"));

            string song;
            string sing;

            
            driver.FindElement(By.XPath("//*[@id='frm']/div/table"));




            song = rank.Text;
                
                Console.WriteLine(song);
               */


        }
    }
}
