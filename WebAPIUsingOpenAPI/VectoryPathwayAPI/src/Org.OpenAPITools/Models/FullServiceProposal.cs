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
    public partial class FullServiceProposal : IEquatable<FullServiceProposal>
    {
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [Required]
        [DataMember(Name="serviceType", EmitDefaultValue=true)]
        public long ServiceType { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [Required]
        [DataMember(Name="parent_id", EmitDefaultValue=true)]
        public long ParentId { get; set; }

        /// <summary>
        /// Gets or Sets ParentsApproved
        /// </summary>
        [Required]
        [DataMember(Name="parentsApproved", EmitDefaultValue=true)]
        public bool ParentsApproved { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedBy
        /// </summary>
        [DataMember(Name="approvedBy", EmitDefaultValue=false)]
        public BasicUser ApprovedBy { get; set; }

        /// <summary>
        /// Gets or Sets AgencyRepresentative
        /// </summary>
        [Required]
        [DataMember(Name="agencyRepresentative", EmitDefaultValue=false)]
        public string AgencyRepresentative { get; set; }

        /// <summary>
        /// Gets or Sets ParentsSignature
        /// </summary>
        [DataMember(Name="parentsSignature", EmitDefaultValue=true)]
        public string ParentsSignature { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [Required]
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Object> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets AgencyEmail
        /// </summary>
        [Required]
        [DataMember(Name="agencyEmail", EmitDefaultValue=false)]
        public string AgencyEmail { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AgencyName
        /// </summary>
        [Required]
        [DataMember(Name="agencyName", EmitDefaultValue=false)]
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or Sets AgencyPhoneNumber
        /// </summary>
        [Required]
        [DataMember(Name="agencyPhoneNumber", EmitDefaultValue=false)]
        public string AgencyPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets RejectedBy
        /// </summary>
        [DataMember(Name="rejected_by", EmitDefaultValue=true)]
        public long? RejectedBy { get; set; }


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user", EmitDefaultValue=false)]
        public FullServiceProposalBasicUserWithID User { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [Required]
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public long UserId { get; set; }

        /// <summary>
        /// Gets or Sets ParentsRejected
        /// </summary>
        [Required]
        [DataMember(Name="parentsRejected", EmitDefaultValue=true)]
        public bool ParentsRejected { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullServiceProposal {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ParentsApproved: ").Append(ParentsApproved).Append("\n");
            sb.Append("  ApprovedBy: ").Append(ApprovedBy).Append("\n");
            sb.Append("  AgencyRepresentative: ").Append(AgencyRepresentative).Append("\n");
            sb.Append("  ParentsSignature: ").Append(ParentsSignature).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  AgencyEmail: ").Append(AgencyEmail).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AgencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  AgencyPhoneNumber: ").Append(AgencyPhoneNumber).Append("\n");
            sb.Append("  RejectedBy: ").Append(RejectedBy).Append("\n");
            sb.Append("  ApprovedBy: ").Append(ApprovedBy).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ParentsRejected: ").Append(ParentsRejected).Append("\n");
            sb.Append("  RejectedBy: ").Append(RejectedBy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FullServiceProposal)obj);
        }

        /// <summary>
        /// Returns true if FullServiceProposal instances are equal
        /// </summary>
        /// <param name="other">Instance of FullServiceProposal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullServiceProposal other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    ServiceType == other.ServiceType ||
                    
                    ServiceType.Equals(other.ServiceType)
                ) && 
                (
                    ParentId == other.ParentId ||
                    
                    ParentId.Equals(other.ParentId)
                ) && 
                (
                    ParentsApproved == other.ParentsApproved ||
                    
                    ParentsApproved.Equals(other.ParentsApproved)
                ) && 
                (
                    ApprovedBy == other.ApprovedBy ||
                    ApprovedBy != null &&
                    ApprovedBy.Equals(other.ApprovedBy)
                ) && 
                (
                    AgencyRepresentative == other.AgencyRepresentative ||
                    AgencyRepresentative != null &&
                    AgencyRepresentative.Equals(other.AgencyRepresentative)
                ) && 
                (
                    ParentsSignature == other.ParentsSignature ||
                    ParentsSignature != null &&
                    ParentsSignature.Equals(other.ParentsSignature)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    AgencyEmail == other.AgencyEmail ||
                    AgencyEmail != null &&
                    AgencyEmail.Equals(other.AgencyEmail)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    AgencyName == other.AgencyName ||
                    AgencyName != null &&
                    AgencyName.Equals(other.AgencyName)
                ) && 
                (
                    AgencyPhoneNumber == other.AgencyPhoneNumber ||
                    AgencyPhoneNumber != null &&
                    AgencyPhoneNumber.Equals(other.AgencyPhoneNumber)
                ) && 
                (
                    RejectedBy == other.RejectedBy ||
                    RejectedBy != null &&
                    RejectedBy.Equals(other.RejectedBy)
                ) && 
                (
                    ApprovedBy == other.ApprovedBy ||
                    ApprovedBy != null &&
                    ApprovedBy.Equals(other.ApprovedBy)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    UserId == other.UserId ||
                    
                    UserId.Equals(other.UserId)
                ) && 
                (
                    ParentsRejected == other.ParentsRejected ||
                    
                    ParentsRejected.Equals(other.ParentsRejected)
                ) && 
                (
                    RejectedBy == other.RejectedBy ||
                    RejectedBy != null &&
                    RejectedBy.Equals(other.RejectedBy)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + ServiceType.GetHashCode();
                    
                    hashCode = hashCode * 59 + ParentId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ParentsApproved.GetHashCode();
                    if (ApprovedBy != null)
                    hashCode = hashCode * 59 + ApprovedBy.GetHashCode();
                    if (AgencyRepresentative != null)
                    hashCode = hashCode * 59 + AgencyRepresentative.GetHashCode();
                    if (ParentsSignature != null)
                    hashCode = hashCode * 59 + ParentsSignature.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (AgencyEmail != null)
                    hashCode = hashCode * 59 + AgencyEmail.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (AgencyName != null)
                    hashCode = hashCode * 59 + AgencyName.GetHashCode();
                    if (AgencyPhoneNumber != null)
                    hashCode = hashCode * 59 + AgencyPhoneNumber.GetHashCode();
                    if (RejectedBy != null)
                    hashCode = hashCode * 59 + RejectedBy.GetHashCode();
                    if (ApprovedBy != null)
                    hashCode = hashCode * 59 + ApprovedBy.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    
                    hashCode = hashCode * 59 + ParentsRejected.GetHashCode();
                    if (RejectedBy != null)
                    hashCode = hashCode * 59 + RejectedBy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FullServiceProposal left, FullServiceProposal right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FullServiceProposal left, FullServiceProposal right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
