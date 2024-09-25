namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }

        //Relacionamento com a tabela Venda 
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        //Relacionamento com a tabela Produtos 
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QtdadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }
    }
}
