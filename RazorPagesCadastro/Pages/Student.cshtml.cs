using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCadastro.Models;

namespace RazorPagesCadastro.Pages
{
	public class StudentModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Student> Students { get; set; } = new List<Student>();

        [BindProperty]
        public required Student NewStudent { get; set; }

        public StudentModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Students = _context.Students.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Students.Add(NewStudent);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}