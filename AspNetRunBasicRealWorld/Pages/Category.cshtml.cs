﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetRunBasicRealWorld.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRunBasicRealWorld
{
    public class CategoryModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public CategoryModel(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IEnumerable<Entities.Category> CategoryList { get; set; } = new List<Entities.Category>();

        public async Task<IActionResult> OnGetAsync()
        {
            CategoryList = await _productRepository.GetCategories();
            return Page();
        }
        
    }
}