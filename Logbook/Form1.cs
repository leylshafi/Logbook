using Guna.UI2.WinForms;
using System.Text;

namespace Logbook;

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
            Size = new Size(180, 33),
            Location = new Point(1254, 134),
            Text = "Add"
        };


        Controls.Add(textBox1);
        Controls.Add(button1);
        button1.BringToFront();
        button1.Click += Button1_Click;

        void Button1_Click(object? sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            Controls.Remove(textBox1);
            Controls.Remove(button1);
        }

    }

    private void radioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButton1.Checked || radioButton2.Checked)
        {
            guna2CustomRadioButton1.Enabled = true;
            panel2.Enabled = true;
            guna2Button1.Enabled = true;


            foreach (var control in pnl_students.Controls)
                if (control is UserControl1 s)
                {
                    if (s.Name == "panel3")
                        MessageBox.Show("panel3");
                    foreach (var item in s.Controls[0].Controls)
                    {
                        if (item is Control p && p.Name == "panel3")
                        {
                            foreach (var a in p.Controls)
                            {
                                if (a is RadioButton it)
                                    it.Enabled = true;
                            }
                        }
                        if (item is Control p4 && p4.Name == "panel4")
                        {
                            foreach (var a in p4.Controls)
                            {
                                if (a is ComboBox it)
                                    it.Enabled = true;
                            }
                        }
                        if (item is Control p7 && p7.Name == "panel7")
                        {
                            foreach (var a in p7.Controls)
                            {
                                if (a is ComboBox it)
                                    it.Enabled = true;
                            }
                        }
                        if (item is Control pp && (pp.Name == "panel8" || pp.Name == "panel6"))
                        {
                            foreach (var a in pp.Controls)
                            {
                                if (a is Button it)
                                    it.Enabled = true;
                            }
                        }
                    }

                }
            foreach (var control in pnl_students.Controls)
                if (control is UserControl1 s)
                {
                    foreach (var item in s.Controls[0].Controls)
                    {
                        if (item is ComboBox it)
                            it.Enabled = true;

                    }

                }
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        for (int i = FakeRepository.Students.Count - 1; i >= 0; i--)
        {
            var userControl = new UserControl1(FakeRepository.Students[i]);
            userControl.Dock = DockStyle.Top;
            pnl_students.Controls.Add(userControl);
        }


        AutoScrollMinSize = new Size(1300, 220 + pnl_students.PreferredSize.Height);
    }

    private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
    {

        foreach (var control in pnl_students.Controls)
            if (control is UserControl1 s)
            {
                if (s.Name == "panel3")
                    MessageBox.Show("panel3");
                foreach (var item in s.Controls[0].Controls)
                {
                    if (item is Control p && p.Name == "panel3")
                    {
                        foreach (var a in p.Controls)
                        {
                            if (a is RadioButton it)
                                it.Checked = true;
                        }
                    }

                }

            }
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {

        var jsonString = System.Text.Json.JsonSerializer.Serialize(FakeRepository.Students);
        File.WriteAllText("students.json", jsonString);

        using FileStream fs = new FileStream("students.json", FileMode.Open);
        if (fs != null)
        {
            List<Student> students = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(fs);

            StringBuilder sb = new StringBuilder();
            foreach (var item in FakeRepository.Students)
                sb.Append(item.ToString());
            MessageBox.Show(sb.ToString());
        }


        
       

    }
}
