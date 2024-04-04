using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemortyProductsDal : IProductDal
    {
        List<Product> _products;
        public InMemortyProductsDal()
        {
            //Oracle,SqlServer,Postgress,MangoDb
            _products = new List<Product> { 
            new Product{ ProductId = 1 , CategoryId=1,ProductName="Bardak ",UnitPrice=15,UnitsInStock=15},
                        new Product{ ProductId = 2 , CategoryId=1,ProductName="Kamera ",UnitPrice=500,UnitsInStock=3},
            new Product{ ProductId = 3 , CategoryId=1,ProductName="Telefon ",UnitPrice=1500,UnitsInStock=2},
                        new Product{ ProductId = 4 , CategoryId=1,ProductName="Klavye ",UnitPrice=150,UnitsInStock=65},
            new Product{ ProductId = 5 , CategoryId=1,ProductName="Fare ",UnitPrice=85,UnitsInStock=1}



            };

        }
        public void add(Product product)
        {
            _products.Add(product); 
        }
        //Delete özel olarak ıd alınmalıdır. Referans olduğu için.
        public void delete(Product product)
        {
            //LİNQ Liste  bazlı kullanımları sql gibi filtrelenebiliyor.
            // = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId) {

            //    productToDelete= p;
            //    }

            //} //Bizim yerimize ürünleri tek tek dolaşmaya yarar.
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
       _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
                }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void update(Product product)
        { //Gönderdiğim ürün ıd sine sahip olan ürün idsine sahip ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
