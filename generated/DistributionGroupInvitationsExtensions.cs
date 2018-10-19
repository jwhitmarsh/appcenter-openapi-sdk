// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DistributionGroupInvitations.
    /// </summary>
    public static partial class DistributionGroupInvitationsExtensions
    {
            /// <summary>
            /// Accepts all pending invitations to distribution groups for the specified
            /// user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void AcceptAll(this IDistributionGroupInvitations operations)
            {
                operations.AcceptAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Accepts all pending invitations to distribution groups for the specified
            /// user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AcceptAllAsync(this IDistributionGroupInvitations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AcceptAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}