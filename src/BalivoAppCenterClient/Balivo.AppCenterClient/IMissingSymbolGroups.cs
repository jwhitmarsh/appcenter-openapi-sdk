// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// MissingSymbolGroups operations.
    /// </summary>
    public partial interface IMissingSymbolGroups
    {
        /// <summary>
        /// Gets application level statistics for all missing symbol groups
        /// </summary>
        /// <remarks>
        /// Gets application level statistics for all missing symbol groups
        /// </remarks>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MissingSymbolCrashGroupsInfoResponse>> InfoWithHttpMessagesAsync(string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets missing symbol crash group by its id
        /// </summary>
        /// <remarks>
        /// Gets missing symbol crash group by its id
        /// </remarks>
        /// <param name='symbolGroupId'>
        /// missing symbol crash group id
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MissingSymbolCrashGroupsResponse>> GetWithHttpMessagesAsync(string symbolGroupId, string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets top N (ordered by crash count) of crash groups by missing
        /// symbol
        /// </summary>
        /// <remarks>
        /// Gets top N (ordered by crash count) of crash groups by missing
        /// symbol
        /// </remarks>
        /// <param name='top'>
        /// top N elements
        /// </param>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='filter'>
        /// query filter
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="FailureResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MissingSymbolCrashGroupsResponse>> ListWithHttpMessagesAsync(int top, string ownerName, string appName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}