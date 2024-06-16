using System.Windows.Forms;
using MajorExpressTestTask.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace MajorExpressTestTask.UI;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        System.Windows.Forms.Application.EnableVisualStyles();
        System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

        var serviceCollection = new ServiceCollection();
        var startup = new Startup();
        startup.ConfigureServices(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var mainForm = serviceProvider.GetRequiredService<MainForm>();

        System.Windows.Forms.Application.Run(mainForm);
    }
}