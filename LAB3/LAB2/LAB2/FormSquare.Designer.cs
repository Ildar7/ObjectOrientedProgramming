namespace OOPLAB2
{
    partial class FormSquare
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
            this.button1 = new System.Windows.Forms.Button();
            this.BNewWH = new System.Windows.Forms.Button();
            this.BNewXY = new System.Windows.Forms.Button();
            this.newW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newY = new System.Windows.Forms.TextBox();
            this.newX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BDraw = new System.Windows.Forms.Button();
            this.setW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(276, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BNewWH
            // 
            this.BNewWH.Location = new System.Drawing.Point(110, 474);
            this.BNewWH.Name = "BNewWH";
            this.BNewWH.Size = new System.Drawing.Size(94, 29);
            this.BNewWH.TabIndex = 71;
            this.BNewWH.Text = "Изменить";
            this.BNewWH.UseVisualStyleBackColor = true;
            this.BNewWH.Click += new System.EventHandler(this.BNewWH_Click);
            // 
            // BNewXY
            // 
            this.BNewXY.Location = new System.Drawing.Point(110, 339);
            this.BNewXY.Name = "BNewXY";
            this.BNewXY.Size = new System.Drawing.Size(94, 29);
            this.BNewXY.TabIndex = 70;
            this.BNewXY.Text = "Изменить";
            this.BNewXY.UseVisualStyleBackColor = true;
            this.BNewXY.Click += new System.EventHandler(this.BNewXY_Click);
            // 
            // newW
            // 
            this.newW.Location = new System.Drawing.Point(12, 436);
            this.newW.Name = "newW";
            this.newW.Size = new System.Drawing.Size(295, 27);
            this.newW.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "Ширина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = "Новые размеры:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "X";
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(174, 300);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(133, 27);
            this.newY.TabIndex = 62;
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(12, 300);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(126, 27);
            this.newX.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Новые координаты:";
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(104, 200);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 59;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // setW
            // 
            this.setW.Location = new System.Drawing.Point(7, 164);
            this.setW.Name = "setW";
            this.setW.Size = new System.Drawing.Size(300, 27);
            this.setW.TabIndex = 57;
            this.setW.TextChanged += new System.EventHandler(this.setW_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ширина";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWH.Location = new System.Drawing.Point(7, 109);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(83, 20);
            this.labelWH.TabIndex = 54;
            this.labelWH.Text = "Размеры:";
            this.labelWH.Click += new System.EventHandler(this.labelWH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(174, 75);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(133, 27);
            this.setY.TabIndex = 51;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(7, 75);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(131, 27);
            this.setX.TabIndex = 50;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelXY.Location = new System.Drawing.Point(7, 20);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(111, 20);
            this.labelXY.TabIndex = 49;
            this.labelXY.Text = "Координаты:";
            // 
            // FormSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(319, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNewWH);
            this.Controls.Add(this.BNewXY);
            this.Controls.Add(this.newW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.setW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSquare";
            this.Text = "FormSQ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSQ_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button BNewWH;
        private Button BNewXY;
        private TextBox newW;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label label7;
        private TextBox newY;
        private TextBox newX;
        private Label label8;
        private Button BDraw;
        private TextBox setW;
        private Label label4;
        private Label labelWH;
        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
    }
}