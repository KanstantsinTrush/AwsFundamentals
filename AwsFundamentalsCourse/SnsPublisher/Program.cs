using System.Text.Json;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using SnsPublisher;

var customer = new CustomerCreated()
{
    Id = Guid.NewGuid(),
    FullName = "Kostya Trush",
    Email = "kanstantsintrush@gmail.com",
    GitHubUSername = "kostyatrush",
    DateOfBirth = new DateTime(1998, 2, 19)
};

var snsClient = new AmazonSimpleNotificationServiceClient();

var topicArnResource = await snsClient.FindTopicAsync("customers");

var publishRequest = new PublishRequest
{
    TopicArn = topicArnResource.TopicArn,
    Message = JsonSerializer.Serialize(customer),
    MessageAttributes = new Dictionary<string, MessageAttributeValue>
    {
        {
            "MessageType", new MessageAttributeValue
            {
                DataType = "String",
                StringValue = nameof(CustomerCreated)
            }
        }
    }
};

var response = await snsClient.PublishAsync(publishRequest);