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
    public partial class TeacherCaseloadResponse : IEquatable<TeacherCaseloadResponse>
    {
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user", EmitDefaultValue=false)]
        public BasicUser User { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [Required]
        [DataMember(Name="count", EmitDefaultValue=true)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets Students
        /// </summary>
        [Required]
        [DataMember(Name="students", EmitDefaultValue=false)]
        public List<BasicUser> Students { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeacherCaseloadResponse {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TeacherCaseloadResponse)obj);
        }

        /// <summary>
        /// Returns true if TeacherCaseloadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TeacherCaseloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeacherCaseloadResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    Count == other.Count ||
                    
                    Count.Equals(other.Count)
                ) && 
                (
                    Students == other.Students ||
                    Students != null &&
                    other.Students != null &&
                    Students.SequenceEqual(other.Students)
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
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    
                    hashCode = hashCode * 59 + Count.GetHashCode();
                    if (Students != null)
                    hashCode = hashCode * 59 + Students.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TeacherCaseloadResponse left, TeacherCaseloadResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TeacherCaseloadResponse left, TeacherCaseloadResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
