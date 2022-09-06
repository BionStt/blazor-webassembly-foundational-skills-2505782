﻿using MyBlazorShopHosted.Libraries.Services.Product.Models;

namespace MyBlazorShopHosted.Libraries.Services.ShoppingCart.Models
{
    /// <summary>
    /// Stores a shopping cart.
    /// </summary>
    public class ShoppingCartModel
    {
        /// <summary>
        /// A list of all the items stored in the shopping cart.
        /// </summary>
        public IList<ShoppingCartItemModel> Items { get; init; }

        /// <summary>
        /// Constructs a new shopping cart.
        /// </summary>
        public ShoppingCartModel()
        {
            Items = new List<ShoppingCartItemModel>();
        }
    }
}
