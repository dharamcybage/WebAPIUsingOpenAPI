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
    public partial class CoCurricularEventsControllerCoCurricularEventTableResponse : IEquatable<CoCurricularEventsControllerCoCurricularEventTableResponse>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [Required]
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [Required]
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [Required]
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactEmail
        /// </summary>
        [Required]
        [DataMember(Name="contactEmail", EmitDefaultValue=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumberOfStudents
        /// </summary>
        [DataMember(Name="maxNumberOfStudents", EmitDefaultValue=true)]
        public long? MaxNumberOfStudents { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantsCount
        /// </summary>
        [DataMember(Name="participantsCount", EmitDefaultValue=true)]
        public long? ParticipantsCount { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=true)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets ContactLastName
        /// </summary>
        [Required]
        [DataMember(Name="contactLastName", EmitDefaultValue=false)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AttendedCount
        /// </summary>
        [DataMember(Name="attendedCount", EmitDefaultValue=true)]
        public long? AttendedCount { get; set; }

        /// <summary>
        /// Gets or Sets IsAllDay
        /// </summary>
        [Required]
        [DataMember(Name="isAllDay", EmitDefaultValue=true)]
        public bool IsAllDay { get; set; }

        /// <summary>
        /// Gets or Sets ContactFirstName
        /// </summary>
        [Required]
        [DataMember(Name="contactFirstName", EmitDefaultValue=false)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredCount
        /// </summary>
        [DataMember(Name="registeredCount", EmitDefaultValue=true)]
        public long? RegisteredCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoCurricularEventsControllerCoCurricularEventTableResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ContactEmail: ").Append(ContactEmail).Append("\n");
            sb.Append("  MaxNumberOfStudents: ").Append(MaxNumberOfStudents).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParticipantsCount: ").Append(ParticipantsCount).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AttendedCount: ").Append(AttendedCount).Append("\n");
            sb.Append("  IsAllDay: ").Append(IsAllDay).Append("\n");
            sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
            sb.Append("  RegisteredCount: ").Append(RegisteredCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CoCurricularEventsControllerCoCurricularEventTableResponse)obj);
        }

        /// <summary>
        /// Returns true if CoCurricularEventsControllerCoCurricularEventTableResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CoCurricularEventsControllerCoCurricularEventTableResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoCurricularEventsControllerCoCurricularEventTableResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    ContactEmail == other.ContactEmail ||
                    ContactEmail != null &&
                    ContactEmail.Equals(other.ContactEmail)
                ) && 
                (
                    MaxNumberOfStudents == other.MaxNumberOfStudents ||
                    MaxNumberOfStudents != null &&
                    MaxNumberOfStudents.Equals(other.MaxNumberOfStudents)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ParticipantsCount == other.ParticipantsCount ||
                    ParticipantsCount != null &&
                    ParticipantsCount.Equals(other.ParticipantsCount)
                ) && 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.Equals(other.Organization)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    ContactLastName == other.ContactLastName ||
                    ContactLastName != null &&
                    ContactLastName.Equals(other.ContactLastName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    AttendedCount == other.AttendedCount ||
                    AttendedCount != null &&
                    AttendedCount.Equals(other.AttendedCount)
                ) && 
                (
                    IsAllDay == other.IsAllDay ||
                    
                    IsAllDay.Equals(other.IsAllDay)
                ) && 
                (
                    ContactFirstName == other.ContactFirstName ||
                    ContactFirstName != null &&
                    ContactFirstName.Equals(other.ContactFirstName)
                ) && 
                (
                    RegisteredCount == other.RegisteredCount ||
                    RegisteredCount != null &&
                    RegisteredCount.Equals(other.RegisteredCount)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (ContactEmail != null)
                    hashCode = hashCode * 59 + ContactEmail.GetHashCode();
                    if (MaxNumberOfStudents != null)
                    hashCode = hashCode * 59 + MaxNumberOfStudents.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ParticipantsCount != null)
                    hashCode = hashCode * 59 + ParticipantsCount.GetHashCode();
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ContactLastName != null)
                    hashCode = hashCode * 59 + ContactLastName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (AttendedCount != null)
                    hashCode = hashCode * 59 + AttendedCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsAllDay.GetHashCode();
                    if (ContactFirstName != null)
                    hashCode = hashCode * 59 + ContactFirstName.GetHashCode();
                    if (RegisteredCount != null)
                    hashCode = hashCode * 59 + RegisteredCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CoCurricularEventsControllerCoCurricularEventTableResponse left, CoCurricularEventsControllerCoCurricularEventTableResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CoCurricularEventsControllerCoCurricularEventTableResponse left, CoCurricularEventsControllerCoCurricularEventTableResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
