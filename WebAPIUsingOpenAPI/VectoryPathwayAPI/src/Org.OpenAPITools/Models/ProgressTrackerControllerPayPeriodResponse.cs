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
    public partial class ProgressTrackerControllerPayPeriodResponse : IEquatable<ProgressTrackerControllerPayPeriodResponse>
    {
        /// <summary>
        /// Gets or Sets ExperienceName
        /// </summary>
        [Required]
        [DataMember(Name="experienceName", EmitDefaultValue=false)]
        public string ExperienceName { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [Required]
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [Required]
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedHours
        /// </summary>
        [Required]
        [DataMember(Name="approvedHours", EmitDefaultValue=true)]
        public double ApprovedHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressTrackerControllerPayPeriodResponse {\n");
            sb.Append("  ExperienceName: ").Append(ExperienceName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ApprovedHours: ").Append(ApprovedHours).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProgressTrackerControllerPayPeriodResponse)obj);
        }

        /// <summary>
        /// Returns true if ProgressTrackerControllerPayPeriodResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgressTrackerControllerPayPeriodResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressTrackerControllerPayPeriodResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExperienceName == other.ExperienceName ||
                    ExperienceName != null &&
                    ExperienceName.Equals(other.ExperienceName)
                ) && 
                (
                    EndDate == other.EndDate ||
                    EndDate != null &&
                    EndDate.Equals(other.EndDate)
                ) && 
                (
                    StartDate == other.StartDate ||
                    StartDate != null &&
                    StartDate.Equals(other.StartDate)
                ) && 
                (
                    ApprovedHours == other.ApprovedHours ||
                    
                    ApprovedHours.Equals(other.ApprovedHours)
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
                    if (ExperienceName != null)
                    hashCode = hashCode * 59 + ExperienceName.GetHashCode();
                    if (EndDate != null)
                    hashCode = hashCode * 59 + EndDate.GetHashCode();
                    if (StartDate != null)
                    hashCode = hashCode * 59 + StartDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + ApprovedHours.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProgressTrackerControllerPayPeriodResponse left, ProgressTrackerControllerPayPeriodResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProgressTrackerControllerPayPeriodResponse left, ProgressTrackerControllerPayPeriodResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
