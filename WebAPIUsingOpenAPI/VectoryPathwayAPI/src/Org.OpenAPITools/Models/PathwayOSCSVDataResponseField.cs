/*
 * Pathwayos API
 *
 * Pathwayos API description
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PathwayOSCSVDataResponseField : IEquatable<PathwayOSCSVDataResponseField>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=true)]
        public long Type { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [Required]
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<PathwayOSCSVDataResponseFieldOption> Options { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [Required]
        [DataMember(Name="required", EmitDefaultValue=true)]
        public bool Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PathwayOSCSVDataResponseField {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((PathwayOSCSVDataResponseField)obj);
        }

        /// <summary>
        /// Returns true if PathwayOSCSVDataResponseField instances are equal
        /// </summary>
        /// <param name="other">Instance of PathwayOSCSVDataResponseField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PathwayOSCSVDataResponseField other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Options == other.Options ||
                    Options != null &&
                    other.Options != null &&
                    Options.SequenceEqual(other.Options)
                ) && 
                (
                    Required == other.Required ||
                    
                    Required.Equals(other.Required)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                    
                    hashCode = hashCode * 59 + Required.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PathwayOSCSVDataResponseField left, PathwayOSCSVDataResponseField right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PathwayOSCSVDataResponseField left, PathwayOSCSVDataResponseField right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
