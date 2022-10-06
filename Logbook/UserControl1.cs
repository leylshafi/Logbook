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
        List<Student> students = new List<Student>();
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

            if (student.PictureUrl is not null)
            {
                switch (student.PictureUrl)
                {
                    case "pp1.png":
                        panel9.BackgroundImage = Resources.pp1;
                        break;
                    case "pp2.png":
                        panel9.BackgroundImage = Resources.pp2;
                        break;
                    case "pp3.png":
                        panel9.BackgroundImage = Resources.pp3;
                        break;
                    case "pp4.png":
                        panel9.BackgroundImage = Resources.pp4;
                        break;
                    default:
                        break;
                }
               
                panel9.BackgroundImageLayout = ImageLayout.Zoom;
            }



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
                (sender as Button).Tag = "christal";
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in panel8.Controls)
            {
                if(item is Button s && s?.Tag=="christal")
                {
                    s.BackgroundImage = Resources.icons8_diamond_48;
                    ChristalCount--;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(sender is Button b)
                panel6.Controls.Remove(b);
            RichTextBox textBox = new RichTextBox()
            {
                Location = new Point(8, 10),
                Size = new Size(250,70)
            };

            Button btn1 = new Button()
            { 
                Location= new Point(8,80),
                Size = new Size(50,50),
                BackgroundImage= Resources.icons8_save_100,
                BackgroundImageLayout = ImageLayout.Zoom
            };

            panel6.Controls.Add(textBox);
            panel6.Controls.Add(btn1);

            btn1.Click += (object? sender, EventArgs e) =>
            {
                Label lbl = new Label()
                {
                    Location = new Point(8, 40),
                    Text = textBox.Text,
                };

                panel6.Controls.Add(lbl);
                panel6.Controls.Remove(textBox);
                panel6.Controls.Remove(btn1);

            };

          

        }

    }
}
