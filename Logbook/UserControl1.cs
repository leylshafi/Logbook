using Logbook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logbook
{
    partial class UserControl1 : UserControl
    {
        public static int ChristalCount { get; set; } = 0;

        public UserControl1(Student student)
        {
            InitializeComponent();
            if (student != null)
            {
                InitializeStudent(student);

            }
        }

        private void InitializeStudent(Student student)
        {
            Id.Text = student.Number.ToString();

            //if (student.PictureUrl is not null)
                //picture.Image = Image.FromFile($"../../../Resources/{student.PictureUrl}");



            FullName.Text = student.FullName();

            if (student.LastIn.HasValue)
                Lastseen.Text = student.LastIn.Value.ToString("MM/dd/yy");


            switch (student.Status)
            {
                case Abscence.Present:
                    Present.Checked = true;
                    break;
                case Abscence.Absent:
                    Absent.Checked = true;
                    break;
                case Abscence.Late:
                    Late.Checked = true;
                    break;
            }
            comboBox1.Text = student.LaboratoryWork.ToString();
            comboBox2.Text=student.ClassWork.ToString();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((ChristalCount + 1) <= 5)
            {
                ChristalCount++;
                (sender as Button).BackgroundImage = Resources.christal;
                (sender as Button).BackgroundImageLayout = ImageLayout.Zoom;
            }
                
        }
    }
}
