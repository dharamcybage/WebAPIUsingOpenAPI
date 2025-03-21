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
    public partial class TeacherProfileResponse : IEquatable<TeacherProfileResponse>
    {
        /// <summary>
        /// Gets or Sets Submission
        /// </summary>
        [DataMember(Name="submission", EmitDefaultValue=false)]
        public FormSubmissionResponse Submission { get; set; }

        /// <summary>
        /// Gets or Sets EntityPermissions
        /// </summary>
        [Required]
        [DataMember(Name="entityPermissions", EmitDefaultValue=false)]
        public UserEntityPermissions EntityPermissions { get; set; }

        /// <summary>
        /// Gets or Sets FormResponse
        /// </summary>
        [DataMember(Name="formResponse", EmitDefaultValue=false)]
        public FormResponse FormResponse { get; set; }

        /// <summary>
        /// Gets or Sets BasicUser
        /// </summary>
        [Required]
        [DataMember(Name="basicUser", EmitDefaultValue=false)]
        public BasicUser BasicUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeacherProfileResponse {\n");
            sb.Append("  Submission: ").Append(Submission).Append("\n");
            sb.Append("  EntityPermissions: ").Append(EntityPermissions).Append("\n");
            sb.Append("  FormResponse: ").Append(FormResponse).Append("\n");
            sb.Append("  BasicUser: ").Append(BasicUser).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TeacherProfileResponse)obj);
        }

        /// <summary>
        /// Returns true if TeacherProfileResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TeacherProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeacherProfileResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Submission == other.Submission ||
                    Submission != null &&
                    Submission.Equals(other.Submission)
                ) && 
                (
                    EntityPermissions == other.EntityPermissions ||
                    EntityPermissions != null &&
                    EntityPermissions.Equals(other.EntityPermissions)
                ) && 
                (
                    FormResponse == other.FormResponse ||
                    FormResponse != null &&
                    FormResponse.Equals(other.FormResponse)
                ) && 
                (
                    BasicUser == other.BasicUser ||
                    BasicUser != null &&
                    BasicUser.Equals(other.BasicUser)
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
                    if (Submission != null)
                    hashCode = hashCode * 59 + Submission.GetHashCode();
                    if (EntityPermissions != null)
                    hashCode = hashCode * 59 + EntityPermissions.GetHashCode();
                    if (FormResponse != null)
                    hashCode = hashCode * 59 + FormResponse.GetHashCode();
                    if (BasicUser != null)
                    hashCode = hashCode * 59 + BasicUser.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TeacherProfileResponse left, TeacherProfileResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TeacherProfileResponse left, TeacherProfileResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
