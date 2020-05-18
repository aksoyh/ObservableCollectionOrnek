using ObservableCollectionOrnek.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ObservableCollectionOrnek
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Person> PeopleDataSource { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            PeopleDataSource = new ObservableCollection<Person>(Person.getPeople());
            this.DataContext = this;

        }

        private void BtnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            PeopleDataSource.Add(new Person { personID = PeopleDataSource.Count + 1, Name = txtName.Text, Title = txtTitle.Text });
        }
        
    }
}
