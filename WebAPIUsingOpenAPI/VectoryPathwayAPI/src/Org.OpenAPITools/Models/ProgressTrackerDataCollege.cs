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
    public partial class ProgressTrackerDataCollege : IEquatable<ProgressTrackerDataCollege>
    {
        /// <summary>
        /// Gets or Sets AttendingCollege
        /// </summary>
        [DataMember(Name="attendingCollege", EmitDefaultValue=true)]
        public string AttendingCollege { get; set; }

        /// <summary>
        /// Gets or Sets LastTranscriptDate
        /// </summary>
        [DataMember(Name="lastTranscriptDate", EmitDefaultValue=true)]
        public DateTime? LastTranscriptDate { get; set; }

        /// <summary>
        /// Gets or Sets ApplyingCount
        /// </summary>
        [Required]
        [DataMember(Name="applyingCount", EmitDefaultValue=true)]
        public long ApplyingCount { get; set; }

        /// <summary>
        /// Gets or Sets FafsaDate
        /// </summary>
        [DataMember(Name="fafsaDate", EmitDefaultValue=true)]
        public DateTime? FafsaDate { get; set; }

        /// <summary>
        /// Gets or Sets AppliedCount
        /// </summary>
        [Required]
        [DataMember(Name="appliedCount", EmitDefaultValue=true)]
        public long AppliedCount { get; set; }

        /// <summary>
        /// Gets or Sets EssaysCompleted
        /// </summary>
        [Required]
        [DataMember(Name="essaysCompleted", EmitDefaultValue=true)]
        public long EssaysCompleted { get; set; }

        /// <summary>
        /// Gets or Sets LetterOfRecCompleted
        /// </summary>
        [Required]
        [DataMember(Name="letterOfRecCompleted", EmitDefaultValue=true)]
        public long LetterOfRecCompleted { get; set; }

        /// <summary>
        /// Gets or Sets EssaysGoal
        /// </summary>
        [Required]
        [DataMember(Name="essaysGoal", EmitDefaultValue=true)]
        public long EssaysGoal { get; set; }

        /// <summary>
        /// Gets or Sets InterestedCount
        /// </summary>
        [Required]
        [DataMember(Name="interestedCount", EmitDefaultValue=true)]
        public long InterestedCount { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedCount
        /// </summary>
        [Required]
        [DataMember(Name="acceptedCount", EmitDefaultValue=true)]
        public long AcceptedCount { get; set; }

        /// <summary>
        /// Gets or Sets BragSheetDate
        /// </summary>
        [DataMember(Name="bragSheetDate", EmitDefaultValue=true)]
        public DateTime? BragSheetDate { get; set; }

        /// <summary>
        /// Gets or Sets LetterOfRecGoal
        /// </summary>
        [Required]
        [DataMember(Name="letterOfRecGoal", EmitDefaultValue=true)]
        public long LetterOfRecGoal { get; set; }

        /// <summary>
        /// Gets or Sets RejectedCount
        /// </summary>
        [Required]
        [DataMember(Name="rejectedCount", EmitDefaultValue=true)]
        public long RejectedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressTrackerDataCollege {\n");
            sb.Append("  AttendingCollege: ").Append(AttendingCollege).Append("\n");
            sb.Append("  LastTranscriptDate: ").Append(LastTranscriptDate).Append("\n");
            sb.Append("  ApplyingCount: ").Append(ApplyingCount).Append("\n");
            sb.Append("  FafsaDate: ").Append(FafsaDate).Append("\n");
            sb.Append("  AppliedCount: ").Append(AppliedCount).Append("\n");
            sb.Append("  EssaysCompleted: ").Append(EssaysCompleted).Append("\n");
            sb.Append("  LetterOfRecCompleted: ").Append(LetterOfRecCompleted).Append("\n");
            sb.Append("  EssaysGoal: ").Append(EssaysGoal).Append("\n");
            sb.Append("  InterestedCount: ").Append(InterestedCount).Append("\n");
            sb.Append("  AcceptedCount: ").Append(AcceptedCount).Append("\n");
            sb.Append("  BragSheetDate: ").Append(BragSheetDate).Append("\n");
            sb.Append("  LetterOfRecGoal: ").Append(LetterOfRecGoal).Append("\n");
            sb.Append("  RejectedCount: ").Append(RejectedCount).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProgressTrackerDataCollege)obj);
        }

        /// <summary>
        /// Returns true if ProgressTrackerDataCollege instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgressTrackerDataCollege to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressTrackerDataCollege other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AttendingCollege == other.AttendingCollege ||
                    AttendingCollege != null &&
                    AttendingCollege.Equals(other.AttendingCollege)
                ) && 
                (
                    LastTranscriptDate == other.LastTranscriptDate ||
                    LastTranscriptDate != null &&
                    LastTranscriptDate.Equals(other.LastTranscriptDate)
                ) && 
                (
                    ApplyingCount == other.ApplyingCount ||
                    
                    ApplyingCount.Equals(other.ApplyingCount)
                ) && 
                (
                    FafsaDate == other.FafsaDate ||
                    FafsaDate != null &&
                    FafsaDate.Equals(other.FafsaDate)
                ) && 
                (
                    AppliedCount == other.AppliedCount ||
                    
                    AppliedCount.Equals(other.AppliedCount)
                ) && 
                (
                    EssaysCompleted == other.EssaysCompleted ||
                    
                    EssaysCompleted.Equals(other.EssaysCompleted)
                ) && 
                (
                    LetterOfRecCompleted == other.LetterOfRecCompleted ||
                    
                    LetterOfRecCompleted.Equals(other.LetterOfRecCompleted)
                ) && 
                (
                    EssaysGoal == other.EssaysGoal ||
                    
                    EssaysGoal.Equals(other.EssaysGoal)
                ) && 
                (
                    InterestedCount == other.InterestedCount ||
                    
                    InterestedCount.Equals(other.InterestedCount)
                ) && 
                (
                    AcceptedCount == other.AcceptedCount ||
                    
                    AcceptedCount.Equals(other.AcceptedCount)
                ) && 
                (
                    BragSheetDate == other.BragSheetDate ||
                    BragSheetDate != null &&
                    BragSheetDate.Equals(other.BragSheetDate)
                ) && 
                (
                    LetterOfRecGoal == other.LetterOfRecGoal ||
                    
                    LetterOfRecGoal.Equals(other.LetterOfRecGoal)
                ) && 
                (
                    RejectedCount == other.RejectedCount ||
                    
                    RejectedCount.Equals(other.RejectedCount)
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
                    if (AttendingCollege != null)
                    hashCode = hashCode * 59 + AttendingCollege.GetHashCode();
                    if (LastTranscriptDate != null)
                    hashCode = hashCode * 59 + LastTranscriptDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + ApplyingCount.GetHashCode();
                    if (FafsaDate != null)
                    hashCode = hashCode * 59 + FafsaDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + AppliedCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + EssaysCompleted.GetHashCode();
                    
                    hashCode = hashCode * 59 + LetterOfRecCompleted.GetHashCode();
                    
                    hashCode = hashCode * 59 + EssaysGoal.GetHashCode();
                    
                    hashCode = hashCode * 59 + InterestedCount.GetHashCode();
                    
                    hashCode = hashCode * 59 + AcceptedCount.GetHashCode();
                    if (BragSheetDate != null)
                    hashCode = hashCode * 59 + BragSheetDate.GetHashCode();
                    
                    hashCode = hashCode * 59 + LetterOfRecGoal.GetHashCode();
                    
                    hashCode = hashCode * 59 + RejectedCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProgressTrackerDataCollege left, ProgressTrackerDataCollege right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProgressTrackerDataCollege left, ProgressTrackerDataCollege right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
