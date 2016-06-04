using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForPlarium.Views;

namespace TaskForPlarium.Models
{
    class Model
    {
        public void ChooseButton(string operation)
        {
            ChooseDirectory myWindow = new ChooseDirectory();
            myWindow.Show();
        }
    }
}
