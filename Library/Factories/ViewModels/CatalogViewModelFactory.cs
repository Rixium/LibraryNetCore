using System.Linq;

using Library.Models.Catalog;

using LibraryData;

namespace Library.Factories.ViewModels {

    public class CatalogViewModelFactory {

        private readonly AssetDtoFactory _assetDtoFactory;

        public CatalogViewModelFactory(IAsset assets) {
            _assetDtoFactory = new AssetDtoFactory(assets);
        }

        public AssetIndexModel IndexViewModel(IAsset assets) {
            var resultAssets = assets.GetAll().Select(result => _assetDtoFactory.Create(result));
            return new AssetIndexModel {
                Assets = resultAssets.ToList()
            };
        }

    }

}