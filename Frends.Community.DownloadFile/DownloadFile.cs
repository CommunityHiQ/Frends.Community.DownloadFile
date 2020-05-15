using System;
using System.Net;
using SimpleImpersonation;

#pragma warning disable 1591

namespace Frends.Community.DownloadFile
{
    public static class WebFiles
    {
        /// <summary>
        /// Read contents as string for a single file. See: https://github.com/FrendsPlatform/Frends.File
        /// </summary>
        /// <returns>Object {string FilePath }  </returns>
        public static Output DownloadFile(Parameters parameters, Options options)
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
                    Impersonation.RunAsUser(new UserCredentials(domainAndUserName[0], domainAndUserName[1], options.Password), LogonType.NewCredentials, () => webClient.DownloadFile(parameters.Address, parameters.DestinationFilePath));
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
