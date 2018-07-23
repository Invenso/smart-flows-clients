
# Template

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** |  |  [optional]
**displayName** | **String** |  | 
**description** | **String** |  |  [optional]
**createdAt** | **String** |  |  [optional]
**createdBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**modifiedAt** | **String** |  |  [optional]
**modifiedBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**datasets** | [**List&lt;TemplateDatasets&gt;**](TemplateDatasets.md) |  |  [optional]
**type** | [**TypeEnum**](#TypeEnum) |  |  [optional]
**tagGroups** | [**List&lt;TagGroupRef&gt;**](TagGroupRef.md) |  |  [optional]
**standardContent** | [**TemplateStandardContent**](TemplateStandardContent.md) |  |  [optional]
**composedContent** | [**TemplateComposedContent**](TemplateComposedContent.md) |  |  [optional]


<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
STANDARD | &quot;standard&quot;
COMPOSED | &quot;composed&quot;



