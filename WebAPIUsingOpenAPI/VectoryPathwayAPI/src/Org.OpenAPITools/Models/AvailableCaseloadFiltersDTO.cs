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
    public partial class AvailableCaseloadFiltersDTO : IEquatable<AvailableCaseloadFiltersDTO>
    {
        /// <summary>
        /// Gets or Sets Courses
        /// </summary>
        [Required]
        [DataMember(Name="courses", EmitDefaultValue=false)]
        public List<AvailableCaseloadFilterCourseDTO> Courses { get; set; }

        /// <summary>
        /// Gets or Sets Schools
        /// </summary>
        [Required]
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<AvailableCaseloadFilterSchoolDTO> Schools { get; set; }

        /// <summary>
        /// Gets or Sets Districts
        /// </summary>
        [Required]
        [DataMember(Name="districts", EmitDefaultValue=false)]
        public List<AvailableCaseloadFilterDistrictDTO> Districts { get; set; }

        /// <summary>
        /// Gets or Sets Subjects
        /// </summary>
        [Required]
        [DataMember(Name="subjects", EmitDefaultValue=false)]
        public List<AvailableCaseloadFilterCourseSubjectDTO> Subjects { get; set; }

        /// <summary>
        /// Gets or Sets Grades
        /// </summary>
        [Required]
        [DataMember(Name="grades", EmitDefaultValue=false)]
        public List<AvailableCaseloadFilterGradeDTO> Grades { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableCaseloadFiltersDTO {\n");
            sb.Append("  Courses: ").Append(Courses).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  Districts: ").Append(Districts).Append("\n");
            sb.Append("  Subjects: ").Append(Subjects).Append("\n");
            sb.Append("  Grades: ").Append(Grades).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailableCaseloadFiltersDTO)obj);
        }

        /// <summary>
        /// Returns true if AvailableCaseloadFiltersDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableCaseloadFiltersDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableCaseloadFiltersDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Courses == other.Courses ||
                    Courses != null &&
                    other.Courses != null &&
                    Courses.SequenceEqual(other.Courses)
                ) && 
                (
                    Schools == other.Schools ||
                    Schools != null &&
                    other.Schools != null &&
                    Schools.SequenceEqual(other.Schools)
                ) && 
                (
                    Districts == other.Districts ||
                    Districts != null &&
                    other.Districts != null &&
                    Districts.SequenceEqual(other.Districts)
                ) && 
                (
                    Subjects == other.Subjects ||
                    Subjects != null &&
                    other.Subjects != null &&
                    Subjects.SequenceEqual(other.Subjects)
                ) && 
                (
                    Grades == other.Grades ||
                    Grades != null &&
                    other.Grades != null &&
                    Grades.SequenceEqual(other.Grades)
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
                    if (Courses != null)
                    hashCode = hashCode * 59 + Courses.GetHashCode();
                    if (Schools != null)
                    hashCode = hashCode * 59 + Schools.GetHashCode();
                    if (Districts != null)
                    hashCode = hashCode * 59 + Districts.GetHashCode();
                    if (Subjects != null)
                    hashCode = hashCode * 59 + Subjects.GetHashCode();
                    if (Grades != null)
                    hashCode = hashCode * 59 + Grades.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AvailableCaseloadFiltersDTO left, AvailableCaseloadFiltersDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailableCaseloadFiltersDTO left, AvailableCaseloadFiltersDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
