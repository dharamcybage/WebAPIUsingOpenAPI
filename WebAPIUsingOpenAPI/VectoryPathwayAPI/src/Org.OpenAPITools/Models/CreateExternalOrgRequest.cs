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
    public partial class CreateExternalOrgRequest : IEquatable<CreateExternalOrgRequest>
    {
        /// <summary>
        /// Gets or Sets CreatedByLastName
        /// </summary>
        [Required]
        [DataMember(Name="createdByLastName", EmitDefaultValue=false)]
        public string CreatedByLastName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=true)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [Required]
        [DataMember(Name="locationName", EmitDefaultValue=false)]
        public string LocationName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByEmail
        /// </summary>
        [Required]
        [DataMember(Name="createdByEmail", EmitDefaultValue=false)]
        public string CreatedByEmail { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=true)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets CreatedByFirstName
        /// </summary>
        [Required]
        [DataMember(Name="createdByFirstName", EmitDefaultValue=false)]
        public string CreatedByFirstName { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=true)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [DataMember(Name="form_submission_id", EmitDefaultValue=true)]
        public long? FormSubmissionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExternalOrgRequest {\n");
            sb.Append("  CreatedByLastName: ").Append(CreatedByLastName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  CreatedByEmail: ").Append(CreatedByEmail).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  CreatedByFirstName: ").Append(CreatedByFirstName).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateExternalOrgRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateExternalOrgRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateExternalOrgRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateExternalOrgRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CreatedByLastName == other.CreatedByLastName ||
                    CreatedByLastName != null &&
                    CreatedByLastName.Equals(other.CreatedByLastName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                ) && 
                (
                    Longitude == other.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(other.Longitude)
                ) && 
                (
                    LocationName == other.LocationName ||
                    LocationName != null &&
                    LocationName.Equals(other.LocationName)
                ) && 
                (
                    CreatedByEmail == other.CreatedByEmail ||
                    CreatedByEmail != null &&
                    CreatedByEmail.Equals(other.CreatedByEmail)
                ) && 
                (
                    Latitude == other.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    CreatedByFirstName == other.CreatedByFirstName ||
                    CreatedByFirstName != null &&
                    CreatedByFirstName.Equals(other.CreatedByFirstName)
                ) && 
                (
                    Website == other.Website ||
                    Website != null &&
                    Website.Equals(other.Website)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    FormSubmissionId != null &&
                    FormSubmissionId.Equals(other.FormSubmissionId)
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
                    if (CreatedByLastName != null)
                    hashCode = hashCode * 59 + CreatedByLastName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    if (LocationName != null)
                    hashCode = hashCode * 59 + LocationName.GetHashCode();
                    if (CreatedByEmail != null)
                    hashCode = hashCode * 59 + CreatedByEmail.GetHashCode();
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (CreatedByFirstName != null)
                    hashCode = hashCode * 59 + CreatedByFirstName.GetHashCode();
                    if (Website != null)
                    hashCode = hashCode * 59 + Website.GetHashCode();
                    if (FormSubmissionId != null)
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateExternalOrgRequest left, CreateExternalOrgRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateExternalOrgRequest left, CreateExternalOrgRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
