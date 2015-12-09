using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE695_Project
{
    public partial class Form1 : Form
    {
        int current_index = -1;
        int last_index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bayesian_node.map.Clear();
            Bayesian_node.event_table.Clear();
            Bayesian_node.event_count = 0;
            string path = textBox2.Text;
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                line = sr.ReadLine();
                string[] data = line.Split(' ');
                Bayesian_node.event_count = int.Parse(data[1]);

                for(int i=0;i<Bayesian_node.event_count;i++)
                {
                    line = sr.ReadLine();
                    data = line.Split(' ');
                    Bayesian_node.map.Add(new Bayesian_node(i, int.Parse(data[1]), data[0]));
                }

                while ((line = sr.ReadLine()) != null)
                {
                    int[] ele = new int[Bayesian_node.event_count];
                    data = line.Split(' ');
                    for(int i=0;i<Bayesian_node.event_count;i++)
                    {
                        ele[i] = int.Parse(data[i]);
                    }
                    Bayesian_node.event_table.Add(ele);
                }
            }
            Bayesian_node.create_network(float.Parse(textbox_epsilon.Text));
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Font drawFont = new System.Drawing.Font("Calibri", 12);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            System.Drawing.SolidBrush blackbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.SolidBrush selectbrush = new System.Drawing.SolidBrush(System.Drawing.Color.Aqua);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            foreach (var node in Bayesian_node.map)
            {
                if(node.index!=last_index)e.Graphics.FillEllipse(myBrush, new Rectangle(node.positionX, node.positionY, 50, 50));
                else e.Graphics.FillEllipse(selectbrush, new Rectangle(node.positionX, node.positionY, 50, 50));
                e.Graphics.DrawString(node.str, drawFont, blackbrush, node.positionX, node.positionY+15, drawFormat);
                foreach(int p in node.parents)
                {

                    int x1 = node.positionX + 25;
                    int y1 = node.positionY + 25;
                    int x2 = Bayesian_node.map[p].positionX + 25;
                    int y2 = Bayesian_node.map[p].positionY + 25;
                    double k;
                    if (x1 == x2) k = 0;
                    else k = (double)(y2 - y1) / (x2 - x1);
                    k = Math.Abs(k);
                    double m = Math.Sqrt(k * k + 1);
                    double deltax = 25 / m;
                    double deltay = deltax * k;
                    if(x1>=x2)
                    {
                        x1 -= (int)deltax;
                        x2 += (int)deltax;
                    }
                    else
                    {
                        x1 += (int)deltax;
                        x2 -= (int)deltax;
                    }
                    if(y1>=y2)
                    {
                        y1 -= (int)deltay;
                        y2 += (int)deltay;
                    }
                    else
                    {
                        y1 += (int)deltay;
                        y2 -= (int)deltay;
                    }
                    e.Graphics.DrawLine(pen, x1,y1,x2,y2);
                }
            }        
            myBrush.Dispose();
        }

        private void textbox_epsilon_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(var node in Bayesian_node.map)
            {
                float dsqure = (e.X - node.positionX-25) * (e.X - node.positionX-25) + (e.Y - node.positionY-25) * (e.Y - node.positionY-25);
                //Console.WriteLine(node.str + "-" +dsqure.ToString());
                if (dsqure<300)
                {
                    current_index = node.index;
                    last_index = node.index;
                    if(node.set_value)
                    {
                        radioButton_true.Checked = true;
                    }
                    else
                    {
                        radioButton_false.Checked = true;
                    }
                    switch(node.type)
                    {
                        case Bayesian_node.status.STATUS_INTERVEND:
                            {
                                radioButton_intervened.Checked = true;
                                break;
                            }
                        case Bayesian_node.status.STATUS_OBSERVED:
                            {
                                radioButton_observed.Checked = true;
                                break;
                            }
                        case Bayesian_node.status.STATUS_TARGET:
                            {
                                radioButton_target.Checked = true;
                                break;
                            }
                        case Bayesian_node.status.STATUS_UNKNOWN:
                            {
                                radioButton_unknown.Checked = true;
                                //radioButton_unknown.Update();
                                break;
                            }
                    }
                    break;
                }
            }
            this.Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            current_index = -1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (current_index != -1)
            {
                Bayesian_node.map[current_index].positionX = e.X - 25;
                Bayesian_node.map[current_index].positionY = e.Y - 25;
                this.Refresh();
            }
        }

        private void radioButton_target_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].type = Bayesian_node.status.STATUS_TARGET;
        }

        private void radioButton_observed_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].type = Bayesian_node.status.STATUS_OBSERVED;
        }

        private void radioButton_intervened_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].type = Bayesian_node.status.STATUS_INTERVEND;
        }

        private void radioButton_unknown_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].type = Bayesian_node.status.STATUS_UNKNOWN;
        }

        private void radioButton_true_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].set_value = true;
        }

        private void radioButton_false_CheckedChanged(object sender, EventArgs e)
        {
            Bayesian_node.map[last_index].set_value = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> unknown = new List<int>();
            foreach (var node in Bayesian_node.map)
            {
                if (node.type == Bayesian_node.status.STATUS_UNKNOWN) unknown.Add(node.index);
            }
            int iteration_count = (int)Math.Pow(2, unknown.Count);
            double sum_n = 0;
            double sum_d = 0;
            for (int i = 0; i < iteration_count; i++)
            {
                double p = 1;
                string binary = Convert.ToString(i, 2);
                while (binary.Length < unknown.Count) binary = "0" + binary;
                for (int j = 0; j < unknown.Count; j++)
                {
                    if (binary[j] == '0') Bayesian_node.map[unknown[j]].set_value = false;
                    else Bayesian_node.map[unknown[j]].set_value = true;
                }
                foreach (var node in Bayesian_node.map)
                {
                    if (node.type == Bayesian_node.status.STATUS_INTERVEND) continue;
                    p *= Bayesian_node.posibility(node.index, true);
                }
                sum_n += p;
            }


            foreach (var node in Bayesian_node.map)
            {
                if (node.type == Bayesian_node.status.STATUS_TARGET) unknown.Add(node.index);
            }
            iteration_count = (int)Math.Pow(2, unknown.Count);
            for (int i = 0; i < iteration_count; i++)
            {
                double p = 1;
                string binary = Convert.ToString(i, 2);
                while (binary.Length < unknown.Count) binary = "0" + binary;
                for (int j = 0; j < unknown.Count; j++)
                {
                    if (binary[j] == '0') Bayesian_node.map[unknown[j]].set_value = false;
                    else Bayesian_node.map[unknown[j]].set_value = true;
                }
                foreach (var node in Bayesian_node.map)
                {
                    if (node.type == Bayesian_node.status.STATUS_INTERVEND) continue;
                    p *= Bayesian_node.posibility(node.index, true);
                }
                sum_d += p;
            }

            double re = 0;
            if (sum_d != 0) re = sum_n / sum_d;
            label_result.Text = "P=" + re.ToString();
            label_result.Text = label_result.Text.Substring(0, 14);
        }
    }
}
