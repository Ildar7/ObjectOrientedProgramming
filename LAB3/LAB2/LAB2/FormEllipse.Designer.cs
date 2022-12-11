namespace OOPLAB2
{
    partial class FormEllipse
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
            this.labelXY = new System.Windows.Forms.Label();
            this.setX = new System.Windows.Forms.TextBox();
            this.setY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.setW = new System.Windows.Forms.TextBox();
            this.setH = new System.Windows.Forms.TextBox();
            this.BDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newY = new System.Windows.Forms.TextBox();
            this.newX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newH = new System.Windows.Forms.TextBox();
            this.newW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BNewXY = new System.Windows.Forms.Button();
            this.BNewWH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelXY.Location = new System.Drawing.Point(12, 21);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(111, 20);
            this.labelXY.TabIndex = 0;
            this.labelXY.Text = "Координаты:";
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(12, 76);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(136, 27);
            this.setX.TabIndex = 1;
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(169, 76);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(137, 27);
            this.setY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWH.Location = new System.Drawing.Point(12, 119);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(83, 20);
            this.labelWH.TabIndex = 5;
            this.labelWH.Text = "Размеры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ширина";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Высота";
            // 
            // setW
            // 
            this.setW.Location = new System.Drawing.Point(12, 174);
            this.setW.Name = "setW";
            this.setW.Size = new System.Drawing.Size(136, 27);
            this.setW.TabIndex = 8;
            // 
            // setH
            // 
            this.setH.Location = new System.Drawing.Point(169, 174);
            this.setH.Name = "setH";
            this.setH.Size = new System.Drawing.Size(137, 27);
            this.setH.TabIndex = 9;
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(105, 219);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 10;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(169, 320);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(137, 27);
            this.newY.TabIndex = 13;
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(12, 320);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(136, 27);
            this.newX.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Новые координаты:";
            // 
            // newH
            // 
            this.newH.Location = new System.Drawing.Point(169, 465);
            this.newH.Name = "newH";
            this.newH.Size = new System.Drawing.Size(137, 27);
            this.newH.TabIndex = 20;
            // 
            // newW
            // 
            this.newW.Location = new System.Drawing.Point(12, 465);
            this.newW.Name = "newW";
            this.newW.Size = new System.Drawing.Size(136, 27);
            this.newW.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Высота";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ширина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Новые размеры:";
            // 
            // BNewXY
            // 
            this.BNewXY.Location = new System.Drawing.Point(109, 362);
            this.BNewXY.Name = "BNewXY";
            this.BNewXY.Size = new System.Drawing.Size(94, 29);
            this.BNewXY.TabIndex = 21;
            this.BNewXY.Text = "Изменить";
            this.BNewXY.UseVisualStyleBackColor = true;
            this.BNewXY.Click += new System.EventHandler(this.BNewXY_Click);
            // 
            // BNewWH
            // 
            this.BNewWH.Location = new System.Drawing.Point(109, 498);
            this.BNewWH.Name = "BNewWH";
            this.BNewWH.Size = new System.Drawing.Size(94, 29);
            this.BNewWH.TabIndex = 22;
            this.BNewWH.Text = "Изменить";
            this.BNewWH.UseVisualStyleBackColor = true;
            this.BNewWH.Click += new System.EventHandler(this.BNewWH_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(276, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(318, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNewWH);
            this.Controls.Add(this.BNewXY);
            this.Controls.Add(this.newH);
            this.Controls.Add(this.newW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.setH);
            this.Controls.Add(this.setW);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEl";
            this.Text = "Ellipse";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelXY;
        private TextBox setX;
        private TextBox setY;
        private Label label1;
        private Label label2;
        private Label labelWH;
        private Label label4;
        private Label label5;
        private TextBox setW;
        private TextBox setH;
        private Button BDraw;
        private Label label6;
        private Label label7;
        private TextBox newY;
        private TextBox newX;
        private Label label8;
        private TextBox newH;
        private TextBox newW;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button BNewXY;
        private Button BNewWH;
        private Button button1;
    }
}