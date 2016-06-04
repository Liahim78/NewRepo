using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TaskForPlarium.Comands;
using TaskForPlarium.Models;
using TaskForPlarium.Views;

namespace TaskForPlarium.ViewModels
{
    class PlariumViewModel:ViewModelIBase
    {
        Model myModel = new Model();
        private DelegateCommand<string> digitButtonPressCommand;
        
        public string FullExpression
        {
            get { return fullExpression; }
            set { fullExpression = value; OnPropertyChanged("FullExpression"); }
        }
        public string Display
        {
            get { return display; }
            set { display = value; OnPropertyChanged("Display"); }
        }

        public ICommand ChooseButtonPressCommand
        {
            get
            {
                if (digitButtonPressCommand == null)
                {
                    digitButtonPressCommand = new DelegateCommand<string>(
                         myModel.ChooseButton, (string button) => { return true; });
                }
                return digitButtonPressCommand;
            }
        }
    }
}
