﻿using Newtonsoft.Json;

namespace ReadmeMetricsLib.HarJsonObjectModels
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    class QueryStrings
    {
        public string name { get; set; }  
        public string value { get; set; }  
    }
}
