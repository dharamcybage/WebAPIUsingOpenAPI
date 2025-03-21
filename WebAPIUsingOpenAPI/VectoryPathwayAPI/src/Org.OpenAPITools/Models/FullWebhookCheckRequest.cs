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
    public partial class FullWebhookCheckRequest : IEquatable<FullWebhookCheckRequest>
    {
        /// <summary>
        /// Gets or Sets WorkerUuid
        /// </summary>
        [DataMember(Name="worker_uuid", EmitDefaultValue=true)]
        public string WorkerUuid { get; set; }

        /// <summary>
        /// Gets or Sets WorkerId
        /// </summary>
        [DataMember(Name="worker_id", EmitDefaultValue=true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Gets or Sets Checks
        /// </summary>
        [Required]
        [DataMember(Name="checks", EmitDefaultValue=false)]
        public FullWebhookCheckRequestChecks Checks { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUuid
        /// </summary>
        [Required]
        [DataMember(Name="callback_uuid", EmitDefaultValue=false)]
        public string CallbackUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullWebhookCheckRequest {\n");
            sb.Append("  WorkerUuid: ").Append(WorkerUuid).Append("\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  CallbackUuid: ").Append(CallbackUuid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FullWebhookCheckRequest)obj);
        }

        /// <summary>
        /// Returns true if FullWebhookCheckRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FullWebhookCheckRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullWebhookCheckRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    WorkerUuid == other.WorkerUuid ||
                    WorkerUuid != null &&
                    WorkerUuid.Equals(other.WorkerUuid)
                ) && 
                (
                    WorkerId == other.WorkerId ||
                    WorkerId != null &&
                    WorkerId.Equals(other.WorkerId)
                ) && 
                (
                    Checks == other.Checks ||
                    Checks != null &&
                    Checks.Equals(other.Checks)
                ) && 
                (
                    CallbackUuid == other.CallbackUuid ||
                    CallbackUuid != null &&
                    CallbackUuid.Equals(other.CallbackUuid)
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
                    if (WorkerUuid != null)
                    hashCode = hashCode * 59 + WorkerUuid.GetHashCode();
                    if (WorkerId != null)
                    hashCode = hashCode * 59 + WorkerId.GetHashCode();
                    if (Checks != null)
                    hashCode = hashCode * 59 + Checks.GetHashCode();
                    if (CallbackUuid != null)
                    hashCode = hashCode * 59 + CallbackUuid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FullWebhookCheckRequest left, FullWebhookCheckRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FullWebhookCheckRequest left, FullWebhookCheckRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
