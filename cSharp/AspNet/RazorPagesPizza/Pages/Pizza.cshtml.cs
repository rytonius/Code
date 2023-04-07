using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;
using System.Security.Cryptography.X509Certificates;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
        [BindProperty]public Pizza NewPizza { get; set; }
        public List<Pizza> pizzas = new();
        public void OnGet()
        {
            pizzas = PizzaService.GetAll();
            
        }

        public string GlutenFreeText(Pizza pizza) => pizza.IsGlutenFree ? "Gluten Free" : "Not Gluten Free";

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            PizzaService.Add(NewPizza);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            PizzaService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
