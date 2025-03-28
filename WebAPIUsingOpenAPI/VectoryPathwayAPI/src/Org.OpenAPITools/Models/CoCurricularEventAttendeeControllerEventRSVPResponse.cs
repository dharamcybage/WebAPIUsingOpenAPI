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
    public partial class CoCurricularEventAttendeeControllerEventRSVPResponse : IEquatable<CoCurricularEventAttendeeControllerEventRSVPResponse>
    {
        /// <summary>
        /// Gets or Sets ShiftStartTime
        /// </summary>
        [DataMember(Name="shiftStartTime", EmitDefaultValue=true)]
        public string ShiftStartTime { get; set; }

        /// <summary>
        /// Gets or Sets CoCurricularEventDateId
        /// </summary>
        [Required]
        [DataMember(Name="co_curricular_event_date_id", EmitDefaultValue=true)]
        public long CoCurricularEventDateId { get; set; }

        /// <summary>
        /// Gets or Sets EventEndDate
        /// </summary>
        [Required]
        [DataMember(Name="eventEndDate", EmitDefaultValue=false)]
        public DateTime EventEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public long? Role { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status", EmitDefaultValue=true)]
        public long Status { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or Sets ShiftEndTime
        /// </summary>
        [DataMember(Name="shiftEndTime", EmitDefaultValue=true)]
        public string ShiftEndTime { get; set; }

        /// <summary>
        /// Gets or Sets ShiftId
        /// </summary>
        [DataMember(Name="shift_id", EmitDefaultValue=true)]
        public long? ShiftId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets EventStartDate
        /// </summary>
        [Required]
        [DataMember(Name="eventStartDate", EmitDefaultValue=false)]
        public DateTime EventStartDate { get; set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=true)]
        public string District { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [Required]
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Grade
        /// </summary>
        [DataMember(Name="grade", EmitDefaultValue=true)]
        public long? Grade { get; set; }

        /// <summary>
        /// Gets or Sets ExternalAttendeeId
        /// </summary>
        [DataMember(Name="external_attendee_id", EmitDefaultValue=true)]
        public long? ExternalAttendeeId { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationFormSubmissionId
        /// </summary>
        [DataMember(Name="registration_form_submission_id", EmitDefaultValue=true)]
        public long? RegistrationFormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets School
        /// </summary>
        [DataMember(Name="school", EmitDefaultValue=true)]
        public string School { get; set; }

        /// <summary>
        /// Gets or Sets CoCurricularEventId
        /// </summary>
        [Required]
        [DataMember(Name="co_curricular_event_id", EmitDefaultValue=true)]
        public long CoCurricularEventId { get; set; }

        /// <summary>
        /// Gets or Sets CheckInMethod
        /// </summary>
        [DataMember(Name="checkInMethod", EmitDefaultValue=true)]
        public long? CheckInMethod { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoCurricularEventAttendeeControllerEventRSVPResponse {\n");
            sb.Append("  ShiftStartTime: ").Append(ShiftStartTime).Append("\n");
            sb.Append("  CoCurricularEventDateId: ").Append(CoCurricularEventDateId).Append("\n");
            sb.Append("  EventEndDate: ").Append(EventEndDate).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ShiftEndTime: ").Append(ShiftEndTime).Append("\n");
            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  EventStartDate: ").Append(EventStartDate).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Grade: ").Append(Grade).Append("\n");
            sb.Append("  ExternalAttendeeId: ").Append(ExternalAttendeeId).Append("\n");
            sb.Append("  RegistrationFormSubmissionId: ").Append(RegistrationFormSubmissionId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  School: ").Append(School).Append("\n");
            sb.Append("  CoCurricularEventId: ").Append(CoCurricularEventId).Append("\n");
            sb.Append("  CheckInMethod: ").Append(CheckInMethod).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CoCurricularEventAttendeeControllerEventRSVPResponse)obj);
        }

        /// <summary>
        /// Returns true if CoCurricularEventAttendeeControllerEventRSVPResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CoCurricularEventAttendeeControllerEventRSVPResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoCurricularEventAttendeeControllerEventRSVPResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ShiftStartTime == other.ShiftStartTime ||
                    ShiftStartTime != null &&
                    ShiftStartTime.Equals(other.ShiftStartTime)
                ) && 
                (
                    CoCurricularEventDateId == other.CoCurricularEventDateId ||
                    
                    CoCurricularEventDateId.Equals(other.CoCurricularEventDateId)
                ) && 
                (
                    EventEndDate == other.EventEndDate ||
                    EventEndDate != null &&
                    EventEndDate.Equals(other.EventEndDate)
                ) && 
                (
                    Role == other.Role ||
                    Role != null &&
                    Role.Equals(other.Role)
                ) && 
                (
                    Status == other.Status ||
                    
                    Status.Equals(other.Status)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    ShiftEndTime == other.ShiftEndTime ||
                    ShiftEndTime != null &&
                    ShiftEndTime.Equals(other.ShiftEndTime)
                ) && 
                (
                    ShiftId == other.ShiftId ||
                    ShiftId != null &&
                    ShiftId.Equals(other.ShiftId)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    EventStartDate == other.EventStartDate ||
                    EventStartDate != null &&
                    EventStartDate.Equals(other.EventStartDate)
                ) && 
                (
                    District == other.District ||
                    District != null &&
                    District.Equals(other.District)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Grade == other.Grade ||
                    Grade != null &&
                    Grade.Equals(other.Grade)
                ) && 
                (
                    ExternalAttendeeId == other.ExternalAttendeeId ||
                    ExternalAttendeeId != null &&
                    ExternalAttendeeId.Equals(other.ExternalAttendeeId)
                ) && 
                (
                    RegistrationFormSubmissionId == other.RegistrationFormSubmissionId ||
                    RegistrationFormSubmissionId != null &&
                    RegistrationFormSubmissionId.Equals(other.RegistrationFormSubmissionId)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    School == other.School ||
                    School != null &&
                    School.Equals(other.School)
                ) && 
                (
                    CoCurricularEventId == other.CoCurricularEventId ||
                    
                    CoCurricularEventId.Equals(other.CoCurricularEventId)
                ) && 
                (
                    CheckInMethod == other.CheckInMethod ||
                    CheckInMethod != null &&
                    CheckInMethod.Equals(other.CheckInMethod)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
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
                    if (ShiftStartTime != null)
                    hashCode = hashCode * 59 + ShiftStartTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + CoCurricularEventDateId.GetHashCode();
                    if (EventEndDate != null)
                    hashCode = hashCode * 59 + EventEndDate.GetHashCode();
                    if (Role != null)
                    hashCode = hashCode * 59 + Role.GetHashCode();
                    
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (ShiftEndTime != null)
                    hashCode = hashCode * 59 + ShiftEndTime.GetHashCode();
                    if (ShiftId != null)
                    hashCode = hashCode * 59 + ShiftId.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (EventStartDate != null)
                    hashCode = hashCode * 59 + EventStartDate.GetHashCode();
                    if (District != null)
                    hashCode = hashCode * 59 + District.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Grade != null)
                    hashCode = hashCode * 59 + Grade.GetHashCode();
                    if (ExternalAttendeeId != null)
                    hashCode = hashCode * 59 + ExternalAttendeeId.GetHashCode();
                    if (RegistrationFormSubmissionId != null)
                    hashCode = hashCode * 59 + RegistrationFormSubmissionId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (School != null)
                    hashCode = hashCode * 59 + School.GetHashCode();
                    
                    hashCode = hashCode * 59 + CoCurricularEventId.GetHashCode();
                    if (CheckInMethod != null)
                    hashCode = hashCode * 59 + CheckInMethod.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CoCurricularEventAttendeeControllerEventRSVPResponse left, CoCurricularEventAttendeeControllerEventRSVPResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CoCurricularEventAttendeeControllerEventRSVPResponse left, CoCurricularEventAttendeeControllerEventRSVPResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
