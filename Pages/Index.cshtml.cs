using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TextAreaDemo.Pages
{
   
    public class IndexModel : PageModel
    {
       [BindProperty]
        public string Messages { get; set;}

       [BindProperty]
        public bool SimpleCheckBox { get; set;} = true;
    
        public PageResult OnPost()
        {
            ModelState["Messages"].AttemptedValue = $"AttemptedValue: { SimpleCheckBox.ToText() } ";

            return Page();
            
        }
    }

#region Extenstion Methods
    public static class MyExtensions
    {
        public static string ToText(this bool checkBox)
        {
            return (checkBox ? "Checked" : "Not Checked");
        }
    }
#endregion

}
