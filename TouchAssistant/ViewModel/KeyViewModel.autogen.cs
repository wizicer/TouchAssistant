// -----------------------------------------------------------------------
// Auto generated by Hidden Code Auto Generator
// Don't modify this file manually!
// <auto-generated />
// -----------------------------------------------------------------------

namespace TouchAssistant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal partial class KeyViewModel 
    {
        /// <summary>
        /// Field which backs the Name property
        /// </summary>
        private string _name = null;
        /// <summary>
        /// Gets / sets the Name value
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                var old = _name;
                _name = value;
                OnNameChanged(old, value);
                OnPropertyChanged("Name");
            }
        }
    
        /// <summary>
        /// Invoked when the value of Name changes
        /// </summary>
        partial void OnNameChanged(string oldValue, string newValue);
        /// <summary>
        /// Field which backs the Key property
        /// </summary>
        private VirtualKeys? _key = null;
        /// <summary>
        /// Gets / sets the Key value
        /// </summary>
        public VirtualKeys? Key
        {
            get { return _key; }
            set
            {
                if (_key == value) return;
                var old = _key;
                _key = value;
                OnKeyChanged(old, value);
                OnPropertyChanged("Key");
            }
        }
    
        /// <summary>
        /// Invoked when the value of Key changes
        /// </summary>
        partial void OnKeyChanged(VirtualKeys? oldValue, VirtualKeys? newValue);
    }
}
