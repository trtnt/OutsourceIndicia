﻿
namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupMaanden = new System.Windows.Forms.GroupBox();
            this.Agendatype = new System.Windows.Forms.Label();
            this.agendatype1 = new System.Windows.Forms.ComboBox();
            this.Categorie = new System.Windows.Forms.ComboBox();
            this.timeEinde = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Einddatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.beginDatum = new System.Windows.Forms.DateTimePicker();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupMaanden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(542, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHead.Location = new System.Drawing.Point(12, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(176, 30);
            this.lblHead.TabIndex = 2;
            this.lblHead.Text = "Indicia kalender ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupMaanden
            // 
            this.groupMaanden.Controls.Add(this.Agendatype);
            this.groupMaanden.Controls.Add(this.agendatype1);
            this.groupMaanden.Controls.Add(this.Categorie);
            this.groupMaanden.Controls.Add(this.timeEinde);
            this.groupMaanden.Controls.Add(this.timeStart);
            this.groupMaanden.Controls.Add(this.label5);
            this.groupMaanden.Controls.Add(this.label4);
            this.groupMaanden.Controls.Add(this.Einddatum);
            this.groupMaanden.Controls.Add(this.label3);
            this.groupMaanden.Controls.Add(this.label2);
            this.groupMaanden.Controls.Add(this.label1);
            this.groupMaanden.Controls.Add(this.beginDatum);
            this.groupMaanden.Controls.Add(this.txtOmschrijving);
            this.groupMaanden.Controls.Add(this.txtLocatie);
            this.groupMaanden.Controls.Add(this.btnOpslaan);
            this.groupMaanden.Controls.Add(this.monthCalendar1);
            this.groupMaanden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupMaanden.Location = new System.Drawing.Point(13, 71);
            this.groupMaanden.Name = "groupMaanden";
            this.groupMaanden.Size = new System.Drawing.Size(543, 743);
            this.groupMaanden.TabIndex = 4;
            this.groupMaanden.TabStop = false;
            this.groupMaanden.Text = "Maanden";
            this.groupMaanden.Enter += new System.EventHandler(this.groupMaanden_Enter);
            // 
            // Agendatype
            // 
            this.Agendatype.AutoSize = true;
            this.Agendatype.Location = new System.Drawing.Point(108, 479);
            this.Agendatype.Name = "Agendatype";
            this.Agendatype.Size = new System.Drawing.Size(46, 21);
            this.Agendatype.TabIndex = 16;
            this.Agendatype.Text = "Type";
            // 
            // agendatype1
            // 
            this.agendatype1.FormattingEnabled = true;
            this.agendatype1.Items.AddRange(new object[] {
            "Mijn kalender",
            "Zakelijk",
            "Familie",
            "Vrienden",
            "Reizen",
            "Verjaardagen",
            "Vakanties"});
            this.agendatype1.Location = new System.Drawing.Point(108, 503);
            this.agendatype1.Name = "agendatype1";
            this.agendatype1.Size = new System.Drawing.Size(316, 29);
            this.agendatype1.TabIndex = 15;
            // 
            // Categorie
            // 
            this.Categorie.FormattingEnabled = true;
            this.Categorie.Items.AddRange(new object[] {
            "Meeting",
            "Pauze",
            "Bellen",
            "Vrij"});
            this.Categorie.Location = new System.Drawing.Point(108, 560);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(121, 29);
            this.Categorie.TabIndex = 14;
            // 
            // timeEinde
            // 
            this.timeEinde.CustomFormat = "hh:m";
            this.timeEinde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEinde.Location = new System.Drawing.Point(112, 428);
            this.timeEinde.Name = "timeEinde";
            this.timeEinde.Size = new System.Drawing.Size(84, 29);
            this.timeEinde.TabIndex = 13;
            // 
            // timeStart
            // 
            this.timeStart.CustomFormat = "hh:m";
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(112, 302);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(84, 29);
            this.timeStart.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Einde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start";
            // 
            // Einddatum
            // 
            this.Einddatum.Location = new System.Drawing.Point(112, 393);
            this.Einddatum.Name = "Einddatum";
            this.Einddatum.Size = new System.Drawing.Size(312, 29);
            this.Einddatum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Omschrijving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Locatie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categorie";
            // 
            // beginDatum
            // 
            this.beginDatum.Location = new System.Drawing.Point(112, 267);
            this.beginDatum.Name = "beginDatum";
            this.beginDatum.Size = new System.Drawing.Size(312, 29);
            this.beginDatum.TabIndex = 5;
            this.beginDatum.ValueChanged += new System.EventHandler(this.datumPicker_ValueChanged);
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(108, 616);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(312, 79);
            this.txtOmschrijving.TabIndex = 4;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(280, 560);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(140, 29);
            this.txtLocatie.TabIndex = 3;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpslaan.Location = new System.Drawing.Point(204, 701);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(113, 32);
            this.btnOpslaan.TabIndex = 1;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(6, 24);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnSluiten
            // 
            this.btnSluiten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSluiten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSluiten.Location = new System.Drawing.Point(621, 559);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(226, 57);
            this.btnSluiten.TabIndex = 2;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(562, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(699, 350);
            this.dataGridView1.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "Notify\r\n";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 826);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.groupMaanden);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Indicia Kalender planner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupMaanden.ResumeLayout(false);
            this.groupMaanden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupMaanden;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker beginDatum;
        private System.Windows.Forms.DateTimePicker Einddatum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeEinde;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.ComboBox Categorie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Label Agendatype;
        private System.Windows.Forms.ComboBox agendatype1;
    }
}

