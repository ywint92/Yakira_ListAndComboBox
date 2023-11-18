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

namespace Yakira_ListAndComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> firstNames = new List<string> { "John", "Jane", "Doe", "Mary", "Bob" };
        private object cbFirstNames;

        public MainWindow()
        {
            InitializeComponent();asvt b 
            cmbFirstName.ItemsSource = firstNames; // Assign our list to the combo box
        }

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cbFirstNames.SelectedIndex;

            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            // Using the index to get the first name from the list
            string firstName = firstNames[firstNameIndex];

            // Using the index to get the last name from the list
            string lastName = lastNames[lastNameIndex];

            // Concatenating a full name
            string fullName = firstName + " " + lastName;

            MessageBox.Show(fullName); // Display Full Name
        }   // btnDisplayFullName_Click

        private void lbLastNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<string> lastNames = new List<string> { "Smith", "Doe", "Johnson", "Taylor", "Brown" };
            lbLastNames.ItemsSource = lastNames;
        }

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text; // Users first name input

            string lastName = txtLastName.Text; // Users last name input

            firstNames.Add(firstName); // Adding first name to first name list
            lastNames.Add(lastName); // Adding last name to last name list

            // Refresh each of the Boxes to show the newly added names to the list

            cbFirstNames.Items.Refresh();
            lbLastNames.Items.Refresh();
            // btnAddNames_Click
        }

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cbFirstNames.SelectedIndex;
            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            firstNames.RemoveAt(firstNameIndex); // Removing first name
            lastNames.RemoveAt(lastNameIndex); // Removing last name


            // Refresh each of the Boxes to show the newly added names to the list

            cbFirstNames.Items.Refresh();
            lbLastNames.Items.Refresh();
        }   // btnRemoveStudentAtIndex_Click


        private void OnLastNamesSelected(object sender, SelectionChangedEventArgs e)
        {
            cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
        }
    }




}
