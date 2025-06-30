namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        public string rua;
        public string numero;
        public string bairro;
        public string cidade;
        public string estado;
        public string cep;
 
        public Endereco() { }

        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
        }

        public override string ToString()
        {
            return $"Rua: {rua}, {numero} - {bairro}, {cidade} - {estado}, CEP: {cep}";
        }
    }
}
