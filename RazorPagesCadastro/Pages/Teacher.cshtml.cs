using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCadastro.Models;

namespace RazorPagesCadastro.Pages
{
	public class TeacherModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        [BindProperty]
        public required Teacher NewTeacher { get; set; }

        public TeacherModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Teachers = _context.Teachers.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Teachers.Add(NewTeacher);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}