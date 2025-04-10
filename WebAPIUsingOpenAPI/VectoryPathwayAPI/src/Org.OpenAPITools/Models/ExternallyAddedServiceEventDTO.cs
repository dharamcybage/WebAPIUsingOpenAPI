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
    public partial class ExternallyAddedServiceEventDTO : IEquatable<ExternallyAddedServiceEventDTO>
    {
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="contactPhone", EmitDefaultValue=true)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [Required]
        [DataMember(Name="time", EmitDefaultValue=false)]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [Required]
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [Required]
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [Required]
        [DataMember(Name="contactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [Required]
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=true)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [Required]
        [DataMember(Name="group_id", EmitDefaultValue=true)]
        public long GroupId { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumberOfStudents
        /// </summary>
        [DataMember(Name="maxNumberOfStudents", EmitDefaultValue=true)]
        public long? MaxNumberOfStudents { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternallyAddedServiceEventDTO {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  MaxNumberOfStudents: ").Append(MaxNumberOfStudents).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExternallyAddedServiceEventDTO)obj);
        }

        /// <summary>
        /// Returns true if ExternallyAddedServiceEventDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternallyAddedServiceEventDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternallyAddedServiceEventDTO other)
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
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    ContactPhone == other.ContactPhone ||
                    ContactPhone != null &&
                    ContactPhone.Equals(other.ContactPhone)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DeletedAt == other.DeletedAt ||
                    DeletedAt != null &&
                    DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    ContactName == other.ContactName ||
                    ContactName != null &&
                    ContactName.Equals(other.ContactName)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    ContactEmail == other.ContactEmail ||
                    ContactEmail != null &&
                    ContactEmail.Equals(other.ContactEmail)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    OrganizationId == other.OrganizationId ||
                    OrganizationId != null &&
                    OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    GroupId == other.GroupId ||
                    
                    GroupId.Equals(other.GroupId)
                ) && 
                (
                    MaxNumberOfStudents == other.MaxNumberOfStudents ||
                    MaxNumberOfStudents != null &&
                    MaxNumberOfStudents.Equals(other.MaxNumberOfStudents)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ContactPhone != null)
                    hashCode = hashCode * 59 + ContactPhone.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (ContactName != null)
                    hashCode = hashCode * 59 + ContactName.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (ContactEmail != null)
                    hashCode = hashCode * 59 + ContactEmail.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (OrganizationId != null)
                    hashCode = hashCode * 59 + OrganizationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + GroupId.GetHashCode();
                    if (MaxNumberOfStudents != null)
                    hashCode = hashCode * 59 + MaxNumberOfStudents.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExternallyAddedServiceEventDTO left, ExternallyAddedServiceEventDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExternallyAddedServiceEventDTO left, ExternallyAddedServiceEventDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
