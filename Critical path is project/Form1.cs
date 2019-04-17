using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Critical_path_is_project
{
    public partial class Form1 : Form
    {

        public struct Activity
        {
            public string name_of_entitiy;
            public int duration_time;
            public int Est;
            public int Lst;
            public int Efi;
            public int Lfi;
            public int num_of_predecessors_c;
        }
        public static string[,] depend = new string[100,10];
        static Activity[] Network = new Activity[100];
        List<Panel> listpanel = new List<Panel>();
        int index;
        public static int counter = 0, counter_pre = 0;
        
        public Form1()
        {
            InitializeComponent();
            N_predecessor.Enabled = false;

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
                listpanel[++index].BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (index > 0)
                listpanel[--index].BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listpanel.Add(panel1);
            listpanel.Add(panel2);
            listpanel[index].BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public int Activity_input()
        {
            int num = Convert.ToInt16(Num_AC.Text);
            return num;
        }
        public static void cala_first_half(int size)
        {
            
            for (int i = 0; i < size; i++)
            {
                Activity[] find=new Activity[100];
                Activity val=Network[i];
                int  f = 0;
                if (Network[i].num_of_predecessors_c != 0)
                {
                    for (int j = 0; j < Network[i].num_of_predecessors_c; j++)
                    {
                        //enter the intitiy into new arr
                        for (int l = 0; l < size; l++)
                        {
                            if (Network[l].name_of_entitiy == depend[i,j])
                            {
                                find[f].name_of_entitiy = Network[l].name_of_entitiy;
                                find[f].duration_time = Network[l].duration_time;
                                find[f].num_of_predecessors_c = Network[l].num_of_predecessors_c;
                                find[f].Est = Network[l].Est;
                                find[f].Efi = Network[l].Efi;
                                f++;
                            }
                        }
                    }
                    //search for the biggist Els on the arr
                    int max_comp_du = find[0].Efi, index1=0;
                    for (int l = 0; l < f; l++)
                    {
                        if (max_comp_du <= find[l].Efi)
                        {
                            max_comp_du = find[l].Efi;
                            index1 = l;
                        }
                    }
                    Network[i].name_of_entitiy = val.name_of_entitiy;
                    Network[i].duration_time = val.duration_time;
                    Network[i].num_of_predecessors_c = val.num_of_predecessors_c;
                    Network[i].Est = find[index1].Efi + 1;
                    Network[i].Efi = Network[i].duration_time + Network[i].Est - 1;
                    f = 0;
                }
                else
                {
                    Network[i].name_of_entitiy = val.name_of_entitiy;
                    Network[i].duration_time = val.duration_time;
                    Network[i].num_of_predecessors_c = val.num_of_predecessors_c;
                    Network[i].Est = 1;
                    Network[i].Efi = Network[i].duration_time + Network[i].Est - 1;
                }
            }

        }
        public static void calc_second_half(int size)
        {
            Network[size - 1].Lst = Network[size - 1].Efi;
            Network[size - 1].Lfi = Network[size - 1].Lst - Network[size - 1].duration_time + 1;
            for (int i = size - 2; i >= 0; i--)
            {
                bool cheak = true;
                for (int j = i; j < size; j++)
                {
                    for (int w = 0; w < Network[j].num_of_predecessors_c; w++)
                    {
                        if (Network[i].name_of_entitiy == depend[j,w])
                        {
                            cheak = false;
                            break;
                        }
                    }
                }
                if (cheak == true)
                {
                    Network[i].Lst = Network[i].Efi;
                    Network[i].Lfi = Network[i].Lst - Network[i].duration_time;
                }
                else
                {
                    Activity [] find1=new Activity[100];
                    int f = 0;
                    for (int j = i; j < size; j++)
                    {
                        for (int w = 0; w < Network[j].num_of_predecessors_c; w++)
                        {
                            if (Network[i].name_of_entitiy == depend[j,w])
                            {
                                find1[f].name_of_entitiy = Network[j].name_of_entitiy;
                                find1[f].duration_time = Network[j].duration_time;
                                find1[f].num_of_predecessors_c = Network[j].num_of_predecessors_c;
                                find1[f].Est = Network[j].Est;
                                find1[f].Efi = Network[j].Efi;
                                find1[f].Lfi = Network[j].Lfi;
                                find1[f].Lst = Network[j].Lst;
                                f++;
                            }
                        }
                    }
                    int min_comp_du = find1[0].Lfi, index2;
                    for (int l = 0; l < f; l++)
                    {
                        if (min_comp_du >= find1[l].Lfi)
                        {
                            min_comp_du = find1[l].Lfi;
                            index2 = l;
                        }
                    }
                    Network[i].Lst = min_comp_du - 1;
                    Network[i].Lfi = Network[i].Lst - Network[i].duration_time + 1;
                    f = 0;
                }
            }
        }


        private void input_Click_1(object sender, EventArgs e)
        {
            Network[counter].name_of_entitiy =id_input.Text;
            Network[counter].duration_time = Convert.ToInt16(du_input.Text);
            cala_first_half(Activity_input());
            int s = counter + 2;
            id_input.Text = "";
            du_input.Text = "";
            ID.Text = "ID_" + s + " : ";
            Duration.Text = "Duration_" + s + " : ";
            counter++;
            counter_pre = 0;
            pre_input.Text = "";
            pre_AC.Text = "Activity_1 ID :";
            checkBox1.Checked = false;
            if (counter == Activity_input()) { input.Enabled = false; id_input.Enabled = false; du_input.Enabled = false; }
                
        }


        private void N_predecessor_Click_1(object sender, EventArgs e)
        {
            Network[counter].num_of_predecessors_c = Convert.ToInt16(pre_input.Text);
            depend[counter,counter_pre] = pre_id.Text;
            int s = counter_pre + 2;
            pre_id.Text = "";
            pre_AC.Text = "Activity_" + s + " ID :";
            counter_pre++;
            if (counter_pre == Convert.ToInt16(pre_input.Text))
                N_predecessor.Enabled = false;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                pre_input.Enabled = false;
                pre_id.Enabled = false;
                N_predecessor.Enabled = false;
            }
            if (checkBox1.Checked == true)
            {
                pre_input.Enabled = true;
                pre_id.Enabled = true;
                N_predecessor.Enabled = true;
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            int siz = Activity_input();
            calc_second_half(siz);
            finsh(siz);
            /*
            for(int i=0; i<Activity_input();i++)
            {
                MessageBox.Show(Network[i].name_of_entitiy);
            }*/
        }

        public void finsh(int size)
        {
            string answer = "";
            for (int i = 0; i < size; i++)
            {
                if (Network[i].Lst - Network[i].Efi == 0 && Network[i].Lfi - Network[i].Est == 0)
                {
                    answer += Network[i].name_of_entitiy;
                    if (i!=size-1)
                    answer += " --> ";
                }
            }
            Ans.Text = answer;
        }

        private void pre_input_TextChanged(object sender, EventArgs e)
        {

        }
        private void Num_AC_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void N_predecessor_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void Num_AC_TextChanged(object sender, EventArgs e)
        {

        }

    }
}