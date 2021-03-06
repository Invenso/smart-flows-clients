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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Authentication
    /// </summary>
    [DataContract]
    public partial class Authentication : IEquatable<Authentication>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Authentication" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Tokens">Tokens.</param>
        public Authentication(User User = default(User), List<AuthenticationTokens> Tokens = default(List<AuthenticationTokens>))
        {
            this.User = User;
            this.Tokens = Tokens;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public User User { get; set; }
        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name = "tokens", EmitDefaultValue = false)]
        public List<AuthenticationTokens> Tokens { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Authentication {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
            return this.Equals(obj as Authentication);
        }

        /// <summary>
        /// Returns true if Authentication instances are equal
        /// </summary>
        /// <param name="other">Instance of Authentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Authentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Tokens == other.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(other.Tokens)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Tokens != null)
                    hash = hash * 59 + this.Tokens.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
