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
    public partial class StudentServeReportResponse : IEquatable<StudentServeReportResponse>
    {
        /// <summary>
        /// Gets or Sets LifetimeHours
        /// </summary>
        [Required]
        [DataMember(Name="lifetimeHours", EmitDefaultValue=true)]
        public double LifetimeHours { get; set; }

        /// <summary>
        /// Gets or Sets Years
        /// </summary>
        [Required]
        [DataMember(Name="years", EmitDefaultValue=false)]
        public List<StudentServeReportResponseYearData> Years { get; set; }

        /// <summary>
        /// Gets or Sets SchoolSponsoredHours
        /// </summary>
        [Required]
        [DataMember(Name="schoolSponsoredHours", EmitDefaultValue=true)]
        public double SchoolSponsoredHours { get; set; }

        /// <summary>
        /// Gets or Sets NumberServiceEvents
        /// </summary>
        [Required]
        [DataMember(Name="numberServiceEvents", EmitDefaultValue=true)]
        public long NumberServiceEvents { get; set; }

        /// <summary>
        /// Gets or Sets TotalHoursVerified
        /// </summary>
        [Required]
        [DataMember(Name="totalHoursVerified", EmitDefaultValue=true)]
        public double TotalHoursVerified { get; set; }

        /// <summary>
        /// Gets or Sets ExternalHours
        /// </summary>
        [Required]
        [DataMember(Name="externalHours", EmitDefaultValue=true)]
        public double ExternalHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentServeReportResponse {\n");
            sb.Append("  LifetimeHours: ").Append(LifetimeHours).Append("\n");
            sb.Append("  Years: ").Append(Years).Append("\n");
            sb.Append("  SchoolSponsoredHours: ").Append(SchoolSponsoredHours).Append("\n");
            sb.Append("  NumberServiceEvents: ").Append(NumberServiceEvents).Append("\n");
            sb.Append("  TotalHoursVerified: ").Append(TotalHoursVerified).Append("\n");
            sb.Append("  ExternalHours: ").Append(ExternalHours).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StudentServeReportResponse)obj);
        }

        /// <summary>
        /// Returns true if StudentServeReportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentServeReportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentServeReportResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LifetimeHours == other.LifetimeHours ||
                    
                    LifetimeHours.Equals(other.LifetimeHours)
                ) && 
                (
                    Years == other.Years ||
                    Years != null &&
                    other.Years != null &&
                    Years.SequenceEqual(other.Years)
                ) && 
                (
                    SchoolSponsoredHours == other.SchoolSponsoredHours ||
                    
                    SchoolSponsoredHours.Equals(other.SchoolSponsoredHours)
                ) && 
                (
                    NumberServiceEvents == other.NumberServiceEvents ||
                    
                    NumberServiceEvents.Equals(other.NumberServiceEvents)
                ) && 
                (
                    TotalHoursVerified == other.TotalHoursVerified ||
                    
                    TotalHoursVerified.Equals(other.TotalHoursVerified)
                ) && 
                (
                    ExternalHours == other.ExternalHours ||
                    
                    ExternalHours.Equals(other.ExternalHours)
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
                    
                    hashCode = hashCode * 59 + LifetimeHours.GetHashCode();
                    if (Years != null)
                    hashCode = hashCode * 59 + Years.GetHashCode();
                    
                    hashCode = hashCode * 59 + SchoolSponsoredHours.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberServiceEvents.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalHoursVerified.GetHashCode();
                    
                    hashCode = hashCode * 59 + ExternalHours.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StudentServeReportResponse left, StudentServeReportResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StudentServeReportResponse left, StudentServeReportResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
