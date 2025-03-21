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
    public partial class CreateCoCurricularEventRequest : IEquatable<CreateCoCurricularEventRequest>
    {
        /// <summary>
        /// Gets or Sets OwnerIds
        /// </summary>
        [Required]
        [DataMember(Name="ownerIds", EmitDefaultValue=false)]
        public List<long> OwnerIds { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [Required]
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="group_id", EmitDefaultValue=true)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets ExternalSubmissionId
        /// </summary>
        [DataMember(Name="externalSubmissionId", EmitDefaultValue=true)]
        public long? ExternalSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets EventTypeId
        /// </summary>
        [DataMember(Name="event_type_id", EmitDefaultValue=true)]
        public long? EventTypeId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [Required]
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets FirstReminderDate
        /// </summary>
        [DataMember(Name="firstReminderDate", EmitDefaultValue=true)]
        public DateTime? FirstReminderDate { get; set; }

        /// <summary>
        /// Gets or Sets SchoolIds
        /// </summary>
        [Required]
        [DataMember(Name="schoolIds", EmitDefaultValue=false)]
        public List<long> SchoolIds { get; set; }

        /// <summary>
        /// Gets or Sets Shifts
        /// </summary>
        [Required]
        [DataMember(Name="shifts", EmitDefaultValue=false)]
        public List<CreateCoCurricularEventRequestShift> Shifts { get; set; }

        /// <summary>
        /// Gets or Sets FinalRegistrationDate
        /// </summary>
        [DataMember(Name="finalRegistrationDate", EmitDefaultValue=true)]
        public DateTime? FinalRegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=true)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets SecondReminderDate
        /// </summary>
        [DataMember(Name="secondReminderDate", EmitDefaultValue=true)]
        public DateTime? SecondReminderDate { get; set; }

        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="form_id", EmitDefaultValue=true)]
        public long? FormId { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [Required]
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumberOfStudents
        /// </summary>
        [DataMember(Name="maxNumberOfStudents", EmitDefaultValue=true)]
        public long? MaxNumberOfStudents { get; set; }

        /// <summary>
        /// Gets or Sets RepetitionType
        /// </summary>
        [Required]
        [DataMember(Name="repetitionType", EmitDefaultValue=true)]
        public long RepetitionType { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public CreateCoCurricularEventRequestFile File { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FileUrl
        /// </summary>
        [DataMember(Name="fileUrl", EmitDefaultValue=true)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationCodeRequired
        /// </summary>
        [Required]
        [DataMember(Name="registrationCodeRequired", EmitDefaultValue=true)]
        public bool RegistrationCodeRequired { get; set; }

        /// <summary>
        /// Gets or Sets RepetitionIteration
        /// </summary>
        [DataMember(Name="repetitionIteration", EmitDefaultValue=true)]
        public long? RepetitionIteration { get; set; }

        /// <summary>
        /// Gets or Sets AddedToPublicCalendar
        /// </summary>
        [Required]
        [DataMember(Name="addedToPublicCalendar", EmitDefaultValue=true)]
        public bool AddedToPublicCalendar { get; set; }

        /// <summary>
        /// Gets or Sets IsAllDay
        /// </summary>
        [Required]
        [DataMember(Name="isAllDay", EmitDefaultValue=true)]
        public bool IsAllDay { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationType
        /// </summary>
        [Required]
        [DataMember(Name="registrationType", EmitDefaultValue=true)]
        public long RegistrationType { get; set; }

        /// <summary>
        /// Gets or Sets PostOnSchoolCalendar
        /// </summary>
        [Required]
        [DataMember(Name="postOnSchoolCalendar", EmitDefaultValue=true)]
        public bool PostOnSchoolCalendar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoCurricularEventRequest {\n");
            sb.Append("  OwnerIds: ").Append(OwnerIds).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  ExternalSubmissionId: ").Append(ExternalSubmissionId).Append("\n");
            sb.Append("  EventTypeId: ").Append(EventTypeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FirstReminderDate: ").Append(FirstReminderDate).Append("\n");
            sb.Append("  SchoolIds: ").Append(SchoolIds).Append("\n");
            sb.Append("  Shifts: ").Append(Shifts).Append("\n");
            sb.Append("  FinalRegistrationDate: ").Append(FinalRegistrationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SecondReminderDate: ").Append(SecondReminderDate).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MaxNumberOfStudents: ").Append(MaxNumberOfStudents).Append("\n");
            sb.Append("  RepetitionType: ").Append(RepetitionType).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  RegistrationCodeRequired: ").Append(RegistrationCodeRequired).Append("\n");
            sb.Append("  RepetitionIteration: ").Append(RepetitionIteration).Append("\n");
            sb.Append("  AddedToPublicCalendar: ").Append(AddedToPublicCalendar).Append("\n");
            sb.Append("  IsAllDay: ").Append(IsAllDay).Append("\n");
            sb.Append("  RegistrationType: ").Append(RegistrationType).Append("\n");
            sb.Append("  PostOnSchoolCalendar: ").Append(PostOnSchoolCalendar).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateCoCurricularEventRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateCoCurricularEventRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCoCurricularEventRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoCurricularEventRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OwnerIds == other.OwnerIds ||
                    OwnerIds != null &&
                    other.OwnerIds != null &&
                    OwnerIds.SequenceEqual(other.OwnerIds)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    GroupId == other.GroupId ||
                    GroupId != null &&
                    GroupId.Equals(other.GroupId)
                ) && 
                (
                    ExternalSubmissionId == other.ExternalSubmissionId ||
                    ExternalSubmissionId != null &&
                    ExternalSubmissionId.Equals(other.ExternalSubmissionId)
                ) && 
                (
                    EventTypeId == other.EventTypeId ||
                    EventTypeId != null &&
                    EventTypeId.Equals(other.EventTypeId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    FirstReminderDate == other.FirstReminderDate ||
                    FirstReminderDate != null &&
                    FirstReminderDate.Equals(other.FirstReminderDate)
                ) && 
                (
                    SchoolIds == other.SchoolIds ||
                    SchoolIds != null &&
                    other.SchoolIds != null &&
                    SchoolIds.SequenceEqual(other.SchoolIds)
                ) && 
                (
                    Shifts == other.Shifts ||
                    Shifts != null &&
                    other.Shifts != null &&
                    Shifts.SequenceEqual(other.Shifts)
                ) && 
                (
                    FinalRegistrationDate == other.FinalRegistrationDate ||
                    FinalRegistrationDate != null &&
                    FinalRegistrationDate.Equals(other.FinalRegistrationDate)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    OrganizationId == other.OrganizationId ||
                    OrganizationId != null &&
                    OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    SecondReminderDate == other.SecondReminderDate ||
                    SecondReminderDate != null &&
                    SecondReminderDate.Equals(other.SecondReminderDate)
                ) && 
                (
                    FormId == other.FormId ||
                    FormId != null &&
                    FormId.Equals(other.FormId)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    MaxNumberOfStudents == other.MaxNumberOfStudents ||
                    MaxNumberOfStudents != null &&
                    MaxNumberOfStudents.Equals(other.MaxNumberOfStudents)
                ) && 
                (
                    RepetitionType == other.RepetitionType ||
                    
                    RepetitionType.Equals(other.RepetitionType)
                ) && 
                (
                    File == other.File ||
                    File != null &&
                    File.Equals(other.File)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    FileUrl == other.FileUrl ||
                    FileUrl != null &&
                    FileUrl.Equals(other.FileUrl)
                ) && 
                (
                    RegistrationCodeRequired == other.RegistrationCodeRequired ||
                    
                    RegistrationCodeRequired.Equals(other.RegistrationCodeRequired)
                ) && 
                (
                    RepetitionIteration == other.RepetitionIteration ||
                    RepetitionIteration != null &&
                    RepetitionIteration.Equals(other.RepetitionIteration)
                ) && 
                (
                    AddedToPublicCalendar == other.AddedToPublicCalendar ||
                    
                    AddedToPublicCalendar.Equals(other.AddedToPublicCalendar)
                ) && 
                (
                    IsAllDay == other.IsAllDay ||
                    
                    IsAllDay.Equals(other.IsAllDay)
                ) && 
                (
                    RegistrationType == other.RegistrationType ||
                    
                    RegistrationType.Equals(other.RegistrationType)
                ) && 
                (
                    PostOnSchoolCalendar == other.PostOnSchoolCalendar ||
                    
                    PostOnSchoolCalendar.Equals(other.PostOnSchoolCalendar)
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
                    if (OwnerIds != null)
                    hashCode = hashCode * 59 + OwnerIds.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (GroupId != null)
                    hashCode = hashCode * 59 + GroupId.GetHashCode();
                    if (ExternalSubmissionId != null)
                    hashCode = hashCode * 59 + ExternalSubmissionId.GetHashCode();
                    if (EventTypeId != null)
                    hashCode = hashCode * 59 + EventTypeId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (FirstReminderDate != null)
                    hashCode = hashCode * 59 + FirstReminderDate.GetHashCode();
                    if (SchoolIds != null)
                    hashCode = hashCode * 59 + SchoolIds.GetHashCode();
                    if (Shifts != null)
                    hashCode = hashCode * 59 + Shifts.GetHashCode();
                    if (FinalRegistrationDate != null)
                    hashCode = hashCode * 59 + FinalRegistrationDate.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (OrganizationId != null)
                    hashCode = hashCode * 59 + OrganizationId.GetHashCode();
                    if (SecondReminderDate != null)
                    hashCode = hashCode * 59 + SecondReminderDate.GetHashCode();
                    if (FormId != null)
                    hashCode = hashCode * 59 + FormId.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (MaxNumberOfStudents != null)
                    hashCode = hashCode * 59 + MaxNumberOfStudents.GetHashCode();
                    
                    hashCode = hashCode * 59 + RepetitionType.GetHashCode();
                    if (File != null)
                    hashCode = hashCode * 59 + File.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (FileUrl != null)
                    hashCode = hashCode * 59 + FileUrl.GetHashCode();
                    
                    hashCode = hashCode * 59 + RegistrationCodeRequired.GetHashCode();
                    if (RepetitionIteration != null)
                    hashCode = hashCode * 59 + RepetitionIteration.GetHashCode();
                    
                    hashCode = hashCode * 59 + AddedToPublicCalendar.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsAllDay.GetHashCode();
                    
                    hashCode = hashCode * 59 + RegistrationType.GetHashCode();
                    
                    hashCode = hashCode * 59 + PostOnSchoolCalendar.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateCoCurricularEventRequest left, CreateCoCurricularEventRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateCoCurricularEventRequest left, CreateCoCurricularEventRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
