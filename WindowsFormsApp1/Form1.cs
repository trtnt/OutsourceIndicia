﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void groupMaanden_Enter(object sender, EventArgs e)
        {
            groupMaanden.Show();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.DataSource = GetAppointment();
        }

        public List<Agenda> GetAppointment() {
            string datum = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            AgendaContainer agendacontainer = new AgendaContainer();
            return agendacontainer.getAll(Convert.ToDateTime(datum));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        private void datumPicker_ValueChanged(object sender, EventArgs e)
        {
            string dt = beginDatum.Value.ToString("dd-MM-yyyy");
            lblHead.Text = dt.ToString();
        }

        private void txtCategorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            addAppointment();
            MessageBox.Show("Afspraak staat ingepland");
        }

        public void addAppointment()
        {
            AgendaContainer agendacontainer = new AgendaContainer();

            DateTimePicker timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm"; // Only use hours and minutes
            timePicker.ShowUpDown = true;

            DateTime begindatum = beginDatum.Value;
            DateTime einddatum = Einddatum.Value;
            TimeSpan begintijd = TimeSpan.Parse(timeStart.Value.ToString("HH:mm"));
            TimeSpan eindtijd = TimeSpan.Parse(timeEinde.Value.ToString("HH:mm"));
            string categorie = Categorie.Text;
            string locatie = txtLocatie.Text;
            string omschrijving = txtOmschrijving.Text;

            Agenda agenda = new Agenda(begindatum, einddatum, begintijd, eindtijd, categorie, locatie, omschrijving);
            agendacontainer.insert(agenda);
            dataGridView1.DataSource = GetAppointment();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Einddatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
