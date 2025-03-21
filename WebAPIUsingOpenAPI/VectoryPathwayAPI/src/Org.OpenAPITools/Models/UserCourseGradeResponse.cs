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
    public partial class UserCourseGradeResponse : IEquatable<UserCourseGradeResponse>
    {
        /// <summary>
        /// Gets or Sets SectionName
        /// </summary>
        [Required]
        [DataMember(Name="sectionName", EmitDefaultValue=false)]
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or Sets GradeData
        /// </summary>
        [Required]
        [DataMember(Name="gradeData", EmitDefaultValue=false)]
        public Object GradeData { get; set; }

        /// <summary>
        /// Gets or Sets Student
        /// </summary>
        [Required]
        [DataMember(Name="student", EmitDefaultValue=false)]
        public BasicUserWithFields Student { get; set; }

        /// <summary>
        /// Gets or Sets CourseName
        /// </summary>
        [Required]
        [DataMember(Name="courseName", EmitDefaultValue=false)]
        public string CourseName { get; set; }

        /// <summary>
        /// Gets or Sets InstructorName
        /// </summary>
        [Required]
        [DataMember(Name="instructorName", EmitDefaultValue=false)]
        public string InstructorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCourseGradeResponse {\n");
            sb.Append("  SectionName: ").Append(SectionName).Append("\n");
            sb.Append("  GradeData: ").Append(GradeData).Append("\n");
            sb.Append("  Student: ").Append(Student).Append("\n");
            sb.Append("  CourseName: ").Append(CourseName).Append("\n");
            sb.Append("  InstructorName: ").Append(InstructorName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserCourseGradeResponse)obj);
        }

        /// <summary>
        /// Returns true if UserCourseGradeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserCourseGradeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCourseGradeResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SectionName == other.SectionName ||
                    SectionName != null &&
                    SectionName.Equals(other.SectionName)
                ) && 
                (
                    GradeData == other.GradeData ||
                    GradeData != null &&
                    GradeData.Equals(other.GradeData)
                ) && 
                (
                    Student == other.Student ||
                    Student != null &&
                    Student.Equals(other.Student)
                ) && 
                (
                    CourseName == other.CourseName ||
                    CourseName != null &&
                    CourseName.Equals(other.CourseName)
                ) && 
                (
                    InstructorName == other.InstructorName ||
                    InstructorName != null &&
                    InstructorName.Equals(other.InstructorName)
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
                    if (SectionName != null)
                    hashCode = hashCode * 59 + SectionName.GetHashCode();
                    if (GradeData != null)
                    hashCode = hashCode * 59 + GradeData.GetHashCode();
                    if (Student != null)
                    hashCode = hashCode * 59 + Student.GetHashCode();
                    if (CourseName != null)
                    hashCode = hashCode * 59 + CourseName.GetHashCode();
                    if (InstructorName != null)
                    hashCode = hashCode * 59 + InstructorName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserCourseGradeResponse left, UserCourseGradeResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserCourseGradeResponse left, UserCourseGradeResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
