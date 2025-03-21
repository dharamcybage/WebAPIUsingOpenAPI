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
    public partial class WorkflowFormResponse : IEquatable<WorkflowFormResponse>
    {
        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [Required]
        [DataMember(Name="form", EmitDefaultValue=false)]
        public FormDTO Form { get; set; }

        /// <summary>
        /// Gets or Sets AdminNotificationUserIds
        /// </summary>
        [Required]
        [DataMember(Name="adminNotificationUserIds", EmitDefaultValue=false)]
        public List<long> AdminNotificationUserIds { get; set; }

        /// <summary>
        /// Gets or Sets SentAfter
        /// </summary>
        [DataMember(Name="sentAfter", EmitDefaultValue=true)]
        public long? SentAfter { get; set; }

        /// <summary>
        /// Gets or Sets AllPotentialSigners
        /// </summary>
        [Required]
        [DataMember(Name="allPotentialSigners", EmitDefaultValue=false)]
        public List<UserWorkflowStatusPotentialSignerDetails> AllPotentialSigners { get; set; }

        /// <summary>
        /// Gets or Sets Signers
        /// </summary>
        [Required]
        [DataMember(Name="signers", EmitDefaultValue=false)]
        public List<Object> Signers { get; set; }

        /// <summary>
        /// Gets or Sets UserWorkflowStatus
        /// </summary>
        [Required]
        [DataMember(Name="userWorkflowStatus", EmitDefaultValue=false)]
        public UserWorkflowStatusDTO UserWorkflowStatus { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowForm
        /// </summary>
        [Required]
        [DataMember(Name="workflowForm", EmitDefaultValue=false)]
        public Object WorkflowForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowFormResponse {\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  AdminNotificationUserIds: ").Append(AdminNotificationUserIds).Append("\n");
            sb.Append("  SentAfter: ").Append(SentAfter).Append("\n");
            sb.Append("  AllPotentialSigners: ").Append(AllPotentialSigners).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  UserWorkflowStatus: ").Append(UserWorkflowStatus).Append("\n");
            sb.Append("  WorkflowForm: ").Append(WorkflowForm).Append("\n");
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
            return obj.GetType() == GetType() && Equals((WorkflowFormResponse)obj);
        }

        /// <summary>
        /// Returns true if WorkflowFormResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowFormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowFormResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Form == other.Form ||
                    Form != null &&
                    Form.Equals(other.Form)
                ) && 
                (
                    AdminNotificationUserIds == other.AdminNotificationUserIds ||
                    AdminNotificationUserIds != null &&
                    other.AdminNotificationUserIds != null &&
                    AdminNotificationUserIds.SequenceEqual(other.AdminNotificationUserIds)
                ) && 
                (
                    SentAfter == other.SentAfter ||
                    SentAfter != null &&
                    SentAfter.Equals(other.SentAfter)
                ) && 
                (
                    AllPotentialSigners == other.AllPotentialSigners ||
                    AllPotentialSigners != null &&
                    other.AllPotentialSigners != null &&
                    AllPotentialSigners.SequenceEqual(other.AllPotentialSigners)
                ) && 
                (
                    Signers == other.Signers ||
                    Signers != null &&
                    other.Signers != null &&
                    Signers.SequenceEqual(other.Signers)
                ) && 
                (
                    UserWorkflowStatus == other.UserWorkflowStatus ||
                    UserWorkflowStatus != null &&
                    UserWorkflowStatus.Equals(other.UserWorkflowStatus)
                ) && 
                (
                    WorkflowForm == other.WorkflowForm ||
                    WorkflowForm != null &&
                    WorkflowForm.Equals(other.WorkflowForm)
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
                    if (Form != null)
                    hashCode = hashCode * 59 + Form.GetHashCode();
                    if (AdminNotificationUserIds != null)
                    hashCode = hashCode * 59 + AdminNotificationUserIds.GetHashCode();
                    if (SentAfter != null)
                    hashCode = hashCode * 59 + SentAfter.GetHashCode();
                    if (AllPotentialSigners != null)
                    hashCode = hashCode * 59 + AllPotentialSigners.GetHashCode();
                    if (Signers != null)
                    hashCode = hashCode * 59 + Signers.GetHashCode();
                    if (UserWorkflowStatus != null)
                    hashCode = hashCode * 59 + UserWorkflowStatus.GetHashCode();
                    if (WorkflowForm != null)
                    hashCode = hashCode * 59 + WorkflowForm.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WorkflowFormResponse left, WorkflowFormResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WorkflowFormResponse left, WorkflowFormResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
