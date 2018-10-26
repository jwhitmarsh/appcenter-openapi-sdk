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
    /// AppInvitations operations.
    /// </summary>
    public partial interface IAppInvitations
    {
        /// <summary>
        /// Rejects a pending invitation for the specified user
        /// </summary>
        /// <param name='invitationToken'>
        /// The app invitation token that was sent to the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> RejectWithHttpMessagesAsync(string invitationToken, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Accepts a pending invitation for the specified user
        /// </summary>
        /// <param name='invitationToken'>
        /// The app invitation token that was sent to the user
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AcceptWithHttpMessagesAsync(string invitationToken, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Invites a new or existing user to an app
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='userEmail'>
        /// The email of the user to invite
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Obsolete("This operation is deprecated. Please do not use it any longer.")]
        Task<HttpOperationResponse> CreateByEmailWithHttpMessagesAsync(string ownerName, string appName, string userEmail, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update pending invitation permission
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='userEmail'>
        /// The email of the user to invite
        /// </param>
        /// <param name='userInvitationPermissionsData'>
        /// The value to update the user permission in the invite.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdatePermissionsWithHttpMessagesAsync(string ownerName, string appName, string userEmail, UserInvitationPermissionsUpdateRequest userInvitationPermissionsData = default(UserInvitationPermissionsUpdateRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a user's invitation to an app
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='userEmail'>
        /// The email of the user to invite
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string ownerName, string appName, string userEmail, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Invites a new or existing user to an app
        /// </summary>
        /// <param name='ownerName'>
        /// The name of the owner
        /// </param>
        /// <param name='appName'>
        /// The name of the application
        /// </param>
        /// <param name='userEmail'>
        /// The email of the user to invite
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> CreateWithHttpMessagesAsync(string ownerName, string appName, UserEmailRequest userEmail = default(UserEmailRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the pending invitations for the app
        /// </summary>
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AppInvitationDetailResponse>> ListWithHttpMessagesAsync(string ownerName, string appName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}