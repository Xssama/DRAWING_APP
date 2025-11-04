namespace DrawingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plCanvas = new System.Windows.Forms.Panel();
            this.plToolBox = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paintbrushSize = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.plTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plCanvas.SuspendLayout();
            this.plToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // plTop
            // 
            this.plTop.BackColor = System.Drawing.Color.GreenYellow;
            this.plTop.Controls.Add(this.button2);
            this.plTop.Controls.Add(this.textBox1);
            this.plTop.Controls.Add(this.butClear);
            this.plTop.Controls.Add(this.butSave);
            this.plTop.Controls.Add(this.button1);
            this.plTop.Controls.Add(this.pictureBox1);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1034, 60);
            this.plTop.TabIndex = 0;
            this.plTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.plTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.plTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_mouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(117, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Drawing application";
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(770, 8);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 37);
            this.butClear.TabIndex = 2;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(671, 10);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 37);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(971, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plCanvas
            // 
            this.plCanvas.BackColor = System.Drawing.Color.Transparent;
            this.plCanvas.Controls.Add(this.plToolBox);
            this.plCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCanvas.Location = new System.Drawing.Point(0, 60);
            this.plCanvas.Name = "plCanvas";
            this.plCanvas.Size = new System.Drawing.Size(1034, 562);
            this.plCanvas.TabIndex = 1;
            this.plCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_mousedown);
            this.plCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_mousemove);
            // 
            // plToolBox
            // 
            this.plToolBox.BackColor = System.Drawing.Color.Honeydew;
            this.plToolBox.Controls.Add(this.pictureBox3);
            this.plToolBox.Controls.Add(this.pictureBox2);
            this.plToolBox.Controls.Add(this.panel1);
            this.plToolBox.Controls.Add(this.paintbrushSize);
            this.plToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.plToolBox.Location = new System.Drawing.Point(0, 0);
            this.plToolBox.Name = "plToolBox";
            this.plToolBox.Size = new System.Drawing.Size(95, 562);
            this.plToolBox.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 58);
            this.panel1.TabIndex = 3;
            // 
            // paintbrushSize
            // 
            this.paintbrushSize.Location = new System.Drawing.Point(22, 219);
            this.paintbrushSize.Name = "paintbrushSize";
            this.paintbrushSize.Size = new System.Drawing.Size(51, 26);
            this.paintbrushSize.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(914, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 622);
            this.Controls.Add(this.plCanvas);
            this.Controls.Add(this.plTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plCanvas.ResumeLayout(false);
            this.plToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrushSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plCanvas;
        private System.Windows.Forms.Panel plToolBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown paintbrushSize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

