using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateBaseV01.Models
{
    public class Pagamento
    {
        public Pagamento(string cartao, decimal valor, int quantidadeParcelas)
        {
            this.id = Guid.NewGuid();
            this.cartao = cartao;
            this.valor = valor;
            this.quantidadeParcelas = quantidadeParcelas;
        }

        public Guid id { get; set; }
        public string cartao { get; set; }
        public decimal valor { get; set; }
        public int quantidadeParcelas { get; set; }
    }
}