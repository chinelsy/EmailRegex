using System;
using System.Text.RegularExpressions;
using System.Text;

namespace RegexEmail
{
    class Program
    {
        //Find all the emails in a string. count them
        //and print as well.if no email is found, print not found.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any words or sentences of your " +
           "choice to check for an email match: ");
            Console.WriteLine();
            string emailSamples = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string mails=FindAllEmails(emailSamples);
            Console.WriteLine("email will be counted");
            Console.WriteLine(mails);
            Console.ResetColor();
            //Console.WriteLine(FindAllEmails(mails));
            // Console.ReadLine();
        }
        public static string FindAllEmails(string emailInput)
        {
            string data = (emailInput);

            //instantiate pattern that will match our regex 

            Regex emailRegex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z]+(\.[a-zA-Z0-9]+)+",
            RegexOptions.IgnoreCase);

            //find items that matches with our regex pattern
            MatchCollection emailMatches = emailRegex.Matches(data);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            string emailsRecieved = sb.ToString();
            return emailsRecieved;

            // return sb.ToString(); OR


        }
    }
}
