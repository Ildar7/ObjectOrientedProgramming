namespace OOPLAB2
{
    partial class FormPolygon
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
            this.BNewXY = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newY = new System.Windows.Forms.TextBox();
            this.newX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BDraw = new System.Windows.Forms.Button();
            this.labelWH = new System.Windows.Forms.Label();
            this.labelXY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.BsetDots = new System.Windows.Forms.Button();
            this.dots_count = new System.Windows.Forms.TextBox();
            this.BAddDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(276, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 71;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BNewXY
            // 
            this.BNewXY.Location = new System.Drawing.Point(121, 363);
            this.BNewXY.Name = "BNewXY";
            this.BNewXY.Size = new System.Drawing.Size(94, 29);
            this.BNewXY.TabIndex = 69;
            this.BNewXY.Text = "Изменить";
            this.BNewXY.UseVisualStyleBackColor = true;
            this.BNewXY.Click += new System.EventHandler(this.BNewXY_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "X";
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(174, 320);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(135, 27);
            this.newY.TabIndex = 61;
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(14, 320);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(136, 27);
            this.newX.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Новые координаты:";
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(172, 224);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 58;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // labelWH
            // 
            this.labelWH.AutoSize = true;
            this.labelWH.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWH.Location = new System.Drawing.Point(14, 126);
            this.labelWH.Name = "labelWH";
            this.labelWH.Size = new System.Drawing.Size(160, 20);
            this.labelWH.TabIndex = 53;
            this.labelWH.Text = "Координаты точки:";
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelXY.Location = new System.Drawing.Point(12, 44);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(277, 20);
            this.labelXY.TabIndex = 48;
            this.labelXY.Text = "Количество точек многоугольника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(172, 175);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(135, 27);
            this.setY.TabIndex = 73;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(12, 175);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(136, 27);
            this.setX.TabIndex = 72;
            // 
            // BsetDots
            // 
            this.BsetDots.Location = new System.Drawing.Point(172, 76);
            this.BsetDots.Name = "BsetDots";
            this.BsetDots.Size = new System.Drawing.Size(102, 29);
            this.BsetDots.TabIndex = 76;
            this.BsetDots.Text = "Задать";
            this.BsetDots.UseVisualStyleBackColor = true;
            this.BsetDots.Click += new System.EventHandler(this.BsetDots_Click);
            // 
            // dots_count
            // 
            this.dots_count.Location = new System.Drawing.Point(14, 78);
            this.dots_count.Name = "dots_count";
            this.dots_count.Size = new System.Drawing.Size(136, 27);
            this.dots_count.TabIndex = 77;
            this.dots_count.TextChanged += new System.EventHandler(this.dots_count_TextChanged);
            // 
            // BAddDot
            // 
            this.BAddDot.Location = new System.Drawing.Point(12, 224);
            this.BAddDot.Name = "BAddDot";
            this.BAddDot.Size = new System.Drawing.Size(102, 29);
            this.BAddDot.TabIndex = 78;
            this.BAddDot.Text = "Добавить";
            this.BAddDot.UseVisualStyleBackColor = true;
            this.BAddDot.Click += new System.EventHandler(this.BAddDot_Click);
            // 
            // FormPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(337, 417);
            this.Controls.Add(this.BAddDot);
            this.Controls.Add(this.dots_count);
            this.Controls.Add(this.BsetDots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNewXY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.labelWH);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPolygon";
            this.Text = "Form_Polygon";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPolygon_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button BNewXY;
        private Label label6;
        private Label label7;
        private TextBox newY;
        private TextBox newX;
        private Label label8;
        private Button BDraw;
        private Label labelWH;
        private Label labelXY;
        private Label label3;
        private Label label4;
        private TextBox setY;
        private TextBox setX;
        private Button BsetDots;
        private TextBox dots_count;
        private Button BAddDot;
    }
}