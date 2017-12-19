namespace dbEntity
{
    public class Endereco
    {
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco() { }
        public Endereco(int numero, string logra, string comple, string bairro, string cidade)
        {
            this.Numero = numero;
            this.Logradouro = logra;
            this.Complemento = comple;
            this.Bairro = bairro;
            this.Cidade = cidade;
        }
    }
}