using System.Security.Principal;

namespace demoapp
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        Student s;
        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
         s = new Student();
             MessageBox.Show("Student object created.");
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
          s.Id = int.Parse(txtId.Text);
          s.Name = txtName.Text;
          s.Marks = decimal.Parse(txtMarks.Text);
            
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            txtId.Text = s.Id.ToString();
            txtName.Text = s.Name;
            txtMarks.Text = s.Marks.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtMarks.Clear();
        }
    }
}
