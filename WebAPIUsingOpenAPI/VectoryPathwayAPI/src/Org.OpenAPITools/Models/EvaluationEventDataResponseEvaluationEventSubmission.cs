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
    public partial class EvaluationEventDataResponseEvaluationEventSubmission : IEquatable<EvaluationEventDataResponseEvaluationEventSubmission>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationGoalId
        /// </summary>
        [Required]
        [DataMember(Name="evaluation_goal_id", EmitDefaultValue=true)]
        public long EvaluationGoalId { get; set; }

        /// <summary>
        /// Gets or Sets IsStudent
        /// </summary>
        [Required]
        [DataMember(Name="isStudent", EmitDefaultValue=true)]
        public bool IsStudent { get; set; }

        /// <summary>
        /// Gets or Sets Ranking
        /// </summary>
        [DataMember(Name="ranking", EmitDefaultValue=true)]
        public long? Ranking { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationEventDataResponseEvaluationEventSubmission {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EvaluationGoalId: ").Append(EvaluationGoalId).Append("\n");
            sb.Append("  IsStudent: ").Append(IsStudent).Append("\n");
            sb.Append("  Ranking: ").Append(Ranking).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EvaluationEventDataResponseEvaluationEventSubmission)obj);
        }

        /// <summary>
        /// Returns true if EvaluationEventDataResponseEvaluationEventSubmission instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationEventDataResponseEvaluationEventSubmission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationEventDataResponseEvaluationEventSubmission other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    EvaluationGoalId == other.EvaluationGoalId ||
                    
                    EvaluationGoalId.Equals(other.EvaluationGoalId)
                ) && 
                (
                    IsStudent == other.IsStudent ||
                    
                    IsStudent.Equals(other.IsStudent)
                ) && 
                (
                    Ranking == other.Ranking ||
                    Ranking != null &&
                    Ranking.Equals(other.Ranking)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + EvaluationGoalId.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsStudent.GetHashCode();
                    if (Ranking != null)
                    hashCode = hashCode * 59 + Ranking.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EvaluationEventDataResponseEvaluationEventSubmission left, EvaluationEventDataResponseEvaluationEventSubmission right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EvaluationEventDataResponseEvaluationEventSubmission left, EvaluationEventDataResponseEvaluationEventSubmission right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
