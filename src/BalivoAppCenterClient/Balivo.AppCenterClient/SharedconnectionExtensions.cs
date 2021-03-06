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
    /// Extension methods for Sharedconnection.
    /// </summary>
    public static partial class SharedconnectionExtensions
    {
            /// <summary>
            /// Gets all service connections of the service type for GDPR export.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<SharedConnectionResponse> Connections(this ISharedconnection operations)
            {
                return operations.ConnectionsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all service connections of the service type for GDPR export.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SharedConnectionResponse>> ConnectionsAsync(this ISharedconnection operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ConnectionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
