namespace TouchAssistant
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;

    internal class DataService
    {
        internal static ProfileSchema[] GetData()
        {
            var basePath = @"Data\";
            var indexjson = File.ReadAllText(Path.Combine(basePath, "index.json"));
            var index = JsonConvert.DeserializeObject<IndexSchema>(indexjson);
            for (int i = 0; i < index.Profiles.Length; i++)
            {
                try
                {
                    var id = index.Profiles[i].Id;
                    var pfjson = File.ReadAllText(Path.Combine(basePath, $"{id}.json"));
                    var pfdetail = JsonConvert.DeserializeObject<ProfileSchema>(pfjson);
                    index.Profiles[i] = pfdetail;
                }
                catch (Exception)
                {
                }
            }

            return index.Profiles;
        }
    }
}