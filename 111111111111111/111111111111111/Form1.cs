
using System.IO;

namespace _111111111111111
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void lbloral_Click(object sender, EventArgs e)
        {

        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtsemester.Clear();
            txtaddentence.Clear();
            txttasks.Clear();
            txtmidterm.Clear();
            txtoral.Clear();
            txtpractice.Clear();
            txtbonus.Clear();
            txtfinal.Clear();
            txttotal.Clear();
            txtgrade.Clear();

            txtaddentence2.Clear();
            txttasks2.Clear();
            txtmidterm2.Clear();
            txtoral2.Clear();
            txtbonus2.Clear();
            txtpractice2.Clear();
            txtfinal2.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int addentence, tasks, midterm, oral, practice, bonus, final, total;
            string grade;


            addentence = int.Parse(txtaddentence.Text);
            tasks = int.Parse(txttasks.Text);
            midterm = int.Parse(txtmidterm.Text);
            practice = int.Parse(txtpractice.Text);
            bonus = int.Parse(txtbonus.Text);
            oral = int.Parse(txtoral.Text);
            final = int.Parse(txtfinal.Text);
            total = addentence + midterm + practice + bonus + final + tasks + oral;
            // txttotal.Text = total.ToString() + "/100";




            txtaddentence2.Text = txtaddentence.Text + "/10";
            txttasks2.Text = txttasks.Text + "/5";
            txtmidterm2.Text = txtmidterm.Text + "/5";
            txtpractice2.Text = txtpractice.Text + "/5";
            txtbonus2.Text = txtbonus.Text + "/5";
            txtoral2.Text = txtoral.Text + "/5";
            txtfinal2.Text = txtfinal.Text + "/60";





        }

        private void lblshinfo_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("Student data"))
            {
                sw.WriteLine(txtid.Text);
                sw.WriteLine(txtsemester.Text);
                sw.WriteLine(txtname.Text);
            }
        }


        private void lbldraw_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
            {
                e.Handled = true;

                int addentence, tasks, midterm, oral, practice, bonus, final, total;
                string grade;


                addentence = int.Parse(txtaddentence.Text);
                tasks = int.Parse(txttasks.Text);
                midterm = int.Parse(txtmidterm.Text);
                practice = int.Parse(txtpractice.Text);
                bonus = int.Parse(txtbonus.Text);
                oral = int.Parse(txtoral.Text);
                final = int.Parse(txtfinal.Text);
                total = addentence + midterm + practice + bonus + final + tasks + oral;
                txttotal.Text = total.ToString() + "/100";
               
            }
        }

        private void txtgrade_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtgrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'b')
            {
                e.Handled = true;
                int addentence, tasks, midterm, oral, practice, bonus, final, total;
                string grade;
                addentence = int.Parse(txtaddentence.Text);
                tasks = int.Parse(txttasks.Text);
                midterm = int.Parse(txtmidterm.Text);
                practice = int.Parse(txtpractice.Text);
                bonus = int.Parse(txtbonus.Text);
                oral = int.Parse(txtoral.Text);
                final = int.Parse(txtfinal.Text);
                total = addentence + midterm + practice + bonus + final + tasks + oral;


                if (total >= 85)
                {
                    grade = "excllent";
                }

                else if (total >= 75)
                {
                    grade = "very good";
                }

                else if (total >= 65)
                {
                    grade = "good";
                }

                else
                {
                    grade = " pass ";
                }

                txtgrade.Text = grade;
            }
        }

        private void buttonshow_Click(object sender, EventArgs e)
        {

        }
    }
}
