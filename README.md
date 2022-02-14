# EasyLife365 - FieldDataSource

This example shows you how to develop a custom data source field for EasyLife 365 using an Azure Function and C#.

## What are custom data sources for EasyLife 365?

In some situations, it might be necessary to retrieve dynamic values for the metadata fields in EasyLife. It might be helpful to maintain lists such as Departments in other systems and do not want to synchronize the department list in the EasyLife Cockpit.

EasyLife 365 allows you to specify custom fields that consume values from a web service. You can create custom data sources for the following EasyLife fields:

- Dropdowns

## Specifications

This example provides a simple Azure Function with an HTTP trigger showing how to return values based on the parameters triggered by EasyLife 365.

The web service receives an HTTP GET request. We also pass the current language with the query string parameter "lng" (e.g., en, de, it). It allows you to provide a localized output. EasyLife expects a JSON response with the following structure.

```
[
  {
    "key": "depKey1",
    "text": "Department 1"
  },
  {
    "key": "depKey2",
    "text": "Department 2"
  },
  {
    "key": "depKey3",
    "text": "Department 3"
  }
]
```

### Recommendations

- Web service should respond within 300ms to have a good user experience
- Enable caching for your web service

### Requirements

- Keys must only be alphanumeric and do not contain spaces
- CORS must be enabled for https://\*.easylife365.cloud
- support ticket must be opened on https://support.easylife365.cloud and must contain the following information:
  - company name
  - endpoint url
- a domain entry will be created on  *_.easylife365.cloud* and point to the service endpoint

## About this sample

This sample presented in this project is an Azure Function hosted on a consumption plan. You can provide the necessary resources using the bicep file under /_deployment.

- Install the Azure CLI on your machine
- Identify the subscription you want to deploy.
- Change the parameters under _deployment/provision.ps1
- Run the code

```
  cd _/deployment
  az login
  az account set --subscription "My Subscription ID"
  ./provision.ps1
```

- Publish the project using the publishing file of your previously deployed Azure Function. (https://docs.microsoft.com/en-us/visualstudio/deployment/tutorial-import-publish-settings-azure?view=vs-2022)
- Get the Functions URL for the HTTP Service on the Azure Portal: Functions -> DepartmentsHttpTrigger -> Get FunctionURL
- Go to EasyLife 365 Cockpit and configure your Dropdown Field. Under Options, select "Retrieve options from a web service" and paste the Function URL.

## Contribution guidelines
We appreciate that you're interested in helping with moving the project forward. Feel free to create issues or submit a PR. We will come back to you shortly.

Sharing is caring!
