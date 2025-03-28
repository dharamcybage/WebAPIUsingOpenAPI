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
    public partial class ServiceEventResponse : IEquatable<ServiceEventResponse>
    {
        /// <summary>
        /// Gets or Sets UserLogged
        /// </summary>
        [Required]
        [DataMember(Name="userLogged", EmitDefaultValue=true)]
        public bool UserLogged { get; set; }

        /// <summary>
        /// Gets or Sets HidePendingLogs
        /// </summary>
        [Required]
        [DataMember(Name="hidePendingLogs", EmitDefaultValue=true)]
        public bool HidePendingLogs { get; set; }

        /// <summary>
        /// Gets or Sets PendingLogs
        /// </summary>
        [DataMember(Name="pendingLogs", EmitDefaultValue=true)]
        public List<SimpleJSONServiceLog> PendingLogs { get; set; }

        /// <summary>
        /// Gets or Sets AllowedAmount
        /// </summary>
        [DataMember(Name="allowedAmount", EmitDefaultValue=true)]
        public long? AllowedAmount { get; set; }

        /// <summary>
        /// Gets or Sets UserSignedUp
        /// </summary>
        [DataMember(Name="userSignedUp", EmitDefaultValue=true)]
        public bool? UserSignedUp { get; set; }

        /// <summary>
        /// Gets or Sets RemainingSpots
        /// </summary>
        [DataMember(Name="remainingSpots", EmitDefaultValue=true)]
        public long? RemainingSpots { get; set; }

        /// <summary>
        /// Gets or Sets CanPrefill
        /// </summary>
        [Required]
        [DataMember(Name="canPrefill", EmitDefaultValue=true)]
        public bool CanPrefill { get; set; }

        /// <summary>
        /// Gets or Sets VarEvent
        /// </summary>
        [Required]
        [DataMember(Name="event", EmitDefaultValue=false)]
        public ServiceEventJSON VarEvent { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [Required]
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<TagDTO> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceEventResponse {\n");
            sb.Append("  UserLogged: ").Append(UserLogged).Append("\n");
            sb.Append("  HidePendingLogs: ").Append(HidePendingLogs).Append("\n");
            sb.Append("  PendingLogs: ").Append(PendingLogs).Append("\n");
            sb.Append("  AllowedAmount: ").Append(AllowedAmount).Append("\n");
            sb.Append("  UserSignedUp: ").Append(UserSignedUp).Append("\n");
            sb.Append("  RemainingSpots: ").Append(RemainingSpots).Append("\n");
            sb.Append("  CanPrefill: ").Append(CanPrefill).Append("\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServiceEventResponse)obj);
        }

        /// <summary>
        /// Returns true if ServiceEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceEventResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserLogged == other.UserLogged ||
                    
                    UserLogged.Equals(other.UserLogged)
                ) && 
                (
                    HidePendingLogs == other.HidePendingLogs ||
                    
                    HidePendingLogs.Equals(other.HidePendingLogs)
                ) && 
                (
                    PendingLogs == other.PendingLogs ||
                    PendingLogs != null &&
                    other.PendingLogs != null &&
                    PendingLogs.SequenceEqual(other.PendingLogs)
                ) && 
                (
                    AllowedAmount == other.AllowedAmount ||
                    AllowedAmount != null &&
                    AllowedAmount.Equals(other.AllowedAmount)
                ) && 
                (
                    UserSignedUp == other.UserSignedUp ||
                    UserSignedUp != null &&
                    UserSignedUp.Equals(other.UserSignedUp)
                ) && 
                (
                    RemainingSpots == other.RemainingSpots ||
                    RemainingSpots != null &&
                    RemainingSpots.Equals(other.RemainingSpots)
                ) && 
                (
                    CanPrefill == other.CanPrefill ||
                    
                    CanPrefill.Equals(other.CanPrefill)
                ) && 
                (
                    VarEvent == other.VarEvent ||
                    VarEvent != null &&
                    VarEvent.Equals(other.VarEvent)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
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
                    
                    hashCode = hashCode * 59 + UserLogged.GetHashCode();
                    
                    hashCode = hashCode * 59 + HidePendingLogs.GetHashCode();
                    if (PendingLogs != null)
                    hashCode = hashCode * 59 + PendingLogs.GetHashCode();
                    if (AllowedAmount != null)
                    hashCode = hashCode * 59 + AllowedAmount.GetHashCode();
                    if (UserSignedUp != null)
                    hashCode = hashCode * 59 + UserSignedUp.GetHashCode();
                    if (RemainingSpots != null)
                    hashCode = hashCode * 59 + RemainingSpots.GetHashCode();
                    
                    hashCode = hashCode * 59 + CanPrefill.GetHashCode();
                    if (VarEvent != null)
                    hashCode = hashCode * 59 + VarEvent.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServiceEventResponse left, ServiceEventResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServiceEventResponse left, ServiceEventResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
