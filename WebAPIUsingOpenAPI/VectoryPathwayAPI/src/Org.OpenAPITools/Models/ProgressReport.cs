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
    public partial class ProgressReport : IEquatable<ProgressReport>
    {
        /// <summary>
        /// Gets or Sets NumberOfApprovedHours
        /// </summary>
        [Required]
        [DataMember(Name="numberOfApprovedHours", EmitDefaultValue=true)]
        public double NumberOfApprovedHours { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfActivities
        /// </summary>
        [Required]
        [DataMember(Name="numberOfActivities", EmitDefaultValue=true)]
        public long NumberOfActivities { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfExperiences
        /// </summary>
        [Required]
        [DataMember(Name="numberOfExperiences", EmitDefaultValue=true)]
        public long NumberOfExperiences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressReport {\n");
            sb.Append("  NumberOfApprovedHours: ").Append(NumberOfApprovedHours).Append("\n");
            sb.Append("  NumberOfActivities: ").Append(NumberOfActivities).Append("\n");
            sb.Append("  NumberOfExperiences: ").Append(NumberOfExperiences).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProgressReport)obj);
        }

        /// <summary>
        /// Returns true if ProgressReport instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgressReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressReport other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NumberOfApprovedHours == other.NumberOfApprovedHours ||
                    
                    NumberOfApprovedHours.Equals(other.NumberOfApprovedHours)
                ) && 
                (
                    NumberOfActivities == other.NumberOfActivities ||
                    
                    NumberOfActivities.Equals(other.NumberOfActivities)
                ) && 
                (
                    NumberOfExperiences == other.NumberOfExperiences ||
                    
                    NumberOfExperiences.Equals(other.NumberOfExperiences)
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
                    
                    hashCode = hashCode * 59 + NumberOfApprovedHours.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfActivities.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfExperiences.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProgressReport left, ProgressReport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProgressReport left, ProgressReport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
