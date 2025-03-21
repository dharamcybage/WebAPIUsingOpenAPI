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
    public partial class UserPerkinsReport : IEquatable<UserPerkinsReport>
    {
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user", EmitDefaultValue=false)]
        public BasicUser User { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status", EmitDefaultValue=true)]
        public long Status { get; set; }

        /// <summary>
        /// Gets or Sets Sequence
        /// </summary>
        [Required]
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public UserPerkinsReportFullSequenceData Sequence { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYear
        /// </summary>
        [Required]
        [DataMember(Name="schoolYear", EmitDefaultValue=true)]
        public long SchoolYear { get; set; }

        /// <summary>
        /// Gets or Sets CompletedCourses
        /// </summary>
        [Required]
        [DataMember(Name="completedCourses", EmitDefaultValue=false)]
        public List<UserPerkinsReportCompletedCourseOrder> CompletedCourses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPerkinsReport {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  CompletedCourses: ").Append(CompletedCourses).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserPerkinsReport)obj);
        }

        /// <summary>
        /// Returns true if UserPerkinsReport instances are equal
        /// </summary>
        /// <param name="other">Instance of UserPerkinsReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPerkinsReport other)
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
                    Status == other.Status ||
                    
                    Status.Equals(other.Status)
                ) && 
                (
                    Sequence == other.Sequence ||
                    Sequence != null &&
                    Sequence.Equals(other.Sequence)
                ) && 
                (
                    SchoolYear == other.SchoolYear ||
                    
                    SchoolYear.Equals(other.SchoolYear)
                ) && 
                (
                    CompletedCourses == other.CompletedCourses ||
                    CompletedCourses != null &&
                    other.CompletedCourses != null &&
                    CompletedCourses.SequenceEqual(other.CompletedCourses)
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
                    
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Sequence != null)
                    hashCode = hashCode * 59 + Sequence.GetHashCode();
                    
                    hashCode = hashCode * 59 + SchoolYear.GetHashCode();
                    if (CompletedCourses != null)
                    hashCode = hashCode * 59 + CompletedCourses.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserPerkinsReport left, UserPerkinsReport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserPerkinsReport left, UserPerkinsReport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
