using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace Lousand_checker_v1._0
{
    class HttpMethods
    {


        public static string Get(string url, string referer, ref CookieContainer cookies)
        {

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.ProtocolVersion = HttpVersion.Version11;
            req.Method = "GET";
            req.CookieContainer = cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.87 Safari/537.36";
            req.Referer = referer;
            req.ContentType = "text/html; charset=utf-8";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);
            string pageSrc;
            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                pageSrc = sr.ReadToEnd();
            }
            return pageSrc;
        }
        public static bool Post(string url, string postData, string referer, CookieContainer cookies)
        {

            string key = "Fecha de registro (UTC)";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            req.ProtocolVersion = HttpVersion.Version11;
            req.Method = "POST";
            req.CookieContainer = cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.87 Safari/537.36";
            req.Referer = referer;
            req.ContentType = "Content-Type" + "application/json";
            req.Accept = "application/json";

            Stream postStream = req.GetRequestStream();
            byte[] postBytes = Encoding.ASCII.GetBytes(postData);
            postStream.Write(postBytes, 0, postBytes.Length);
            postStream.Dispose();


            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())

                return NewMethod(cookies, key, resp);
        }

        private static bool NewMethod(CookieContainer cookies, string key, HttpWebResponse resp)
        {
            cookies.Add(resp.Cookies);

            StreamReader streamReader = new StreamReader(resp.GetResponseStream());
            StreamReader sr = streamReader;

            string pageSrc = sr.ReadToEnd();
            sr.Dispose();
            //Console.WriteLine(pageSrc);
            return (pageSrc.Contains(key));

        }
    }
}
