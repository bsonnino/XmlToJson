using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace XmlToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serializer = new XmlSerializer(typeof(catalog));

            //using var reader = new StreamReader("books.xml");
            //var catalog = (catalog)serializer.Deserialize(reader);
            //reader.Close();

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //var jsonCatalog = JsonSerializer.Serialize(catalog, options);
            //File.WriteAllText("books.json", jsonCatalog);
            //var serializer = new XmlSerializer(typeof(catalog));

            var serializer = new XmlSerializer(typeof(object));
            using var reader = new StreamReader("books.xml");
            var catalog = serializer.Deserialize(reader);
            reader.Close();

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonCatalog = JsonSerializer.Serialize(catalog, options);
            File.WriteAllText("books.json", jsonCatalog);
        }
    }

}
