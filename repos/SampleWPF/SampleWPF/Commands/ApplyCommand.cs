using SampleWPF.Data;
using SampleWPF.ViewModels;
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
        private readonly MainWindowViewModel viewModel;

        public ApplyCommand(MainWindowViewModel model)
        {
            this.sampleDataService = new SampleDataService();
            this.viewModel = model;
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
            return viewModel.Description.Length > 0;
        }

        public void Execute(object parameter)
        {
            sampleDataService.Apply(viewModel.Model);
        }
    }
}
