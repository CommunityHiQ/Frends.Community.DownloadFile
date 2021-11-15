using NUnit.Framework;
using System.IO;

namespace Frends.Community.DownloadFile.Tests
{
    [TestFixture]
    class DownloadFileTests
    {
        private static readonly string _directory = Path.Combine(TestContext.CurrentContext.TestDirectory, "testfiles");
        private static readonly string _filePath = Path.Combine(_directory, "picture.jpg");
        private static readonly string _targetFileAddress = @"https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Google_2015_logo.svg/1200px-Google_2015_logo.svg.png";

        [SetUp]
        public void Setup()
        {
            Directory.CreateDirectory(_directory);
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
            Directory.Delete(_directory);
        }

        [Test]
        public void TestFileDownload()
        {
            var parameters = new Parameters
            {
                Address = _targetFileAddress,
                DestinationFilePath = _filePath
            };
            var options = new Options
            {
                AllowInvalidCertificate = false,
                UseGivenUserCredentialsForRemoteConnections = false,
                UserName = "",
                Password = ""
            };
            var result = WebFiles.DownloadFile(parameters, options);
            Assert.AreEqual(result.FilePath, _filePath);
        }
    }
}
