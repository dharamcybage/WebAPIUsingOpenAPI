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
    public partial class SettingsCollegeUpdateRequest : IEquatable<SettingsCollegeUpdateRequest>
    {
        /// <summary>
        /// Gets or Sets TestScoresHelpText
        /// </summary>
        [DataMember(Name="testScoresHelpText", EmitDefaultValue=true)]
        public string TestScoresHelpText { get; set; }

        /// <summary>
        /// Gets or Sets DocumentsHelpText
        /// </summary>
        [DataMember(Name="documentsHelpText", EmitDefaultValue=true)]
        public string DocumentsHelpText { get; set; }

        /// <summary>
        /// Gets or Sets InterestedCollegeTarget
        /// </summary>
        [DataMember(Name="interestedCollegeTarget", EmitDefaultValue=true)]
        public long? InterestedCollegeTarget { get; set; }

        /// <summary>
        /// Gets or Sets AttendingCollegeWorkflowForm
        /// </summary>
        [DataMember(Name="attendingCollegeWorkflowForm", EmitDefaultValue=true)]
        public long? AttendingCollegeWorkflowForm { get; set; }

        /// <summary>
        /// Gets or Sets EssaysHelpText
        /// </summary>
        [DataMember(Name="essaysHelpText", EmitDefaultValue=true)]
        public string EssaysHelpText { get; set; }

        /// <summary>
        /// Gets or Sets BragSheetForm
        /// </summary>
        [DataMember(Name="bragSheetForm", EmitDefaultValue=true)]
        public long? BragSheetForm { get; set; }

        /// <summary>
        /// Gets or Sets LetterOfRecForm
        /// </summary>
        [DataMember(Name="letterOfRecForm", EmitDefaultValue=true)]
        public long? LetterOfRecForm { get; set; }

        /// <summary>
        /// Gets or Sets CollegeFafsaActivity
        /// </summary>
        [DataMember(Name="collegeFafsaActivity", EmitDefaultValue=true)]
        public long? CollegeFafsaActivity { get; set; }

        /// <summary>
        /// Gets or Sets CollegeBadge
        /// </summary>
        [DataMember(Name="collegeBadge", EmitDefaultValue=true)]
        public long? CollegeBadge { get; set; }

        /// <summary>
        /// Gets or Sets CollegeEssaysTarget
        /// </summary>
        [DataMember(Name="collegeEssaysTarget", EmitDefaultValue=true)]
        public long? CollegeEssaysTarget { get; set; }

        /// <summary>
        /// Gets or Sets PrepBadgeHelpText
        /// </summary>
        [DataMember(Name="prepBadgeHelpText", EmitDefaultValue=true)]
        public string PrepBadgeHelpText { get; set; }

        /// <summary>
        /// Gets or Sets LettersOfRecHelpText
        /// </summary>
        [DataMember(Name="lettersOfRecHelpText", EmitDefaultValue=true)]
        public string LettersOfRecHelpText { get; set; }

        /// <summary>
        /// Gets or Sets CollegeLetterOfRecTarget
        /// </summary>
        [DataMember(Name="collegeLetterOfRecTarget", EmitDefaultValue=true)]
        public long? CollegeLetterOfRecTarget { get; set; }

        /// <summary>
        /// Gets or Sets BragSheetHelpText
        /// </summary>
        [DataMember(Name="bragSheetHelpText", EmitDefaultValue=true)]
        public string BragSheetHelpText { get; set; }

        /// <summary>
        /// Gets or Sets AppFormsHelpText
        /// </summary>
        [DataMember(Name="appFormsHelpText", EmitDefaultValue=true)]
        public string AppFormsHelpText { get; set; }

        /// <summary>
        /// Gets or Sets FafsaHelpText
        /// </summary>
        [DataMember(Name="fafsaHelpText", EmitDefaultValue=true)]
        public string FafsaHelpText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsCollegeUpdateRequest {\n");
            sb.Append("  TestScoresHelpText: ").Append(TestScoresHelpText).Append("\n");
            sb.Append("  DocumentsHelpText: ").Append(DocumentsHelpText).Append("\n");
            sb.Append("  InterestedCollegeTarget: ").Append(InterestedCollegeTarget).Append("\n");
            sb.Append("  AttendingCollegeWorkflowForm: ").Append(AttendingCollegeWorkflowForm).Append("\n");
            sb.Append("  EssaysHelpText: ").Append(EssaysHelpText).Append("\n");
            sb.Append("  BragSheetForm: ").Append(BragSheetForm).Append("\n");
            sb.Append("  LetterOfRecForm: ").Append(LetterOfRecForm).Append("\n");
            sb.Append("  CollegeFafsaActivity: ").Append(CollegeFafsaActivity).Append("\n");
            sb.Append("  CollegeBadge: ").Append(CollegeBadge).Append("\n");
            sb.Append("  CollegeEssaysTarget: ").Append(CollegeEssaysTarget).Append("\n");
            sb.Append("  PrepBadgeHelpText: ").Append(PrepBadgeHelpText).Append("\n");
            sb.Append("  LettersOfRecHelpText: ").Append(LettersOfRecHelpText).Append("\n");
            sb.Append("  CollegeLetterOfRecTarget: ").Append(CollegeLetterOfRecTarget).Append("\n");
            sb.Append("  BragSheetHelpText: ").Append(BragSheetHelpText).Append("\n");
            sb.Append("  AppFormsHelpText: ").Append(AppFormsHelpText).Append("\n");
            sb.Append("  FafsaHelpText: ").Append(FafsaHelpText).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SettingsCollegeUpdateRequest)obj);
        }

        /// <summary>
        /// Returns true if SettingsCollegeUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingsCollegeUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsCollegeUpdateRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TestScoresHelpText == other.TestScoresHelpText ||
                    TestScoresHelpText != null &&
                    TestScoresHelpText.Equals(other.TestScoresHelpText)
                ) && 
                (
                    DocumentsHelpText == other.DocumentsHelpText ||
                    DocumentsHelpText != null &&
                    DocumentsHelpText.Equals(other.DocumentsHelpText)
                ) && 
                (
                    InterestedCollegeTarget == other.InterestedCollegeTarget ||
                    InterestedCollegeTarget != null &&
                    InterestedCollegeTarget.Equals(other.InterestedCollegeTarget)
                ) && 
                (
                    AttendingCollegeWorkflowForm == other.AttendingCollegeWorkflowForm ||
                    AttendingCollegeWorkflowForm != null &&
                    AttendingCollegeWorkflowForm.Equals(other.AttendingCollegeWorkflowForm)
                ) && 
                (
                    EssaysHelpText == other.EssaysHelpText ||
                    EssaysHelpText != null &&
                    EssaysHelpText.Equals(other.EssaysHelpText)
                ) && 
                (
                    BragSheetForm == other.BragSheetForm ||
                    BragSheetForm != null &&
                    BragSheetForm.Equals(other.BragSheetForm)
                ) && 
                (
                    LetterOfRecForm == other.LetterOfRecForm ||
                    LetterOfRecForm != null &&
                    LetterOfRecForm.Equals(other.LetterOfRecForm)
                ) && 
                (
                    CollegeFafsaActivity == other.CollegeFafsaActivity ||
                    CollegeFafsaActivity != null &&
                    CollegeFafsaActivity.Equals(other.CollegeFafsaActivity)
                ) && 
                (
                    CollegeBadge == other.CollegeBadge ||
                    CollegeBadge != null &&
                    CollegeBadge.Equals(other.CollegeBadge)
                ) && 
                (
                    CollegeEssaysTarget == other.CollegeEssaysTarget ||
                    CollegeEssaysTarget != null &&
                    CollegeEssaysTarget.Equals(other.CollegeEssaysTarget)
                ) && 
                (
                    PrepBadgeHelpText == other.PrepBadgeHelpText ||
                    PrepBadgeHelpText != null &&
                    PrepBadgeHelpText.Equals(other.PrepBadgeHelpText)
                ) && 
                (
                    LettersOfRecHelpText == other.LettersOfRecHelpText ||
                    LettersOfRecHelpText != null &&
                    LettersOfRecHelpText.Equals(other.LettersOfRecHelpText)
                ) && 
                (
                    CollegeLetterOfRecTarget == other.CollegeLetterOfRecTarget ||
                    CollegeLetterOfRecTarget != null &&
                    CollegeLetterOfRecTarget.Equals(other.CollegeLetterOfRecTarget)
                ) && 
                (
                    BragSheetHelpText == other.BragSheetHelpText ||
                    BragSheetHelpText != null &&
                    BragSheetHelpText.Equals(other.BragSheetHelpText)
                ) && 
                (
                    AppFormsHelpText == other.AppFormsHelpText ||
                    AppFormsHelpText != null &&
                    AppFormsHelpText.Equals(other.AppFormsHelpText)
                ) && 
                (
                    FafsaHelpText == other.FafsaHelpText ||
                    FafsaHelpText != null &&
                    FafsaHelpText.Equals(other.FafsaHelpText)
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
                    if (TestScoresHelpText != null)
                    hashCode = hashCode * 59 + TestScoresHelpText.GetHashCode();
                    if (DocumentsHelpText != null)
                    hashCode = hashCode * 59 + DocumentsHelpText.GetHashCode();
                    if (InterestedCollegeTarget != null)
                    hashCode = hashCode * 59 + InterestedCollegeTarget.GetHashCode();
                    if (AttendingCollegeWorkflowForm != null)
                    hashCode = hashCode * 59 + AttendingCollegeWorkflowForm.GetHashCode();
                    if (EssaysHelpText != null)
                    hashCode = hashCode * 59 + EssaysHelpText.GetHashCode();
                    if (BragSheetForm != null)
                    hashCode = hashCode * 59 + BragSheetForm.GetHashCode();
                    if (LetterOfRecForm != null)
                    hashCode = hashCode * 59 + LetterOfRecForm.GetHashCode();
                    if (CollegeFafsaActivity != null)
                    hashCode = hashCode * 59 + CollegeFafsaActivity.GetHashCode();
                    if (CollegeBadge != null)
                    hashCode = hashCode * 59 + CollegeBadge.GetHashCode();
                    if (CollegeEssaysTarget != null)
                    hashCode = hashCode * 59 + CollegeEssaysTarget.GetHashCode();
                    if (PrepBadgeHelpText != null)
                    hashCode = hashCode * 59 + PrepBadgeHelpText.GetHashCode();
                    if (LettersOfRecHelpText != null)
                    hashCode = hashCode * 59 + LettersOfRecHelpText.GetHashCode();
                    if (CollegeLetterOfRecTarget != null)
                    hashCode = hashCode * 59 + CollegeLetterOfRecTarget.GetHashCode();
                    if (BragSheetHelpText != null)
                    hashCode = hashCode * 59 + BragSheetHelpText.GetHashCode();
                    if (AppFormsHelpText != null)
                    hashCode = hashCode * 59 + AppFormsHelpText.GetHashCode();
                    if (FafsaHelpText != null)
                    hashCode = hashCode * 59 + FafsaHelpText.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SettingsCollegeUpdateRequest left, SettingsCollegeUpdateRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SettingsCollegeUpdateRequest left, SettingsCollegeUpdateRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
