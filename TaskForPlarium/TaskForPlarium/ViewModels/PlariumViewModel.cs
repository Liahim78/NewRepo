using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TaskForPlarium.Comands;
using TaskForPlarium.Views;

namespace TaskForPlarium.ViewModels
{
    class PlariumViewModel:ViewModelIBase
    {

        private DelegateCommand<string> digitButtonPressCommand;
        public void ChooseButtonPress(string operation)
        {
            ChooseDirectory myWindow = new ChooseDirectory();
            myWindow.Show();
        }
        public ICommand ChooseButtonPressCommand
        {
            get
            {
                if (digitButtonPressCommand == null)
                {
                    digitButtonPressCommand = new DelegateCommand<string>(
                        ChooseButtonPress, (string button) => { return true; });
                }
                return digitButtonPressCommand;
            }
        }
    }
}
