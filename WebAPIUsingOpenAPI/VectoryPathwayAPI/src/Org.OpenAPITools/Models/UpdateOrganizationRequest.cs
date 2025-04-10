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
    public partial class UpdateOrganizationRequest : IEquatable<UpdateOrganizationRequest>
    {
        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [Required]
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<long> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets MainNotes
        /// </summary>
        [Required]
        [DataMember(Name="mainNotes", EmitDefaultValue=false)]
        public string MainNotes { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=true)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets LocationDescription
        /// </summary>
        [Required]
        [DataMember(Name="locationDescription", EmitDefaultValue=false)]
        public string LocationDescription { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationRequest {\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  MainNotes: ").Append(MainNotes).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  LocationDescription: ").Append(LocationDescription).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateOrganizationRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateOrganizationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateOrganizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrganizationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    TagIds == other.TagIds ||
                    TagIds != null &&
                    other.TagIds != null &&
                    TagIds.SequenceEqual(other.TagIds)
                ) && 
                (
                    MainNotes == other.MainNotes ||
                    MainNotes != null &&
                    MainNotes.Equals(other.MainNotes)
                ) && 
                (
                    Website == other.Website ||
                    Website != null &&
                    Website.Equals(other.Website)
                ) && 
                (
                    LocationDescription == other.LocationDescription ||
                    LocationDescription != null &&
                    LocationDescription.Equals(other.LocationDescription)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
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
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (TagIds != null)
                    hashCode = hashCode * 59 + TagIds.GetHashCode();
                    if (MainNotes != null)
                    hashCode = hashCode * 59 + MainNotes.GetHashCode();
                    if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                    if (LocationDescription != null)
                    hashCode = hashCode * 59 + LocationDescription.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UpdateOrganizationRequest left, UpdateOrganizationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateOrganizationRequest left, UpdateOrganizationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
