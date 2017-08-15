# Frends.Community.Web #

#### Property DownloadFile.Parameters.Address

 Exact address of the file to be downloaded 



---
#### Property DownloadFile.Parameters.DestinationFilePath

 Exact location and name of the file to be created 



---
## Type DownloadFile.Options

 Options for the call 



---
#### Property DownloadFile.Options.AllowInvalidCertificate

 Allows invalid SSL certificate 



---
#### Property DownloadFile.Options.UseGivenUserCredentialsForRemoteConnections

 If set, allows you to give the user credentials to use to write files on remote hosts. If not set, the agent service user credentials will be used. Note: For writing files on the local machine, the agent service user credentials will always be used, even if this option is set. 



---
#### Property DownloadFile.Options.UserName

 This needs to be of format domain\username 



---
#### Method DownloadFile.Execute(Frends.Community.Web.DownloadFile.Parameters,Frends.Community.Web.DownloadFile.Options)

 Read contents as string for a single file. See: https://github.com/FrendsPlatform/Frends.File 

**Returns**: Object {string FilePath } 



---


