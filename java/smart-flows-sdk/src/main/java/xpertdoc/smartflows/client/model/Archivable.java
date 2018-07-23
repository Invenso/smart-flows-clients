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
import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * Archivable
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class Archivable {
  @SerializedName("identifier")
  private IdWithName identifier = null;

  /**
   * Gets or Sets archiveType
   */
  @JsonAdapter(ArchiveTypeEnum.Adapter.class)
  public enum ArchiveTypeEnum {
    EXPLICIT("explicit"),
    
    DEPENDENCY("dependency");

    private String value;

    ArchiveTypeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ArchiveTypeEnum fromValue(String text) {
      for (ArchiveTypeEnum b : ArchiveTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ArchiveTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ArchiveTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ArchiveTypeEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ArchiveTypeEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("archiveType")
  private ArchiveTypeEnum archiveType = null;

  @SerializedName("definition")
  private String definition = null;

  @SerializedName("checksum")
  private String checksum = null;

  @SerializedName("contents")
  private List<ArchivableContent> contents = null;

  @SerializedName("outboundDependencies")
  private List<DependencyTreeNode> outboundDependencies = null;

  public Archivable identifier(IdWithName identifier) {
    this.identifier = identifier;
    return this;
  }

   /**
   * Get identifier
   * @return identifier
  **/
  @ApiModelProperty(value = "")
  public IdWithName getIdentifier() {
    return identifier;
  }

  public void setIdentifier(IdWithName identifier) {
    this.identifier = identifier;
  }

  public Archivable archiveType(ArchiveTypeEnum archiveType) {
    this.archiveType = archiveType;
    return this;
  }

   /**
   * Get archiveType
   * @return archiveType
  **/
  @ApiModelProperty(value = "")
  public ArchiveTypeEnum getArchiveType() {
    return archiveType;
  }

  public void setArchiveType(ArchiveTypeEnum archiveType) {
    this.archiveType = archiveType;
  }

  public Archivable definition(String definition) {
    this.definition = definition;
    return this;
  }

   /**
   * Get definition
   * @return definition
  **/
  @ApiModelProperty(value = "")
  public String getDefinition() {
    return definition;
  }

  public void setDefinition(String definition) {
    this.definition = definition;
  }

  public Archivable checksum(String checksum) {
    this.checksum = checksum;
    return this;
  }

   /**
   * Get checksum
   * @return checksum
  **/
  @ApiModelProperty(value = "")
  public String getChecksum() {
    return checksum;
  }

  public void setChecksum(String checksum) {
    this.checksum = checksum;
  }

  public Archivable contents(List<ArchivableContent> contents) {
    this.contents = contents;
    return this;
  }

  public Archivable addContentsItem(ArchivableContent contentsItem) {
    if (this.contents == null) {
      this.contents = new ArrayList<ArchivableContent>();
    }
    this.contents.add(contentsItem);
    return this;
  }

   /**
   * Get contents
   * @return contents
  **/
  @ApiModelProperty(value = "")
  public List<ArchivableContent> getContents() {
    return contents;
  }

  public void setContents(List<ArchivableContent> contents) {
    this.contents = contents;
  }

  public Archivable outboundDependencies(List<DependencyTreeNode> outboundDependencies) {
    this.outboundDependencies = outboundDependencies;
    return this;
  }

  public Archivable addOutboundDependenciesItem(DependencyTreeNode outboundDependenciesItem) {
    if (this.outboundDependencies == null) {
      this.outboundDependencies = new ArrayList<DependencyTreeNode>();
    }
    this.outboundDependencies.add(outboundDependenciesItem);
    return this;
  }

   /**
   * Get outboundDependencies
   * @return outboundDependencies
  **/
  @ApiModelProperty(value = "")
  public List<DependencyTreeNode> getOutboundDependencies() {
    return outboundDependencies;
  }

  public void setOutboundDependencies(List<DependencyTreeNode> outboundDependencies) {
    this.outboundDependencies = outboundDependencies;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Archivable archivable = (Archivable) o;
    return Objects.equals(this.identifier, archivable.identifier) &&
        Objects.equals(this.archiveType, archivable.archiveType) &&
        Objects.equals(this.definition, archivable.definition) &&
        Objects.equals(this.checksum, archivable.checksum) &&
        Objects.equals(this.contents, archivable.contents) &&
        Objects.equals(this.outboundDependencies, archivable.outboundDependencies);
  }

  @Override
  public int hashCode() {
    return Objects.hash(identifier, archiveType, definition, checksum, contents, outboundDependencies);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Archivable {\n");
    
    sb.append("    identifier: ").append(toIndentedString(identifier)).append("\n");
    sb.append("    archiveType: ").append(toIndentedString(archiveType)).append("\n");
    sb.append("    definition: ").append(toIndentedString(definition)).append("\n");
    sb.append("    checksum: ").append(toIndentedString(checksum)).append("\n");
    sb.append("    contents: ").append(toIndentedString(contents)).append("\n");
    sb.append("    outboundDependencies: ").append(toIndentedString(outboundDependencies)).append("\n");
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
