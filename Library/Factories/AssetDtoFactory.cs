using Library.Models.Catalog;

using LibraryData;
using LibraryData.Models;

namespace Library.Factories {

    public class AssetDtoFactory {

        private readonly IAsset _assets;

        public AssetDtoFactory(IAsset assets) {
            _assets = assets;
        }

        public AssetIndexListingModel Create(Asset asset) {
            return new AssetIndexListingModel {
                Id = asset.Id,
                AuthorOrDirector = _assets.GetAuthorOrDirector(asset.Id),
                ImageUrl = asset.ImageUrl,
                NumberOfCopies = asset.NumberOfCopies.ToString(),
                Title = asset.Title
            };
        }

    }

}