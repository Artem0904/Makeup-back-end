using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductsService
    {
        Task<IEnumerable<ProductDto>> GetAll();
        IEnumerable<ProductDto> Get(IEnumerable<int> ids);
        Task<ProductDto?> Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        IEnumerable<GenderDto> GetAllGenders();
        IEnumerable<BrandDto> GetAllBrands();
        void Create(CreateProductModel product);
        void Edit(ProductDto product);
        void Delete(int id);
    }
}
