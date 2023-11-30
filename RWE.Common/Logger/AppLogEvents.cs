using System;
using Microsoft.Extensions.Logging;

namespace RWE.Common.Logger;

public static class AppLogEvents
{
    public static EventId Create = new(1000, "Created");
    public static EventId Read = new(1001, "Read");
    public static EventId Update = new(1002, "Updated");
    public static EventId Delete = new(1003, "Deleted");
}