# UriHttpStatus
IMPORTANT NOTE: This sample code is provided for the purpose of illustration only and is not intended to be used in a production environment.

A console application based on .NET framework 4.7.2 to access a URI and return back the HTTP response status code either in text or numeric value. This project was created using Microsoft Visual Studio 2019. This utility can be used to test the status of URI on the Internet/Intranet.

USAGE:
Checks the HTTP status of URI. This command requires Internet access if the URI is on the Internet.

UriHtpStatus [-text | -numeric] uri
-text           Get HTTP Status of the uri and return the status in text representation.
-numeric        Get HTTP Status of the uri and return the status in numeric representation.
uri             URI that you need to check status for.

You can only use one option, either -text or -numeric and you cannot use both together.

Here is a reference for what does the HTTP status code means:
https://docs.microsoft.com/en-us/dotnet/api/system.net.httpstatuscode

You can test this utility by executing it in the command prompt:
C:\> UriHttpStatus.exe -numeric http://httpstat.us/200
200
C:\> UriHttpStatus.exe -text http://httpstat.us/200
OK
C:\> UriHttpStatus.exe -numeric http://httpstat.us/404
404
C:\> UriHttpStatus.exe -text http://httpstat.us/404
NotFound
C:\> UriHttpStatus.exe -numeric http://httpstat.us/500
500
C:\> UriHttpStatus.exe -text http://httpstat.us/500
InternalServerError


