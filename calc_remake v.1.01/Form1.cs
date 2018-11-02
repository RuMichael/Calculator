using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace calc_remake_v._1._01
{
    public partial class calc_remake : Form
    {
        public calc_remake()
        {
            InitializeComponent();
            Size = new Size(318, 330);
        }

        #region меню скрипт
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (расширенныйToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                обычныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
                расширенныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
                for (int i = 0; i < 21; i++)
                {
                    Thread.Sleep(10);
                    this.Width = this.Width - 10;
                }
            }
        }

        private void расширенныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (обычныйToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                обычныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
                расширенныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;

                for (int i = 0; i < 21; i++)
                {
                    Thread.Sleep(10);
                    Application.DoEvents();
                    this.Width = this.Width + 10;
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Колескин Михаил. \n 14-ис-2б");
        }
        #endregion

        #region переменные

        double arg;
        int op = 0;
        int c = 0;  //счетчик повторных нажатий функций
        bool cif = false; //cif=true когда нажали цифру
        bool rav = false; // rav=true когда последние действие было равно
        bool fun = false; //fun  индикатор равенства (обнуляется только при равно)
        bool clear = false; // было лень думать, не дает набирать циферки после функций
        ErrorProvider newErrorProvider = new System.Windows.Forms.ErrorProvider();

        #endregion

        #region основные операции(набор цифр\операции\равно)

        /// <summary>
        /// кнопки цифр 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c0_Click(object sender, EventArgs e) 
        {            
            KeyPressEventArgs e_cif=null;
            Button bt_cif=null;
            bool check_vvod;            
            if (e is KeyPressEventArgs)
            {
                check_vvod = false;
                e_cif = (KeyPressEventArgs)e;
            }
            else
            {
                check_vvod = true;
                bt_cif = (Button)sender;
            }
                if ((fun || rav) && !cif || clear) 
            {
                Tablo.Text = "0";
            }
            if (Tablo.Text.Length > 19) return;
            if (Tablo.Text == "0") Tablo.Text = "";
            Tablo.Text += check_vvod ? bt_cif.Text : e_cif.KeyChar.ToString();
            rav = false;
            cif = true;
            clear = false;
        }
        /// <summary>
        /// кнопки операций вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minys_Click(object sender, EventArgs e)
        {            
            rav = false;
            bool check_vvod;
            KeyPressEventArgs e_fun = null;
            Button bt_fun = null;
            try
            { e_fun = (KeyPressEventArgs)e; check_vvod = false; }
            catch (InvalidCastException)
            { bt_fun = (Button)sender; check_vvod = true; }
            c++;
            if (!fun)
            {
                arg = double.Parse(Tablo.Text);
                fun = true;
            }
            else if (cif)ravno_Click(sender, e);
            if (check_vvod)
                op = (bt_fun.Text == "+") ? 1 : (bt_fun.Text == "-") ? 2 : (bt_fun.Text == "*") ? 3 : 4;
            else
                op = (e_fun.KeyChar == '+') ? 1 : (e_fun.KeyChar == '-') ? 2 : (e_fun.KeyChar == '*') ? 3 : 4;
            cif = false;
        }
        /// <summary>
        /// кнопка равно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ravno_Click(object sender, EventArgs e)
        {
            
            double tmp_arg = double.Parse(Tablo.Text);
            
            switch (op)
            {
                case 1:
                    Tablo.Text = (arg + tmp_arg).ToString();
                    break;
                case 2:
                    Tablo.Text = rav ? (tmp_arg - arg).ToString() : (arg - tmp_arg).ToString();
                    break;
                case 3:
                    Tablo.Text = (arg * tmp_arg).ToString();
                    break;
                case 4:
                    Tablo.Text = rav ? (tmp_arg / arg).ToString() : (arg / tmp_arg).ToString();
                    break;
            }
            
            if (c <= 1)//не убирать скобки {}
            {
                if (!rav)
                    arg = tmp_arg;
            }
            else
                if (sender.ToString().IndexOf('=') >= 0) 
                {
                    c = 0;
                    arg = tmp_arg;
                }
                else
                     arg = double.Parse(Tablo.Text);
            rav = true;
            cif = false;

            if (sender.ToString().IndexOf('=') >= 0)
            {
                fun = false;
                history.Items.Add(Tablo.Text);
            }
        }
        /// <summary>
        /// кнопка backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_space_Click(object sender, EventArgs e)
        {
            if (cif && !rav)
                Tablo.Text = Tablo.Text.Remove(Tablo.Text.Length - 1);
            if (Tablo.Text == "" || Tablo.Text == "-" || Tablo.Text == "-0") Tablo.Text = "0";
            
        }
        /// <summary>
        /// кномка clear (C)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_tablo_Click(object sender, EventArgs e)
        {
            Tablo.Text = "0";
            c = 0;
            op = 0;
            fun = false;
            cif = false;
            rav = false;
            arg = 0;
            #region включает кнопки 
            c0.Enabled = !false;
            c1.Enabled = !false;
            c2.Enabled = !false;
            c3.Enabled = !false;
            c4.Enabled = !false;
            c5.Enabled = !false;
            c6.Enabled = !false;
            c7.Enabled = !false;
            c8.Enabled = !false;
            c9.Enabled = !false;
            back_space.Enabled = !false;
            plus.Enabled = !false;
            minys.Enabled = !false;
            delenie.Enabled = !false;
            ymnojenie.Enabled = !false;
            f_cos.Enabled = !false;
            f_del_x.Enabled = !false;
            f_ln.Enabled = !false;
            f_sin.Enabled = !false;
            f_smena_znaka.Enabled = !false;
            f_sqrt.Enabled = !false;
            f_x2.Enabled = !false;
            to4ka.Enabled = !false;
            ravno.Enabled = !false;
            clear_history.Enabled = !false;
            #endregion

        }
        /// <summary>
        /// дробная часть(точка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void to4ka_Click(object sender, EventArgs e)
        {
            if ((rav || fun) && !cif)
            {
                Tablo.Text = "0";
                cif = true;
            }
            if (Tablo.Text.IndexOf(",") == -1)
                Tablo.Text += ",";
        } 

        #endregion

        #region простые функции
        /// <summary>
        /// корень
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_sqrt_Click(object sender, EventArgs e)
        {
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = (Math.Sqrt(arg2)).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;             
        }
        /// <summary>
        /// 1 делить на x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_del_x_Click(object sender, EventArgs e)
        {
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = (1 / arg2).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;
        }
        /// <summary>
        /// смена знака (+/-)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f_smena_znaka_Click(object sender, EventArgs e)
        {
            if (Tablo.Text[0] != '0' || Tablo.Text.Length != 1)
                if (Tablo.Text[0] != '-')
                    Tablo.Text = "-" + Tablo.Text;
                else
                    Tablo.Text = Tablo.Text.Remove(0, 1);            
        }
        #endregion
        
        #region работа с клавы

        private void keyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                c0_Click(sender, e);
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
                minys_Click(sender, e);
            if (e.KeyChar == ',')
                to4ka_Click(sender, e);
        }       

        private void f_sqrt_Enter(object sender, EventArgs e)
        {
            ravno.Focus();
        }

        #endregion

        #region dragdrop 
        private void Tablo_DragDrop(object sender, DragEventArgs e)
        {
            double i;
            if (e.Data.GetData(DataFormats.Text) is string && (double.TryParse(e.Data.GetData(DataFormats.Text).ToString(),out i) || double.TryParse(e.Data.GetData(DataFormats.Text).ToString().Replace(',','.'), out i)))
            {
                if (e.Data.GetData(DataFormats.Text).ToString() != "NaN")
                    Tablo.Text = e.Data.GetData(DataFormats.Text).ToString();
                else
                    Tablo.Text = "Нет решений";
                c = 0;
            }
        }

        private void Tablo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)   
        {
            if (history.SelectedItem != null)
                DoDragDrop(history.SelectedItem.ToString(), DragDropEffects.Move);
        }
        #endregion
             
        #region дополнительные функции
        private void f_sin_Click(object sender, EventArgs e)
        {
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = Math.Sin(arg2).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;
        }

        private void f_cos_Click(object sender, EventArgs e)
        {            
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = Math.Cos(arg2).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;
        }

        private void f_x2_Click(object sender, EventArgs e)
        {
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = Math.Pow(arg2, 2).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;
        }

        private void f_ln_Click(object sender, EventArgs e)
        {
            double arg2 = double.Parse(Tablo.Text);
            Tablo.Text = Math.Log(arg2).ToString();
            history.Items.Add(Tablo.Text);
            clear = true;
        }
        #endregion

        private void clear_history_Click(object sender, EventArgs e)
        {
            history.Items.Clear();
        }

        private void Tablo_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (!double.TryParse(Tablo.Text, out result))
                return;
            else
                if (double.IsNaN(double.Parse(Tablo.Text)) || double.IsInfinity(double.Parse(Tablo.Text)))
            {
                if (double.IsNaN(double.Parse(Tablo.Text)))
                    Tablo.Text = "Нет решения";
                else
                    Tablo.Text = "Переполнение";
                c0.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;
                c4.Enabled = false;
                c5.Enabled = false;
                c6.Enabled = false;
                c7.Enabled = false;
                c8.Enabled = false;
                c9.Enabled = false;
                back_space.Enabled = false;
                plus.Enabled = false;
                minys.Enabled = false;
                delenie.Enabled = false;
                ymnojenie.Enabled = false;
                f_cos.Enabled = false;
                f_del_x.Enabled = false;
                f_ln.Enabled = false;
                f_sin.Enabled = false;
                f_smena_znaka.Enabled = false;
                f_sqrt.Enabled = false;
                f_x2.Enabled = false;
                to4ka.Enabled = false;
                ravno.Enabled = false;
                clear_history.Enabled = false;
            }
        }
    }
}
