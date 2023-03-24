using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
//Najim Sultani
//Classes Methods
//3-24-23

namespace classes2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Course csi122;
       // A block of code that is given a name, and runs when it is called
        //You use the* ____ operator * do you use to access members inside of an instanced class?
        //Dot operater to acces inside the onjects

        public MainWindow()
        {
            InitializeComponent();//
            csi122 = new Course("CSi 122", "jake mill");//NAME of the course and teacher
            //adds it all to csi122
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {//adding all the new students to csi 122
            AddStudentToList();

            int lastStudentEnterd = students.Count - 1;
            Student lastStudent = students[lastStudentEnterd];  

            csi122.EnrollStudent(lastStudent);

            //clear
            runDisplay.Text = "";
            //displays csi122 course name and csi122 teacher name
            runDisplay.Text = csi122.CourseName + " " + csi122.Teacher + "\n" ;
            //the end that displays everything together
            //csi122
            MessageBox.Show(csi122.RosterAverage().ToString());
            foreach (Student student in csi122.CourseRoster)
            {
                runDisplay.Text += student + "\n";
            }

            //DisplayStudents();  

            //how to display from the student fromm the list
            //runDisplay.Text = students[0].FirstName ;
        }

        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;//student name string
            string lastName = txtLastName.Text;//student last name string
            double csiGrade = double.Parse(txtCSIGrade.Text);//student csi grade number
            double genEdGrade = double.Parse(txtGenEdGrade.Text);//student gen ed grade number

            //add student to the list of students
            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));


        }

        public void DisplayStudents()
        {
            //clear the display
            runDisplay.Text = "";
            //shows all the students
            for (int i = 0; i < students.Count; i++)
            {
                //for loop to add students to the course
                runDisplay.Text += students[i] + "\n";

            }
        }


    }
}
