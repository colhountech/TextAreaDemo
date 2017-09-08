using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TextAreaDemo.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Messages { get; set; }

        public void OnGet()
        {

        }
        public PageResult OnPost()
        {
            if ( ModelState.IsValid)
            {
                //RedirectToPage("Index");
            }
            
            Messages += $"OnPost : Updated On Server {Environment.NewLine}" ;               
            return Page();
        }
    }
}
