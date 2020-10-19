# Frends.Community.DownloadFile

FRENDS Community Task to download a file from internet

[![Actions Status](https://github.com/CommunityHiQ/Frends.Community.DownloadFile/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.DownloadFile/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.DownloadFile) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 

- [Installing](#installing)
- [Tasks](#tasks)
     - [DownloadFile](#DownloadFile)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the task via FRENDS UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.DownloadFile

# Tasks

## DownloadFile

Downloads a file from internet.

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

### Returns

| Property        | Type     | Description                      |
|-----------------|----------|----------------------------------|
| FilePath        | string   | Full path of the downloaded file|

Usage:
To fetch result use syntax:

`#result.DownloadFile`

# Building

Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.DownloadFile.git`

Rebuild the project

`dotnet build`

Testing

No tests defined for DownloadFile task.

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes                                         |
| --------| ------------------------------------------------|
| 1.0.0   | Initial version of DownloadFile                 |
| 1.0.9   | Task now support SimpleImpersonation version 3. |
| 1.0.10  | Converted to support .Net Standard & .Net 4.7.1 |
