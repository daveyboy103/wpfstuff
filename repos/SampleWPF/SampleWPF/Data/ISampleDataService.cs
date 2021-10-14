using System.Net;
using System.Threading.Tasks;
using WpfModels.Models;

namespace SampleWPF.Data
{
    public interface ISampleDataService
    {
        Task<MainWindow> Get(int id);
        void Apply(MainWindowModel model);
    }
}
