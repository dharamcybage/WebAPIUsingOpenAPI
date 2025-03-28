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
    public partial class StudentRegistrationRequest : IEquatable<StudentRegistrationRequest>
    {
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [Required]
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Grade
        /// </summary>
        [DataMember(Name="grade", EmitDefaultValue=true)]
        public long? Grade { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolId
        /// </summary>
        [Required]
        [DataMember(Name="school_id", EmitDefaultValue=true)]
        public long SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [Required]
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public long Gender { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [Required]
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentRegistrationRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StudentRegistrationRequest)obj);
        }

        /// <summary>
        /// Returns true if StudentRegistrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentRegistrationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    ShortName == other.ShortName ||
                    ShortName != null &&
                    ShortName.Equals(other.ShortName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    Grade == other.Grade ||
                    Grade != null &&
                    Grade.Equals(other.Grade)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    SchoolId == other.SchoolId ||
                    
                    SchoolId.Equals(other.SchoolId)
                ) && 
                (
                    Gender == other.Gender ||
                    
                    Gender.Equals(other.Gender)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
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
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (ShortName != null)
                    hashCode = hashCode * 59 + ShortName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (Grade != null)
                    hashCode = hashCode * 59 + Grade.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    
                    hashCode = hashCode * 59 + SchoolId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StudentRegistrationRequest left, StudentRegistrationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StudentRegistrationRequest left, StudentRegistrationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
