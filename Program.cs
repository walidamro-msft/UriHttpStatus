/*
# This Sample Code is provided for the purpose of illustration only and is not intended to be used 
# in a production environment. THIS SAMPLE CODE AND ANY RELATED INFORMATION ARE PROVIDED "AS IS" 
# WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
# WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. We grant You a nonexclusive, 
# royalty-free right to use and modify the Sample Code and to reproduce and distribute the object code 
# form of the Sample Code, provided that You agree: (i) to not use Our name, logo, or trademarks to 
# market Your software product in which the Sample Code is embedded; (ii) to include a valid copyright 
# notice on Your software product in which the Sample Code is embedded; and (iii) to indemnify, hold 
# harmless, and defend Us and Our suppliers from and against any claims or lawsuits, including attorneys’ 
# fees, that arise or result from the use or distribution of the Sample Code.

# This sample script is not supported under any Microsoft standard support program or service. 
# The sample script is provided AS IS without warranty of any kind. Microsoft further disclaims 
# all implied warranties including, without limitation, any implied warranties of merchantability 
# or of fitness for a particular purpose. The entire risk arising out of the use or performance of 
# the sample scripts and documentation remains with you. In no event shall Microsoft, its authors, 
# or anyone else involved in the creation, production, or delivery of the scripts be liable for any 
# damages whatsoever (including, without limitation, damages for loss of business profits, business 
# interruption, loss of business information, or other pecuniary loss) arising out of the use of or 
# inability to use the sample scripts or documentation, even if Microsoft has been advised of the 
# possibility of such damages 
*/

using System;
using System.Linq;

namespace UriHtpStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Count() == 0)
            {
                Console.WriteLine("The syntax of the command is incorrect.");
            }
            else
            {
                if (args[0].Equals("-h", StringComparison.CurrentCultureIgnoreCase) ||
                    args[0].Equals("-help", StringComparison.CurrentCultureIgnoreCase) ||
                    args[0].Equals("/h", StringComparison.CurrentCultureIgnoreCase) ||
                    args[0].Equals("/help", StringComparison.CurrentCultureIgnoreCase) ||
                    args[0].Equals("/?", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Checks the HTTP status of URI. This command requires Internet access if the URI is on the Internet.\n");
                    Console.WriteLine("UriHtpStatus [-text | -numeric] uri");
                    Console.WriteLine("-text   \tGet HTTP Status of the uri and return the status in text representation.");
                    Console.WriteLine("-numeric\tGet HTTP Status of the uri and return the status in numeric representation.");
                    Console.WriteLine("uri     \tURI that you need to check status for.\n");
                    Console.WriteLine("You can only use one option, either -text or -numeric and you cannot use both together.\n");
                }
                else
                {
                    if (args.Count() != 2)
                    {
                        Console.WriteLine("The syntax of the command is incorrect.");
                    }
                    else
                    {
                        if (args[0].Equals("-text", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine(HttpOperations.GetHttpResponseCode(args[1]).ToString());
                        }

                        if (args[0].Equals("-numeric", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine(((int)HttpOperations.GetHttpResponseCode(args[1])).ToString());
                        }
                    }
                }


#if DEBUG
                Console.ReadLine();
#endif

            }
        }
    }
}
