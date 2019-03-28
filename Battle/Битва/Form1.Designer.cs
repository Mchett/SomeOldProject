namespace Битва
{
    partial class A
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.OneStep = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.ArmyA = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Helth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.many = new System.Windows.Forms.RadioButton();
            this.two = new System.Windows.Forms.RadioButton();
            this.one = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clone = new System.Windows.Forms.CheckBox();
            this.Death = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.UnDo = new System.Windows.Forms.Button();
            this.ReDo = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.ArmyB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArmyA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArmyB)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать новые армии";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OneStep
            // 
            this.OneStep.Enabled = false;
            this.OneStep.Location = new System.Drawing.Point(481, 205);
            this.OneStep.Name = "OneStep";
            this.OneStep.Size = new System.Drawing.Size(107, 36);
            this.OneStep.TabIndex = 1;
            this.OneStep.Text = "Сделать 1 ход";
            this.OneStep.UseVisualStyleBackColor = true;
            this.OneStep.Click += new System.EventHandler(this.OneStep_Click);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(481, 294);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 36);
            this.Start.TabIndex = 2;
            this.Start.Text = "Да начнется бой";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button3_Click);
            // 
            // ArmyA
            // 
            this.ArmyA.AllowUserToAddRows = false;
            this.ArmyA.AllowUserToDeleteRows = false;
            this.ArmyA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ArmyA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ArmyA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArmyA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Type,
            this.Helth,
            this.Attac,
            this.Distance});
            this.ArmyA.Location = new System.Drawing.Point(12, 192);
            this.ArmyA.Name = "ArmyA";
            this.ArmyA.ReadOnly = true;
            this.ArmyA.RowHeadersVisible = false;
            this.ArmyA.RowTemplate.ReadOnly = true;
            this.ArmyA.Size = new System.Drawing.Size(463, 156);
            this.ArmyA.TabIndex = 3;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 30;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип воина";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Helth
            // 
            this.Helth.HeaderText = "Здоровье";
            this.Helth.Name = "Helth";
            this.Helth.ReadOnly = true;
            this.Helth.Width = 60;
            // 
            // Attac
            // 
            this.Attac.HeaderText = "Макс. аттака";
            this.Attac.Name = "Attac";
            this.Attac.ReadOnly = true;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Дистанция СД";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.many);
            this.groupBox1.Controls.Add(this.two);
            this.groupBox1.Controls.Add(this.one);
            this.groupBox1.Location = new System.Drawing.Point(284, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стратегия";
            // 
            // many
            // 
            this.many.AutoSize = true;
            this.many.Location = new System.Drawing.Point(40, 77);
            this.many.Name = "many";
            this.many.Size = new System.Drawing.Size(87, 17);
            this.many.TabIndex = 2;
            this.many.Text = "Куча на кучу";
            this.many.UseVisualStyleBackColor = true;
            this.many.CheckedChanged += new System.EventHandler(this.many_CheckedChanged);
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.Location = new System.Drawing.Point(40, 53);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(82, 17);
            this.two.TabIndex = 1;
            this.two.Text = "Два на два";
            this.two.UseVisualStyleBackColor = true;
            this.two.CheckedChanged += new System.EventHandler(this.two_CheckedChanged);
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.Checked = true;
            this.one.Location = new System.Drawing.Point(40, 30);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(93, 17);
            this.one.TabIndex = 0;
            this.one.TabStop = true;
            this.one.Text = "Один на один";
            this.one.UseVisualStyleBackColor = true;
            this.one.CheckedChanged += new System.EventHandler(this.one_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clone);
            this.groupBox2.Controls.Add(this.Death);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(520, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подписки";
            // 
            // clone
            // 
            this.clone.AutoSize = true;
            this.clone.Location = new System.Drawing.Point(40, 77);
            this.clone.Name = "clone";
            this.clone.Size = new System.Drawing.Size(99, 17);
            this.clone.TabIndex = 1;
            this.clone.Text = "Клонирование";
            this.clone.UseVisualStyleBackColor = true;
            this.clone.CheckedChanged += new System.EventHandler(this.clone_CheckedChanged);
            // 
            // Death
            // 
            this.Death.AutoSize = true;
            this.Death.Location = new System.Drawing.Point(40, 30);
            this.Death.Name = "Death";
            this.Death.Size = new System.Drawing.Size(64, 17);
            this.Death.TabIndex = 0;
            this.Death.Text = "Смерть";
            this.Death.UseVisualStyleBackColor = true;
            this.Death.CheckedChanged += new System.EventHandler(this.Death_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Стоимость армий";
            // 
            // Pause
            // 
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(481, 247);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(107, 36);
            this.Pause.TabIndex = 9;
            this.Pause.Text = "Пауза";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // UnDo
            // 
            this.UnDo.Enabled = false;
            this.UnDo.Location = new System.Drawing.Point(774, 36);
            this.UnDo.Name = "UnDo";
            this.UnDo.Size = new System.Drawing.Size(107, 36);
            this.UnDo.TabIndex = 10;
            this.UnDo.Text = "Ctrl+Z";
            this.UnDo.UseVisualStyleBackColor = true;
            this.UnDo.Click += new System.EventHandler(this.UnDo_Click);
            // 
            // ReDo
            // 
            this.ReDo.Enabled = false;
            this.ReDo.Location = new System.Drawing.Point(774, 89);
            this.ReDo.Name = "ReDo";
            this.ReDo.Size = new System.Drawing.Size(107, 36);
            this.ReDo.TabIndex = 11;
            this.ReDo.Text = "Ctrl+Shift+Z";
            this.ReDo.UseVisualStyleBackColor = true;
            this.ReDo.Click += new System.EventHandler(this.ReDo_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(921, 65);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(107, 36);
            this.Help.TabIndex = 12;
            this.Help.Text = "Help me";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Step
            // 
            this.Step.AutoSize = true;
            this.Step.Location = new System.Drawing.Point(607, 176);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(52, 13);
            this.Step.TabIndex = 13;
            this.Step.Text = "Красные";
            // 
            // Restart
            // 
            this.Restart.Enabled = false;
            this.Restart.Location = new System.Drawing.Point(120, 117);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(112, 36);
            this.Restart.TabIndex = 0;
            this.Restart.Text = "Начать сначала";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // ArmyB
            // 
            this.ArmyB.AllowUserToAddRows = false;
            this.ArmyB.AllowUserToDeleteRows = false;
            this.ArmyB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ArmyB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ArmyB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArmyB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ArmyB.Location = new System.Drawing.Point(594, 192);
            this.ArmyB.Name = "ArmyB";
            this.ArmyB.ReadOnly = true;
            this.ArmyB.RowHeadersVisible = false;
            this.ArmyB.Size = new System.Drawing.Size(465, 156);
            this.ArmyB.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Тип воина";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Здоровье";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Макс. аттака";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Дистанция СД";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Белые";
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArmyB);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.ReDo);
            this.Controls.Add(this.UnDo);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArmyA);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.OneStep);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1087, 20000);
            this.Name = "A";
            this.Text = "Битва";
            ((System.ComponentModel.ISupportInitialize)(this.ArmyA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArmyB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OneStep;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.DataGridView ArmyA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton many;
        private System.Windows.Forms.RadioButton two;
        private System.Windows.Forms.RadioButton one;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox clone;
        private System.Windows.Forms.CheckBox Death;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button UnDo;
        private System.Windows.Forms.Button ReDo;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label Step;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.DataGridView ArmyB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Helth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

