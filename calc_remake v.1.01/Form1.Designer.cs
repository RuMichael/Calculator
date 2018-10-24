namespace calc_remake_v._1._01
{
    partial class calc_remake
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tablo = new System.Windows.Forms.Label();
            this.clear_tablo = new System.Windows.Forms.Button();
            this.back_space = new System.Windows.Forms.Button();
            this.c0 = new System.Windows.Forms.Button();
            this.to4ka = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c5 = new System.Windows.Forms.Button();
            this.c6 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.c8 = new System.Windows.Forms.Button();
            this.c9 = new System.Windows.Forms.Button();
            this.c7 = new System.Windows.Forms.Button();
            this.f_sqrt = new System.Windows.Forms.Button();
            this.f_del_x = new System.Windows.Forms.Button();
            this.f_smena_znaka = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.ymnojenie = new System.Windows.Forms.Button();
            this.minys = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.f_ln = new System.Windows.Forms.Button();
            this.f_x2 = new System.Windows.Forms.Button();
            this.f_cos = new System.Windows.Forms.Button();
            this.f_sin = new System.Windows.Forms.Button();
            this.clear_history = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширенныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tablo
            // 
            this.Tablo.AllowDrop = true;
            this.Tablo.BackColor = System.Drawing.Color.White;
            this.Tablo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tablo.Location = new System.Drawing.Point(12, 30);
            this.Tablo.Name = "Tablo";
            this.Tablo.Size = new System.Drawing.Size(280, 39);
            this.Tablo.TabIndex = 1;
            this.Tablo.Text = "0";
            this.Tablo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tablo.TextChanged += new System.EventHandler(this.Tablo_TextChanged);
            this.Tablo.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tablo_DragDrop);
            this.Tablo.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tablo_DragEnter);
            // 
            // clear_tablo
            // 
            this.clear_tablo.Location = new System.Drawing.Point(12, 82);
            this.clear_tablo.Name = "clear_tablo";
            this.clear_tablo.Size = new System.Drawing.Size(43, 28);
            this.clear_tablo.TabIndex = 31;
            this.clear_tablo.TabStop = false;
            this.clear_tablo.Text = "C";
            this.clear_tablo.UseVisualStyleBackColor = true;
            this.clear_tablo.Click += new System.EventHandler(this.clear_tablo_Click);
            this.clear_tablo.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // back_space
            // 
            this.back_space.Location = new System.Drawing.Point(61, 82);
            this.back_space.Name = "back_space";
            this.back_space.Size = new System.Drawing.Size(83, 28);
            this.back_space.TabIndex = 30;
            this.back_space.TabStop = false;
            this.back_space.Text = "<-";
            this.back_space.UseVisualStyleBackColor = true;
            this.back_space.Click += new System.EventHandler(this.back_space_Click);
            this.back_space.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c0
            // 
            this.c0.Location = new System.Drawing.Point(12, 245);
            this.c0.Name = "c0";
            this.c0.Size = new System.Drawing.Size(86, 37);
            this.c0.TabIndex = 29;
            this.c0.TabStop = false;
            this.c0.Text = "0";
            this.c0.UseVisualStyleBackColor = true;
            this.c0.Click += new System.EventHandler(this.c0_Click);
            this.c0.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // to4ka
            // 
            this.to4ka.Location = new System.Drawing.Point(104, 245);
            this.to4ka.Name = "to4ka";
            this.to4ka.Size = new System.Drawing.Size(40, 37);
            this.to4ka.TabIndex = 28;
            this.to4ka.TabStop = false;
            this.to4ka.Text = ".";
            this.to4ka.UseVisualStyleBackColor = true;
            this.to4ka.Click += new System.EventHandler(this.to4ka_Click);
            this.to4ka.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(58, 202);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(40, 37);
            this.c2.TabIndex = 27;
            this.c2.TabStop = false;
            this.c2.Text = "2";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c0_Click);
            this.c2.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(104, 202);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(40, 37);
            this.c3.TabIndex = 26;
            this.c3.TabStop = false;
            this.c3.Text = "3";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.c0_Click);
            this.c3.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 202);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(40, 37);
            this.c1.TabIndex = 25;
            this.c1.TabStop = false;
            this.c1.Text = "1";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c0_Click);
            this.c1.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(58, 159);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(40, 37);
            this.c5.TabIndex = 24;
            this.c5.TabStop = false;
            this.c5.Text = "5";
            this.c5.UseVisualStyleBackColor = true;
            this.c5.Click += new System.EventHandler(this.c0_Click);
            this.c5.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c6
            // 
            this.c6.Location = new System.Drawing.Point(104, 159);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(40, 37);
            this.c6.TabIndex = 23;
            this.c6.TabStop = false;
            this.c6.Text = "6";
            this.c6.UseVisualStyleBackColor = true;
            this.c6.Click += new System.EventHandler(this.c0_Click);
            this.c6.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(12, 159);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(40, 37);
            this.c4.TabIndex = 22;
            this.c4.TabStop = false;
            this.c4.Text = "4";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Click += new System.EventHandler(this.c0_Click);
            this.c4.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c8
            // 
            this.c8.Location = new System.Drawing.Point(58, 116);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(40, 37);
            this.c8.TabIndex = 21;
            this.c8.TabStop = false;
            this.c8.Text = "8";
            this.c8.UseVisualStyleBackColor = true;
            this.c8.Click += new System.EventHandler(this.c0_Click);
            this.c8.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c9
            // 
            this.c9.Location = new System.Drawing.Point(104, 116);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(40, 37);
            this.c9.TabIndex = 20;
            this.c9.TabStop = false;
            this.c9.Text = "9";
            this.c9.UseVisualStyleBackColor = true;
            this.c9.Click += new System.EventHandler(this.c0_Click);
            this.c9.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // c7
            // 
            this.c7.Location = new System.Drawing.Point(12, 116);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(40, 37);
            this.c7.TabIndex = 19;
            this.c7.TabStop = false;
            this.c7.Text = "7";
            this.c7.UseVisualStyleBackColor = true;
            this.c7.Click += new System.EventHandler(this.c0_Click);
            this.c7.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_sqrt
            // 
            this.f_sqrt.Location = new System.Drawing.Point(236, 82);
            this.f_sqrt.Name = "f_sqrt";
            this.f_sqrt.Size = new System.Drawing.Size(56, 37);
            this.f_sqrt.TabIndex = 39;
            this.f_sqrt.Text = "√";
            this.f_sqrt.UseVisualStyleBackColor = true;
            this.f_sqrt.Click += new System.EventHandler(this.f_sqrt_Click);
            this.f_sqrt.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_del_x
            // 
            this.f_del_x.Location = new System.Drawing.Point(236, 125);
            this.f_del_x.Name = "f_del_x";
            this.f_del_x.Size = new System.Drawing.Size(56, 37);
            this.f_del_x.TabIndex = 38;
            this.f_del_x.Text = "1/x";
            this.f_del_x.UseVisualStyleBackColor = true;
            this.f_del_x.Click += new System.EventHandler(this.f_del_x_Click);
            this.f_del_x.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_smena_znaka
            // 
            this.f_smena_znaka.Location = new System.Drawing.Point(236, 168);
            this.f_smena_znaka.Name = "f_smena_znaka";
            this.f_smena_znaka.Size = new System.Drawing.Size(56, 37);
            this.f_smena_znaka.TabIndex = 37;
            this.f_smena_znaka.Text = "+/-";
            this.f_smena_znaka.UseVisualStyleBackColor = true;
            this.f_smena_znaka.Click += new System.EventHandler(this.f_smena_znaka_Click);
            this.f_smena_znaka.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // delenie
            // 
            this.delenie.Location = new System.Drawing.Point(183, 125);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(47, 37);
            this.delenie.TabIndex = 36;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.minys_Click);
            this.delenie.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // ymnojenie
            // 
            this.ymnojenie.Location = new System.Drawing.Point(183, 82);
            this.ymnojenie.Name = "ymnojenie";
            this.ymnojenie.Size = new System.Drawing.Size(47, 37);
            this.ymnojenie.TabIndex = 35;
            this.ymnojenie.Text = "*";
            this.ymnojenie.UseVisualStyleBackColor = true;
            this.ymnojenie.Click += new System.EventHandler(this.minys_Click);
            this.ymnojenie.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // minys
            // 
            this.minys.Location = new System.Drawing.Point(183, 168);
            this.minys.Name = "minys";
            this.minys.Size = new System.Drawing.Size(47, 37);
            this.minys.TabIndex = 34;
            this.minys.Text = "-";
            this.minys.UseVisualStyleBackColor = true;
            this.minys.Click += new System.EventHandler(this.minys_Click);
            this.minys.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(183, 211);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(47, 71);
            this.plus.TabIndex = 33;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.minys_Click);
            this.plus.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // ravno
            // 
            this.ravno.Location = new System.Drawing.Point(236, 211);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(56, 71);
            this.ravno.TabIndex = 32;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = true;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // f_ln
            // 
            this.f_ln.Location = new System.Drawing.Point(460, 240);
            this.f_ln.Name = "f_ln";
            this.f_ln.Size = new System.Drawing.Size(43, 38);
            this.f_ln.TabIndex = 45;
            this.f_ln.Text = "ln";
            this.f_ln.UseVisualStyleBackColor = true;
            this.f_ln.Click += new System.EventHandler(this.f_ln_Click);
            this.f_ln.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_x2
            // 
            this.f_x2.Location = new System.Drawing.Point(407, 240);
            this.f_x2.Name = "f_x2";
            this.f_x2.Size = new System.Drawing.Size(43, 38);
            this.f_x2.TabIndex = 44;
            this.f_x2.Text = "x²";
            this.f_x2.UseVisualStyleBackColor = true;
            this.f_x2.Click += new System.EventHandler(this.f_x2_Click);
            this.f_x2.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_cos
            // 
            this.f_cos.Location = new System.Drawing.Point(358, 240);
            this.f_cos.Name = "f_cos";
            this.f_cos.Size = new System.Drawing.Size(43, 38);
            this.f_cos.TabIndex = 43;
            this.f_cos.Text = "cos";
            this.f_cos.UseVisualStyleBackColor = true;
            this.f_cos.Click += new System.EventHandler(this.f_cos_Click);
            this.f_cos.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // f_sin
            // 
            this.f_sin.Location = new System.Drawing.Point(309, 240);
            this.f_sin.Name = "f_sin";
            this.f_sin.Size = new System.Drawing.Size(43, 38);
            this.f_sin.TabIndex = 42;
            this.f_sin.Text = "sin";
            this.f_sin.UseVisualStyleBackColor = true;
            this.f_sin.Click += new System.EventHandler(this.f_sin_Click);
            this.f_sin.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // clear_history
            // 
            this.clear_history.Location = new System.Drawing.Point(309, 202);
            this.clear_history.Name = "clear_history";
            this.clear_history.Size = new System.Drawing.Size(194, 28);
            this.clear_history.TabIndex = 41;
            this.clear_history.Text = "Очистить";
            this.clear_history.UseVisualStyleBackColor = true;
            this.clear_history.Click += new System.EventHandler(this.clear_history_Click);
            this.clear_history.Enter += new System.EventHandler(this.f_sqrt_Enter);
            // 
            // history
            // 
            this.history.FormattingEnabled = true;
            this.history.Location = new System.Drawing.Point(309, 33);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(194, 160);
            this.history.TabIndex = 40;
            this.history.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.расширенныйToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Checked = true;
            this.обычныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.обычныйToolStripMenuItem.Text = "Обычный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // расширенныйToolStripMenuItem
            // 
            this.расширенныйToolStripMenuItem.Name = "расширенныйToolStripMenuItem";
            this.расширенныйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.расширенныйToolStripMenuItem.Text = "Расширенный";
            this.расширенныйToolStripMenuItem.Click += new System.EventHandler(this.расширенныйToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // calc_remake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 288);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.f_ln);
            this.Controls.Add(this.f_x2);
            this.Controls.Add(this.f_cos);
            this.Controls.Add(this.f_sin);
            this.Controls.Add(this.clear_history);
            this.Controls.Add(this.history);
            this.Controls.Add(this.f_sqrt);
            this.Controls.Add(this.f_del_x);
            this.Controls.Add(this.f_smena_znaka);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.ymnojenie);
            this.Controls.Add(this.minys);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.clear_tablo);
            this.Controls.Add(this.back_space);
            this.Controls.Add(this.c0);
            this.Controls.Add(this.to4ka);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c8);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.Tablo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calc_remake";
            this.ShowIcon = false;
            this.Text = "калькулятор";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyboard_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tablo;
        private System.Windows.Forms.Button clear_tablo;
        private System.Windows.Forms.Button back_space;
        private System.Windows.Forms.Button c0;
        private System.Windows.Forms.Button to4ka;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c5;
        private System.Windows.Forms.Button c6;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button c8;
        private System.Windows.Forms.Button c9;
        private System.Windows.Forms.Button c7;
        private System.Windows.Forms.Button f_sqrt;
        private System.Windows.Forms.Button f_del_x;
        private System.Windows.Forms.Button f_smena_znaka;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button ymnojenie;
        private System.Windows.Forms.Button minys;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Button f_ln;
        private System.Windows.Forms.Button f_x2;
        private System.Windows.Forms.Button f_cos;
        private System.Windows.Forms.Button f_sin;
        private System.Windows.Forms.Button clear_history;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширенныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

