using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OdeToFood2.Pages
{
    public class GreetingModel : PageModel
    {
        private IGreeter _greeter;


        public GreetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet()
        {
        }
    }
}