package console;

import xpertdoc.smartflows.client.ApiClient;
import xpertdoc.smartflows.client.ApiException;
import xpertdoc.smartflows.client.Configuration;
import xpertdoc.smartflows.client.api.DefaultApi;
import xpertdoc.smartflows.client.model.*;

import java.util.ArrayList;
import java.util.List;

class SmartFlowsApi {

	private DefaultApi apiInstance;

	SmartFlowsApi() {}

	boolean authorize(String host, String username, String password) {
		Login login = new Login();
		login.setUsername(username);
		login.setPassword(password);
		ApiClient api = Configuration.getDefaultApiClient();
		api.setBasePath(host);

		apiInstance = new DefaultApi(api);
		try {
			Authentication auth = apiInstance.authenticateLoginPost(login);
			AuthenticationTokens tokens = auth.getTokens().get(0);
			ApiClient apiClient = Configuration.getDefaultApiClient();
			apiClient.setAccessToken(tokens.getToken());
			apiInstance.setApiClient(api);
			return true;

		} catch (ApiException e) {
			System.err.println("Failed to connect with " + host);
			return false;
		}
	}

	List<Flow> getFlows() {
		try {
			return apiInstance.getFlows(0, 20, "displayName", null);
		} catch (ApiException e) {
			System.err.println("Exception when calling getFlows");
			return new ArrayList<>();
		}
	}

	FlowExecutionProgress startFlow(String flowId) {
		try {
			return apiInstance.executeFlow(flowId, null, null);
		} catch (ApiException e) {
			System.err.println("Exception when calling executeFlow");
			return null;
		}
	}
	FlowExecutionProgress getStatus(String flowExecutionId) {
		try {
			return apiInstance.getFlowExecutionProgress(flowExecutionId, -1);
		} catch (ApiException e) {
			System.err.println("Exception when calling getFlowExecutionProgress");
			return null;
		}
	}

	Document getDocument(String documentId) {
		try {
			return apiInstance.getDocument(documentId);
		} catch (ApiException e) {
			System.err.println("Exception when calling getDocument");
			return null;
		}
	}
	byte[] downloadDocument(String documentId) {
		try {
			return apiInstance.getDocumentContent(documentId);
		} catch (ApiException e) {
			System.err.println("Exception when calling downloadDocument");
			return null;
		}
	}
}
