namespace TouchAssistant
{
    using System;
    using System.Linq;

    internal class ApplicationModel
    {
        public string Name { get; set; }
        public string TitleMatchPattern { get; set; }
        public KeyModel[] Keys { get; set; }
    }
}