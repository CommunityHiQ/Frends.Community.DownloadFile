**[Table of Contents](http://tableofcontent.eu)**
- [Frends.Community.Web.DownloadFile](#frendscommunitywebdownloadfile)
  - [Contributing](#contributing)
  - [Documentation](#documentation)
    - [Parameters](#parameters)
    - [Options](#options)
    - [Result](#result)
  - [Change Log](#change-log)
  - [License](#license)


# Frends.Community.Web.DownloadFile
FRENDS Task that downloads a file from internet.

## Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

## Documentation

### Parameters

| Property            |  Type               | Description                                   | Example                     |
|---------------------|---------------------|-----------------------------------------------|-----------------------------|
| Address             | string              | Exact address of the file to be downloaded    | `https://api.github.com/repos/foo/bar/zipball` |
| DestinationFilePath | string              | Full path of the destination file             | `c:\temp\foo.txt`           |
| Headers             | Array(string,string)| List of headers the webrequest should contain | `Authorization token` `xxx` |

### Options

| Property                                    | Type           | Description                                    | Example                   |
|---------------------------------------------|----------------|------------------------------------------------|---------------------------|
| AllowInvalidCertificate                     | bool           | If set, allows invalid SSL certificates
| UseGivenUserCredentialsForRemoteConnections | bool           | If set, allows you to give the user credentials when downloading file to a remote host. If not set, the agent service user credentials will be used.| |
| UserName                                    | string         | Needs to be of format domain\username | `example\Admin` |
| Password                                    | string         | | |

### Result

| Property        | Type     | Description                      |
|-----------------|----------|----------------------------------|
| FilePath        | string   | Full path of the downloaded file|

## Change Log

| Version             | Changes                 |
| ---------------------| ---------------------|
| 1.0.0 | Initial version of DownloadFile |
| 1.0.9 | Task now support SimpleImpersonation version 3. |

## License

This project is licensed under the MIT License - see the LICENSE file for details
