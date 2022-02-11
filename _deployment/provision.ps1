$RESOURCE_GROUP = "rg-d-dropdown"
$APP_NAME = "easylifeextension"
$BICEP_FILE = "main.bicep"
$LOCATION = "westeurope"

# create a resource group
az group create -n $RESOURCE_GROUP -l $LOCATION

# deploy the bicep file directly
az deployment group create `
    --name mybicepdeployment `
    --resource-group $RESOURCE_GROUP `
    --template-file $BICEP_FILE `
    --parameters "appName=$APP_NAME"