using Registro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = tbNombre.Text;
            person.LastName = tbApellido.Text;
            person.Birthdate = dtpBirthdate.Value;
            person.Edad = Convert.ToInt32(DateTime.Now.Year - dtpBirthdate.Value.Year); 
            persons.Add(person);
            showPersons();
            ClearTb();
        }

        private void showPersons()
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = persons;
        }

        private void ClearTb()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            dtpBirthdate.Value = DateTime.Now;
            tbNombre.Focus();
        }
    }
}
