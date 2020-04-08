using System;
using System.Collections.Generic;
using System.Data;
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

namespace BookCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bookListBox.ItemsSource = MyBookCollection.GetMyCollection();
            FormatComboBox.ItemsSource = Enum.GetValues(typeof(BookFormat)).Cast<BookFormat>();
        }

        private void bookListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Book row_selected = (Book)lb.SelectedItem;
            if(row_selected != null)
            {
                IdLabel.Content = row_selected.Id.ToString();
                TitleTextBox.Text = row_selected.Title.ToString();
                AuthorTextBox.Text = row_selected.Author.ToString();
                YearTextBox.Text = row_selected.Year.ToString();
                IsReadCheckBox.IsChecked = row_selected.IsRead;
                FormatComboBox.SelectedItem = row_selected.Format;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Book> new_books = new List<Book>();
            new_books = MyBookCollection.GetMyCollection();
            Book new_book = new Book(new_books.Last().Id + 1);
            new_book.Title = TitleTextBox.Text;
            new_book.Author = AuthorTextBox.Text;
            new_book.Year = Int32.Parse(YearTextBox.Text);
            new_book.IsRead = (bool)IsReadCheckBox.IsChecked;
            new_book.Format = (BookFormat)FormatComboBox.SelectedItem;
            bookListBox.ItemsSource = new_books;
            new_books.Add(new_book);
            bookListBox.ItemsSource = new_books;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // needs implementation 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Book> new_books = new List<Book>();
            new_books = MyBookCollection.GetMyCollection();
            Book bookToRemove = new_books.Single(b => b.Title == TitleTextBox.Text);
            new_books.Remove(bookToRemove);
            bookListBox.ItemsSource = new_books;
        }
    }
}
