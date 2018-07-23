# smart-flows-clients

## Getting started

Running a Smart Flow using the Smart Flow REST API is done in 4 steps:

1) Authenticate
2) Create a flow execution
3) Wait for completion
4) Get the flow output


## Authenticate
To authenticate with the API you need an API key, which you can generate in the project console.
Each user in the Smart Flows project can generate/revoke API keys for his specific user account.
We recommend creating an extra user with the role "Super User", specifically  for creating an API key.

(control panel > users > select native @ top left of list > create a user with role 'Super user' > Edit user > Security > create API key)

<b>It is important you store this key somewhere safe, because it is shown only once and not stored in the project.</b>

To authenticate all calls to the API, each http call has to contain the header 'X-API-Key' with your API key as the value.
As long as you don't revoke the key via the project console, all calls containing this header will be authorized.

## Creating a flow execution
The first call you should make to the API is one to begin a new flow execution.
```
POST https://{host}:{port}/api/v1/flows/executions?flowId={flowId}
```
### Headers

|name|value|
|---|---|
|Content-Type | application/xml; charset="utf-8"|
|X-API-Key| <i>your API key</i>|

### Request parameters
|name|description |
|---|---|
| flowId   |  the guid for the flow you want to run | 

### Body
The body consists of your data in xml format. This xml follows the structure defined in the inputDataset of the flow

### Response
```
{
  "id":"6de9206a-de42-4182-8f86-a9a8d29fbd56",
  "percentage":0,
  "message":"Generate document",
  "status":"Running"
}
```
The important part of this response its the id, which can be used to get the status and the output of the flow execution.

## Wait for completion
To check the status of the flow execution you can make the following API call

```
GET https://{host}:{port}/api/v1/flows/executions/{executionId}/progress
```
### Headers

|name|value|
|---|---|
|X-API-Key| <i>your API key</i>|

### URL parameters
|name|description |
|---|---|
| executionId   |  the guid of the flow execution (obtained in the previous step) | 

### Response

```
{
    "id": "85f8fe94-6f61-4216-af6c-4889e2547b72",
    "percentage": 30,
    "message": "Generating Document",
    "status": "Running",
    "schema": {
        ...
    },
    "model": {
        ...
    },
    "form": [
        ...
    ]
}
```

|name|description |
|---|---|
| id   |  the flow execution id | 
| percentage   |  percentage of the flow steps that has already completed (0 - 100)| 
| message  |  Info message that describes what the execution is currently doing | 
| status   |  The current status of the flow |

### Flow statuses

|name|description |
|---|---|
| Running | The flow is currently running. |
| Success  |  The flow finished successfully.
| Queued   |  The flow is queued on the server. | 
| User input | The flow is waiting for user input. |
| Error   | The flow has run into an error.|
| Canceled   | The flow has been stopped by the user.|
| Waiting | The flow is waiting for an external event to resume. |
| SelectFlow   |  The user needs to select which flow to run.|
| Interrupted   |  The flow has been interrupted by an unexpected event.|

## Get flow output
If the flow is in a stable status (Success, error, ...) you can query the result with the following request:

```
GET https://{host}:{port}/api/v1/flows/executions/{executionId}
```
### Headers

|name|value|
|---|---|
|X-API-Key| <i>your API key</i>|

### URL parameters
|name|description |
|---|---|
| executionId   |  the guid of the flow execution | 

### Response

The resonse looks alot like the response of a progress call, but contains a few extra properties:
- state
  - inputdata: Representation of the input data that was send in step 1
  - output: xd-schema-form representation of the flow output, used by the execution panel.
  - stages: all stages ran by the flow
  - report: info on all flow steps that where executed in the flow
  
```
{
    "id": "executionid",
    "createdAt": ... ,
    "createdBy": ... ,
    "modifiedAt": ... ,
    "modifiedBy": ... ,
    "status": "Success",
    "flow": {
        "id": "someguid",
        "displayName": "The displayName",
        "type": "flow"
    },
    "state": {
        "inputData": { ... },
        "output": { ... },
        "stages": [ ... ],
        "report": [ ... ]
            }
    }
}
```
