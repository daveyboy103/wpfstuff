using SampleWPF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfModels.Models;

namespace SampleWPF.Commands
{
    public class ApplyCommand : ICommand
    {
        private readonly ISampleDataService sampleDataService;
        private readonly MainWindowModel model;

        public ApplyCommand(MainWindowModel model)
        {
            this.sampleDataService = new SampleDataService();
            this.model = model;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            sampleDataService.Apply(model);
        }
    }
}
