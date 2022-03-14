using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APICliente.ConnectAPI
{
    public class APICon // Executa os requests
    {
        public static readonly string URI = "https://localhost:44353/api/limitecliente/";

        public static string RequestGET(string metodo, string valor)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo + valor);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        public static string RequestPATCH(string metodo, string valor)
        {
            var request = (HttpWebRequest)WebRequest.Create(URI + metodo + valor);
            request.Method = "PATCH";

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
