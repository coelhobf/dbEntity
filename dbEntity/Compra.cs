namespace dbEntity
{
    internal class Compra
    {
        private Produto produto;
        private int quant;
        private double precoT;

        public Compra(Produto produto, int quant)
        {
            this.produto = produto;
            this.quant = quant;

            this.precoT = produto.PrecoU * quant;
        }
    }
}