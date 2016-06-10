namespace TouchAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class DataGen
    {
        internal static ApplicationModel[] GetData()
        {
            var m = new List<ApplicationModel>();
            var tckeys = new KeyModel[]
            {
                new KeyModel { FunctionName = "Up", Key = VirtualKeys.Up },
                new KeyModel { FunctionName = "Down", Key = VirtualKeys.Down },
            };
            m.Add(new ApplicationModel { Name = "Total Commander", TitleMatchPattern = "Total Commander.*", Keys = tckeys });

            return m.ToArray();
        }
    }
}