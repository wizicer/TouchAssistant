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
        internal void InitData(ProfileSchema am)
        {
            if (am == null)
            {
                this.Title = null;
                this.Keys = null;
                return;
            }

            this.Title = am.Application;
            this.Keys = new ObservableCollection<KeyViewModel>(am.Keys.Select(_ => new KeyViewModel { Key = _.Key, Name = _.Name }));
        }
    }
}
