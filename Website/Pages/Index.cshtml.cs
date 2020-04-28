﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Items { get; protected set; }

        [BindProperty]
        public string SearchTerms { get; set; }

        [BindProperty]
        public string[] Options { get; set; }

        [BindProperty]
        public double? PriceMax { get; set; }

        [BindProperty]
        public double? PriceMin { get; set; }

        [BindProperty]
        public double? CaloriesMax { get; set; }

        [BindProperty]
        public double? CaloriesMin { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page.
        /// </summary>
        public void OnGet()
        {
            Items = Menu.All;
            Options = Request.Query["Options"];
        }

        public void OnPost()
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByOptions(Items, Options);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        }
    }
}
