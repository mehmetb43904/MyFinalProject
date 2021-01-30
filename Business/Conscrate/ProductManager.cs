using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conscrate
{
   public  class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //Yetkisi var mı ?

            return _productDal.GetAll();
        }
    }
}
