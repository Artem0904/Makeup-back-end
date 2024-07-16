using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Makeup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService productsService;
        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }


        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await productsService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await productsService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateProductModel model)
        {
            productsService.Create(model);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit([FromBody] ProductDto model)
        {
            productsService.Edit(model);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            productsService.Delete(id);
            return Ok();
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            return Ok(productsService.GetAllCategories());
        }

        [HttpGet("genders")]
        public IActionResult GetGenders()
        {
            return Ok(productsService.GetAllGenders());
        }

        [HttpGet("brands")]
        public IActionResult GetBrands()
        {
            return Ok(productsService.GetAllBrands());
        }
    }
}
