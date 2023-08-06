using System;
namespace RazorPagesCadastro.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
    }
}