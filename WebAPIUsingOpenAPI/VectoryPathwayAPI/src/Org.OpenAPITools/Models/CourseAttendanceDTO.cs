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
    public partial class CourseAttendanceDTO : IEquatable<CourseAttendanceDTO>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status", EmitDefaultValue=true)]
        public long Status { get; set; }

        /// <summary>
        /// Gets or Sets CourseSectionId
        /// </summary>
        [Required]
        [DataMember(Name="course_section_id", EmitDefaultValue=true)]
        public long CourseSectionId { get; set; }

        /// <summary>
        /// Gets or Sets StudentId
        /// </summary>
        [Required]
        [DataMember(Name="student_id", EmitDefaultValue=true)]
        public long StudentId { get; set; }

        /// <summary>
        /// Gets or Sets TeacherId
        /// </summary>
        [Required]
        [DataMember(Name="teacher_id", EmitDefaultValue=true)]
        public long TeacherId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [Required]
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CourseAttendanceDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CourseSectionId: ").Append(CourseSectionId).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  TeacherId: ").Append(TeacherId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CourseAttendanceDTO)obj);
        }

        /// <summary>
        /// Returns true if CourseAttendanceDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of CourseAttendanceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CourseAttendanceDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    Status == other.Status ||
                    
                    Status.Equals(other.Status)
                ) && 
                (
                    CourseSectionId == other.CourseSectionId ||
                    
                    CourseSectionId.Equals(other.CourseSectionId)
                ) && 
                (
                    StudentId == other.StudentId ||
                    
                    StudentId.Equals(other.StudentId)
                ) && 
                (
                    TeacherId == other.TeacherId ||
                    
                    TeacherId.Equals(other.TeacherId)
                ) && 
                (
                    Reason == other.Reason ||
                    Reason != null &&
                    Reason.Equals(other.Reason)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    
                    hashCode = hashCode * 59 + CourseSectionId.GetHashCode();
                    
                    hashCode = hashCode * 59 + StudentId.GetHashCode();
                    
                    hashCode = hashCode * 59 + TeacherId.GetHashCode();
                    if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CourseAttendanceDTO left, CourseAttendanceDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CourseAttendanceDTO left, CourseAttendanceDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
