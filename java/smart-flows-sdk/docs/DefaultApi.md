# DefaultApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addAsset**](DefaultApi.md#addAsset) | **POST** /assets | 
[**authenticateGet**](DefaultApi.md#authenticateGet) | **GET** /authenticate | 
[**authenticateLoginPost**](DefaultApi.md#authenticateLoginPost) | **POST** /authenticate/login | 
[**authenticateOauth2Post**](DefaultApi.md#authenticateOauth2Post) | **POST** /authenticate/oauth2 | 
[**cancelFlowExecution**](DefaultApi.md#cancelFlowExecution) | **DELETE** /flows/executions/{execution}/progress | 
[**clearSubSettings**](DefaultApi.md#clearSubSettings) | **DELETE** /settings/{settingsType} | 
[**continueFlowExecution**](DefaultApi.md#continueFlowExecution) | **POST** /flows/executions/{execution}/progress | 
[**createBackup**](DefaultApi.md#createBackup) | **POST** /system/backup | 
[**createConnector**](DefaultApi.md#createConnector) | **POST** /connectors | 
[**createDataset**](DefaultApi.md#createDataset) | **POST** /datasets | 
[**createDatasetData**](DefaultApi.md#createDatasetData) | **POST** /datasets/{datasetId}/data | 
[**createDocument**](DefaultApi.md#createDocument) | **POST** /documents | 
[**createExport**](DefaultApi.md#createExport) | **POST** /system/export | 
[**createFlatExport**](DefaultApi.md#createFlatExport) | **POST** /system/export/flat | 
[**createFlow**](DefaultApi.md#createFlow) | **POST** /flows | 
[**createLanguage**](DefaultApi.md#createLanguage) | **POST** /languages | 
[**createPrinter**](DefaultApi.md#createPrinter) | **POST** /printers | 
[**createTagGroup**](DefaultApi.md#createTagGroup) | **POST** /taggroups | 
[**createTemplate**](DefaultApi.md#createTemplate) | **POST** /templates | 
[**createUser**](DefaultApi.md#createUser) | **POST** /users | 
[**deleteAsset**](DefaultApi.md#deleteAsset) | **DELETE** /assets/{assetId} | 
[**deleteConnector**](DefaultApi.md#deleteConnector) | **DELETE** /connectors/{connectorId} | 
[**deleteData**](DefaultApi.md#deleteData) | **DELETE** /data/{dataId} | 
[**deleteDataset**](DefaultApi.md#deleteDataset) | **DELETE** /datasets/{datasetId} | 
[**deleteFlow**](DefaultApi.md#deleteFlow) | **DELETE** /flows/{flow} | 
[**deleteLanguage**](DefaultApi.md#deleteLanguage) | **DELETE** /languages/{language} | 
[**deletePrinter**](DefaultApi.md#deletePrinter) | **DELETE** /printers/{printer} | 
[**deleteTagGroup**](DefaultApi.md#deleteTagGroup) | **DELETE** /taggroups/{tagGroupId} | 
[**deleteTemplate**](DefaultApi.md#deleteTemplate) | **DELETE** /templates/{templateId} | 
[**deleteTemplateContent**](DefaultApi.md#deleteTemplateContent) | **DELETE** /templates/{templateId}/content | 
[**deleteUser**](DefaultApi.md#deleteUser) | **DELETE** /users/{user} | 
[**executeFlatImport**](DefaultApi.md#executeFlatImport) | **POST** /system/import/flat | 
[**executeFlow**](DefaultApi.md#executeFlow) | **POST** /flows/executions | 
[**executeImport**](DefaultApi.md#executeImport) | **POST** /system/import | 
[**existsData**](DefaultApi.md#existsData) | **HEAD** /data/{dataId} | 
[**getAllFlowExecutions**](DefaultApi.md#getAllFlowExecutions) | **GET** /flows/executions | 
[**getAsset**](DefaultApi.md#getAsset) | **GET** /assets/{assetId} | 
[**getAssetContent**](DefaultApi.md#getAssetContent) | **GET** /assets/{assetId}/content | 
[**getAssets**](DefaultApi.md#getAssets) | **GET** /assets | 
[**getConnector**](DefaultApi.md#getConnector) | **GET** /connectors/{connectorId} | 
[**getConnectorType**](DefaultApi.md#getConnectorType) | **GET** /connectors/types/{connectorTypeId} | 
[**getConnectorTypes**](DefaultApi.md#getConnectorTypes) | **GET** /connectors/types | 
[**getConnectors**](DefaultApi.md#getConnectors) | **GET** /connectors | 
[**getCurrentUser**](DefaultApi.md#getCurrentUser) | **GET** /users/me | 
[**getData**](DefaultApi.md#getData) | **GET** /data/{dataId} | 
[**getDataContent**](DefaultApi.md#getDataContent) | **GET** /data/{dataId}/content | 
[**getDataMetadata**](DefaultApi.md#getDataMetadata) | **GET** /data/meta | 
[**getDataPreview**](DefaultApi.md#getDataPreview) | **GET** /data/{dataId}/preview | 
[**getDataset**](DefaultApi.md#getDataset) | **GET** /datasets/{datasetId} | 
[**getDatasetDatas**](DefaultApi.md#getDatasetDatas) | **GET** /datasets/{datasetId}/data | 
[**getDatasetEntityReferences**](DefaultApi.md#getDatasetEntityReferences) | **GET** /datasets/{datasetId}/entityrefs | 
[**getDatasetLayout**](DefaultApi.md#getDatasetLayout) | **POST** /datasets/layout | 
[**getDatasets**](DefaultApi.md#getDatasets) | **GET** /datasets | 
[**getDatasource**](DefaultApi.md#getDatasource) | **GET** /datasources/{datasourceId} | 
[**getDatasourceEntityLayout**](DefaultApi.md#getDatasourceEntityLayout) | **GET** /datasources/{datasourceId}/layout/{entityName} | 
[**getDatasourceLayout**](DefaultApi.md#getDatasourceLayout) | **GET** /datasources/{datasourceId}/layout | 
[**getDatasourceType**](DefaultApi.md#getDatasourceType) | **GET** /datasources/types/{datasourceTypeId} | 
[**getDatasourceTypes**](DefaultApi.md#getDatasourceTypes) | **GET** /datasources/types | 
[**getDatasources**](DefaultApi.md#getDatasources) | **GET** /datasources | 
[**getDefaultLanguage**](DefaultApi.md#getDefaultLanguage) | **GET** /languages/default | 
[**getDefaultPrinter**](DefaultApi.md#getDefaultPrinter) | **GET** /printers/default | 
[**getDependencies**](DefaultApi.md#getDependencies) | **GET** /dependencies/{objectType}/{objectId} | 
[**getDocument**](DefaultApi.md#getDocument) | **GET** /documents/{documentId} | 
[**getDocumentContent**](DefaultApi.md#getDocumentContent) | **GET** /documents/{documentId}/content | 
[**getDocuments**](DefaultApi.md#getDocuments) | **GET** /documents | 
[**getExpressionFunctions**](DefaultApi.md#getExpressionFunctions) | **GET** /system/expression/functions | 
[**getExternalUsers**](DefaultApi.md#getExternalUsers) | **GET** /users/external | 
[**getFilteredAssets**](DefaultApi.md#getFilteredAssets) | **POST** /assets/filter | 
[**getFilteredConnectors**](DefaultApi.md#getFilteredConnectors) | **POST** /connectors/filter | 
[**getFilteredDatasets**](DefaultApi.md#getFilteredDatasets) | **POST** /datasets/filter | 
[**getFilteredDatasources**](DefaultApi.md#getFilteredDatasources) | **POST** /datasources/filter | 
[**getFilteredDocuments**](DefaultApi.md#getFilteredDocuments) | **POST** /documents/filter | 
[**getFilteredFlowExecutions**](DefaultApi.md#getFilteredFlowExecutions) | **POST** /flows/executions/filter | 
[**getFilteredPrinters**](DefaultApi.md#getFilteredPrinters) | **POST** /printers/filter | 
[**getFilteredTagGroups**](DefaultApi.md#getFilteredTagGroups) | **POST** /taggroups/filter | 
[**getFilteredTemplates**](DefaultApi.md#getFilteredTemplates) | **POST** /templates/filter | 
[**getFilteredUsers**](DefaultApi.md#getFilteredUsers) | **POST** /users/filter | 
[**getFlow**](DefaultApi.md#getFlow) | **GET** /flows/{flow} | 
[**getFlowContract**](DefaultApi.md#getFlowContract) | **POST** /flows/{flow}/contract | 
[**getFlowExecution**](DefaultApi.md#getFlowExecution) | **GET** /flows/executions/{execution} | 
[**getFlowExecutionProgress**](DefaultApi.md#getFlowExecutionProgress) | **GET** /flows/executions/{execution}/progress | 
[**getFlowExecutionStatistics**](DefaultApi.md#getFlowExecutionStatistics) | **POST** /flows/executions/statistics | 
[**getFlowExecutions**](DefaultApi.md#getFlowExecutions) | **GET** /flows/{flow}/executions | 
[**getFlowSettings**](DefaultApi.md#getFlowSettings) | **POST** /flows/steps/{step} | 
[**getFlowStep**](DefaultApi.md#getFlowStep) | **GET** /flows/steps/{step} | 
[**getFlowSteps**](DefaultApi.md#getFlowSteps) | **GET** /flows/steps | 
[**getFlowThumbnail**](DefaultApi.md#getFlowThumbnail) | **GET** /flows/{flow}/thumbnail | 
[**getFlows**](DefaultApi.md#getFlows) | **GET** /flows | 
[**getFormattedValue**](DefaultApi.md#getFormattedValue) | **GET** /system/format | 
[**getLanguage**](DefaultApi.md#getLanguage) | **GET** /languages/{language} | 
[**getLanguages**](DefaultApi.md#getLanguages) | **GET** /languages | 
[**getLicense**](DefaultApi.md#getLicense) | **GET** /system/license | 
[**getPluginDatasets**](DefaultApi.md#getPluginDatasets) | **GET** /datasets/plugin | 
[**getPlugins**](DefaultApi.md#getPlugins) | **GET** /plugins | 
[**getPrinter**](DefaultApi.md#getPrinter) | **GET** /printers/{printer} | 
[**getPrinters**](DefaultApi.md#getPrinters) | **GET** /printers | 
[**getRoles**](DefaultApi.md#getRoles) | **GET** /roles | 
[**getSettings**](DefaultApi.md#getSettings) | **GET** /settings | 
[**getSubSettings**](DefaultApi.md#getSubSettings) | **GET** /settings/{settingsType} | 
[**getSupportedFeatures**](DefaultApi.md#getSupportedFeatures) | **GET** /system/features | 
[**getSystemCurrencySymbols**](DefaultApi.md#getSystemCurrencySymbols) | **GET** /system/currencies | 
[**getSystemDefaultLanguage**](DefaultApi.md#getSystemDefaultLanguage) | **GET** /system/languages/default | 
[**getSystemInfo**](DefaultApi.md#getSystemInfo) | **GET** /system/info | 
[**getSystemLanguages**](DefaultApi.md#getSystemLanguages) | **GET** /system/languages | 
[**getSystemPrinter**](DefaultApi.md#getSystemPrinter) | **GET** /system/printers/{printer} | 
[**getSystemPrinters**](DefaultApi.md#getSystemPrinters) | **GET** /system/printers | 
[**getSystemTimeZones**](DefaultApi.md#getSystemTimeZones) | **GET** /system/timeZones | 
[**getTagGroup**](DefaultApi.md#getTagGroup) | **GET** /taggroups/{tagGroupId} | 
[**getTagGroups**](DefaultApi.md#getTagGroups) | **GET** /taggroups | 
[**getTemplate**](DefaultApi.md#getTemplate) | **GET** /templates/{templateId} | 
[**getTemplateContent**](DefaultApi.md#getTemplateContent) | **GET** /templates/{templateId}/content | 
[**getTemplateHistory**](DefaultApi.md#getTemplateHistory) | **GET** /templates/{templateId}/history | 
[**getTemplateLanguage**](DefaultApi.md#getTemplateLanguage) | **GET** /templates/{templateId}/lang/{lang} | 
[**getTemplateSchema**](DefaultApi.md#getTemplateSchema) | **GET** /templates/{templateId}/schema | 
[**getTemplates**](DefaultApi.md#getTemplates) | **GET** /templates | 
[**getUser**](DefaultApi.md#getUser) | **GET** /users/{user} | 
[**getUsers**](DefaultApi.md#getUsers) | **GET** /users | 
[**installLicense**](DefaultApi.md#installLicense) | **POST** /system/license | 
[**parseExpression**](DefaultApi.md#parseExpression) | **PUT** /system/expression | 
[**postFlowCallback**](DefaultApi.md#postFlowCallback) | **POST** /flows/callback/{callbackId} | 
[**prepareImport**](DefaultApi.md#prepareImport) | **POST** /system/import/prepare | 
[**refreshConnector**](DefaultApi.md#refreshConnector) | **POST** /connectors/{connectorId}/refresh | 
[**restoreBackup**](DefaultApi.md#restoreBackup) | **POST** /system/backup/restore | 
[**runCleanup**](DefaultApi.md#runCleanup) | **GET** /system/cleanup/run | 
[**setDefaultLanguage**](DefaultApi.md#setDefaultLanguage) | **PUT** /languages/default | 
[**setDefaultPrinter**](DefaultApi.md#setDefaultPrinter) | **PUT** /printers/default | 
[**setSystemDefaultLanguage**](DefaultApi.md#setSystemDefaultLanguage) | **PUT** /system/languages/default | 
[**setupConnector**](DefaultApi.md#setupConnector) | **POST** /connectors/{connectorId}/setup | 
[**setupConnectorCancel**](DefaultApi.md#setupConnectorCancel) | **POST** /connectors/{connectorId}/setup/cancel | 
[**setupConnectorCurrent**](DefaultApi.md#setupConnectorCurrent) | **GET** /connectors/{connectorId}/setup/current | 
[**setupConnectorFinish**](DefaultApi.md#setupConnectorFinish) | **POST** /connectors/{connectorId}/setup/finish | 
[**setupConnectorNext**](DefaultApi.md#setupConnectorNext) | **POST** /connectors/{connectorId}/setup/next | 
[**setupConnectorPrevious**](DefaultApi.md#setupConnectorPrevious) | **POST** /connectors/{connectorId}/setup/previous | 
[**syncExternalUsers**](DefaultApi.md#syncExternalUsers) | **POST** /users/external | 
[**testConnector**](DefaultApi.md#testConnector) | **GET** /connectors/{connectorId}/test | 
[**testPrinter**](DefaultApi.md#testPrinter) | **POST** /printers/{printer}/test | 
[**updateAsset**](DefaultApi.md#updateAsset) | **PUT** /assets/{assetId} | 
[**updateAssetContent**](DefaultApi.md#updateAssetContent) | **PUT** /assets/{assetId}/content | 
[**updateConnector**](DefaultApi.md#updateConnector) | **PUT** /connectors/{connectorId} | 
[**updateData**](DefaultApi.md#updateData) | **PUT** /data/{dataId} | 
[**updateDataset**](DefaultApi.md#updateDataset) | **PUT** /datasets/{datasetId} | 
[**updateFlow**](DefaultApi.md#updateFlow) | **PUT** /flows/{flow} | 
[**updateLanguage**](DefaultApi.md#updateLanguage) | **PUT** /languages/{language} | 
[**updatePrinter**](DefaultApi.md#updatePrinter) | **PUT** /printers/{printer} | 
[**updateSubSettings**](DefaultApi.md#updateSubSettings) | **PUT** /settings/{settingsType} | 
[**updateTagGroup**](DefaultApi.md#updateTagGroup) | **PUT** /taggroups/{tagGroupId} | 
[**updateTemplate**](DefaultApi.md#updateTemplate) | **PUT** /templates/{templateId} | 
[**updateTemplateContent**](DefaultApi.md#updateTemplateContent) | **PUT** /templates/{templateId}/content | 
[**updateUser**](DefaultApi.md#updateUser) | **PUT** /users/{user} | 


<a name="addAsset"></a>
# **addAsset**
> Asset addAsset(body)



Add a &#x60;assets&#x60; object to the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
BinaryDataHolder body = new BinaryDataHolder(); // BinaryDataHolder | 
try {
    Asset result = apiInstance.addAsset(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#addAsset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BinaryDataHolder**](BinaryDataHolder.md)|  | [optional]

### Return type

[**Asset**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="authenticateGet"></a>
# **authenticateGet**
> AuthenticationInfo authenticateGet()



Get info about the login methods

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
try {
    AuthenticationInfo result = apiInstance.authenticateGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#authenticateGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AuthenticationInfo**](AuthenticationInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="authenticateLoginPost"></a>
# **authenticateLoginPost**
> Authentication authenticateLoginPost(body)



Authenticate a user using user/password information

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
Login body = new Login(); // Login | The login information
try {
    Authentication result = apiInstance.authenticateLoginPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#authenticateLoginPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Login**](Login.md)| The login information | [optional]

### Return type

[**Authentication**](Authentication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="authenticateOauth2Post"></a>
# **authenticateOauth2Post**
> Authentication authenticateOauth2Post(body)



Authenticate a user using OAuth2 authorization code

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
Oauth2Parameters body = new Oauth2Parameters(); // Oauth2Parameters | The authorization code
try {
    Authentication result = apiInstance.authenticateOauth2Post(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#authenticateOauth2Post");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Oauth2Parameters**](Oauth2Parameters.md)| The authorization code | [optional]

### Return type

[**Authentication**](Authentication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="cancelFlowExecution"></a>
# **cancelFlowExecution**
> FlowExecutionProgress cancelFlowExecution(execution)



Cancel an existing execution

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String execution = "execution_example"; // String | The id of the flow execution
try {
    FlowExecutionProgress result = apiInstance.cancelFlowExecution(execution);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#cancelFlowExecution");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **String**| The id of the flow execution |

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="clearSubSettings"></a>
# **clearSubSettings**
> clearSubSettings(settingsType)



Clear all settings and revert to default settings for one settings type

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String settingsType = "settingsType_example"; // String | The type of the settings
try {
    apiInstance.clearSubSettings(settingsType);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#clearSubSettings");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **String**| The type of the settings |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="continueFlowExecution"></a>
# **continueFlowExecution**
> FlowExecutionProgress continueFlowExecution(execution, body)



Continue an existing execution

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String execution = "execution_example"; // String | The id of the flow execution
Object body = null; // Object | The object responding to the schema of the executionProgress object
try {
    FlowExecutionProgress result = apiInstance.continueFlowExecution(execution, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#continueFlowExecution");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **String**| The id of the flow execution |
 **body** | **Object**| The object responding to the schema of the executionProgress object | [optional]

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createBackup"></a>
# **createBackup**
> File createBackup(includeHistory, includeSensitiveData)



Create a backup of all objects in the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Boolean includeHistory = false; // Boolean | Whether to include the complete history of templates
Boolean includeSensitiveData = true; // Boolean | Whether to include possible sensitive data (passwords from connectors e.a.)
try {
    File result = apiInstance.createBackup(includeHistory, includeSensitiveData);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createBackup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeHistory** | **Boolean**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **Boolean**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to true]

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

<a name="createConnector"></a>
# **createConnector**
> Connector createConnector(body)



Add a &#x60;Connector&#x60; object to the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Connector body = new Connector(); // Connector | The connector to add
try {
    Connector result = apiInstance.createConnector(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Connector**](Connector.md)| The connector to add | [optional]

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createDataset"></a>
# **createDataset**
> Dataset createDataset(body)



Add a &#x60;Dataset&#x60; object to the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Dataset body = new Dataset(); // Dataset | 
try {
    Dataset result = apiInstance.createDataset(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createDataset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dataset**](Dataset.md)|  | [optional]

### Return type

[**Dataset**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createDatasetData"></a>
# **createDatasetData**
> Data createDatasetData(datasetId, body)



Add data that conforms to a dataset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
Data body = new Data(); // Data | The data object to create
try {
    Data result = apiInstance.createDatasetData(datasetId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createDatasetData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |
 **body** | [**Data**](Data.md)| The data object to create | [optional]

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="createDocument"></a>
# **createDocument**
> List&lt;GeneratedDocument&gt; createDocument(body)



Create preview of given template(ref) with given data(ref)

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
DocGenSettings body = new DocGenSettings(); // DocGenSettings | The parameters to create the document with
try {
    List<GeneratedDocument> result = apiInstance.createDocument(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createDocument");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocGenSettings**](DocGenSettings.md)| The parameters to create the document with | [optional]

### Return type

[**List&lt;GeneratedDocument&gt;**](GeneratedDocument.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createExport"></a>
# **createExport**
> File createExport(body, includeHistory, includeSensitiveData)



Create an export file for the given request

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
ArchiveRequest body = new ArchiveRequest(); // ArchiveRequest | The settings for the archive to create
Boolean includeHistory = false; // Boolean | Whether to include the complete history of templates
Boolean includeSensitiveData = false; // Boolean | Whether to include possible sensitive data (passwords from connectors e.a.)
try {
    File result = apiInstance.createExport(body, includeHistory, includeSensitiveData);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createExport");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ArchiveRequest**](ArchiveRequest.md)| The settings for the archive to create | [optional]
 **includeHistory** | **Boolean**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **Boolean**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to false]

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

<a name="createFlatExport"></a>
# **createFlatExport**
> FlatArchive createFlatExport(body, includeHistory, includeSensitiveData)



Create an export for the given request

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
ArchiveRequest body = new ArchiveRequest(); // ArchiveRequest | The settings for the archive to create
Boolean includeHistory = false; // Boolean | Whether to include the complete history of templates
Boolean includeSensitiveData = false; // Boolean | Whether to include possible sensitive data (passwords from connectors e.a.)
try {
    FlatArchive result = apiInstance.createFlatExport(body, includeHistory, includeSensitiveData);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createFlatExport");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ArchiveRequest**](ArchiveRequest.md)| The settings for the archive to create | [optional]
 **includeHistory** | **Boolean**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **Boolean**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to false]

### Return type

[**FlatArchive**](FlatArchive.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="createFlow"></a>
# **createFlow**
> Flow createFlow(body)



Add a new flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Flow body = new Flow(); // Flow | The possible fields and their possible values
try {
    Flow result = apiInstance.createFlow(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createFlow");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Flow**](Flow.md)| The possible fields and their possible values | [optional]

### Return type

[**Flow**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="createLanguage"></a>
# **createLanguage**
> Language createLanguage(body)



Add a new language that is supported

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Language body = new Language(); // Language | The settings for the language to create
try {
    Language result = apiInstance.createLanguage(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Language**](Language.md)| The settings for the language to create | [optional]

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="createPrinter"></a>
# **createPrinter**
> Printer createPrinter(body)



Add a new printer that can be used to print documents

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Printer body = new Printer(); // Printer | The settings for the printer to create
try {
    Printer result = apiInstance.createPrinter(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createPrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Printer**](Printer.md)| The settings for the printer to create | [optional]

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="createTagGroup"></a>
# **createTagGroup**
> TagGroup createTagGroup(body)



Add a tagGroup object to the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
TagGroup body = new TagGroup(); // TagGroup | 
try {
    TagGroup result = apiInstance.createTagGroup(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createTagGroup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TagGroup**](TagGroup.md)|  | [optional]

### Return type

[**TagGroup**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createTemplate"></a>
# **createTemplate**
> Template createTemplate(body)



Add a &#x60;templates&#x60; object to the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Template body = new Template(); // Template | 
try {
    Template result = apiInstance.createTemplate(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createTemplate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Template**](Template.md)|  | [optional]

### Return type

[**Template**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="createUser"></a>
# **createUser**
> User createUser(body)



Add a new user

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
User body = new User(); // User | The settings for the user to create
try {
    User result = apiInstance.createUser(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#createUser");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)| The settings for the user to create | [optional]

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteAsset"></a>
# **deleteAsset**
> deleteAsset(assetId, deleteInbound)



Remove a single asset object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String assetId = "assetId_example"; // String | The id of the asset
Boolean deleteInbound = false; // Boolean | When true, all items linked to this asset will also be deleted. When false, an error is returned when there is some link to this asset
try {
    apiInstance.deleteAsset(assetId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteAsset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **String**| The id of the asset |
 **deleteInbound** | **Boolean**| When true, all items linked to this asset will also be deleted. When false, an error is returned when there is some link to this asset | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteConnector"></a>
# **deleteConnector**
> deleteConnector(connectorId, deleteInbound)



Remove a single connector object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Boolean deleteInbound = false; // Boolean | When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this connector
try {
    apiInstance.deleteConnector(connectorId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **deleteInbound** | **Boolean**| When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this connector | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteData"></a>
# **deleteData**
> deleteData(dataId, deleteInbound)



Remove a single data object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data
Boolean deleteInbound = false; // Boolean | When true, all items linked to this data will also be deleted. When false, an error is returned when there is some link to this data
try {
    apiInstance.deleteData(dataId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data |
 **deleteInbound** | **Boolean**| When true, all items linked to this data will also be deleted. When false, an error is returned when there is some link to this data | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteDataset"></a>
# **deleteDataset**
> deleteDataset(datasetId, deleteInbound)



Remove a single dataset object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
Boolean deleteInbound = false; // Boolean | When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset
try {
    apiInstance.deleteDataset(datasetId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteDataset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |
 **deleteInbound** | **Boolean**| When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteFlow"></a>
# **deleteFlow**
> deleteFlow(flow)



Remove a single flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The id of the flow
try {
    apiInstance.deleteFlow(flow);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteFlow");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The id of the flow |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteLanguage"></a>
# **deleteLanguage**
> deleteLanguage(language, force, deleteInbound)



Remove a single language. You cannot delete the default language unless it is the last one and force is set to true

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String language = "language_example"; // String | The id of the language
Boolean force = false; // Boolean | true if you want to delete the last (and by definition then default) language in the project
Boolean deleteInbound = false; // Boolean | When true, all items linked to this language will also be deleted. When false, an error is returned when there is some link to this language
try {
    apiInstance.deleteLanguage(language, force, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **String**| The id of the language |
 **force** | **Boolean**| true if you want to delete the last (and by definition then default) language in the project | [optional] [default to false]
 **deleteInbound** | **Boolean**| When true, all items linked to this language will also be deleted. When false, an error is returned when there is some link to this language | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deletePrinter"></a>
# **deletePrinter**
> deletePrinter(printer, force, deleteInbound)



Remove a single printer. You cannot delete the default printer unless it is the last one and force is set to true

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String printer = "printer_example"; // String | The id of the printer
Boolean force = false; // Boolean | true if you want to delete the last (and by definition then default) printer in the project
Boolean deleteInbound = false; // Boolean | When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset
try {
    apiInstance.deletePrinter(printer, force, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deletePrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **String**| The id of the printer |
 **force** | **Boolean**| true if you want to delete the last (and by definition then default) printer in the project | [optional] [default to false]
 **deleteInbound** | **Boolean**| When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteTagGroup"></a>
# **deleteTagGroup**
> deleteTagGroup(tagGroupId, deleteInbound)



Remove a single tag group object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String tagGroupId = "tagGroupId_example"; // String | The id of the tag group
Boolean deleteInbound = false; // Boolean | When true, all tags linked to this tag group will also be deleted. When false, an error is returned when there is some link to this tag group
try {
    apiInstance.deleteTagGroup(tagGroupId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteTagGroup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **String**| The id of the tag group |
 **deleteInbound** | **Boolean**| When true, all tags linked to this tag group will also be deleted. When false, an error is returned when there is some link to this tag group | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteTemplate"></a>
# **deleteTemplate**
> deleteTemplate(templateId, deleteInbound)



Remove a single template object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
Boolean deleteInbound = false; // Boolean | When true, all items linked to this template will also be deleted. When false, an error is returned when there is some link to this template
try {
    apiInstance.deleteTemplate(templateId, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteTemplate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **deleteInbound** | **Boolean**| When true, all items linked to this template will also be deleted. When false, an error is returned when there is some link to this template | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteTemplateContent"></a>
# **deleteTemplateContent**
> deleteTemplateContent(templateId, lang, deleteInbound)



Remove the content for the given language of the given template

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String lang = "lang_example"; // String | The id of the language that is supported by the project, default when none specified
Boolean deleteInbound = false; // Boolean | When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this standard template
try {
    apiInstance.deleteTemplateContent(templateId, lang, deleteInbound);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteTemplateContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **lang** | **String**| The id of the language that is supported by the project, default when none specified | [optional]
 **deleteInbound** | **Boolean**| When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this standard template | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="deleteUser"></a>
# **deleteUser**
> deleteUser(user, force)



Remove a single user. You cannot delete the last admin user.

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String user = "user_example"; // String | The id of the user
Boolean force = false; // Boolean | true if you want to delete the last admin user
try {
    apiInstance.deleteUser(user, force);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#deleteUser");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **String**| The id of the user |
 **force** | **Boolean**| true if you want to delete the last admin user | [optional] [default to false]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="executeFlatImport"></a>
# **executeFlatImport**
> executeFlatImport(body)



Import the content from the given archive

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
FlatArchive body = new FlatArchive(); // FlatArchive | The flat archive content
try {
    apiInstance.executeFlatImport(body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#executeFlatImport");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlatArchive**](FlatArchive.md)| The flat archive content | [optional]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="executeFlow"></a>
# **executeFlow**
> FlowExecutionProgress executeFlow(flowId, datasetId, body)



Execute a flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flowId = "flowId_example"; // String | The id of the flow.
String datasetId = "datasetId_example"; // String | The id of the dataset the flow input conforms to. Optional if flowId is present or no data is sent.
Object body = null; // Object | The input object for the flow
try {
    FlowExecutionProgress result = apiInstance.executeFlow(flowId, datasetId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#executeFlow");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flowId** | **String**| The id of the flow. | [optional]
 **datasetId** | **String**| The id of the dataset the flow input conforms to. Optional if flowId is present or no data is sent. | [optional]
 **body** | **Object**| The input object for the flow | [optional]

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="executeImport"></a>
# **executeImport**
> executeImport(body)



Import the content from the given archive

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
RestoreContext body = new RestoreContext(); // RestoreContext | The content of the archive with mappings for the unresolved entities
try {
    apiInstance.executeImport(body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#executeImport");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RestoreContext**](RestoreContext.md)| The content of the archive with mappings for the unresolved entities | [optional]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="existsData"></a>
# **existsData**
> existsData(dataId)



Check whether the data with the given id exists

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data as returned by the dataset data endpoint
try {
    apiInstance.existsData(dataId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#existsData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data as returned by the dataset data endpoint |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getAllFlowExecutions"></a>
# **getAllFlowExecutions**
> List&lt;FlowExecution&gt; getAllFlowExecutions(page, size, sort, filter)



Returns all executions for all flows

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<FlowExecution> result = apiInstance.getAllFlowExecutions(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getAllFlowExecutions");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;FlowExecution&gt;**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getAsset"></a>
# **getAsset**
> Asset getAsset(assetId, includeContent)



Retrieve a single asset object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String assetId = "assetId_example"; // String | The id of the asset
Boolean includeContent = false; // Boolean | true to return content with the asset
try {
    Asset result = apiInstance.getAsset(assetId, includeContent);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getAsset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **String**| The id of the asset |
 **includeContent** | **Boolean**| true to return content with the asset | [optional] [default to false]

### Return type

[**Asset**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getAssetContent"></a>
# **getAssetContent**
> getAssetContent(assetId)



Return the content of the asset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String assetId = "assetId_example"; // String | The id of the asset
try {
    apiInstance.getAssetContent(assetId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getAssetContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **String**| The id of the asset |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octetstream

<a name="getAssets"></a>
# **getAssets**
> List&lt;Asset&gt; getAssets(page, size, sort, filter)



Returns all assets

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Asset> result = apiInstance.getAssets(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getAssets");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Asset&gt;**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getConnector"></a>
# **getConnector**
> Connector getConnector(connectorId)



Retrieve a single connector object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
try {
    Connector result = apiInstance.getConnector(connectorId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getConnectorType"></a>
# **getConnectorType**
> ConnectorType getConnectorType(connectorTypeId)



Retrieve a single connectorType object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorTypeId = "connectorTypeId_example"; // String | The id of the connector type
try {
    ConnectorType result = apiInstance.getConnectorType(connectorTypeId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getConnectorType");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorTypeId** | **String**| The id of the connector type |

### Return type

[**ConnectorType**](ConnectorType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getConnectorTypes"></a>
# **getConnectorTypes**
> List&lt;ConnectorType&gt; getConnectorTypes()



Gets all &#x60;ConnectorType&#x60; objects for this project.

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<ConnectorType> result = apiInstance.getConnectorTypes();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getConnectorTypes");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;ConnectorType&gt;**](ConnectorType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getConnectors"></a>
# **getConnectors**
> List&lt;Connector&gt; getConnectors(page, size, sort, filter)



Gets all &#x60;Connector&#x60; objects for this project. 

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Connector> result = apiInstance.getConnectors(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getConnectors");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Connector&gt;**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getCurrentUser"></a>
# **getCurrentUser**
> User getCurrentUser()



Gets the current user

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    User result = apiInstance.getCurrentUser();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getCurrentUser");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getData"></a>
# **getData**
> Data getData(dataId)



Retrieve information about previously added data

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data as returned by the dataset data endpoint
try {
    Data result = apiInstance.getData(dataId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data as returned by the dataset data endpoint |

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDataContent"></a>
# **getDataContent**
> File getDataContent(dataId)



Retrieve the actual data

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data as returned by the dataset data endpoint
try {
    File result = apiInstance.getDataContent(dataId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDataContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data as returned by the dataset data endpoint |

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDataMetadata"></a>
# **getDataMetadata**
> File getDataMetadata(templateName, projectName, creator)



Retrieve a sample for the metadata used when generating documents

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateName = "templateName_example"; // String | The name of the template to use
String projectName = "projectName_example"; // String | The name of the project to use
String creator = "creator_example"; // String | The name of the creator to use
try {
    File result = apiInstance.getDataMetadata(templateName, projectName, creator);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDataMetadata");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateName** | **String**| The name of the template to use | [optional]
 **projectName** | **String**| The name of the project to use | [optional]
 **creator** | **String**| The name of the creator to use | [optional]

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

<a name="getDataPreview"></a>
# **getDataPreview**
> File getDataPreview(dataId)



Retrieve the data as sent to the document preview

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data as returned by the dataset data endpoint
try {
    File result = apiInstance.getDataPreview(dataId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDataPreview");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data as returned by the dataset data endpoint |

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

<a name="getDataset"></a>
# **getDataset**
> Dataset getDataset(datasetId)



Retrieve a single dataset object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
try {
    Dataset result = apiInstance.getDataset(datasetId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDataset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |

### Return type

[**Dataset**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasetDatas"></a>
# **getDatasetDatas**
> List&lt;Data&gt; getDatasetDatas(datasetId, page, size, sort, filter)



Retrieve all datas that are linked to the given dataset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter (dataset cannot be specified)
try {
    List<Data> result = apiInstance.getDatasetDatas(datasetId, page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasetDatas");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter (dataset cannot be specified) | [optional]

### Return type

[**List&lt;Data&gt;**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasetEntityReferences"></a>
# **getDatasetEntityReferences**
> List&lt;IdWithName&gt; getDatasetEntityReferences(datasetId, page, size, sort, filter)



Retrieves entity references to the primary entity

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<IdWithName> result = apiInstance.getDatasetEntityReferences(datasetId, page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasetEntityReferences");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;IdWithName&gt;**](IdWithName.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasetLayout"></a>
# **getDatasetLayout**
> List&lt;EntityDefinition&gt; getDatasetLayout(body, primaryOnly)



Get a list of available entities in the given dataset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Dataset body = new Dataset(); // Dataset | 
Boolean primaryOnly = false; // Boolean | Return only the entities that can be primary entities when set to true
try {
    List<EntityDefinition> result = apiInstance.getDatasetLayout(body, primaryOnly);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasetLayout");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dataset**](Dataset.md)|  | [optional]
 **primaryOnly** | **Boolean**| Return only the entities that can be primary entities when set to true | [optional] [default to false]

### Return type

[**List&lt;EntityDefinition&gt;**](EntityDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasets"></a>
# **getDatasets**
> List&lt;Dataset&gt; getDatasets(page, size, sort, filter)



Returns all datasets

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Dataset> result = apiInstance.getDatasets(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasets");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Dataset&gt;**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasource"></a>
# **getDatasource**
> Datasource getDatasource(datasourceId)



Gets all &#x60;Datasource&#x60; objects for this project. 

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasourceId = "datasourceId_example"; // String | The id of the datasource
try {
    Datasource result = apiInstance.getDatasource(datasourceId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasource");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **String**| The id of the datasource |

### Return type

[**Datasource**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasourceEntityLayout"></a>
# **getDatasourceEntityLayout**
> EntityDefinition getDatasourceEntityLayout(datasourceId, entityName)



Returns all the fields and relations for the entity

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasourceId = "datasourceId_example"; // String | The id of the datasource
String entityName = "entityName_example"; // String | The name of the entity
try {
    EntityDefinition result = apiInstance.getDatasourceEntityLayout(datasourceId, entityName);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasourceEntityLayout");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **String**| The id of the datasource |
 **entityName** | **String**| The name of the entity |

### Return type

[**EntityDefinition**](EntityDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasourceLayout"></a>
# **getDatasourceLayout**
> DatasourceLayout getDatasourceLayout(datasourceId, full)



Returns all the fields and relations that are available in the datasource

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasourceId = "datasourceId_example"; // String | The id of the datasource
Boolean full = true; // Boolean | True to return the entire layout at once, false to return only the entity information. Defaults to datasource default.
try {
    DatasourceLayout result = apiInstance.getDatasourceLayout(datasourceId, full);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasourceLayout");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **String**| The id of the datasource |
 **full** | **Boolean**| True to return the entire layout at once, false to return only the entity information. Defaults to datasource default. | [optional]

### Return type

[**DatasourceLayout**](DatasourceLayout.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasourceType"></a>
# **getDatasourceType**
> DatasourceType getDatasourceType(datasourceTypeId)



Retrieve a single datasourcetype object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasourceTypeId = "datasourceTypeId_example"; // String | The id of the datasource type
try {
    DatasourceType result = apiInstance.getDatasourceType(datasourceTypeId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasourceType");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceTypeId** | **String**| The id of the datasource type |

### Return type

[**DatasourceType**](DatasourceType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasourceTypes"></a>
# **getDatasourceTypes**
> List&lt;DatasourceType&gt; getDatasourceTypes()



Gets all &#x60;DatasourceType&#x60; objects for this project.

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<DatasourceType> result = apiInstance.getDatasourceTypes();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasourceTypes");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;DatasourceType&gt;**](DatasourceType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDatasources"></a>
# **getDatasources**
> List&lt;Datasource&gt; getDatasources(page, size, sort, filter)



Gets all &#x60;Datasource&#x60; objects for this project. 

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Datasource> result = apiInstance.getDatasources(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDatasources");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Datasource&gt;**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDefaultLanguage"></a>
# **getDefaultLanguage**
> Language getDefaultLanguage()



Get the default language for the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    Language result = apiInstance.getDefaultLanguage();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDefaultLanguage");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getDefaultPrinter"></a>
# **getDefaultPrinter**
> Printer getDefaultPrinter()



Get the default printer for the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    Printer result = apiInstance.getDefaultPrinter();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDefaultPrinter");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getDependencies"></a>
# **getDependencies**
> DependencyTree getDependencies(objectType, objectId, direction, depth)



Get the dependencies of the object with the given id

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String objectType = "objectType_example"; // String | The type of the object to get the dependencies of (definitions/objectType)
String objectId = "objectId_example"; // String | The id of the object to get the dependencies of
String direction = "inbound"; // String | Whether the inbound or outbound relations or both are requested
String depth = "direct"; // String | Whether only the direct relations or all the transitive relations are requested
try {
    DependencyTree result = apiInstance.getDependencies(objectType, objectId, direction, depth);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDependencies");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectType** | **String**| The type of the object to get the dependencies of (definitions/objectType) |
 **objectId** | **String**| The id of the object to get the dependencies of |
 **direction** | **String**| Whether the inbound or outbound relations or both are requested | [optional] [default to inbound] [enum: inbound, outbound, both]
 **depth** | **String**| Whether only the direct relations or all the transitive relations are requested | [optional] [default to direct] [enum: direct, full]

### Return type

[**DependencyTree**](DependencyTree.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getDocument"></a>
# **getDocument**
> Document getDocument(documentId)



Retrieve a single document object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String documentId = "documentId_example"; // String | The id of the document
try {
    Document result = apiInstance.getDocument(documentId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDocument");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **String**| The id of the document |

### Return type

[**Document**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getDocumentContent"></a>
# **getDocumentContent**
> getDocumentContent(documentId)



Return the content of the document

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String documentId = "documentId_example"; // String | The id of the document
try {
    apiInstance.getDocumentContent(documentId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDocumentContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **String**| The id of the document |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.openxmlformats-officedocument.wordprocessingml.document

<a name="getDocuments"></a>
# **getDocuments**
> List&lt;Document&gt; getDocuments(page, size, sort, filter)



Returns all documents

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Document> result = apiInstance.getDocuments(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getDocuments");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Document&gt;**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getExpressionFunctions"></a>
# **getExpressionFunctions**
> List&lt;ExpressionFunction&gt; getExpressionFunctions(page, size, sort, filter)



List all the supported template expression functions

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<ExpressionFunction> result = apiInstance.getExpressionFunctions(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getExpressionFunctions");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;ExpressionFunction&gt;**](ExpressionFunction.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getExternalUsers"></a>
# **getExternalUsers**
> List&lt;User&gt; getExternalUsers(page, size, sort, filter)



Retrieves users exposed by the login connector

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<User> result = apiInstance.getExternalUsers(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getExternalUsers");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredAssets"></a>
# **getFilteredAssets**
> List&lt;Asset&gt; getFilteredAssets(page, size, sort, filter)



Returns all assets using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Asset> result = apiInstance.getFilteredAssets(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredAssets");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Asset&gt;**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredConnectors"></a>
# **getFilteredConnectors**
> List&lt;Connector&gt; getFilteredConnectors(page, size, sort, filter)



Gets all &#x60;Connector&#x60; objects for this project using a complex filter. 

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Connector> result = apiInstance.getFilteredConnectors(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredConnectors");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Connector&gt;**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredDatasets"></a>
# **getFilteredDatasets**
> List&lt;Dataset&gt; getFilteredDatasets(page, size, sort, filter)



Returns all datasets using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Dataset> result = apiInstance.getFilteredDatasets(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredDatasets");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Dataset&gt;**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredDatasources"></a>
# **getFilteredDatasources**
> List&lt;Datasource&gt; getFilteredDatasources(page, size, sort, filter)



Gets all &#x60;Datasource&#x60; objects for this project using a complex filter 

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Datasource> result = apiInstance.getFilteredDatasources(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredDatasources");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Datasource&gt;**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredDocuments"></a>
# **getFilteredDocuments**
> List&lt;Document&gt; getFilteredDocuments(page, size, sort, filter)



Returns all documents using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Document> result = apiInstance.getFilteredDocuments(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredDocuments");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Document&gt;**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredFlowExecutions"></a>
# **getFilteredFlowExecutions**
> List&lt;FlowExecution&gt; getFilteredFlowExecutions(page, size, sort, filter)



Returns all executions for all flows, by a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<FlowExecution> result = apiInstance.getFilteredFlowExecutions(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredFlowExecutions");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;FlowExecution&gt;**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFilteredPrinters"></a>
# **getFilteredPrinters**
> List&lt;Printer&gt; getFilteredPrinters(page, size, sort, filter)



Lists all printers using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Printer> result = apiInstance.getFilteredPrinters(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredPrinters");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Printer&gt;**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFilteredTagGroups"></a>
# **getFilteredTagGroups**
> List&lt;TagGroup&gt; getFilteredTagGroups(page, size, sort, filter)



Returns all tag groups using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<TagGroup> result = apiInstance.getFilteredTagGroups(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredTagGroups");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;TagGroup&gt;**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredTemplates"></a>
# **getFilteredTemplates**
> List&lt;Template&gt; getFilteredTemplates(page, size, sort, filter)



Returns all templates using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<Template> result = apiInstance.getFilteredTemplates(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredTemplates");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;Template&gt;**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFilteredUsers"></a>
# **getFilteredUsers**
> List&lt;User&gt; getFilteredUsers(page, size, sort, filter)



Lists all users using a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    List<User> result = apiInstance.getFilteredUsers(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFilteredUsers");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFlow"></a>
# **getFlow**
> Flow getFlow(flow)



Get a single flow from the server

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The path property of the flow
try {
    Flow result = apiInstance.getFlow(flow);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlow");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The path property of the flow |

### Return type

[**Flow**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFlowContract"></a>
# **getFlowContract**
> FlowContract getFlowContract(flow, body)



Get all the input and output parameters the flow defines based on the steps it contains and the values that are specified for all parameters in each step

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The path property of the flow step
Object body = null; // Object | The possible fields and their possible values, matching the input schema
try {
    FlowContract result = apiInstance.getFlowContract(flow, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowContract");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The path property of the flow step |
 **body** | **Object**| The possible fields and their possible values, matching the input schema | [optional]

### Return type

[**FlowContract**](FlowContract.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFlowExecution"></a>
# **getFlowExecution**
> FlowExecution getFlowExecution(execution)



Get the state of a single execution

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String execution = "execution_example"; // String | The id of the flow execution
try {
    FlowExecution result = apiInstance.getFlowExecution(execution);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowExecution");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **String**| The id of the flow execution |

### Return type

[**FlowExecution**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFlowExecutionProgress"></a>
# **getFlowExecutionProgress**
> FlowExecutionProgress getFlowExecutionProgress(execution, timeout)



Find out the progress of an existing execution

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String execution = "execution_example"; // String | The id of the flow execution
Integer timeout = 56; // Integer | The timeout in seconds, defaults to 30
try {
    FlowExecutionProgress result = apiInstance.getFlowExecutionProgress(execution, timeout);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowExecutionProgress");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **String**| The id of the flow execution |
 **timeout** | **Integer**| The timeout in seconds, defaults to 30 | [optional]

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFlowExecutionStatistics"></a>
# **getFlowExecutionStatistics**
> Statistics getFlowExecutionStatistics(groupTimeBy, filter)



Returns statistics for flow executions, by a complex filter

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String groupTimeBy = "groupTimeBy_example"; // String | the timespan to groupBy for the perTime part
FilterGroupNode filter = new FilterGroupNode(); // FilterGroupNode | The filter
try {
    Statistics result = apiInstance.getFlowExecutionStatistics(groupTimeBy, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowExecutionStatistics");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupTimeBy** | **String**| the timespan to groupBy for the perTime part | [optional] [enum: Hour, HourOfDay, Day, DayOfWeek, DayOfMonth, Week, WeekOfYear, Month, MonthOfYear]
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional]

### Return type

[**Statistics**](Statistics.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFlowExecutions"></a>
# **getFlowExecutions**
> List&lt;FlowExecution&gt; getFlowExecutions(flow, page, size, sort, filter)



Returns all executions for this flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The id of the flow
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<FlowExecution> result = apiInstance.getFlowExecutions(flow, page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowExecutions");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The id of the flow |
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;FlowExecution&gt;**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFlowSettings"></a>
# **getFlowSettings**
> Object getFlowSettings(step, property, body)



Get all the settings (in and out) the step requires based on the values for the properties of the step, input is according to schema defining input, output is schemaform

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String step = "step_example"; // String | The path property of the flow step
String property = "property_example"; // String | The property to get the schemaform for
Object body = null; // Object | The possible fields and their possible values
try {
    Object result = apiInstance.getFlowSettings(step, property, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowSettings");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **step** | **String**| The path property of the flow step |
 **property** | **String**| The property to get the schemaform for |
 **body** | **Object**| The possible fields and their possible values | [optional]

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFlowStep"></a>
# **getFlowStep**
> FlowStep getFlowStep(step)



Get definition of a specific flow step

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String step = "step_example"; // String | The path property of the step
try {
    FlowStep result = apiInstance.getFlowStep(step);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowStep");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **step** | **String**| The path property of the step |

### Return type

[**FlowStep**](FlowStep.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFlowSteps"></a>
# **getFlowSteps**
> List&lt;FlowStep&gt; getFlowSteps()



Lists all the possible flow steps

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<FlowStep> result = apiInstance.getFlowSteps();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowSteps");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;FlowStep&gt;**](FlowStep.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFlowThumbnail"></a>
# **getFlowThumbnail**
> File getFlowThumbnail(flow)



Returns a thumbnail image of the flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The id of the flow
try {
    File result = apiInstance.getFlowThumbnail(flow);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlowThumbnail");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The id of the flow |

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getFlows"></a>
# **getFlows**
> List&lt;Flow&gt; getFlows(page, size, sort, filter)



Lists all the flows defined on the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Flow> result = apiInstance.getFlows(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFlows");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Flow&gt;**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getFormattedValue"></a>
# **getFormattedValue**
> FormattedValue getFormattedValue(value, pattern, type, locale)



Format a number, date, time or dateTime using the given pattern

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String value = "value_example"; // String | The value to format
String pattern = "pattern_example"; // String | The pattern to format the value with
String type = "type_example"; // String | The type of the value
String locale = "locale_example"; // String | The locale to use for the formatting
try {
    FormattedValue result = apiInstance.getFormattedValue(value, pattern, type, locale);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getFormattedValue");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **String**| The value to format |
 **pattern** | **String**| The pattern to format the value with |
 **type** | **String**| The type of the value | [enum: number, date, time, dateTime, duration]
 **locale** | **String**| The locale to use for the formatting | [optional]

### Return type

[**FormattedValue**](FormattedValue.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getLanguage"></a>
# **getLanguage**
> Language getLanguage(language)



Get a single language

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String language = "language_example"; // String | The id of the language
try {
    Language result = apiInstance.getLanguage(language);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **String**| The id of the language |

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getLanguages"></a>
# **getLanguages**
> List&lt;Language&gt; getLanguages()



Lists all the supported languages

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<Language> result = apiInstance.getLanguages();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getLanguages");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Language&gt;**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getLicense"></a>
# **getLicense**
> LicenseInformation getLicense()



Return the currently installed license

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
try {
    LicenseInformation result = apiInstance.getLicense();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getLicense");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LicenseInformation**](LicenseInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getPluginDatasets"></a>
# **getPluginDatasets**
> List&lt;Dataset&gt; getPluginDatasets()



Returns all datasets defined by plugins

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<Dataset> result = apiInstance.getPluginDatasets();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getPluginDatasets");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Dataset&gt;**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getPlugins"></a>
# **getPlugins**
> List&lt;Plugin&gt; getPlugins()



Gets all Plugins registered in this project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
try {
    List<Plugin> result = apiInstance.getPlugins();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getPlugins");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Plugin&gt;**](Plugin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getPrinter"></a>
# **getPrinter**
> Printer getPrinter(printer)



Get a single printer

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String printer = "printer_example"; // String | The id of the printer
try {
    Printer result = apiInstance.getPrinter(printer);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getPrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **String**| The id of the printer |

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getPrinters"></a>
# **getPrinters**
> List&lt;Printer&gt; getPrinters()



Lists all printers that can be used to print documents

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<Printer> result = apiInstance.getPrinters();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getPrinters");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Printer&gt;**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getRoles"></a>
# **getRoles**
> List&lt;Role&gt; getRoles()



Lists all security roles

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<Role> result = apiInstance.getRoles();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getRoles");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Role&gt;**](Role.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSettings"></a>
# **getSettings**
> Settings getSettings()



Get all settings

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    Settings result = apiInstance.getSettings();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSettings");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Settings**](Settings.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getSubSettings"></a>
# **getSubSettings**
> Object getSubSettings(settingsType)



Get only settings of one type. SettingsType parameter should be one of the properties of the settings object.

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String settingsType = "settingsType_example"; // String | The type of the settings
try {
    Object result = apiInstance.getSubSettings(settingsType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSubSettings");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **String**| The type of the settings |

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getSupportedFeatures"></a>
# **getSupportedFeatures**
> List&lt;Feature&gt; getSupportedFeatures()



Get a list of supported features

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<Feature> result = apiInstance.getSupportedFeatures();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSupportedFeatures");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Feature&gt;**](Feature.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemCurrencySymbols"></a>
# **getSystemCurrencySymbols**
> List&lt;CurrencySymbol&gt; getSystemCurrencySymbols(page, size, sort, filter)



Lists all the currency symbols that are availabled on the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<CurrencySymbol> result = apiInstance.getSystemCurrencySymbols(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemCurrencySymbols");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;CurrencySymbol&gt;**](CurrencySymbol.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemDefaultLanguage"></a>
# **getSystemDefaultLanguage**
> LanguageDefinition getSystemDefaultLanguage()



Get the default language for the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    LanguageDefinition result = apiInstance.getSystemDefaultLanguage();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemDefaultLanguage");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LanguageDefinition**](LanguageDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemInfo"></a>
# **getSystemInfo**
> SystemInfo getSystemInfo()



Get system information

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    SystemInfo result = apiInstance.getSystemInfo();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemInfo");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SystemInfo**](SystemInfo.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemLanguages"></a>
# **getSystemLanguages**
> List&lt;LanguageDefinition&gt; getSystemLanguages(page, size, sort, filter, formats)



Lists all the languages that are availabled on the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
Boolean formats = false; // Boolean | Include standard formats for dates, times, dateTimes and numbers in the result
try {
    List<LanguageDefinition> result = apiInstance.getSystemLanguages(page, size, sort, filter, formats);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemLanguages");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]
 **formats** | **Boolean**| Include standard formats for dates, times, dateTimes and numbers in the result | [optional] [default to false]

### Return type

[**List&lt;LanguageDefinition&gt;**](LanguageDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemPrinter"></a>
# **getSystemPrinter**
> PrinterDefinition getSystemPrinter(printer, includeDetails)



Get a single printerdefinition

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String printer = "printer_example"; // String | The id of the printer definition
Boolean includeDetails = true; // Boolean | Include the details of each printer
try {
    PrinterDefinition result = apiInstance.getSystemPrinter(printer, includeDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemPrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **String**| The id of the printer definition |
 **includeDetails** | **Boolean**| Include the details of each printer | [optional] [default to true]

### Return type

[**PrinterDefinition**](PrinterDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemPrinters"></a>
# **getSystemPrinters**
> List&lt;PrinterDefinition&gt; getSystemPrinters(page, size, sort, filter, includeDetails)



Get a list of the available printers on the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
Boolean includeDetails = false; // Boolean | Include the details of each printer
try {
    List<PrinterDefinition> result = apiInstance.getSystemPrinters(page, size, sort, filter, includeDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemPrinters");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]
 **includeDetails** | **Boolean**| Include the details of each printer | [optional] [default to false]

### Return type

[**List&lt;PrinterDefinition&gt;**](PrinterDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getSystemTimeZones"></a>
# **getSystemTimeZones**
> List&lt;String&gt; getSystemTimeZones()



Lists all the time zones that are availabled on the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    List<String> result = apiInstance.getSystemTimeZones();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getSystemTimeZones");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List&lt;String&gt;**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getTagGroup"></a>
# **getTagGroup**
> TagGroup getTagGroup(tagGroupId)



Retrieve a single tag group object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String tagGroupId = "tagGroupId_example"; // String | The id of the tag group
try {
    TagGroup result = apiInstance.getTagGroup(tagGroupId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTagGroup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **String**| The id of the tag group |

### Return type

[**TagGroup**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTagGroups"></a>
# **getTagGroups**
> List&lt;TagGroup&gt; getTagGroups(page, size, sort, filter)



Returns all tag groups

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<TagGroup> result = apiInstance.getTagGroups(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTagGroups");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;TagGroup&gt;**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTemplate"></a>
# **getTemplate**
> Template getTemplate(templateId)



Retrieve a single template object

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
try {
    Template result = apiInstance.getTemplate(templateId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |

### Return type

[**Template**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTemplateContent"></a>
# **getTemplateContent**
> File getTemplateContent(templateId, lang, version, includeMeta)



Return the content of the template for the given language.

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String lang = "lang_example"; // String | The id of the language that is supported by the project, default when none specified
String version = "version_example"; // String | The version ID or the revision number of the template to retrieve. Latest version if not specified
Boolean includeMeta = false; // Boolean | Whether template meta information should already be included in the template document itself
try {
    File result = apiInstance.getTemplateContent(templateId, lang, version, includeMeta);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplateContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **lang** | **String**| The id of the language that is supported by the project, default when none specified | [optional]
 **version** | **String**| The version ID or the revision number of the template to retrieve. Latest version if not specified | [optional]
 **includeMeta** | **Boolean**| Whether template meta information should already be included in the template document itself | [optional] [default to false]

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

<a name="getTemplateHistory"></a>
# **getTemplateHistory**
> List&lt;Version&gt; getTemplateHistory(templateId, lang, page, size, sort)



Show the history of a given template

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String lang = "lang_example"; // String | The id of the language that is supported by the project, default when none specified
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
try {
    List<Version> result = apiInstance.getTemplateHistory(templateId, lang, page, size, sort);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplateHistory");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **lang** | **String**| The id of the language that is supported by the project, default when none specified | [optional]
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]

### Return type

[**List&lt;Version&gt;**](Version.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTemplateLanguage"></a>
# **getTemplateLanguage**
> TemplateLanguage getTemplateLanguage(templateId, lang)



Retrieve info about the template for the given language

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String lang = "lang_example"; // String | The id of the language that is supported by the project
try {
    TemplateLanguage result = apiInstance.getTemplateLanguage(templateId, lang);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplateLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **lang** | **String**| The id of the language that is supported by the project |

### Return type

[**TemplateLanguage**](TemplateLanguage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTemplateSchema"></a>
# **getTemplateSchema**
> File getTemplateSchema(templateId, format)



Get the schema of the fields that are usabel in the template

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String format = "xsd"; // String | The format of the schema
try {
    File result = apiInstance.getTemplateSchema(templateId, format);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplateSchema");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **format** | **String**| The format of the schema | [optional] [default to xsd] [enum: xsd]

### Return type

[**File**](File.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getTemplates"></a>
# **getTemplates**
> List&lt;Template&gt; getTemplates(page, size, sort, filter)



Returns all templates

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<Template> result = apiInstance.getTemplates(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getTemplates");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;Template&gt;**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="getUser"></a>
# **getUser**
> User getUser(user)



Get a single user

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String user = "user_example"; // String | The id of the user
try {
    User result = apiInstance.getUser(user);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getUser");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **String**| The id of the user |

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="getUsers"></a>
# **getUsers**
> List&lt;User&gt; getUsers(page, size, sort, filter)



Lists all users

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Integer page = 56; // Integer | The 0-based page to retrieve, defaults to 0
Integer size = 56; // Integer | The size of the page, defaults to 20
String sort = "sort_example"; // String | The fields to sort on
String filter = "filter_example"; // String | The filter
try {
    List<User> result = apiInstance.getUsers(page, size, sort, filter);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#getUsers");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **Integer**| The 0-based page to retrieve, defaults to 0 | [optional]
 **size** | **Integer**| The size of the page, defaults to 20 | [optional]
 **sort** | **String**| The fields to sort on | [optional]
 **filter** | **String**| The filter | [optional]

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="installLicense"></a>
# **installLicense**
> LicenseInformation installLicense(body)



Install a new license

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
byte[] body = BINARY_DATA_HERE; // byte[] | The license to install
try {
    LicenseInformation result = apiInstance.installLicense(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#installLicense");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**| The license to install | [optional]

### Return type

[**LicenseInformation**](LicenseInformation.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="parseExpression"></a>
# **parseExpression**
> ParseExpressionResponse parseExpression(body)



Parse the given expression

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
ParseExpressionRequest body = new ParseExpressionRequest(); // ParseExpressionRequest | The result object for the language
try {
    ParseExpressionResponse result = apiInstance.parseExpression(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#parseExpression");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ParseExpressionRequest**](ParseExpressionRequest.md)| The result object for the language | [optional]

### Return type

[**ParseExpressionResponse**](ParseExpressionResponse.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="postFlowCallback"></a>
# **postFlowCallback**
> String postFlowCallback(callbackId, executionId, body)



Can be used for external calls to the flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String callbackId = "callbackId_example"; // String | The id of the queue to put the request in
String executionId = "executionId_example"; // String | The id to identify the execution
String body = "body_example"; // String | The data that is passed from the external party
try {
    String result = apiInstance.postFlowCallback(callbackId, executionId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#postFlowCallback");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callbackId** | **String**| The id of the queue to put the request in |
 **executionId** | **String**| The id to identify the execution | [optional]
 **body** | **String**| The data that is passed from the external party | [optional]

### Return type

**String**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="prepareImport"></a>
# **prepareImport**
> ImportInformation prepareImport(body)



Given an archive, produce some information that can be used to map items from the archive on items in the target environment

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
byte[] body = BINARY_DATA_HERE; // byte[] | The content of the archive
try {
    ImportInformation result = apiInstance.prepareImport(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#prepareImport");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**| The content of the archive | [optional]

### Return type

[**ImportInformation**](ImportInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="refreshConnector"></a>
# **refreshConnector**
> refreshConnector(connectorId)



Refresh the state of the connector

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
try {
    apiInstance.refreshConnector(connectorId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#refreshConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="restoreBackup"></a>
# **restoreBackup**
> restoreBackup(body)



Import the content from the given archive

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
byte[] body = BINARY_DATA_HERE; // byte[] | The content of the archive
try {
    apiInstance.restoreBackup(body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#restoreBackup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**| The content of the archive | [optional]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="runCleanup"></a>
# **runCleanup**
> List&lt;CleanupActionStatus&gt; runCleanup(action)



Run one or all cleanup processes now

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String action = "action_example"; // String | The cleanup action to run. When not specified, all actions are triggered
try {
    List<CleanupActionStatus> result = apiInstance.runCleanup(action);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#runCleanup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **String**| The cleanup action to run. When not specified, all actions are triggered | [optional]

### Return type

[**List&lt;CleanupActionStatus&gt;**](CleanupActionStatus.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="setDefaultLanguage"></a>
# **setDefaultLanguage**
> Language setDefaultLanguage(body)



Set the default language for the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Language body = new Language(); // Language | The result object for the language
try {
    Language result = apiInstance.setDefaultLanguage(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setDefaultLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Language**](Language.md)| The result object for the language | [optional]

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setDefaultPrinter"></a>
# **setDefaultPrinter**
> Printer setDefaultPrinter(body)



Set the default printer for the project

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
Printer body = new Printer(); // Printer | The result object for the printer
try {
    Printer result = apiInstance.setDefaultPrinter(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setDefaultPrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Printer**](Printer.md)| The result object for the printer | [optional]

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setSystemDefaultLanguage"></a>
# **setSystemDefaultLanguage**
> LanguageDefinition setSystemDefaultLanguage(body)



Set the default language for the system

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
LanguageDefinition body = new LanguageDefinition(); // LanguageDefinition | The result object for the language
try {
    LanguageDefinition result = apiInstance.setSystemDefaultLanguage(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setSystemDefaultLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LanguageDefinition**](LanguageDefinition.md)| The result object for the language | [optional]

### Return type

[**LanguageDefinition**](LanguageDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setupConnector"></a>
# **setupConnector**
> ConnectorStage setupConnector(connectorId)



Setup the connector - start

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
try {
    ConnectorStage result = apiInstance.setupConnector(connectorId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setupConnectorCancel"></a>
# **setupConnectorCancel**
> Connector setupConnectorCancel(connectorId, body)



Cancel the connector setup

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Object body = null; // Object | The model of the current step
try {
    Connector result = apiInstance.setupConnectorCancel(connectorId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnectorCancel");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **body** | **Object**| The model of the current step | [optional]

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setupConnectorCurrent"></a>
# **setupConnectorCurrent**
> ConnectorStage setupConnectorCurrent(connectorId)



Setup the connector - get the current step

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
try {
    ConnectorStage result = apiInstance.setupConnectorCurrent(connectorId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnectorCurrent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setupConnectorFinish"></a>
# **setupConnectorFinish**
> Connector setupConnectorFinish(connectorId, body)



Finish the connector setup

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Object body = null; // Object | The model of the current step
try {
    Connector result = apiInstance.setupConnectorFinish(connectorId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnectorFinish");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **body** | **Object**| The model of the current step | [optional]

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setupConnectorNext"></a>
# **setupConnectorNext**
> ConnectorStage setupConnectorNext(connectorId, body)



Setup the connector - go to the next step

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Object body = null; // Object | The model of the current step
try {
    ConnectorStage result = apiInstance.setupConnectorNext(connectorId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnectorNext");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **body** | **Object**| The model of the current step | [optional]

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="setupConnectorPrevious"></a>
# **setupConnectorPrevious**
> ConnectorStage setupConnectorPrevious(connectorId, body)



Setup the connector - go to the previous step

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Object body = null; // Object | The model of the current step
try {
    ConnectorStage result = apiInstance.setupConnectorPrevious(connectorId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#setupConnectorPrevious");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **body** | **Object**| The model of the current step | [optional]

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="syncExternalUsers"></a>
# **syncExternalUsers**
> SyncResult syncExternalUsers()



Syncs all users with the login connector

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
try {
    SyncResult result = apiInstance.syncExternalUsers();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#syncExternalUsers");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SyncResult**](SyncResult.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="testConnector"></a>
# **testConnector**
> OperationStatus testConnector(connectorId)



Test if the connection to the connector can be made successfully

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
try {
    OperationStatus result = apiInstance.testConnector(connectorId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#testConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |

### Return type

[**OperationStatus**](OperationStatus.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="testPrinter"></a>
# **testPrinter**
> testPrinter(printer)



Send a test document to the printer

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String printer = "printer_example"; // String | The id of the printer
try {
    apiInstance.testPrinter(printer);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#testPrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **String**| The id of the printer |

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateAsset"></a>
# **updateAsset**
> Asset updateAsset(assetId, body)



Update the asset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String assetId = "assetId_example"; // String | The id of the asset
Asset body = new Asset(); // Asset | The asset object with updated properties
try {
    Asset result = apiInstance.updateAsset(assetId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateAsset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **String**| The id of the asset |
 **body** | [**Asset**](Asset.md)| The asset object with updated properties | [optional]

### Return type

[**Asset**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateAssetContent"></a>
# **updateAssetContent**
> updateAssetContent(assetId, body)



Update the content of the asset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String assetId = "assetId_example"; // String | The id of the asset
byte[] body = BINARY_DATA_HERE; // byte[] | The content of the asset
try {
    apiInstance.updateAssetContent(assetId, body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateAssetContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **String**| The id of the asset |
 **body** | **byte[]**| The content of the asset | [optional]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateConnector"></a>
# **updateConnector**
> Connector updateConnector(connectorId, body)



Update the connector

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String connectorId = "connectorId_example"; // String | The id of the connector
Connector body = new Connector(); // Connector | The connector object with updated properties
try {
    Connector result = apiInstance.updateConnector(connectorId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateConnector");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **String**| The id of the connector |
 **body** | [**Connector**](Connector.md)| The connector object with updated properties | [optional]

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateData"></a>
# **updateData**
> Data updateData(dataId, body)



Update the data

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String dataId = "dataId_example"; // String | The id of the data
Data body = new Data(); // Data | The data object with updated properties
try {
    Data result = apiInstance.updateData(dataId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **String**| The id of the data |
 **body** | [**Data**](Data.md)| The data object with updated properties | [optional]

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateDataset"></a>
# **updateDataset**
> Dataset updateDataset(datasetId, body)



Update the dataset

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String datasetId = "datasetId_example"; // String | The id of the dataset
Dataset body = new Dataset(); // Dataset | The dataset object with updated properties
try {
    Dataset result = apiInstance.updateDataset(datasetId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateDataset");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **String**| The id of the dataset |
 **body** | [**Dataset**](Dataset.md)| The dataset object with updated properties | [optional]

### Return type

[**Dataset**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateFlow"></a>
# **updateFlow**
> Flow updateFlow(flow, body)



Update a single flow

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String flow = "flow_example"; // String | The id of the flow
Flow body = new Flow(); // Flow | The possible fields and their possible values
try {
    Flow result = apiInstance.updateFlow(flow, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateFlow");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **String**| The id of the flow |
 **body** | [**Flow**](Flow.md)| The possible fields and their possible values | [optional]

### Return type

[**Flow**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateLanguage"></a>
# **updateLanguage**
> Language updateLanguage(language, body)



Update a single language

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String language = "language_example"; // String | The id of the language
Language body = new Language(); // Language | The result object for the language
try {
    Language result = apiInstance.updateLanguage(language, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateLanguage");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **String**| The id of the language |
 **body** | [**Language**](Language.md)| The result object for the language | [optional]

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePrinter"></a>
# **updatePrinter**
> Printer updatePrinter(printer, body)



Update a single printer

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String printer = "printer_example"; // String | The id of the printer
Printer body = new Printer(); // Printer | The result object for the printer
try {
    Printer result = apiInstance.updatePrinter(printer, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updatePrinter");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **String**| The id of the printer |
 **body** | [**Printer**](Printer.md)| The result object for the printer | [optional]

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateSubSettings"></a>
# **updateSubSettings**
> Object updateSubSettings(settingsType, body)



Update settings of one type

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String settingsType = "settingsType_example"; // String | The type of the settings
Object body = null; // Object | The updated settings
try {
    Object result = apiInstance.updateSubSettings(settingsType, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateSubSettings");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **String**| The type of the settings |
 **body** | **Object**| The updated settings | [optional]

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateTagGroup"></a>
# **updateTagGroup**
> TagGroup updateTagGroup(tagGroupId, body)



Update the tag group

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String tagGroupId = "tagGroupId_example"; // String | The id of the tag group
TagGroup body = new TagGroup(); // TagGroup | The tag group object with updated properties
try {
    TagGroup result = apiInstance.updateTagGroup(tagGroupId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateTagGroup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **String**| The id of the tag group |
 **body** | [**TagGroup**](TagGroup.md)| The tag group object with updated properties | [optional]

### Return type

[**TagGroup**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateTemplate"></a>
# **updateTemplate**
> Template updateTemplate(templateId, body)



Update the template

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
Template body = new Template(); // Template | The template object with updated properties
try {
    Template result = apiInstance.updateTemplate(templateId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateTemplate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **body** | [**Template**](Template.md)| The template object with updated properties | [optional]

### Return type

[**Template**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="updateTemplateContent"></a>
# **updateTemplateContent**
> updateTemplateContent(templateId, lang, description, body)



Update the content of the template for the given language

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String templateId = "templateId_example"; // String | The id of the template
String lang = "lang_example"; // String | The id of the language that is supported by the project, default when none specified
String description = "description_example"; // String | The description of the changes made
byte[] body = BINARY_DATA_HERE; // byte[] | The content of the template
try {
    apiInstance.updateTemplateContent(templateId, lang, description, body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateTemplateContent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **String**| The id of the template |
 **lang** | **String**| The id of the language that is supported by the project, default when none specified | [optional]
 **description** | **String**| The description of the changes made | [optional]
 **body** | **byte[]**| The content of the template | [optional]

### Return type

null (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: Not defined

<a name="updateUser"></a>
# **updateUser**
> User updateUser(user, body)



Update a single user

### Example
```java
// Import classes:
//import xpertdoc.smartflows.client.ApiClient;
//import xpertdoc.smartflows.client.ApiException;
//import xpertdoc.smartflows.client.Configuration;
//import xpertdoc.smartflows.client.auth.*;
//import xpertdoc.smartflows.client.api.DefaultApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: xperido_auth
OAuth xperido_auth = (OAuth) defaultClient.getAuthentication("xperido_auth");
xperido_auth.setAccessToken("YOUR ACCESS TOKEN");

DefaultApi apiInstance = new DefaultApi();
String user = "user_example"; // String | The id of the user
User body = new User(); // User | The user properties to update
try {
    User result = apiInstance.updateUser(user, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#updateUser");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **String**| The id of the user |
 **body** | [**User**](User.md)| The user properties to update | [optional]

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

