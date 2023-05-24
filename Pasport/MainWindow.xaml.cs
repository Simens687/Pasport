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
using Ser_Deser;

namespace Pasport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vidach vidach = new Vidach();
        Lich lich = new Lich();

        Pasport_dan pasport_chela = new Pasport_dan();

        string PUT = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/pasport.json";
        public MainWindow()
        {
            InitializeComponent();

            DateTime dateNow = DateTime.Now;
            lich.Date_rozh_pik.DisplayDateStart = new DateTime(1900, 1, 1);
            lich.Date_rozh_pik.DisplayDateEnd = dateNow.AddYears(-14);

            vidach.Date_vid_pik.DisplayDateStart = new DateTime(1900, 1, 1);
            vidach.Date_vid_pik.DisplayDateEnd = dateNow;

        }

        private void Open(object sender, RoutedEventArgs e)
        {
        }

        private void Open_pasp(object sender, RoutedEventArgs e)
        {
            Page_(vidach);
        }

        private void Open_chel(object sender, RoutedEventArgs e)
        {
            Page_(lich);
        }

        private void Page_(object Page__)
        {
            Page___.Content = Page__;
        }

        private void Sohr(object sender, RoutedEventArgs e)
        {
            bool can = true;
            try
            {
                pasport_chela.Surename = lich.Surename_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Фамилия\': " + ex.Message); can = false; }

            try
            {
                pasport_chela.Name = lich.Name_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Имя\': " + ex.Message); can = false; }

            try
            {
                pasport_chela.Fathername = lich.Fathername_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Отчество\': " + ex.Message); can = false; }

            if (lich.Sex_cbx.Text == "Муж" || lich.Sex_cbx.Text == "Жен")
            {
                pasport_chela.sex = lich.Sex_cbx.Text;
            }
            else
            {
                MessageBox.Show("Поле \'пол\' не заполнено");
                can = false;
            }

            try
            {
                DateTime selectedDate = (DateTime)lich.Date_rozh_pik.SelectedDate;
                pasport_chela.date_rozh = new DateOnly(selectedDate.Year, selectedDate.Month, selectedDate.Day);
            }
            catch
            {
                MessageBox.Show("Поле \'Дата рож.\' не заполнено");
                can = false;
            }

            try
            {
                pasport_chela.Mest_rozh = lich.Mest_rozh_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Место рож.\': " + ex.Message); can = false; }

            try
            {
                pasport_chela.Ser_num = vidach.Ser_and_num_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Серия и номер\': " + ex.Message); can = false; }

            try
            {
                pasport_chela.Hwo_vid = vidach.Vidan_bx.Text;
            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Выдан\': " + ex.Message); can = false; }

            try
            {
                DateTime selectedDate_ = (DateTime)vidach.Date_vid_pik.SelectedDate;
                pasport_chela.date_vidach = new DateOnly(selectedDate_.Year, selectedDate_.Month, selectedDate_.Day);
            }
            catch
            {
                MessageBox.Show("Поле \'Дата выдачи.\' не заполнено");
                can = false;
            }

            try
            {
                pasport_chela.Code_pod = vidach.Code_bx.Text;

            }
            catch (Exception ex) { MessageBox.Show("Произошла ошибка в поле \'Код подразделения\': " + ex.Message); can = false; }

            if (can == true)
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Ser_and_deser.Serialize_All(pasport_chela, PUT);
            }
        }

        private void Vigrus(object sender, RoutedEventArgs e)
        {
            pasport_chela = Ser_and_deser.Deserialize<Pasport_dan>(PUT);

            lich.Surename_bx.Text = pasport_chela.Surename;
            lich.Name_bx.Text = pasport_chela.Name;
            lich.Fathername_bx.Text = pasport_chela.Fathername;
            lich.Sex_cbx.Text = pasport_chela.sex;

            DateTime selectedDate = new DateTime(pasport_chela.date_rozh.Year, pasport_chela.date_rozh.Month, pasport_chela.date_rozh.Day);
            lich.Date_rozh_pik.SelectedDate = selectedDate;

            lich.Mest_rozh_bx.Text = pasport_chela.Mest_rozh;
            

            vidach.Ser_and_num_bx.Text = pasport_chela.Ser_num;
            vidach.Vidan_bx.Text = pasport_chela.Hwo_vid;

            DateTime selectedDate_ = new DateTime(pasport_chela.date_vidach.Year, pasport_chela.date_vidach.Month, pasport_chela.date_vidach.Day);
            vidach.Date_vid_pik.SelectedDate = selectedDate_;

            vidach.Code_bx.Text = pasport_chela.Code_pod;
        }
    }
}
