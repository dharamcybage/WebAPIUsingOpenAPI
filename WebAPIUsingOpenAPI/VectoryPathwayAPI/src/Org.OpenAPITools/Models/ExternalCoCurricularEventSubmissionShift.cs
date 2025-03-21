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
    public partial class ExternalCoCurricularEventSubmissionShift : IEquatable<ExternalCoCurricularEventSubmissionShift>
    {
        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [Required]
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [Required]
        [DataMember(Name="hours", EmitDefaultValue=true)]
        public double Hours { get; set; }

        /// <summary>
        /// Gets or Sets MaxRegistrations
        /// </summary>
        [DataMember(Name="maxRegistrations", EmitDefaultValue=true)]
        public long? MaxRegistrations { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [Required]
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalCoCurricularEventSubmissionShift {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  MaxRegistrations: ").Append(MaxRegistrations).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExternalCoCurricularEventSubmissionShift)obj);
        }

        /// <summary>
        /// Returns true if ExternalCoCurricularEventSubmissionShift instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalCoCurricularEventSubmissionShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalCoCurricularEventSubmissionShift other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
                ) && 
                (
                    Hours == other.Hours ||
                    
                    Hours.Equals(other.Hours)
                ) && 
                (
                    MaxRegistrations == other.MaxRegistrations ||
                    MaxRegistrations != null &&
                    MaxRegistrations.Equals(other.MaxRegistrations)
                ) && 
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
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
                    if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                    
                    hashCode = hashCode * 59 + Hours.GetHashCode();
                    if (MaxRegistrations != null)
                    hashCode = hashCode * 59 + MaxRegistrations.GetHashCode();
                    if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExternalCoCurricularEventSubmissionShift left, ExternalCoCurricularEventSubmissionShift right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExternalCoCurricularEventSubmissionShift left, ExternalCoCurricularEventSubmissionShift right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
