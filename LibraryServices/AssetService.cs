using System.Collections.Generic;
using System.Linq;

using LibraryData;
using LibraryData.Database;
using LibraryData.Models;

namespace LibraryServices.Assets
{

    public class AssetService : IAsset
    {

        private readonly LibraryContext _context;

        public AssetService(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Asset> GetAll()
        {
            return _context.Assets;
        }

        public string GetIsbn(int id)
        {
            return GetBook(id)?.ISBN;
        }

        public Asset GetById(int id)
        {
            return _context.Assets.FirstOrDefault(asset => asset.Id == id);
        }

        public void Add(Asset asset)
        {
            _context.Add(asset);
            _context.SaveChanges();
        }

        public void Delete(Asset asset)
        {
            _context.Assets.Remove(asset);
            _context.SaveChanges();
        }

        public string GetAuthorOrDirector(int id)
        {
            var book = GetBook(id);
            return book != null ? book.Author : GetVideo(id)?.Director;
        }

        public Branch GetLocation(int id)
        {
            return _context.Assets.FirstOrDefault(asset => asset.Id == id)?.Branch;
        }

        public Video GetVideo(int id)
        {
            return _context.Videos.FirstOrDefault(video => video.Id == id);
        }

        public string GetDeweyIndex(int id)
        {
            return GetBook(id)?.DeweyIndex;
        }

        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(book => book.Id == id);
        }

    }

}