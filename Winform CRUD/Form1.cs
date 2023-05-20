using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_CRUD_DB
{
    public partial class Form1 : Form
    {

        private int id_pekerjaan;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void showDB()
        {
            dataGridView1.DataSource = CrudDatabasePBO.ReadData();
            dataGridView1.Columns[0].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CrudDatabasePBO.CreateData(nama.Text, deskripsi.Text, kualifikasi.Text, skills.Text, rerata.Text, lokasi.Text);
            showDB();
            nama.Text = "";
            deskripsi.Text = "";
            kualifikasi.Text = "";
            skills.Text = "";
            rerata.Text = "";
            lokasi.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showDB();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (id_pekerjaan > 0)
            {
                CrudDatabasePBO.UpdateData(nama.Text, deskripsi.Text, kualifikasi.Text, skills.Text, rerata.Text, lokasi.Text, id_pekerjaan);
                showDB();

                nama.Text = "";
                deskripsi.Text = "";
                kualifikasi.Text = "";
                skills.Text = "";
                rerata.Text = "";
                lokasi.Text = "";

                dataGridView1.CurrentRow.Selected = false;
            }
            else
            {
                MessageBox.Show("Tidak ada baris yang dipilih, silahkan pilih baris yang ingin diupdate", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (id_pekerjaan > 0)
            {
                CrudDatabasePBO.DeleteData(id_pekerjaan);
                showDB();
                nama.Text = "";
                deskripsi.Text = "";
                kualifikasi.Text = "";
                skills.Text = "";
                rerata.Text = "";
                lokasi.Text = "";
                dataGridView1.CurrentRow.Selected = false;
            }
            else
            {
                MessageBox.Show("Tidak ada baris yang dipilih, silahkan pilih baris yang ingin didelete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            deskripsi.Text = "";
            kualifikasi.Text = "";
            skills.Text = "";
            rerata.Text = "";
            lokasi.Text = "";

            dataGridView1.CurrentRow.Selected = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_pekerjaan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            nama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            deskripsi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            kualifikasi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            skills.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            rerata.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            lokasi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();


        }
    }
}
