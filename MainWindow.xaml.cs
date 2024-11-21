using System.Windows;

namespace LedgerLight
{

    public partial class MainWindow : Window
    {
        private static int window = 0;

        private void SetWindow()
        {
            switch (window)
            {
                case 0:
                    gd_Main.Children.Clear();
                    Views.Dashboard dashboard = new Views.Dashboard();
                    gd_Main.Children.Add(dashboard);
                    break;
                case 1:
                    gd_Main.Children.Clear();
                    Views.PurchaseInvoice purchaseInvoice = new Views.PurchaseInvoice();
                    gd_Main.Children.Add(purchaseInvoice);
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            SetWindow();
        }

        private void SelectDashboardWindow(object sender, RoutedEventArgs e)
        {
            window = 0;
            SetWindow();
        }

        private void SelectPurchaseInvoiceWindow(object sender, RoutedEventArgs e)
        {
            window = 1;
            SetWindow();
        }

    }
}
