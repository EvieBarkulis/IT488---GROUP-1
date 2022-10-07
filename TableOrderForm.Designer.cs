namespace IT488_Group1_Project
{
    partial class TableOrderForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_thickness = new System.Windows.Forms.ComboBox();
            this.comboBox_wood = new System.Windows.Forms.ComboBox();
            this.comboBox_finish = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.textBox_design = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(88, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 45);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Table Order Form:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(35, 158);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(276, 20);
            this.textBox_email.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 56);
            this.button1.TabIndex = 28;
            this.button1.Text = "Submit Your Order!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_thickness
            // 
            this.comboBox_thickness.FormattingEnabled = true;
            this.comboBox_thickness.Items.AddRange(new object[] {
            "1 Inch",
            "2 Inch",
            "3 Inch"});
            this.comboBox_thickness.Location = new System.Drawing.Point(367, 298);
            this.comboBox_thickness.Name = "comboBox_thickness";
            this.comboBox_thickness.Size = new System.Drawing.Size(182, 21);
            this.comboBox_thickness.TabIndex = 25;
            // 
            // comboBox_wood
            // 
            this.comboBox_wood.FormattingEnabled = true;
            this.comboBox_wood.Items.AddRange(new object[] {
            "Pine",
            "Oak",
            "Cedar",
            "Walnut"});
            this.comboBox_wood.Location = new System.Drawing.Point(35, 228);
            this.comboBox_wood.Name = "comboBox_wood";
            this.comboBox_wood.Size = new System.Drawing.Size(182, 21);
            this.comboBox_wood.TabIndex = 24;
            // 
            // comboBox_finish
            // 
            this.comboBox_finish.FormattingEnabled = true;
            this.comboBox_finish.Items.AddRange(new object[] {
            "Stain",
            "Lacquer",
            "Varnish",
            "Resign"});
            this.comboBox_finish.Location = new System.Drawing.Point(367, 228);
            this.comboBox_finish.Name = "comboBox_finish";
            this.comboBox_finish.Size = new System.Drawing.Size(182, 21);
            this.comboBox_finish.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Design:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thickness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Wood:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Finish:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type:";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Coffee Table",
            "End Table",
            "Bedside Table",
            "Dining Table",
            "Bar Topper"});
            this.comboBox_type.Location = new System.Drawing.Point(367, 157);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(182, 21);
            this.comboBox_type.TabIndex = 16;
            // 
            // textBox_design
            // 
            this.textBox_design.Location = new System.Drawing.Point(35, 298);
            this.textBox_design.MaxLength = 50;
            this.textBox_design.Multiline = true;
            this.textBox_design.Name = "textBox_design";
            this.textBox_design.Size = new System.Drawing.Size(285, 107);
            this.textBox_design.TabIndex = 31;
            // 
            // TableOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.textBox_design);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_thickness);
            this.Controls.Add(this.comboBox_wood);
            this.Controls.Add(this.comboBox_finish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox1);
            this.Name = "TableOrderForm";
            this.Text = "TableOrderForm";
            this.Load += new System.EventHandler(this.TableOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_thickness;
        private System.Windows.Forms.ComboBox comboBox_wood;
        private System.Windows.Forms.ComboBox comboBox_finish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_design;
    }
}