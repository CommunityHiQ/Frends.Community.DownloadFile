# Frends.Community.DownloadFile #

#### Property Parameters.Address

 Exact address of the file to be downloaded 



---
#### Property Parameters.DestinationFilePath

 Exact location and name of the file to be created 



---
## Type Options

 Options for the call 



---
#### Property Options.AllowInvalidCertificate

 Allows invalid SSL certificate 



---
#### Property Options.UseGivenUserCredentialsForRemoteConnections

 If set, allows you to give the user credentials to use to write files on remote hosts. If not set, the agent service user credentials will be used. Note: For writing files on the local machine, the agent service user credentials will always be used, even if this option is set. 



---
#### Property Options.UserName

 This needs to be of format domain\username 



---
#### Method WebFiles.DownloadFile(Frends.Community.DownloadFile.Parameters,Frends.Community.DownloadFile.Options)

 Read contents as string for a single file. See: https://github.com/FrendsPlatform/Frends.File 

**Returns**: Object {string FilePath } 



---


