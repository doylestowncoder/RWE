using System;
using Microsoft.Extensions.Logging;

namespace RWE.Common.Logger;
public static class AppLogTemplates
{
    private const string IdPropertyName = "Id";
    private const string MessageIdPropertyName = "MessageId";
    private const string EmailPropertyName = "Email";
    public const string SendMessagePostBegin = $"Sending a message to Service Bus. Id: {{{IdPropertyName}}} Email: {{{EmailPropertyName}}}";
    public const string SendMessagePostEnd = $"Completed sending message to Service Bus. Id: {{{IdPropertyName}}} Email: {{{EmailPropertyName}}}";
    public const string SendMessageBegin = $"Begin - {MessageIdPropertyName}: {{{MessageIdPropertyName}}} {EmailPropertyName}: {{{EmailPropertyName}}}";
    public const string SendMessageEnd = $"End - {MessageIdPropertyName}: {{{MessageIdPropertyName}}} {EmailPropertyName}: {{{EmailPropertyName}}}";
}