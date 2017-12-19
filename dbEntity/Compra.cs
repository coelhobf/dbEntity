namespace dbEntity
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quant { get; internal set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; internal set; }
        public double PrecoT { get; internal set; }

        public Compra(Produto produto, int quant)
        {
            this.Produto = produto;
            this.Quant = quant;
            this.PrecoT = produto.PrecoU * quant;
        }

        public override string ToString()
        {
            return $"Compra de {this.Quant} {this.Produto.Unidade} do produto {this.Produto.Nome} a R$ {this.PrecoT}";
        }
    }
}