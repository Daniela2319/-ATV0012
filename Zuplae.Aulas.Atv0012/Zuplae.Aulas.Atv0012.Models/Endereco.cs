namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        private string rua;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
 
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

        public void SetRua(string rua)
        {
            this.rua = rua;
        }

        public string GetRua()
        {
            return rua;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return numero;
        }

        public void SetBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public void SetEstado(string estado)
        {
            this.estado = estado;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetCep(string cep)
        {
            this.cep = cep;
        }

        public string GetCep()
        {
            return cep;
        }


        public override string ToString()
        {
            return $"Rua: {rua}, {numero} - {bairro}, {cidade} - {estado}, CEP: {cep}";
        }
    }
}
