using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksoo.TestData
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Image { get; set; } = "A.png";
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; } = "A.png";
        public string Price { get; set; }


        public ObservableCollection<Product> ProductList()
        {
            return new ObservableCollection<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                  Price = "2500",
                    

                },
                new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }, new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }, new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }, new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }, new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }, new Product()
                {
                    Id = 1,
                    Name = "چای سبز",
                    Price = "2500"

                }
            };
        }

        public ObservableCollection<Category> Categorie()
        {
            return new ObservableCollection<Category>()
            {
                new Category()
                {
                  Name = "دسته بندی 1",
                    Id = 1,
                    ParentId = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 2
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 3
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 3
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 3
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 2
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 3
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 2
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 2
                }, new Category()
                {
                    Name = "دسته بندی 2",
                    Id = 1,
                    ParentId = 2
                }, new Category()
                {
                    Name = "دسته بندی 3",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 4",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 5",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 6",
                    Id = 1
                }, new Category()
                {
                    Name = "دسته بندی 7",
                    Id = 1
                }
            };
        }
    }

}
