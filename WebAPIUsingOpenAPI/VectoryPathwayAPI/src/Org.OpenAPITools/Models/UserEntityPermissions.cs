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
    public partial class UserEntityPermissions : IEquatable<UserEntityPermissions>
    {
        /// <summary>
        /// Gets or Sets CanCreateExperiences
        /// </summary>
        [Required]
        [DataMember(Name="canCreateExperiences", EmitDefaultValue=true)]
        public bool CanCreateExperiences { get; set; }

        /// <summary>
        /// Gets or Sets CanEditExperiences
        /// </summary>
        [Required]
        [DataMember(Name="canEditExperiences", EmitDefaultValue=true)]
        public bool CanEditExperiences { get; set; }

        /// <summary>
        /// Gets or Sets CanViewOrganizations
        /// </summary>
        [Required]
        [DataMember(Name="canViewOrganizations", EmitDefaultValue=true)]
        public bool CanViewOrganizations { get; set; }

        /// <summary>
        /// Gets or Sets CanEditContacts
        /// </summary>
        [Required]
        [DataMember(Name="canEditContacts", EmitDefaultValue=true)]
        public bool CanEditContacts { get; set; }

        /// <summary>
        /// Gets or Sets CanCreateOrganizations
        /// </summary>
        [Required]
        [DataMember(Name="canCreateOrganizations", EmitDefaultValue=true)]
        public bool CanCreateOrganizations { get; set; }

        /// <summary>
        /// Gets or Sets CanCreateContacts
        /// </summary>
        [Required]
        [DataMember(Name="canCreateContacts", EmitDefaultValue=true)]
        public bool CanCreateContacts { get; set; }

        /// <summary>
        /// Gets or Sets CanViewContacts
        /// </summary>
        [Required]
        [DataMember(Name="canViewContacts", EmitDefaultValue=true)]
        public bool CanViewContacts { get; set; }

        /// <summary>
        /// Gets or Sets CanEditOrganizations
        /// </summary>
        [Required]
        [DataMember(Name="canEditOrganizations", EmitDefaultValue=true)]
        public bool CanEditOrganizations { get; set; }

        /// <summary>
        /// Gets or Sets CanViewExperiences
        /// </summary>
        [Required]
        [DataMember(Name="canViewExperiences", EmitDefaultValue=true)]
        public bool CanViewExperiences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserEntityPermissions {\n");
            sb.Append("  CanCreateExperiences: ").Append(CanCreateExperiences).Append("\n");
            sb.Append("  CanEditExperiences: ").Append(CanEditExperiences).Append("\n");
            sb.Append("  CanViewOrganizations: ").Append(CanViewOrganizations).Append("\n");
            sb.Append("  CanEditContacts: ").Append(CanEditContacts).Append("\n");
            sb.Append("  CanCreateOrganizations: ").Append(CanCreateOrganizations).Append("\n");
            sb.Append("  CanCreateContacts: ").Append(CanCreateContacts).Append("\n");
            sb.Append("  CanViewContacts: ").Append(CanViewContacts).Append("\n");
            sb.Append("  CanEditOrganizations: ").Append(CanEditOrganizations).Append("\n");
            sb.Append("  CanViewExperiences: ").Append(CanViewExperiences).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserEntityPermissions)obj);
        }

        /// <summary>
        /// Returns true if UserEntityPermissions instances are equal
        /// </summary>
        /// <param name="other">Instance of UserEntityPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserEntityPermissions other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CanCreateExperiences == other.CanCreateExperiences ||
                    
                    CanCreateExperiences.Equals(other.CanCreateExperiences)
                ) && 
                (
                    CanEditExperiences == other.CanEditExperiences ||
                    
                    CanEditExperiences.Equals(other.CanEditExperiences)
                ) && 
                (
                    CanViewOrganizations == other.CanViewOrganizations ||
                    
                    CanViewOrganizations.Equals(other.CanViewOrganizations)
                ) && 
                (
                    CanEditContacts == other.CanEditContacts ||
                    
                    CanEditContacts.Equals(other.CanEditContacts)
                ) && 
                (
                    CanCreateOrganizations == other.CanCreateOrganizations ||
                    
                    CanCreateOrganizations.Equals(other.CanCreateOrganizations)
                ) && 
                (
                    CanCreateContacts == other.CanCreateContacts ||
                    
                    CanCreateContacts.Equals(other.CanCreateContacts)
                ) && 
                (
                    CanViewContacts == other.CanViewContacts ||
                    
                    CanViewContacts.Equals(other.CanViewContacts)
                ) && 
                (
                    CanEditOrganizations == other.CanEditOrganizations ||
                    
                    CanEditOrganizations.Equals(other.CanEditOrganizations)
                ) && 
                (
                    CanViewExperiences == other.CanViewExperiences ||
                    
                    CanViewExperiences.Equals(other.CanViewExperiences)
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
                    
                    hashCode = hashCode * 59 + CanCreateExperiences.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanEditExperiences.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanViewOrganizations.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanEditContacts.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanCreateOrganizations.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanCreateContacts.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanViewContacts.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanEditOrganizations.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanViewExperiences.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserEntityPermissions left, UserEntityPermissions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserEntityPermissions left, UserEntityPermissions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
