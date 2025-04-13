using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Server.DTOs
{
    public class AddCategoryDto
    {
        public string? CategoryName { get; set; }
        public string? CategoryDesc { get; set; }
    }
}
