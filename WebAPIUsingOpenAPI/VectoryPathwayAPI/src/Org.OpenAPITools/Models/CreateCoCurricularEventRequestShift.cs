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
    public partial class CreateCoCurricularEventRequestShift : IEquatable<CreateCoCurricularEventRequestShift>
    {
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [Required]
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

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
        /// Gets or Sets EndTime
        /// </summary>
        [Required]
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCoCurricularEventRequestShift {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  MaxRegistrations: ").Append(MaxRegistrations).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateCoCurricularEventRequestShift)obj);
        }

        /// <summary>
        /// Returns true if CreateCoCurricularEventRequestShift instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCoCurricularEventRequestShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCoCurricularEventRequestShift other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
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
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
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
                    if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + Hours.GetHashCode();
                    if (MaxRegistrations != null)
                    hashCode = hashCode * 59 + MaxRegistrations.GetHashCode();
                    if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateCoCurricularEventRequestShift left, CreateCoCurricularEventRequestShift right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateCoCurricularEventRequestShift left, CreateCoCurricularEventRequestShift right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
