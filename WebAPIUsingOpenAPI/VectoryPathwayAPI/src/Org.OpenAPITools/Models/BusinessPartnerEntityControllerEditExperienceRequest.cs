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
    public partial class BusinessPartnerEntityControllerEditExperienceRequest : IEquatable<BusinessPartnerEntityControllerEditExperienceRequest>
    {
        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=true)]
        public long? LocationId { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="formSubmissionId", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFormId
        /// </summary>
        [DataMember(Name="applicationFormId", EmitDefaultValue=true)]
        public long? ApplicationFormId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfSpots
        /// </summary>
        [DataMember(Name="numberOfSpots", EmitDefaultValue=true)]
        public long? NumberOfSpots { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TimeLogFormId
        /// </summary>
        [DataMember(Name="timeLogFormId", EmitDefaultValue=true)]
        public long? TimeLogFormId { get; set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contactId", EmitDefaultValue=true)]
        public long? ContactId { get; set; }

        /// <summary>
        /// Gets or Sets ClusterIds
        /// </summary>
        [Required]
        [DataMember(Name="clusterIds", EmitDefaultValue=false)]
        public List<long> ClusterIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessPartnerEntityControllerEditExperienceRequest {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  ApplicationFormId: ").Append(ApplicationFormId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  NumberOfSpots: ").Append(NumberOfSpots).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeLogFormId: ").Append(TimeLogFormId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  ClusterIds: ").Append(ClusterIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BusinessPartnerEntityControllerEditExperienceRequest)obj);
        }

        /// <summary>
        /// Returns true if BusinessPartnerEntityControllerEditExperienceRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessPartnerEntityControllerEditExperienceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessPartnerEntityControllerEditExperienceRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocationId == other.LocationId ||
                    LocationId != null &&
                    LocationId.Equals(other.LocationId)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    ApplicationFormId == other.ApplicationFormId ||
                    ApplicationFormId != null &&
                    ApplicationFormId.Equals(other.ApplicationFormId)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
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
                    NumberOfSpots == other.NumberOfSpots ||
                    NumberOfSpots != null &&
                    NumberOfSpots.Equals(other.NumberOfSpots)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    TimeLogFormId == other.TimeLogFormId ||
                    TimeLogFormId != null &&
                    TimeLogFormId.Equals(other.TimeLogFormId)
                ) && 
                (
                    ContactId == other.ContactId ||
                    ContactId != null &&
                    ContactId.Equals(other.ContactId)
                ) && 
                (
                    ClusterIds == other.ClusterIds ||
                    ClusterIds != null &&
                    other.ClusterIds != null &&
                    ClusterIds.SequenceEqual(other.ClusterIds)
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
                    if (LocationId != null)
                    hashCode = hashCode * 59 + LocationId.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (ApplicationFormId != null)
                    hashCode = hashCode * 59 + ApplicationFormId.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (NumberOfSpots != null)
                    hashCode = hashCode * 59 + NumberOfSpots.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (TimeLogFormId != null)
                    hashCode = hashCode * 59 + TimeLogFormId.GetHashCode();
                    if (ContactId != null)
                    hashCode = hashCode * 59 + ContactId.GetHashCode();
                    if (ClusterIds != null)
                    hashCode = hashCode * 59 + ClusterIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessPartnerEntityControllerEditExperienceRequest left, BusinessPartnerEntityControllerEditExperienceRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessPartnerEntityControllerEditExperienceRequest left, BusinessPartnerEntityControllerEditExperienceRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
