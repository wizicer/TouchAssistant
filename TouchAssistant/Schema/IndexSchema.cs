namespace TouchAssistant
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;

        internal class IndexSchema
        {
            public string ServerVersion { get; set; }
            public ProfileSchema[] Profiles { get; set; }
        }
}