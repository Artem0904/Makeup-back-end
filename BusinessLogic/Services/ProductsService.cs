using Ardalis.Specification;
using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using BusinessLogic.Specefications;
using DataAccess.Data.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Product> productRepo;
        private readonly IRepository<Category> categoryRepo;
        private readonly IRepository<Gender> genderRepo;
        private readonly IRepository<Brand> brandRepo;

        public ProductsService(IMapper mapper, IRepository<Product> productRepo, IRepository<Category> categoryRepo,
            IRepository<Gender> genderRepo, IRepository<Brand> brandRepo)
        {
            this.mapper = mapper;
            this.productRepo = productRepo;
            this.categoryRepo = categoryRepo;
            this.genderRepo = genderRepo;
            this.brandRepo = brandRepo;
        }

        public void Create(CreateProductModel product)
        {
            productRepo.Insert(mapper.Map<Product>(product));
            productRepo.Save();
        }

        public void Delete(int id)
        {
            var product = productRepo.GetByID(id);

            if (product == null) throw new HttpException("Product not found.", HttpStatusCode.NotFound);

            productRepo.Delete(product);
            productRepo.Save();
        }

        public void Edit(ProductDto product)
        {
            productRepo.Update(mapper.Map<Product>(product));
            productRepo.Save();
        }

        public async Task<ProductDto?> Get(int id)
        {
            if (id < 0) throw new HttpException("Id must be positive:)", HttpStatusCode.BadRequest);
            var product = await productRepo.GetItemBySpec(new ProductSpecs.ById(id));
            if (product == null) throw new HttpException("Product not found.", HttpStatusCode.NotFound);

            var dto = mapper.Map<ProductDto>(product);

            return dto;
        }

        public IEnumerable<ProductDto> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<ProductDto>>(productRepo.GetAll());
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            return mapper.Map<List<ProductDto>>(await productRepo.GetListBySpec(new ProductSpecs.All()));
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return mapper.Map<List<CategoryDto>>(categoryRepo.GetAll());
        }

        public IEnumerable<GenderDto> GetAllGenders()
        {
            return mapper.Map<List<GenderDto>>(genderRepo.GetAll());
        }

        public IEnumerable<BrandDto> GetAllBrands()
        {
            return mapper.Map<List<BrandDto>>(brandRepo.GetAll());
        }
    }
}
