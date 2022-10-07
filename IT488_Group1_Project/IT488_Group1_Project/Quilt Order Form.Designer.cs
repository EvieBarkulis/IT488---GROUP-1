namespace IT488_Group1_Project
{
    partial class Quilt_Order_Form
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
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.comboBox_fabric = new System.Windows.Forms.ComboBox();
            this.comboBox_design = new System.Windows.Forms.ComboBox();
            this.comboBox_backing = new System.Windows.Forms.ComboBox();
            this.comboBox_filler = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Machine Quilt Top",
            "Patchwork",
            "English Paper Pacing",
            "Custom Applique",
            "American Quilt Top",
            "Nine Patch",
            "Square",
            "Log Cabin",
            "Block",
            "Pinwheel"});
            this.comboBox_type.Location = new System.Drawing.Point(34, 156);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(182, 21);
            this.comboBox_type.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fabric:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Design:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filler:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Backing:";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Twin",
            "Infant",
            "Child",
            "Full",
            "TV Blanket"});
            this.comboBox_size.Location = new System.Drawing.Point(333, 156);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(182, 21);
            this.comboBox_size.TabIndex = 7;
            // 
            // comboBox_fabric
            // 
            this.comboBox_fabric.FormattingEnabled = true;
            this.comboBox_fabric.Items.AddRange(new object[] {
            "Cotton",
            "Wool",
            "Polyester",
            "Linen",
            "Denim",
            "Corduroy",
            "Spandex",
            "T-Shirt",
            "Felt",
            "Microfiber"});
            this.comboBox_fabric.Location = new System.Drawing.Point(34, 251);
            this.comboBox_fabric.Name = "comboBox_fabric";
            this.comboBox_fabric.Size = new System.Drawing.Size(182, 21);
            this.comboBox_fabric.TabIndex = 8;
            // 
            // comboBox_design
            // 
            this.comboBox_design.FormattingEnabled = true;
            this.comboBox_design.Items.AddRange(new object[] {
            "Animals",
            "Flowers",
            "Video Games",
            "Disney",
            "Star Wars",
            "Marvel",
            "DC Comics",
            "Minecraft"});
            this.comboBox_design.Location = new System.Drawing.Point(333, 251);
            this.comboBox_design.Name = "comboBox_design";
            this.comboBox_design.Size = new System.Drawing.Size(182, 21);
            this.comboBox_design.TabIndex = 9;
            // 
            // comboBox_backing
            // 
            this.comboBox_backing.FormattingEnabled = true;
            this.comboBox_backing.Items.AddRange(new object[] {
            "Fleece",
            "Flannel",
            "MicroFlannel",
            "Wool",
            "100 % Cotton"});
            this.comboBox_backing.Location = new System.Drawing.Point(333, 339);
            this.comboBox_backing.Name = "comboBox_backing";
            this.comboBox_backing.Size = new System.Drawing.Size(182, 21);
            this.comboBox_backing.TabIndex = 10;
            // 
            // comboBox_filler
            // 
            this.comboBox_filler.FormattingEnabled = true;
            this.comboBox_filler.Items.AddRange(new object[] {
            "Polyester",
            "100% Cotton",
            "Cotton / Polyblend",
            "Wool"});
            this.comboBox_filler.Location = new System.Drawing.Point(34, 339);
            this.comboBox_filler.Name = "comboBox_filler";
            this.comboBox_filler.Size = new System.Drawing.Size(182, 21);
            this.comboBox_filler.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 45);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Quilt Order Form:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit Your Order!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(166, 89);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(266, 20);
            this.textBox_email.TabIndex = 15;
            // 
            // Quilt_Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(565, 479);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox_filler);
            this.Controls.Add(this.comboBox_backing);
            this.Controls.Add(this.comboBox_design);
            this.Controls.Add(this.comboBox_fabric);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_type);
            this.Name = "Quilt_Order_Form";
            this.Text = "Quilt Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.ComboBox comboBox_fabric;
        private System.Windows.Forms.ComboBox comboBox_design;
        private System.Windows.Forms.ComboBox comboBox_backing;
        private System.Windows.Forms.ComboBox comboBox_filler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_email;
    }
}