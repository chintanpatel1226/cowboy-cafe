/// <summary>
/// Author:  Chintan Patel
/// Class: CIS 400
/// Purpose: A public class connecting the PageModel to the class.
/// References: Nathan Bean
/// </summary>
using System;
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
        /// <summary>
        /// The menu items to display on the index page.
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The menu item to be searched for.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The avaailable options in the menu.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Options { get; set; }

        /// <summary>
        /// THe max price range.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The minimum price range.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The max calories range.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum calories range.
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }
        
        /// <summary>
        /// Gets the search results for display on the index page.
        /// </summary>
        public void OnGet()
        {
            Items = Menu.All;
            SearchTerms = Request.Query["SearchTerms"];
            Options = Request.Query["Options"];
        }

        /// <summary>
        /// Gets the post results for display on the index page.
        /// </summary>
        public void OnPost()
        {
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByOptions(Items, Options);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        }
    }
}
