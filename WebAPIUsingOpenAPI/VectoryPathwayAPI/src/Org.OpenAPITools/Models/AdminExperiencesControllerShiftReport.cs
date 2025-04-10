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
    public partial class AdminExperiencesControllerShiftReport : IEquatable<AdminExperiencesControllerShiftReport>
    {
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required]
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required]
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets ShiftEndTime
        /// </summary>
        [Required]
        [DataMember(Name="shiftEndTime", EmitDefaultValue=false)]
        public DateTime ShiftEndTime { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceName
        /// </summary>
        [DataMember(Name="experienceName", EmitDefaultValue=true)]
        public string ExperienceName { get; set; }

        /// <summary>
        /// Gets or Sets ShiftStartTime
        /// </summary>
        [Required]
        [DataMember(Name="shiftStartTime", EmitDefaultValue=false)]
        public DateTime ShiftStartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminExperiencesControllerShiftReport {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  ShiftEndTime: ").Append(ShiftEndTime).Append("\n");
            sb.Append("  ExperienceName: ").Append(ExperienceName).Append("\n");
            sb.Append("  ShiftStartTime: ").Append(ShiftStartTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AdminExperiencesControllerShiftReport)obj);
        }

        /// <summary>
        /// Returns true if AdminExperiencesControllerShiftReport instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminExperiencesControllerShiftReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminExperiencesControllerShiftReport other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    ShiftEndTime == other.ShiftEndTime ||
                    ShiftEndTime != null &&
                    ShiftEndTime.Equals(other.ShiftEndTime)
                ) && 
                (
                    ExperienceName == other.ExperienceName ||
                    ExperienceName != null &&
                    ExperienceName.Equals(other.ExperienceName)
                ) && 
                (
                    ShiftStartTime == other.ShiftStartTime ||
                    ShiftStartTime != null &&
                    ShiftStartTime.Equals(other.ShiftStartTime)
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
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (ShiftEndTime != null)
                    hashCode = hashCode * 59 + ShiftEndTime.GetHashCode();
                    if (ExperienceName != null)
                    hashCode = hashCode * 59 + ExperienceName.GetHashCode();
                    if (ShiftStartTime != null)
                    hashCode = hashCode * 59 + ShiftStartTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AdminExperiencesControllerShiftReport left, AdminExperiencesControllerShiftReport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AdminExperiencesControllerShiftReport left, AdminExperiencesControllerShiftReport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
