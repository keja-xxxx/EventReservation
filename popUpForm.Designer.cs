namespace EventReservation
{
    partial class popUpForm
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
            this.fName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(95, 12);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(290, 27);
            this.fName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // lName
            // 
            this.lName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(95, 45);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(290, 27);
            this.lName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone #";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(95, 78);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(290, 27);
            this.phone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(95, 111);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(290, 27);
            this.address.TabIndex = 6;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(16, 157);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 58);
            this.add.TabIndex = 8;
            this.add.Text = "Confirm\r\nreservation";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.remove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(295, 157);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(90, 58);
            this.remove.TabIndex = 10;
            this.remove.Text = "Cancel";
            this.remove.UseVisualStyleBackColor = false;
            // 
            // popUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 243);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fName);
            this.Name = "popUpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendee Information";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
    }
}