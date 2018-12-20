namespace Polygons
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_paint_polygon = new System.Windows.Forms.Button();
            this.n_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.width_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.y_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.height_text = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button_paint_polygon);
            this.panel1.Controls.Add(this.n_text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.height_text);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.width_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.y_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.x_text);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 520);
            this.panel1.TabIndex = 0;
            // 
            // button_paint_polygon
            // 
            this.button_paint_polygon.Location = new System.Drawing.Point(12, 202);
            this.button_paint_polygon.Name = "button_paint_polygon";
            this.button_paint_polygon.Size = new System.Drawing.Size(178, 23);
            this.button_paint_polygon.TabIndex = 2;
            this.button_paint_polygon.Text = "Нарисовать";
            this.button_paint_polygon.UseVisualStyleBackColor = true;
            this.button_paint_polygon.Click += new System.EventHandler(this.button_paint_polygon_Click);
            // 
            // n_text
            // 
            this.n_text.Location = new System.Drawing.Point(101, 111);
            this.n_text.Name = "n_text";
            this.n_text.Size = new System.Drawing.Size(89, 20);
            this.n_text.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "К-во сторон";
            // 
            // width_text
            // 
            this.width_text.Location = new System.Drawing.Point(101, 58);
            this.width_text.Name = "width_text";
            this.width_text.Size = new System.Drawing.Size(89, 20);
            this.width_text.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ширина";
            // 
            // y_text
            // 
            this.y_text.Location = new System.Drawing.Point(101, 32);
            this.y_text.Name = "y_text";
            this.y_text.Size = new System.Drawing.Size(89, 20);
            this.y_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y";
            // 
            // x_text
            // 
            this.x_text.Location = new System.Drawing.Point(101, 6);
            this.x_text.Name = "x_text";
            this.x_text.Size = new System.Drawing.Size(89, 20);
            this.x_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 520);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Высота";
            // 
            // height_text
            // 
            this.height_text.Location = new System.Drawing.Point(101, 85);
            this.height_text.Name = "height_text";
            this.height_text.Size = new System.Drawing.Size(89, 20);
            this.height_text.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Правильный многоугольник",
            "Правильный многоугольник 2",
            "Звезда",
            "Звезда 2"});
            this.comboBox1.Location = new System.Drawing.Point(12, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Закрасить";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Многоугольники";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox x_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox width_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_paint_polygon;
        private System.Windows.Forms.TextBox height_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

