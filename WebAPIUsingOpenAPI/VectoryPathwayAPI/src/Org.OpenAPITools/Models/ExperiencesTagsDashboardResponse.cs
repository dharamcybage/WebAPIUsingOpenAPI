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
    public partial class ExperiencesTagsDashboardResponse : IEquatable<ExperiencesTagsDashboardResponse>
    {
        /// <summary>
        /// Gets or Sets Experience
        /// </summary>
        [Required]
        [DataMember(Name="experience", EmitDefaultValue=false)]
        public ExperienceDTO Experience { get; set; }

        /// <summary>
        /// Gets or Sets FormResponse
        /// </summary>
        [DataMember(Name="formResponse", EmitDefaultValue=false)]
        public FormSubmissionResponse FormResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExperiencesTagsDashboardResponse {\n");
            sb.Append("  Experience: ").Append(Experience).Append("\n");
            sb.Append("  FormResponse: ").Append(FormResponse).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExperiencesTagsDashboardResponse)obj);
        }

        /// <summary>
        /// Returns true if ExperiencesTagsDashboardResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExperiencesTagsDashboardResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperiencesTagsDashboardResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Experience == other.Experience ||
                    Experience != null &&
                    Experience.Equals(other.Experience)
                ) && 
                (
                    FormResponse == other.FormResponse ||
                    FormResponse != null &&
                    FormResponse.Equals(other.FormResponse)
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
                    if (Experience != null)
                    hashCode = hashCode * 59 + Experience.GetHashCode();
                    if (FormResponse != null)
                    hashCode = hashCode * 59 + FormResponse.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExperiencesTagsDashboardResponse left, ExperiencesTagsDashboardResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExperiencesTagsDashboardResponse left, ExperiencesTagsDashboardResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
