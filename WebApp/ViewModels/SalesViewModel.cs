using System.ComponentModel.DataAnnotations;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class SalesViewModel
    {
        // used in the view to keep track of the category selected by the user.
        public int SelectedCategoryId { get; set; }

        // This collection will be populated with data retrieved from a database and then passed to the view for display.
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public int SelectedProductId { get; set; }


        [Display(Name ="Quantity")]
        [Range(1,int.MaxValue)]
        public int QuantityToSell { get; set; }
    }
}
