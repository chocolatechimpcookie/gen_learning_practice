using PersonLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            //Person[] people;
            List<Person> people;

            people = peopleRepo.GetPeople();

            PersonListBox.ItemsSource = people;

            //foreach (var person in people)
                //PersonListBox.Items.Add(person);


        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            //IEnumerable people;
            //generic version
            IEnumerable<Person> people;
            // strongly typed has more methods available, non generic
            //same output

            people = peopleRepo.GetPeople();


            //foreach (var person in people)
            //    PersonListBox.Items.Add(person);

            //adding manually

            PersonListBox.ItemsSource = people;
            //data binding instead. If you do this, you need to do it all over.

            //same as above method, but this one uses an interface instead of a specific type 
            // both list of person and person array use INumerable


        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //PersonListBox.Items.Clear();
            ///manually
            ///

            PersonListBox.ItemsSource = null;
            //^same thing as above
        }
    }
}
