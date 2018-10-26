// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of an uploaded release
    /// </summary>
    public partial class PrivateReleaseDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the PrivateReleaseDetailsResponse
        /// class.
        /// </summary>
        public PrivateReleaseDetailsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateReleaseDetailsResponse
        /// class.
        /// </summary>
        /// <param name="id">ID identifying this unique release.</param>
        /// <param name="status">OBSOLETE. Will be removed in next version. The
        /// availability concept is now replaced with distributed. Any
        /// 'available' release will be associated with the default
        /// distribution group of an app.&lt;/br&gt;
        /// The release state.&lt;br&gt;
        /// &lt;b&gt;available&lt;/b&gt;: The uploaded release has been
        /// distributed.&lt;br&gt;
        /// &lt;b&gt;unavailable&lt;/b&gt;: The uploaded release is not visible
        /// to the user. &lt;br&gt;
        /// . Possible values include: 'available', 'unavailable'</param>
        /// <param name="appName">The app's name (extracted from the uploaded
        /// release).</param>
        /// <param name="appDisplayName">The app's display name.</param>
        /// <param name="version">The release's version.&lt;br&gt;
        /// For iOS: CFBundleVersion from info.plist.
        /// For Android: android:versionCode from AppManifest.xml.
        /// </param>
        /// <param name="shortVersion">The release's short version.&lt;br&gt;
        /// For iOS: CFBundleShortVersionString from info.plist.
        /// For Android: android:versionName from AppManifest.xml.
        /// </param>
        /// <param name="releaseNotes">The release's release notes.</param>
        /// <param name="provisioningProfileName">The release's provisioning
        /// profile name.</param>
        /// <param name="provisioningProfileType">The type of the provisioning
        /// profile for the requested app version. Possible values include:
        /// 'adhoc', 'enterprise', 'other'</param>
        /// <param name="isProvisioningProfileSyncing">A flag that determines
        /// whether the release's provisioning profile is still extracted or
        /// not.</param>
        /// <param name="size">The release's size in bytes.</param>
        /// <param name="minOs">The release's minimum required operating
        /// system.</param>
        /// <param name="deviceFamily">The release's device family.</param>
        /// <param name="androidMinApiLevel">The release's minimum required
        /// Android API level.</param>
        /// <param name="bundleIdentifier">The identifier of the apps
        /// bundle.</param>
        /// <param name="fingerprint">MD5 checksum of the release
        /// binary.</param>
        /// <param name="uploadedAt">UTC time in ISO 8601 format of the
        /// uploaded time.</param>
        /// <param name="downloadUrl">The URL that hosts the binary for this
        /// release.</param>
        /// <param name="appIconUrl">A URL to the app's icon.</param>
        /// <param name="installUrl">The href required to install a release on
        /// a mobile device. On iOS devices will be prefixed with
        /// `itms-services://?action=download-manifest&amp;url=`</param>
        /// <param name="distributionGroupId">the destination where release is
        /// distributed</param>
        /// <param name="publishingStatus">the publishing status of the
        /// distributed release</param>
        /// <param name="destinationType">The destination type.&lt;br&gt;
        /// &lt;b&gt;group&lt;/b&gt;: The release distributed to internal
        /// groups and distribution_groups details will be returned.&lt;br&gt;
        /// &lt;b&gt;store&lt;/b&gt;: The release distributed to external
        /// stores and distribution_stores details will be returned. &lt;br&gt;
        /// . Possible values include: 'group', 'store'</param>
        public PrivateReleaseDetailsResponse(int? id = default(int?), string status = default(string), string appName = default(string), string appDisplayName = default(string), string version = default(string), string shortVersion = default(string), string releaseNotes = default(string), string provisioningProfileName = default(string), string provisioningProfileType = default(string), bool? isProvisioningProfileSyncing = default(bool?), int? size = default(int?), string minOs = default(string), string deviceFamily = default(string), string androidMinApiLevel = default(string), string bundleIdentifier = default(string), string fingerprint = default(string), string uploadedAt = default(string), string downloadUrl = default(string), string appIconUrl = default(string), string installUrl = default(string), string distributionGroupId = default(string), string publishingStatus = default(string), string destinationType = default(string))
        {
            Id = id;
            Status = status;
            AppName = appName;
            AppDisplayName = appDisplayName;
            Version = version;
            ShortVersion = shortVersion;
            ReleaseNotes = releaseNotes;
            ProvisioningProfileName = provisioningProfileName;
            ProvisioningProfileType = provisioningProfileType;
            IsProvisioningProfileSyncing = isProvisioningProfileSyncing;
            Size = size;
            MinOs = minOs;
            DeviceFamily = deviceFamily;
            AndroidMinApiLevel = androidMinApiLevel;
            BundleIdentifier = bundleIdentifier;
            Fingerprint = fingerprint;
            UploadedAt = uploadedAt;
            DownloadUrl = downloadUrl;
            AppIconUrl = appIconUrl;
            InstallUrl = installUrl;
            DistributionGroupId = distributionGroupId;
            PublishingStatus = publishingStatus;
            DestinationType = destinationType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID identifying this unique release.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets OBSOLETE. Will be removed in next version. The
        /// availability concept is now replaced with distributed. Any
        /// 'available' release will be associated with the default
        /// distribution group of an app.&amp;lt;/br&amp;gt;
        /// The release state.&amp;lt;br&amp;gt;
        /// &amp;lt;b&amp;gt;available&amp;lt;/b&amp;gt;: The uploaded release
        /// has been distributed.&amp;lt;br&amp;gt;
        /// &amp;lt;b&amp;gt;unavailable&amp;lt;/b&amp;gt;: The uploaded
        /// release is not visible to the user. &amp;lt;br&amp;gt;
        /// . Possible values include: 'available', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the app's name (extracted from the uploaded release).
        /// </summary>
        [JsonProperty(PropertyName = "app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or sets the app's display name.
        /// </summary>
        [JsonProperty(PropertyName = "app_display_name")]
        public string AppDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the release's version.&amp;lt;br&amp;gt;
        /// For iOS: CFBundleVersion from info.plist.
        /// For Android: android:versionCode from AppManifest.xml.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the release's short version.&amp;lt;br&amp;gt;
        /// For iOS: CFBundleShortVersionString from info.plist.
        /// For Android: android:versionName from AppManifest.xml.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "short_version")]
        public string ShortVersion { get; set; }

        /// <summary>
        /// Gets or sets the release's release notes.
        /// </summary>
        [JsonProperty(PropertyName = "release_notes")]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or sets the release's provisioning profile name.
        /// </summary>
        [JsonProperty(PropertyName = "provisioning_profile_name")]
        public string ProvisioningProfileName { get; set; }

        /// <summary>
        /// Gets or sets the type of the provisioning profile for the requested
        /// app version. Possible values include: 'adhoc', 'enterprise',
        /// 'other'
        /// </summary>
        [JsonProperty(PropertyName = "provisioning_profile_type")]
        public string ProvisioningProfileType { get; set; }

        /// <summary>
        /// Gets or sets a flag that determines whether the release's
        /// provisioning profile is still extracted or not.
        /// </summary>
        [JsonProperty(PropertyName = "is_provisioning_profile_syncing")]
        public bool? IsProvisioningProfileSyncing { get; set; }

        /// <summary>
        /// Gets or sets the release's size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or sets the release's minimum required operating system.
        /// </summary>
        [JsonProperty(PropertyName = "min_os")]
        public string MinOs { get; set; }

        /// <summary>
        /// Gets or sets the release's device family.
        /// </summary>
        [JsonProperty(PropertyName = "device_family")]
        public string DeviceFamily { get; set; }

        /// <summary>
        /// Gets or sets the release's minimum required Android API level.
        /// </summary>
        [JsonProperty(PropertyName = "android_min_api_level")]
        public string AndroidMinApiLevel { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the apps bundle.
        /// </summary>
        [JsonProperty(PropertyName = "bundle_identifier")]
        public string BundleIdentifier { get; set; }

        /// <summary>
        /// Gets or sets MD5 checksum of the release binary.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Gets or sets UTC time in ISO 8601 format of the uploaded time.
        /// </summary>
        [JsonProperty(PropertyName = "uploaded_at")]
        public string UploadedAt { get; set; }

        /// <summary>
        /// Gets or sets the URL that hosts the binary for this release.
        /// </summary>
        [JsonProperty(PropertyName = "download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets a URL to the app's icon.
        /// </summary>
        [JsonProperty(PropertyName = "app_icon_url")]
        public string AppIconUrl { get; set; }

        /// <summary>
        /// Gets or sets the href required to install a release on a mobile
        /// device. On iOS devices will be prefixed with
        /// `itms-services://?action=download-manifest&amp;amp;url=`
        /// </summary>
        [JsonProperty(PropertyName = "install_url")]
        public string InstallUrl { get; set; }

        /// <summary>
        /// Gets or sets the destination where release is distributed
        /// </summary>
        [JsonProperty(PropertyName = "distribution_group_id")]
        public string DistributionGroupId { get; set; }

        /// <summary>
        /// Gets or sets the publishing status of the distributed release
        /// </summary>
        [JsonProperty(PropertyName = "publishing_status")]
        public string PublishingStatus { get; set; }

        /// <summary>
        /// Gets or sets the destination type.&amp;lt;br&amp;gt;
        /// &amp;lt;b&amp;gt;group&amp;lt;/b&amp;gt;: The release distributed
        /// to internal groups and distribution_groups details will be
        /// returned.&amp;lt;br&amp;gt;
        /// &amp;lt;b&amp;gt;store&amp;lt;/b&amp;gt;: The release distributed
        /// to external stores and distribution_stores details will be
        /// returned. &amp;lt;br&amp;gt;
        /// . Possible values include: 'group', 'store'
        /// </summary>
        [JsonProperty(PropertyName = "destination_type")]
        public string DestinationType { get; set; }

    }
}