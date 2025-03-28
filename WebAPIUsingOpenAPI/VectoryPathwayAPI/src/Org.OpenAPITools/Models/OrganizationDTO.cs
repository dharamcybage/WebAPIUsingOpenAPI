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
    public partial class OrganizationDTO : IEquatable<OrganizationDTO>
    {
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=true)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets MainNotes
        /// </summary>
        [Required]
        [DataMember(Name="mainNotes", EmitDefaultValue=false)]
        public string MainNotes { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets LocationDescription
        /// </summary>
        [Required]
        [DataMember(Name="locationDescription", EmitDefaultValue=false)]
        public string LocationDescription { get; set; }

        /// <summary>
        /// Gets or Sets ProfileImageUrl
        /// </summary>
        [DataMember(Name="profileImageUrl", EmitDefaultValue=true)]
        public string ProfileImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationDTO {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MainNotes: ").Append(MainNotes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocationDescription: ").Append(LocationDescription).Append("\n");
            sb.Append("  ProfileImageUrl: ").Append(ProfileImageUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrganizationDTO)obj);
        }

        /// <summary>
        /// Returns true if OrganizationDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    DeletedAt == other.DeletedAt ||
                    DeletedAt != null &&
                    DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Website == other.Website ||
                    Website != null &&
                    Website.Equals(other.Website)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    MainNotes == other.MainNotes ||
                    MainNotes != null &&
                    MainNotes.Equals(other.MainNotes)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    LocationDescription == other.LocationDescription ||
                    LocationDescription != null &&
                    LocationDescription.Equals(other.LocationDescription)
                ) && 
                (
                    ProfileImageUrl == other.ProfileImageUrl ||
                    ProfileImageUrl != null &&
                    ProfileImageUrl.Equals(other.ProfileImageUrl)
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
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (MainNotes != null)
                    hashCode = hashCode * 59 + MainNotes.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (LocationDescription != null)
                    hashCode = hashCode * 59 + LocationDescription.GetHashCode();
                    if (ProfileImageUrl != null)
                    hashCode = hashCode * 59 + ProfileImageUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OrganizationDTO left, OrganizationDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OrganizationDTO left, OrganizationDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
