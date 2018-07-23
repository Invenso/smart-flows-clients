
# PrinterDefinitionPrinterInfoGcp

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**connector** | [**IdWithName**](IdWithName.md) |  |  [optional]
**createTime** | **String** |  |  [optional]
**updateTime** | **String** |  |  [optional]
**accessTime** | **String** |  |  [optional]
**connectionStatus** | [**ConnectionStatusEnum**](#ConnectionStatusEnum) |  |  [optional]
**vendorCapabilities** | [**List&lt;GcpVendorCapability&gt;**](GcpVendorCapability.md) |  |  [optional]


<a name="ConnectionStatusEnum"></a>
## Enum: ConnectionStatusEnum
Name | Value
---- | -----
UNKNOWN | &quot;unknown&quot;
ONLINE | &quot;online&quot;
OFFLINE | &quot;offline&quot;
DORMANT | &quot;dormant&quot;



