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
    public partial class OnetResponseQuestion : IEquatable<OnetResponseQuestion>
    {
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [Required]
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [Required]
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [Required]
        [DataMember(Name="index", EmitDefaultValue=true)]
        public long Index { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnetResponseQuestion {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OnetResponseQuestion)obj);
        }

        /// <summary>
        /// Returns true if OnetResponseQuestion instances are equal
        /// </summary>
        /// <param name="other">Instance of OnetResponseQuestion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnetResponseQuestion other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Area == other.Area ||
                    Area != null &&
                    Area.Equals(other.Area)
                ) && 
                (
                    Index == other.Index ||
                    
                    Index.Equals(other.Index)
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
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Area != null)
                    hashCode = hashCode * 59 + Area.GetHashCode();
                    
                    hashCode = hashCode * 59 + Index.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OnetResponseQuestion left, OnetResponseQuestion right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OnetResponseQuestion left, OnetResponseQuestion right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
