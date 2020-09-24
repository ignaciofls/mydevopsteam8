using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        public Healthcheck()
        {
            Message = "POI Service Healthcheck";
            Status = "Healthy";
            System.String s = Environment.GetEnvironmentVariable("DOCKER_CUSTOM_IMAGE_NAME");
            DockerVersionNumber = s.Substring(s.IndexOf(':'));
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {
          get; set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dockerversionumber")]
        public string DockerVersionNumber {
          get; set;
        }
    }
}
