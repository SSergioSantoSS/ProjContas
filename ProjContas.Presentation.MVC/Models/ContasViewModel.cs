namespace ProjContas.Presentation.MVC.Models
{
    public class ContasViewModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Valor { get; set; }
        public int? Tipo { get; set; }
    }

}
