using Zuplae.Aulas.Atv0012.Models;

namespace Zuplae.Aulas.Atv0012.Servics
{
    public class BaseService<M> : IService<M> where M : BaseModel, new()
    {
        #region Propriedades
            private static List<M> listas = new List<M>();
            private M modelOriginal = new M();
        #endregion

        #region Cadastrar
            public int Cadastrar(M model)
            {
                listas.Add(model);
                int id = model.Id;
                return id;
            }
        #endregion

        #region Editar
        public bool Editar(M model)
        {
            // Busca o item na lista
            modelOriginal = ListarPorId(model.Id);

            if (modelOriginal != null)
            {
               
               listas.Remove(modelOriginal);// Remove o modelo original da lista
               listas.Add(model); // Adiciona o modelo atualizado à lista
                return true;
            }

            return false;
        }
        #endregion

        #region Listar
        public List<M> Listar()
            {
                return listas;
            }
        #endregion

        #region ListarPorId
            public M ListarPorId(int id) 
            {
                return listas.FirstOrDefault(e => e.Id == id);
            }
        #endregion

        #region Deletar
            public bool Deletar(int id)
            {
                 modelOriginal = this.ListarPorId(id);
                if (this.modelOriginal != null)
                {
                    listas.Remove(this.modelOriginal);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion


    }
}
