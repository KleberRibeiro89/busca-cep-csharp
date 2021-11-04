using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busca_cep_csharp
{
    public class EnderecoModel
    {
        public string cep { get; private set; }

        public string logradouro { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }
        
        public string localidade { get; set; }

        public string uf { get; set; }
    }
}
