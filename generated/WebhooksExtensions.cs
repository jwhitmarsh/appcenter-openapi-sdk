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
    /// Extension methods for Webhooks.
    /// </summary>
    public static partial class WebhooksExtensions
    {
            /// <summary>
            /// Get web hooks configured for a particular app
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static AlertWebhookListResult List(this IWebhooks operations, string ownerName, string appName)
            {
                return operations.ListAsync(ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get web hooks configured for a particular app
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AlertWebhookListResult> ListAsync(this IWebhooks operations, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
