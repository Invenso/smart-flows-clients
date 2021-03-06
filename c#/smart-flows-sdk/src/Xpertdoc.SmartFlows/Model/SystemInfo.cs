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
    /// SystemInfo
    /// </summary>
    [DataContract]
    public partial class SystemInfo : IEquatable<SystemInfo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {

            /// <summary>
            /// Enum Sandbox for "sandbox"
            /// </summary>
            [EnumMember(Value = "sandbox")]
            Sandbox,

            /// <summary>
            /// Enum Development for "development"
            /// </summary>
            [EnumMember(Value = "development")]
            Development,

            /// <summary>
            /// Enum Testing for "testing"
            /// </summary>
            [EnumMember(Value = "testing")]
            Testing,

            /// <summary>
            /// Enum Production for "production"
            /// </summary>
            [EnumMember(Value = "production")]
            Production
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public RoleEnum? Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfo" /> class.
        /// </summary>
        /// <param name="Version">Version.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="ProjectId">ProjectId.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Defaults">Defaults.</param>
        /// <param name="RssFeed">RssFeed.</param>
        /// <param name="SupportUrl">SupportUrl.</param>
        /// <param name="AssetsUrl">AssetsUrl.</param>
        public SystemInfo(string Version = default(string), string DisplayName = default(string), string ProjectId = default(string), string Description = default(string), RoleEnum? Role = default(RoleEnum?), SystemInfoDefaults Defaults = default(SystemInfoDefaults), string RssFeed = default(string), string SupportUrl = default(string), string AssetsUrl = default(string))
        {
            this.Version = Version;
            this.DisplayName = DisplayName;
            this.ProjectId = ProjectId;
            this.Description = Description;
            this.Role = Role;
            this.Defaults = Defaults;
            this.RssFeed = RssFeed;
            this.SupportUrl = SupportUrl;
            this.AssetsUrl = AssetsUrl;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public string ProjectId { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Defaults
        /// </summary>
        [DataMember(Name = "defaults", EmitDefaultValue = false)]
        public SystemInfoDefaults Defaults { get; set; }
        /// <summary>
        /// Gets or Sets RssFeed
        /// </summary>
        [DataMember(Name = "rssFeed", EmitDefaultValue = false)]
        public string RssFeed { get; set; }
        /// <summary>
        /// Gets or Sets SupportUrl
        /// </summary>
        [DataMember(Name = "supportUrl", EmitDefaultValue = false)]
        public string SupportUrl { get; set; }
        /// <summary>
        /// Gets or Sets AssetsUrl
        /// </summary>
        [DataMember(Name = "assetsUrl", EmitDefaultValue = false)]
        public string AssetsUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfo {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Defaults: ").Append(Defaults).Append("\n");
            sb.Append("  RssFeed: ").Append(RssFeed).Append("\n");
            sb.Append("  SupportUrl: ").Append(SupportUrl).Append("\n");
            sb.Append("  AssetsUrl: ").Append(AssetsUrl).Append("\n");
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
            return this.Equals(obj as SystemInfo);
        }

        /// <summary>
        /// Returns true if SystemInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SystemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.ProjectId == other.ProjectId ||
                    this.ProjectId != null &&
                    this.ProjectId.Equals(other.ProjectId)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) &&
                (
                    this.Defaults == other.Defaults ||
                    this.Defaults != null &&
                    this.Defaults.Equals(other.Defaults)
                ) &&
                (
                    this.RssFeed == other.RssFeed ||
                    this.RssFeed != null &&
                    this.RssFeed.Equals(other.RssFeed)
                ) &&
                (
                    this.SupportUrl == other.SupportUrl ||
                    this.SupportUrl != null &&
                    this.SupportUrl.Equals(other.SupportUrl)
                ) &&
                (
                    this.AssetsUrl == other.AssetsUrl ||
                    this.AssetsUrl != null &&
                    this.AssetsUrl.Equals(other.AssetsUrl)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.ProjectId != null)
                    hash = hash * 59 + this.ProjectId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Defaults != null)
                    hash = hash * 59 + this.Defaults.GetHashCode();
                if (this.RssFeed != null)
                    hash = hash * 59 + this.RssFeed.GetHashCode();
                if (this.SupportUrl != null)
                    hash = hash * 59 + this.SupportUrl.GetHashCode();
                if (this.AssetsUrl != null)
                    hash = hash * 59 + this.AssetsUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
