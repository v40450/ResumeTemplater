using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages
{
    public class AboutMeModel : PageModel
    {
        public string Email { get; set; }
        public string Description { get; set; }
        public void OnGet()
        {
            Description = "Hello! I'm Vincent, a software engineer based in Perth, AU who enjoys building things that live on the internet. I focus on developing web apps that provide intuitive, user interfaces with efficient and modern backends.";
            Email = "v40450@gmail.com";

        }
    }
}