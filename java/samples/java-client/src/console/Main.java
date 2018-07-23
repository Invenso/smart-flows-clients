package console;

import com.google.gson.internal.LinkedTreeMap;
import xpertdoc.smartflows.client.model.Document;
import xpertdoc.smartflows.client.model.FlowExecutionProgress;

import java.io.File;
import java.io.FileOutputStream;
import java.io.OutputStream;

public class Main {

	/**
	 * Sample for a flow which required no user interaction
	 **/
	public static void main(String[] args) {

		SmartFlowsApi api = new SmartFlowsApi();
		boolean authorized = api.authorize("URL", "USER", "PASSWORD");

		String flowId = "FLOWID";

		if (authorized) {
			System.out.println("Successfully connected");

			FlowExecutionProgress progress = api.startFlow(flowId);
			String executionId = progress.getId();

			int percentage = progress.getPercentage();
			while (percentage < 100) {
				System.out.println("\tstatus: " + progress.getStatus());
				progress = api.getStatus(executionId);
				percentage = progress.getPercentage();
				try {
					Thread.sleep(200);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}

			System.out.println("Completed");

			findAndDownloadDocuments(api, progress);
		}

	}

	private static void findAndDownloadDocuments(SmartFlowsApi api, FlowExecutionProgress state) {

		LinkedTreeMap<String, Object> map = (LinkedTreeMap<String, Object>) state.getModel();

		if (map != null) {
			map.keySet().forEach(key -> {
				LinkedTreeMap<String, Object> innermap = (LinkedTreeMap<String, Object>) map.get(key);
				innermap.keySet().forEach(innerKey -> {
					LinkedTreeMap<String, Object> idWithName = (LinkedTreeMap<String, Object>) innermap.get(innerKey);
					if (idWithName.containsKey("type") && idWithName.get("type").equals("document")) {
						downloadDocument(api, idWithName.get("id").toString());
					}
				});
			});
		}
	}

	private static void downloadDocument(SmartFlowsApi api, String documentId) {
		// supports 2 types of documents
		Document document = api.getDocument(documentId);
		String extension = document.getContentType().contains("pdf") ? ".pdf" : ".docx";
		byte[] content = api.downloadDocument(documentId);
		try {
			File file = new File(System.getProperty("user.home").replace("\\", "/") + "/Desktop/" + document.getDisplayName() + extension);
			OutputStream os = new FileOutputStream(file);
			os.write(content);
			os.close();
			System.out.println("Written " + file.getName() + " to " + file.getAbsolutePath());
		} catch (Exception e) {
			System.err.println(e);
		}
	}


}
