# swagger-java-client

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>xpertdoc.smartflows</groupId>
    <artifactId>swagger-java-client</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "xpertdoc.smartflows:swagger-java-client:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/swagger-java-client-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import xpertdoc.smartflows.client.*;
import xpertdoc.smartflows.client.auth.*;
import xpertdoc.smartflows.client.model.*;
import xpertdoc.smartflows.client.api.DefaultApi;

import java.io.File;
import java.util.*;

public class DefaultApiExample {

    public static void main(String[] args) {
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
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**addAsset**](docs/DefaultApi.md#addAsset) | **POST** /assets | 
*DefaultApi* | [**authenticateGet**](docs/DefaultApi.md#authenticateGet) | **GET** /authenticate | 
*DefaultApi* | [**authenticateLoginPost**](docs/DefaultApi.md#authenticateLoginPost) | **POST** /authenticate/login | 
*DefaultApi* | [**authenticateOauth2Post**](docs/DefaultApi.md#authenticateOauth2Post) | **POST** /authenticate/oauth2 | 
*DefaultApi* | [**cancelFlowExecution**](docs/DefaultApi.md#cancelFlowExecution) | **DELETE** /flows/executions/{execution}/progress | 
*DefaultApi* | [**clearSubSettings**](docs/DefaultApi.md#clearSubSettings) | **DELETE** /settings/{settingsType} | 
*DefaultApi* | [**continueFlowExecution**](docs/DefaultApi.md#continueFlowExecution) | **POST** /flows/executions/{execution}/progress | 
*DefaultApi* | [**createBackup**](docs/DefaultApi.md#createBackup) | **POST** /system/backup | 
*DefaultApi* | [**createConnector**](docs/DefaultApi.md#createConnector) | **POST** /connectors | 
*DefaultApi* | [**createDataset**](docs/DefaultApi.md#createDataset) | **POST** /datasets | 
*DefaultApi* | [**createDatasetData**](docs/DefaultApi.md#createDatasetData) | **POST** /datasets/{datasetId}/data | 
*DefaultApi* | [**createDocument**](docs/DefaultApi.md#createDocument) | **POST** /documents | 
*DefaultApi* | [**createExport**](docs/DefaultApi.md#createExport) | **POST** /system/export | 
*DefaultApi* | [**createFlatExport**](docs/DefaultApi.md#createFlatExport) | **POST** /system/export/flat | 
*DefaultApi* | [**createFlow**](docs/DefaultApi.md#createFlow) | **POST** /flows | 
*DefaultApi* | [**createLanguage**](docs/DefaultApi.md#createLanguage) | **POST** /languages | 
*DefaultApi* | [**createPrinter**](docs/DefaultApi.md#createPrinter) | **POST** /printers | 
*DefaultApi* | [**createTagGroup**](docs/DefaultApi.md#createTagGroup) | **POST** /taggroups | 
*DefaultApi* | [**createTemplate**](docs/DefaultApi.md#createTemplate) | **POST** /templates | 
*DefaultApi* | [**createUser**](docs/DefaultApi.md#createUser) | **POST** /users | 
*DefaultApi* | [**deleteAsset**](docs/DefaultApi.md#deleteAsset) | **DELETE** /assets/{assetId} | 
*DefaultApi* | [**deleteConnector**](docs/DefaultApi.md#deleteConnector) | **DELETE** /connectors/{connectorId} | 
*DefaultApi* | [**deleteData**](docs/DefaultApi.md#deleteData) | **DELETE** /data/{dataId} | 
*DefaultApi* | [**deleteDataset**](docs/DefaultApi.md#deleteDataset) | **DELETE** /datasets/{datasetId} | 
*DefaultApi* | [**deleteFlow**](docs/DefaultApi.md#deleteFlow) | **DELETE** /flows/{flow} | 
*DefaultApi* | [**deleteLanguage**](docs/DefaultApi.md#deleteLanguage) | **DELETE** /languages/{language} | 
*DefaultApi* | [**deletePrinter**](docs/DefaultApi.md#deletePrinter) | **DELETE** /printers/{printer} | 
*DefaultApi* | [**deleteTagGroup**](docs/DefaultApi.md#deleteTagGroup) | **DELETE** /taggroups/{tagGroupId} | 
*DefaultApi* | [**deleteTemplate**](docs/DefaultApi.md#deleteTemplate) | **DELETE** /templates/{templateId} | 
*DefaultApi* | [**deleteTemplateContent**](docs/DefaultApi.md#deleteTemplateContent) | **DELETE** /templates/{templateId}/content | 
*DefaultApi* | [**deleteUser**](docs/DefaultApi.md#deleteUser) | **DELETE** /users/{user} | 
*DefaultApi* | [**executeFlatImport**](docs/DefaultApi.md#executeFlatImport) | **POST** /system/import/flat | 
*DefaultApi* | [**executeFlow**](docs/DefaultApi.md#executeFlow) | **POST** /flows/executions | 
*DefaultApi* | [**executeImport**](docs/DefaultApi.md#executeImport) | **POST** /system/import | 
*DefaultApi* | [**existsData**](docs/DefaultApi.md#existsData) | **HEAD** /data/{dataId} | 
*DefaultApi* | [**getAllFlowExecutions**](docs/DefaultApi.md#getAllFlowExecutions) | **GET** /flows/executions | 
*DefaultApi* | [**getAsset**](docs/DefaultApi.md#getAsset) | **GET** /assets/{assetId} | 
*DefaultApi* | [**getAssetContent**](docs/DefaultApi.md#getAssetContent) | **GET** /assets/{assetId}/content | 
*DefaultApi* | [**getAssets**](docs/DefaultApi.md#getAssets) | **GET** /assets | 
*DefaultApi* | [**getConnector**](docs/DefaultApi.md#getConnector) | **GET** /connectors/{connectorId} | 
*DefaultApi* | [**getConnectorType**](docs/DefaultApi.md#getConnectorType) | **GET** /connectors/types/{connectorTypeId} | 
*DefaultApi* | [**getConnectorTypes**](docs/DefaultApi.md#getConnectorTypes) | **GET** /connectors/types | 
*DefaultApi* | [**getConnectors**](docs/DefaultApi.md#getConnectors) | **GET** /connectors | 
*DefaultApi* | [**getCurrentUser**](docs/DefaultApi.md#getCurrentUser) | **GET** /users/me | 
*DefaultApi* | [**getData**](docs/DefaultApi.md#getData) | **GET** /data/{dataId} | 
*DefaultApi* | [**getDataContent**](docs/DefaultApi.md#getDataContent) | **GET** /data/{dataId}/content | 
*DefaultApi* | [**getDataMetadata**](docs/DefaultApi.md#getDataMetadata) | **GET** /data/meta | 
*DefaultApi* | [**getDataPreview**](docs/DefaultApi.md#getDataPreview) | **GET** /data/{dataId}/preview | 
*DefaultApi* | [**getDataset**](docs/DefaultApi.md#getDataset) | **GET** /datasets/{datasetId} | 
*DefaultApi* | [**getDatasetDatas**](docs/DefaultApi.md#getDatasetDatas) | **GET** /datasets/{datasetId}/data | 
*DefaultApi* | [**getDatasetEntityReferences**](docs/DefaultApi.md#getDatasetEntityReferences) | **GET** /datasets/{datasetId}/entityrefs | 
*DefaultApi* | [**getDatasetLayout**](docs/DefaultApi.md#getDatasetLayout) | **POST** /datasets/layout | 
*DefaultApi* | [**getDatasets**](docs/DefaultApi.md#getDatasets) | **GET** /datasets | 
*DefaultApi* | [**getDatasource**](docs/DefaultApi.md#getDatasource) | **GET** /datasources/{datasourceId} | 
*DefaultApi* | [**getDatasourceEntityLayout**](docs/DefaultApi.md#getDatasourceEntityLayout) | **GET** /datasources/{datasourceId}/layout/{entityName} | 
*DefaultApi* | [**getDatasourceLayout**](docs/DefaultApi.md#getDatasourceLayout) | **GET** /datasources/{datasourceId}/layout | 
*DefaultApi* | [**getDatasourceType**](docs/DefaultApi.md#getDatasourceType) | **GET** /datasources/types/{datasourceTypeId} | 
*DefaultApi* | [**getDatasourceTypes**](docs/DefaultApi.md#getDatasourceTypes) | **GET** /datasources/types | 
*DefaultApi* | [**getDatasources**](docs/DefaultApi.md#getDatasources) | **GET** /datasources | 
*DefaultApi* | [**getDefaultLanguage**](docs/DefaultApi.md#getDefaultLanguage) | **GET** /languages/default | 
*DefaultApi* | [**getDefaultPrinter**](docs/DefaultApi.md#getDefaultPrinter) | **GET** /printers/default | 
*DefaultApi* | [**getDependencies**](docs/DefaultApi.md#getDependencies) | **GET** /dependencies/{objectType}/{objectId} | 
*DefaultApi* | [**getDocument**](docs/DefaultApi.md#getDocument) | **GET** /documents/{documentId} | 
*DefaultApi* | [**getDocumentContent**](docs/DefaultApi.md#getDocumentContent) | **GET** /documents/{documentId}/content | 
*DefaultApi* | [**getDocuments**](docs/DefaultApi.md#getDocuments) | **GET** /documents | 
*DefaultApi* | [**getExpressionFunctions**](docs/DefaultApi.md#getExpressionFunctions) | **GET** /system/expression/functions | 
*DefaultApi* | [**getExternalUsers**](docs/DefaultApi.md#getExternalUsers) | **GET** /users/external | 
*DefaultApi* | [**getFilteredAssets**](docs/DefaultApi.md#getFilteredAssets) | **POST** /assets/filter | 
*DefaultApi* | [**getFilteredConnectors**](docs/DefaultApi.md#getFilteredConnectors) | **POST** /connectors/filter | 
*DefaultApi* | [**getFilteredDatasets**](docs/DefaultApi.md#getFilteredDatasets) | **POST** /datasets/filter | 
*DefaultApi* | [**getFilteredDatasources**](docs/DefaultApi.md#getFilteredDatasources) | **POST** /datasources/filter | 
*DefaultApi* | [**getFilteredDocuments**](docs/DefaultApi.md#getFilteredDocuments) | **POST** /documents/filter | 
*DefaultApi* | [**getFilteredFlowExecutions**](docs/DefaultApi.md#getFilteredFlowExecutions) | **POST** /flows/executions/filter | 
*DefaultApi* | [**getFilteredPrinters**](docs/DefaultApi.md#getFilteredPrinters) | **POST** /printers/filter | 
*DefaultApi* | [**getFilteredTagGroups**](docs/DefaultApi.md#getFilteredTagGroups) | **POST** /taggroups/filter | 
*DefaultApi* | [**getFilteredTemplates**](docs/DefaultApi.md#getFilteredTemplates) | **POST** /templates/filter | 
*DefaultApi* | [**getFilteredUsers**](docs/DefaultApi.md#getFilteredUsers) | **POST** /users/filter | 
*DefaultApi* | [**getFlow**](docs/DefaultApi.md#getFlow) | **GET** /flows/{flow} | 
*DefaultApi* | [**getFlowContract**](docs/DefaultApi.md#getFlowContract) | **POST** /flows/{flow}/contract | 
*DefaultApi* | [**getFlowExecution**](docs/DefaultApi.md#getFlowExecution) | **GET** /flows/executions/{execution} | 
*DefaultApi* | [**getFlowExecutionProgress**](docs/DefaultApi.md#getFlowExecutionProgress) | **GET** /flows/executions/{execution}/progress | 
*DefaultApi* | [**getFlowExecutionStatistics**](docs/DefaultApi.md#getFlowExecutionStatistics) | **POST** /flows/executions/statistics | 
*DefaultApi* | [**getFlowExecutions**](docs/DefaultApi.md#getFlowExecutions) | **GET** /flows/{flow}/executions | 
*DefaultApi* | [**getFlowSettings**](docs/DefaultApi.md#getFlowSettings) | **POST** /flows/steps/{step} | 
*DefaultApi* | [**getFlowStep**](docs/DefaultApi.md#getFlowStep) | **GET** /flows/steps/{step} | 
*DefaultApi* | [**getFlowSteps**](docs/DefaultApi.md#getFlowSteps) | **GET** /flows/steps | 
*DefaultApi* | [**getFlowThumbnail**](docs/DefaultApi.md#getFlowThumbnail) | **GET** /flows/{flow}/thumbnail | 
*DefaultApi* | [**getFlows**](docs/DefaultApi.md#getFlows) | **GET** /flows | 
*DefaultApi* | [**getFormattedValue**](docs/DefaultApi.md#getFormattedValue) | **GET** /system/format | 
*DefaultApi* | [**getLanguage**](docs/DefaultApi.md#getLanguage) | **GET** /languages/{language} | 
*DefaultApi* | [**getLanguages**](docs/DefaultApi.md#getLanguages) | **GET** /languages | 
*DefaultApi* | [**getLicense**](docs/DefaultApi.md#getLicense) | **GET** /system/license | 
*DefaultApi* | [**getPluginDatasets**](docs/DefaultApi.md#getPluginDatasets) | **GET** /datasets/plugin | 
*DefaultApi* | [**getPlugins**](docs/DefaultApi.md#getPlugins) | **GET** /plugins | 
*DefaultApi* | [**getPrinter**](docs/DefaultApi.md#getPrinter) | **GET** /printers/{printer} | 
*DefaultApi* | [**getPrinters**](docs/DefaultApi.md#getPrinters) | **GET** /printers | 
*DefaultApi* | [**getRoles**](docs/DefaultApi.md#getRoles) | **GET** /roles | 
*DefaultApi* | [**getSettings**](docs/DefaultApi.md#getSettings) | **GET** /settings | 
*DefaultApi* | [**getSubSettings**](docs/DefaultApi.md#getSubSettings) | **GET** /settings/{settingsType} | 
*DefaultApi* | [**getSupportedFeatures**](docs/DefaultApi.md#getSupportedFeatures) | **GET** /system/features | 
*DefaultApi* | [**getSystemCurrencySymbols**](docs/DefaultApi.md#getSystemCurrencySymbols) | **GET** /system/currencies | 
*DefaultApi* | [**getSystemDefaultLanguage**](docs/DefaultApi.md#getSystemDefaultLanguage) | **GET** /system/languages/default | 
*DefaultApi* | [**getSystemInfo**](docs/DefaultApi.md#getSystemInfo) | **GET** /system/info | 
*DefaultApi* | [**getSystemLanguages**](docs/DefaultApi.md#getSystemLanguages) | **GET** /system/languages | 
*DefaultApi* | [**getSystemPrinter**](docs/DefaultApi.md#getSystemPrinter) | **GET** /system/printers/{printer} | 
*DefaultApi* | [**getSystemPrinters**](docs/DefaultApi.md#getSystemPrinters) | **GET** /system/printers | 
*DefaultApi* | [**getSystemTimeZones**](docs/DefaultApi.md#getSystemTimeZones) | **GET** /system/timeZones | 
*DefaultApi* | [**getTagGroup**](docs/DefaultApi.md#getTagGroup) | **GET** /taggroups/{tagGroupId} | 
*DefaultApi* | [**getTagGroups**](docs/DefaultApi.md#getTagGroups) | **GET** /taggroups | 
*DefaultApi* | [**getTemplate**](docs/DefaultApi.md#getTemplate) | **GET** /templates/{templateId} | 
*DefaultApi* | [**getTemplateContent**](docs/DefaultApi.md#getTemplateContent) | **GET** /templates/{templateId}/content | 
*DefaultApi* | [**getTemplateHistory**](docs/DefaultApi.md#getTemplateHistory) | **GET** /templates/{templateId}/history | 
*DefaultApi* | [**getTemplateLanguage**](docs/DefaultApi.md#getTemplateLanguage) | **GET** /templates/{templateId}/lang/{lang} | 
*DefaultApi* | [**getTemplateSchema**](docs/DefaultApi.md#getTemplateSchema) | **GET** /templates/{templateId}/schema | 
*DefaultApi* | [**getTemplates**](docs/DefaultApi.md#getTemplates) | **GET** /templates | 
*DefaultApi* | [**getUser**](docs/DefaultApi.md#getUser) | **GET** /users/{user} | 
*DefaultApi* | [**getUsers**](docs/DefaultApi.md#getUsers) | **GET** /users | 
*DefaultApi* | [**installLicense**](docs/DefaultApi.md#installLicense) | **POST** /system/license | 
*DefaultApi* | [**parseExpression**](docs/DefaultApi.md#parseExpression) | **PUT** /system/expression | 
*DefaultApi* | [**postFlowCallback**](docs/DefaultApi.md#postFlowCallback) | **POST** /flows/callback/{callbackId} | 
*DefaultApi* | [**prepareImport**](docs/DefaultApi.md#prepareImport) | **POST** /system/import/prepare | 
*DefaultApi* | [**refreshConnector**](docs/DefaultApi.md#refreshConnector) | **POST** /connectors/{connectorId}/refresh | 
*DefaultApi* | [**restoreBackup**](docs/DefaultApi.md#restoreBackup) | **POST** /system/backup/restore | 
*DefaultApi* | [**runCleanup**](docs/DefaultApi.md#runCleanup) | **GET** /system/cleanup/run | 
*DefaultApi* | [**setDefaultLanguage**](docs/DefaultApi.md#setDefaultLanguage) | **PUT** /languages/default | 
*DefaultApi* | [**setDefaultPrinter**](docs/DefaultApi.md#setDefaultPrinter) | **PUT** /printers/default | 
*DefaultApi* | [**setSystemDefaultLanguage**](docs/DefaultApi.md#setSystemDefaultLanguage) | **PUT** /system/languages/default | 
*DefaultApi* | [**setupConnector**](docs/DefaultApi.md#setupConnector) | **POST** /connectors/{connectorId}/setup | 
*DefaultApi* | [**setupConnectorCancel**](docs/DefaultApi.md#setupConnectorCancel) | **POST** /connectors/{connectorId}/setup/cancel | 
*DefaultApi* | [**setupConnectorCurrent**](docs/DefaultApi.md#setupConnectorCurrent) | **GET** /connectors/{connectorId}/setup/current | 
*DefaultApi* | [**setupConnectorFinish**](docs/DefaultApi.md#setupConnectorFinish) | **POST** /connectors/{connectorId}/setup/finish | 
*DefaultApi* | [**setupConnectorNext**](docs/DefaultApi.md#setupConnectorNext) | **POST** /connectors/{connectorId}/setup/next | 
*DefaultApi* | [**setupConnectorPrevious**](docs/DefaultApi.md#setupConnectorPrevious) | **POST** /connectors/{connectorId}/setup/previous | 
*DefaultApi* | [**syncExternalUsers**](docs/DefaultApi.md#syncExternalUsers) | **POST** /users/external | 
*DefaultApi* | [**testConnector**](docs/DefaultApi.md#testConnector) | **GET** /connectors/{connectorId}/test | 
*DefaultApi* | [**testPrinter**](docs/DefaultApi.md#testPrinter) | **POST** /printers/{printer}/test | 
*DefaultApi* | [**updateAsset**](docs/DefaultApi.md#updateAsset) | **PUT** /assets/{assetId} | 
*DefaultApi* | [**updateAssetContent**](docs/DefaultApi.md#updateAssetContent) | **PUT** /assets/{assetId}/content | 
*DefaultApi* | [**updateConnector**](docs/DefaultApi.md#updateConnector) | **PUT** /connectors/{connectorId} | 
*DefaultApi* | [**updateData**](docs/DefaultApi.md#updateData) | **PUT** /data/{dataId} | 
*DefaultApi* | [**updateDataset**](docs/DefaultApi.md#updateDataset) | **PUT** /datasets/{datasetId} | 
*DefaultApi* | [**updateFlow**](docs/DefaultApi.md#updateFlow) | **PUT** /flows/{flow} | 
*DefaultApi* | [**updateLanguage**](docs/DefaultApi.md#updateLanguage) | **PUT** /languages/{language} | 
*DefaultApi* | [**updatePrinter**](docs/DefaultApi.md#updatePrinter) | **PUT** /printers/{printer} | 
*DefaultApi* | [**updateSubSettings**](docs/DefaultApi.md#updateSubSettings) | **PUT** /settings/{settingsType} | 
*DefaultApi* | [**updateTagGroup**](docs/DefaultApi.md#updateTagGroup) | **PUT** /taggroups/{tagGroupId} | 
*DefaultApi* | [**updateTemplate**](docs/DefaultApi.md#updateTemplate) | **PUT** /templates/{templateId} | 
*DefaultApi* | [**updateTemplateContent**](docs/DefaultApi.md#updateTemplateContent) | **PUT** /templates/{templateId}/content | 
*DefaultApi* | [**updateUser**](docs/DefaultApi.md#updateUser) | **PUT** /users/{user} | 


## Documentation for Models

 - [Archivable](docs/Archivable.md)
 - [ArchivableContent](docs/ArchivableContent.md)
 - [ArchivableItem](docs/ArchivableItem.md)
 - [Archive](docs/Archive.md)
 - [ArchiveRequest](docs/ArchiveRequest.md)
 - [Asset](docs/Asset.md)
 - [Authentication](docs/Authentication.md)
 - [AuthenticationInfo](docs/AuthenticationInfo.md)
 - [AuthenticationInfoLogin](docs/AuthenticationInfoLogin.md)
 - [AuthenticationInfoOauth2](docs/AuthenticationInfoOauth2.md)
 - [AuthenticationTokens](docs/AuthenticationTokens.md)
 - [BinaryDataHolder](docs/BinaryDataHolder.md)
 - [BooleanCondition](docs/BooleanCondition.md)
 - [ChartValue](docs/ChartValue.md)
 - [CleanupAction](docs/CleanupAction.md)
 - [CleanupActionSettings](docs/CleanupActionSettings.md)
 - [CleanupActionStatus](docs/CleanupActionStatus.md)
 - [CleanupSettings](docs/CleanupSettings.md)
 - [CleanupSettingsFlowExecutions](docs/CleanupSettingsFlowExecutions.md)
 - [CompletedExecutions](docs/CompletedExecutions.md)
 - [CompletedExecutionsPlan](docs/CompletedExecutionsPlan.md)
 - [Condition](docs/Condition.md)
 - [ConditionCheckValue](docs/ConditionCheckValue.md)
 - [ConditionCheckValueSettings](docs/ConditionCheckValueSettings.md)
 - [ConditionFlowVariable](docs/ConditionFlowVariable.md)
 - [ConditionGroup](docs/ConditionGroup.md)
 - [ConditionGroupNode](docs/ConditionGroupNode.md)
 - [ConditionOccurrence](docs/ConditionOccurrence.md)
 - [ConditionType](docs/ConditionType.md)
 - [ConditionValue](docs/ConditionValue.md)
 - [ConditionValueType](docs/ConditionValueType.md)
 - [Connector](docs/Connector.md)
 - [ConnectorStage](docs/ConnectorStage.md)
 - [ConnectorType](docs/ConnectorType.md)
 - [ConnectorTypeResourceFetch](docs/ConnectorTypeResourceFetch.md)
 - [ConnectorTypeResourceFetchMethod](docs/ConnectorTypeResourceFetchMethod.md)
 - [CurrencySymbol](docs/CurrencySymbol.md)
 - [CustomContentField](docs/CustomContentField.md)
 - [CustomContentFieldBoolean](docs/CustomContentFieldBoolean.md)
 - [CustomContentFieldData](docs/CustomContentFieldData.md)
 - [CustomContentFieldDataOptions](docs/CustomContentFieldDataOptions.md)
 - [CustomContentFieldDate](docs/CustomContentFieldDate.md)
 - [CustomContentFieldDateTime](docs/CustomContentFieldDateTime.md)
 - [CustomContentFieldEntityRef](docs/CustomContentFieldEntityRef.md)
 - [CustomContentFieldEntityRefDefault](docs/CustomContentFieldEntityRefDefault.md)
 - [CustomContentFieldEntityRefOptions](docs/CustomContentFieldEntityRefOptions.md)
 - [CustomContentFieldNumber](docs/CustomContentFieldNumber.md)
 - [CustomContentFieldOptionset](docs/CustomContentFieldOptionset.md)
 - [CustomContentFieldOptionsetOptions](docs/CustomContentFieldOptionsetOptions.md)
 - [CustomContentFieldText](docs/CustomContentFieldText.md)
 - [CustomContentFieldTime](docs/CustomContentFieldTime.md)
 - [Data](docs/Data.md)
 - [DataReference](docs/DataReference.md)
 - [DataValue](docs/DataValue.md)
 - [Dataset](docs/Dataset.md)
 - [DatasetContent](docs/DatasetContent.md)
 - [DatasetCustomContent](docs/DatasetCustomContent.md)
 - [DatasetExtendedContent](docs/DatasetExtendedContent.md)
 - [DatasetExtendedContentDatasets](docs/DatasetExtendedContentDatasets.md)
 - [DatasetExtendedContentFields](docs/DatasetExtendedContentFields.md)
 - [DatasetExtendedContentFrom](docs/DatasetExtendedContentFrom.md)
 - [DatasetExtendedContentRelations](docs/DatasetExtendedContentRelations.md)
 - [DatasetExtendedContentViews](docs/DatasetExtendedContentViews.md)
 - [DatasetSchemaContent](docs/DatasetSchemaContent.md)
 - [DatasetStandardContent](docs/DatasetStandardContent.md)
 - [DatasetStandardContentQueries](docs/DatasetStandardContentQueries.md)
 - [DatasetStandardContentQueriesParameters](docs/DatasetStandardContentQueriesParameters.md)
 - [Datasource](docs/Datasource.md)
 - [DatasourceLayout](docs/DatasourceLayout.md)
 - [DatasourceType](docs/DatasourceType.md)
 - [DatasourceTypeProperties](docs/DatasourceTypeProperties.md)
 - [DateCondition](docs/DateCondition.md)
 - [DateFormatStyle](docs/DateFormatStyle.md)
 - [DefaultPluginSettings](docs/DefaultPluginSettings.md)
 - [DependencyDepth](docs/DependencyDepth.md)
 - [DependencyDirection](docs/DependencyDirection.md)
 - [DependencyMapping](docs/DependencyMapping.md)
 - [DependencyTree](docs/DependencyTree.md)
 - [DependencyTreeNode](docs/DependencyTreeNode.md)
 - [DocGenSettings](docs/DocGenSettings.md)
 - [DocGenSettingsDatas](docs/DocGenSettingsDatas.md)
 - [DocGenSettingsResult](docs/DocGenSettingsResult.md)
 - [DocGenSettingsResultChartData](docs/DocGenSettingsResultChartData.md)
 - [DocGenSettingsResultHtml](docs/DocGenSettingsResultHtml.md)
 - [DocGenSettingsResultImage](docs/DocGenSettingsResultImage.md)
 - [DocGenSettingsResultImagePageing](docs/DocGenSettingsResultImagePageing.md)
 - [DocGenSettingsResultOdt](docs/DocGenSettingsResultOdt.md)
 - [DocGenSettingsResultOoxml](docs/DocGenSettingsResultOoxml.md)
 - [DocGenSettingsResultPdf](docs/DocGenSettingsResultPdf.md)
 - [DocGenSettingsResultPdfEncryption](docs/DocGenSettingsResultPdfEncryption.md)
 - [DocGenSettingsResultText](docs/DocGenSettingsResultText.md)
 - [DocGenSettingsTemplate](docs/DocGenSettingsTemplate.md)
 - [DocGenSettingsTemplateComposed](docs/DocGenSettingsTemplateComposed.md)
 - [DocGenSettingsTemplateStandard](docs/DocGenSettingsTemplateStandard.md)
 - [Document](docs/Document.md)
 - [DocumentPostProcessing](docs/DocumentPostProcessing.md)
 - [EntityDefinition](docs/EntityDefinition.md)
 - [EntityDefinitionLookups](docs/EntityDefinitionLookups.md)
 - [EntityDefinitionRelationships](docs/EntityDefinitionRelationships.md)
 - [EntityField](docs/EntityField.md)
 - [EntityReference](docs/EntityReference.md)
 - [EntityReferenceFields](docs/EntityReferenceFields.md)
 - [EntityReferenceLookups](docs/EntityReferenceLookups.md)
 - [EntityReferenceRelationships](docs/EntityReferenceRelationships.md)
 - [ExpressionFunction](docs/ExpressionFunction.md)
 - [ExpressionFunctionArguments](docs/ExpressionFunctionArguments.md)
 - [Feature](docs/Feature.md)
 - [FilterCondition](docs/FilterCondition.md)
 - [FilterGroup](docs/FilterGroup.md)
 - [FilterGroupNode](docs/FilterGroupNode.md)
 - [FlatArchive](docs/FlatArchive.md)
 - [Flow](docs/Flow.md)
 - [FlowBlock](docs/FlowBlock.md)
 - [FlowBlockState](docs/FlowBlockState.md)
 - [FlowBody](docs/FlowBody.md)
 - [FlowCondition](docs/FlowCondition.md)
 - [FlowConditionState](docs/FlowConditionState.md)
 - [FlowContract](docs/FlowContract.md)
 - [FlowDoStep](docs/FlowDoStep.md)
 - [FlowDoStepState](docs/FlowDoStepState.md)
 - [FlowExecution](docs/FlowExecution.md)
 - [FlowExecutionIteration](docs/FlowExecutionIteration.md)
 - [FlowExecutionProgress](docs/FlowExecutionProgress.md)
 - [FlowExecutionStage](docs/FlowExecutionStage.md)
 - [FlowExecutionState](docs/FlowExecutionState.md)
 - [FlowExecutionStateOutput](docs/FlowExecutionStateOutput.md)
 - [FlowExecutionStateOutputParts](docs/FlowExecutionStateOutputParts.md)
 - [FlowExecutionStatus](docs/FlowExecutionStatus.md)
 - [FlowInput](docs/FlowInput.md)
 - [FlowInputType](docs/FlowInputType.md)
 - [FlowSettings](docs/FlowSettings.md)
 - [FlowStep](docs/FlowStep.md)
 - [FlowSwitch](docs/FlowSwitch.md)
 - [FlowSwitchCases](docs/FlowSwitchCases.md)
 - [FlowSwitchState](docs/FlowSwitchState.md)
 - [FlowTry](docs/FlowTry.md)
 - [FlowTryState](docs/FlowTryState.md)
 - [FlowZone](docs/FlowZone.md)
 - [FlowZoneState](docs/FlowZoneState.md)
 - [FormatDefinition](docs/FormatDefinition.md)
 - [FormattedValue](docs/FormattedValue.md)
 - [GcpPrintProps](docs/GcpPrintProps.md)
 - [GcpVendorCapability](docs/GcpVendorCapability.md)
 - [GcpVendorCapabilityRange](docs/GcpVendorCapabilityRange.md)
 - [GcpVendorCapabilitySelect](docs/GcpVendorCapabilitySelect.md)
 - [GcpVendorCapabilityTypedValue](docs/GcpVendorCapabilityTypedValue.md)
 - [GeneralPrintProps](docs/GeneralPrintProps.md)
 - [GeneralPrintPropsPageRange](docs/GeneralPrintPropsPageRange.md)
 - [GeneratedDocument](docs/GeneratedDocument.md)
 - [GeneratedDocumentCharts](docs/GeneratedDocumentCharts.md)
 - [GeneratedDocumentContent](docs/GeneratedDocumentContent.md)
 - [GeneratedDocumentPages](docs/GeneratedDocumentPages.md)
 - [GeneratedDocumentProperties](docs/GeneratedDocumentProperties.md)
 - [GeneratedDocumentSeries](docs/GeneratedDocumentSeries.md)
 - [IdWithName](docs/IdWithName.md)
 - [ImportInformation](docs/ImportInformation.md)
 - [InProgressExecutions](docs/InProgressExecutions.md)
 - [JpsPrintProps](docs/JpsPrintProps.md)
 - [Language](docs/Language.md)
 - [LanguageDefinition](docs/LanguageDefinition.md)
 - [LanguageDefinitionDateTimeFormats](docs/LanguageDefinitionDateTimeFormats.md)
 - [LanguageDefinitionNumberFormat](docs/LanguageDefinitionNumberFormat.md)
 - [LicenseInformation](docs/LicenseInformation.md)
 - [Login](docs/Login.md)
 - [MultiDependencyMapping](docs/MultiDependencyMapping.md)
 - [NumberCondition](docs/NumberCondition.md)
 - [Oauth2Parameters](docs/Oauth2Parameters.md)
 - [ObjectReference](docs/ObjectReference.md)
 - [ObjectType](docs/ObjectType.md)
 - [ObjectUsage](docs/ObjectUsage.md)
 - [OperationStatus](docs/OperationStatus.md)
 - [ParseExpressionRequest](docs/ParseExpressionRequest.md)
 - [ParseExpressionResponse](docs/ParseExpressionResponse.md)
 - [ParseExpressionResponseErrors](docs/ParseExpressionResponseErrors.md)
 - [Part](docs/Part.md)
 - [Period](docs/Period.md)
 - [Plugin](docs/Plugin.md)
 - [Printer](docs/Printer.md)
 - [PrinterDefinition](docs/PrinterDefinition.md)
 - [PrinterDefinitionPrinterInfo](docs/PrinterDefinitionPrinterInfo.md)
 - [PrinterDefinitionPrinterInfoGcp](docs/PrinterDefinitionPrinterInfoGcp.md)
 - [PrinterDefinitionPrinterInfoJps](docs/PrinterDefinitionPrinterInfoJps.md)
 - [PrinterDefinitionPrinterInfoJpsPaperSources](docs/PrinterDefinitionPrinterInfoJpsPaperSources.md)
 - [PrinterProperties](docs/PrinterProperties.md)
 - [ProjectSettings](docs/ProjectSettings.md)
 - [RestoreContext](docs/RestoreContext.md)
 - [Role](docs/Role.md)
 - [Schedule](docs/Schedule.md)
 - [SchemaContent](docs/SchemaContent.md)
 - [Settings](docs/Settings.md)
 - [Statistics](docs/Statistics.md)
 - [StatisticsPerObject](docs/StatisticsPerObject.md)
 - [StatisticsPerStatus](docs/StatisticsPerStatus.md)
 - [StatisticsPerTime](docs/StatisticsPerTime.md)
 - [StatisticsPerUser](docs/StatisticsPerUser.md)
 - [StatusMessage](docs/StatusMessage.md)
 - [StatusMessageDocumentLocation](docs/StatusMessageDocumentLocation.md)
 - [SyncResult](docs/SyncResult.md)
 - [SystemInfo](docs/SystemInfo.md)
 - [SystemInfoDefaults](docs/SystemInfoDefaults.md)
 - [Tag](docs/Tag.md)
 - [TagGroup](docs/TagGroup.md)
 - [TagGroupRef](docs/TagGroupRef.md)
 - [Template](docs/Template.md)
 - [TemplateComposedContent](docs/TemplateComposedContent.md)
 - [TemplateDatasets](docs/TemplateDatasets.md)
 - [TemplateLanguage](docs/TemplateLanguage.md)
 - [TemplateStandardContent](docs/TemplateStandardContent.md)
 - [TextCondition](docs/TextCondition.md)
 - [User](docs/User.md)
 - [UserIdentity](docs/UserIdentity.md)
 - [UserIdentityExternal](docs/UserIdentityExternal.md)
 - [UserIdentityNative](docs/UserIdentityNative.md)
 - [UserManagementSettings](docs/UserManagementSettings.md)
 - [UserManagementSettingsSync](docs/UserManagementSettingsSync.md)
 - [Version](docs/Version.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### xperido_auth

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: http://swagger.io/api/oauth/dialog
- **Scopes**: 
  - delete:connectors: delete connectors
  - write:connectors: modify connectors
  - read:connectors: read connectors
  - read:datasources: read datasources
  - delete:tags: delete tags
  - write:tags: modify tags
  - read:tags: read tags
  - delete:datasets: delete datasets
  - write:datasets: modify datasets
  - read:datasets: read datasets
  - delete:templates: delete templates
  - write:templates: modify templates
  - read:templates: read templates
  - read:documents: read documents
  - delete:documents: delete documents
  - read:assets: read assets
  - write:assets: modify assets
  - delete:assets: delete assets
  - execute:flows: execute flows
  - read:flows: read flows
  - write:flows: change flows
  - delete:flows: remove flows
  - read:flowExecutions: read flow executions
  - read:ownFlowExecutions: read own flow executions
  - delete:flowExecutions: delete flow executions
  - read:languages: read languages
  - write:languages: write languages
  - delete:languages: delete languages
  - read:printers: read printers
  - write:printers: write printers
  - delete:printers: delete printers
  - read:settings: use settings
  - write:settings: change settings
  - read:users: read users
  - write:users: write users
  - delete:users: delete users
  - read:roles: read roles


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



