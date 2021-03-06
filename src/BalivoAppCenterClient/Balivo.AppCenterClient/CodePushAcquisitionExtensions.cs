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
    /// Extension methods for CodePushAcquisition.
    /// </summary>
    public static partial class CodePushAcquisitionExtensions
    {
            /// <summary>
            /// Check for updates
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentKey'>
            /// </param>
            /// <param name='appVersion'>
            /// </param>
            /// <param name='packageHash'>
            /// </param>
            /// <param name='label'>
            /// </param>
            /// <param name='clientUniqueId'>
            /// </param>
            /// <param name='isCompanion'>
            /// </param>
            /// <param name='previousLabelOrAppVersion'>
            /// </param>
            /// <param name='previousDeploymentKey'>
            /// </param>
            public static UpdateCheckResponse UpdateCheck(this ICodePushAcquisition operations, string deploymentKey, string appVersion, string packageHash = default(string), string label = default(string), string clientUniqueId = default(string), bool? isCompanion = default(bool?), string previousLabelOrAppVersion = default(string), string previousDeploymentKey = default(string))
            {
                return operations.UpdateCheckAsync(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion, previousLabelOrAppVersion, previousDeploymentKey).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check for updates
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deploymentKey'>
            /// </param>
            /// <param name='appVersion'>
            /// </param>
            /// <param name='packageHash'>
            /// </param>
            /// <param name='label'>
            /// </param>
            /// <param name='clientUniqueId'>
            /// </param>
            /// <param name='isCompanion'>
            /// </param>
            /// <param name='previousLabelOrAppVersion'>
            /// </param>
            /// <param name='previousDeploymentKey'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UpdateCheckResponse> UpdateCheckAsync(this ICodePushAcquisition operations, string deploymentKey, string appVersion, string packageHash = default(string), string label = default(string), string clientUniqueId = default(string), bool? isCompanion = default(bool?), string previousLabelOrAppVersion = default(string), string previousDeploymentKey = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateCheckWithHttpMessagesAsync(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion, previousLabelOrAppVersion, previousDeploymentKey, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the acquisition service status to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AcquisitionStatusSuccessResponse GetAcquisitionStatus(this ICodePushAcquisition operations)
            {
                return operations.GetAcquisitionStatusAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the acquisition service status to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcquisitionStatusSuccessResponse> GetAcquisitionStatusAsync(this ICodePushAcquisition operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAcquisitionStatusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Report download of specified release
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseMetadata'>
            /// Deployment status metric properties
            /// </param>
            public static void UpdateDownloadStatus(this ICodePushAcquisition operations, CodePushStatusMetricMetadata releaseMetadata)
            {
                operations.UpdateDownloadStatusAsync(releaseMetadata).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Report download of specified release
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseMetadata'>
            /// Deployment status metric properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateDownloadStatusAsync(this ICodePushAcquisition operations, CodePushStatusMetricMetadata releaseMetadata, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateDownloadStatusWithHttpMessagesAsync(releaseMetadata, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Report Deployment status metric
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseMetadata'>
            /// Deployment status metric properties
            /// </param>
            public static void UpdateDeployStatus(this ICodePushAcquisition operations, CodePushStatusMetricMetadata releaseMetadata)
            {
                operations.UpdateDeployStatusAsync(releaseMetadata).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Report Deployment status metric
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseMetadata'>
            /// Deployment status metric properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateDeployStatusAsync(this ICodePushAcquisition operations, CodePushStatusMetricMetadata releaseMetadata, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateDeployStatusWithHttpMessagesAsync(releaseMetadata, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
