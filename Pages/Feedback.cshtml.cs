using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;
using WebApplication3.Models;

namespace WebApplication3.Pages
{
    public class FeedbackModel : PageModel
    {
        [BindProperty]
        public Feedback Feedback { get; set; }

        public string SuccessMessage { get; set; }

        public static List<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        public void OnGet()
        {

        }

        // SendForm
   
        public IActionResult OnPostSend()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }
            Feedbacks.Add(Feedback);
            SuccessMessage = "Feedback submitted successfully!";
            return Page();
        }

        //Clear Form
        public IActionResult OnPostClear()
        {
            ModelState.Clear();
            Feedback = new Feedback();
            return Page();
        }
    }
}
