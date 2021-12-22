using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Add_To_Cart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBaseRepostory<Product> _ProductRepo;
        public ProductController(IBaseRepostory<Product> ProductRepo)
        {
            _ProductRepo = ProductRepo;
        }

        [HttpGet]
        public async Task <IActionResult> GetByID(int id)
        {
            return  Ok(await _ProductRepo.GetByID(1));
        }
    }
}
