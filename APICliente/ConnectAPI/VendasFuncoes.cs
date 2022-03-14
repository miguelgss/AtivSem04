using APICliente.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace APICliente.ConnectAPI
{
    public class VendasFuncoes
    {
        // Essas funcoes utilizam a APICon para executar os requests necessários
        public static List<LimiteCliente> GetLista() // Obtem uma lista com todos os Limite Cliente do banco
        {
            List<LimiteCliente> ListaLimites = new List<LimiteCliente>();
            string json = APICon.RequestGET(string.Empty, string.Empty);
            ListaLimites = JsonConvert.DeserializeObject<List<LimiteCliente>>(json);

            return ListaLimites;
        }

        public static LimiteCliente GetLimite(string id) // Obtem o limite de credito de um cliente especificado pelo Id
        {
            LimiteCliente limite;
            string json = APICon.RequestGET("/api/LimiteCliente/Limite/", id);
            limite = JsonConvert.DeserializeObject<LimiteCliente>(json);

            return limite;
        }

        public static void PatchLimite(string id, string valor) // Modifica o limite de credito de um cliente de acordo com o id e valor informado
        {
            LimiteCliente limite = GetLimite(id);

            string json = APICon.RequestPATCH(@"/api/LimiteCliente/Limite/", id + "/Decrementa/" + valor);
            limite = JsonConvert.DeserializeObject<LimiteCliente>(json);
        }
    }
}
