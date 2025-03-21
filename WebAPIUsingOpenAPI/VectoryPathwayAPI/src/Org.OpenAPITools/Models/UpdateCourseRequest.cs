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
    public partial class UpdateCourseRequest : IEquatable<UpdateCourseRequest>
    {
        /// <summary>
        /// Gets or Sets Ncaa
        /// </summary>
        [Required]
        [DataMember(Name="ncaa", EmitDefaultValue=true)]
        public bool Ncaa { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GraduationStatus
        /// </summary>
        [Required]
        [DataMember(Name="graduationStatus", EmitDefaultValue=true)]
        public long GraduationStatus { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets Subjects
        /// </summary>
        [Required]
        [DataMember(Name="subjects", EmitDefaultValue=false)]
        public List<UpdateCourseRequestSubject> Subjects { get; set; }

        /// <summary>
        /// Gets or Sets ShowsOnGradPlan
        /// </summary>
        [Required]
        [DataMember(Name="showsOnGradPlan", EmitDefaultValue=true)]
        public bool ShowsOnGradPlan { get; set; }

        /// <summary>
        /// Gets or Sets Credits
        /// </summary>
        [Required]
        [DataMember(Name="credits", EmitDefaultValue=true)]
        public double Credits { get; set; }

        /// <summary>
        /// Gets or Sets Grades
        /// </summary>
        [Required]
        [DataMember(Name="grades", EmitDefaultValue=false)]
        public List<long> Grades { get; set; }

        /// <summary>
        /// Gets or Sets CourseLength
        /// </summary>
        [Required]
        [DataMember(Name="courseLength", EmitDefaultValue=true)]
        public long CourseLength { get; set; }

        /// <summary>
        /// Gets or Sets CareerClusterId
        /// </summary>
        [Required]
        [DataMember(Name="career_cluster_id", EmitDefaultValue=true)]
        public long CareerClusterId { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [Required]
        [DataMember(Name="level", EmitDefaultValue=true)]
        public long Level { get; set; }

        /// <summary>
        /// Gets or Sets CourseId
        /// </summary>
        [DataMember(Name="courseId", EmitDefaultValue=true)]
        public string CourseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCourseRequest {\n");
            sb.Append("  Ncaa: ").Append(Ncaa).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GraduationStatus: ").Append(GraduationStatus).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  Subjects: ").Append(Subjects).Append("\n");
            sb.Append("  ShowsOnGradPlan: ").Append(ShowsOnGradPlan).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
            sb.Append("  CourseLength: ").Append(CourseLength).Append("\n");
            sb.Append("  CareerClusterId: ").Append(CareerClusterId).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  CourseId: ").Append(CourseId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateCourseRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateCourseRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateCourseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCourseRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Ncaa == other.Ncaa ||
                    
                    Ncaa.Equals(other.Ncaa)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    GraduationStatus == other.GraduationStatus ||
                    
                    GraduationStatus.Equals(other.GraduationStatus)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    Subjects == other.Subjects ||
                    Subjects != null &&
                    other.Subjects != null &&
                    Subjects.SequenceEqual(other.Subjects)
                ) && 
                (
                    ShowsOnGradPlan == other.ShowsOnGradPlan ||
                    
                    ShowsOnGradPlan.Equals(other.ShowsOnGradPlan)
                ) && 
                (
                    Credits == other.Credits ||
                    
                    Credits.Equals(other.Credits)
                ) && 
                (
                    Grades == other.Grades ||
                    Grades != null &&
                    other.Grades != null &&
                    Grades.SequenceEqual(other.Grades)
                ) && 
                (
                    CourseLength == other.CourseLength ||
                    
                    CourseLength.Equals(other.CourseLength)
                ) && 
                (
                    CareerClusterId == other.CareerClusterId ||
                    
                    CareerClusterId.Equals(other.CareerClusterId)
                ) && 
                (
                    Level == other.Level ||
                    
                    Level.Equals(other.Level)
                ) && 
                (
                    CourseId == other.CourseId ||
                    CourseId != null &&
                    CourseId.Equals(other.CourseId)
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
                    
                    hashCode = hashCode * 59 + Ncaa.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + GraduationStatus.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (Subjects != null)
                    hashCode = hashCode * 59 + Subjects.GetHashCode();
                    
                    hashCode = hashCode * 59 + ShowsOnGradPlan.GetHashCode();
                    
                    hashCode = hashCode * 59 + Credits.GetHashCode();
                    if (Grades != null)
                    hashCode = hashCode * 59 + Grades.GetHashCode();
                    
                    hashCode = hashCode * 59 + CourseLength.GetHashCode();
                    
                    hashCode = hashCode * 59 + CareerClusterId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Level.GetHashCode();
                    if (CourseId != null)
                    hashCode = hashCode * 59 + CourseId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UpdateCourseRequest left, UpdateCourseRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateCourseRequest left, UpdateCourseRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
