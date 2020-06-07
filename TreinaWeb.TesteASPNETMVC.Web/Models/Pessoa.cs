using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TreinaWeb.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
        [DisplayName("Nome da pessoa")]
        public string Nome { get; set; }
        [DisplayName("Idade da pessoa")]
        public int Idade { get; set; }
        [DisplayName("Endereço da pessoa")]
        public string Endereco { get; set; }
    }
}