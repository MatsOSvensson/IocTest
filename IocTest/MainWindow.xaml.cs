using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Interfaces;
using IocFactory;
using Unity;

namespace IocTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IUnityContainer container;

        public MainWindow(IUnityContainer container)
        {
            InitializeComponent();
            this.container = container;
        }

        private void QuotButtton_Click(object sender, RoutedEventArgs e)
        {
            IQuotFactory factory = container.Resolve<IQuotFactory>();
            IQuotService service = factory.GetQuotService();
            QuotTextBlock.Text = service.GetQuot();
        }
    }
}
