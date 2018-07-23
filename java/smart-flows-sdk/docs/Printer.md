
# Printer

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
**definition** | [**IdWithName**](IdWithName.md) |  | 
**flavor** | [**FlavorEnum**](#FlavorEnum) |  |  [optional]
**defaultPrinter** | **Boolean** |  |  [optional]
**properties** | [**PrinterProperties**](PrinterProperties.md) |  |  [optional]


<a name="FlavorEnum"></a>
## Enum: FlavorEnum
Name | Value
---- | -----
JPS | &quot;jps&quot;
GCP | &quot;gcp&quot;



