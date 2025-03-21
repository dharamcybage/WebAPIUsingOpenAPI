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
    public partial class EditExperienceControllerBulkSetCreateExperienceEvaluationRequest : IEquatable<EditExperienceControllerBulkSetCreateExperienceEvaluationRequest>
    {
        /// <summary>
        /// Gets or Sets EvaluationContent
        /// </summary>
        [Required]
        [DataMember(Name="evaluationContent", EmitDefaultValue=false)]
        public CreateExperienceEvaluationRequest EvaluationContent { get; set; }

        /// <summary>
        /// Gets or Sets DestinationExperienceIds
        /// </summary>
        [Required]
        [DataMember(Name="destinationExperienceIds", EmitDefaultValue=false)]
        public List<long> DestinationExperienceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditExperienceControllerBulkSetCreateExperienceEvaluationRequest {\n");
            sb.Append("  EvaluationContent: ").Append(EvaluationContent).Append("\n");
            sb.Append("  DestinationExperienceIds: ").Append(DestinationExperienceIds).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EditExperienceControllerBulkSetCreateExperienceEvaluationRequest)obj);
        }

        /// <summary>
        /// Returns true if EditExperienceControllerBulkSetCreateExperienceEvaluationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EditExperienceControllerBulkSetCreateExperienceEvaluationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditExperienceControllerBulkSetCreateExperienceEvaluationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EvaluationContent == other.EvaluationContent ||
                    EvaluationContent != null &&
                    EvaluationContent.Equals(other.EvaluationContent)
                ) && 
                (
                    DestinationExperienceIds == other.DestinationExperienceIds ||
                    DestinationExperienceIds != null &&
                    other.DestinationExperienceIds != null &&
                    DestinationExperienceIds.SequenceEqual(other.DestinationExperienceIds)
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
                    if (EvaluationContent != null)
                    hashCode = hashCode * 59 + EvaluationContent.GetHashCode();
                    if (DestinationExperienceIds != null)
                    hashCode = hashCode * 59 + DestinationExperienceIds.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EditExperienceControllerBulkSetCreateExperienceEvaluationRequest left, EditExperienceControllerBulkSetCreateExperienceEvaluationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EditExperienceControllerBulkSetCreateExperienceEvaluationRequest left, EditExperienceControllerBulkSetCreateExperienceEvaluationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
