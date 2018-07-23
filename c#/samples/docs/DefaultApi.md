# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAsset**](DefaultApi.md#addasset) | **POST** /assets | 
[**AuthenticateGet**](DefaultApi.md#authenticateget) | **GET** /authenticate | 
[**AuthenticateLoginPost**](DefaultApi.md#authenticateloginpost) | **POST** /authenticate/login | 
[**AuthenticateOauth2Post**](DefaultApi.md#authenticateoauth2post) | **POST** /authenticate/oauth2 | 
[**CancelFlowExecution**](DefaultApi.md#cancelflowexecution) | **DELETE** /flows/executions/{execution}/progress | 
[**ClearSubSettings**](DefaultApi.md#clearsubsettings) | **DELETE** /settings/{settingsType} | 
[**ContinueFlowExecution**](DefaultApi.md#continueflowexecution) | **POST** /flows/executions/{execution}/progress | 
[**CreateBackup**](DefaultApi.md#createbackup) | **POST** /system/backup | 
[**CreateConnector**](DefaultApi.md#createconnector) | **POST** /connectors | 
[**CreateDataset**](DefaultApi.md#createdataset) | **POST** /datasets | 
[**CreateDatasetData**](DefaultApi.md#createdatasetdata) | **POST** /datasets/{datasetId}/data | 
[**CreateDocument**](DefaultApi.md#createdocument) | **POST** /documents | 
[**CreateExport**](DefaultApi.md#createexport) | **POST** /system/export | 
[**CreateFlatExport**](DefaultApi.md#createflatexport) | **POST** /system/export/flat | 
[**CreateFlow**](DefaultApi.md#createflow) | **POST** /flows | 
[**CreateLanguage**](DefaultApi.md#createlanguage) | **POST** /languages | 
[**CreatePrinter**](DefaultApi.md#createprinter) | **POST** /printers | 
[**CreateTagGroup**](DefaultApi.md#createtaggroup) | **POST** /taggroups | 
[**CreateTemplate**](DefaultApi.md#createtemplate) | **POST** /templates | 
[**CreateUser**](DefaultApi.md#createuser) | **POST** /users | 
[**DeleteAsset**](DefaultApi.md#deleteasset) | **DELETE** /assets/{assetId} | 
[**DeleteConnector**](DefaultApi.md#deleteconnector) | **DELETE** /connectors/{connectorId} | 
[**DeleteData**](DefaultApi.md#deletedata) | **DELETE** /data/{dataId} | 
[**DeleteDataset**](DefaultApi.md#deletedataset) | **DELETE** /datasets/{datasetId} | 
[**DeleteFlow**](DefaultApi.md#deleteflow) | **DELETE** /flows/{flow} | 
[**DeleteLanguage**](DefaultApi.md#deletelanguage) | **DELETE** /languages/{language} | 
[**DeletePrinter**](DefaultApi.md#deleteprinter) | **DELETE** /printers/{printer} | 
[**DeleteTagGroup**](DefaultApi.md#deletetaggroup) | **DELETE** /taggroups/{tagGroupId} | 
[**DeleteTemplate**](DefaultApi.md#deletetemplate) | **DELETE** /templates/{templateId} | 
[**DeleteTemplateContent**](DefaultApi.md#deletetemplatecontent) | **DELETE** /templates/{templateId}/content | 
[**DeleteUser**](DefaultApi.md#deleteuser) | **DELETE** /users/{user} | 
[**ExecuteFlatImport**](DefaultApi.md#executeflatimport) | **POST** /system/import/flat | 
[**ExecuteFlow**](DefaultApi.md#executeflow) | **POST** /flows/executions | 
[**ExecuteImport**](DefaultApi.md#executeimport) | **POST** /system/import | 
[**ExistsData**](DefaultApi.md#existsdata) | **HEAD** /data/{dataId} | 
[**GetAllFlowExecutions**](DefaultApi.md#getallflowexecutions) | **GET** /flows/executions | 
[**GetAsset**](DefaultApi.md#getasset) | **GET** /assets/{assetId} | 
[**GetAssetContent**](DefaultApi.md#getassetcontent) | **GET** /assets/{assetId}/content | 
[**GetAssets**](DefaultApi.md#getassets) | **GET** /assets | 
[**GetConnector**](DefaultApi.md#getconnector) | **GET** /connectors/{connectorId} | 
[**GetConnectorType**](DefaultApi.md#getconnectortype) | **GET** /connectors/types/{connectorTypeId} | 
[**GetConnectorTypes**](DefaultApi.md#getconnectortypes) | **GET** /connectors/types | 
[**GetConnectors**](DefaultApi.md#getconnectors) | **GET** /connectors | 
[**GetCurrentUser**](DefaultApi.md#getcurrentuser) | **GET** /users/me | 
[**GetData**](DefaultApi.md#getdata) | **GET** /data/{dataId} | 
[**GetDataContent**](DefaultApi.md#getdatacontent) | **GET** /data/{dataId}/content | 
[**GetDataMetadata**](DefaultApi.md#getdatametadata) | **GET** /data/meta | 
[**GetDataPreview**](DefaultApi.md#getdatapreview) | **GET** /data/{dataId}/preview | 
[**GetDataset**](DefaultApi.md#getdataset) | **GET** /datasets/{datasetId} | 
[**GetDatasetDatas**](DefaultApi.md#getdatasetdatas) | **GET** /datasets/{datasetId}/data | 
[**GetDatasetEntityReferences**](DefaultApi.md#getdatasetentityreferences) | **GET** /datasets/{datasetId}/entityrefs | 
[**GetDatasetLayout**](DefaultApi.md#getdatasetlayout) | **POST** /datasets/layout | 
[**GetDatasets**](DefaultApi.md#getdatasets) | **GET** /datasets | 
[**GetDatasource**](DefaultApi.md#getdatasource) | **GET** /datasources/{datasourceId} | 
[**GetDatasourceEntityLayout**](DefaultApi.md#getdatasourceentitylayout) | **GET** /datasources/{datasourceId}/layout/{entityName} | 
[**GetDatasourceLayout**](DefaultApi.md#getdatasourcelayout) | **GET** /datasources/{datasourceId}/layout | 
[**GetDatasourceType**](DefaultApi.md#getdatasourcetype) | **GET** /datasources/types/{datasourceTypeId} | 
[**GetDatasourceTypes**](DefaultApi.md#getdatasourcetypes) | **GET** /datasources/types | 
[**GetDatasources**](DefaultApi.md#getdatasources) | **GET** /datasources | 
[**GetDefaultLanguage**](DefaultApi.md#getdefaultlanguage) | **GET** /languages/default | 
[**GetDefaultPrinter**](DefaultApi.md#getdefaultprinter) | **GET** /printers/default | 
[**GetDependencies**](DefaultApi.md#getdependencies) | **GET** /dependencies/{objectType}/{objectId} | 
[**GetDocument**](DefaultApi.md#getdocument) | **GET** /documents/{documentId} | 
[**GetDocumentContent**](DefaultApi.md#getdocumentcontent) | **GET** /documents/{documentId}/content | 
[**GetDocuments**](DefaultApi.md#getdocuments) | **GET** /documents | 
[**GetExpressionFunctions**](DefaultApi.md#getexpressionfunctions) | **GET** /system/expression/functions | 
[**GetExternalUsers**](DefaultApi.md#getexternalusers) | **GET** /users/external | 
[**GetFilteredAssets**](DefaultApi.md#getfilteredassets) | **POST** /assets/filter | 
[**GetFilteredConnectors**](DefaultApi.md#getfilteredconnectors) | **POST** /connectors/filter | 
[**GetFilteredDatasets**](DefaultApi.md#getfiltereddatasets) | **POST** /datasets/filter | 
[**GetFilteredDatasources**](DefaultApi.md#getfiltereddatasources) | **POST** /datasources/filter | 
[**GetFilteredDocuments**](DefaultApi.md#getfiltereddocuments) | **POST** /documents/filter | 
[**GetFilteredFlowExecutions**](DefaultApi.md#getfilteredflowexecutions) | **POST** /flows/executions/filter | 
[**GetFilteredPrinters**](DefaultApi.md#getfilteredprinters) | **POST** /printers/filter | 
[**GetFilteredTagGroups**](DefaultApi.md#getfilteredtaggroups) | **POST** /taggroups/filter | 
[**GetFilteredTemplates**](DefaultApi.md#getfilteredtemplates) | **POST** /templates/filter | 
[**GetFilteredUsers**](DefaultApi.md#getfilteredusers) | **POST** /users/filter | 
[**GetFlow**](DefaultApi.md#getflow) | **GET** /flows/{flow} | 
[**GetFlowContract**](DefaultApi.md#getflowcontract) | **POST** /flows/{flow}/contract | 
[**GetFlowExecution**](DefaultApi.md#getflowexecution) | **GET** /flows/executions/{execution} | 
[**GetFlowExecutionProgress**](DefaultApi.md#getflowexecutionprogress) | **GET** /flows/executions/{execution}/progress | 
[**GetFlowExecutionStatistics**](DefaultApi.md#getflowexecutionstatistics) | **POST** /flows/executions/statistics | 
[**GetFlowExecutions**](DefaultApi.md#getflowexecutions) | **GET** /flows/{flow}/executions | 
[**GetFlowSettings**](DefaultApi.md#getflowsettings) | **POST** /flows/steps/{step} | 
[**GetFlowStep**](DefaultApi.md#getflowstep) | **GET** /flows/steps/{step} | 
[**GetFlowSteps**](DefaultApi.md#getflowsteps) | **GET** /flows/steps | 
[**GetFlowThumbnail**](DefaultApi.md#getflowthumbnail) | **GET** /flows/{flow}/thumbnail | 
[**GetFlows**](DefaultApi.md#getflows) | **GET** /flows | 
[**GetFormattedValue**](DefaultApi.md#getformattedvalue) | **GET** /system/format | 
[**GetLanguage**](DefaultApi.md#getlanguage) | **GET** /languages/{language} | 
[**GetLanguages**](DefaultApi.md#getlanguages) | **GET** /languages | 
[**GetLicense**](DefaultApi.md#getlicense) | **GET** /system/license | 
[**GetPluginDatasets**](DefaultApi.md#getplugindatasets) | **GET** /datasets/plugin | 
[**GetPlugins**](DefaultApi.md#getplugins) | **GET** /plugins | 
[**GetPrinter**](DefaultApi.md#getprinter) | **GET** /printers/{printer} | 
[**GetPrinters**](DefaultApi.md#getprinters) | **GET** /printers | 
[**GetRoles**](DefaultApi.md#getroles) | **GET** /roles | 
[**GetSettings**](DefaultApi.md#getsettings) | **GET** /settings | 
[**GetSubSettings**](DefaultApi.md#getsubsettings) | **GET** /settings/{settingsType} | 
[**GetSupportedFeatures**](DefaultApi.md#getsupportedfeatures) | **GET** /system/features | 
[**GetSystemCurrencySymbols**](DefaultApi.md#getsystemcurrencysymbols) | **GET** /system/currencies | 
[**GetSystemDefaultLanguage**](DefaultApi.md#getsystemdefaultlanguage) | **GET** /system/languages/default | 
[**GetSystemInfo**](DefaultApi.md#getsysteminfo) | **GET** /system/info | 
[**GetSystemLanguages**](DefaultApi.md#getsystemlanguages) | **GET** /system/languages | 
[**GetSystemPrinter**](DefaultApi.md#getsystemprinter) | **GET** /system/printers/{printer} | 
[**GetSystemPrinters**](DefaultApi.md#getsystemprinters) | **GET** /system/printers | 
[**GetSystemTimeZones**](DefaultApi.md#getsystemtimezones) | **GET** /system/timeZones | 
[**GetTagGroup**](DefaultApi.md#gettaggroup) | **GET** /taggroups/{tagGroupId} | 
[**GetTagGroups**](DefaultApi.md#gettaggroups) | **GET** /taggroups | 
[**GetTemplate**](DefaultApi.md#gettemplate) | **GET** /templates/{templateId} | 
[**GetTemplateContent**](DefaultApi.md#gettemplatecontent) | **GET** /templates/{templateId}/content | 
[**GetTemplateHistory**](DefaultApi.md#gettemplatehistory) | **GET** /templates/{templateId}/history | 
[**GetTemplateLanguage**](DefaultApi.md#gettemplatelanguage) | **GET** /templates/{templateId}/lang/{lang} | 
[**GetTemplateSchema**](DefaultApi.md#gettemplateschema) | **GET** /templates/{templateId}/schema | 
[**GetTemplates**](DefaultApi.md#gettemplates) | **GET** /templates | 
[**GetUser**](DefaultApi.md#getuser) | **GET** /users/{user} | 
[**GetUsers**](DefaultApi.md#getusers) | **GET** /users | 
[**InstallLicense**](DefaultApi.md#installlicense) | **POST** /system/license | 
[**ParseExpression**](DefaultApi.md#parseexpression) | **PUT** /system/expression | 
[**PostFlowCallback**](DefaultApi.md#postflowcallback) | **POST** /flows/callback/{callbackId} | 
[**PrepareImport**](DefaultApi.md#prepareimport) | **POST** /system/import/prepare | 
[**RefreshConnector**](DefaultApi.md#refreshconnector) | **POST** /connectors/{connectorId}/refresh | 
[**RestoreBackup**](DefaultApi.md#restorebackup) | **POST** /system/backup/restore | 
[**RunCleanup**](DefaultApi.md#runcleanup) | **GET** /system/cleanup/run | 
[**SetDefaultLanguage**](DefaultApi.md#setdefaultlanguage) | **PUT** /languages/default | 
[**SetDefaultPrinter**](DefaultApi.md#setdefaultprinter) | **PUT** /printers/default | 
[**SetSystemDefaultLanguage**](DefaultApi.md#setsystemdefaultlanguage) | **PUT** /system/languages/default | 
[**SetupConnector**](DefaultApi.md#setupconnector) | **POST** /connectors/{connectorId}/setup | 
[**SetupConnectorCancel**](DefaultApi.md#setupconnectorcancel) | **POST** /connectors/{connectorId}/setup/cancel | 
[**SetupConnectorCurrent**](DefaultApi.md#setupconnectorcurrent) | **GET** /connectors/{connectorId}/setup/current | 
[**SetupConnectorFinish**](DefaultApi.md#setupconnectorfinish) | **POST** /connectors/{connectorId}/setup/finish | 
[**SetupConnectorNext**](DefaultApi.md#setupconnectornext) | **POST** /connectors/{connectorId}/setup/next | 
[**SetupConnectorPrevious**](DefaultApi.md#setupconnectorprevious) | **POST** /connectors/{connectorId}/setup/previous | 
[**SyncExternalUsers**](DefaultApi.md#syncexternalusers) | **POST** /users/external | 
[**TestConnector**](DefaultApi.md#testconnector) | **GET** /connectors/{connectorId}/test | 
[**TestPrinter**](DefaultApi.md#testprinter) | **POST** /printers/{printer}/test | 
[**UpdateAsset**](DefaultApi.md#updateasset) | **PUT** /assets/{assetId} | 
[**UpdateAssetContent**](DefaultApi.md#updateassetcontent) | **PUT** /assets/{assetId}/content | 
[**UpdateConnector**](DefaultApi.md#updateconnector) | **PUT** /connectors/{connectorId} | 
[**UpdateData**](DefaultApi.md#updatedata) | **PUT** /data/{dataId} | 
[**UpdateDataset**](DefaultApi.md#updatedataset) | **PUT** /datasets/{datasetId} | 
[**UpdateFlow**](DefaultApi.md#updateflow) | **PUT** /flows/{flow} | 
[**UpdateLanguage**](DefaultApi.md#updatelanguage) | **PUT** /languages/{language} | 
[**UpdatePrinter**](DefaultApi.md#updateprinter) | **PUT** /printers/{printer} | 
[**UpdateSubSettings**](DefaultApi.md#updatesubsettings) | **PUT** /settings/{settingsType} | 
[**UpdateTagGroup**](DefaultApi.md#updatetaggroup) | **PUT** /taggroups/{tagGroupId} | 
[**UpdateTemplate**](DefaultApi.md#updatetemplate) | **PUT** /templates/{templateId} | 
[**UpdateTemplateContent**](DefaultApi.md#updatetemplatecontent) | **PUT** /templates/{templateId}/content | 
[**UpdateUser**](DefaultApi.md#updateuser) | **PUT** /users/{user} | 


<a name="addasset"></a>
# **AddAsset**
> Asset AddAsset (BinaryDataHolder body = null)



Add a `assets` object to the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAssetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new BinaryDataHolder(); // BinaryDataHolder |  (optional) 

            try
            {
                Asset result = apiInstance.AddAsset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddAsset: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticateget"></a>
# **AuthenticateGet**
> AuthenticationInfo AuthenticateGet ()



Get info about the login methods

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthenticateGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                AuthenticationInfo result = apiInstance.AuthenticateGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthenticateGet: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticateloginpost"></a>
# **AuthenticateLoginPost**
> Authentication AuthenticateLoginPost (Login body = null)



Authenticate a user using user/password information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthenticateLoginPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Login(); // Login | The login information (optional) 

            try
            {
                Authentication result = apiInstance.AuthenticateLoginPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthenticateLoginPost: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticateoauth2post"></a>
# **AuthenticateOauth2Post**
> Authentication AuthenticateOauth2Post (Oauth2Parameters body = null)



Authenticate a user using OAuth2 authorization code

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthenticateOauth2PostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new Oauth2Parameters(); // Oauth2Parameters | The authorization code (optional) 

            try
            {
                Authentication result = apiInstance.AuthenticateOauth2Post(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AuthenticateOauth2Post: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancelflowexecution"></a>
# **CancelFlowExecution**
> FlowExecutionProgress CancelFlowExecution (string execution)



Cancel an existing execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelFlowExecutionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var execution = execution_example;  // string | The id of the flow execution

            try
            {
                FlowExecutionProgress result = apiInstance.CancelFlowExecution(execution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelFlowExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **string**| The id of the flow execution | 

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clearsubsettings"></a>
# **ClearSubSettings**
> void ClearSubSettings (string settingsType)



Clear all settings and revert to default settings for one settings type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ClearSubSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var settingsType = settingsType_example;  // string | The type of the settings

            try
            {
                apiInstance.ClearSubSettings(settingsType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ClearSubSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **string**| The type of the settings | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="continueflowexecution"></a>
# **ContinueFlowExecution**
> FlowExecutionProgress ContinueFlowExecution (string execution, Object body = null)



Continue an existing execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContinueFlowExecutionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var execution = execution_example;  // string | The id of the flow execution
            var body = ;  // Object | The object responding to the schema of the executionProgress object (optional) 

            try
            {
                FlowExecutionProgress result = apiInstance.ContinueFlowExecution(execution, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ContinueFlowExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **string**| The id of the flow execution | 
 **body** | **Object**| The object responding to the schema of the executionProgress object | [optional] 

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createbackup"></a>
# **CreateBackup**
> System.IO.Stream CreateBackup (bool? includeHistory = null, bool? includeSensitiveData = null)



Create a backup of all objects in the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateBackupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var includeHistory = true;  // bool? | Whether to include the complete history of templates (optional)  (default to false)
            var includeSensitiveData = true;  // bool? | Whether to include possible sensitive data (passwords from connectors e.a.) (optional)  (default to false)

            try
            {
                System.IO.Stream result = apiInstance.CreateBackup(includeHistory, includeSensitiveData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateBackup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeHistory** | **bool?**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **bool?**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to false]

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createconnector"></a>
# **CreateConnector**
> Connector CreateConnector (Connector body = null)



Add a `Connector` object to the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Connector(); // Connector | The connector to add (optional) 

            try
            {
                Connector result = apiInstance.CreateConnector(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateConnector: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdataset"></a>
# **CreateDataset**
> Dataset CreateDataset (Dataset body = null)



Add a `Dataset` object to the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDatasetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Dataset(); // Dataset |  (optional) 

            try
            {
                Dataset result = apiInstance.CreateDataset(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateDataset: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdatasetdata"></a>
# **CreateDatasetData**
> Data CreateDatasetData (string datasetId, Data body = null)



Add data that conforms to a dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDatasetDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset
            var body = new Data(); // Data | The data object to create (optional) 

            try
            {
                Data result = apiInstance.CreateDatasetData(datasetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateDatasetData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 
 **body** | [**Data**](Data.md)| The data object to create | [optional] 

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdocument"></a>
# **CreateDocument**
> List<GeneratedDocument> CreateDocument (DocGenSettings body = null)



Create preview of given template(ref) with given data(ref)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new DocGenSettings(); // DocGenSettings | The parameters to create the document with (optional) 

            try
            {
                List&lt;GeneratedDocument&gt; result = apiInstance.CreateDocument(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DocGenSettings**](DocGenSettings.md)| The parameters to create the document with | [optional] 

### Return type

[**List<GeneratedDocument>**](GeneratedDocument.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createexport"></a>
# **CreateExport**
> System.IO.Stream CreateExport (ArchiveRequest body = null, bool? includeHistory = null, bool? includeSensitiveData = null)



Create an export file for the given request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new ArchiveRequest(); // ArchiveRequest | The settings for the archive to create (optional) 
            var includeHistory = true;  // bool? | Whether to include the complete history of templates (optional)  (default to false)
            var includeSensitiveData = true;  // bool? | Whether to include possible sensitive data (passwords from connectors e.a.) (optional)  (default to false)

            try
            {
                System.IO.Stream result = apiInstance.CreateExport(body, includeHistory, includeSensitiveData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ArchiveRequest**](ArchiveRequest.md)| The settings for the archive to create | [optional] 
 **includeHistory** | **bool?**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **bool?**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to false]

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createflatexport"></a>
# **CreateFlatExport**
> FlatArchive CreateFlatExport (ArchiveRequest body = null, bool? includeHistory = null, bool? includeSensitiveData = null)



Create an export for the given request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFlatExportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new ArchiveRequest(); // ArchiveRequest | The settings for the archive to create (optional) 
            var includeHistory = true;  // bool? | Whether to include the complete history of templates (optional)  (default to false)
            var includeSensitiveData = true;  // bool? | Whether to include possible sensitive data (passwords from connectors e.a.) (optional)  (default to false)

            try
            {
                FlatArchive result = apiInstance.CreateFlatExport(body, includeHistory, includeSensitiveData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFlatExport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ArchiveRequest**](ArchiveRequest.md)| The settings for the archive to create | [optional] 
 **includeHistory** | **bool?**| Whether to include the complete history of templates | [optional] [default to false]
 **includeSensitiveData** | **bool?**| Whether to include possible sensitive data (passwords from connectors e.a.) | [optional] [default to false]

### Return type

[**FlatArchive**](FlatArchive.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createflow"></a>
# **CreateFlow**
> Flow CreateFlow (Flow body = null)



Add a new flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFlowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Flow(); // Flow | The possible fields and their possible values (optional) 

            try
            {
                Flow result = apiInstance.CreateFlow(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateFlow: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createlanguage"></a>
# **CreateLanguage**
> Language CreateLanguage (Language body = null)



Add a new language that is supported

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Language(); // Language | The settings for the language to create (optional) 

            try
            {
                Language result = apiInstance.CreateLanguage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateLanguage: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createprinter"></a>
# **CreatePrinter**
> Printer CreatePrinter (Printer body = null)



Add a new printer that can be used to print documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Printer(); // Printer | The settings for the printer to create (optional) 

            try
            {
                Printer result = apiInstance.CreatePrinter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreatePrinter: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaggroup"></a>
# **CreateTagGroup**
> TagGroup CreateTagGroup (TagGroup body = null)



Add a tagGroup object to the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTagGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new TagGroup(); // TagGroup |  (optional) 

            try
            {
                TagGroup result = apiInstance.CreateTagGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateTagGroup: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplate"></a>
# **CreateTemplate**
> Template CreateTemplate (Template body = null)



Add a `templates` object to the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Template(); // Template |  (optional) 

            try
            {
                Template result = apiInstance.CreateTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateTemplate: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> User CreateUser (User body = null)



Add a new user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new User(); // User | The settings for the user to create (optional) 

            try
            {
                User result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateUser: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (string assetId, bool? deleteInbound = null)



Remove a single asset object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var assetId = assetId_example;  // string | The id of the asset
            var deleteInbound = true;  // bool? | When true, all items linked to this asset will also be deleted. When false, an error is returned when there is some link to this asset (optional)  (default to false)

            try
            {
                apiInstance.DeleteAsset(assetId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| The id of the asset | 
 **deleteInbound** | **bool?**| When true, all items linked to this asset will also be deleted. When false, an error is returned when there is some link to this asset | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconnector"></a>
# **DeleteConnector**
> void DeleteConnector (string connectorId, bool? deleteInbound = null)



Remove a single connector object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var deleteInbound = true;  // bool? | When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this connector (optional)  (default to false)

            try
            {
                apiInstance.DeleteConnector(connectorId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **deleteInbound** | **bool?**| When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this connector | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedata"></a>
# **DeleteData**
> void DeleteData (string dataId, bool? deleteInbound = null)



Remove a single data object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data
            var deleteInbound = true;  // bool? | When true, all items linked to this data will also be deleted. When false, an error is returned when there is some link to this data (optional)  (default to false)

            try
            {
                apiInstance.DeleteData(dataId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data | 
 **deleteInbound** | **bool?**| When true, all items linked to this data will also be deleted. When false, an error is returned when there is some link to this data | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedataset"></a>
# **DeleteDataset**
> void DeleteDataset (string datasetId, bool? deleteInbound = null)



Remove a single dataset object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDatasetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset
            var deleteInbound = true;  // bool? | When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset (optional)  (default to false)

            try
            {
                apiInstance.DeleteDataset(datasetId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteDataset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 
 **deleteInbound** | **bool?**| When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteflow"></a>
# **DeleteFlow**
> void DeleteFlow (string flow)



Remove a single flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFlowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The id of the flow

            try
            {
                apiInstance.DeleteFlow(flow);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The id of the flow | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelanguage"></a>
# **DeleteLanguage**
> void DeleteLanguage (string language, bool? force = null, bool? deleteInbound = null)



Remove a single language. You cannot delete the default language unless it is the last one and force is set to true

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var language = language_example;  // string | The id of the language
            var force = true;  // bool? | true if you want to delete the last (and by definition then default) language in the project (optional)  (default to false)
            var deleteInbound = true;  // bool? | When true, all items linked to this language will also be deleted. When false, an error is returned when there is some link to this language (optional)  (default to false)

            try
            {
                apiInstance.DeleteLanguage(language, force, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| The id of the language | 
 **force** | **bool?**| true if you want to delete the last (and by definition then default) language in the project | [optional] [default to false]
 **deleteInbound** | **bool?**| When true, all items linked to this language will also be deleted. When false, an error is returned when there is some link to this language | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteprinter"></a>
# **DeletePrinter**
> void DeletePrinter (string printer, bool? force = null, bool? deleteInbound = null)



Remove a single printer. You cannot delete the default printer unless it is the last one and force is set to true

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var printer = printer_example;  // string | The id of the printer
            var force = true;  // bool? | true if you want to delete the last (and by definition then default) printer in the project (optional)  (default to false)
            var deleteInbound = true;  // bool? | When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset (optional)  (default to false)

            try
            {
                apiInstance.DeletePrinter(printer, force, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeletePrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **string**| The id of the printer | 
 **force** | **bool?**| true if you want to delete the last (and by definition then default) printer in the project | [optional] [default to false]
 **deleteInbound** | **bool?**| When true, all items linked to this dataset will also be deleted. When false, an error is returned when there is some link to this dataset | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaggroup"></a>
# **DeleteTagGroup**
> void DeleteTagGroup (string tagGroupId, bool? deleteInbound = null)



Remove a single tag group object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTagGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var tagGroupId = tagGroupId_example;  // string | The id of the tag group
            var deleteInbound = true;  // bool? | When true, all tags linked to this tag group will also be deleted. When false, an error is returned when there is some link to this tag group (optional)  (default to false)

            try
            {
                apiInstance.DeleteTagGroup(tagGroupId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTagGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **string**| The id of the tag group | 
 **deleteInbound** | **bool?**| When true, all tags linked to this tag group will also be deleted. When false, an error is returned when there is some link to this tag group | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplate"></a>
# **DeleteTemplate**
> void DeleteTemplate (string templateId, bool? deleteInbound = null)



Remove a single template object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var deleteInbound = true;  // bool? | When true, all items linked to this template will also be deleted. When false, an error is returned when there is some link to this template (optional)  (default to false)

            try
            {
                apiInstance.DeleteTemplate(templateId, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **deleteInbound** | **bool?**| When true, all items linked to this template will also be deleted. When false, an error is returned when there is some link to this template | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplatecontent"></a>
# **DeleteTemplateContent**
> void DeleteTemplateContent (string templateId, string lang = null, bool? deleteInbound = null)



Remove the content for the given language of the given template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTemplateContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var lang = lang_example;  // string | The id of the language that is supported by the project, default when none specified (optional) 
            var deleteInbound = true;  // bool? | When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this standard template (optional)  (default to false)

            try
            {
                apiInstance.DeleteTemplateContent(templateId, lang, deleteInbound);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteTemplateContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **lang** | **string**| The id of the language that is supported by the project, default when none specified | [optional] 
 **deleteInbound** | **bool?**| When true, all items linked to this connector will also be deleted. When false, an error is returned when there is some link to this standard template | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string user, bool? force = null)



Remove a single user. You cannot delete the last admin user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var user = user_example;  // string | The id of the user
            var force = true;  // bool? | true if you want to delete the last admin user (optional)  (default to false)

            try
            {
                apiInstance.DeleteUser(user, force);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**| The id of the user | 
 **force** | **bool?**| true if you want to delete the last admin user | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeflatimport"></a>
# **ExecuteFlatImport**
> void ExecuteFlatImport (FlatArchive body = null)



Import the content from the given archive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteFlatImportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new FlatArchive(); // FlatArchive | The flat archive content (optional) 

            try
            {
                apiInstance.ExecuteFlatImport(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExecuteFlatImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlatArchive**](FlatArchive.md)| The flat archive content | [optional] 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeflow"></a>
# **ExecuteFlow**
> FlowExecutionProgress ExecuteFlow (string flowId = null, string datasetId = null, Object body = null)



Execute a flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteFlowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flowId = flowId_example;  // string | The id of the flow. (optional) 
            var datasetId = datasetId_example;  // string | The id of the dataset the flow input conforms to. Optional if flowId is present or no data is sent. (optional) 
            var body = ;  // Object | The input object for the flow (optional) 

            try
            {
                FlowExecutionProgress result = apiInstance.ExecuteFlow(flowId, datasetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExecuteFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flowId** | **string**| The id of the flow. | [optional] 
 **datasetId** | **string**| The id of the dataset the flow input conforms to. Optional if flowId is present or no data is sent. | [optional] 
 **body** | **Object**| The input object for the flow | [optional] 

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executeimport"></a>
# **ExecuteImport**
> void ExecuteImport (RestoreContext body = null)



Import the content from the given archive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteImportExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new RestoreContext(); // RestoreContext | The content of the archive with mappings for the unresolved entities (optional) 

            try
            {
                apiInstance.ExecuteImport(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExecuteImport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RestoreContext**](RestoreContext.md)| The content of the archive with mappings for the unresolved entities | [optional] 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="existsdata"></a>
# **ExistsData**
> void ExistsData (string dataId)



Check whether the data with the given id exists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExistsDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data as returned by the dataset data endpoint

            try
            {
                apiInstance.ExistsData(dataId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExistsData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data as returned by the dataset data endpoint | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallflowexecutions"></a>
# **GetAllFlowExecutions**
> List<FlowExecution> GetAllFlowExecutions (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all executions for all flows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAllFlowExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;FlowExecution&gt; result = apiInstance.GetAllFlowExecutions(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAllFlowExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<FlowExecution>**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getasset"></a>
# **GetAsset**
> Asset GetAsset (string assetId, bool? includeContent = null)



Retrieve a single asset object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var assetId = assetId_example;  // string | The id of the asset
            var includeContent = true;  // bool? | true to return content with the asset (optional)  (default to false)

            try
            {
                Asset result = apiInstance.GetAsset(assetId, includeContent);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| The id of the asset | 
 **includeContent** | **bool?**| true to return content with the asset | [optional] [default to false]

### Return type

[**Asset**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetcontent"></a>
# **GetAssetContent**
> void GetAssetContent (string assetId)



Return the content of the asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var assetId = assetId_example;  // string | The id of the asset

            try
            {
                apiInstance.GetAssetContent(assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAssetContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| The id of the asset | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octetstream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassets"></a>
# **GetAssets**
> List<Asset> GetAssets (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all assets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAssetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Asset&gt; result = apiInstance.GetAssets(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Asset>**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnector"></a>
# **GetConnector**
> Connector GetConnector (string connectorId)



Retrieve a single connector object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector

            try
            {
                Connector result = apiInstance.GetConnector(connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnectortype"></a>
# **GetConnectorType**
> ConnectorType GetConnectorType (string connectorTypeId)



Retrieve a single connectorType object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectorTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorTypeId = connectorTypeId_example;  // string | The id of the connector type

            try
            {
                ConnectorType result = apiInstance.GetConnectorType(connectorTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetConnectorType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorTypeId** | **string**| The id of the connector type | 

### Return type

[**ConnectorType**](ConnectorType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnectortypes"></a>
# **GetConnectorTypes**
> List<ConnectorType> GetConnectorTypes ()



Gets all `ConnectorType` objects for this project.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectorTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;ConnectorType&gt; result = apiInstance.GetConnectorTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetConnectorTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ConnectorType>**](ConnectorType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconnectors"></a>
# **GetConnectors**
> List<Connector> GetConnectors (int? page = null, int? size = null, string sort = null, string filter = null)



Gets all `Connector` objects for this project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetConnectorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Connector&gt; result = apiInstance.GetConnectors(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetConnectors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Connector>**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentuser"></a>
# **GetCurrentUser**
> User GetCurrentUser ()



Gets the current user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCurrentUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                User result = apiInstance.GetCurrentUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCurrentUser: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdata"></a>
# **GetData**
> Data GetData (string dataId)



Retrieve information about previously added data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data as returned by the dataset data endpoint

            try
            {
                Data result = apiInstance.GetData(dataId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data as returned by the dataset data endpoint | 

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatacontent"></a>
# **GetDataContent**
> System.IO.Stream GetDataContent (string dataId)



Retrieve the actual data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data as returned by the dataset data endpoint

            try
            {
                System.IO.Stream result = apiInstance.GetDataContent(dataId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDataContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data as returned by the dataset data endpoint | 

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatametadata"></a>
# **GetDataMetadata**
> System.IO.Stream GetDataMetadata (string templateName = null, string projectName = null, string creator = null)



Retrieve a sample for the metadata used when generating documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataMetadataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateName = templateName_example;  // string | The name of the template to use (optional) 
            var projectName = projectName_example;  // string | The name of the project to use (optional) 
            var creator = creator_example;  // string | The name of the creator to use (optional) 

            try
            {
                System.IO.Stream result = apiInstance.GetDataMetadata(templateName, projectName, creator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDataMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateName** | **string**| The name of the template to use | [optional] 
 **projectName** | **string**| The name of the project to use | [optional] 
 **creator** | **string**| The name of the creator to use | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatapreview"></a>
# **GetDataPreview**
> System.IO.Stream GetDataPreview (string dataId)



Retrieve the data as sent to the document preview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDataPreviewExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data as returned by the dataset data endpoint

            try
            {
                System.IO.Stream result = apiInstance.GetDataPreview(dataId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDataPreview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data as returned by the dataset data endpoint | 

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataset"></a>
# **GetDataset**
> Dataset GetDataset (string datasetId)



Retrieve a single dataset object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset

            try
            {
                Dataset result = apiInstance.GetDataset(datasetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDataset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 

### Return type

[**Dataset**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetdatas"></a>
# **GetDatasetDatas**
> List<Data> GetDatasetDatas (string datasetId, int? page = null, int? size = null, string sort = null, string filter = null)



Retrieve all datas that are linked to the given dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasetDatasExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (dataset cannot be specified) (optional) 

            try
            {
                List&lt;Data&gt; result = apiInstance.GetDatasetDatas(datasetId, page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasetDatas: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter (dataset cannot be specified) | [optional] 

### Return type

[**List<Data>**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetentityreferences"></a>
# **GetDatasetEntityReferences**
> List<IdWithName> GetDatasetEntityReferences (string datasetId, int? page = null, int? size = null, string sort = null, string filter = null)



Retrieves entity references to the primary entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasetEntityReferencesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;IdWithName&gt; result = apiInstance.GetDatasetEntityReferences(datasetId, page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasetEntityReferences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<IdWithName>**](IdWithName.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetlayout"></a>
# **GetDatasetLayout**
> List<EntityDefinition> GetDatasetLayout (Dataset body = null, bool? primaryOnly = null)



Get a list of available entities in the given dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasetLayoutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Dataset(); // Dataset |  (optional) 
            var primaryOnly = true;  // bool? | Return only the entities that can be primary entities when set to true (optional)  (default to false)

            try
            {
                List&lt;EntityDefinition&gt; result = apiInstance.GetDatasetLayout(body, primaryOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasetLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dataset**](Dataset.md)|  | [optional] 
 **primaryOnly** | **bool?**| Return only the entities that can be primary entities when set to true | [optional] [default to false]

### Return type

[**List<EntityDefinition>**](EntityDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasets"></a>
# **GetDatasets**
> List<Dataset> GetDatasets (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all datasets

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Dataset&gt; result = apiInstance.GetDatasets(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Dataset>**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasource"></a>
# **GetDatasource**
> Datasource GetDatasource (string datasourceId)



Gets all `Datasource` objects for this project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourceExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasourceId = datasourceId_example;  // string | The id of the datasource

            try
            {
                Datasource result = apiInstance.GetDatasource(datasourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **string**| The id of the datasource | 

### Return type

[**Datasource**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourceentitylayout"></a>
# **GetDatasourceEntityLayout**
> EntityDefinition GetDatasourceEntityLayout (string datasourceId, string entityName)



Returns all the fields and relations for the entity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourceEntityLayoutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasourceId = datasourceId_example;  // string | The id of the datasource
            var entityName = entityName_example;  // string | The name of the entity

            try
            {
                EntityDefinition result = apiInstance.GetDatasourceEntityLayout(datasourceId, entityName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasourceEntityLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **string**| The id of the datasource | 
 **entityName** | **string**| The name of the entity | 

### Return type

[**EntityDefinition**](EntityDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourcelayout"></a>
# **GetDatasourceLayout**
> DatasourceLayout GetDatasourceLayout (string datasourceId, bool? full = null)



Returns all the fields and relations that are available in the datasource

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourceLayoutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasourceId = datasourceId_example;  // string | The id of the datasource
            var full = true;  // bool? | True to return the entire layout at once, false to return only the entity information. Defaults to datasource default. (optional) 

            try
            {
                DatasourceLayout result = apiInstance.GetDatasourceLayout(datasourceId, full);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasourceLayout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceId** | **string**| The id of the datasource | 
 **full** | **bool?**| True to return the entire layout at once, false to return only the entity information. Defaults to datasource default. | [optional] 

### Return type

[**DatasourceLayout**](DatasourceLayout.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourcetype"></a>
# **GetDatasourceType**
> DatasourceType GetDatasourceType (string datasourceTypeId)



Retrieve a single datasourcetype object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourceTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasourceTypeId = datasourceTypeId_example;  // string | The id of the datasource type

            try
            {
                DatasourceType result = apiInstance.GetDatasourceType(datasourceTypeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasourceType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasourceTypeId** | **string**| The id of the datasource type | 

### Return type

[**DatasourceType**](DatasourceType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourcetypes"></a>
# **GetDatasourceTypes**
> List<DatasourceType> GetDatasourceTypes ()



Gets all `DatasourceType` objects for this project.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourceTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;DatasourceType&gt; result = apiInstance.GetDatasourceTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasourceTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DatasourceType>**](DatasourceType.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasources"></a>
# **GetDatasources**
> List<Datasource> GetDatasources (int? page = null, int? size = null, string sort = null, string filter = null)



Gets all `Datasource` objects for this project. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDatasourcesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Datasource&gt; result = apiInstance.GetDatasources(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDatasources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Datasource>**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultlanguage"></a>
# **GetDefaultLanguage**
> Language GetDefaultLanguage ()



Get the default language for the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                Language result = apiInstance.GetDefaultLanguage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDefaultLanguage: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdefaultprinter"></a>
# **GetDefaultPrinter**
> Printer GetDefaultPrinter ()



Get the default printer for the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDefaultPrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                Printer result = apiInstance.GetDefaultPrinter();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDefaultPrinter: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdependencies"></a>
# **GetDependencies**
> DependencyTree GetDependencies (string objectType, string objectId, string direction = null, string depth = null)



Get the dependencies of the object with the given id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDependenciesExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var objectType = objectType_example;  // string | The type of the object to get the dependencies of (definitions/objectType)
            var objectId = objectId_example;  // string | The id of the object to get the dependencies of
            var direction = direction_example;  // string | Whether the inbound or outbound relations or both are requested (optional)  (default to inbound)
            var depth = depth_example;  // string | Whether only the direct relations or all the transitive relations are requested (optional)  (default to direct)

            try
            {
                DependencyTree result = apiInstance.GetDependencies(objectType, objectId, direction, depth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDependencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectType** | **string**| The type of the object to get the dependencies of (definitions/objectType) | 
 **objectId** | **string**| The id of the object to get the dependencies of | 
 **direction** | **string**| Whether the inbound or outbound relations or both are requested | [optional] [default to inbound]
 **depth** | **string**| Whether only the direct relations or all the transitive relations are requested | [optional] [default to direct]

### Return type

[**DependencyTree**](DependencyTree.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocument"></a>
# **GetDocument**
> Document GetDocument (string documentId)



Retrieve a single document object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var documentId = documentId_example;  // string | The id of the document

            try
            {
                Document result = apiInstance.GetDocument(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| The id of the document | 

### Return type

[**Document**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocumentcontent"></a>
# **GetDocumentContent**
> void GetDocumentContent (string documentId)



Return the content of the document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var documentId = documentId_example;  // string | The id of the document

            try
            {
                apiInstance.GetDocumentContent(documentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDocumentContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| The id of the document | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.openxmlformats-officedocument.wordprocessingml.document

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> List<Document> GetDocuments (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Document&gt; result = apiInstance.GetDocuments(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Document>**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexpressionfunctions"></a>
# **GetExpressionFunctions**
> List<ExpressionFunction> GetExpressionFunctions (int? page = null, int? size = null, string sort = null, string filter = null)



List all the supported template expression functions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExpressionFunctionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;ExpressionFunction&gt; result = apiInstance.GetExpressionFunctions(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetExpressionFunctions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<ExpressionFunction>**](ExpressionFunction.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexternalusers"></a>
# **GetExternalUsers**
> List<User> GetExternalUsers (int? page = null, int? size = null, string sort = null, string filter = null)



Retrieves users exposed by the login connector

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExternalUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;User&gt; result = apiInstance.GetExternalUsers(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetExternalUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredassets"></a>
# **GetFilteredAssets**
> List<Asset> GetFilteredAssets (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all assets using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredAssetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Asset&gt; result = apiInstance.GetFilteredAssets(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Asset>**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredconnectors"></a>
# **GetFilteredConnectors**
> List<Connector> GetFilteredConnectors (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Gets all `Connector` objects for this project using a complex filter. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredConnectorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Connector&gt; result = apiInstance.GetFilteredConnectors(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredConnectors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Connector>**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfiltereddatasets"></a>
# **GetFilteredDatasets**
> List<Dataset> GetFilteredDatasets (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all datasets using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredDatasetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Dataset&gt; result = apiInstance.GetFilteredDatasets(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredDatasets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Dataset>**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfiltereddatasources"></a>
# **GetFilteredDatasources**
> List<Datasource> GetFilteredDatasources (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Gets all `Datasource` objects for this project using a complex filter 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredDatasourcesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Datasource&gt; result = apiInstance.GetFilteredDatasources(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredDatasources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Datasource>**](Datasource.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfiltereddocuments"></a>
# **GetFilteredDocuments**
> List<Document> GetFilteredDocuments (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all documents using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredDocumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Document&gt; result = apiInstance.GetFilteredDocuments(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Document>**](Document.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredflowexecutions"></a>
# **GetFilteredFlowExecutions**
> List<FlowExecution> GetFilteredFlowExecutions (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all executions for all flows, by a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredFlowExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;FlowExecution&gt; result = apiInstance.GetFilteredFlowExecutions(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredFlowExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<FlowExecution>**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredprinters"></a>
# **GetFilteredPrinters**
> List<Printer> GetFilteredPrinters (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Lists all printers using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredPrintersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Printer&gt; result = apiInstance.GetFilteredPrinters(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredPrinters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Printer>**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredtaggroups"></a>
# **GetFilteredTagGroups**
> List<TagGroup> GetFilteredTagGroups (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all tag groups using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredTagGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;TagGroup&gt; result = apiInstance.GetFilteredTagGroups(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredTagGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<TagGroup>**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredtemplates"></a>
# **GetFilteredTemplates**
> List<Template> GetFilteredTemplates (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Returns all templates using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredTemplatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;Template&gt; result = apiInstance.GetFilteredTemplates(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilteredusers"></a>
# **GetFilteredUsers**
> List<User> GetFilteredUsers (int? page = null, int? size = null, string sort = null, FilterGroupNode filter = null)



Lists all users using a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFilteredUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                List&lt;User&gt; result = apiInstance.GetFilteredUsers(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFilteredUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflow"></a>
# **GetFlow**
> Flow GetFlow (string flow)



Get a single flow from the server

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The path property of the flow

            try
            {
                Flow result = apiInstance.GetFlow(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The path property of the flow | 

### Return type

[**Flow**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowcontract"></a>
# **GetFlowContract**
> FlowContract GetFlowContract (string flow, Object body = null)



Get all the input and output parameters the flow defines based on the steps it contains and the values that are specified for all parameters in each step

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowContractExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The path property of the flow step
            var body = ;  // Object | The possible fields and their possible values, matching the input schema (optional) 

            try
            {
                FlowContract result = apiInstance.GetFlowContract(flow, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The path property of the flow step | 
 **body** | **Object**| The possible fields and their possible values, matching the input schema | [optional] 

### Return type

[**FlowContract**](FlowContract.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowexecution"></a>
# **GetFlowExecution**
> FlowExecution GetFlowExecution (string execution)



Get the state of a single execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExecutionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var execution = execution_example;  // string | The id of the flow execution

            try
            {
                FlowExecution result = apiInstance.GetFlowExecution(execution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowExecution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **string**| The id of the flow execution | 

### Return type

[**FlowExecution**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowexecutionprogress"></a>
# **GetFlowExecutionProgress**
> FlowExecutionProgress GetFlowExecutionProgress (string execution, int? timeout = null)



Find out the progress of an existing execution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExecutionProgressExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var execution = execution_example;  // string | The id of the flow execution
            var timeout = 56;  // int? | The timeout in seconds, defaults to 30 (optional) 

            try
            {
                FlowExecutionProgress result = apiInstance.GetFlowExecutionProgress(execution, timeout);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowExecutionProgress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execution** | **string**| The id of the flow execution | 
 **timeout** | **int?**| The timeout in seconds, defaults to 30 | [optional] 

### Return type

[**FlowExecutionProgress**](FlowExecutionProgress.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowexecutionstatistics"></a>
# **GetFlowExecutionStatistics**
> Statistics GetFlowExecutionStatistics (string groupTimeBy = null, FilterGroupNode filter = null)



Returns statistics for flow executions, by a complex filter

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExecutionStatisticsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var groupTimeBy = groupTimeBy_example;  // string | the timespan to groupBy for the perTime part (optional) 
            var filter = new FilterGroupNode(); // FilterGroupNode | The filter (optional) 

            try
            {
                Statistics result = apiInstance.GetFlowExecutionStatistics(groupTimeBy, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowExecutionStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupTimeBy** | **string**| the timespan to groupBy for the perTime part | [optional] 
 **filter** | [**FilterGroupNode**](FilterGroupNode.md)| The filter | [optional] 

### Return type

[**Statistics**](Statistics.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowexecutions"></a>
# **GetFlowExecutions**
> List<FlowExecution> GetFlowExecutions (string flow, int? page = null, int? size = null, string sort = null, string filter = null)



Returns all executions for this flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The id of the flow
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;FlowExecution&gt; result = apiInstance.GetFlowExecutions(flow, page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The id of the flow | 
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<FlowExecution>**](FlowExecution.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowsettings"></a>
# **GetFlowSettings**
> Object GetFlowSettings (string step, string property, Object body = null)



Get all the settings (in and out) the step requires based on the values for the properties of the step, input is according to schema defining input, output is schemaform

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var step = step_example;  // string | The path property of the flow step
            var property = property_example;  // string | The property to get the schemaform for
            var body = ;  // Object | The possible fields and their possible values (optional) 

            try
            {
                Object result = apiInstance.GetFlowSettings(step, property, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **step** | **string**| The path property of the flow step | 
 **property** | **string**| The property to get the schemaform for | 
 **body** | **Object**| The possible fields and their possible values | [optional] 

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowstep"></a>
# **GetFlowStep**
> FlowStep GetFlowStep (string step)



Get definition of a specific flow step

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowStepExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var step = step_example;  // string | The path property of the step

            try
            {
                FlowStep result = apiInstance.GetFlowStep(step);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **step** | **string**| The path property of the step | 

### Return type

[**FlowStep**](FlowStep.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowsteps"></a>
# **GetFlowSteps**
> List<FlowStep> GetFlowSteps ()



Lists all the possible flow steps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowStepsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;FlowStep&gt; result = apiInstance.GetFlowSteps();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowSteps: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FlowStep>**](FlowStep.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflowthumbnail"></a>
# **GetFlowThumbnail**
> System.IO.Stream GetFlowThumbnail (string flow)



Returns a thumbnail image of the flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowThumbnailExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The id of the flow

            try
            {
                System.IO.Stream result = apiInstance.GetFlowThumbnail(flow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlowThumbnail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The id of the flow | 

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getflows"></a>
# **GetFlows**
> List<Flow> GetFlows (int? page = null, int? size = null, string sort = null, string filter = null)



Lists all the flows defined on the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFlowsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Flow&gt; result = apiInstance.GetFlows(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFlows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Flow>**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getformattedvalue"></a>
# **GetFormattedValue**
> FormattedValue GetFormattedValue (string value, string pattern, string type, string locale = null)



Format a number, date, time or dateTime using the given pattern

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFormattedValueExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var value = value_example;  // string | The value to format
            var pattern = pattern_example;  // string | The pattern to format the value with
            var type = type_example;  // string | The type of the value
            var locale = locale_example;  // string | The locale to use for the formatting (optional) 

            try
            {
                FormattedValue result = apiInstance.GetFormattedValue(value, pattern, type, locale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetFormattedValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| The value to format | 
 **pattern** | **string**| The pattern to format the value with | 
 **type** | **string**| The type of the value | 
 **locale** | **string**| The locale to use for the formatting | [optional] 

### Return type

[**FormattedValue**](FormattedValue.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlanguage"></a>
# **GetLanguage**
> Language GetLanguage (string language)



Get a single language

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var language = language_example;  // string | The id of the language

            try
            {
                Language result = apiInstance.GetLanguage(language);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| The id of the language | 

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlanguages"></a>
# **GetLanguages**
> List<Language> GetLanguages ()



Lists all the supported languages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLanguagesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Language&gt; result = apiInstance.GetLanguages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Language>**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlicense"></a>
# **GetLicense**
> LicenseInformation GetLicense ()



Return the currently installed license

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLicenseExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                LicenseInformation result = apiInstance.GetLicense();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetLicense: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplugindatasets"></a>
# **GetPluginDatasets**
> List<Dataset> GetPluginDatasets ()



Returns all datasets defined by plugins

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPluginDatasetsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Dataset&gt; result = apiInstance.GetPluginDatasets();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPluginDatasets: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Dataset>**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplugins"></a>
# **GetPlugins**
> List<Plugin> GetPlugins ()



Gets all Plugins registered in this project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPluginsExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Plugin&gt; result = apiInstance.GetPlugins();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPlugins: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Plugin>**](Plugin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprinter"></a>
# **GetPrinter**
> Printer GetPrinter (string printer)



Get a single printer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var printer = printer_example;  // string | The id of the printer

            try
            {
                Printer result = apiInstance.GetPrinter(printer);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **string**| The id of the printer | 

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprinters"></a>
# **GetPrinters**
> List<Printer> GetPrinters ()



Lists all printers that can be used to print documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPrintersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Printer&gt; result = apiInstance.GetPrinters();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPrinters: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Printer>**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getroles"></a>
# **GetRoles**
> List<Role> GetRoles ()



Lists all security roles

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRolesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Role&gt; result = apiInstance.GetRoles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Role>**](Role.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettings"></a>
# **GetSettings**
> Settings GetSettings ()



Get all settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                Settings result = apiInstance.GetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSettings: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubsettings"></a>
# **GetSubSettings**
> Object GetSubSettings (string settingsType)



Get only settings of one type. SettingsType parameter should be one of the properties of the settings object.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var settingsType = settingsType_example;  // string | The type of the settings

            try
            {
                Object result = apiInstance.GetSubSettings(settingsType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSubSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **string**| The type of the settings | 

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsupportedfeatures"></a>
# **GetSupportedFeatures**
> List<Feature> GetSupportedFeatures ()



Get a list of supported features

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSupportedFeaturesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;Feature&gt; result = apiInstance.GetSupportedFeatures();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSupportedFeatures: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Feature>**](Feature.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemcurrencysymbols"></a>
# **GetSystemCurrencySymbols**
> List<CurrencySymbol> GetSystemCurrencySymbols (int? page = null, int? size = null, string sort = null, string filter = null)



Lists all the currency symbols that are availabled on the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemCurrencySymbolsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;CurrencySymbol&gt; result = apiInstance.GetSystemCurrencySymbols(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemCurrencySymbols: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<CurrencySymbol>**](CurrencySymbol.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemdefaultlanguage"></a>
# **GetSystemDefaultLanguage**
> LanguageDefinition GetSystemDefaultLanguage ()



Get the default language for the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemDefaultLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                LanguageDefinition result = apiInstance.GetSystemDefaultLanguage();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemDefaultLanguage: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsysteminfo"></a>
# **GetSystemInfo**
> SystemInfo GetSystemInfo ()



Get system information

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemInfoExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                SystemInfo result = apiInstance.GetSystemInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemInfo: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemlanguages"></a>
# **GetSystemLanguages**
> List<LanguageDefinition> GetSystemLanguages (int? page = null, int? size = null, string sort = null, string filter = null, bool? formats = null)



Lists all the languages that are availabled on the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemLanguagesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 
            var formats = true;  // bool? | Include standard formats for dates, times, dateTimes and numbers in the result (optional)  (default to false)

            try
            {
                List&lt;LanguageDefinition&gt; result = apiInstance.GetSystemLanguages(page, size, sort, filter, formats);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemLanguages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 
 **formats** | **bool?**| Include standard formats for dates, times, dateTimes and numbers in the result | [optional] [default to false]

### Return type

[**List<LanguageDefinition>**](LanguageDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemprinter"></a>
# **GetSystemPrinter**
> PrinterDefinition GetSystemPrinter (string printer, bool? includeDetails = null)



Get a single printerdefinition

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemPrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var printer = printer_example;  // string | The id of the printer definition
            var includeDetails = true;  // bool? | Include the details of each printer (optional)  (default to true)

            try
            {
                PrinterDefinition result = apiInstance.GetSystemPrinter(printer, includeDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemPrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **string**| The id of the printer definition | 
 **includeDetails** | **bool?**| Include the details of each printer | [optional] [default to true]

### Return type

[**PrinterDefinition**](PrinterDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemprinters"></a>
# **GetSystemPrinters**
> List<PrinterDefinition> GetSystemPrinters (int? page = null, int? size = null, string sort = null, string filter = null, bool? includeDetails = null)



Get a list of the available printers on the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemPrintersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 
            var includeDetails = true;  // bool? | Include the details of each printer (optional)  (default to false)

            try
            {
                List&lt;PrinterDefinition&gt; result = apiInstance.GetSystemPrinters(page, size, sort, filter, includeDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemPrinters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 
 **includeDetails** | **bool?**| Include the details of each printer | [optional] [default to false]

### Return type

[**List<PrinterDefinition>**](PrinterDefinition.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemtimezones"></a>
# **GetSystemTimeZones**
> List<string> GetSystemTimeZones ()



Lists all the time zones that are availabled on the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSystemTimeZonesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                List&lt;string&gt; result = apiInstance.GetSystemTimeZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetSystemTimeZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaggroup"></a>
# **GetTagGroup**
> TagGroup GetTagGroup (string tagGroupId)



Retrieve a single tag group object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var tagGroupId = tagGroupId_example;  // string | The id of the tag group

            try
            {
                TagGroup result = apiInstance.GetTagGroup(tagGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTagGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **string**| The id of the tag group | 

### Return type

[**TagGroup**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaggroups"></a>
# **GetTagGroups**
> List<TagGroup> GetTagGroups (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all tag groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTagGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;TagGroup&gt; result = apiInstance.GetTagGroups(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTagGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<TagGroup>**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplate"></a>
# **GetTemplate**
> Template GetTemplate (string templateId)



Retrieve a single template object

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template

            try
            {
                Template result = apiInstance.GetTemplate(templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 

### Return type

[**Template**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatecontent"></a>
# **GetTemplateContent**
> System.IO.Stream GetTemplateContent (string templateId, string lang = null, string version = null, bool? includeMeta = null)



Return the content of the template for the given language.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var lang = lang_example;  // string | The id of the language that is supported by the project, default when none specified (optional) 
            var version = version_example;  // string | The version ID or the revision number of the template to retrieve. Latest version if not specified (optional) 
            var includeMeta = true;  // bool? | Whether template meta information should already be included in the template document itself (optional)  (default to false)

            try
            {
                System.IO.Stream result = apiInstance.GetTemplateContent(templateId, lang, version, includeMeta);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplateContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **lang** | **string**| The id of the language that is supported by the project, default when none specified | [optional] 
 **version** | **string**| The version ID or the revision number of the template to retrieve. Latest version if not specified | [optional] 
 **includeMeta** | **bool?**| Whether template meta information should already be included in the template document itself | [optional] [default to false]

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatehistory"></a>
# **GetTemplateHistory**
> List<Version> GetTemplateHistory (string templateId, string lang = null, int? page = null, int? size = null, string sort = null)



Show the history of a given template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateHistoryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var lang = lang_example;  // string | The id of the language that is supported by the project, default when none specified (optional) 
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 

            try
            {
                List&lt;Version&gt; result = apiInstance.GetTemplateHistory(templateId, lang, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplateHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **lang** | **string**| The id of the language that is supported by the project, default when none specified | [optional] 
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 

### Return type

[**List<Version>**](Version.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatelanguage"></a>
# **GetTemplateLanguage**
> TemplateLanguage GetTemplateLanguage (string templateId, string lang)



Retrieve info about the template for the given language

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var lang = lang_example;  // string | The id of the language that is supported by the project

            try
            {
                TemplateLanguage result = apiInstance.GetTemplateLanguage(templateId, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplateLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **lang** | **string**| The id of the language that is supported by the project | 

### Return type

[**TemplateLanguage**](TemplateLanguage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplateschema"></a>
# **GetTemplateSchema**
> System.IO.Stream GetTemplateSchema (string templateId, string format = null)



Get the schema of the fields that are usabel in the template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplateSchemaExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var format = format_example;  // string | The format of the schema (optional)  (default to xsd)

            try
            {
                System.IO.Stream result = apiInstance.GetTemplateSchema(templateId, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplateSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **format** | **string**| The format of the schema | [optional] [default to xsd]

### Return type

**System.IO.Stream**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplates"></a>
# **GetTemplates**
> List<Template> GetTemplates (int? page = null, int? size = null, string sort = null, string filter = null)



Returns all templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTemplatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;Template&gt; result = apiInstance.GetTemplates(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> User GetUser (string user)



Get a single user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var user = user_example;  // string | The id of the user

            try
            {
                User result = apiInstance.GetUser(user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**| The id of the user | 

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusers"></a>
# **GetUsers**
> List<User> GetUsers (int? page = null, int? size = null, string sort = null, string filter = null)



Lists all users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var page = 56;  // int? | The 0-based page to retrieve, defaults to 0 (optional) 
            var size = 56;  // int? | The size of the page, defaults to 20 (optional) 
            var sort = sort_example;  // string | The fields to sort on (optional) 
            var filter = filter_example;  // string | The filter (optional) 

            try
            {
                List&lt;User&gt; result = apiInstance.GetUsers(page, size, sort, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The 0-based page to retrieve, defaults to 0 | [optional] 
 **size** | **int?**| The size of the page, defaults to 20 | [optional] 
 **sort** | **string**| The fields to sort on | [optional] 
 **filter** | **string**| The filter | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="installlicense"></a>
# **InstallLicense**
> LicenseInformation InstallLicense (byte[] body = null)



Install a new license

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InstallLicenseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = BINARY_DATA_HERE;  // byte[] | The license to install (optional) 

            try
            {
                LicenseInformation result = apiInstance.InstallLicense(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.InstallLicense: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parseexpression"></a>
# **ParseExpression**
> ParseExpressionResponse ParseExpression (ParseExpressionRequest body = null)



Parse the given expression

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ParseExpressionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new ParseExpressionRequest(); // ParseExpressionRequest | The result object for the language (optional) 

            try
            {
                ParseExpressionResponse result = apiInstance.ParseExpression(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ParseExpression: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postflowcallback"></a>
# **PostFlowCallback**
> string PostFlowCallback (string callbackId, string executionId = null, string body = null)



Can be used for external calls to the flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostFlowCallbackExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var callbackId = callbackId_example;  // string | The id of the queue to put the request in
            var executionId = executionId_example;  // string | The id to identify the execution (optional) 
            var body = body_example;  // string | The data that is passed from the external party (optional) 

            try
            {
                string result = apiInstance.PostFlowCallback(callbackId, executionId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PostFlowCallback: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callbackId** | **string**| The id of the queue to put the request in | 
 **executionId** | **string**| The id to identify the execution | [optional] 
 **body** | **string**| The data that is passed from the external party | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="prepareimport"></a>
# **PrepareImport**
> ImportInformation PrepareImport (byte[] body = null)



Given an archive, produce some information that can be used to map items from the archive on items in the target environment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PrepareImportExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = body_example;  // byte[] | The content of the archive (optional) 

            try
            {
                ImportInformation result = apiInstance.PrepareImport(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.PrepareImport: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshconnector"></a>
# **RefreshConnector**
> void RefreshConnector (string connectorId)



Refresh the state of the connector

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RefreshConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector

            try
            {
                apiInstance.RefreshConnector(connectorId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RefreshConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restorebackup"></a>
# **RestoreBackup**
> void RestoreBackup (byte[] body = null)



Import the content from the given archive

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RestoreBackupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = body_example;  // byte[] | The content of the archive (optional) 

            try
            {
                apiInstance.RestoreBackup(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RestoreBackup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **byte[]**| The content of the archive | [optional] 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="runcleanup"></a>
# **RunCleanup**
> List<CleanupActionStatus> RunCleanup (string action = null)



Run one or all cleanup processes now

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RunCleanupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var action = action_example;  // string | The cleanup action to run. When not specified, all actions are triggered (optional) 

            try
            {
                List&lt;CleanupActionStatus&gt; result = apiInstance.RunCleanup(action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RunCleanup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | **string**| The cleanup action to run. When not specified, all actions are triggered | [optional] 

### Return type

[**List<CleanupActionStatus>**](CleanupActionStatus.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdefaultlanguage"></a>
# **SetDefaultLanguage**
> Language SetDefaultLanguage (Language body = null)



Set the default language for the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetDefaultLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Language(); // Language | The result object for the language (optional) 

            try
            {
                Language result = apiInstance.SetDefaultLanguage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetDefaultLanguage: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdefaultprinter"></a>
# **SetDefaultPrinter**
> Printer SetDefaultPrinter (Printer body = null)



Set the default printer for the project

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetDefaultPrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new Printer(); // Printer | The result object for the printer (optional) 

            try
            {
                Printer result = apiInstance.SetDefaultPrinter(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetDefaultPrinter: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsystemdefaultlanguage"></a>
# **SetSystemDefaultLanguage**
> LanguageDefinition SetSystemDefaultLanguage (LanguageDefinition body = null)



Set the default language for the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetSystemDefaultLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var body = new LanguageDefinition(); // LanguageDefinition | The result object for the language (optional) 

            try
            {
                LanguageDefinition result = apiInstance.SetSystemDefaultLanguage(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetSystemDefaultLanguage: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnector"></a>
# **SetupConnector**
> ConnectorStage SetupConnector (string connectorId)



Setup the connector - start

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector

            try
            {
                ConnectorStage result = apiInstance.SetupConnector(connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnectorcancel"></a>
# **SetupConnectorCancel**
> Connector SetupConnectorCancel (string connectorId, Object body = null)



Cancel the connector setup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorCancelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var body = ;  // Object | The model of the current step (optional) 

            try
            {
                Connector result = apiInstance.SetupConnectorCancel(connectorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnectorCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **body** | **Object**| The model of the current step | [optional] 

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnectorcurrent"></a>
# **SetupConnectorCurrent**
> ConnectorStage SetupConnectorCurrent (string connectorId)



Setup the connector - get the current step

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorCurrentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector

            try
            {
                ConnectorStage result = apiInstance.SetupConnectorCurrent(connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnectorCurrent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnectorfinish"></a>
# **SetupConnectorFinish**
> Connector SetupConnectorFinish (string connectorId, Object body = null)



Finish the connector setup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorFinishExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var body = ;  // Object | The model of the current step (optional) 

            try
            {
                Connector result = apiInstance.SetupConnectorFinish(connectorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnectorFinish: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **body** | **Object**| The model of the current step | [optional] 

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnectornext"></a>
# **SetupConnectorNext**
> ConnectorStage SetupConnectorNext (string connectorId, Object body = null)



Setup the connector - go to the next step

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorNextExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var body = ;  // Object | The model of the current step (optional) 

            try
            {
                ConnectorStage result = apiInstance.SetupConnectorNext(connectorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnectorNext: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **body** | **Object**| The model of the current step | [optional] 

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setupconnectorprevious"></a>
# **SetupConnectorPrevious**
> ConnectorStage SetupConnectorPrevious (string connectorId, Object body = null)



Setup the connector - go to the previous step

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetupConnectorPreviousExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var body = ;  // Object | The model of the current step (optional) 

            try
            {
                ConnectorStage result = apiInstance.SetupConnectorPrevious(connectorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SetupConnectorPrevious: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **body** | **Object**| The model of the current step | [optional] 

### Return type

[**ConnectorStage**](ConnectorStage.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncexternalusers"></a>
# **SyncExternalUsers**
> SyncResult SyncExternalUsers ()



Syncs all users with the login connector

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SyncExternalUsersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                SyncResult result = apiInstance.SyncExternalUsers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SyncExternalUsers: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testconnector"></a>
# **TestConnector**
> OperationStatus TestConnector (string connectorId)



Test if the connection to the connector can be made successfully

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TestConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector

            try
            {
                OperationStatus result = apiInstance.TestConnector(connectorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.TestConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 

### Return type

[**OperationStatus**](OperationStatus.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testprinter"></a>
# **TestPrinter**
> void TestPrinter (string printer)



Send a test document to the printer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TestPrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var printer = printer_example;  // string | The id of the printer

            try
            {
                apiInstance.TestPrinter(printer);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.TestPrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **string**| The id of the printer | 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateasset"></a>
# **UpdateAsset**
> Asset UpdateAsset (string assetId, Asset body = null)



Update the asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var assetId = assetId_example;  // string | The id of the asset
            var body = new Asset(); // Asset | The asset object with updated properties (optional) 

            try
            {
                Asset result = apiInstance.UpdateAsset(assetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| The id of the asset | 
 **body** | [**Asset**](Asset.md)| The asset object with updated properties | [optional] 

### Return type

[**Asset**](Asset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateassetcontent"></a>
# **UpdateAssetContent**
> void UpdateAssetContent (string assetId, byte[] body = null)



Update the content of the asset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAssetContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var assetId = assetId_example;  // string | The id of the asset
            var body = body_example;  // byte[] | The content of the asset (optional) 

            try
            {
                apiInstance.UpdateAssetContent(assetId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAssetContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**| The id of the asset | 
 **body** | **byte[]**| The content of the asset | [optional] 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconnector"></a>
# **UpdateConnector**
> Connector UpdateConnector (string connectorId, Connector body = null)



Update the connector

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateConnectorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var connectorId = connectorId_example;  // string | The id of the connector
            var body = new Connector(); // Connector | The connector object with updated properties (optional) 

            try
            {
                Connector result = apiInstance.UpdateConnector(connectorId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateConnector: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **connectorId** | **string**| The id of the connector | 
 **body** | [**Connector**](Connector.md)| The connector object with updated properties | [optional] 

### Return type

[**Connector**](Connector.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedata"></a>
# **UpdateData**
> Data UpdateData (string dataId, Data body = null)



Update the data

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDataExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var dataId = dataId_example;  // string | The id of the data
            var body = new Data(); // Data | The data object with updated properties (optional) 

            try
            {
                Data result = apiInstance.UpdateData(dataId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataId** | **string**| The id of the data | 
 **body** | [**Data**](Data.md)| The data object with updated properties | [optional] 

### Return type

[**Data**](Data.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedataset"></a>
# **UpdateDataset**
> Dataset UpdateDataset (string datasetId, Dataset body = null)



Update the dataset

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDatasetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var datasetId = datasetId_example;  // string | The id of the dataset
            var body = new Dataset(); // Dataset | The dataset object with updated properties (optional) 

            try
            {
                Dataset result = apiInstance.UpdateDataset(datasetId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateDataset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datasetId** | **string**| The id of the dataset | 
 **body** | [**Dataset**](Dataset.md)| The dataset object with updated properties | [optional] 

### Return type

[**Dataset**](Dataset.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateflow"></a>
# **UpdateFlow**
> Flow UpdateFlow (string flow, Flow body = null)



Update a single flow

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFlowExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var flow = flow_example;  // string | The id of the flow
            var body = new Flow(); // Flow | The possible fields and their possible values (optional) 

            try
            {
                Flow result = apiInstance.UpdateFlow(flow, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **flow** | **string**| The id of the flow | 
 **body** | [**Flow**](Flow.md)| The possible fields and their possible values | [optional] 

### Return type

[**Flow**](Flow.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelanguage"></a>
# **UpdateLanguage**
> Language UpdateLanguage (string language, Language body = null)



Update a single language

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLanguageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var language = language_example;  // string | The id of the language
            var body = new Language(); // Language | The result object for the language (optional) 

            try
            {
                Language result = apiInstance.UpdateLanguage(language, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateLanguage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **language** | **string**| The id of the language | 
 **body** | [**Language**](Language.md)| The result object for the language | [optional] 

### Return type

[**Language**](Language.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprinter"></a>
# **UpdatePrinter**
> Printer UpdatePrinter (string printer, Printer body = null)



Update a single printer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePrinterExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var printer = printer_example;  // string | The id of the printer
            var body = new Printer(); // Printer | The result object for the printer (optional) 

            try
            {
                Printer result = apiInstance.UpdatePrinter(printer, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdatePrinter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **printer** | **string**| The id of the printer | 
 **body** | [**Printer**](Printer.md)| The result object for the printer | [optional] 

### Return type

[**Printer**](Printer.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubsettings"></a>
# **UpdateSubSettings**
> Object UpdateSubSettings (string settingsType, Object body = null)



Update settings of one type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubSettingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var settingsType = settingsType_example;  // string | The type of the settings
            var body = ;  // Object | The updated settings (optional) 

            try
            {
                Object result = apiInstance.UpdateSubSettings(settingsType, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateSubSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **settingsType** | **string**| The type of the settings | 
 **body** | **Object**| The updated settings | [optional] 

### Return type

**Object**

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaggroup"></a>
# **UpdateTagGroup**
> TagGroup UpdateTagGroup (string tagGroupId, TagGroup body = null)



Update the tag group

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTagGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var tagGroupId = tagGroupId_example;  // string | The id of the tag group
            var body = new TagGroup(); // TagGroup | The tag group object with updated properties (optional) 

            try
            {
                TagGroup result = apiInstance.UpdateTagGroup(tagGroupId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTagGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagGroupId** | **string**| The id of the tag group | 
 **body** | [**TagGroup**](TagGroup.md)| The tag group object with updated properties | [optional] 

### Return type

[**TagGroup**](TagGroup.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplate"></a>
# **UpdateTemplate**
> Template UpdateTemplate (string templateId, Template body = null)



Update the template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var body = new Template(); // Template | The template object with updated properties (optional) 

            try
            {
                Template result = apiInstance.UpdateTemplate(templateId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **body** | [**Template**](Template.md)| The template object with updated properties | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplatecontent"></a>
# **UpdateTemplateContent**
> void UpdateTemplateContent (string templateId, string lang = null, string description = null, byte[] body = null)



Update the content of the template for the given language

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTemplateContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var templateId = templateId_example;  // string | The id of the template
            var lang = lang_example;  // string | The id of the language that is supported by the project, default when none specified (optional) 
            var description = description_example;  // string | The description of the changes made (optional) 
            var body = body_example;  // byte[] | The content of the template (optional) 

            try
            {
                apiInstance.UpdateTemplateContent(templateId, lang, description, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateTemplateContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**| The id of the template | 
 **lang** | **string**| The id of the language that is supported by the project, default when none specified | [optional] 
 **description** | **string**| The description of the changes made | [optional] 
 **body** | **byte[]**| The content of the template | [optional] 

### Return type

void (empty response body)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/octet-stream
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> User UpdateUser (string user, User body = null)



Update a single user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: xperido_auth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var user = user_example;  // string | The id of the user
            var body = new User(); // User | The user properties to update (optional) 

            try
            {
                User result = apiInstance.UpdateUser(user, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **string**| The id of the user | 
 **body** | [**User**](User.md)| The user properties to update | [optional] 

### Return type

[**User**](User.md)

### Authorization

[xperido_auth](../README.md#xperido_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

