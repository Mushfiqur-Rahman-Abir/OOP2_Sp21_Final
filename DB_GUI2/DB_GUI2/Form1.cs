using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_GUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //do validation
            string cname = tbCName.Text;
            string ccode = tbCCode.Text;

            var conn = Database.ConnectDB();
            /*string connString = @"Server=DESKTOP-RTQVKPL;Database=demo_m_sp21; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);*/
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            string query = string.Format("insert into courses values ('{0}','{1}')",cname,ccode);
            try
            {


                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to insert Course");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            RefreshControls();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;


        }

        private void loadData_Click(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            /*string connString = @"Server=DESKTOP-RTQVKPL;Database=demo_m_sp21; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Course> courses = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();*/

           dtCourses.DataSource = courses;
        }

        List<Course> GetAllCourses()
        {
            var conn = Database.ConnectDB();
            /*string connString = @"Server=DESKTOP-RTQVKPL;Database=demo_m_sp21; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);*/
            List<Course> courses = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    courses.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return courses;
        }

        void RefreshControls()
        {
            tbCCode.Text = "";
            tbCName.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbSrchCid.Text);
            string cName = tbCnameUpdate.Text.Trim();
            string cCode = tbCcodeUpdate.Text.Trim();

            var conn = Database.ConnectDB();
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = String.Format("update courses set CourseName='{0}',CourseCode='{1}' where id={2}", cName, cCode, id);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var conn = Database.ConnectDB();

            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int id = Int32.Parse(tbSrchCid.Text);
            string query = "select * from courses where id= " +id;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Course c = new Course();
                while (reader.Read())
                {
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                }

                tbCnameUpdate.Text = c.CourseName;
                tbCcodeUpdate.Text = c.CourseCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }
    }
}
