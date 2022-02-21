## Register custom domain for azure functions / web apps
- go to your azure function / web app
- go to **Custom domains**
### Add custom domain
- validate the domain e.g. xi-rocks.ext.easylife365.cloud
- save custom domain
### Register certificate
- in function go to **TLS/SSL settings**
- go to **Private Key Certificates** and click on **Create App Service Managed Certificate**
- Choose your custom domain entry and create a Certificate for it
- Go back to Bindings and add TLS/SSL binding
- bind the Certificate with your custom domain, **SNI/SSL** or type and **add Binding**
![binding](https://user-images.githubusercontent.com/91621287/154977490-bf8998bc-7f5a-472f-b528-abd389588c0f.png)
