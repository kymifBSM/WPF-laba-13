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
using System.Windows.Shapes;

namespace WPF_laba13
{
    public partial class task3 : Window
    {
        private List<Employees> employeesList;

        public task3()
        {
            InitializeComponent();

            employeesList = new List<Employees>
            {
                new Employees{ID = 3, Name = "John", Joing_Date = "18/05/2019", Gender = "Male", Monthly_Salary = 3000},
                new Employees{ID = 7, Name = "Marry", Joing_Date = "14/06/2019", Gender = "Female", Monthly_Salary = 3100},
            };

            employeeGrid.ItemsSource = employeesList;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (!int.TryParse(idTextBox.Text, out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid value.");
                return;
            }

            string name = nameTextBox.Text;
            string joinDate = joinDateTextBox.Text;
            string gender = genderTextBox.Text;

            int salary;
            if (!int.TryParse(salaryTextBox.Text, out salary))
            {
                MessageBox.Show("Invalid salary. Please enter a valid value.");
                return;
            }

            Employees newEmployee = new()
            {
                ID = id,
                Name = name,
                Joing_Date = joinDate,
                Gender = gender,
                Monthly_Salary = salary
            };

            employeesList.Add(newEmployee);
            employeeGrid.Items.Refresh();

            ClearInputFields();
        }

        private void ClearInputFields()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            joinDateTextBox.Clear();
            genderTextBox.Clear();
            salaryTextBox.Clear();
        }
    }
}