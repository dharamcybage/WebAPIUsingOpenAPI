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
    public partial class ViewableContactExternalInput : IEquatable<ViewableContactExternalInput>
    {
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByEmail
        /// </summary>
        [Required]
        [DataMember(Name="createdByEmail", EmitDefaultValue=false)]
        public string CreatedByEmail { get; set; }

        /// <summary>
        /// Gets or Sets OrgExternalInputId
        /// </summary>
        [DataMember(Name="org_external_input_id", EmitDefaultValue=true)]
        public long? OrgExternalInputId { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets OrgName
        /// </summary>
        [DataMember(Name="orgName", EmitDefaultValue=true)]
        public string OrgName { get; set; }

        /// <summary>
        /// Gets or Sets DualSubmitted
        /// </summary>
        [Required]
        [DataMember(Name="dualSubmitted", EmitDefaultValue=true)]
        public bool DualSubmitted { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByLastName
        /// </summary>
        [Required]
        [DataMember(Name="createdByLastName", EmitDefaultValue=false)]
        public string CreatedByLastName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets ProfileImageUrl
        /// </summary>
        [DataMember(Name="profileImageUrl", EmitDefaultValue=true)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="org_id", EmitDefaultValue=true)]
        public long? OrgId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByFirstName
        /// </summary>
        [Required]
        [DataMember(Name="createdByFirstName", EmitDefaultValue=false)]
        public string CreatedByFirstName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [Required]
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewableContactExternalInput {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CreatedByEmail: ").Append(CreatedByEmail).Append("\n");
            sb.Append("  OrgExternalInputId: ").Append(OrgExternalInputId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
            sb.Append("  DualSubmitted: ").Append(DualSubmitted).Append("\n");
            sb.Append("  CreatedByLastName: ").Append(CreatedByLastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  CreatedByFirstName: ").Append(CreatedByFirstName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ViewableContactExternalInput)obj);
        }

        /// <summary>
        /// Returns true if ViewableContactExternalInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ViewableContactExternalInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewableContactExternalInput other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    CreatedByEmail == other.CreatedByEmail ||
                    CreatedByEmail != null &&
                    CreatedByEmail.Equals(other.CreatedByEmail)
                ) && 
                (
                    OrgExternalInputId == other.OrgExternalInputId ||
                    OrgExternalInputId != null &&
                    OrgExternalInputId.Equals(other.OrgExternalInputId)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    OrgName == other.OrgName ||
                    OrgName != null &&
                    OrgName.Equals(other.OrgName)
                ) && 
                (
                    DualSubmitted == other.DualSubmitted ||
                    
                    DualSubmitted.Equals(other.DualSubmitted)
                ) && 
                (
                    CreatedByLastName == other.CreatedByLastName ||
                    CreatedByLastName != null &&
                    CreatedByLastName.Equals(other.CreatedByLastName)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ProfileImageUrl == other.ProfileImageUrl ||
                    ProfileImageUrl != null &&
                    ProfileImageUrl.Equals(other.ProfileImageUrl)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    OrgId == other.OrgId ||
                    OrgId != null &&
                    OrgId.Equals(other.OrgId)
                ) && 
                (
                    CreatedByFirstName == other.CreatedByFirstName ||
                    CreatedByFirstName != null &&
                    CreatedByFirstName.Equals(other.CreatedByFirstName)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
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
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (CreatedByEmail != null)
                    hashCode = hashCode * 59 + CreatedByEmail.GetHashCode();
                    if (OrgExternalInputId != null)
                    hashCode = hashCode * 59 + OrgExternalInputId.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (OrgName != null)
                    hashCode = hashCode * 59 + OrgName.GetHashCode();
                    
                    hashCode = hashCode * 59 + DualSubmitted.GetHashCode();
                    if (CreatedByLastName != null)
                    hashCode = hashCode * 59 + CreatedByLastName.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ProfileImageUrl != null)
                    hashCode = hashCode * 59 + ProfileImageUrl.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (OrgId != null)
                    hashCode = hashCode * 59 + OrgId.GetHashCode();
                    if (CreatedByFirstName != null)
                    hashCode = hashCode * 59 + CreatedByFirstName.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ViewableContactExternalInput left, ViewableContactExternalInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ViewableContactExternalInput left, ViewableContactExternalInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
