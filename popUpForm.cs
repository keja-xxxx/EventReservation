using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventReservation
{
    public partial class popUpForm : Form
    {

        public string Callback_query { get; private set; }
        public string id;

        private string mode;
        public popUpForm()
        {
            InitializeComponent();
            add.Text = "Confirm\nReservation";
        }
        public popUpForm(string selection)
        {
            InitializeComponent();
            add.Text = "Save\nChanges";
            id = selection;
            MessageBox.Show(id);
        }


        
        private void add_Click(object sender, EventArgs e)
        {
            if(add.Text.Equals("Confirm\nReservation")) //ADD
            { 
                Callback_query = $"INSERT INTO dbo.attendees_Info(FirstName, LastName, PhoneNumber, Address) " +
                $"VALUES ('{fName.Text}', '{lName.Text}', '{phone.Text}', '{address.Text}')";
                this.Close();
            }
            else //UPDATE
            {
                Callback_query = $"UPDATE dbo.attendees_Info SET FirstName = '{fName.Text}', LastName = '{lName.Text}', " +
                    $"PhoneNumber = '{phone.Text}', Address = '{address.Text}'  WHERE Id = '{id}'";
                this.Close();
            }
        }
    }
}
