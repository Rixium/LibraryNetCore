using System.Collections.Generic;

using LibraryData.Models;

namespace LibraryData {

    public interface IAsset {

        IEnumerable<Asset> GetAll();
        Asset GetById(int id);
        void Add(Asset asset);
        void Delete(Asset asset);

        string GetAuthorOrDirector(int id);
        Branch GetLocation(int id);

    }

}