using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Zuplae.Aulas.Atv0012.Models;
using Zuplae.Aulas.Atv0012.Servics;
using Zuplae.Aulas.Atv0012.Web.Models;

namespace Zuplae.Aulas.Atv0012.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoService _produtoService = new ProdutoService();
        private FornecedorService _fornecedorService = new FornecedorService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProdutoViewModel viewModel = new ProdutoViewModel();
            viewModel.Produto = new Produto();

            List<Fornecedor> fornecedores = _fornecedorService.Listar();

            viewModel.Fornecedores = new List<SelectListItem>();

            foreach (var item in fornecedores)
            {
                viewModel.Fornecedores.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.ToString()
                });
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(ProdutoViewModel viewModel)
        {
            Produto model = viewModel.Produto;

            // Busca o fornecedor selecionado e adiciona à lista de fornecedores do produto
            var fornecedorSelecionado = _fornecedorService.ListarPorId(model.Fornecedor.Id);
            model.Fornecedor = fornecedorSelecionado;

            _produtoService.Cadastrar(model);

            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult List()
        {
            var enderecos = _produtoService.Listar();
            return View(enderecos);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto model = _produtoService.ListarPorId(id);
            return View(model);
        }

        public IActionResult Edit(Produto model)
        {
            bool editado = _produtoService.Editar(model);
            return RedirectToAction("List");

        }

        public IActionResult Delete(int id)
        {
            _produtoService.Deletar(id);
            return RedirectToAction("List");
        }
    }
}
