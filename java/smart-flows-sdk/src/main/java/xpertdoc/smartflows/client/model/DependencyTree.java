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

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * DependencyTree
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DependencyTree {
  @SerializedName("object")
  private IdWithName object = null;

  @SerializedName("inbound")
  private List<DependencyTreeNode> inbound = null;

  @SerializedName("outbound")
  private List<DependencyTreeNode> outbound = null;

  @SerializedName("users")
  private List<IdWithName> users = null;

  public DependencyTree object(IdWithName object) {
    this.object = object;
    return this;
  }

   /**
   * Get object
   * @return object
  **/
  @ApiModelProperty(value = "")
  public IdWithName getObject() {
    return object;
  }

  public void setObject(IdWithName object) {
    this.object = object;
  }

  public DependencyTree inbound(List<DependencyTreeNode> inbound) {
    this.inbound = inbound;
    return this;
  }

  public DependencyTree addInboundItem(DependencyTreeNode inboundItem) {
    if (this.inbound == null) {
      this.inbound = new ArrayList<DependencyTreeNode>();
    }
    this.inbound.add(inboundItem);
    return this;
  }

   /**
   * Get inbound
   * @return inbound
  **/
  @ApiModelProperty(value = "")
  public List<DependencyTreeNode> getInbound() {
    return inbound;
  }

  public void setInbound(List<DependencyTreeNode> inbound) {
    this.inbound = inbound;
  }

  public DependencyTree outbound(List<DependencyTreeNode> outbound) {
    this.outbound = outbound;
    return this;
  }

  public DependencyTree addOutboundItem(DependencyTreeNode outboundItem) {
    if (this.outbound == null) {
      this.outbound = new ArrayList<DependencyTreeNode>();
    }
    this.outbound.add(outboundItem);
    return this;
  }

   /**
   * Get outbound
   * @return outbound
  **/
  @ApiModelProperty(value = "")
  public List<DependencyTreeNode> getOutbound() {
    return outbound;
  }

  public void setOutbound(List<DependencyTreeNode> outbound) {
    this.outbound = outbound;
  }

  public DependencyTree users(List<IdWithName> users) {
    this.users = users;
    return this;
  }

  public DependencyTree addUsersItem(IdWithName usersItem) {
    if (this.users == null) {
      this.users = new ArrayList<IdWithName>();
    }
    this.users.add(usersItem);
    return this;
  }

   /**
   * Get users
   * @return users
  **/
  @ApiModelProperty(value = "")
  public List<IdWithName> getUsers() {
    return users;
  }

  public void setUsers(List<IdWithName> users) {
    this.users = users;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DependencyTree dependencyTree = (DependencyTree) o;
    return Objects.equals(this.object, dependencyTree.object) &&
        Objects.equals(this.inbound, dependencyTree.inbound) &&
        Objects.equals(this.outbound, dependencyTree.outbound) &&
        Objects.equals(this.users, dependencyTree.users);
  }

  @Override
  public int hashCode() {
    return Objects.hash(object, inbound, outbound, users);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DependencyTree {\n");
    
    sb.append("    object: ").append(toIndentedString(object)).append("\n");
    sb.append("    inbound: ").append(toIndentedString(inbound)).append("\n");
    sb.append("    outbound: ").append(toIndentedString(outbound)).append("\n");
    sb.append("    users: ").append(toIndentedString(users)).append("\n");
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
