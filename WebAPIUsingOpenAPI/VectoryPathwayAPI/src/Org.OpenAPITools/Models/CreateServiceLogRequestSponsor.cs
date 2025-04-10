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
    public partial class CreateServiceLogRequestSponsor : IEquatable<CreateServiceLogRequestSponsor>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServiceLogRequestSponsor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateServiceLogRequestSponsor)obj);
        }

        /// <summary>
        /// Returns true if CreateServiceLogRequestSponsor instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateServiceLogRequestSponsor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateServiceLogRequestSponsor other)
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
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
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
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateServiceLogRequestSponsor left, CreateServiceLogRequestSponsor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateServiceLogRequestSponsor left, CreateServiceLogRequestSponsor right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
