using System.Text.Json.Serialization;

namespace phrase_web.Models
{
    public class PhraseResult
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

    }
}
