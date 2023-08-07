using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesCadastro.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
    }
}