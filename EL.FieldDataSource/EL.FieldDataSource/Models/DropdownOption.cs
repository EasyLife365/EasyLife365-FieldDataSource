using System;
using System.Text.Json.Serialization;

namespace EL.FieldDataSource
{
    public class DropdownOption
    {
        [JsonPropertyName("key")]
        public String Key { get; set; }
        [JsonPropertyName("text")]
        public String Text { get; set; }
    }
}
