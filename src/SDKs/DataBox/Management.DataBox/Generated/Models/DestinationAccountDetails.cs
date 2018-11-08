// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details for the destination account.
    /// </summary>
    public partial class DestinationAccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the DestinationAccountDetails class.
        /// </summary>
        public DestinationAccountDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DestinationAccountDetails class.
        /// </summary>
        /// <param name="accountId">Destination storage account id.</param>
        public DestinationAccountDetails(string accountId)
        {
            AccountId = accountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets destination storage account id.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AccountId");
            }
        }
    }
}