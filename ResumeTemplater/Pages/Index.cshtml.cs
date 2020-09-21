using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Vincent";
            LinkedInUsername = "v40450";
            YearsOfExperience = 5;
            Languages = new List<string>
            {
                "C#",
                "JavaScript",
                "Java",
                "C++"
            };

        }
    }
}
