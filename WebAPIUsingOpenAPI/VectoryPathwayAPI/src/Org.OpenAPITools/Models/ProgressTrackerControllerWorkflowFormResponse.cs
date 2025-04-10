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
    public partial class ProgressTrackerControllerWorkflowFormResponse : IEquatable<ProgressTrackerControllerWorkflowFormResponse>
    {
        /// <summary>
        /// Gets or Sets ExperienceId
        /// </summary>
        [Required]
        [DataMember(Name="experienceId", EmitDefaultValue=true)]
        public long ExperienceId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [Required]
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [Required]
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowFormName
        /// </summary>
        [Required]
        [DataMember(Name="workflowFormName", EmitDefaultValue=false)]
        public string WorkflowFormName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressTrackerControllerWorkflowFormResponse {\n");
            sb.Append("  ExperienceId: ").Append(ExperienceId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WorkflowFormName: ").Append(WorkflowFormName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProgressTrackerControllerWorkflowFormResponse)obj);
        }

        /// <summary>
        /// Returns true if ProgressTrackerControllerWorkflowFormResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgressTrackerControllerWorkflowFormResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressTrackerControllerWorkflowFormResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ExperienceId == other.ExperienceId ||
                    
                    ExperienceId.Equals(other.ExperienceId)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    WorkflowFormName == other.WorkflowFormName ||
                    WorkflowFormName != null &&
                    WorkflowFormName.Equals(other.WorkflowFormName)
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
                    
                    hashCode = hashCode * 59 + ExperienceId.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (WorkflowFormName != null)
                    hashCode = hashCode * 59 + WorkflowFormName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProgressTrackerControllerWorkflowFormResponse left, ProgressTrackerControllerWorkflowFormResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProgressTrackerControllerWorkflowFormResponse left, ProgressTrackerControllerWorkflowFormResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
