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
    public partial class CourseDTO : IEquatable<CourseDTO>
    {
        /// <summary>
        /// Gets or Sets CareerClusterId
        /// </summary>
        [Required]
        [DataMember(Name="career_cluster_id", EmitDefaultValue=true)]
        public long CareerClusterId { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [Required]
        [DataMember(Name="level", EmitDefaultValue=true)]
        public long Level { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Ncaa
        /// </summary>
        [Required]
        [DataMember(Name="ncaa", EmitDefaultValue=true)]
        public bool Ncaa { get; set; }

        /// <summary>
        /// Gets or Sets Prerequisites
        /// </summary>
        [DataMember(Name="prerequisites", EmitDefaultValue=false)]
        public CoursePrerequisites Prerequisites { get; set; }

        /// <summary>
        /// Gets or Sets ShowsOnGradPlan
        /// </summary>
        [Required]
        [DataMember(Name="showsOnGradPlan", EmitDefaultValue=true)]
        public bool ShowsOnGradPlan { get; set; }

        /// <summary>
        /// Gets or Sets ExplicitSchoolIds
        /// </summary>
        [Required]
        [DataMember(Name="explicitSchoolIds", EmitDefaultValue=false)]
        public List<long> ExplicitSchoolIds { get; set; }

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
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalBadgeGroupId
        /// </summary>
        [DataMember(Name="conditional_badge_group_id", EmitDefaultValue=true)]
        public long? ConditionalBadgeGroupId { get; set; }

        /// <summary>
        /// Gets or Sets CourseLength
        /// </summary>
        [Required]
        [DataMember(Name="courseLength", EmitDefaultValue=true)]
        public long CourseLength { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets TermId
        /// </summary>
        [DataMember(Name="term_id", EmitDefaultValue=true)]
        public long? TermId { get; set; }

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
        /// Gets or Sets SourcedId
        /// </summary>
        [DataMember(Name="sourcedId", EmitDefaultValue=true)]
        public string SourcedId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CourseId
        /// </summary>
        [DataMember(Name="courseId", EmitDefaultValue=true)]
        public string CourseId { get; set; }

        /// <summary>
        /// Gets or Sets CompletionIndicatorBy
        /// </summary>
        [DataMember(Name="completionIndicatorBy", EmitDefaultValue=true)]
        public DateTime? CompletionIndicatorBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CourseDTO {\n");
            sb.Append("  CareerClusterId: ").Append(CareerClusterId).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ncaa: ").Append(Ncaa).Append("\n");
            sb.Append("  Prerequisites: ").Append(Prerequisites).Append("\n");
            sb.Append("  ShowsOnGradPlan: ").Append(ShowsOnGradPlan).Append("\n");
            sb.Append("  ExplicitSchoolIds: ").Append(ExplicitSchoolIds).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConditionalBadgeGroupId: ").Append(ConditionalBadgeGroupId).Append("\n");
            sb.Append("  CourseLength: ").Append(CourseLength).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  TermId: ").Append(TermId).Append("\n");
            sb.Append("  GraduationStatus: ").Append(GraduationStatus).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SourcedId: ").Append(SourcedId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CourseId: ").Append(CourseId).Append("\n");
            sb.Append("  CompletionIndicatorBy: ").Append(CompletionIndicatorBy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CourseDTO)obj);
        }

        /// <summary>
        /// Returns true if CourseDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of CourseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CourseDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CareerClusterId == other.CareerClusterId ||
                    
                    CareerClusterId.Equals(other.CareerClusterId)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    Level == other.Level ||
                    
                    Level.Equals(other.Level)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Ncaa == other.Ncaa ||
                    
                    Ncaa.Equals(other.Ncaa)
                ) && 
                (
                    Prerequisites == other.Prerequisites ||
                    Prerequisites != null &&
                    Prerequisites.Equals(other.Prerequisites)
                ) && 
                (
                    ShowsOnGradPlan == other.ShowsOnGradPlan ||
                    
                    ShowsOnGradPlan.Equals(other.ShowsOnGradPlan)
                ) && 
                (
                    ExplicitSchoolIds == other.ExplicitSchoolIds ||
                    ExplicitSchoolIds != null &&
                    other.ExplicitSchoolIds != null &&
                    ExplicitSchoolIds.SequenceEqual(other.ExplicitSchoolIds)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ConditionalBadgeGroupId == other.ConditionalBadgeGroupId ||
                    ConditionalBadgeGroupId != null &&
                    ConditionalBadgeGroupId.Equals(other.ConditionalBadgeGroupId)
                ) && 
                (
                    CourseLength == other.CourseLength ||
                    
                    CourseLength.Equals(other.CourseLength)
                ) && 
                (
                    DeletedAt == other.DeletedAt ||
                    DeletedAt != null &&
                    DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    TermId == other.TermId ||
                    TermId != null &&
                    TermId.Equals(other.TermId)
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
                    SourcedId == other.SourcedId ||
                    SourcedId != null &&
                    SourcedId.Equals(other.SourcedId)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    CourseId == other.CourseId ||
                    CourseId != null &&
                    CourseId.Equals(other.CourseId)
                ) && 
                (
                    CompletionIndicatorBy == other.CompletionIndicatorBy ||
                    CompletionIndicatorBy != null &&
                    CompletionIndicatorBy.Equals(other.CompletionIndicatorBy)
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
                    
                    hashCode = hashCode * 59 + CareerClusterId.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Level.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + Ncaa.GetHashCode();
                    if (Prerequisites != null)
                    hashCode = hashCode * 59 + Prerequisites.GetHashCode();
                    
                    hashCode = hashCode * 59 + ShowsOnGradPlan.GetHashCode();
                    if (ExplicitSchoolIds != null)
                    hashCode = hashCode * 59 + ExplicitSchoolIds.GetHashCode();
                    
                    hashCode = hashCode * 59 + Credits.GetHashCode();
                    if (Grades != null)
                    hashCode = hashCode * 59 + Grades.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ConditionalBadgeGroupId != null)
                    hashCode = hashCode * 59 + ConditionalBadgeGroupId.GetHashCode();
                    
                    hashCode = hashCode * 59 + CourseLength.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (TermId != null)
                    hashCode = hashCode * 59 + TermId.GetHashCode();
                    
                    hashCode = hashCode * 59 + GraduationStatus.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (SourcedId != null)
                    hashCode = hashCode * 59 + SourcedId.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (CourseId != null)
                    hashCode = hashCode * 59 + CourseId.GetHashCode();
                    if (CompletionIndicatorBy != null)
                    hashCode = hashCode * 59 + CompletionIndicatorBy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CourseDTO left, CourseDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CourseDTO left, CourseDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
