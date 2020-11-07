# SOC.&#8203;io

SOC.&#8203;io is a Windows all-in-one tool for cybersecurity analysts.

## Description
Modules:
* URL Reputation: This module is used for retrieving information of different websites.
* File Analyzer: This module will provide information for a given file.

### Tech

SOC.&#8203;io uses:

* [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472) - Framework for creating Windows applications.
* [LiveCharts](https://lvcharts.net/) - Simple, flexible, interactive & powerful data visualization for .Net

### Todos
This section is divided into new functionalities and/or bug fixed for the different modules: 
 - URL Reputation
    - [New functionality] Add the option to send an URL to URLScan.io for the scan
    - [New functionality] Add the categories of the website (Phishing, Port scanning, ...)
- Settings
    - [New functionality] Add the option to add the ApiKeys through here
- Misc
    - Integrate with Travis-CI (https://travis-ci.org/)
     [Update] Probably we will use appveyor.com because of the problems that CI Travis has with .NET Framework.
    - Integrate with SonarCloud (https://sonarcloud.io/)
     [Update] We will have to reevalute this requirement
    
## Compilation

The project has been built using Microsoft Visual Studio 2019 Community Edition (https://visualstudio.microsoft.com/es/vs/community/)




