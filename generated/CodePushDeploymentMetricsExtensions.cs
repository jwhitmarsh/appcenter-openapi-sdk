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
    /// Extension methods for CodePushDeploymentMetrics.
    /// </summary>
    public static partial class CodePushDeploymentMetricsExtensions
    {
            /// <summary>
            /// Gets all releases metrics for specified Deployment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentName'>
            /// deployment name
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static IList<CodePushReleaseMetric> Get(this ICodePushDeploymentMetrics operations, string deploymentName, string ownerName, string appName)
            {
                return operations.GetAsync(deploymentName, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all releases metrics for specified Deployment
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentName'>
            /// deployment name
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
            public static async Task<IList<CodePushReleaseMetric>> GetAsync(this ICodePushDeploymentMetrics operations, string deploymentName, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deploymentName, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
