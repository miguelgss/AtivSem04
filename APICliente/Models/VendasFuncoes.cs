using APICliente.ConnectAPI;
using APICliente.Context;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICliente.Models
{
    public class VendasFuncoes
    {
        

        // Funcoes para obter dados da tabela de Vendas

        // Funcoes que se conectam a API
        public static List<object> GetLista()
        {
            List<object> ListaLimites = new List<object>();
            string json = APICon.RequestGET(string.Empty, string.Empty);
            ListaLimites = JsonConvert.DeserializeObject<List<object>>(json);

            return ListaLimites;
        }

        public static object GetLimite(string id)
        {
            object limite;
            string json = APICon.RequestGET("/api/LimiteCliente/Limite/", id);
            limite = JsonConvert.DeserializeObject<object>(json);

            return limite;
        }

        public static bool PatchLimite(string id, string valor)
        {
            //object limite = GetUnico(id);

            //if (Double.Parse(limite) < Int32.Parse(valor)) return false;
            //string json = APICon.RequestPATCH(@"/api/LimiteCliente/Limite/", id + "/Decrementa/" + valor);
            return true;
        }
    }
}
