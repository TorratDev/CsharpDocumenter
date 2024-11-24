using System.Text.Json.Serialization;

namespace BatchDocumentationTool;

[JsonSerializable(typeof(Todo[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}