using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Server.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDesc { get; set; }
    }
}
