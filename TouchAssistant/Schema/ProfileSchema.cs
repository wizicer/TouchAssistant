namespace TouchAssistant
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;

        internal class ProfileSchema
        {
            public int Id { get; set; }
            public string Application { get; set; }
            public string Author { get; set; }
            public DateTime UpdateDate { get; set; }
            public double Rating { get; set; }
            public int Download { get; set; }
            public string TitleMatchPattern { get; set; }
            public KeySchema[] Keys { get; set; }
        }
}