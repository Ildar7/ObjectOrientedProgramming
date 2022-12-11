namespace OOPLAB2
{
    partial class FormHelicopter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setY = new System.Windows.Forms.TextBox();
            this.setX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newY = new System.Windows.Forms.TextBox();
            this.newX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BNewXY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "X";
            // 
            // setY
            // 
            this.setY.Location = new System.Drawing.Point(172, 83);
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(135, 27);
            this.setY.TabIndex = 31;
            // 
            // setX
            // 
            this.setX.Location = new System.Drawing.Point(12, 83);
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(136, 27);
            this.setX.TabIndex = 30;
            // 
            // labelXY
            // 
            this.labelXY.AutoSize = true;
            this.labelXY.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelXY.Location = new System.Drawing.Point(12, 28);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(111, 20);
            this.labelXY.TabIndex = 29;
            this.labelXY.Text = "Координаты:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(274, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BDraw
            // 
            this.BDraw.Location = new System.Drawing.Point(108, 128);
            this.BDraw.Name = "BDraw";
            this.BDraw.Size = new System.Drawing.Size(102, 29);
            this.BDraw.TabIndex = 49;
            this.BDraw.Text = "Нарисовать";
            this.BDraw.UseVisualStyleBackColor = true;
            this.BDraw.Click += new System.EventHandler(this.BDraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "X";
            // 
            // newY
            // 
            this.newY.Location = new System.Drawing.Point(172, 242);
            this.newY.Name = "newY";
            this.newY.Size = new System.Drawing.Size(135, 27);
            this.newY.TabIndex = 52;
            // 
            // newX
            // 
            this.newX.Location = new System.Drawing.Point(12, 242);
            this.newX.Name = "newX";
            this.newX.Size = new System.Drawing.Size(136, 27);
            this.newX.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Новые координаты:";
            // 
            // BNewXY
            // 
            this.BNewXY.Location = new System.Drawing.Point(108, 300);
            this.BNewXY.Name = "BNewXY";
            this.BNewXY.Size = new System.Drawing.Size(94, 29);
            this.BNewXY.TabIndex = 55;
            this.BNewXY.Text = "Изменить";
            this.BNewXY.UseVisualStyleBackColor = true;
            this.BNewXY.Click += new System.EventHandler(this.BNewXY_Click);
            // 
            // FormHelicopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(332, 354);
            this.Controls.Add(this.BNewXY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newY);
            this.Controls.Add(this.newX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setY);
            this.Controls.Add(this.setX);
            this.Controls.Add(this.labelXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHelicopter";
            this.Text = "FormHelicopter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHelicopter_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox setY;
        private TextBox setX;
        private Label labelXY;
        private Button button1;
        private Button BDraw;
        private Label label6;
        private Label label7;
        private TextBox newY;
        private TextBox newX;
        private Label label8;
        private Button BNewXY;
    }
}