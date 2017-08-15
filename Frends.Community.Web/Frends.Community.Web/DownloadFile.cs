using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using SimpleImpersonation;

namespace Frends.Community.Web
{
    public static class DownloadFile
    {
        public class HTTPHeader
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class Parameters
        {
            /// <summary>
            /// Exact address of the file to be downloaded
            /// </summary>
            public string Address { get; set; }
            public HTTPHeader[] Headers { get; set; }
            /// <summary>
            /// Exact location and name of the file to be created
            /// </summary>
            public string DestinationFilePath { get; set; }

        }

        /// <summary>
        /// Options for the call
        /// </summary>
        public class Options
        {
            /// <summary>
            /// Allows invalid SSL certificate
            /// </summary>
            public bool AllowInvalidCertificate { get; set; }

            /// <summary>
            /// If set, allows you to give the user credentials to use to write files on remote hosts. 
            /// If not set, the agent service user credentials will be used.
            /// Note: For writing files on the local machine, the agent service user credentials will always be used, even if this option is set.
            /// </summary>
            public bool UseGivenUserCredentialsForRemoteConnections { get; set; }

            /// <summary>
            /// This needs to be of format domain\username
            /// </summary>
            [DefaultValue("\"domain\\username\"")]
            public string UserName { get; set; }

            [PasswordPropertyText]
            public string Password { get; set; }
        }

        public class Output
        {
            public string FilePath { get; set; }
        }

        public static Output Execute(Parameters parameters, Options options)
        {
            using (var webClient = new WebClient())
            {
                foreach (var header in parameters.Headers)
                {
                    webClient.Headers.Add(header.Name, header.Value);
                }

                if (options.AllowInvalidCertificate)
                    ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;

                if (options.UseGivenUserCredentialsForRemoteConnections)
                {
                    var domainAndUserName = GetDomainAndUserName(options.UserName);
                    using (Impersonation.LogonUser(domainAndUserName[0], domainAndUserName[1], options.Password, LogonType.NewCredentials))
                    {
                        webClient.DownloadFile(parameters.Address, parameters.DestinationFilePath);
                    }
                }
                else
                {
                    webClient.DownloadFile(parameters.Address, parameters.DestinationFilePath);
                }

            }

            return new Output() { FilePath = parameters.DestinationFilePath };

        }

        private static string[] GetDomainAndUserName(string username)
        {
            var domainAndUserName = username.Split('\\');
            if (domainAndUserName.Length != 2)
            {
                throw new ArgumentException($@"UserName field must be of format domain\username was: {username}");
            }
            return domainAndUserName;
        }
    }
}
