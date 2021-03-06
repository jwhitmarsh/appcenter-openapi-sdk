// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResetPasswordUsingTokenRequest
    {
        /// <summary>
        /// Initializes a new instance of the ResetPasswordUsingTokenRequest
        /// class.
        /// </summary>
        public ResetPasswordUsingTokenRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResetPasswordUsingTokenRequest
        /// class.
        /// </summary>
        /// <param name="newPassword">The new password. Needs to be at least 8
        /// characters long and contain at least one lower- and one uppercase
        /// letter.</param>
        /// <param name="token">The reset password token that was sent to the
        /// user</param>
        public ResetPasswordUsingTokenRequest(string newPassword, string token)
        {
            NewPassword = newPassword;
            Token = token;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new password. Needs to be at least 8 characters
        /// long and contain at least one lower- and one uppercase letter.
        /// </summary>
        [JsonProperty(PropertyName = "new_password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the reset password token that was sent to the user
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NewPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NewPassword");
            }
            if (Token == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Token");
            }
        }
    }
}
