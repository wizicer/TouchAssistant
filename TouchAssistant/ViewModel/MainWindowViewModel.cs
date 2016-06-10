// <AutoGen src="..\..\Common\AutoGen.cs" />

namespace TouchAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [AutoGen("Keys", typeof(ObservableCollection<KeyViewModel>), null)]
    [AutoGen("Title", typeof(string), null)]
    internal partial class MainWindowViewModel : ViewModelBase
    {
        internal void InitData(ApplicationModel am)
        {
            if (am == null)
            {
                am = new ApplicationModel { Name = null, Keys = new KeyModel[] { } };
            }

            this.Title = am.Name;
            this.Keys = new ObservableCollection<KeyViewModel>(am.Keys.Select(_ => new KeyViewModel { Key = _.Key, Name = _.FunctionName }));
        }
    }
}
