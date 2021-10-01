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
using System.Globalization;

namespace CARGAS_DE_VENTO_REV00
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
/////       CAIXAS DE TEXTO    
        private void s1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void s2_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void s3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void z_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void v0_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void vk_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void s1_click(object sender, EventArgs e)
        {
            s1.Text = "";
            a.IsChecked = false;
            b.IsChecked = false;
            c.IsChecked = false;

        }   //OK
        private void s2_click(object sender, EventArgs e)
        {
            s2.Text = "";
            sA.IsChecked = false;
            sB.IsChecked = false;
            sC.IsChecked = false;
            si.IsChecked = false;
            sii.IsChecked = false;
            siii.IsChecked = false;
            siv.IsChecked = false;
            sv.IsChecked = false;
            Z.Text = "Z - Altura (m)";
        }   //OK
        private void s3_click(object sender, EventArgs e)
        {
            s3.Text = "";
            i.IsChecked = false;
            ii.IsChecked = false;
            iii.IsChecked = false;
            iv.IsChecked = false;
            v.IsChecked = false;

        }   //OK
        private void vk_click(object sender, EventArgs e)
        {
            vk.Text = "";
        }   //OK
        private void z_click(object sender, EventArgs e)
        {
            Z.Text = "";
        }    //OK
        private void v0_click(object sender, EventArgs e)
        {
            v0.Text = "";
        }   //OK


        /////       CAIXAS DE SELEÇÃO
        private void a_checked(object sender, RoutedEventArgs e)
        {   string a = "1";
            s1.Text = a;
            b.IsChecked = false;
            c.IsChecked = false;

        } //OK
        private void b_checked(object sender, RoutedEventArgs e)
        {

            a.IsChecked = false;
            c.IsChecked = false;
        }
        private void c_checked(object sender, RoutedEventArgs e)
        {
            string aa = "0.9";
            s1.Text = aa;
            a.IsChecked = false;
            b.IsChecked = false;

        } //OK
        private void a_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void sA_Checked(object sender, RoutedEventArgs e)
        {
            sB.IsChecked = false;
            sC.IsChecked = false;
        }
        private void sB_Checked(object sender, RoutedEventArgs e)
        {

            sA.IsChecked = false;
            sC.IsChecked = false;
        }
        private void sC_Checked(object sender, RoutedEventArgs e)
        {

            sB.IsChecked = false;
            sA.IsChecked = false;
        }
        private void i_Checked(object sender, RoutedEventArgs e)
        {
            string a = "1.1";
            s3.Text = a;
            ii.IsChecked = false;
            iii.IsChecked = false;
            iv.IsChecked = false;
            v.IsChecked = false;
        } //OK
        private void ii_Checked(object sender, RoutedEventArgs e)
        {
            string a = "1";
            s3.Text = a;
            i.IsChecked = false;
            iii.IsChecked = false;
            iv.IsChecked = false;
            v.IsChecked = false;


        } //OK
        private void iii_Checked(object sender, RoutedEventArgs e)
        {
            string a = "0.95";
            s3.Text = a;
            ii.IsChecked = false;
            i.IsChecked = false;
            iv.IsChecked = false;
            v.IsChecked = false;
        } //OK
        private void iv_Checked(object sender, RoutedEventArgs e)
        {
            string a = "0.88";
            s3.Text = a;
            ii.IsChecked = false;
            iii.IsChecked = false;
            i.IsChecked = false;
            v.IsChecked = false;

        } //OK
        private void v_Checked(object sender, RoutedEventArgs e)
        {
            string a = "0.83";
            s3.Text = a;
            ii.IsChecked = false;
            iii.IsChecked = false;
            iv.IsChecked = false;
            i.IsChecked = false;

        } //OK
        private void si_Checked(object sender, RoutedEventArgs e)
        {
            sii.IsChecked = false;
            siii.IsChecked = false;
            siv.IsChecked = false;
            sv.IsChecked = false;
        }
        private void sii_Checked(object sender, RoutedEventArgs e)
        {
            si.IsChecked = false;
            siii.IsChecked = false;
            siv.IsChecked = false;
            sv.IsChecked = false;

        }
        private void siii_Checked(object sender, RoutedEventArgs e)
        {
            sii.IsChecked = false;
            si.IsChecked = false;
            siv.IsChecked = false;
            sv.IsChecked = false;

        }
        private void siv_Checked(object sender, RoutedEventArgs e)
        {

            sii.IsChecked = false;
            siii.IsChecked = false;
            si.IsChecked = false;
            sv.IsChecked = false;
        }
        private void sv_Checked(object sender, RoutedEventArgs e)
        {

            sii.IsChecked = false;
            siii.IsChecked = false;
            siv.IsChecked = false;
            si.IsChecked = false;
        }

        /////   BOTÕES
        private void click_calcular_vk(object sender, RoutedEventArgs e)
        {
            //double v00 = double.Parse(v0.Text.Replace(",", "."));
            //double S11 = double.Parse(s1.Text.Replace(",", "."));
            //double s22 = double.Parse(s2.Text.Replace(",", "."));
            //double s33 = double.Parse(s3.Text.Replace(",", "."));
            //double vkk = v00 * S11 * s22 * s33;
            //MessageBoxResult result1 = MessageBox.Show(S11.ToString());
            //MessageBoxResult result2 = MessageBox.Show(s22.ToString());
            //MessageBoxResult result3 = MessageBox.Show(s33.ToString());
            //MessageBoxResult result4 = MessageBox.Show(v00.ToString());
            //vk.Text = (vkk).ToString();
            if (v0.Text == "Insira o Valor" || s1.Text == "Insirao valor ou selecione" || s2.Text == "Insira o valor ou calcule" || s3.Text == "Insira o valor ou selecione")
            {
                MessageBoxResult Erro = MessageBox.Show("Insira os valores antes de calcular a velocidade característica!");
            }
            else
            {
                v0.Text = v0.Text.Replace(",", ".");
                s1.Text = s1.Text.Replace(",", ".");
                s2.Text = s2.Text.Replace(",", ".");
                s3.Text = s3.Text.Replace(",", ".");
                double v00 = double.Parse(v0.Text, CultureInfo.InvariantCulture);
                double S11 = double.Parse(s1.Text, CultureInfo.InvariantCulture);
                double s22 = double.Parse(s2.Text, CultureInfo.InvariantCulture);
                double s33 = double.Parse(s3.Text, CultureInfo.InvariantCulture);
                double vkk = v00 * S11 * s22 * s33;
               // MessageBoxResult result1 = MessageBox.Show(S11.ToString());
               // MessageBoxResult result2 = MessageBox.Show(s22.ToString());
               // MessageBoxResult result3 = MessageBox.Show(s33.ToString());
               // MessageBoxResult result4 = MessageBox.Show(v00.ToString());
                vk.Text = (vkk).ToString();
            }
        }   
        private void show_tabela1(object sender, RoutedEventArgs e)
        {
            t55 subWindows = new t55();
            subWindows.Show();
        }
        private void show_tabela2(object sender, RoutedEventArgs e)
        {
            t44 subWindows = new t44();
            subWindows.Show();
        }
        private void show_tabela3(object sender, RoutedEventArgs e)
        {

            t33 subWindow3 = new t33();
            subWindow3.Show();
        }

        private void show_tabela4(object sender, RoutedEventArgs e)
        {

            Window1 subWindow = new Window1();
            subWindow.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            if (abc.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: A")
            {
                sA.IsChecked = true;
                sB.IsChecked = false;
                sC.IsChecked = false;

            }
            if (abc.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: B")
            {
                sA.IsChecked = false;
                sB.IsChecked = true;
                sC.IsChecked = false;

            }
            if (abc.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: C")
            {
                sA.IsChecked = false;
                sB.IsChecked = false;
                sC.IsChecked = true;

            }


        }
        private void SEGUNDACAIXA(object sender, SelectionChangedEventArgs e)
        {
            if (abc_Copy.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: I")
            {
                si.IsChecked = true;
                sii.IsChecked = false;
                siii.IsChecked = false;
                siv.IsChecked = false;
                sv.IsChecked = false;

            }
            if (abc_Copy.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: II")
            {
                si.IsChecked = false;
                sii.IsChecked = true;
                siii.IsChecked = false;
                siv.IsChecked = false;
                sv.IsChecked = false;

            }
            if (abc_Copy.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: III")
            {
                si.IsChecked = false;
                sii.IsChecked = false;
                siii.IsChecked = true;
                siv.IsChecked = false;
                sv.IsChecked = false;

            }
            if (abc_Copy.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: IV")
            {
                si.IsChecked = false;
                sii.IsChecked = false;
                siii.IsChecked = false;
                siv.IsChecked = true;
                sv.IsChecked = false;

            }
            if (abc_Copy.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: V")
            {
                si.IsChecked = false;
                sii.IsChecked = false;
                siii.IsChecked = false;
                siv.IsChecked = false;
                sv.IsChecked = true;

            }
        }
        private void SEGUNDACAIXA2(object sender, SelectionChangedEventArgs e)
        {
            if (abc_Copy1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: I")
            {
                i.IsChecked = true;
                ii.IsChecked = false;
                iii.IsChecked = false;
                iv.IsChecked = false;
                v.IsChecked = false;

            }
            if (abc_Copy1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: II")
            {
                i.IsChecked = false;
                ii.IsChecked = true;
                iii.IsChecked = false;
                iv.IsChecked = false;
                v.IsChecked = false;

            }
            if (abc_Copy1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: III")
            {
                i.IsChecked = false;
                ii.IsChecked = false;
                iii.IsChecked = true;
                iv.IsChecked = false;
                v.IsChecked = false;

            }
            if (abc_Copy1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: IV")
            {
                i.IsChecked = false;
                ii.IsChecked = false;
                iii.IsChecked = false;
                iv.IsChecked = true;
                v.IsChecked = false;

            }
            if (abc_Copy1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: V")
            {
                i.IsChecked = false;
                ii.IsChecked = false;
                iii.IsChecked = false;
                iv.IsChecked = false;
                v.IsChecked = true;

            }
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {       
                { Z.Text = Z.Text.Replace(".", ",");
                double aaa = 0;
                double bbb = 0;
                double zzz = double.Parse(Z.Text);
                if (sA.IsChecked == true)
                {
                    aaa = 0;
                }
                if (sB.IsChecked == true)
                {
                    aaa = 1;
                }
                if (sC.IsChecked == true)
                {
                    aaa = 2;
                }
                if (si.IsChecked == true)
                {
                    bbb = 0;
                }
                if (sii.IsChecked == true)
                {
                    bbb = 1;
                }
                if (siii.IsChecked == true)
                {
                    bbb = 2;
                }
                if (siv.IsChecked == true)
                {
                    bbb = 3;
                }
                if (sv.IsChecked == true)
                {
                    bbb = 4;
                }
                int z0 = 0;
                if (zzz <= 5)
                {
                    z0 = 0;
                }
                float stat = 10;
                float fint = 5;
                if (zzz <= stat & zzz > fint)
                { z0 = 1; }
                stat = 15;
                fint = 10;
                if (zzz <= stat & zzz > fint)
                {
                    z0 = 2;
                }
                stat = 20;
                fint = 15;
                if (zzz <= stat & zzz > fint)
                {
                    z0 = 3;
                }
                stat = 30;
                fint = 20;
                int i = 4;
                while (i < 8)
                {
                    if (zzz <= stat & zzz > fint)
                    {
                        z0 = i;
                    }
                    i = i + 1;
                    stat = stat + 10;
                    fint = fint + 10;
                }
                stat = 80;
                fint = 60;
                while (i < 15)
                {
                    if (zzz <= stat & zzz > fint)
                    {
                        z0 = i;
                    }
                    i = i + 1;
                    stat = stat + 20;
                    fint = fint + 20;
                }
                stat = 250;
                fint = 200;
                while (i < 19)
                {
                    if (zzz <= stat & zzz > fint)
                    {
                        z0 = i;
                    }
                    i = i + 1;
                    stat = stat + 50;
                    fint = fint + 50;
                }
                if (zzz <= 420 & zzz > 400)
                {
                    z0 = 19;
                }
                if (zzz <= 450 & zzz > 420)
                {
                    z0 = 20;
                }
                if (zzz <= 500 & zzz > 450)
                {
                    z0 = 21;
                }
                if (zzz > 500)
                {
                    z0 = 22;
                }
                double[] S22 = new double[28];
                if (bbb == 0)
                {
                    if (aaa == 0)
                    {
                        S22 = new double[] { 1.06, 1.10, 1.13, 1.15, 1.17, 1.20, 1.21, 1.22, 1.25, 1.26, 1.28, 1.29, 1.30, 1.31, 1.32, 1.34, 0, 0, 0, 0, 0, 0 };
                    }
                    if (aaa == 1)
                    {
                        S22 = new double[22] { 1.04, 1.06, 1.09, 1.12, 1.15, 1.17, 1.19, 1.21, 1.23, 1.25, 1.27, 1.28, 1.29, 1.31, 1.32, 1.34, 0, 0, 0, 0, 0, 0 };

                    }
                    if (aaa == 2)
                    {
                        S22 = new double[22] { 1.01, 1.06, 1.09, 1.12, 1.15, 1.17, 1.19, 1.21, 1.23, 1.25, 1.27, 1.28, 1.29, 1.31, 1.32, 1.33, 0, 0, 0, 0, 0, 0 };
                    }

                }
                if (bbb == 1)
                {
                    if (aaa == 0)
                    {
                        S22 = new double[22] { 0.94, 1.00, 1.04, 1.06, 1.10, 1.13, 1.15, 1.16, 1.19, 1.22, 1.24, 1.25, 1.27, 1.28, 1.29, 1.31, 1.34, 0, 0, 0, 0, 0 };
                    }
                    if (aaa == 1)
                    {
                        S22 = new double[22] { 0.92, 0.98, 1.02, 1.04, 1.08, 1.11, 1.13, 1.15, 1.18, 1.21, 1.23, 1.24, 1.26, 1.27, 1.28, 1.31, 1.33, 0, 0, 0, 0, 0 };

                    }
                    if (aaa == 2)
                    {
                        S22 = new double[22] { 0.89, 0.95, 0.99, 1.02, 1.06, 1.09, 1.12, 1.14, 1.17, 1.20, 1.22, 1.24, 1.25, 1.27, 1.28, 1.31, 1.33, 0, 0, 0, 0, 0 };
                    }

                }
                if (bbb == 2)
                {
                    if (aaa == 0)
                    {
                        S22 = new double[22] { 0.88, 0.94, 0.98, 1.01, 1.05, 1.08, 1.10, 1.12, 1.16, 1.18, 1.20, 1.22, 1.24, 1.26, 1.27, 1.30, 1.32, 1.34, 0, 0, 0, 0 };
                    }
                    if (aaa == 1)
                    {
                        S22 = new double[22] { 0.86, 0.92, 0.96, 0.99, 1.03, 1.06, 1.09, 1.11, 1.14, 1.17, 1.20, 1.22, 1.23, 1.25, 1.26, 1.29, 1.32, 1.34, 0, 0, 0, 0 };

                    }
                    if (aaa == 2)
                    {
                        S22 = new double[22] { 0.82, 0.88, 0.93, 0.96, 1.00, 1.04, 1.06, 1.09, 1.12, 1.15, 1.18, 1.20, 1.22, 1.23, 1.25, 1.28, 1.31, 1.33, 0, 0, 0, 0 };
                    }

                }
                if (bbb == 3)
                {
                    if (aaa == 0)
                    {
                        S22 = new double[22] { 0.79, 0.86, 0.90, 0.93, 0.98, 1.01, 1.04, 1.07, 1.10, 1.13, 1.16, 1.18, 1.20, 1.22, 1.23, 1.27, 1.29, 1.32, 1.34, 1.35, 0, 0 };
                    }
                    if (aaa == 1)
                    {
                        S22 = new double[22] { 0.76, 0.83, 0.88, 0.91, 0.96, 0.99, 1.02, 1.04, 1.08, 1.11, 1.14, 1.16, 1.18, 1.20, 1.21, 1.25, 1.27, 1.30, 1.32, 1.35, 0, 0 };

                    }
                    if (aaa == 2)
                    {
                        S22 = new double[22] { 0.73, 0.80, 0.84, 0.88, 0.93, 0.96, 0.99, 1.02, 1.06, 1.09, 1.12, 1.14, 1.16, 1.18, 1.20, 1.23, 1.26, 1.29, 1.32, 1.33, 0, 0 };
                    }

                }
                if (bbb == 4)
                {
                    if (aaa == 0)
                    {
                        S22 = new double[22] { 0.74, 0.74, 0.79, 0.82, 0.87, 0.91, 0.94, 0.97, 1.01, 1.05, 1.07, 1.10, 1.12, 1.14, 1.16, 1.20, 1.23, 1.26, 1.29, 1.30, 1.32, 1.34 };
                    }
                    if (aaa == 1)
                    {
                        S22 = new double[22] { 0.72, 0.72, 0.76, 0.80, 0.85, 0.89, 0.93, 0.95, 1.00, 1.03, 1.06, 1.09, 1.11, 1.14, 1.16, 1.20, 1.23, 1.26, 1.29, 1.30, 1.32, 1.34 };

                    }
                    if (aaa == 2)
                    {
                        S22 = new double[22] { 0.67, 0.67, 0.72, 0.76, 0.82, 0.86, 0.89, 0.92, 0.97, 1.01, 1.04, 1.07, 1.10, 1.12, 1.14, 1.18, 1.22, 1.26, 1.29, 1.30, 1.32, 1.34 };
                    }

                }
                s2.Text = S22[z0].ToString();
                s2.Text = s2.Text.Replace(",", ".");
                }
               
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   double tetta = double.Parse(TTTttt.Text);
            double zetta = double.Parse(ZZZzzz.Text);
            double detta = double.Parse(DDDddd.Text);
            if (pontoa.IsChecked == true && pontob.IsChecked == false && pontoc.IsChecked == false) 
            {
                taludresul.Text = "1";
            }     //  NO PONTO A
            if (pontoa.IsChecked == false && pontob.IsChecked == true && pontoc.IsChecked == false)
            {
                if (tetta <= 3)
                {
                    taludresul.Text = "1";
                }
                if (tetta<=17 && tetta >= 6)
                {
                    double tettarad = tetta * Math.PI / 180;
                    double aux = 1 + (2.5 - (zetta / detta)) * (Math.Tan(tettarad - 3 * Math.PI/180));
                    taludresul.Text = aux.ToString(); 
                }
                if (tetta >= 45)
                {
                    double aux = 1 + (2.5 - zetta / detta) * 0.31;
                    taludresul.Text = aux.ToString();
                }
                if (tetta>3 && tetta < 6)
                { 
                    double tettarad = tetta * Math.PI / 180;
                    double inicial = 1;
                    double final = 1 + (2.5 - (zetta / detta)) * (Math.Tan(3 * Math.PI / 180));
                    double auxs1 = inicial + (final - inicial) * (tetta - 3) / (6 - 3);
                    taludresul.Text = auxs1.ToString();
                }
                if (tetta>17 && tetta < 45)
                {
                    double tettarad = tetta * Math.PI / 180;

                    double inicial = 1 + (2.5 - (zetta / detta)) * (Math.Tan(14* Math.PI / 180));
                    double final =   1 + (2.5 - (zetta / detta)) * 0.31;
                    double auxs1 = inicial + (final - inicial) * (tetta - 17) / (45 - 17);

                    taludresul.Text = auxs1.ToString();
                }
            }    //   NO PONTO B
            if (pontoa.IsChecked == false && pontob.IsChecked == false && pontoc.IsChecked == true)
            {
                taludresul.Text = "1";
            }   //    NO PONTO C
            if (pontoa.IsChecked == false && pontob.IsChecked == true && pontoc.IsChecked == true)
            {
                taludresul.Text = "1";
            }   //    NO PONTO C
            if (b.IsChecked == true)
            {
                s1.Text = taludresul.Text;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CALCULARQ(object sender, RoutedEventArgs e)
        {   if(vk.Text != "Velocidade Característica (Vk)")
            { double auxiliar = double.Parse(vk.Text) * double.Parse(vk.Text) * 0.613;
                QQQ.Text = auxiliar.ToString();
            }
        }

        private void CALCULARpe(object sender, RoutedEventArgs e)
        {
            if(QQQ.Text != "Resultado")
            {
                double auxiliar = double.Parse(QQQ.Text) * (double.Parse(cpe.Text) - double.Parse(cpi.Text));
                pressaumdinamicaum.Text = auxiliar.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { double ffa = double.Parse(fa.Text);
            double ffb = double.Parse(fb.Text);
            double T = ffa / ffb;

            if (T >= 1 && T <= 1.5)
            {
                ce1.Content = "-1";
                ce1_Copy.Content = "-0,6";
                ce1_Copy1.Content = "0,8";
                ce1_Copy2.Content = "-0,6";
                ce1_Copy4.Content = "0,8";
                ce1_Copy5.Content = "-0,6";
                ce1_Copy6.Content = "-1";
                ce1_Copy7.Content = "-0,6";

            }
            if (T>=2 && T <= 4)
            {
                ce1.Content = "-1";
                ce1_Copy.Content = "-0,5";
                ce1_Copy1.Content = "0,8";
                ce1_Copy2.Content = "-0,3";
                ce1_Copy4.Content = "0,8";
                ce1_Copy5.Content = "-0,6";
                ce1_Copy6.Content = "-1";
                ce1_Copy7.Content = "-0,6";

            }
            double valordea;
            double valordeb;
            if (T == 1)
            {
                ce1_Copy3.Content = ce1_Copy.Content;
            }
            if (T >= 2)
            {
                ce1_Copy3.Content = "-0,2";
            }
            if (T>1 && T < 2) {
                double valor1 = double.Parse(ce1_Copy.Content.ToString());
                double valor2 = -0.2;
                double valorc = valor1 + (valor2 - valor1) * (T - 1);
                ce1_Copy3.Content = valorc.ToString();
            }

        }

        private void Button_Clic98529k_1(object sender, RoutedEventArgs e)
        {
            double ffa = double.Parse(fa.Text);
            double ffb = double.Parse(fb.Text);
            double aluraa = double.Parse(caixa_da_altura.Text.ToString());
            double A1 = 0;
            double A2 = 0;
            double ccc = ffb;
            double ddd = ffb;
            double aaa = ffa;
            double bbb = ffa;

            if (ffa / 4 <= ffb / 3)
            {
                A1 = ffb / 3;
                A2 = ffb / 3;
            }
            if (ffa / 4 > ffb / 3)
            {
                A1 = ffa / 4;
                A2 = ffa / 4;
            }

            double A3 = ffa / 2;

            double C1 = 0; 
            double C2 = 0;

            if (2*aluraa >= ffb / 2)
            {
                C1 = ffb / 2;
                C2 = ffb / 2;
            }
            if (2*aluraa <= ffb/ 2)
            {
                C1 = 2 * aluraa;
                C2 = 2 * aluraa;
            }

            double areaaa1 = A1*aluraa;
            double areaaa2 = A2*aluraa;
            double areaaa3 = ccc*aluraa;
            double areaaa4 = ddd * aluraa;
            double areaaa5 = A3 * aluraa;
            double areaaa6 = aaa * aluraa;
            double areaaa7 = bbb * aluraa;
            double areaaa8 = C1 * aluraa;
            double areaaa9 = C2 * aluraa;

            double areaaa10 = ffa * aluraa;
            double areaaa11 = ffb * aluraa;

            a111.Text = areaaa1.ToString();
            a222.Text = areaaa2.ToString();
            a333.Text = areaaa3.ToString();
            a444.Text = areaaa4.ToString();
            a555.Text = areaaa5.ToString();
            a666.Text = areaaa6.ToString();
            a777.Text = areaaa7.ToString();
            a888.Text = areaaa8.ToString();
            a999.Text = areaaa9.ToString();
            cof2_Copy.Text = areaaa10.ToString();
            cof2_Copy1.Text = areaaa11.ToString();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void eweeew(object sender, RoutedEventArgs e)
        {
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: A1 e B1")
            {
                double resssultado = (double.Parse(ce1.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a111.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: A2 e B2")
            {
                double resssultado = (double.Parse(ce1_Copy.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a222.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: C")
            {
                double resssultado = (double.Parse(ce1_Copy1.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a333.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: D")
            {
                double resssultado = (double.Parse(ce1_Copy2.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a444.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: A3 e B3")
            {
                double resssultado = (double.Parse(ce1_Copy3.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a555.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: A")
            {
                double resssultado = (double.Parse(ce1_Copy4.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a666.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: B")
            {
                double resssultado = (double.Parse(ce1_Copy5.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a777.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: C1 e D1")
            {
                double resssultado = (double.Parse(ce1_Copy6.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a888.Text);
                cargafinal.Text = resssultado.ToString();
            }
            if (escolhaa.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: C2 e D2")
            {
                double resssultado = (double.Parse(ce1_Copy7.Content.ToString()) - double.Parse(cpi.Text)) * double.Parse(QQQ.Text) * double.Parse(a999.Text);
                cargafinal.Text = resssultado.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (double.Parse(caixa_da_altura.Text) <= 2 * double.Parse(alturamedia.Text))
            {
                ARRASTO1 t50 = new ARRASTO1();
                t50.Show();
            }
            else
            {
                ARRASTO2 t55 = new ARRASTO2();
                t55.Show();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double aaaaa = double.Parse(QQQ.Text.ToString());
            double bbbaa = double.Parse(cof1.Text.ToString());
            double cccaa = double.Parse(cof2.Text.ToString());

            double arrastadoresultado = aaaaa * bbbaa * cccaa;
           arrastado.Text = arrastadoresultado.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            CCPI t8 = new CCPI();
            t8.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CCPE t9 = new CCPE();
            t9.Show();

        }
    }
    
}

