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
    public partial class StudentProfileResponseFormData : IEquatable<StudentProfileResponseFormData>
    {
        /// <summary>
        /// Gets or Sets FormSubmissionDate
        /// </summary>
        [DataMember(Name="formSubmissionDate", EmitDefaultValue=true)]
        public DateTime? FormSubmissionDate { get; set; }

        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [Required]
        [DataMember(Name="formId", EmitDefaultValue=true)]
        public long FormId { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmissionId
        /// </summary>
        [Required]
        [DataMember(Name="formSubmissionId", EmitDefaultValue=true)]
        public long FormSubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets FormName
        /// </summary>
        [Required]
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentProfileResponseFormData {\n");
            sb.Append("  FormSubmissionDate: ").Append(FormSubmissionDate).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  FormSubmissionId: ").Append(FormSubmissionId).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StudentProfileResponseFormData)obj);
        }

        /// <summary>
        /// Returns true if StudentProfileResponseFormData instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentProfileResponseFormData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentProfileResponseFormData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FormSubmissionDate == other.FormSubmissionDate ||
                    FormSubmissionDate != null &&
                    FormSubmissionDate.Equals(other.FormSubmissionDate)
                ) && 
                (
                    FormId == other.FormId ||
                    
                    FormId.Equals(other.FormId)
                ) && 
                (
                    FormSubmissionId == other.FormSubmissionId ||
                    
                    FormSubmissionId.Equals(other.FormSubmissionId)
                ) && 
                (
                    FormName == other.FormName ||
                    FormName != null &&
                    FormName.Equals(other.FormName)
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
                    if (FormSubmissionDate != null)
                    hashCode = hashCode * 59 + FormSubmissionDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + FormId.GetHashCode();
                    
                    hashCode = hashCode * 59 + FormSubmissionId.GetHashCode();
                    if (FormName != null)
                    hashCode = hashCode * 59 + FormName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StudentProfileResponseFormData left, StudentProfileResponseFormData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StudentProfileResponseFormData left, StudentProfileResponseFormData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
