using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfClient.Controller;
using WpfClient.Model;

namespace WpfClient {
    /// <summary>
    ///   Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        /* private static readonly Service1Client Proxy = new Service1Client();*/
        private ObservableCollection<StudentDTO> _dataSource;
        private string _imageFile = null;

        public MainWindow() {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e) {
            try {

                _dataSource = new ObservableCollection<StudentDTO>(StudentController.GetAll());
                studentGrid.ItemsSource = _dataSource;
                studentGrid.Columns[0].Visibility = Visibility.Hidden;
            }
            catch (Exception) {
                MessageBox.Show("Webservice is not available at the moment !");
            }
        }

        private static BitmapImage StreamToBitMapImage(Stream stream) {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = stream;
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.EndInit();
            return bitmap;
        }

        private void StudentGridSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e) {
            try
            {
                foreach (var student in e.AddedCells.Select(item => (StudentDTO)item.Item))
                {
                    tbAvg.Text = student.Avg.ToString();
                    tbCode.Text = student.Code;
                    tbName.Text = student.Name;
                    dpBirthday.Text = DateTime.Parse(student.Birthday.ToString()).ToString();

                    // Get Image from service
                    var stream = StudentController.GetImage(student.Name) ?? StudentController.GetImage("default");
                    image.Source = StreamToBitMapImage(stream);
                }
            } catch { }
        }

        private void Button1Click(object sender, RoutedEventArgs e) {
            // Ready to add new row 
            switch (button1.Content.ToString()) {
                case "Add": {
                    button1.Content = "New";
                    var student = new StudentDTO {
                                                     Avg = float.Parse(tbAvg.Text),
                                                     Birthday = DateTime.Parse(dpBirthday.Text),
                                                     Code = tbCode.Text,
                                                     Name = tbName.Text,
                                                     Status = true,
                                                 };
                    StudentController.Create(student, _imageFile);
                    _dataSource.Add(student);
                }
                    break;
                case "New":
                    button1.Content = "Add";
                    button1.IsEnabled = false;
                    tbName.Text = "Name";
                    tbCode.Text = "Student Code";
                    tbAvg.Text = "Average Mark";
                    dpBirthday.Text = "Birthday";
                    break;
            }
        }

        private void TbNameGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Name")
                textBox.Text = "";
        }

        private void TbCodeGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Student Code")
                textBox.Text = "";
        }

        private void TbAvgGotFocus(object sender, RoutedEventArgs e) {
            var textBox = (TextBox) sender;
            if (textBox.Text == "Average Mark")
                textBox.Text = "";
        }

        // Update 
        private void Button2Click(object sender, RoutedEventArgs e) {
            var selectedStudent = (StudentDTO) studentGrid.SelectedItems[0];
            var index = studentGrid.SelectedIndex;
            var student = new StudentDTO {
                                             Avg = float.Parse(tbAvg.Text),
                                             Birthday = DateTime.Parse(dpBirthday.Text),
                                             Code = tbCode.Text,
                                             Name = tbName.Text,
                                             Status = true,
                                             Id = selectedStudent.Id
                                         };
            if (StudentController.Update(student, _imageFile) == "failed") {
                MessageBox.Show("Update failed");
            } else {
                _dataSource[index] = student;
            }
        }

        private void Button3Click(object sender, RoutedEventArgs e) {
            var selectedStudent = (StudentDTO)studentGrid.SelectedItems[0];
            if (StudentController.Delete(selectedStudent) == "failed") {
                MessageBox.Show("Delete failed");
            } else {
                _dataSource.Remove(selectedStudent);
            }
        }


        private void CheckInputStatus(object sender, SelectionChangedEventArgs e)
        {
            DateTime tmp ;
            if (!DateTime.TryParse(dpBirthday.Text, out tmp)) return;
            if (tbName.Text == "Name" || tbAvg.Text == "Average Mark" || tbCode.Text == "Student Code")
                button1.IsEnabled = false;
            else 
                button1.IsEnabled = true;
        }

        private void ImageMouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            var dlg = new Microsoft.Win32.OpenFileDialog { DefaultExt = ".jpg", Filter = "JPEG|*.jpg|PNG|*.png" };
            // Display OpenFileDialog by calling ShowDialog method
            if (dlg.ShowDialog() != true) return;
            _imageFile = dlg.FileName;
            image.Source = new BitmapImage(new Uri(dlg.FileName));
        }
    }
}