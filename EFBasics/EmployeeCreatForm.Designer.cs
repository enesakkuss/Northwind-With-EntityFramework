﻿namespace EFBasics
{
    partial class EmployeeCreatForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.cmbReportsTo = new System.Windows.Forms.ComboBox();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtTitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(659, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(535, 149);
            this.txtHomePhone.Mask = "(999) 000-0000";
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(199, 23);
            this.txtHomePhone.TabIndex = 67;
            // 
            // cmbReportsTo
            // 
            this.cmbReportsTo.FormattingEnabled = true;
            this.cmbReportsTo.Location = new System.Drawing.Point(535, 260);
            this.cmbReportsTo.Name = "cmbReportsTo";
            this.cmbReportsTo.Size = new System.Drawing.Size(199, 23);
            this.cmbReportsTo.TabIndex = 66;
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.Location = new System.Drawing.Point(535, 297);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(199, 23);
            this.txtPhotoPath.TabIndex = 65;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(535, 223);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(199, 23);
            this.txtNotes.TabIndex = 64;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(535, 112);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(199, 23);
            this.txtCountry.TabIndex = 62;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(535, 75);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(199, 23);
            this.txtPostalCode.TabIndex = 61;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(535, 38);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(199, 23);
            this.txtRegion.TabIndex = 60;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(131, 220);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 23);
            this.dtpHireDate.TabIndex = 59;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(131, 183);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.TabIndex = 58;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(131, 297);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 23);
            this.txtCity.TabIndex = 57;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(131, 260);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(200, 23);
            this.txtAdress.TabIndex = 56;
            // 
            // txtTitleOfCourtesy
            // 
            this.txtTitleOfCourtesy.Location = new System.Drawing.Point(131, 149);
            this.txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            this.txtTitleOfCourtesy.Size = new System.Drawing.Size(200, 23);
            this.txtTitleOfCourtesy.TabIndex = 55;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(131, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.TabIndex = 54;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(131, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(428, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "Photo Path:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(428, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 50;
            this.label15.Text = "Hesap Verdiği:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(428, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Notlar:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(428, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "Extension:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ev Telfonu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Ülke:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Posta Kodu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Bölge:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Şehir:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "İşe Alım Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Doğum Günü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nezaken Ünvanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ünvan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad:";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(535, 186);
            this.txtExtension.Mask = "AAAA";
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(199, 23);
            this.txtExtension.TabIndex = 103;
            // 
            // EmployeeCreatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.cmbReportsTo);
            this.Controls.Add(this.txtPhotoPath);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtTitleOfCourtesy);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeCreatForm";
            this.Text = "EmployeeCreatForm";
            this.Load += new System.EventHandler(this.EmployeeCreatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private MaskedTextBox txtHomePhone;
        private ComboBox cmbReportsTo;
        private TextBox txtPhotoPath;
        private TextBox txtNotes;
        private TextBox txtCountry;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private DateTimePicker dtpHireDate;
        private DateTimePicker dtpBirthDate;
        private TextBox txtCity;
        private TextBox txtAdress;
        private TextBox txtTitleOfCourtesy;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtExtension;
    }
}