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
    public partial class CreateExperienceProposalRequest : IEquatable<CreateExperienceProposalRequest>
    {
        /// <summary>
        /// Gets or Sets OrgPhone
        /// </summary>
        [DataMember(Name="orgPhone", EmitDefaultValue=true)]
        public string OrgPhone { get; set; }

        /// <summary>
        /// Gets or Sets OrgLong
        /// </summary>
        [Required]
        [DataMember(Name="orgLong", EmitDefaultValue=false)]
        public string OrgLong { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceDescription
        /// </summary>
        [Required]
        [DataMember(Name="experienceDescription", EmitDefaultValue=false)]
        public string ExperienceDescription { get; set; }

        /// <summary>
        /// Gets or Sets OrgId
        /// </summary>
        [DataMember(Name="orgId", EmitDefaultValue=true)]
        public long? OrgId { get; set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contactId", EmitDefaultValue=true)]
        public long? ContactId { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="contactPhone", EmitDefaultValue=true)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets ContactLastName
        /// </summary>
        [Required]
        [DataMember(Name="contactLastName", EmitDefaultValue=false)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Gets or Sets OrgLat
        /// </summary>
        [Required]
        [DataMember(Name="orgLat", EmitDefaultValue=false)]
        public string OrgLat { get; set; }

        /// <summary>
        /// Gets or Sets ContactFirstName
        /// </summary>
        [Required]
        [DataMember(Name="contactFirstName", EmitDefaultValue=false)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [Required]
        [DataMember(Name="contactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceName
        /// </summary>
        [Required]
        [DataMember(Name="experienceName", EmitDefaultValue=false)]
        public string ExperienceName { get; set; }

        /// <summary>
        /// Gets or Sets OrgLocation
        /// </summary>
        [Required]
        [DataMember(Name="orgLocation", EmitDefaultValue=false)]
        public string OrgLocation { get; set; }

        /// <summary>
        /// Gets or Sets ContactTitle
        /// </summary>
        [Required]
        [DataMember(Name="contactTitle", EmitDefaultValue=false)]
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or Sets ContactFormSubmissionId
        /// </summary>
        [DataMember(Name="contactFormSubmissionId", EmitDefaultValue=true)]
        public long? ContactFormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets OrgFormSubmissionId
        /// </summary>
        [DataMember(Name="orgFormSubmissionId", EmitDefaultValue=true)]
        public long? OrgFormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceFormSubmissionId
        /// </summary>
        [DataMember(Name="experienceFormSubmissionId", EmitDefaultValue=true)]
        public long? ExperienceFormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets OrgWebsite
        /// </summary>
        [DataMember(Name="orgWebsite", EmitDefaultValue=true)]
        public string OrgWebsite { get; set; }

        /// <summary>
        /// Gets or Sets OrgName
        /// </summary>
        [Required]
        [DataMember(Name="orgName", EmitDefaultValue=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExperienceProposalRequest {\n");
            sb.Append("  OrgPhone: ").Append(OrgPhone).Append("\n");
            sb.Append("  OrgLong: ").Append(OrgLong).Append("\n");
            sb.Append("  ExperienceDescription: ").Append(ExperienceDescription).Append("\n");
            sb.Append("  OrgId: ").Append(OrgId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
            sb.Append("  OrgLat: ").Append(OrgLat).Append("\n");
            sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  ExperienceName: ").Append(ExperienceName).Append("\n");
            sb.Append("  OrgLocation: ").Append(OrgLocation).Append("\n");
            sb.Append("  ContactTitle: ").Append(ContactTitle).Append("\n");
            sb.Append("  ContactFormSubmissionId: ").Append(ContactFormSubmissionId).Append("\n");
            sb.Append("  OrgFormSubmissionId: ").Append(OrgFormSubmissionId).Append("\n");
            sb.Append("  ExperienceFormSubmissionId: ").Append(ExperienceFormSubmissionId).Append("\n");
            sb.Append("  OrgWebsite: ").Append(OrgWebsite).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateExperienceProposalRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateExperienceProposalRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateExperienceProposalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateExperienceProposalRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OrgPhone == other.OrgPhone ||
                    OrgPhone != null &&
                    OrgPhone.Equals(other.OrgPhone)
                ) && 
                (
                    OrgLong == other.OrgLong ||
                    OrgLong != null &&
                    OrgLong.Equals(other.OrgLong)
                ) && 
                (
                    ExperienceDescription == other.ExperienceDescription ||
                    ExperienceDescription != null &&
                    ExperienceDescription.Equals(other.ExperienceDescription)
                ) && 
                (
                    OrgId == other.OrgId ||
                    OrgId != null &&
                    OrgId.Equals(other.OrgId)
                ) && 
                (
                    ContactId == other.ContactId ||
                    ContactId != null &&
                    ContactId.Equals(other.ContactId)
                ) && 
                (
                    ContactPhone == other.ContactPhone ||
                    ContactPhone != null &&
                    ContactPhone.Equals(other.ContactPhone)
                ) && 
                (
                    ContactLastName == other.ContactLastName ||
                    ContactLastName != null &&
                    ContactLastName.Equals(other.ContactLastName)
                ) && 
                (
                    OrgLat == other.OrgLat ||
                    OrgLat != null &&
                    OrgLat.Equals(other.OrgLat)
                ) && 
                (
                    ContactFirstName == other.ContactFirstName ||
                    ContactFirstName != null &&
                    ContactFirstName.Equals(other.ContactFirstName)
                ) && 
                (
                    ContactEmail == other.ContactEmail ||
                    ContactEmail != null &&
                    ContactEmail.Equals(other.ContactEmail)
                ) && 
                (
                    ExperienceName == other.ExperienceName ||
                    ExperienceName != null &&
                    ExperienceName.Equals(other.ExperienceName)
                ) && 
                (
                    OrgLocation == other.OrgLocation ||
                    OrgLocation != null &&
                    OrgLocation.Equals(other.OrgLocation)
                ) && 
                (
                    ContactTitle == other.ContactTitle ||
                    ContactTitle != null &&
                    ContactTitle.Equals(other.ContactTitle)
                ) && 
                (
                    ContactFormSubmissionId == other.ContactFormSubmissionId ||
                    ContactFormSubmissionId != null &&
                    ContactFormSubmissionId.Equals(other.ContactFormSubmissionId)
                ) && 
                (
                    OrgFormSubmissionId == other.OrgFormSubmissionId ||
                    OrgFormSubmissionId != null &&
                    OrgFormSubmissionId.Equals(other.OrgFormSubmissionId)
                ) && 
                (
                    ExperienceFormSubmissionId == other.ExperienceFormSubmissionId ||
                    ExperienceFormSubmissionId != null &&
                    ExperienceFormSubmissionId.Equals(other.ExperienceFormSubmissionId)
                ) && 
                (
                    OrgWebsite == other.OrgWebsite ||
                    OrgWebsite != null &&
                    OrgWebsite.Equals(other.OrgWebsite)
                ) && 
                (
                    OrgName == other.OrgName ||
                    OrgName != null &&
                    OrgName.Equals(other.OrgName)
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
                    if (OrgPhone != null)
                    hashCode = hashCode * 59 + OrgPhone.GetHashCode();
                    if (OrgLong != null)
                    hashCode = hashCode * 59 + OrgLong.GetHashCode();
                    if (ExperienceDescription != null)
                    hashCode = hashCode * 59 + ExperienceDescription.GetHashCode();
                    if (OrgId != null)
                    hashCode = hashCode * 59 + OrgId.GetHashCode();
                    if (ContactId != null)
                    hashCode = hashCode * 59 + ContactId.GetHashCode();
                    if (ContactPhone != null)
                    hashCode = hashCode * 59 + ContactPhone.GetHashCode();
                    if (ContactLastName != null)
                    hashCode = hashCode * 59 + ContactLastName.GetHashCode();
                    if (OrgLat != null)
                    hashCode = hashCode * 59 + OrgLat.GetHashCode();
                    if (ContactFirstName != null)
                    hashCode = hashCode * 59 + ContactFirstName.GetHashCode();
                    if (ContactEmail != null)
                    hashCode = hashCode * 59 + ContactEmail.GetHashCode();
                    if (ExperienceName != null)
                    hashCode = hashCode * 59 + ExperienceName.GetHashCode();
                    if (OrgLocation != null)
                    hashCode = hashCode * 59 + OrgLocation.GetHashCode();
                    if (ContactTitle != null)
                    hashCode = hashCode * 59 + ContactTitle.GetHashCode();
                    if (ContactFormSubmissionId != null)
                    hashCode = hashCode * 59 + ContactFormSubmissionId.GetHashCode();
                    if (OrgFormSubmissionId != null)
                    hashCode = hashCode * 59 + OrgFormSubmissionId.GetHashCode();
                    if (ExperienceFormSubmissionId != null)
                    hashCode = hashCode * 59 + ExperienceFormSubmissionId.GetHashCode();
                    if (OrgWebsite != null)
                    hashCode = hashCode * 59 + OrgWebsite.GetHashCode();
                    if (OrgName != null)
                    hashCode = hashCode * 59 + OrgName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateExperienceProposalRequest left, CreateExperienceProposalRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateExperienceProposalRequest left, CreateExperienceProposalRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
