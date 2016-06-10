namespace TouchAssistant
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;

        internal class KeySchema
        {
            public string Name { get; set; }
            public VirtualKeys Key { get; set; }
        }
}