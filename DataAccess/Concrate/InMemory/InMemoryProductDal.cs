﻿using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()  //constructer
        {
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName= "Bardak",UnitPrice = 15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName= "Kamera",UnitPrice = 15, UnitsInStock=15},
                new Product{ProductId=3, CategoryId=2, ProductName= "Telefon",UnitPrice = 15, UnitsInStock=15},
                new Product{ProductId=4, CategoryId=2, ProductName= "Klavye",UnitPrice = 15, UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName= "Fare",UnitPrice = 15, UnitsInStock=15},
        };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gönderdiğim ürün Id sine sahip olan ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
       
    }
}
