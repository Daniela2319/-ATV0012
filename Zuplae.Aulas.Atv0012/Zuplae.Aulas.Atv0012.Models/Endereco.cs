namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco
    {
        #region Atributos
        private string logradouro;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        #endregion

        #region Metodos
        public Endereco() { }

        public Endereco(string logradouro, string numero, string bairro, string cidade, string estado, string cep)
        {
            this.SetLogradouro(logradouro);
            this.SetNumero(numero);
            this.SetBairro(bairro);
            this.SetCidade(cidade);
            this.SetEstado(estado);
            this.SetCep(cep);
        }

        #endregion

        #region Logradouro, Numero, Bairro, Cidade, Estado, Cep
        public void SetLogradouro(string rua)
        {
            this.logradouro = rua; 
        }

        public string GetLogradouro()
        {
            return logradouro; 
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

        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Rua: {GetLogradouro()}, {GetNumero()} - {GetBairro()}, {GetCidade()} - {GetEstado()}, CEP: {GetCep()}";
        }
        #endregion
    }
}
