using System;
using Xunit;

namespace AWS_CICDServicesTest
{
    public class AWSCICDServicesTest
    {
        [Fact]
        public void TestSuccess1()
        {

        }

        [Fact]
        public void TestSuccess2()
        {

        }

        [Theory]
        [InlineData("https://www.google.com")]
        [InlineData("fffaaa")]
        public void TestMalformedUri(string uri)
        {
            new Uri(uri);
        }
    }
}
