using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WpfClient.StudentService;

namespace WpfClient {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        private static readonly Service1Client Proxy = new Service1Client();
        private bool _readyToAdd;
        private ObservableCollection<StudentDTO> _dataSource;

        public MainWindow() {
            InitializeComponent();
        }

        //private void Button1Click(object sender, RoutedEventArgs e)
        //{
        //    var proxy = new Service1Client();
        //    MessageBox.Show(proxy.GetData(1));
        //}

        private void WindowLoaded(object sender, RoutedEventArgs e) {
            try {
                // remove extension data in students
                _dataSource = new ObservableCollection<StudentDTO>(Proxy.GetAllStudents());
                studentGrid.ItemsSource = _dataSource;
                //studentGrid.Columns.RemoveAt(studentGrid.Columns.Count - 1);
            }
            catch (Exception) {
                MessageBox.Show("Webservice is not available at the moment !");
            }
        }

        private void StudentGridSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e) {
            foreach (DataGridCellInfo item in e.AddedCells) {
                var student = (StudentDTO) item.Item;
                tbAvg.Text = student.Avg.ToString();
                tbCode.Text = student.Code;
                tbFullname.Text = student.Fullname;
                dpBirthday.Text = DateTime.Parse(student.Birthday.ToString()).ToString();
            }
        }

        private void Button1Click(object sender, RoutedEventArgs e) {
            // Ready to add new row 
            if (_readyToAdd) {
                _readyToAdd = false;
                var student = new StudentDTO {
                                                 Avg = float.Parse(tbAvg.Text),
                                                 Birthday = DateTime.Parse(dpBirthday.Text),
                                                 Code = tbCode.Text,
                                                 Fullname = tbFullname.Text,
                                                 Status = true,
                                                 Id = Proxy.GetId()
                                             };
                Proxy.CreateStudent(student);
                _dataSource.Add(student);
            }
            else {
                _readyToAdd = true;
                tbFullname.Text = "Your full name!";
                tbCode.Text = "Your student code!";
                tbAvg.Text = "Your avg mark !";
                dpBirthday.Text = "Pick your birthday !";
            }
        }

        private void TbFullnameGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Your full name!")
                textBox.Text = "";
        }

        private void TbCodeGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Your student code!")
                textBox.Text = "";
        }

        private void TbAvgGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Your avg mark !")
                textBox.Text = "";
        }

        // Update 
        private void Button2Click(object sender, RoutedEventArgs e) {
            var selectedStudent = (StudentDTO) studentGrid.SelectedItems[0];
            var student = new StudentDTO {
                                             Avg = float.Parse(tbAvg.Text),
                                             Birthday = DateTime.Parse(dpBirthday.Text),
                                             Code = tbCode.Text,
                                             Fullname = tbFullname.Text,
                                             Status = true,
                                             Id = selectedStudent.Id
                                         };
            Proxy.UpdateStudent(student);
        }

        private void Button3Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (StudentDTO) studentGrid.SelectedItems[0];
            Proxy.DeleteStudent(selectedStudent);
            _dataSource.Remove(selectedStudent);
        }

    }
}