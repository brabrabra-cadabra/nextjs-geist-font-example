using System.Windows;

namespace LibraryManagementSystem.Views
{
    public partial class BorrowHistoryDialog : Window
    {
        public BorrowHistoryDialog()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
