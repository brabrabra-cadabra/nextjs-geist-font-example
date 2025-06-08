using System.Windows;
using LibraryManagementSystem.ViewModels;

namespace LibraryManagementSystem.Views
{
    public partial class AddEditStudentDialog : Window
    {
        public AddEditStudentDialog()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is AddEditStudentViewModel viewModel)
            {
                viewModel.Save();
                if (viewModel.DialogResult)
                {
                    DialogResult = true;
                    Close();
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
