# **Cloud.Core.Telemetry.Logging** 
[![Build status](https://dev.azure.com/cloudcoreproject/CloudCore/_apis/build/status/Cloud.Core%20Packages/Cloud.Core.Telemetry.Logging_Package)](https://dev.azure.com/cloudcoreproject/CloudCore/_build/latest?definitionId=9)  ![Code Coverage](https://cloud1core.blob.core.windows.net/codecoveragebadges/Cloud.Core.Telemetry.Logging-LineCoverage.png) [![Cloud.Core.Telemetry.Logging package in Cloud.Core feed in Azure Artifacts](https://feeds.dev.azure.com/cloudcoreproject/dfc5e3d0-a562-46fe-8070-7901ac8e64a0/_apis/public/Packaging/Feeds/8949198b-5c74-42af-9d30-e8c462acada6/Packages/95e01cf4-39b8-40c7-a868-9feb96142b0f/Badge)](https://dev.azure.com/cloudcoreproject/CloudCore/_packaging?_a=package&feed=8949198b-5c74-42af-9d30-e8c462acada6&package=95e01cf4-39b8-40c7-a868-9feb96142b0f&preferRelease=true)


<div id="description">
	
Extensions to the Logging Provider functionality availability when configuring services for dependency injection.  Can be used with MVC web apps OR console apps and will utilise any `ITelemetryLogger`.
	
</div>

## Usage

The `AddTelemetryLogger` can be used when building your logging within your service collection, as follows:

```csharp
IServiceCollection services = new ServiceCollection();

services.AddSingleton<MyExample>();
services.AddLogging(loggers => {
	
	loggers.AddDebug()
	       // AppInsights is an example here, add any of our implementing ITelemetryLogger classes.
	       .AddTelemetryLogger(new AppInsightsLogger("<instrumentationKeyHere>"))
	       .AddConsole()
	       .AddSerilog()
	       .AddLogger(new Log4Net());
	       //etc...
});

```

## Test Coverage
A threshold will be added to this package to ensure the test coverage is above 80% for branches, functions and lines.  If it's not above the required threshold 
(threshold that will be implemented on ALL of the core repositories to gurantee a satisfactory level of testing), then the build will fail.

## Compatibility
This package has has been written in .net Standard and can be therefore be referenced from a .net Core or .net Framework application. The advantage of utilising from a .net Core application, 
is that it can be deployed and run on a number of host operating systems, such as Windows, Linux or OSX.  Unlike referencing from the a .net Framework application, which can only run on 
Windows (or Linux using Mono).
 
## Setup
This package is built using .net Standard 2.1 and requires the .net Core 3.1 SDK, it can be downloaded here: 
https://www.microsoft.com/net/download/dotnet-core/

IDE of Visual Studio or Visual Studio Code, can be downloaded here:
https://visualstudio.microsoft.com/downloads/

## How to access this package
All of the Cloud.Core.* packages are published to a internal NuGet feed.  To consume this on your local development machine, please add the following feed to your feed sources in Visual Studio:
https://pkgs.dev.azure.com/cloudcoreproject/CloudCore/_packaging/Cloud.Core/nuget/v3/index.json
 
For help setting up, follow this article: https://docs.microsoft.com/en-us/vsts/package/nuget/consume?view=vsts


<img src="https://cloud1core.blob.core.windows.net/icons/cloud_core_small.PNG" />
