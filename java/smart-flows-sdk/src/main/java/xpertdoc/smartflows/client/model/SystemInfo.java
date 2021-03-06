/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModelProperty;

import java.io.IOException;
import java.util.Objects;

/**
 * SystemInfo
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class SystemInfo {
  @SerializedName("version")
  private String version = null;

  @SerializedName("displayName")
  private String displayName = null;

  @SerializedName("description")
  private String description = null;

  /**
   * Gets or Sets role
   */
  @JsonAdapter(RoleEnum.Adapter.class)
  public enum RoleEnum {
    SANDBOX("sandbox"),
    
    DEVELOPMENT("development"),
    
    TESTING("testing"),
    
    PRODUCTION("production");

    private String value;

    RoleEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static RoleEnum fromValue(String text) {
      for (RoleEnum b : RoleEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<RoleEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final RoleEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public RoleEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return RoleEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("role")
  private RoleEnum role = null;

  @SerializedName("defaults")
  private SystemInfoDefaults defaults = null;

  @SerializedName("rssFeed")
  private String rssFeed = null;

  @SerializedName("supportUrl")
  private String supportUrl = null;

  @SerializedName("assetsUrl")
  private String assetsUrl = null;

  public SystemInfo version(String version) {
    this.version = version;
    return this;
  }

   /**
   * Get version
   * @return version
  **/
  @ApiModelProperty(value = "")
  public String getVersion() {
    return version;
  }

  public void setVersion(String version) {
    this.version = version;
  }

  public SystemInfo displayName(String displayName) {
    this.displayName = displayName;
    return this;
  }

   /**
   * Get displayName
   * @return displayName
  **/
  @ApiModelProperty(value = "")
  public String getDisplayName() {
    return displayName;
  }

  public void setDisplayName(String displayName) {
    this.displayName = displayName;
  }

  public SystemInfo description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public SystemInfo role(RoleEnum role) {
    this.role = role;
    return this;
  }

   /**
   * Get role
   * @return role
  **/
  @ApiModelProperty(value = "")
  public RoleEnum getRole() {
    return role;
  }

  public void setRole(RoleEnum role) {
    this.role = role;
  }

  public SystemInfo defaults(SystemInfoDefaults defaults) {
    this.defaults = defaults;
    return this;
  }

   /**
   * Get defaults
   * @return defaults
  **/
  @ApiModelProperty(value = "")
  public SystemInfoDefaults getDefaults() {
    return defaults;
  }

  public void setDefaults(SystemInfoDefaults defaults) {
    this.defaults = defaults;
  }

  public SystemInfo rssFeed(String rssFeed) {
    this.rssFeed = rssFeed;
    return this;
  }

   /**
   * Get rssFeed
   * @return rssFeed
  **/
  @ApiModelProperty(value = "")
  public String getRssFeed() {
    return rssFeed;
  }

  public void setRssFeed(String rssFeed) {
    this.rssFeed = rssFeed;
  }

  public SystemInfo supportUrl(String supportUrl) {
    this.supportUrl = supportUrl;
    return this;
  }

   /**
   * Get supportUrl
   * @return supportUrl
  **/
  @ApiModelProperty(value = "")
  public String getSupportUrl() {
    return supportUrl;
  }

  public void setSupportUrl(String supportUrl) {
    this.supportUrl = supportUrl;
  }

  public SystemInfo assetsUrl(String assetsUrl) {
    this.assetsUrl = assetsUrl;
    return this;
  }

   /**
   * Get assetsUrl
   * @return assetsUrl
  **/
  @ApiModelProperty(value = "")
  public String getAssetsUrl() {
    return assetsUrl;
  }

  public void setAssetsUrl(String assetsUrl) {
    this.assetsUrl = assetsUrl;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SystemInfo systemInfo = (SystemInfo) o;
    return Objects.equals(this.version, systemInfo.version) &&
        Objects.equals(this.displayName, systemInfo.displayName) &&
        Objects.equals(this.description, systemInfo.description) &&
        Objects.equals(this.role, systemInfo.role) &&
        Objects.equals(this.defaults, systemInfo.defaults) &&
        Objects.equals(this.rssFeed, systemInfo.rssFeed) &&
        Objects.equals(this.supportUrl, systemInfo.supportUrl) &&
        Objects.equals(this.assetsUrl, systemInfo.assetsUrl);
  }

  @Override
  public int hashCode() {
    return Objects.hash(version, displayName, description, role, defaults, rssFeed, supportUrl, assetsUrl);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SystemInfo {\n");
    
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("    displayName: ").append(toIndentedString(displayName)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    role: ").append(toIndentedString(role)).append("\n");
    sb.append("    defaults: ").append(toIndentedString(defaults)).append("\n");
    sb.append("    rssFeed: ").append(toIndentedString(rssFeed)).append("\n");
    sb.append("    supportUrl: ").append(toIndentedString(supportUrl)).append("\n");
    sb.append("    assetsUrl: ").append(toIndentedString(assetsUrl)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

