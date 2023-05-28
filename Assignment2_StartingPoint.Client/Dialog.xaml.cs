using Assignment2_StartingPoint.Domain.DTOs;
using System.Windows;

namespace Assignment2_StartingPoint.Client
{
    /// <summary>
    /// Interaction logic for DialogBorrowbook.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public int MemberID { get; set; }
        public int BookID { get; set; }

        public Dialog()
        {
            InitializeComponent();
            PopularCombo();
        }

        private void PopularCombo()
        {
            using var server = new HttpSever();
            
            var membersItemsSource = server.ViewAllMembers().List;
            members.ItemsSource = membersItemsSource;            

            var booksItemsSource = server.ViewAllBooks().List;
            books.ItemsSource = booksItemsSource;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var memberDTO = (MemberDTO)members.SelectedItem;
            var bookDTO = (BookDTO)books.SelectedItem;
            MemberID = memberDTO.ID;
            BookID = bookDTO.Id;

            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }    
}
