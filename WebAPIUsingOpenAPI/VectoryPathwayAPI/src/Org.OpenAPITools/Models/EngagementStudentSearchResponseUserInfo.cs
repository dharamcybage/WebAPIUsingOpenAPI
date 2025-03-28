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
    public partial class EngagementStudentSearchResponseUserInfo : IEquatable<EngagementStudentSearchResponseUserInfo>
    {
        /// <summary>
        /// Gets or Sets BasicUser
        /// </summary>
        [Required]
        [DataMember(Name="basicUser", EmitDefaultValue=false)]
        public BasicUser BasicUser { get; set; }

        /// <summary>
        /// Gets or Sets Experiences
        /// </summary>
        [Required]
        [DataMember(Name="experiences", EmitDefaultValue=false)]
        public List<EngagementStudentSearchResponseUserInfoExperienceInfo> Experiences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EngagementStudentSearchResponseUserInfo {\n");
            sb.Append("  BasicUser: ").Append(BasicUser).Append("\n");
            sb.Append("  Experiences: ").Append(Experiences).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EngagementStudentSearchResponseUserInfo)obj);
        }

        /// <summary>
        /// Returns true if EngagementStudentSearchResponseUserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of EngagementStudentSearchResponseUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EngagementStudentSearchResponseUserInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BasicUser == other.BasicUser ||
                    BasicUser != null &&
                    BasicUser.Equals(other.BasicUser)
                ) && 
                (
                    Experiences == other.Experiences ||
                    Experiences != null &&
                    other.Experiences != null &&
                    Experiences.SequenceEqual(other.Experiences)
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
                    if (BasicUser != null)
                    hashCode = hashCode * 59 + BasicUser.GetHashCode();
                    if (Experiences != null)
                    hashCode = hashCode * 59 + Experiences.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EngagementStudentSearchResponseUserInfo left, EngagementStudentSearchResponseUserInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EngagementStudentSearchResponseUserInfo left, EngagementStudentSearchResponseUserInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
