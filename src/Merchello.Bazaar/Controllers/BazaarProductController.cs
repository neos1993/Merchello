﻿namespace Merchello.Bazaar.Controllers
{
    using System.Web.Mvc;

    using Merchello.Bazaar.Models;

    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;

    /// <summary>
    /// Controller responsible for displaying Merchello Product.
    /// </summary>
    [PluginController("Bazaar")]
    public class BazaarProductController : RenderControllerBase
    {
        /// <summary>
        /// The index <see cref="ActionResult"/>.
        /// </summary>
        /// <param name="model">
        /// The current render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public override ActionResult Index(RenderModel model)
        {
            var viewModel = this.Populate(new ProductModel(model.Content));

            return this.View(viewModel.ThemeViewPath("Product"), viewModel);
        }
    }
}