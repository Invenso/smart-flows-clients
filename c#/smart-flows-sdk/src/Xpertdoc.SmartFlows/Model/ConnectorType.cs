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
    /// ConnectorType
    /// </summary>
    [DataContract]
    public partial class ConnectorType : IEquatable<ConnectorType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorType" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="JavaType">JavaType.</param>
        /// <param name="ReadSchema">ReadSchema.</param>
        /// <param name="WriteSchema">WriteSchema.</param>
        /// <param name="ResourceFetch">ResourceFetch.</param>
        public ConnectorType(string Id = default(string), string DisplayName = default(string), string Description = default(string), string JavaType = default(string), Object ReadSchema = default(Object), Object WriteSchema = default(Object), ConnectorTypeResourceFetch ResourceFetch = default(ConnectorTypeResourceFetch))
        {
            // to ensure "DisplayName" is required (not null)
            if (DisplayName == null)
            {
                throw new InvalidDataException("DisplayName is a required property for ConnectorType and cannot be null");
            }
            else
            {
                this.DisplayName = DisplayName;
            }
            this.Id = Id;
            this.Description = Description;
            this.JavaType = JavaType;
            this.ReadSchema = ReadSchema;
            this.WriteSchema = WriteSchema;
            this.ResourceFetch = ResourceFetch;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets JavaType
        /// </summary>
        [DataMember(Name = "javaType", EmitDefaultValue = false)]
        public string JavaType { get; set; }

        /// <summary>
        /// Gets or Sets ReadSchema
        /// </summary>
        [DataMember(Name = "readSchema", EmitDefaultValue = false)]
        public Object ReadSchema { get; set; }

        /// <summary>
        /// Gets or Sets WriteSchema
        /// </summary>
        [DataMember(Name = "writeSchema", EmitDefaultValue = false)]
        public Object WriteSchema { get; set; }

        /// <summary>
        /// Gets or Sets ResourceFetch
        /// </summary>
        [DataMember(Name = "resourceFetch", EmitDefaultValue = false)]
        public ConnectorTypeResourceFetch ResourceFetch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  JavaType: ").Append(JavaType).Append("\n");
            sb.Append("  ReadSchema: ").Append(ReadSchema).Append("\n");
            sb.Append("  WriteSchema: ").Append(WriteSchema).Append("\n");
            sb.Append("  ResourceFetch: ").Append(ResourceFetch).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectorType);
        }

        /// <summary>
        /// Returns true if ConnectorType instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) &&
                (
                    this.JavaType == input.JavaType ||
                    (this.JavaType != null &&
                    this.JavaType.Equals(input.JavaType))
                ) &&
                (
                    this.ReadSchema == input.ReadSchema ||
                    (this.ReadSchema != null &&
                    this.ReadSchema.Equals(input.ReadSchema))
                ) &&
                (
                    this.WriteSchema == input.WriteSchema ||
                    (this.WriteSchema != null &&
                    this.WriteSchema.Equals(input.WriteSchema))
                ) &&
                (
                    this.ResourceFetch == input.ResourceFetch ||
                    (this.ResourceFetch != null &&
                    this.ResourceFetch.Equals(input.ResourceFetch))
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
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.JavaType != null)
                    hashCode = hashCode * 59 + this.JavaType.GetHashCode();
                if (this.ReadSchema != null)
                    hashCode = hashCode * 59 + this.ReadSchema.GetHashCode();
                if (this.WriteSchema != null)
                    hashCode = hashCode * 59 + this.WriteSchema.GetHashCode();
                if (this.ResourceFetch != null)
                    hashCode = hashCode * 59 + this.ResourceFetch.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DisplayName (string) maxLength
            if (this.DisplayName != null && this.DisplayName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be less than 255.", new[] { "DisplayName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2048.", new[] { "Description" });
            }

            yield break;
        }
    }

}
