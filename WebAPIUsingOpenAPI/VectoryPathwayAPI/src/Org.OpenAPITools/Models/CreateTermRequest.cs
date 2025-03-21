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
    public partial class CreateTermRequest : IEquatable<CreateTermRequest>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearId
        /// </summary>
        [Required]
        [DataMember(Name="school_year_id", EmitDefaultValue=true)]
        public long SchoolYearId { get; set; }

        /// <summary>
        /// Gets or Sets UploadId
        /// </summary>
        [Required]
        [DataMember(Name="uploadId", EmitDefaultValue=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTermRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SchoolYearId: ").Append(SchoolYearId).Append("\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateTermRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateTermRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateTermRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTermRequest other)
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
                    SchoolYearId == other.SchoolYearId ||
                    
                    SchoolYearId.Equals(other.SchoolYearId)
                ) && 
                (
                    UploadId == other.UploadId ||
                    UploadId != null &&
                    UploadId.Equals(other.UploadId)
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
                    
                    hashCode = hashCode * 59 + SchoolYearId.GetHashCode();
                    if (UploadId != null)
                    hashCode = hashCode * 59 + UploadId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateTermRequest left, CreateTermRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateTermRequest left, CreateTermRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
