namespace Zuplae.Aulas.Atv0012.Models
{
    public class Endereco : BaseModel
    {
        #region Atributos
        public string logradouro;
        private string numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        #endregion

        #region Construtores
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
            return cidade.ToLower();
        }

        public void SetEstado(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado) || estado.Length != 2)
            {
                throw new Exception("Estado inválido. Deve ter 2 caracteres.");
            }
            this.estado = estado;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetCep(string cep)
        {
            //validar que valor contenha 8 caracteres e seja numérico
            if (string.IsNullOrWhiteSpace(cep) || cep.Length != 8 || !long.TryParse(cep, out _))
            {
                throw new Exception("CEP inválido. Deve ter 8 caracteres numéricos.");
            }
            this.cep = cep;
        }

        public string GetCep()
        {
            return cep;
        }

        #endregion

        #region Metodo
        public override string ToString()
        {
            return $"Rua: {GetLogradouro()}, {GetNumero()} - {GetBairro()}, {GetCidade()} - {GetEstado()}, CEP: {GetCep()}";
        }
        #endregion

    } 
}
