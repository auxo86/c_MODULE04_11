using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODULE04_09.DAL;
//資料從ViewModels來，不是從Models
using MODULE04_09.ViewModels;

namespace MODULE04_09.Models
{
    public class ProductSystem
    {
        //public Product GetProductByID(int id)
        //{
        //    NorthwindEntities db = new NorthwindEntities();
        //    var query = from p in db.Products
        //                where p.ProductID == id
        //                select p;

        //    //只列第一筆
        //    var result = query.First();

        //    return result;

        //}

        //這裡要注意回傳型別，是ProductViewModel，不是Product喔~
        public ProductViewModel GetProductByIdNew(int id)
        {
            //這裡是說，我只要Product中的三個欄位的資料，不要全部
            NorthwindEntities_new db = new NorthwindEntities_new();
            var query = from p in db.Products
                        where p.ProductID == id
                        //這裡new了ProductViewModel物件，所以query也是ProductViewModel物件
                        select new ProductViewModel
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice
                        };
            //只列第一筆ProductViewModel
            var result = query.First();

            //所以result是ProductViewModel物件
            return result;
        }

        //這裡要注意回傳型別，是ProductViewModel，不是Product喔~
        public ProductViewModel GetProductByID(int id)
        {
            //這裡是說，我只要Product中的三個欄位的資料，不要全部
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.ProductID == id
                        //這裡new了ProductViewModel物件，所以query也是ProductViewModel物件
                        select new ProductViewModel
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice
                        };

            //只列第一筆ProductViewModel
            var result = query.First();

            //所以result是ProductViewModel物件
            return result;
        }

        public IEnumerable<Product> GetProductsByCategoryID(int id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == id
                        select p;

            var result = query.ToList();
            return result;
        }


    }
}
