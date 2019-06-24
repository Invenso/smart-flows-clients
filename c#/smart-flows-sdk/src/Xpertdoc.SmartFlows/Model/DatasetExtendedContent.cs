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
    /// DatasetExtendedContent
    /// </summary>
    [DataContract]
    public partial class DatasetExtendedContent : IEquatable<DatasetExtendedContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExtendedContent" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Root">Root.</param>
        /// <param name="Datasets">Datasets.</param>
        /// <param name="Relations">Relations.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="Views">Views.</param>
        public DatasetExtendedContent(string Name = default(string), string Root = default(string), List<DatasetExtendedContentDatasets> Datasets = default(List<DatasetExtendedContentDatasets>), List<DatasetExtendedContentRelations> Relations = default(List<DatasetExtendedContentRelations>), List<DatasetExtendedContentFields> Fields = default(List<DatasetExtendedContentFields>), List<DatasetExtendedContentViews> Views = default(List<DatasetExtendedContentViews>))
        {
            this.Name = Name;
            this.Root = Root;
            this.Datasets = Datasets;
            this.Relations = Relations;
            this.Fields = Fields;
            this.Views = Views;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public string Root { get; set; }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name = "datasets", EmitDefaultValue = false)]
        public List<DatasetExtendedContentDatasets> Datasets { get; set; }

        /// <summary>
        /// Gets or Sets Relations
        /// </summary>
        [DataMember(Name = "relations", EmitDefaultValue = false)]
        public List<DatasetExtendedContentRelations> Relations { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<DatasetExtendedContentFields> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public List<DatasetExtendedContentViews> Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetExtendedContent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
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
            return this.Equals(input as DatasetExtendedContent);
        }

        /// <summary>
        /// Returns true if DatasetExtendedContent instances are equal
        /// </summary>
        /// <param name="input">Instance of DatasetExtendedContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetExtendedContent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.Root == input.Root ||
                    (this.Root != null &&
                    this.Root.Equals(input.Root))
                ) &&
                (
                    this.Datasets == input.Datasets ||
                    this.Datasets != null &&
                    this.Datasets.SequenceEqual(input.Datasets)
                ) &&
                (
                    this.Relations == input.Relations ||
                    this.Relations != null &&
                    this.Relations.SequenceEqual(input.Relations)
                ) &&
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) &&
                (
                    this.Views == input.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(input.Views)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Root != null)
                    hashCode = hashCode * 59 + this.Root.GetHashCode();
                if (this.Datasets != null)
                    hashCode = hashCode * 59 + this.Datasets.GetHashCode();
                if (this.Relations != null)
                    hashCode = hashCode * 59 + this.Relations.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
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
            yield break;
        }
    }

}
