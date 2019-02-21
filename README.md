# **Cloud.Core.Telemetry.Logging**

<div id="description">

Extensions to the Logging Provider functionality availability when configuring services for dependency injection.  Can be used with MVC web apps OR console apps and will utilise any `ITelemetryLogger`.

</div>

## Usage

The `AddTelemetryLogger` can be used when building your logging within your service collection, as follows:

```csharp
IServiceCollection services = new ServiceCollection();

services.AddSingleton<MyExample>();
services.AddLogging(loggers => {
	loggers.AddTelemetryLogger(new AppInsightsLogger("<instrumentationKeyHere>")); // Add any of our implementing ITelemetryLogger classes.
	loggers.AddConsole(); // Add other standard loggers as normal.
	loggers.AddSerilog();
	loggers.AddLogger(new Log4Net
	//etc...
});

```

## Test Coverage
A threshold will be added to this package to ensure the test coverage is above 80% for branches, functions and lines.  If it's not above the required threshold 
(threshold that will be implemented on ALL of the new core repositories going forward), then the build will fail.

## Compatibility
This package has has been written in .net Standard and can be therefore be referenced from a .net Core or .net Framework application. The advantage of utilising from a .net Core application, 
is that it can be deployed and run on a number of host operating systems, such as Windows, Linux or OSX.  Unlike referencing from the a .net Framework application, which can only run on 
Windows (or Linux using Mono).
 
## Setup
This package requires the .net Core 2.1 SDK, it can be downloaded here: 
https://www.microsoft.com/net/download/dotnet-core/2.1

IDE of Visual Studio or Visual Studio Code, can be downloaded here:
https://visualstudio.microsoft.com/downloads/

## How to access this package
All of the Cloud.Core.* packages are published to our internal NuGet feed.  To consume this on your local development machine, please add the following feed to your feed sources in Visual Studio:
TBC

For help setting up, follow this article: https://docs.microsoft.com/en-us/vsts/package/nuget/consume?view=vsts
