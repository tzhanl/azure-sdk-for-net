// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object that represents Communication resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CommunicationDetails
    {
        /// <summary>
        /// Initializes a new instance of the CommunicationDetails class.
        /// </summary>
        public CommunicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommunicationDetails class.
        /// </summary>
        /// <param name="communicationType">Communication type. Possible values
        /// include: 'web', 'phone'</param>
        /// <param name="communicationDirection">Direction of communication.
        /// Possible values include: 'inbound', 'outbound'</param>
        /// <param name="id">Id of the resource</param>
        /// <param name="name">Name of the resource</param>
        /// <param name="type">Type of the resource
        /// 'Microsoft.Support/communications</param>
        /// <param name="sender">Sender of the communication.</param>
        /// <param name="subject">Subject of the communication.</param>
        /// <param name="body">Body of the communication.</param>
        /// <param name="createdDate">Time in UTC (ISO 8601 format) when the
        /// communication was created.</param>
        public CommunicationDetails(string communicationType, string communicationDirection, string id = default(string), string name = default(string), string type = default(string), string sender = default(string), string subject = default(string), string body = default(string), System.DateTime? createdDate = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            Type = type;
            CommunicationType = communicationType;
            CommunicationDirection = communicationDirection;
            Sender = sender;
            Subject = subject;
            Body = body;
            CreatedDate = createdDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the resource 'Microsoft.Support/communications
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets communication type. Possible values include: 'web',
        /// 'phone'
        /// </summary>
        [JsonProperty(PropertyName = "properties.communicationType")]
        public string CommunicationType { get; set; }

        /// <summary>
        /// Gets or sets direction of communication. Possible values include:
        /// 'inbound', 'outbound'
        /// </summary>
        [JsonProperty(PropertyName = "properties.communicationDirection")]
        public string CommunicationDirection { get; set; }

        /// <summary>
        /// Gets or sets sender of the communication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sender")]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or sets subject of the communication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets body of the communication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets time in UTC (ISO 8601 format) when the communication
        /// was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CommunicationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommunicationType");
            }
            if (CommunicationDirection == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommunicationDirection");
            }
        }
    }
}
