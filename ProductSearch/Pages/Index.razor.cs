﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;


namespace ProductSearch.Pages
{
    public class IndexBase : ComponentBase
    {
        protected string SearchTerm { get; set; }

        List<Data.Product> Products { get; set; } = new List<Data.Product>
        {
            new Data.Product {Title = "Smart speaker", Price = 22m, Image = "test-image.png"},
            new Data.Product {Title = "Dumb speaker", Price = 89m, Image = "test-image.png"},
            new Data.Product {Title = "Speaker cable", Price = 12m, Image = "test-image.png"},
            new Data.Product {Title = "T-Shirt", Price = 32m, Image = "test-image.png"},
            new Data.Product {Title = "Large TV", Price = 119.90m, Image = "test-image.png"},
        };

        protected IEnumerable<Data.Product> SearchResults =>
               Products.Where(p =>
                   string.IsNullOrEmpty(SearchTerm)
                   || p.Title.ToLower().Contains(SearchTerm.ToLower())
               );
    }
}
