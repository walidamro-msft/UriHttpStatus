# UriHttpStatus
IMPORTANT NOTE: This sample code is provided for the purpose of illustration only and is not intended to be used in a production environment.

A console application based on .NET framework 4.7.2 to access a URI and return back the HTTP response status code either in text or numeric value. This project was created using Microsoft Visual Studio 2019.

USAGE:
Checks the HTTP status of URI. This command requires Internet access if the URI is on the Internet.

UriHtpStatus [-text | -numeric] uri
-text           Get HTTP Status of the uri and return the status in text representation.
-numeric        Get HTTP Status of the uri and return the status in numeric representation.
uri             URI that you need to check status for.

You can only use one option, either -text or -numeric and you cannot use both together.
