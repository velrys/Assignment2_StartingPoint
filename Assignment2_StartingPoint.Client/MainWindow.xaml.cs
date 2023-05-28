using Assignment2_StartingPoint.Client;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace LibraryRentalSystem
{
    public partial class MainWindow : Window
    {
        private string urlServer = "https://localhost:7297";

        public MainWindow()
        {
            InitializeComponent();

            ViewCurrentLoans_Click(null, null);
        }       

        private void Borrowbook_Click(object sender, RoutedEventArgs e)
        {
            ShowDialogLoan(0);
        }        

        private void ReturnBook_Click(object sender, RoutedEventArgs e)
        {
            ShowDialogLoan(1);
        }        

        private void ViewMembers_Click(object sender, RoutedEventArgs e)
        {

            CreateGridViewColumns(new HttpSever().ViewMembers());
        }

        private void ViewAllBooks_Click(object sender, RoutedEventArgs e)
        {

            CreateGridViewColumns(new HttpSever().ViewBooks());
        }

        private void ViewCurrentLoans_Click(object sender, RoutedEventArgs e)
        {
            CreateGridViewColumns(new HttpSever().ViewCurrentLoans());
        }

        private void ShowDialogLoan(int operation)
        {
            Dialog returnDialogBorrowbook = new Dialog();
            returnDialogBorrowbook.MemberID = 0;
            returnDialogBorrowbook.BookID = 0;
            if (returnDialogBorrowbook.ShowDialog() == false)
            {
                bool valid = returnDialogBorrowbook.MemberID > 0 && returnDialogBorrowbook.BookID > 0;
                
                if (valid)
                {
                    using var server = new HttpSever();


                    Dictionary<string, string> result;

                    switch (operation)
                    {
                        case 1:
                            result = server.Returnbook(returnDialogBorrowbook.MemberID, returnDialogBorrowbook.BookID);
                            break;
                        case 2:
                            result = server.RenewLoan(returnDialogBorrowbook.MemberID, returnDialogBorrowbook.BookID);
                            break;
                        default:
                            result = server.Borrowbook(returnDialogBorrowbook.MemberID, returnDialogBorrowbook.BookID);
                            break;
                    }

                    if (result.TryGetValue("message", out string value))
                    {
                        MessageBox.Show(value);
                    }
                }


                ViewCurrentLoans_Click(null, null);
            }
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            this.Close();   
        }
        private void RenewLoan_Click(object sender, RoutedEventArgs e)
        {
            ShowDialogLoan(2);
        }

        private void CreateGridViewColumns<T>(List<T> items)
        {
            listViewItems.Visibility = Visibility.Hidden;
            // Limpar as colunas existentes (se houver)
            gridViewItems.Columns.Clear();

            // Criar uma coluna para cada propriedade do objeto Item
            foreach (var property in typeof(T).GetProperties())
            {
                // Criar uma nova coluna
                GridViewColumn column = new GridViewColumn();
                column.Header = property.Name;
                column.DisplayMemberBinding = new System.Windows.Data.Binding(property.Name);

                // Adicionar a coluna ao GridView
                gridViewItems.Columns.Add(column);
            }
            listViewItems.ItemsSource = items;
            listViewItems.Visibility = Visibility.Visible;
        }
    }
}