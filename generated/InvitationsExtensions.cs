// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Invitations.
    /// </summary>
    public static partial class InvitationsExtensions
    {
            /// <summary>
            /// Returns all invitations sent by the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<GDPRInvitationDetailResponse> Sent(this IInvitations operations)
            {
                return operations.SentAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all invitations sent by the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<GDPRInvitationDetailResponse>> SentAsync(this IInvitations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SentWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
