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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CodePushDeploymentReleases.
    /// </summary>
    public static partial class CodePushDeploymentReleasesExtensions
    {
            /// <summary>
            /// Clears a Deployment of releases
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
            public static void Delete(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName)
            {
                operations.DeleteAsync(deploymentName, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Clears a Deployment of releases
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
            public static async Task DeleteAsync(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(deploymentName, ownerName, appName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the history of releases on a Deployment
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
            public static IList<CodePushRelease> Get(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName)
            {
                return operations.GetAsync(deploymentName, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the history of releases on a Deployment
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
            public static async Task<IList<CodePushRelease>> GetAsync(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deploymentName, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new CodePush release for the specified deployment
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
            /// <param name='targetBinaryVersion'>
            /// the binary version of the application
            /// </param>
            /// <param name='package'>
            /// The upload zip file
            /// </param>
            /// <param name='deploymentName1'>
            /// This specifies which deployment you want to release the update to. Default
            /// is Staging.
            /// </param>
            /// <param name='description'>
            /// This provides an optional "change log" for the deployment.
            /// </param>
            /// <param name='disabled'>
            /// This specifies whether an update should be downloadable by end users or
            /// not.
            /// </param>
            /// <param name='mandatory'>
            /// This specifies whether the update should be considered mandatory or not
            /// (e.g. it includes a critical security fix).
            /// </param>
            /// <param name='noDuplicateReleaseError'>
            /// This specifies that if the update is identical to the latest release on the
            /// deployment, the CLI should generate a warning instead of an error.
            /// </param>
            /// <param name='rollout'>
            /// This specifies the percentage of users (as an integer between 1 and 100)
            /// that should be eligible to receive this update.
            /// </param>
            public static CodePushRelease Create(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName, string targetBinaryVersion, Stream package = default(Stream), string deploymentName1 = default(string), string description = default(string), bool? disabled = default(bool?), bool? mandatory = default(bool?), bool? noDuplicateReleaseError = default(bool?), int? rollout = default(int?))
            {
                return operations.CreateAsync(deploymentName, ownerName, appName, targetBinaryVersion, package, deploymentName1, description, disabled, mandatory, noDuplicateReleaseError, rollout).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new CodePush release for the specified deployment
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
            /// <param name='targetBinaryVersion'>
            /// the binary version of the application
            /// </param>
            /// <param name='package'>
            /// The upload zip file
            /// </param>
            /// <param name='deploymentName1'>
            /// This specifies which deployment you want to release the update to. Default
            /// is Staging.
            /// </param>
            /// <param name='description'>
            /// This provides an optional "change log" for the deployment.
            /// </param>
            /// <param name='disabled'>
            /// This specifies whether an update should be downloadable by end users or
            /// not.
            /// </param>
            /// <param name='mandatory'>
            /// This specifies whether the update should be considered mandatory or not
            /// (e.g. it includes a critical security fix).
            /// </param>
            /// <param name='noDuplicateReleaseError'>
            /// This specifies that if the update is identical to the latest release on the
            /// deployment, the CLI should generate a warning instead of an error.
            /// </param>
            /// <param name='rollout'>
            /// This specifies the percentage of users (as an integer between 1 and 100)
            /// that should be eligible to receive this update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CodePushRelease> CreateAsync(this ICodePushDeploymentReleases operations, string deploymentName, string ownerName, string appName, string targetBinaryVersion, Stream package = default(Stream), string deploymentName1 = default(string), string description = default(string), bool? disabled = default(bool?), bool? mandatory = default(bool?), bool? noDuplicateReleaseError = default(bool?), int? rollout = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(deploymentName, ownerName, appName, targetBinaryVersion, package, deploymentName1, description, disabled, mandatory, noDuplicateReleaseError, rollout, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}