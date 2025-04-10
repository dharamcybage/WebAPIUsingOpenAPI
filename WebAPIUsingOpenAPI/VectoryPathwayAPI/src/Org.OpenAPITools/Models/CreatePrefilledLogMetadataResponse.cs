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
    public partial class CreatePrefilledLogMetadataResponse : IEquatable<CreatePrefilledLogMetadataResponse>
    {
        /// <summary>
        /// Gets or Sets DescriptionPlaceholder
        /// </summary>
        [Required]
        [DataMember(Name="descriptionPlaceholder", EmitDefaultValue=false)]
        public string DescriptionPlaceholder { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLogSignatureAllowed
        /// </summary>
        [Required]
        [DataMember(Name="serviceLogSignatureAllowed", EmitDefaultValue=true)]
        public bool ServiceLogSignatureAllowed { get; set; }

        /// <summary>
        /// Gets or Sets ServiceLogSignatureRequired
        /// </summary>
        [Required]
        [DataMember(Name="serviceLogSignatureRequired", EmitDefaultValue=true)]
        public bool ServiceLogSignatureRequired { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfWords
        /// </summary>
        [Required]
        [DataMember(Name="numberOfWords", EmitDefaultValue=true)]
        public long NumberOfWords { get; set; }

        /// <summary>
        /// Gets or Sets Days
        /// </summary>
        [Required]
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<BasicPreLogDay> Days { get; set; }

        /// <summary>
        /// Gets or Sets ServiceEvent
        /// </summary>
        [Required]
        [DataMember(Name="serviceEvent", EmitDefaultValue=false)]
        public BasicServiceEventOrgData ServiceEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrefilledLogMetadataResponse {\n");
            sb.Append("  DescriptionPlaceholder: ").Append(DescriptionPlaceholder).Append("\n");
            sb.Append("  ServiceLogSignatureAllowed: ").Append(ServiceLogSignatureAllowed).Append("\n");
            sb.Append("  ServiceLogSignatureRequired: ").Append(ServiceLogSignatureRequired).Append("\n");
            sb.Append("  NumberOfWords: ").Append(NumberOfWords).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  ServiceEvent: ").Append(ServiceEvent).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreatePrefilledLogMetadataResponse)obj);
        }

        /// <summary>
        /// Returns true if CreatePrefilledLogMetadataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreatePrefilledLogMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePrefilledLogMetadataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DescriptionPlaceholder == other.DescriptionPlaceholder ||
                    DescriptionPlaceholder != null &&
                    DescriptionPlaceholder.Equals(other.DescriptionPlaceholder)
                ) && 
                (
                    ServiceLogSignatureAllowed == other.ServiceLogSignatureAllowed ||
                    
                    ServiceLogSignatureAllowed.Equals(other.ServiceLogSignatureAllowed)
                ) && 
                (
                    ServiceLogSignatureRequired == other.ServiceLogSignatureRequired ||
                    
                    ServiceLogSignatureRequired.Equals(other.ServiceLogSignatureRequired)
                ) && 
                (
                    NumberOfWords == other.NumberOfWords ||
                    
                    NumberOfWords.Equals(other.NumberOfWords)
                ) && 
                (
                    Days == other.Days ||
                    Days != null &&
                    other.Days != null &&
                    Days.SequenceEqual(other.Days)
                ) && 
                (
                    ServiceEvent == other.ServiceEvent ||
                    ServiceEvent != null &&
                    ServiceEvent.Equals(other.ServiceEvent)
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
                    if (DescriptionPlaceholder != null)
                    hashCode = hashCode * 59 + DescriptionPlaceholder.GetHashCode();
                    
                    hashCode = hashCode * 59 + ServiceLogSignatureAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + ServiceLogSignatureRequired.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfWords.GetHashCode();
                    if (Days != null)
                    hashCode = hashCode * 59 + Days.GetHashCode();
                    if (ServiceEvent != null)
                    hashCode = hashCode * 59 + ServiceEvent.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreatePrefilledLogMetadataResponse left, CreatePrefilledLogMetadataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreatePrefilledLogMetadataResponse left, CreatePrefilledLogMetadataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
