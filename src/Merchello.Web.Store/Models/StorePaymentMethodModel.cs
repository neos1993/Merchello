﻿namespace Merchello.Web.Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Merchello.Core.Gateways.Payment;
    using Merchello.Web.Models.Ui;

    /// <summary>
    /// Represents a PaymentMethodModel.
    /// </summary>
    public class StorePaymentMethodModel : ICheckoutPaymentMethodModel
    {
        /// <summary>
        /// Gets or sets the payment method key.
        /// </summary>
        public Guid PaymentMethodKey { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="SelectListItem"/>.
        /// </summary>
        public IEnumerable<SelectListItem> PaymentMethods { get; set; }

        /// <summary>
        /// Gets or sets the collection of <see cref="IPaymentGatewayMethod"/>.
        /// </summary>
        public IEnumerable<IPaymentGatewayMethod> PaymentGatewayMethods { get; set; }
    }
}