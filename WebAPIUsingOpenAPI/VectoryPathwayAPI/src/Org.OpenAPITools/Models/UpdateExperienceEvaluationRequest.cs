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
    public partial class UpdateExperienceEvaluationRequest : IEquatable<UpdateExperienceEvaluationRequest>
    {
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets StudentsCanAddGoals
        /// </summary>
        [Required]
        [DataMember(Name="studentsCanAddGoals", EmitDefaultValue=true)]
        public bool StudentsCanAddGoals { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AllowsNotApplicable
        /// </summary>
        [Required]
        [DataMember(Name="allowsNotApplicable", EmitDefaultValue=true)]
        public bool AllowsNotApplicable { get; set; }

        /// <summary>
        /// Gets or Sets ReminderDays
        /// </summary>
        [Required]
        [DataMember(Name="reminderDays", EmitDefaultValue=true)]
        public long ReminderDays { get; set; }

        /// <summary>
        /// Gets or Sets RequiresSignature
        /// </summary>
        [Required]
        [DataMember(Name="requiresSignature", EmitDefaultValue=true)]
        public bool RequiresSignature { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RankingMinimum
        /// </summary>
        [DataMember(Name="rankingMinimum", EmitDefaultValue=true)]
        public long? RankingMinimum { get; set; }

        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [DataMember(Name="form_id", EmitDefaultValue=true)]
        public long? FormId { get; set; }

        /// <summary>
        /// Gets or Sets RankingMaximum
        /// </summary>
        [DataMember(Name="rankingMaximum", EmitDefaultValue=true)]
        public long? RankingMaximum { get; set; }

        /// <summary>
        /// Gets or Sets StudentsSelfRank
        /// </summary>
        [Required]
        [DataMember(Name="studentsSelfRank", EmitDefaultValue=true)]
        public bool StudentsSelfRank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExperienceEvaluationRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  StudentsCanAddGoals: ").Append(StudentsCanAddGoals).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AllowsNotApplicable: ").Append(AllowsNotApplicable).Append("\n");
            sb.Append("  ReminderDays: ").Append(ReminderDays).Append("\n");
            sb.Append("  RequiresSignature: ").Append(RequiresSignature).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RankingMinimum: ").Append(RankingMinimum).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  RankingMaximum: ").Append(RankingMaximum).Append("\n");
            sb.Append("  StudentsSelfRank: ").Append(StudentsSelfRank).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateExperienceEvaluationRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateExperienceEvaluationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateExperienceEvaluationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateExperienceEvaluationRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    StudentsCanAddGoals == other.StudentsCanAddGoals ||
                    
                    StudentsCanAddGoals.Equals(other.StudentsCanAddGoals)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    AllowsNotApplicable == other.AllowsNotApplicable ||
                    
                    AllowsNotApplicable.Equals(other.AllowsNotApplicable)
                ) && 
                (
                    ReminderDays == other.ReminderDays ||
                    
                    ReminderDays.Equals(other.ReminderDays)
                ) && 
                (
                    RequiresSignature == other.RequiresSignature ||
                    
                    RequiresSignature.Equals(other.RequiresSignature)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    RankingMinimum == other.RankingMinimum ||
                    RankingMinimum != null &&
                    RankingMinimum.Equals(other.RankingMinimum)
                ) && 
                (
                    FormId == other.FormId ||
                    FormId != null &&
                    FormId.Equals(other.FormId)
                ) && 
                (
                    RankingMaximum == other.RankingMaximum ||
                    RankingMaximum != null &&
                    RankingMaximum.Equals(other.RankingMaximum)
                ) && 
                (
                    StudentsSelfRank == other.StudentsSelfRank ||
                    
                    StudentsSelfRank.Equals(other.StudentsSelfRank)
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
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    
                    hashCode = hashCode * 59 + StudentsCanAddGoals.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + AllowsNotApplicable.GetHashCode();
                    
                    hashCode = hashCode * 59 + ReminderDays.GetHashCode();
                    
                    hashCode = hashCode * 59 + RequiresSignature.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (RankingMinimum != null)
                    hashCode = hashCode * 59 + RankingMinimum.GetHashCode();
                    if (FormId != null)
                    hashCode = hashCode * 59 + FormId.GetHashCode();
                    if (RankingMaximum != null)
                    hashCode = hashCode * 59 + RankingMaximum.GetHashCode();
                    
                    hashCode = hashCode * 59 + StudentsSelfRank.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UpdateExperienceEvaluationRequest left, UpdateExperienceEvaluationRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateExperienceEvaluationRequest left, UpdateExperienceEvaluationRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
