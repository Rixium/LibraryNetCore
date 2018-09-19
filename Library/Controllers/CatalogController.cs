using Library.Factories.ViewModels;

using LibraryData;

using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers {

    public class CatalogController : Controller {

        private readonly IAsset _assets;
        private readonly CatalogViewModelFactory _catalogViewModelFactory;

        public CatalogController(IAsset assets) {
            _assets = assets;
            _catalogViewModelFactory = new CatalogViewModelFactory(assets);
        }

        public IActionResult Index() {
            var viewModel = _catalogViewModelFactory.IndexViewModel(_assets);
            return View(viewModel);
        }

        public IActionResult Detail() {
            return View();
        }

    }

}