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
    public partial class WorkflowExperience : IEquatable<WorkflowExperience>
    {
        /// <summary>
        /// Gets or Sets ReflectionFormId
        /// </summary>
        [DataMember(Name="reflection_form_id", EmitDefaultValue=true)]
        public long? ReflectionFormId { get; set; }

        /// <summary>
        /// Gets or Sets HideFromSearch
        /// </summary>
        [Required]
        [DataMember(Name="hideFromSearch", EmitDefaultValue=true)]
        public bool HideFromSearch { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [Required]
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public OrganizationDTO Organization { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfSpots
        /// </summary>
        [DataMember(Name="numberOfSpots", EmitDefaultValue=true)]
        public long? NumberOfSpots { get; set; }

        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="form_id", EmitDefaultValue=true)]
        public long? FormId { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

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
        /// Gets or Sets ReflectionFormApproval
        /// </summary>
        [DataMember(Name="reflection_form_approval", EmitDefaultValue=true)]
        public long? ReflectionFormApproval { get; set; }

        /// <summary>
        /// Gets or Sets AllowsTotalTimelogHoursSubmission
        /// </summary>
        [Required]
        [DataMember(Name="allowsTotalTimelogHoursSubmission", EmitDefaultValue=true)]
        public bool AllowsTotalTimelogHoursSubmission { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [Required]
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public BasicContact Contact { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalBadgeGroupId
        /// </summary>
        [DataMember(Name="conditional_badge_group_id", EmitDefaultValue=true)]
        public long? ConditionalBadgeGroupId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="location_id", EmitDefaultValue=true)]
        public long? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [Required]
        [DataMember(Name="created_by", EmitDefaultValue=true)]
        public long CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowExperience {\n");
            sb.Append("  ReflectionFormId: ").Append(ReflectionFormId).Append("\n");
            sb.Append("  HideFromSearch: ").Append(HideFromSearch).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  NumberOfSpots: ").Append(NumberOfSpots).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  ReflectionFormApproval: ").Append(ReflectionFormApproval).Append("\n");
            sb.Append("  AllowsTotalTimelogHoursSubmission: ").Append(AllowsTotalTimelogHoursSubmission).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  ConditionalBadgeGroupId: ").Append(ConditionalBadgeGroupId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((WorkflowExperience)obj);
        }

        /// <summary>
        /// Returns true if WorkflowExperience instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowExperience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowExperience other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ReflectionFormId == other.ReflectionFormId ||
                    ReflectionFormId != null &&
                    ReflectionFormId.Equals(other.ReflectionFormId)
                ) && 
                (
                    HideFromSearch == other.HideFromSearch ||
                    
                    HideFromSearch.Equals(other.HideFromSearch)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.Equals(other.Organization)
                ) && 
                (
                    NumberOfSpots == other.NumberOfSpots ||
                    NumberOfSpots != null &&
                    NumberOfSpots.Equals(other.NumberOfSpots)
                ) && 
                (
                    FormId == other.FormId ||
                    FormId != null &&
                    FormId.Equals(other.FormId)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
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
                    ReflectionFormApproval == other.ReflectionFormApproval ||
                    ReflectionFormApproval != null &&
                    ReflectionFormApproval.Equals(other.ReflectionFormApproval)
                ) && 
                (
                    AllowsTotalTimelogHoursSubmission == other.AllowsTotalTimelogHoursSubmission ||
                    
                    AllowsTotalTimelogHoursSubmission.Equals(other.AllowsTotalTimelogHoursSubmission)
                ) && 
                (
                    Contact == other.Contact ||
                    Contact != null &&
                    Contact.Equals(other.Contact)
                ) && 
                (
                    ConditionalBadgeGroupId == other.ConditionalBadgeGroupId ||
                    ConditionalBadgeGroupId != null &&
                    ConditionalBadgeGroupId.Equals(other.ConditionalBadgeGroupId)
                ) && 
                (
                    LocationId == other.LocationId ||
                    LocationId != null &&
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    
                    CreatedBy.Equals(other.CreatedBy)
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
                    if (ReflectionFormId != null)
                    hashCode = hashCode * 59 + ReflectionFormId.GetHashCode();
                    
                    hashCode = hashCode * 59 + HideFromSearch.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    if (NumberOfSpots != null)
                    hashCode = hashCode * 59 + NumberOfSpots.GetHashCode();
                    if (FormId != null)
                    hashCode = hashCode * 59 + FormId.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (ReflectionFormApproval != null)
                    hashCode = hashCode * 59 + ReflectionFormApproval.GetHashCode();
                    
                    hashCode = hashCode * 59 + AllowsTotalTimelogHoursSubmission.GetHashCode();
                    if (Contact != null)
                    hashCode = hashCode * 59 + Contact.GetHashCode();
                    if (ConditionalBadgeGroupId != null)
                    hashCode = hashCode * 59 + ConditionalBadgeGroupId.GetHashCode();
                    if (LocationId != null)
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WorkflowExperience left, WorkflowExperience right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WorkflowExperience left, WorkflowExperience right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
