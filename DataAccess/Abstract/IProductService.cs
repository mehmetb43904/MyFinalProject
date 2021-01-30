using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

    }
}
