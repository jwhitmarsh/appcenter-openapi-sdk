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
    /// Extension methods for Devices.
    /// </summary>
    public static partial class DevicesExtensions
    {
            /// <summary>
            /// Registers a user for an existing device
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// The ID of the user
            /// </param>
            /// <param name='body'>
            /// The device info.
            /// </param>
            public static object RegisterUserForDevice(this IDevices operations, string userId, DeviceInfoRequest body)
            {
                return operations.RegisterUserForDeviceAsync(userId, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers a user for an existing device
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userId'>
            /// The ID of the user
            /// </param>
            /// <param name='body'>
            /// The device info.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RegisterUserForDeviceAsync(this IDevices operations, string userId, DeviceInfoRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterUserForDeviceWithHttpMessagesAsync(userId, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the device details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceUdid'>
            /// The UDID of the device
            /// </param>
            public static object DeviceDetails(this IDevices operations, string deviceUdid)
            {
                return operations.DeviceDetailsAsync(deviceUdid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the device details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceUdid'>
            /// The UDID of the device
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeviceDetailsAsync(this IDevices operations, string deviceUdid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeviceDetailsWithHttpMessagesAsync(deviceUdid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes an existing device from a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceUdid'>
            /// The UDID of the device
            /// </param>
            public static ErrorDetails RemoveUserDevice(this IDevices operations, string deviceUdid)
            {
                return operations.RemoveUserDeviceAsync(deviceUdid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes an existing device from a user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceUdid'>
            /// The UDID of the device
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorDetails> RemoveUserDeviceAsync(this IDevices operations, string deviceUdid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveUserDeviceWithHttpMessagesAsync(deviceUdid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all devices associated with the given user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object UserDevicesList(this IDevices operations)
            {
                return operations.UserDevicesListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all devices associated with the given user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UserDevicesListAsync(this IDevices operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UserDevicesListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the resign status to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseId'>
            /// The ID of the release.
            /// </param>
            /// <param name='resignId'>
            /// The ID of the resign operation.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='includeProvisioningProfile'>
            /// A boolean value that indicates if the provisioning profile should be return
            /// in addition to the status. When set to true, the provisioning profile will
            /// be returned only when status is 'complete' or 'preparing_for_testers'.
            /// </param>
            public static object GetReleaseUpdateDevicesStatus(this IDevices operations, string releaseId, string resignId, string ownerName, string appName, bool? includeProvisioningProfile = default(bool?))
            {
                return operations.GetReleaseUpdateDevicesStatusAsync(releaseId, resignId, ownerName, appName, includeProvisioningProfile).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the resign status to the caller
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='releaseId'>
            /// The ID of the release.
            /// </param>
            /// <param name='resignId'>
            /// The ID of the resign operation.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='includeProvisioningProfile'>
            /// A boolean value that indicates if the provisioning profile should be return
            /// in addition to the status. When set to true, the provisioning profile will
            /// be returned only when status is 'complete' or 'preparing_for_testers'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetReleaseUpdateDevicesStatusAsync(this IDevices operations, string releaseId, string resignId, string ownerName, string appName, bool? includeProvisioningProfile = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReleaseUpdateDevicesStatusWithHttpMessagesAsync(releaseId, resignId, ownerName, appName, includeProvisioningProfile, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all devices associated with the given distribution group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='distributionGroupName'>
            /// The name of the distribution group.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='unprovisionedOnly'>
            /// when true, filters out provisioned devices
            /// </param>
            /// <param name='udids'>
            /// multiple UDIDs which should be part of the resulting CSV.
            /// </param>
            public static ErrorDetails ListCsvFormat(this IDevices operations, string distributionGroupName, string ownerName, string appName, bool? unprovisionedOnly = false, IList<string> udids = default(IList<string>))
            {
                return operations.ListCsvFormatAsync(distributionGroupName, ownerName, appName, unprovisionedOnly, udids).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all devices associated with the given distribution group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='distributionGroupName'>
            /// The name of the distribution group.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='unprovisionedOnly'>
            /// when true, filters out provisioned devices
            /// </param>
            /// <param name='udids'>
            /// multiple UDIDs which should be part of the resulting CSV.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ErrorDetails> ListCsvFormatAsync(this IDevices operations, string distributionGroupName, string ownerName, string appName, bool? unprovisionedOnly = false, IList<string> udids = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCsvFormatWithHttpMessagesAsync(distributionGroupName, ownerName, appName, unprovisionedOnly, udids, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns all devices associated with the given distribution group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='distributionGroupName'>
            /// The name of the distribution group.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='releaseId'>
            /// when provided, gets the provisioning state of the devices owned by users of
            /// this distribution group when compared to the provided release.
            /// </param>
            public static object List(this IDevices operations, string distributionGroupName, string ownerName, string appName, double? releaseId = default(double?))
            {
                return operations.ListAsync(distributionGroupName, ownerName, appName, releaseId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns all devices associated with the given distribution group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='distributionGroupName'>
            /// The name of the distribution group.
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            /// <param name='releaseId'>
            /// when provided, gets the provisioning state of the devices owned by users of
            /// this distribution group when compared to the provided release.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ListAsync(this IDevices operations, string distributionGroupName, string ownerName, string appName, double? releaseId = default(double?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(distributionGroupName, ownerName, appName, releaseId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Warning, this operation is not reversible.**
            ///
            /// A successful call to this API will permanently stop ingesting any logs
            /// received via SDK for the given installation ID, and cannot be restored. We
            /// advise caution when using this API, it is designed to permanently disable
            /// collection from a specific installation of the app on a device, usually
            /// following the request from a user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='installId'>
            /// The id of the device
            /// </param>
            /// <param name='ownerName'>
            /// The name of the owner
            /// </param>
            /// <param name='appName'>
            /// The name of the application
            /// </param>
            public static string BlockLogs(this IDevices operations, string installId, string ownerName, string appName)
            {
                return operations.BlockLogsAsync(installId, ownerName, appName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// **Warning, this operation is not reversible.**
            ///
            /// A successful call to this API will permanently stop ingesting any logs
            /// received via SDK for the given installation ID, and cannot be restored. We
            /// advise caution when using this API, it is designed to permanently disable
            /// collection from a specific installation of the app on a device, usually
            /// following the request from a user.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='installId'>
            /// The id of the device
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
            public static async Task<string> BlockLogsAsync(this IDevices operations, string installId, string ownerName, string appName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BlockLogsWithHttpMessagesAsync(installId, ownerName, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
