// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using System.Linq;

    /// <summary>
    /// private Apple connection secrets response
    /// </summary>
    public partial class PrivateAppleSecretResponse : PrivateSharedConnectionResponse
    {
        /// <summary>
        /// Initializes a new instance of the PrivateAppleSecretResponse class.
        /// </summary>
        public PrivateAppleSecretResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateAppleSecretResponse class.
        /// </summary>
        /// <param name="id">id of the shared connection</param>
        /// <param name="displayName">display name of shared connection</param>
        /// <param name="isValid">whether the credentials are valid or
        /// not</param>
        /// <param name="is2FA">if the account is a 2FA account or not</param>
        public PrivateAppleSecretResponse(string id, string displayName = default(string), bool? isValid = default(bool?), bool? is2FA = default(bool?))
            : base(id, displayName, isValid, is2FA)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
