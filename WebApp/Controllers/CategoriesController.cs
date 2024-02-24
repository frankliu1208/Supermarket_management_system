using Microsoft.AspNetCore.Mvc;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        // displaying a list of categories
        public IActionResult Index()
        {
            var categories = CategoriesRespository.GetCategories();
            return View(categories);
        }

        // editing a category
        public IActionResult Edit(int? id)
        {
            var category = CategoriesRespository.GetCategoryById(id.HasValue ? id.Value : 0);

            return View(category);

        }

        // invoked when the form for editing a category is submitted, use model binding to receive the data 
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRespository.UpdateCategory(category.CategoryId, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // display a form for adding a new category
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRespository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        public IActionResult Delete(int categoryId)
        {
            CategoriesRespository.DeleteCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
