using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventReservation
{
    public partial class mainForm : Form
    {
        private string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog = CrudDb; Integrated Security = True; Connect Timeout = 30; Encrypt=False";
        DataTable dataTable = new DataTable();
        string query = "";

        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            reload_Data();
        }
        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchField.Text.Trim().ToLower();
            DataView dv = dataTable.DefaultView;
            string filterExp = string.Empty;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible)
                {
                    if(column.ValueType == typeof(String))
                    {
                        filterExp += $" {column.DataPropertyName} LIKE '%{searchText}%' OR";
                    }
                }
            }
            if (!string.IsNullOrEmpty(filterExp))
            {
                filterExp = filterExp.Remove(filterExp.Length - 3);
            }
            dv.RowFilter = filterExp;

        }


        //Refresh
        private void reload_Data()
        {
            query = "SELECT * FROM dbo.attendees_Info";
            dbAccess(query);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            reload_Data();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            popUpForm signUpForm = new popUpForm();
            signUpForm.ShowDialog();
            dbAccess(signUpForm.Callback_query);
            reload_Data();
        }

        private void update(object sender, DataGridViewCellEventArgs e)
        {
            popUpForm signUpForm;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                var id = dataGridView.Rows[e.RowIndex].Cells[0].Value;
                signUpForm = new popUpForm(id.ToString());
                signUpForm.fName.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                signUpForm.lName.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                signUpForm.phone.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                signUpForm.address.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                signUpForm.ShowDialog();
                dbAccess(signUpForm.Callback_query);
                reload_Data();
            }
        }

        private void delete(object sender,  EventArgs e)//DELETE
        {
            DialogResult res = MessageBox.Show("Are you sure you want to cancel reservation?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if(res == DialogResult.Yes)
            {
                string id = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string query = $"DELETE FROM dbo.attendees_Info WHERE Id = '{id}'";
                dbAccess(query);
                reload_Data();
            }
        }



        ////////////QUERY FUNCTIONS


        private void dbAccess(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection opened successfully.");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        dataTable.Clear();
                        // Fill the DataTable with data from the database
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;
                        dataGridView.Columns["Id"].Visible = false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General error: {ex.Message}");
                }
                finally
                {
                    // Close the connection
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection closed.");
                    }
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            remove.Enabled = dataGridView.SelectedRows.Count > 0; 
        }
    }
}
