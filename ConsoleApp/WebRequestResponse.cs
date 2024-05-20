using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ConsoleApp
{
    internal class WebRequestResponse
    {
        public void Start()
        {
            WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine($"Status: {response.StatusDescription}");
            Console.WriteLine(new string('*', 50));

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);
            Console.WriteLine(new string('*', 50));

            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
