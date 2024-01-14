using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

var secretManagerClient = new AmazonSecretsManagerClient();

var request = new GetSecretValueRequest
{
    SecretId = "ApiKey"
};

var response = await secretManagerClient.GetSecretValueAsync(request);

Console.WriteLine(response.SecretString);

var describeSecretRequest = new DescribeSecretRequest
{
    SecretId = "ApiKey"
};

var describeRespinse = await secretManagerClient.DescribeSecretAsync(describeSecretRequest);

Console.WriteLine();