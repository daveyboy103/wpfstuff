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

        public ApplyCommand(ISampleDataService sampleDataService)
        {
            if (sampleDataService is null)
            {
                throw new ArgumentNullException(nameof(sampleDataService));
            }

            this.sampleDataService = sampleDataService;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            sampleDataService.Apply(parameter as MainWindowModel);
        }
    }
}
