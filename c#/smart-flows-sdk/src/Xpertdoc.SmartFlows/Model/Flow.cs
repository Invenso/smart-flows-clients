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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Flow
    /// </summary>
    [DataContract]
    public partial class Flow : IEquatable<Flow>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Simple for value: simple
            /// </summary>
            [EnumMember(Value = "simple")]
            Simple = 1,

            /// <summary>
            /// Enum Advanced for value: advanced
            /// </summary>
            [EnumMember(Value = "advanced")]
            Advanced = 2
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Flow" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="ModifiedAt">ModifiedAt.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="TagGroups">TagGroups.</param>
        /// <param name="Type">Type (default to TypeEnum.Advanced).</param>
        /// <param name="Body">Body.</param>
        /// <param name="Input">Input.</param>
        /// <param name="PrimaryEntity">PrimaryEntity.</param>
        /// <param name="PrimaryTemplate">PrimaryTemplate.</param>
        /// <param name="Settings">Settings.</param>
        public Flow(string Id = default(string), string DisplayName = default(string), string Description = default(string), string CreatedAt = default(string), IdWithName CreatedBy = default(IdWithName), string ModifiedAt = default(string), IdWithName ModifiedBy = default(IdWithName), List<TagGroupRef> TagGroups = default(List<TagGroupRef>), TypeEnum? Type = TypeEnum.Advanced, FlowBody Body = default(FlowBody), FlowInput Input = default(FlowInput), string PrimaryEntity = default(string), IdWithName PrimaryTemplate = default(IdWithName), FlowSettings Settings = default(FlowSettings))
        {
            this.Id = Id;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.CreatedAt = CreatedAt;
            this.CreatedBy = CreatedBy;
            this.ModifiedAt = ModifiedAt;
            this.ModifiedBy = ModifiedBy;
            this.TagGroups = TagGroups;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.Advanced;
            }
            else
            {
                this.Type = Type;
            }
            this.Body = Body;
            this.Input = Input;
            this.PrimaryEntity = PrimaryEntity;
            this.PrimaryTemplate = PrimaryTemplate;
            this.Settings = Settings;
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
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public IdWithName CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name = "modifiedAt", EmitDefaultValue = false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public IdWithName ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets TagGroups
        /// </summary>
        [DataMember(Name = "tagGroups", EmitDefaultValue = false)]
        public List<TagGroupRef> TagGroups { get; set; }


        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public FlowBody Body { get; set; }

        /// <summary>
        /// Gets or Sets Input
        /// </summary>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public FlowInput Input { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryEntity
        /// </summary>
        [DataMember(Name = "primaryEntity", EmitDefaultValue = false)]
        public string PrimaryEntity { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryTemplate
        /// </summary>
        [DataMember(Name = "primaryTemplate", EmitDefaultValue = false)]
        public IdWithName PrimaryTemplate { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public FlowSettings Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flow {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  TagGroups: ").Append(TagGroups).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  PrimaryEntity: ").Append(PrimaryEntity).Append("\n");
            sb.Append("  PrimaryTemplate: ").Append(PrimaryTemplate).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as Flow);
        }

        /// <summary>
        /// Returns true if Flow instances are equal
        /// </summary>
        /// <param name="input">Instance of Flow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Flow input)
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) &&
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) &&
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) &&
                (
                    this.TagGroups == input.TagGroups ||
                    this.TagGroups != null &&
                    this.TagGroups.SequenceEqual(input.TagGroups)
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) &&
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) &&
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) &&
                (
                    this.PrimaryEntity == input.PrimaryEntity ||
                    (this.PrimaryEntity != null &&
                    this.PrimaryEntity.Equals(input.PrimaryEntity))
                ) &&
                (
                    this.PrimaryTemplate == input.PrimaryTemplate ||
                    (this.PrimaryTemplate != null &&
                    this.PrimaryTemplate.Equals(input.PrimaryTemplate))
                ) &&
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.TagGroups != null)
                    hashCode = hashCode * 59 + this.TagGroups.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.PrimaryEntity != null)
                    hashCode = hashCode * 59 + this.PrimaryEntity.GetHashCode();
                if (this.PrimaryTemplate != null)
                    hashCode = hashCode * 59 + this.PrimaryTemplate.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
