
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using MVVMInfrastructure;

namespace WPFMVVMDemo.ViewModel
{
    public class MainWindowsViewModel : NotifyObject
    {
        private String _disPlayText;

        public string DisPlayText
        {
            get
            {
                return _disPlayText;
            }
            set
            {
                SetPropertyNotify(ref _disPlayText, value, nameof(DisPlayText));
            }
        }
        private readonly ObservableCollection<DisplayModel> _listModel;
        public ObservableCollection<DisplayModel> ListModel => _listModel;


        private readonly NVDelegateCommand<KeyCommandParam> _keyDownCommand;
        public NVDelegateCommand<KeyCommandParam> KeyDownCommand => _keyDownCommand;

        private readonly NVCommand _addCommand;
        public NVCommand AddCommand
        {
            get => _addCommand;
        }

        private readonly NVCommand _subtractCommand;
        public NVCommand SubtractCommand
        {
            get => _subtractCommand;
        }

        private readonly NVCommand _multiplyCommand;
        public NVCommand MultiplyCommand
        {
            get => _multiplyCommand;
        }

        private readonly NVCommand _divideCommand;
        public NVCommand DivideCommand
        {
            get => _divideCommand;
        }

        public MainWindowsViewModel()
        {
            _addCommand = new NVCommand(AddHandler);
            _subtractCommand = new NVCommand(SubtractHandler);
            _multiplyCommand = new NVCommand(MultiplyHandler);
            _divideCommand = new NVCommand(DivideHandler);
            _keyDownCommand = new NVDelegateCommand<KeyCommandParam>(KeyDownHandler);
            _listModel = new ObservableCollection<DisplayModel>();
        }

        private Int32 _index;

        private void KeyDownHandler(KeyCommandParam keyCommandParam)
        {
            var key = keyCommandParam.Key;

            DisPlayText = key.ToString();

            _index++;
            _listModel.Add(new DisplayModel { Content = DisPlayText, Index = _index });
        }

        private void AddHandler()
        {
            DisPlayText = "+";
        }

        private void SubtractHandler()
        {
            DisPlayText = "-";
        }

        private void MultiplyHandler()
        {
            DisPlayText = "*";
        }

        private void DivideHandler()
        {
            DisPlayText = "/";
        }
    }
}
