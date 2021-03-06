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
    /// Oauth2Parameters
    /// </summary>
    [DataContract]
    public partial class Oauth2Parameters : IEquatable<Oauth2Parameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oauth2Parameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Oauth2Parameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Oauth2Parameters" /> class.
        /// </summary>
        /// <param name="ResponseParams">ResponseParams (required).</param>
        public Oauth2Parameters(string ResponseParams = default(string))
        {
            // to ensure "ResponseParams" is required (not null)
            if (ResponseParams == null)
            {
                throw new InvalidDataException("ResponseParams is a required property for Oauth2Parameters and cannot be null");
            }
            else
            {
                this.ResponseParams = ResponseParams;
            }
        }

        /// <summary>
        /// Gets or Sets ResponseParams
        /// </summary>
        [DataMember(Name = "responseParams", EmitDefaultValue = false)]
        public string ResponseParams { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Oauth2Parameters {\n");
            sb.Append("  ResponseParams: ").Append(ResponseParams).Append("\n");
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
            return this.Equals(obj as Oauth2Parameters);
        }

        /// <summary>
        /// Returns true if Oauth2Parameters instances are equal
        /// </summary>
        /// <param name="other">Instance of Oauth2Parameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Oauth2Parameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.ResponseParams == other.ResponseParams ||
                    this.ResponseParams != null &&
                    this.ResponseParams.Equals(other.ResponseParams)
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
                if (this.ResponseParams != null)
                    hash = hash * 59 + this.ResponseParams.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
