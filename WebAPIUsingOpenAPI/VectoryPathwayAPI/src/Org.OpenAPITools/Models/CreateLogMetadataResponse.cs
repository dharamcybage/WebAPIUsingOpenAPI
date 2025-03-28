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
    public partial class CreateLogMetadataResponse : IEquatable<CreateLogMetadataResponse>
    {
        /// <summary>
        /// Gets or Sets ServiceLogSignatureAllowed
        /// </summary>
        [Required]
        [DataMember(Name="serviceLogSignatureAllowed", EmitDefaultValue=true)]
        public bool ServiceLogSignatureAllowed { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfWords
        /// </summary>
        [Required]
        [DataMember(Name="numberOfWords", EmitDefaultValue=true)]
        public long NumberOfWords { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionPlaceholder
        /// </summary>
        [Required]
        [DataMember(Name="descriptionPlaceholder", EmitDefaultValue=false)]
        public string DescriptionPlaceholder { get; set; }

        /// <summary>
        /// Gets or Sets Organizations
        /// </summary>
        [Required]
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public List<SimpleServiceOrganization> Organizations { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [Required]
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<SimpleServiceGroup> Groups { get; set; }

        /// <summary>
        /// Gets or Sets HideGroupField
        /// </summary>
        [Required]
        [DataMember(Name="hideGroupField", EmitDefaultValue=true)]
        public bool HideGroupField { get; set; }

        /// <summary>
        /// Gets or Sets RequiresSponsorContactInfo
        /// </summary>
        [Required]
        [DataMember(Name="requiresSponsorContactInfo", EmitDefaultValue=true)]
        public bool RequiresSponsorContactInfo { get; set; }

        /// <summary>
        /// Gets or Sets HourLimit
        /// </summary>
        [Required]
        [DataMember(Name="hourLimit", EmitDefaultValue=true)]
        public long HourLimit { get; set; }

        /// <summary>
        /// Gets or Sets StudentsCanAddTags
        /// </summary>
        [Required]
        [DataMember(Name="studentsCanAddTags", EmitDefaultValue=true)]
        public bool StudentsCanAddTags { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLogSignatureRequired
        /// </summary>
        [Required]
        [DataMember(Name="serviceLogSignatureRequired", EmitDefaultValue=true)]
        public bool ServiceLogSignatureRequired { get; set; }

        /// <summary>
        /// Gets or Sets RequiresServeSponsorEmail
        /// </summary>
        [Required]
        [DataMember(Name="requiresServeSponsorEmail", EmitDefaultValue=true)]
        public bool RequiresServeSponsorEmail { get; set; }

        /// <summary>
        /// Gets or Sets RequirePhoneOnServe
        /// </summary>
        [Required]
        [DataMember(Name="requirePhoneOnServe", EmitDefaultValue=true)]
        public bool RequirePhoneOnServe { get; set; }

        /// <summary>
        /// Gets or Sets StudentsCanUploadFiles
        /// </summary>
        [Required]
        [DataMember(Name="studentsCanUploadFiles", EmitDefaultValue=true)]
        public bool StudentsCanUploadFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogMetadataResponse {\n");
            sb.Append("  ServiceLogSignatureAllowed: ").Append(ServiceLogSignatureAllowed).Append("\n");
            sb.Append("  NumberOfWords: ").Append(NumberOfWords).Append("\n");
            sb.Append("  DescriptionPlaceholder: ").Append(DescriptionPlaceholder).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  HideGroupField: ").Append(HideGroupField).Append("\n");
            sb.Append("  RequiresSponsorContactInfo: ").Append(RequiresSponsorContactInfo).Append("\n");
            sb.Append("  HourLimit: ").Append(HourLimit).Append("\n");
            sb.Append("  StudentsCanAddTags: ").Append(StudentsCanAddTags).Append("\n");
            sb.Append("  ServiceLogSignatureRequired: ").Append(ServiceLogSignatureRequired).Append("\n");
            sb.Append("  RequiresServeSponsorEmail: ").Append(RequiresServeSponsorEmail).Append("\n");
            sb.Append("  RequirePhoneOnServe: ").Append(RequirePhoneOnServe).Append("\n");
            sb.Append("  StudentsCanUploadFiles: ").Append(StudentsCanUploadFiles).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateLogMetadataResponse)obj);
        }

        /// <summary>
        /// Returns true if CreateLogMetadataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateLogMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLogMetadataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ServiceLogSignatureAllowed == other.ServiceLogSignatureAllowed ||
                    
                    ServiceLogSignatureAllowed.Equals(other.ServiceLogSignatureAllowed)
                ) && 
                (
                    NumberOfWords == other.NumberOfWords ||
                    
                    NumberOfWords.Equals(other.NumberOfWords)
                ) && 
                (
                    DescriptionPlaceholder == other.DescriptionPlaceholder ||
                    DescriptionPlaceholder != null &&
                    DescriptionPlaceholder.Equals(other.DescriptionPlaceholder)
                ) && 
                (
                    Organizations == other.Organizations ||
                    Organizations != null &&
                    other.Organizations != null &&
                    Organizations.SequenceEqual(other.Organizations)
                ) && 
                (
                    Groups == other.Groups ||
                    Groups != null &&
                    other.Groups != null &&
                    Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    HideGroupField == other.HideGroupField ||
                    
                    HideGroupField.Equals(other.HideGroupField)
                ) && 
                (
                    RequiresSponsorContactInfo == other.RequiresSponsorContactInfo ||
                    
                    RequiresSponsorContactInfo.Equals(other.RequiresSponsorContactInfo)
                ) && 
                (
                    HourLimit == other.HourLimit ||
                    
                    HourLimit.Equals(other.HourLimit)
                ) && 
                (
                    StudentsCanAddTags == other.StudentsCanAddTags ||
                    
                    StudentsCanAddTags.Equals(other.StudentsCanAddTags)
                ) && 
                (
                    ServiceLogSignatureRequired == other.ServiceLogSignatureRequired ||
                    
                    ServiceLogSignatureRequired.Equals(other.ServiceLogSignatureRequired)
                ) && 
                (
                    RequiresServeSponsorEmail == other.RequiresServeSponsorEmail ||
                    
                    RequiresServeSponsorEmail.Equals(other.RequiresServeSponsorEmail)
                ) && 
                (
                    RequirePhoneOnServe == other.RequirePhoneOnServe ||
                    
                    RequirePhoneOnServe.Equals(other.RequirePhoneOnServe)
                ) && 
                (
                    StudentsCanUploadFiles == other.StudentsCanUploadFiles ||
                    
                    StudentsCanUploadFiles.Equals(other.StudentsCanUploadFiles)
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
                    
                    hashCode = hashCode * 59 + ServiceLogSignatureAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfWords.GetHashCode();
                    if (DescriptionPlaceholder != null)
                    hashCode = hashCode * 59 + DescriptionPlaceholder.GetHashCode();
                    if (Organizations != null)
                    hashCode = hashCode * 59 + Organizations.GetHashCode();
                    if (Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();
                    
                    hashCode = hashCode * 59 + HideGroupField.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequiresSponsorContactInfo.GetHashCode();
                    
                    hashCode = hashCode * 59 + HourLimit.GetHashCode();
                    
                    hashCode = hashCode * 59 + StudentsCanAddTags.GetHashCode();
                    
                    hashCode = hashCode * 59 + ServiceLogSignatureRequired.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequiresServeSponsorEmail.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequirePhoneOnServe.GetHashCode();
                    
                    hashCode = hashCode * 59 + StudentsCanUploadFiles.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateLogMetadataResponse left, CreateLogMetadataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateLogMetadataResponse left, CreateLogMetadataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
