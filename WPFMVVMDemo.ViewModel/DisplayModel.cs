using MVVMInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMDemo.ViewModel
{
    public class DisplayModel : NotifyObject
    {
        private Int32 _index;
        public Int32 Index
        {
            get { return _index; }
            set { SetPropertyNotify(ref _index, value, nameof(Index)); }
        }
        private string _content;
        public string Content { get { return _content; } set { SetPropertyNotify(ref _content, value, nameof(Content)); } }
    }
}
