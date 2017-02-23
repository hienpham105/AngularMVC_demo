using angularjsMVC.Interface;
using angularjsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularjsMVC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        TblProductListEntities db = new TblProductListEntities();
        public IEnumerable<TblProductList> GetAll()
        {
            return db.TblProductLists;
        }

        public TblProductList Get(int id)
        {
            return db.TblProductLists.Find(id);
        }

        public TblProductList Add(TblProductList item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }

            //add product
            db.TblProductLists.Add(item);
            db.SaveChanges();
            return item;
        }

        public bool Update(TblProductList item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }

            //function update product
            var product = db.TblProductLists.Single(a => a.Id == item.Id);
            product.Name = item.Name;
            product.Category = item.Category;
            product.Price = item.Price;
            db.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            //find id product and delete it
            TblProductList product = db.TblProductLists.Find(id);
            db.TblProductLists.Remove(product);
            db.SaveChanges();

            return true;
        }

    }

}