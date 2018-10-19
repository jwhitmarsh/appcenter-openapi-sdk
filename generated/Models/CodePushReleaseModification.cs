// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using System.Linq;

    public partial class CodePushReleaseModification : CodePushReleaseInfo
    {
        /// <summary>
        /// Initializes a new instance of the CodePushReleaseModification
        /// class.
        /// </summary>
        public CodePushReleaseModification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CodePushReleaseModification
        /// class.
        /// </summary>
        public CodePushReleaseModification(string targetBinaryRange = default(string), string description = default(string), bool? isDisabled = default(bool?), bool? isMandatory = default(bool?), int? rollout = default(int?))
            : base(targetBinaryRange, description, isDisabled, isMandatory, rollout)
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
