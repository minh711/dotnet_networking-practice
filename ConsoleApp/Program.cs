using ConsoleApp;
using System;
using System.Net.Http;
using System.Threading.Tasks;


partial class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        URIDemo uriDemo = new URIDemo();
        WebRequestResponse webRequestResponse = new WebRequestResponse();
        HttpClientDemo httpClientDemo = new HttpClientDemo();

        //uriDemo.Start();
        //webRequestResponse.Start();
        await httpClientDemo.Start(client);
    }
}

