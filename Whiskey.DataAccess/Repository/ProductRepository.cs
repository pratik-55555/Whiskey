using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Whiskey.DataAccess.Data;
using Whiskey.DataAccess.Repository.IRepository;
using Whiskey.Models;

namespace Whiskey.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {

                if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Brand = product.Brand;
                objFromDb.Name = product.Name;
                objFromDb.Description = product.Description;
                objFromDb.Price = product.Price;
                objFromDb.Capacity = product.Capacity;
                objFromDb.CategoryId = product.CategoryId;
                
            }
        }
    }
}
