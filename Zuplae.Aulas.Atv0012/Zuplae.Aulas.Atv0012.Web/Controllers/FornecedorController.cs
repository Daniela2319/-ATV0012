using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Zuplae.Aulas.Atv0012.Models;
using Zuplae.Aulas.Atv0012.Servics;
using Zuplae.Aulas.Atv0012.Web.Models;

namespace Zuplae.Aulas.Atv0012.Web.Controllers
{
    public class FornecedorController : Controller
    {
        private FornecedorService _fornecedorService = new FornecedorService();
        EnderecoService enderecoService = new EnderecoService();  // instancia o serviço de endereços

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            FornecedorViewModel viewModel = new FornecedorViewModel();   //cria a view model
            viewModel.Fornecedor = new Fornecedor();                    // inicializa o fornecedor vazio
                                                                        
            List<Endereco> enderecos = enderecoService.Listar();        //busca todos os enderenços

            viewModel.Enderecos = new List<SelectListItem>();           // prepara a lista para o dropdown

            foreach (var item in enderecos)                             //transforma cada endereço em um "SelectListItem" com value=Id e Text= ToString()
            {
                SelectListItem selectListItem = new SelectListItem();
                selectListItem.Value = item.Id.ToString();
                selectListItem.Text = item.ToString();

                viewModel.Enderecos.Add(selectListItem);            // adiciona viewModel na lista de Enderecos
            }
            return View(viewModel);                                 // Retorna a view com o modelo preenchido
        }

        [HttpPost]
        public IActionResult Create(FornecedorViewModel viewModel) // Auto Binding do Model
        {
            Fornecedor model = viewModel.Fornecedor;                        //extrai o fornecedor do view model
            var endereco = enderecoService.ListarPorId(model.Endereco.Id);  //busca o endereço completo pelo Id selecionado
            model.Endereco = endereco;                                      // associa o endereço completo ao fornecedor

            var id = _fornecedorService.Cadastrar(model);                   //salva o fornecedor com o endereço
            return RedirectToAction("List");                                //redireciona para lista de fornecedores.
        }

        [HttpGet]
        public IActionResult List()
        {
            var enderecos = _fornecedorService.Listar();
            return View(enderecos);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Fornecedor model = _fornecedorService.ListarPorId(id);
            return View(model);
        }

        public IActionResult Edit(Fornecedor model)
        {
            bool editado = _fornecedorService.Editar(model);
            return RedirectToAction("List");

        }

        public IActionResult Delete(int id)
        {
            _fornecedorService.Deletar(id);
            return RedirectToAction("List");
        }
    }
}

