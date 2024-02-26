using Microsoft.AspNetCore.Mvc;
using WebApp.Models;


namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        // displaying a list of categories
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        // editing a category
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "edit";

            var category = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);

            return View(category);

        }

        // invoked when the form for editing a category is submitted, use model binding to receive the data 
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRepository.UpdateCategory(category.CategoryId, category);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Action = "edit";
            return View(category);
        }

        // display a form for adding a new category
        public IActionResult Add()
        {
            ViewBag.Action = "add";
             
            return View();
        }


        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoriesRepository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Action = "add";
            return View(category);
        }

        public IActionResult Delete(int categoryId)
        {
            CategoriesRepository.DeleteCategory(categoryId);
            return RedirectToAction(nameof(Index));
        }
    }
}
