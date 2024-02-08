using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }

        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }

        [Display(Name = "Valor total")]
        public Decimal ValorTotal { get; set; }

        [Display(Name = "Nota fiscal")]
        public int NotaFiscal { get; set; }

        [Display(Name = "CLiente")]
        public Guid ClienteID { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
