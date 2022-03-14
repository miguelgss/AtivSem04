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

        public static LimiteCliente GetCliente(string id) // Obtem uma lista com todos os Limite Cliente do banco
        {
            LimiteCliente cliente = new LimiteCliente();
            string json = APICon.RequestGET("Cliente/", id);
            cliente = JsonConvert.DeserializeObject<LimiteCliente>(json);

            return cliente;
        }

        public static LimiteCliente GetLimite(string id) // Obtem o limite de credito de um cliente especificado pelo Id
        {
            LimiteCliente limite;
            string json = APICon.RequestGET("Limite/", id);
            limite = JsonConvert.DeserializeObject<LimiteCliente>(json);

            return limite;
        }

        public static void PatchLimite(string id, float valor) // Modifica o limite de credito de um cliente de acordo com o id e valor informado
        {
            LimiteCliente limite = GetCliente(id);

            string json = APICon.RequestPATCH(@"Limite/", id + "/Decrementa/" + valor);
            limite = JsonConvert.DeserializeObject<LimiteCliente>(json);
        }
    }
}
