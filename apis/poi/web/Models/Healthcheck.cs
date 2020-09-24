﻿using System;
using Newtonsoft.Json;

namespace poi.Models
{
    public class Healthcheck
    {
        public Healthcheck()
        {
            Message = "POI Service Healthcheck. Docker Image: \""+Environment.GetEnvironmentVariable("DOCKER_CUSTOM_IMAGE_NAME")+"\"";
            Status = "Healthy";
        }
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message {get;set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
