namespace OOPLAB2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonRE = new System.Windows.Forms.Button();
            this.buttonCI = new System.Windows.Forms.Button();
            this.buttonSQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHC = new System.Windows.Forms.Button();
            this.buttonTG = new System.Windows.Forms.Button();
            this.buttonPG = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClearThis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 550);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEL
            // 
            this.buttonEL.Location = new System.Drawing.Point(6, 188);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(232, 46);
            this.buttonEL.TabIndex = 1;
            this.buttonEL.Text = "Эллипс";
            this.buttonEL.UseVisualStyleBackColor = true;
            this.buttonEL.Click += new System.EventHandler(this.buttonEL_Click);
            // 
            // buttonRE
            // 
            this.buttonRE.Location = new System.Drawing.Point(6, 26);
            this.buttonRE.Name = "buttonRE";
            this.buttonRE.Size = new System.Drawing.Size(232, 49);
            this.buttonRE.TabIndex = 2;
            this.buttonRE.Text = "Прямоугольник";
            this.buttonRE.UseVisualStyleBackColor = true;
            this.buttonRE.Click += new System.EventHandler(this.buttonRE_Click);
            // 
            // buttonCI
            // 
            this.buttonCI.Location = new System.Drawing.Point(6, 136);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(232, 46);
            this.buttonCI.TabIndex = 3;
            this.buttonCI.Text = "Окружность";
            this.buttonCI.UseVisualStyleBackColor = true;
            this.buttonCI.Click += new System.EventHandler(this.buttonCI_Click);
            // 
            // buttonSQ
            // 
            this.buttonSQ.Location = new System.Drawing.Point(6, 81);
            this.buttonSQ.Name = "buttonSQ";
            this.buttonSQ.Size = new System.Drawing.Size(232, 49);
            this.buttonSQ.TabIndex = 4;
            this.buttonSQ.Text = "Квадрат";
            this.buttonSQ.UseVisualStyleBackColor = true;
            this.buttonSQ.Click += new System.EventHandler(this.buttonSQ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHC);
            this.groupBox1.Controls.Add(this.buttonTG);
            this.groupBox1.Controls.Add(this.buttonPG);
            this.groupBox1.Controls.Add(this.buttonSQ);
            this.groupBox1.Controls.Add(this.buttonCI);
            this.groupBox1.Controls.Add(this.buttonRE);
            this.groupBox1.Controls.Add(this.buttonEL);
            this.groupBox1.Location = new System.Drawing.Point(767, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 397);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите фигуру";
            // 
            // buttonHC
            // 
            this.buttonHC.Location = new System.Drawing.Point(6, 344);
            this.buttonHC.Name = "buttonHC";
            this.buttonHC.Size = new System.Drawing.Size(232, 46);
            this.buttonHC.TabIndex = 7;
            this.buttonHC.Text = "Вертолет";
            this.buttonHC.UseVisualStyleBackColor = true;
            this.buttonHC.Click += new System.EventHandler(this.buttonHC_Click);
            // 
            // buttonTG
            // 
            this.buttonTG.Location = new System.Drawing.Point(6, 292);
            this.buttonTG.Name = "buttonTG";
            this.buttonTG.Size = new System.Drawing.Size(232, 46);
            this.buttonTG.TabIndex = 6;
            this.buttonTG.Text = "Треугольник";
            this.buttonTG.UseVisualStyleBackColor = true;
            this.buttonTG.Click += new System.EventHandler(this.buttonTG_Click);
            // 
            // buttonPG
            // 
            this.buttonPG.Location = new System.Drawing.Point(6, 240);
            this.buttonPG.Name = "buttonPG";
            this.buttonPG.Size = new System.Drawing.Size(232, 46);
            this.buttonPG.TabIndex = 5;
            this.buttonPG.Text = "Многоугольник";
            this.buttonPG.UseVisualStyleBackColor = true;
            this.buttonPG.Click += new System.EventHandler(this.buttonPG_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(767, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(244, 29);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Удалить все фигуры";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "(750;550)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(767, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите фигуру, которую \r\nжелаете удалить с холста:\r\n";
            // 
            // buttonClearThis
            // 
            this.buttonClearThis.Location = new System.Drawing.Point(767, 524);
            this.buttonClearThis.Name = "buttonClearThis";
            this.buttonClearThis.Size = new System.Drawing.Size(244, 52);
            this.buttonClearThis.TabIndex = 11;
            this.buttonClearThis.Text = "Удалить";
            this.buttonClearThis.UseVisualStyleBackColor = true;
            this.buttonClearThis.Click += new System.EventHandler(this.buttonClearThis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 597);
            this.Controls.Add(this.buttonClearThis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonEL;
        private Button buttonRE;
        private Button buttonCI;
        private Button buttonSQ;
        private GroupBox groupBox1;
        private Button buttonClear;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button buttonClearThis;
        private Button buttonHC;
        private Button buttonTG;
        private Button buttonPG;
    }
}