using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Diagnostics;

namespace Timmy
{
    class Selenium
    {


       
        
        public void internet(string url)
        {

        }
        public void exit()
        {

        }
        /*
        public void weather()
        {
            Thread.Sleep(1000);
            string result;
            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("날씨");
            driver.FindElement(By.Id("search_btn")).Click();
            var wt = driver.FindElement(By.ClassName("cast_txt"));
            result = wt.Text;
            main.Re(result);
            Console.WriteLine(result);
        }
        public void navermusic10() // 최신노래제목 (네이버1~10위 ) - 최신곡
        {

            IWebElement q = driver.FindElement(By.Id("query"));
            q.SendKeys("노래순위");                         //네이버 검색어 입력
            driver.FindElement(By.Id("search_btn")).Click();
            Thread.Sleep(3000);

            var rank = driver.FindElement(By.ClassName("list_top_music"));

            string song;
            string sing;
            for (int i = 1; i <= 10; i++)
            {
                var ranksong = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[1]/a"));  //노래 이름
                var ranksinger = rank.FindElement(By.XPath("//*[@id='main_pack']/div[2]/div[2]/ol/li[" + i + "]/div/div[1]/div[2]/div[2]/a[1]")); //가수

                song = ranksong.Text;
                sing = ranksinger.Text;

                Console.Write(i + "위  " + sing + "  -  ");
                Console.WriteLine(song);
            }
        }
        public void googlelogin()
        {
            // driver.Navigate().Forward(); //앞페이지
            // driver.Navigate().Refresh(); //새로고침
            driver.FindElement(By.XPath("//*[@id='gb_70']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("identifierId")).SendKeys("github1919@gmail.com");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='identifierNext']/content/span")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("zxcv1681!");
            Thread.Sleep(1500);
            driver.FindElement(By.XPath("//*[@id='passwordNext']/content/span")).Click();

        }

        public void facebook()  //페이스북 로그인
        {

            driver.Url = "https://www.facebook.com/";

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("alex@csharpstudy.com");
            driver.FindElement(By.Id("pass")).SendKeys("비번");
            driver.FindElement(By.Id("loginbutton")).Click();
            Thread.Sleep(5000);

            //driver.Close(); 크롬종료

        }



        public void chromeexit() //크롬종료  - 인터넷꺼
        {
            string ch = "chrome";
            var pro = Process.GetProcessesByName(ch);
            Process cu = Process.GetCurrentProcess();
            foreach (Process proc in pro)
            {

                if (proc.Id != cu.Id)

                proc.Kill();

            }
        }
        */
        // driver.Url = "https://www.melon.com/chart/index.htm";


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
        */





        /*
        // 최신노래제목 (네이버1~100위 )
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

        */




    }
    }
