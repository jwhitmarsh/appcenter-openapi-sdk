// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Balivo.AppCenterClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ExportEntity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportEntity
    {
        [EnumMember(Value = "crashes")]
        Crashes,
        [EnumMember(Value = "errors")]
        Errors,
        [EnumMember(Value = "attachments")]
        Attachments
    }
    internal static class ExportEntityEnumExtension
    {
        internal static string ToSerializedValue(this ExportEntity? value)
        {
            return value == null ? null : ((ExportEntity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ExportEntity value)
        {
            switch( value )
            {
                case ExportEntity.Crashes:
                    return "crashes";
                case ExportEntity.Errors:
                    return "errors";
                case ExportEntity.Attachments:
                    return "attachments";
            }
            return null;
        }

        internal static ExportEntity? ParseExportEntity(this string value)
        {
            switch( value )
            {
                case "crashes":
                    return ExportEntity.Crashes;
                case "errors":
                    return ExportEntity.Errors;
                case "attachments":
                    return ExportEntity.Attachments;
            }
            return null;
        }
    }
}