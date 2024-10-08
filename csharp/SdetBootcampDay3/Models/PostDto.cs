﻿using Newtonsoft.Json;

namespace SdetBootcampDay3.Models
{
    public class PostDto
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("body")]
        public string Body { get; set; } = string.Empty;
    }
}
