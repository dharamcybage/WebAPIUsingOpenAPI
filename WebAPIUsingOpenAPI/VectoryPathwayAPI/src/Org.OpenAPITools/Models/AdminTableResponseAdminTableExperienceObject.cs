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
    public partial class AdminTableResponseAdminTableExperienceObject : IEquatable<AdminTableResponseAdminTableExperienceObject>
    {
        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        [Required]
        [DataMember(Name="object", EmitDefaultValue=false)]
        public AdminTableExperience VarObject { get; set; }

        /// <summary>
        /// Gets or Sets Submission
        /// </summary>
        [DataMember(Name="submission", EmitDefaultValue=false)]
        public AdminTableResponseAdminTableExperienceSubmission Submission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminTableResponseAdminTableExperienceObject {\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  Submission: ").Append(Submission).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AdminTableResponseAdminTableExperienceObject)obj);
        }

        /// <summary>
        /// Returns true if AdminTableResponseAdminTableExperienceObject instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminTableResponseAdminTableExperienceObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminTableResponseAdminTableExperienceObject other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    VarObject == other.VarObject ||
                    VarObject != null &&
                    VarObject.Equals(other.VarObject)
                ) && 
                (
                    Submission == other.Submission ||
                    Submission != null &&
                    Submission.Equals(other.Submission)
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
                    if (VarObject != null)
                    hashCode = hashCode * 59 + VarObject.GetHashCode();
                    if (Submission != null)
                    hashCode = hashCode * 59 + Submission.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AdminTableResponseAdminTableExperienceObject left, AdminTableResponseAdminTableExperienceObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AdminTableResponseAdminTableExperienceObject left, AdminTableResponseAdminTableExperienceObject right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
