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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace PART_1
{
    /// <summary>
    /// Interaction logic for AddModule.xaml
    /// </summary>
    public partial class AddModule : Window
    {
        public AddModule()
        {
            InitializeComponent();
        }
        //declaration
        string ModuleCode;
        string Name;
        int numCredits;
        int classHour;
        int numWeeks;
        int HoursSpent;
        int remaining;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Module successfully added!");//notifies user soon as they've entered the module detail
            //textboxes
            string Code = txt_Code.Text;
            string Name = txt_Name.Text;
            int numWeeks = Convert.ToInt16(txt_Weeks.Text);
            int numCredits = Convert.ToInt16(txt_Creds.Text);
            int classHours = Convert.ToInt16(txt_ClassHours.Text);
            int HoursSpent = Convert.ToInt16(txt_HoursSpent.Text);
            int ten = 10;


            //Calculating self study hours
            int Hours = numCredits * ten / numWeeks;
            int selfStudy = Hours - classHours;
            txt_Study.Text = selfStudy.ToString();

            //calculating remaning hours
            int remain = HoursSpent - numWeeks;

            //dataGrid
            DateTime date = DateTime.Now;
            dataGrid.Items.Add(new
            {
                datePicker = datePicker,
                ModuleCode = Code,
                Module_Name = Name,
                NumberOfCredits = numCredits,
                ClassHours = classHours,
                WeeksPerSemester = numWeeks,
                HourSpentModule = HoursSpent,
                datePicker2 = datePicker2,
                SelfStudy = selfStudy,
                RemainingHours = remain,
                datePicker1 = datePicker1

            });
        }

       

        private void EXIT(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using our application! See you soon!"); // User Exits the app!
            System.Environment.Exit(0);
        }

        private void CLEAR(object sender, RoutedEventArgs e)
        {
            //This will clear all details after inserting
            txt_Code.Clear();
            txt_Name.Clear();
            txt_Creds.Clear();
            txt_ClassHours.Clear();
            txt_Weeks.Clear();  
            txt_Study.Clear();  
            txt_HoursSpent.Clear();

        }

        private void txt_Creds_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int numCredits = Convert.ToInt16(txt_Creds.Text); //prompts users to enter number of credits
                

            }
            catch (FormatException)
            {
                // Handle the  input is not when the number is valid 
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txt_ClassHours_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int classHour = Convert.ToInt16(txt_ClassHours.Text); //prompts user to add classHour

            }
            catch (FormatException)
            {
                // Handle the case 
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txt_Weeks_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int numWeeks = Convert.ToInt16(txt_Weeks.Text); //prompts user to add classHour
               
            }
            catch (FormatException)
            {
                // Handle the case of invalid input
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void txt_HoursSpent_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int HoursSpent = Convert.ToInt16(txt_HoursSpent.Text); //prompts users to enter number of credits
                



            }
            catch (FormatException)
            {
                // Handle the case where the input is not a valid number

                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }
    }
}
