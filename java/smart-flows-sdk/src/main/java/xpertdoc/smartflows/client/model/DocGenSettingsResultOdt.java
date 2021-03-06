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
 * DocGenSettingsResultOdt
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettingsResultOdt {
  /**
   * Either ODT or OTT
   */
  @JsonAdapter(FormatEnum.Adapter.class)
  public enum FormatEnum {
    ODT("odt"),
    
    OTT("ott");

    private String value;

    FormatEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static FormatEnum fromValue(String text) {
      for (FormatEnum b : FormatEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<FormatEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final FormatEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public FormatEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return FormatEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("format")
  private FormatEnum format = FormatEnum.ODT;

  @SerializedName("isStrictSchema11")
  private Boolean isStrictSchema11 = false;

  public DocGenSettingsResultOdt format(FormatEnum format) {
    this.format = format;
    return this;
  }

   /**
   * Either ODT or OTT
   * @return format
  **/
  @ApiModelProperty(value = "Either ODT or OTT")
  public FormatEnum getFormat() {
    return format;
  }

  public void setFormat(FormatEnum format) {
    this.format = format;
  }

  public DocGenSettingsResultOdt isStrictSchema11(Boolean isStrictSchema11) {
    this.isStrictSchema11 = isStrictSchema11;
    return this;
  }

   /**
   * Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use false for this purpose, or true for strict conformity of specification 1.1
   * @return isStrictSchema11
  **/
  @ApiModelProperty(value = "Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use false for this purpose, or true for strict conformity of specification 1.1")
  public Boolean isIsStrictSchema11() {
    return isStrictSchema11;
  }

  public void setIsStrictSchema11(Boolean isStrictSchema11) {
    this.isStrictSchema11 = isStrictSchema11;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettingsResultOdt docGenSettingsResultOdt = (DocGenSettingsResultOdt) o;
    return Objects.equals(this.format, docGenSettingsResultOdt.format) &&
        Objects.equals(this.isStrictSchema11, docGenSettingsResultOdt.isStrictSchema11);
  }

  @Override
  public int hashCode() {
    return Objects.hash(format, isStrictSchema11);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettingsResultOdt {\n");
    
    sb.append("    format: ").append(toIndentedString(format)).append("\n");
    sb.append("    isStrictSchema11: ").append(toIndentedString(isStrictSchema11)).append("\n");
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

