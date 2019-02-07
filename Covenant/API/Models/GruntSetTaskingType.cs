// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GruntSetTaskingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GruntSetTaskingType
    {
        [EnumMember(Value = "Delay")]
        Delay,
        [EnumMember(Value = "Jitter")]
        Jitter,
        [EnumMember(Value = "ConnectAttempts")]
        ConnectAttempts
    }
    internal static class GruntSetTaskingTypeEnumExtension
    {
        internal static string ToSerializedValue(this GruntSetTaskingType? value)
        {
            return value == null ? null : ((GruntSetTaskingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GruntSetTaskingType value)
        {
            switch( value )
            {
                case GruntSetTaskingType.Delay:
                    return "Delay";
                case GruntSetTaskingType.Jitter:
                    return "Jitter";
                case GruntSetTaskingType.ConnectAttempts:
                    return "ConnectAttempts";
            }
            return null;
        }

        internal static GruntSetTaskingType? ParseGruntSetTaskingType(this string value)
        {
            switch( value )
            {
                case "Delay":
                    return GruntSetTaskingType.Delay;
                case "Jitter":
                    return GruntSetTaskingType.Jitter;
                case "ConnectAttempts":
                    return GruntSetTaskingType.ConnectAttempts;
            }
            return null;
        }
    }
}
