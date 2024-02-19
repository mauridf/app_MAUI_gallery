using app_MAUI_gallery.Models;
using app_MAUI_gallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_MAUI_gallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category {
                Nome = "Layout",
                Components = new List<Component> { 
                    new Component 
                    { 
                        Title = "StackLayout", 
                        Description= "Organização sequencial dos elementos.",
                        Page = new StackLayoutPage()
                    } 
                }
            });
            return categories;
        }
    }
}
