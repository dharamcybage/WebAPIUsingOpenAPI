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
    public partial class ManuallyAddedWorkflowFormRecipientRequest : IEquatable<ManuallyAddedWorkflowFormRecipientRequest>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=true)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets SigningOrder
        /// </summary>
        [DataMember(Name="signingOrder", EmitDefaultValue=true)]
        public long? SigningOrder { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets Responsibility
        /// </summary>
        [Required]
        [DataMember(Name="responsibility", EmitDefaultValue=true)]
        public long Responsibility { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManuallyAddedWorkflowFormRecipientRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SigningOrder: ").Append(SigningOrder).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Responsibility: ").Append(Responsibility).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ManuallyAddedWorkflowFormRecipientRequest)obj);
        }

        /// <summary>
        /// Returns true if ManuallyAddedWorkflowFormRecipientRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ManuallyAddedWorkflowFormRecipientRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManuallyAddedWorkflowFormRecipientRequest other)
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
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.Equals(other.Organization)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    SigningOrder == other.SigningOrder ||
                    SigningOrder != null &&
                    SigningOrder.Equals(other.SigningOrder)
                ) && 
                (
                    Role == other.Role ||
                    Role != null &&
                    Role.Equals(other.Role)
                ) && 
                (
                    Responsibility == other.Responsibility ||
                    
                    Responsibility.Equals(other.Responsibility)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
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
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (SigningOrder != null)
                    hashCode = hashCode * 59 + SigningOrder.GetHashCode();
                    if (Role != null)
                    hashCode = hashCode * 59 + Role.GetHashCode();
                    
                    hashCode = hashCode * 59 + Responsibility.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ManuallyAddedWorkflowFormRecipientRequest left, ManuallyAddedWorkflowFormRecipientRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ManuallyAddedWorkflowFormRecipientRequest left, ManuallyAddedWorkflowFormRecipientRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
