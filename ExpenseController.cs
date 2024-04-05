using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            // Display a list of expenses
            return View();
        }

        public IActionResult AddExpense()
        {
            // Add a new expense
            return View();
        }

        [HttpPost]
        public IActionResult AddExpense(Expense expense)
        {
            // Save the expense to the database
            return RedirectToAction("Index");
        }

        // Implement other CRUD operations as needed
    }
}