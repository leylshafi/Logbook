using Guna.UI2.WinForms;

namespace Logbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
            RichTextBox textBox1 = new RichTextBox()
            {
                Location = new Point(861, 77),
                Size = new Size(283, 67)
            };

            Guna2Button button1 = new Guna2Button()
            {
                BorderRadius = 7,
                Size = new Size(134, 37),
                Location = new Point(1125, 156),
                Text= "Add"
            };

            Controls.Add(textBox1);
            Controls.Add(button1);
           
            button1.Click += Button1_Click;

            void Button1_Click(object? sender, EventArgs e)
            {
                label3.Text = textBox1.Text;
                Controls.Remove(textBox1);
                Controls.Remove(button1);
            }

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2RadioButton1.Checked || guna2RadioButton2.Checked)
            {
                guna2CustomRadioButton1.Enabled = true;
                panel2.Enabled = true;
                guna2Button1.Enabled = true;
            }
        }
    }
}