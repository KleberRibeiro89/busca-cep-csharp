using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace busca_cep_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para exibir o endereço completo informe o CEP");
            Console.WriteLine("...");
            Console.WriteLine("...");

            var cep = Console.ReadLine();
            var url = BuscarUrlCep(cep);
            Console.WriteLine(url);

            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).Result;

            var enderecoJson = response.Content.ReadAsStringAsync().Result;

            var endereco = JsonSerializer.Deserialize<EnderecoModel>(enderecoJson);
            
            Console.WriteLine($"o bairro é: {endereco.bairro}");
            Console.WriteLine($"o cep é: {endereco.cep}");
            Console.WriteLine($"o complemento é: {endereco.complemento}");
            Console.WriteLine($"o localidade é: {endereco.localidade}");
            Console.WriteLine($"o Logradouro é: {endereco.logradouro}");
            Console.WriteLine($"o uf é: {endereco.uf}");
        }


        public static string BuscarUrlCep(string cep)
        {
            return $"https://viacep.com.br/ws/{cep}/json/";
        }
    }
}
