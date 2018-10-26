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
    /// Contains metadata about the build that produced the release being
    /// uploaded
    /// </summary>
    public partial class BuildInfo
    {
        /// <summary>
        /// Initializes a new instance of the BuildInfo class.
        /// </summary>
        public BuildInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildInfo class.
        /// </summary>
        /// <param name="branch">The branch name of the build producing the
        /// release</param>
        /// <param name="commitHash">The commit hash of the build producing the
        /// release</param>
        /// <param name="commitMessage">The commit message of the build
        /// producing the release</param>
        public BuildInfo(string branch = default(string), string commitHash = default(string), string commitMessage = default(string))
        {
            Branch = branch;
            CommitHash = commitHash;
            CommitMessage = commitMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the branch name of the build producing the release
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the commit hash of the build producing the release
        /// </summary>
        [JsonProperty(PropertyName = "commit_hash")]
        public string CommitHash { get; set; }

        /// <summary>
        /// Gets or sets the commit message of the build producing the release
        /// </summary>
        [JsonProperty(PropertyName = "commit_message")]
        public string CommitMessage { get; set; }

    }
}