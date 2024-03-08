using System.ComponentModel.DataAnnotations;
using CoreBusiness;
using WebApp.ViewModels.Validations;

namespace WebApp.ViewModels
{
    // This model helps in passing data between the controller and the view, facilitating a clean separation of concerns
    // in the MVC architecture.
    public class SalesViewModel
    {
        // used in the view to keep track of the category selected by the user.
        public int SelectedCategoryId { get; set; }

        // This collection will be populated with data retrieved from a database and then passed to the view for display.
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public int SelectedProductId { get; set; }


        [Display(Name ="Quantity")]
        [Range(1,int.MaxValue)]
        [SalesViewModel_EnsureProperQuantity]
        public int QuantityToSell { get; set; }
    }
}
