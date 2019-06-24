/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// AuthenticationInfoMethods
    /// </summary>
    [DataContract]
    public partial class AuthenticationInfoMethods : IEquatable<AuthenticationInfoMethods>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MethodType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodTypeEnum
        {

            /// <summary>
            /// Enum Password for "password"
            /// </summary>
            [EnumMember(Value = "password")]
            Password,

            /// <summary>
            /// Enum Oauth for "oauth"
            /// </summary>
            [EnumMember(Value = "oauth")]
            Oauth
        }

        /// <summary>
        /// Gets or Sets MethodType
        /// </summary>
        [DataMember(Name = "methodType", EmitDefaultValue = false)]
        public MethodTypeEnum? MethodType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationInfoMethods" /> class.
        /// </summary>
        /// <param name="MethodType">MethodType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        public AuthenticationInfoMethods(MethodTypeEnum? MethodType = default(MethodTypeEnum?), string Id = default(string), string DisplayName = default(string))
        {
            this.MethodType = MethodType;
            this.Id = Id;
            this.DisplayName = DisplayName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationInfoMethods {\n");
            sb.Append("  MethodType: ").Append(MethodType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AuthenticationInfoMethods);
        }

        /// <summary>
        /// Returns true if AuthenticationInfoMethods instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationInfoMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationInfoMethods other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.MethodType == other.MethodType ||
                    this.MethodType != null &&
                    this.MethodType.Equals(other.MethodType)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MethodType != null)
                    hash = hash * 59 + this.MethodType.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}