using Microsoft.AspNetCore.Http;
using ObiletJourneyApp.Models.DTO;
using System;
using System.Linq;

namespace ObiletJourneyApp.Extensions
{
    public static class SessionExtensions
    {
        public static GetSessionRequest ToGetSessionDto(this HttpContext context)
        {
            var ip = context.Connection.RemoteIpAddress?.ToString() ?? "0.0.0.0";
            var port = context.Connection.RemotePort.ToString();

            var userAgent = context.Request.Headers["User-Agent"].FirstOrDefault() ?? "Unknown";
            string browserName = "Unknown";
            string browserVersion = "Unknown";
            if (userAgent.Contains("Chrome"))
            {
                browserName = "Chrome";
                var idx = userAgent.IndexOf("Chrome/");
                if (idx >= 0)
                {
                    var version = userAgent.Substring(idx + 7).Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                    if (!string.IsNullOrEmpty(version))
                        browserVersion = version;
                }
            }

            else if (userAgent.Contains("Edg/"))
            {
                browserName = "Edge";
                var idx = userAgent.IndexOf("Edg/");
                if (idx >= 0)
                {
                    var version = userAgent.Substring(idx + 4).Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                    if (!string.IsNullOrEmpty(version))
                        browserVersion = version;
                }
            }
            else if (userAgent.Contains("Firefox"))
            {
                browserName = "Firefox";
                var idx = userAgent.IndexOf("Firefox/");
                if (idx >= 0)
                {
                    var version = userAgent.Substring(idx + 8).Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                    if (!string.IsNullOrEmpty(version))
                        browserVersion = version;
                }
            }
         

            return new GetSessionRequest
            {
                Type = 1,
                Connection = new ConnectionInfoDto
                {
                    IpAddress = ip,
                    Port = port
                },
                Browser = new BrowserInfoDto
                {
                    Name = browserName,
                    Version = browserVersion
                }
            };
        }

        public static DeviceSessionDto ToSessionInfo(this ISession session)
        {
            var sessionId = session.GetString("SessionId");
            var deviceId = session.GetString("DeviceId");

            return new DeviceSessionDto
            {
                SessionId = sessionId ?? string.Empty,
                DeviceId = deviceId ?? string.Empty
            };
        }
    }
}