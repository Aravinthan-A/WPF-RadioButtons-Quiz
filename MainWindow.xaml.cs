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

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void rbwrong7_Checked(object sender, RoutedEventArgs e)
        {
            lblfirst.Content = rbwrong0.Tag;
            rbwrong0.IsEnabled = false;
            rbcorrect.IsEnabled = false;
            rbwrong2.IsEnabled = false; 
            rbwrong3.IsEnabled = false;
        }
        private void Rbcorrect_Checked(object sender, RoutedEventArgs e)
        {
            lblfirst.Content = rbcorrect.Tag;
            rbwrong0.IsEnabled = false;
            rbcorrect.IsEnabled = false;
            rbwrong2.IsEnabled = false;
            rbwrong3.IsEnabled = false;
        }

        private void rbwrong8_Checked(object sender, RoutedEventArgs e)
        {
            lblfirst.Content=rbwrong2.Tag;
            rbwrong0.IsEnabled = false;
            rbcorrect.IsEnabled = false;
            rbwrong2.IsEnabled = false;
            rbwrong3.IsEnabled = false;
        }

        private void rbwrong3_Checked(object sender, RoutedEventArgs e)
        {
            lblfirst.Content = rbwrong3.Tag;
            rbwrong0.IsEnabled = false;
            rbcorrect.IsEnabled = false;
            rbwrong2.IsEnabled = false;
            rbwrong3.IsEnabled = false;
        }

        private void rbwrong5_Checked(object sender, RoutedEventArgs e)
        {
            lblsecond.Content=rbwrong5.Tag;
            rbwrong1.IsEnabled = false;
            rbwrong4.IsEnabled = false;
            rbwrong5.IsEnabled = false;
            rbanswer1.IsEnabled= false;
        }

        private void rbwrong1_Checked(object sender, RoutedEventArgs e)
        {
            lblsecond.Content=rbwrong1.Tag;
            rbwrong1.IsEnabled = false;
            rbwrong4.IsEnabled = false;
            rbwrong5.IsEnabled = false;
            rbanswer1.IsEnabled = false;
        }

        private void rbwrong4_Checked(object sender, RoutedEventArgs e)
        {
            lblsecond.Content=rbwrong4.Tag;
            rbwrong1.IsEnabled = false;
            rbwrong4.IsEnabled = false;
            rbwrong5.IsEnabled = false;
            rbanswer1.IsEnabled = false;
        }

        private void rbanswer1_Checked(object sender, RoutedEventArgs e)
        {
            lblsecond.Content=rbanswer1.Tag;
            rbwrong1.IsEnabled = false;
            rbwrong4.IsEnabled = false;
            rbwrong5.IsEnabled = false;
            rbanswer1.IsEnabled = false;
        }

        private void rbwrong10_Checked(object sender, RoutedEventArgs e)
        {
           lblthird.Content=rbwrong10.Tag;
            rbwrong10.IsEnabled = false;
            rbwrong11.IsEnabled = false;
            rbwrong12.IsEnabled= false;
            rbcorrect3.IsEnabled= false;
        }

        private void rbcorrect3_Checked(object sender, RoutedEventArgs e)
        {
            lblthird.Content = rbcorrect3.Tag;
            rbwrong10.IsEnabled = false;
            rbwrong11.IsEnabled = false;
            rbwrong12.IsEnabled = false;
            rbcorrect3.IsEnabled = false;
        }

        private void rbwrong11_Checked(object sender, RoutedEventArgs e)
        {
            lblthird.Content = rbwrong11.Tag;
            rbwrong10.IsEnabled = false;
            rbwrong11.IsEnabled = false;
            rbwrong12.IsEnabled = false;
            rbcorrect3.IsEnabled = false;
        }

        private void rbwrong12_Checked(object sender, RoutedEventArgs e)
        {
            lblthird.Content = rbwrong12.Tag;
            rbwrong10.IsEnabled = false;
            rbwrong11.IsEnabled = false;
            rbwrong12.IsEnabled = false;
            rbcorrect3.IsEnabled = false;
        }

        private void rbcorrect4_Checked(object sender, RoutedEventArgs e)
        {
            lblfourth.Content = rbcorrect4.Tag;
            rbwrong4.IsEnabled = false;
            rbwrong13.IsEnabled = false;
            rbwrong14.IsEnabled = false;
            rbwrong15.IsEnabled = false;
        }

        private void rbwrong13_Checked(object sender, RoutedEventArgs e)
        {
            lblfourth.Content=rbwrong13.Tag;
            rbwrong4.IsEnabled = false;
            rbwrong13.IsEnabled = false;
            rbwrong14.IsEnabled = false;
            rbwrong15.IsEnabled = false;
        }

        private void rbwrong14_Checked(object sender, RoutedEventArgs e)
        {
            lblfourth.Content=(string)rbwrong14.Tag;
            rbwrong4.IsEnabled = false;
            rbwrong13.IsEnabled = false;
            rbwrong14.IsEnabled = false;
            rbwrong15.IsEnabled = false;
        }

        private void rbwrong15_Checked(object sender, RoutedEventArgs e)
        {
            lblfourth.Content=((string)rbwrong15.Tag);
            rbwrong4.IsEnabled = false;
            rbwrong13.IsEnabled = false;
            rbwrong14.IsEnabled = false;
            rbwrong15.IsEnabled = false;
        }

        private void rbwrong16_Checked(object sender, RoutedEventArgs e)
        {
            lblfive.Content=(string)rbwrong16.Tag;
            rbwrong16.IsEnabled = false;
            rbwrong17.IsEnabled = false;
            rbcorrect5.IsEnabled = false;
            rbwrong18.IsEnabled = false;
        }

        private void rbcorrect5_Checked(object sender, RoutedEventArgs e)
        {
            lblfive.Content=rbcorrect5.Tag;
            rbwrong16.IsEnabled = false;
            rbwrong17.IsEnabled = false;
            rbcorrect5.IsEnabled = false;
            rbwrong18.IsEnabled = false;
        }

        private void rbwrong17_Checked(object sender, RoutedEventArgs e)
        {
            lblfive.Content=((string)rbwrong17.Tag);
            rbwrong16.IsEnabled = false;
            rbwrong17.IsEnabled = false;
            rbcorrect5.IsEnabled = false;
            rbwrong18.IsEnabled = false;
        }

        private void rbwrong18_Checked(object sender, RoutedEventArgs e)
        {
            lblfive.Content = rbwrong18.Tag;
            rbwrong16.IsEnabled = false;
            rbwrong17.IsEnabled = false;
            rbcorrect5.IsEnabled = false;
            rbwrong18.IsEnabled = false;
        }

        private void rbwrong19_Checked(object sender, RoutedEventArgs e)
        {
            lblsix.Content=((string)rbwrong19.Tag);
            rbwrong19.IsEnabled = false;
            rbwrong20.IsEnabled = false;
            rbwrong21.IsEnabled = false;
            rbanswer5.IsEnabled = false;
        }

        private void rbwrong20_Checked(object sender, RoutedEventArgs e)
        {
            lblsix.Content = rbwrong20.Tag;
            rbwrong19.IsEnabled = false;
            rbwrong20.IsEnabled = false;
            rbwrong21.IsEnabled = false;
            rbanswer5.IsEnabled = false;
        }

        private void rbwrong21_Checked(object sender, RoutedEventArgs e)
        {
            lblsix.Content=rbwrong21.Tag;
            rbwrong19.IsEnabled = false;
            rbwrong20.IsEnabled = false;
            rbwrong21.IsEnabled = false;
            rbanswer5.IsEnabled = false;
        }

        private void rbanswer5_Checked(object sender, RoutedEventArgs e)
        {
            lblsix.Content=(string)rbanswer5.Tag;
            rbwrong19.IsEnabled = false;
            rbwrong20.IsEnabled = false;
            rbwrong21.IsEnabled = false;
            rbanswer5.IsEnabled = false;
        }

        private void rbwrong22_Checked(object sender, RoutedEventArgs e)
        {
            lblseven.Content=rbwrong22.Tag;
            rbwrong22.IsEnabled = false;
            rbanswer6.IsEnabled= false;
            rbwrong23.IsEnabled = false;
            rbwrong24.IsEnabled = false;
        }

        private void rbwrong23_Checked(object sender, RoutedEventArgs e)
        {
            lblseven.Content= rbwrong23.Tag;
            rbwrong22.IsEnabled = false;
            rbanswer6.IsEnabled = false;
            rbwrong23.IsEnabled = false;
            rbwrong24.IsEnabled = false;
        }

        private void rbwrong24_Checked(object sender, RoutedEventArgs e)
        {
            lblseven.Content=rbwrong24.Tag;
            rbwrong22.IsEnabled = false;
            rbanswer6.IsEnabled = false;
            rbwrong23.IsEnabled = false;
            rbwrong24.IsEnabled = false;
        }

        private void rbanswer6_Checked(object sender, RoutedEventArgs e)
        {
            lblseven.Content=rbanswer6.Tag;
            rbwrong22.IsEnabled = false;
            rbanswer6.IsEnabled = false;
            rbwrong23.IsEnabled = false;
            rbwrong24.IsEnabled = false;
        }

        private void rbwrong25_Checked(object sender, RoutedEventArgs e)
        {
            lbleight.Content=rbwrong25.Tag;
            rbwrong25.IsEnabled = false;
            rbanswer7.IsEnabled = false;
            rbwrong26.IsEnabled = false;
            rbwrong27.IsEnabled = false;
        }

        private void rbwrong26_Checked(object sender, RoutedEventArgs e)
        {
            lbleight.Content= rbwrong26.Tag;
            rbwrong25.IsEnabled = false;
            rbanswer7.IsEnabled = false;
            rbwrong26.IsEnabled = false;
            rbwrong27.IsEnabled = false;
        }

        private void rbwrong27_Checked(object sender, RoutedEventArgs e)
        {
            lbleight.Content = rbwrong27.Tag;
            rbwrong25.IsEnabled = false;
            rbanswer7.IsEnabled = false;
            rbwrong26.IsEnabled = false;
            rbwrong27.IsEnabled = false;
        }

        private void rbanswer7_Checked(object sender, RoutedEventArgs e)
        {
            lbleight.Content= rbanswer7.Tag;
            rbwrong25.IsEnabled = false;
            rbanswer7.IsEnabled = false;
            rbwrong26.IsEnabled = false;
            rbwrong27.IsEnabled = false;
        }

        private void rbanswer8_Checked(object sender, RoutedEventArgs e)
        {
            lblnine.Content = rbanswer8.Tag;
            rbanswer8.IsEnabled= false;
            rbwrong28.IsEnabled = false;
            rbwrong29.IsEnabled = false;
            rbwrong30.IsEnabled = false;
        }

        private void rbwrong28_Checked(object sender, RoutedEventArgs e)
        {
            lblnine.Content= rbwrong28.Tag;
            rbanswer8.IsEnabled = false;
            rbwrong28.IsEnabled = false;
            rbwrong29.IsEnabled = false;
            rbwrong30.IsEnabled = false;
        }

        private void rbwrong29_Checked(object sender, RoutedEventArgs e)
        {
            lblnine.Content = rbwrong29.Tag;
            rbanswer8.IsEnabled = false;
            rbwrong28.IsEnabled = false;
            rbwrong29.IsEnabled = false;
            rbwrong30.IsEnabled = false;

        }

        private void rbwrong30_Checked(object sender, RoutedEventArgs e)
        {
            lblnine.Content = rbwrong30.Tag;
            rbanswer8.IsEnabled = false;
            rbwrong28.IsEnabled = false;
            rbwrong29.IsEnabled = false;
            rbwrong30.IsEnabled = false;
        }

        private void rbwrong31_Checked(object sender, RoutedEventArgs e)
        {
            lblten.Content= rbwrong31.Tag;
            rbanswer9.IsEnabled = false;
            rbwrong31.IsEnabled = false;
            rbwrong32.IsEnabled = false;
            rbwrong33.IsEnabled = false;
        }

        private void rbanswer9_Checked(object sender, RoutedEventArgs e)
        {
            lblten.Content= rbanswer9.Tag;
            rbanswer9.IsEnabled = false;
            rbwrong31.IsEnabled = false;
            rbwrong32.IsEnabled = false;
            rbwrong33.IsEnabled = false;
        }

        private void rbwrong32_Checked(object sender, RoutedEventArgs e)
        {
            lblten.Content= rbwrong32.Tag;
            rbanswer9.IsEnabled = false;
            rbwrong31.IsEnabled = false;
            rbwrong32.IsEnabled = false;
            rbwrong33.IsEnabled = false;
        }

        private void rbwrong33_Checked(object sender, RoutedEventArgs e)
        {
            lblten.Content = rbwrong33.Tag;
            rbanswer9.IsEnabled = false;
            rbwrong31.IsEnabled = false;
            rbwrong32.IsEnabled = false;
            rbwrong33.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(lblfirst.Content);
            int second = Convert.ToInt32(lblsecond.Content);
            int third = Convert.ToInt32(lblthird.Content);
            int Fourth = Convert.ToInt32(lblfourth.Content);
            int Five = Convert.ToInt32(lblfive.Content);
            int six = Convert.ToInt32(lblsix.Content);
            int seven = Convert.ToInt32(lblseven.Content);
            int Eight = Convert.ToInt32(lbleight.Content);
            int Nine = Convert.ToInt32(lblnine.Content);
            int Ten = Convert.ToInt32(lblten.Content);
            int result = first + second + third + Fourth + Five + six + seven + Eight + Nine + Ten;
            String resultvalue = " Your score 10/" + result.ToString();
            
            if(result<=5)
            {
                MessageBox.Show("Fail" + resultvalue, "Choose the Best Answer");
            }
            else
            {
                MessageBox.Show("Excellent" + resultvalue, "Choose the Best Answer");
            }
        }
    }
}
