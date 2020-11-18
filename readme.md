![SOC.io Logo](https://i.imgur.com/QUlrDdO.png) 


# SOC.&#8203;io



SOC.&#8203;io is a Windows all-in-one tool for cybersecurity analysts. It allows the user to quickly perform URL reputation checks and analyze the reputation of files.

It also provides a quick and easy-to-understand layout to generate reports, useful for using in your ticketing system (such as Jira, Slack,...).

  

## Description

  

Modules:

**URL Reputation**:  This module is used for retrieving information of different URLs or IP (v4) adresses. This module uses the APIs of:

*  [AbuseIPDB](https://www.abuseipdb.com/) - AbuseIPDB is a project dedicated to helping combat the spread of hackers, spammers, and abusive activity on the internet.

*  [Maltiverse](https://maltiverse.com/) - The open IoC Search Engine

*  [URLScan.IO](https://urlscan.io/) - A sandbox for the web.

![URL Reputation](https://i.imgur.com/nbE3xat.png =500x)
  
  
**File Analyzer:** This module will provide information for a given file. It will show the different hashes format (MD5, SHA256, SHA512) and it also can check the file in the following services:

*  [Hybrid-Analysis](https://www.hybrid-analysis.com/?lang=es) - Submit malware for free analysis with Falcon Sandbox and Hybrid Analysis

*  [Metadefender](https://metadefender.opswat.com/?lang=en) - The world's most powerful malware sandbox

>  **_NOTE:_** Only the hash will be shared with the different services. Your files are never uploaded to the website.
  

### Tech

  

SOC.&#8203;io uses:

  

*  [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework/net472) - Framework for creating Windows applications.

*  [LiveCharts](https://lvcharts.net/) - Simple, flexible, interactive & powerful data visualization for .Net

  

### Todos

This section is divided into new functionalities that could be added to the service:

- [New functionality] Add the option to send an URL to URLScan.io for the scan

- [New functionality] Add the categories of the website (Phishing, Port scanning, ...)

- Misc

- Integrate with Travis-CI (https://travis-ci.org/) or appveyor (https://www.appveyor.com/)




  
  

## Compilation

  

The project has been built using Microsoft Visual Studio 2019 Community Edition (https://visualstudio.microsoft.com/es/vs/community/)

  
  
  

## Inspiration

  

This project has been inspired by the following projects:

  

*  [Sooty](https://github.com/TheresAFewConors/Sooty) - Sooty is a tool developed with the task of aiding SOC analysts with automating part of their workflow..

*  [Malwoverview](hhttps://github.com/alexandreborges/malwoverview) - Malwoverview<nolink>.py is a simple tool to perform an initial and quick triage of malware samples, URLs and hashes.

  
  

You should check them out! They are awesome!