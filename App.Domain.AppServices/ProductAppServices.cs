﻿using App.Domain.Core.Products.Contracts.AppServices;
using App.Domain.Core.Products.Contracts.Services;
using App.Domain.Core.Products.DTOs;
using App.Infra.Data.Repos.EF.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices
{
    public class ProductAppServices : IProductAppServices
    {
        private readonly IProductServices _productService;

        public ProductAppServices(IProductServices productService)
        {
            _productService = productService;
        }

        public async Task Create(ProductInputDto productInputDto, CancellationToken cancellationToken)
        {
            productInputDto.ImageAddress = ImageAppServices.UploadProcess(productInputDto.Image);

            await _productService.Create(productInputDto, cancellationToken);
        }

        public async Task Delete(int Id, CancellationToken cancellationToken)
        {
            var product = await _productService.GetById(Id, cancellationToken);
            if (product != null)
            {
                await _productService.Delete(Id, cancellationToken);
            }
        }

        public async Task<List<ProductOutputDto>> GetAllDeActives(CancellationToken cancellationToken)
        {
            var result = await _productService.GetAll(cancellationToken);
            return result.Where(x => x.IsActive == false).ToList();
        }

        public async Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _productService.GetAll(cancellationToken);
        }

        public async Task<ProductOutputDto> GetById(int Id, CancellationToken cancellationToken)
        {
            return await _productService.GetById(Id, cancellationToken);
        }

        public async Task DeActive(int Id, CancellationToken cancellationToken)
        {
            await _productService.DeActive(Id, cancellationToken);
        }

        public async Task Active(int Id, CancellationToken cancellationToken)
        {
            await _productService.Active(Id, cancellationToken);
        }
    }
}
