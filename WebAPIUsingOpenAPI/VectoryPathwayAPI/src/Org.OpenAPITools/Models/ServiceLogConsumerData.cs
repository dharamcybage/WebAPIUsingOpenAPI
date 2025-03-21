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
    public partial class ServiceLogConsumerData : IEquatable<ServiceLogConsumerData>
    {
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [Required]
        [DataMember(Name="year", EmitDefaultValue=false)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets TotalHours
        /// </summary>
        [Required]
        [DataMember(Name="totalHours", EmitDefaultValue=true)]
        public double TotalHours { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [Required]
        [DataMember(Name="verified", EmitDefaultValue=true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Gets or Sets NeedsRevision
        /// </summary>
        [Required]
        [DataMember(Name="needsRevision", EmitDefaultValue=true)]
        public bool NeedsRevision { get; set; }

        /// <summary>
        /// Gets or Sets ServiceEvent
        /// </summary>
        [Required]
        [DataMember(Name="serviceEvent", EmitDefaultValue=false)]
        public SimpleServiceEvent ServiceEvent { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLogConsumerData {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  NeedsRevision: ").Append(NeedsRevision).Append("\n");
            sb.Append("  ServiceEvent: ").Append(ServiceEvent).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServiceLogConsumerData)obj);
        }

        /// <summary>
        /// Returns true if ServiceLogConsumerData instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceLogConsumerData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceLogConsumerData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Year == other.Year ||
                    Year != null &&
                    Year.Equals(other.Year)
                ) && 
                (
                    TotalHours == other.TotalHours ||
                    
                    TotalHours.Equals(other.TotalHours)
                ) && 
                (
                    Verified == other.Verified ||
                    
                    Verified.Equals(other.Verified)
                ) && 
                (
                    NeedsRevision == other.NeedsRevision ||
                    
                    NeedsRevision.Equals(other.NeedsRevision)
                ) && 
                (
                    ServiceEvent == other.ServiceEvent ||
                    ServiceEvent != null &&
                    ServiceEvent.Equals(other.ServiceEvent)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
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
                    if (Year != null)
                    hashCode = hashCode * 59 + Year.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalHours.GetHashCode();
                    
                    hashCode = hashCode * 59 + Verified.GetHashCode();
                    
                    hashCode = hashCode * 59 + NeedsRevision.GetHashCode();
                    if (ServiceEvent != null)
                    hashCode = hashCode * 59 + ServiceEvent.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServiceLogConsumerData left, ServiceLogConsumerData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServiceLogConsumerData left, ServiceLogConsumerData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
