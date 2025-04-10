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
    public partial class CreateGoalPlanRequest : IEquatable<CreateGoalPlanRequest>
    {
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [Required]
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public string Plan { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ServiceCustomGoalId
        /// </summary>
        [Required]
        [DataMember(Name="service_custom_goal_id", EmitDefaultValue=true)]
        public long ServiceCustomGoalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGoalPlanRequest {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServiceCustomGoalId: ").Append(ServiceCustomGoalId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateGoalPlanRequest)obj);
        }

        /// <summary>
        /// Returns true if CreateGoalPlanRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateGoalPlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGoalPlanRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Plan == other.Plan ||
                    Plan != null &&
                    Plan.Equals(other.Plan)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ServiceCustomGoalId == other.ServiceCustomGoalId ||
                    
                    ServiceCustomGoalId.Equals(other.ServiceCustomGoalId)
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
                    if (Plan != null)
                    hashCode = hashCode * 59 + Plan.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + ServiceCustomGoalId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateGoalPlanRequest left, CreateGoalPlanRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateGoalPlanRequest left, CreateGoalPlanRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
