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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// UserResetParameters
    /// </summary>
    [DataContract]
    public partial class UserResetParameters : IEquatable<UserResetParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResetParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserResetParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResetParameters" /> class.
        /// </summary>
        /// <param name="Username">Username (required).</param>
        /// <param name="Path">Path.</param>
        public UserResetParameters(string Username = default(string), string Path = default(string))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for UserResetParameters and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            this.Path = Path;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResetParameters {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return this.Equals(obj as UserResetParameters);
        }

        /// <summary>
        /// Returns true if UserResetParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResetParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResetParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
