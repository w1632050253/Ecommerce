﻿using Ecommerce.Shared;

namespace Ecommerce.Client.Service.CategoryService
{
    public interface ICategoryService
    {
         List<Category> Categories { get; set; }

        Task GetCategories();

    }
}
