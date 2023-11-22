using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
