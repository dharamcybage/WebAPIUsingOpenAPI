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
    public partial class SuperUserInformationResponseSchool : IEquatable<SuperUserInformationResponseSchool>
    {
        /// <summary>
        /// Gets or Sets InternalCode
        /// </summary>
        [Required]
        [DataMember(Name="internalCode", EmitDefaultValue=false)]
        public string InternalCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NcesId
        /// </summary>
        [Required]
        [DataMember(Name="ncesId", EmitDefaultValue=false)]
        public string NcesId { get; set; }

        /// <summary>
        /// Gets or Sets OneRosterId
        /// </summary>
        [DataMember(Name="oneRosterId", EmitDefaultValue=true)]
        public string OneRosterId { get; set; }

        /// <summary>
        /// Gets or Sets Teachers
        /// </summary>
        [Required]
        [DataMember(Name="teachers", EmitDefaultValue=true)]
        public long Teachers { get; set; }

        /// <summary>
        /// Gets or Sets SsoId
        /// </summary>
        [DataMember(Name="ssoId", EmitDefaultValue=true)]
        public string SsoId { get; set; }

        /// <summary>
        /// Gets or Sets Administrators
        /// </summary>
        [Required]
        [DataMember(Name="administrators", EmitDefaultValue=true)]
        public long Administrators { get; set; }

        /// <summary>
        /// Gets or Sets Students
        /// </summary>
        [Required]
        [DataMember(Name="students", EmitDefaultValue=true)]
        public long Students { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperUserInformationResponseSchool {\n");
            sb.Append("  InternalCode: ").Append(InternalCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NcesId: ").Append(NcesId).Append("\n");
            sb.Append("  OneRosterId: ").Append(OneRosterId).Append("\n");
            sb.Append("  Teachers: ").Append(Teachers).Append("\n");
            sb.Append("  SsoId: ").Append(SsoId).Append("\n");
            sb.Append("  Administrators: ").Append(Administrators).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SuperUserInformationResponseSchool)obj);
        }

        /// <summary>
        /// Returns true if SuperUserInformationResponseSchool instances are equal
        /// </summary>
        /// <param name="other">Instance of SuperUserInformationResponseSchool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperUserInformationResponseSchool other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InternalCode == other.InternalCode ||
                    InternalCode != null &&
                    InternalCode.Equals(other.InternalCode)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    NcesId == other.NcesId ||
                    NcesId != null &&
                    NcesId.Equals(other.NcesId)
                ) && 
                (
                    OneRosterId == other.OneRosterId ||
                    OneRosterId != null &&
                    OneRosterId.Equals(other.OneRosterId)
                ) && 
                (
                    Teachers == other.Teachers ||
                    
                    Teachers.Equals(other.Teachers)
                ) && 
                (
                    SsoId == other.SsoId ||
                    SsoId != null &&
                    SsoId.Equals(other.SsoId)
                ) && 
                (
                    Administrators == other.Administrators ||
                    
                    Administrators.Equals(other.Administrators)
                ) && 
                (
                    Students == other.Students ||
                    
                    Students.Equals(other.Students)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
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
                    if (InternalCode != null)
                    hashCode = hashCode * 59 + InternalCode.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (NcesId != null)
                    hashCode = hashCode * 59 + NcesId.GetHashCode();
                    if (OneRosterId != null)
                    hashCode = hashCode * 59 + OneRosterId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Teachers.GetHashCode();
                    if (SsoId != null)
                    hashCode = hashCode * 59 + SsoId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Administrators.GetHashCode();
                    
                    hashCode = hashCode * 59 + Students.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SuperUserInformationResponseSchool left, SuperUserInformationResponseSchool right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SuperUserInformationResponseSchool left, SuperUserInformationResponseSchool right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
