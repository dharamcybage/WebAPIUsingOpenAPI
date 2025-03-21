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
    public partial class AdvisoryBoardFormSubmissionsResponse : IEquatable<AdvisoryBoardFormSubmissionsResponse>
    {
        /// <summary>
        /// Gets or Sets Board
        /// </summary>
        [Required]
        [DataMember(Name="board", EmitDefaultValue=false)]
        public AdvisoryBoardDTO Board { get; set; }

        /// <summary>
        /// Gets or Sets Submissions
        /// </summary>
        [Required]
        [DataMember(Name="submissions", EmitDefaultValue=false)]
        public List<AdvisoryBoardFormSubmissionsResponseSubmission> Submissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvisoryBoardFormSubmissionsResponse {\n");
            sb.Append("  Board: ").Append(Board).Append("\n");
            sb.Append("  Submissions: ").Append(Submissions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AdvisoryBoardFormSubmissionsResponse)obj);
        }

        /// <summary>
        /// Returns true if AdvisoryBoardFormSubmissionsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AdvisoryBoardFormSubmissionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvisoryBoardFormSubmissionsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Board == other.Board ||
                    Board != null &&
                    Board.Equals(other.Board)
                ) && 
                (
                    Submissions == other.Submissions ||
                    Submissions != null &&
                    other.Submissions != null &&
                    Submissions.SequenceEqual(other.Submissions)
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
                    if (Board != null)
                    hashCode = hashCode * 59 + Board.GetHashCode();
                    if (Submissions != null)
                    hashCode = hashCode * 59 + Submissions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AdvisoryBoardFormSubmissionsResponse left, AdvisoryBoardFormSubmissionsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AdvisoryBoardFormSubmissionsResponse left, AdvisoryBoardFormSubmissionsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
