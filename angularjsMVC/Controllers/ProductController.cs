using angularjsMVC.Interface;
using angularjsMVC.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using angularjsMVC.Models;
using System.Web.Http;

namespace angularjsMVC.Controllers
{
    public class ProductController : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();
       
	 public IEnumerable GetAllProducts()
        {
            return repository.GetAll();
        }
        
        public TblProductList PostProduct (TblProductList item)
        {
            return repository.Add(item);
        }

     
        public IEnumerable PutProduct(TblProductList product)
        {
            if (repository.Update(product))
            {
                return repository.GetAll();
            }
            else
            {
                return null;
            }
        }

      
        public bool DeleteProduct(int id)
        {
            if (repository.Delete(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
