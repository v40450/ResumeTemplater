using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ResumeTemplater.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; }
        public string GithubUsername { get; set; }
        public void OnGet()
        {
			GithubUsername = "v40450";
			Projects = new List<Project> {
				new Project()
				{
					Title = "Explorella",
					Description = "A large scale travelling application built to help plan your destination and itinerary on your next trip! Built on React, Node, Express, and MongoDB.",
					Year = 2019,
					Technologies = new List<string> {
						"React",
						"Node",
						"Express",
						"MongoDB"
					}
				},
				new Project()
				{
					Title = "Cypher Clothing",
					Description = "A large scale e-commerce clothing store application. Built with Razor Pages and SQLite.",
					Year = 2019,
					Technologies = new List<string> {
						"Razor Pages",
						"SQLite",
					}
				},
				new Project()
				{
					Title = "Password Box",
					Description = "A password manager Chrome plugin used to create and safely store all your passwords! Built with Javascript and HTML.",
					Year = 2020,
					Technologies = new List<string> {
						"Javascript",
						"HTML",
					}
				},
				new Project()
				{
					Title = "Spotivize",
					Description = "Spotivize is a music platform that uses geolocation to track when your favorite artists are playing in your local city! Built with Node, Express, React and MongoDB.",
					Year = 2016,
					Technologies = new List<string> {
						"Express",
						"React",
						"MongoDB"
					}
				}
			};
		}
    }
}