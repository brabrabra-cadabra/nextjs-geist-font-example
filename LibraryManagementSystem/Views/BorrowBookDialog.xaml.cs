using System.Windows;

namespace LibraryManagementSystem.Views
{
    public partial class BorrowBookDialog : Window
    {
        public BorrowBookDialog()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
