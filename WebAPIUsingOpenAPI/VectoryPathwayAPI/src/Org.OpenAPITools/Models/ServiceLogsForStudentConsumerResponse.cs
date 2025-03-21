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
    public partial class ServiceLogsForStudentConsumerResponse : IEquatable<ServiceLogsForStudentConsumerResponse>
    {
        /// <summary>
        /// Gets or Sets TotalHours
        /// </summary>
        [Required]
        [DataMember(Name="totalHours", EmitDefaultValue=true)]
        public double TotalHours { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeHours
        /// </summary>
        [Required]
        [DataMember(Name="lifetimeHours", EmitDefaultValue=true)]
        public double LifetimeHours { get; set; }

        /// <summary>
        /// Gets or Sets PendingLogs
        /// </summary>
        [Required]
        [DataMember(Name="pendingLogs", EmitDefaultValue=false)]
        public List<ServiceLogConsumerData> PendingLogs { get; set; }

        /// <summary>
        /// Gets or Sets NeedsRevisionLogs
        /// </summary>
        [Required]
        [DataMember(Name="needsRevisionLogs", EmitDefaultValue=false)]
        public List<ServiceLogConsumerData> NeedsRevisionLogs { get; set; }

        /// <summary>
        /// Gets or Sets QuickLogs
        /// </summary>
        [Required]
        [DataMember(Name="quickLogs", EmitDefaultValue=false)]
        public List<ServiceLogsForStudentConsumerResponseQuickLog> QuickLogs { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user", EmitDefaultValue=false)]
        public BasicUser User { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedLogs
        /// </summary>
        [Required]
        [DataMember(Name="approvedLogs", EmitDefaultValue=false)]
        public List<ServiceLogConsumerData> ApprovedLogs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLogsForStudentConsumerResponse {\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
            sb.Append("  LifetimeHours: ").Append(LifetimeHours).Append("\n");
            sb.Append("  PendingLogs: ").Append(PendingLogs).Append("\n");
            sb.Append("  NeedsRevisionLogs: ").Append(NeedsRevisionLogs).Append("\n");
            sb.Append("  QuickLogs: ").Append(QuickLogs).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ApprovedLogs: ").Append(ApprovedLogs).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServiceLogsForStudentConsumerResponse)obj);
        }

        /// <summary>
        /// Returns true if ServiceLogsForStudentConsumerResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceLogsForStudentConsumerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceLogsForStudentConsumerResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TotalHours == other.TotalHours ||
                    
                    TotalHours.Equals(other.TotalHours)
                ) && 
                (
                    LifetimeHours == other.LifetimeHours ||
                    
                    LifetimeHours.Equals(other.LifetimeHours)
                ) && 
                (
                    PendingLogs == other.PendingLogs ||
                    PendingLogs != null &&
                    other.PendingLogs != null &&
                    PendingLogs.SequenceEqual(other.PendingLogs)
                ) && 
                (
                    NeedsRevisionLogs == other.NeedsRevisionLogs ||
                    NeedsRevisionLogs != null &&
                    other.NeedsRevisionLogs != null &&
                    NeedsRevisionLogs.SequenceEqual(other.NeedsRevisionLogs)
                ) && 
                (
                    QuickLogs == other.QuickLogs ||
                    QuickLogs != null &&
                    other.QuickLogs != null &&
                    QuickLogs.SequenceEqual(other.QuickLogs)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    ApprovedLogs == other.ApprovedLogs ||
                    ApprovedLogs != null &&
                    other.ApprovedLogs != null &&
                    ApprovedLogs.SequenceEqual(other.ApprovedLogs)
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
                    
                    hashCode = hashCode * 59 + TotalHours.GetHashCode();
                    
                    hashCode = hashCode * 59 + LifetimeHours.GetHashCode();
                    if (PendingLogs != null)
                    hashCode = hashCode * 59 + PendingLogs.GetHashCode();
                    if (NeedsRevisionLogs != null)
                    hashCode = hashCode * 59 + NeedsRevisionLogs.GetHashCode();
                    if (QuickLogs != null)
                    hashCode = hashCode * 59 + QuickLogs.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (ApprovedLogs != null)
                    hashCode = hashCode * 59 + ApprovedLogs.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServiceLogsForStudentConsumerResponse left, ServiceLogsForStudentConsumerResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServiceLogsForStudentConsumerResponse left, ServiceLogsForStudentConsumerResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
