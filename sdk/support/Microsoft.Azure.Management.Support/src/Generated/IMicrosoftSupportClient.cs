// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Microsoft Azure Support Resource Provider.
    /// </summary>
    public partial interface IMicrosoftSupportClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure subscription id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Api version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IServicesOperations.
        /// </summary>
        IServicesOperations Services { get; }

        /// <summary>
        /// Gets the IProblemClassificationsOperations.
        /// </summary>
        IProblemClassificationsOperations ProblemClassifications { get; }

        /// <summary>
        /// Gets the ISupportTicketsOperations.
        /// </summary>
        ISupportTicketsOperations SupportTickets { get; }

        /// <summary>
        /// Gets the ISupportTicketSubscriptionOperations.
        /// </summary>
        ISupportTicketSubscriptionOperations SupportTicketSubscription { get; }

        /// <summary>
        /// Gets the ICommunicationsOperations.
        /// </summary>
        ICommunicationsOperations Communications { get; }

        /// <summary>
        /// Check the availability of a resource name.
        /// </summary>
        /// <param name='checkNameAvailabilityInput'>
        /// Input to check.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameAvailabilityOutput>> CheckNameAvailabilityWithSubscriptionWithHttpMessagesAsync(CheckNameAvailabilityInput checkNameAvailabilityInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a support ticket for a subscription.
        /// </summary>
        /// <remarks>
        /// A paid support plan is required to use this API to create a support
        /// ticket. Users can create tickets for issues relating to Billing,
        /// Subscription Management, Quota or any of the supported Azure
        /// technical services as indicated by the 'serviceId' in the request.
        /// &lt;br/&gt;&lt;br/&gt;**Billing tickets**&lt;br/&gt;For billing
        /// issues, user must set *serviceId* to
        /// *'/providers/Microsoft.Support/services/517f2da6-78fd-0498-4e22-ad26996b1dfc'*.&lt;br/&gt;&lt;br/&gt;**Subscription
        /// Management tickets**&lt;br/&gt; For issues relating to subscription
        /// management, *serviceId* should be set to
        /// *'/providers/Microsoft.Support/services/f3dc5421-79ef-1efa-41a5-42bf3cbb52c6'*.&lt;br/&gt;&lt;br/&gt;**Technical
        /// tickets**&lt;br/&gt;For technical support ticket, user must set
        /// *serviceId* to one of the technical service ids and must provide
        /// additional information in TechnicalScopingInformation.
        /// &lt;br/&gt;Users must also provide problemClassificationId when
        /// creating a support ticket.&lt;br/&gt;
        /// </remarks>
        /// <param name='supportTicketName'>
        /// Support ticket id.
        /// </param>
        /// <param name='createSupportTicketParameters'>
        /// Support ticket request payload.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SupportTicketDetails>> CreateSupportTicketForSubscriptionWithHttpMessagesAsync(string supportTicketName, CreateSupportTicket createSupportTicketParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds a communication to a support ticket.
        /// </summary>
        /// <param name='supportTicketName'>
        /// Support ticket id.
        /// </param>
        /// <param name='addCommunication'>
        /// Communication object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CommunicationDetails>> AddCommunicationToSubscriptionTicketWithHttpMessagesAsync(string supportTicketName, AddCommunication addCommunication, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a support ticket for a subscription.
        /// </summary>
        /// <remarks>
        /// A paid support plan is required to use this API to create a support
        /// ticket. Users can create tickets for issues relating to Billing,
        /// Subscription Management, Quota or any of the supported Azure
        /// technical services as indicated by the 'serviceId' in the request.
        /// &lt;br/&gt;&lt;br/&gt;**Billing tickets**&lt;br/&gt;For billing
        /// issues, user must set *serviceId* to
        /// *'/providers/Microsoft.Support/services/517f2da6-78fd-0498-4e22-ad26996b1dfc'*.&lt;br/&gt;&lt;br/&gt;**Subscription
        /// Management tickets**&lt;br/&gt; For issues relating to subscription
        /// management, *serviceId* should be set to
        /// *'/providers/Microsoft.Support/services/f3dc5421-79ef-1efa-41a5-42bf3cbb52c6'*.&lt;br/&gt;&lt;br/&gt;**Technical
        /// tickets**&lt;br/&gt;For technical support ticket, user must set
        /// *serviceId* to one of the technical service ids and must provide
        /// additional information in TechnicalScopingInformation.
        /// &lt;br/&gt;Users must also provide problemClassificationId when
        /// creating a support ticket.&lt;br/&gt;
        /// </remarks>
        /// <param name='supportTicketName'>
        /// Support ticket id.
        /// </param>
        /// <param name='createSupportTicketParameters'>
        /// Support ticket request payload.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SupportTicketDetails>> BeginCreateSupportTicketForSubscriptionWithHttpMessagesAsync(string supportTicketName, CreateSupportTicket createSupportTicketParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
