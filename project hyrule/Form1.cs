using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

//Notizen nach einem Update:
//Um adressen wieder zu finden einfach Links Kostüme suchen
//ID's für die ersten 4:
//00,01,02,03
//DLC: 08,09,0A,0B,0C,0D
//Abstand von anderen Charakteren: F4

namespace Hyrule
{

    public partial class Form1 : Form
    {
        public uint diff;
        public TCPGecko Gecko;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBox_Click(object sender, EventArgs e)
        {
            Gecko = new TCPGecko(ipBox.Text, 7331);
            {
                StreamWriter File = new StreamWriter("toolip.txt");
                File.Write(ipBox.Text);
                File.Close();
            }
            try
            {
                Gecko.Connect();
                connectBox.Enabled = false;
                label17.ForeColor = System.Drawing.ColorTranslator.FromHtml("#64B385");
                label17.Text = "Connected!";
                load();
            }
            catch (ETCPGeckoException)
            {
                //For tests
                //load();
                MessageBox.Show("Connection failed.");
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("You entered a wrong IP format.");
            }

        }


        public void release()
        {
            ipBox.Enabled = false;
            button13.Enabled = false;
        }
        public void hold()
        {
            ipBox.Enabled = false;
            button13.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox7.Enabled = true;
        }
        public void load()
        {

            hold();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x35617294, Convert.ToUInt32(numericUpDown1.Value)); //rupees
                                                                              //old address: 35614E84

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x1071387C, 0x00000000); //damage taken

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
                timer1.Start();
                button2.Enabled = false;
            }

            else

            {
                timer1.Stop();
                button2.Enabled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            Gecko.poke32(0x1071387C, 0x00000000); //damage taken
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x1071390C, 0x01010000); //full magic

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)

            {
                timer2.Start();
                button3.Enabled = false;
            }

            else

            {
                timer2.Stop();
                button3.Enabled = true;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 500;
            Gecko.poke32(0x1071390C, 0x01010000); //full magic
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x107138FC, 0x03030000); //full special

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)

            {
                timer3.Start();
                button4.Enabled = false;
            }

            else

            {
                timer3.Stop();
                button4.Enabled = true;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 500;
            Gecko.poke32(0x107138FC, 0x03030000); //full special
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x10713880, Convert.ToUInt32(numericUpDown5.Value));
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)

            {
                timer4.Start();
                button5.Enabled = false;
            }

            else

            {
                timer4.Stop();
                button5.Enabled = true;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Interval = 500;
            Gecko.poke32(0x10713880, Convert.ToUInt32(numericUpDown5.Value));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x35628A64, 0x03E703E7); //Materials
            Gecko.poke32(0x35628A68, 0x03E703E7);
            Gecko.poke32(0x35628A6C, 0x03E703E7);
            Gecko.poke32(0x35628A70, 0x03E703E7);
            Gecko.poke32(0x35628A74, 0x03E703E7);
            Gecko.poke32(0x35628A78, 0x03E703E7);
            Gecko.poke32(0x35628A7C, 0x03E703E7);
            Gecko.poke32(0x35628A80, 0x03E703E7);
            Gecko.poke32(0x35628A84, 0x03E703E7);
            Gecko.poke32(0x35628A88, 0x03E703E7);
            Gecko.poke32(0x35628A8C, 0x03E703E7);
            Gecko.poke32(0x35628A90, 0x03E703E7);
            Gecko.poke32(0x35628A94, 0x03E703E7);
            Gecko.poke32(0x35628A98, 0x03E703E7);
            Gecko.poke32(0x35628A9C, 0x03E703E7);
            Gecko.poke32(0x35628AA0, 0x03E703E7);
            Gecko.poke32(0x35628AA4, 0x03E703E7);
            Gecko.poke32(0x35628AA8, 0x03E703E7);
            Gecko.poke32(0x35628AAC, 0x03E703E7);
            Gecko.poke32(0x35628AD0, 0x03E703E7);
            Gecko.poke32(0x35628AD4, 0x03E703E7);
            Gecko.poke32(0x35628AD8, 0x03E703E7);
            Gecko.poke32(0x35628ADC, 0x03E703E7);
            Gecko.poke32(0x35628AE0, 0x03E703E7);
            Gecko.poke32(0x35628AE4, 0x03E703E7);
            Gecko.poke32(0x35628AE8, 0x03E703E7);
            Gecko.poke32(0x35628AEC, 0x03E703E7);
            Gecko.poke32(0x35628AF0, 0x03E703E7);
            Gecko.poke32(0x35628AF4, 0x03E703E7);
            Gecko.poke32(0x35628AF8, 0x03E703E7);
            Gecko.poke32(0x35628AFC, 0x03E703E7);
            Gecko.poke32(0x35628AB0, 0x03E703E7);
            Gecko.poke32(0x35628AB4, 0x03E703E7);
            Gecko.poke32(0x35628AB8, 0x03E703E7);
            Gecko.poke32(0x35628ABC, 0x03E703E7);
            Gecko.poke32(0x35628AC0, 0x03E703E7);
            Gecko.poke32(0x35628AC4, 0x03E703E7);
            Gecko.poke32(0x35628AC8, 0x03E703E7);
            Gecko.poke32(0x35628ACC, 0x03E703E7);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //offset difference: 2410
            Gecko.poke32(0x3562B334, 0x06060606); //All Adventure Items
            Gecko.poke32(0x3562B338, 0x06060606);
            Gecko.poke32(0x3562B33C, 0x06060606);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x3563038C, 0x06060606); //All Master Quest Items
            Gecko.poke32(0x35630390, 0x06060606);
            Gecko.poke32(0x35630394, 0x06060606);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x35632BB8, 0x06000000); //All Twilight Items
            Gecko.poke32(0x35632BBC, 0x00060600);
            Gecko.poke32(0x35632BC4, 0x06060606);
            Gecko.poke32(0x35632BC8, 0x06060606);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356353E4, 0x06060000); //All Termina Items
            Gecko.poke32(0x356353E8, 0x00000006);
            Gecko.poke32(0x356353F8, 0x06060606);
            Gecko.poke32(0x356353FC, 0x06060606);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x387746FF, Convert.ToUInt32(numericUpDown2.Value));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit the Trainingroom via the Adventure Map, to make the Level Hack work!");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ipBox.Text = File.ReadAllText("toolip.txt");
        }

        private void button14_Click(object sender, EventArgs e)
        {

            adventure(0x35617817, comboBox1.Text);

        }

        public void adventure(uint address1, string mode)
        {
            switch (mode)
            {
                case "Link":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Zelda":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Sheik":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Impa":
                    Gecko.poke08(address1, 0x03);
                    break;

                case "Ganondorf":
                    Gecko.poke08(address1, 0x04);
                    break;

                case "Darunia":
                    Gecko.poke08(address1, 0x05);
                    break;

                case "Ruto":
                    Gecko.poke08(address1, 0x06);
                    break;

                case "Agitha":
                    Gecko.poke08(address1, 0x07);
                    break;

                case "Midna":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Fi":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Ghirahim":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Zant":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Lana":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Cia":
                    Gecko.poke08(address1, 0x2C);
                    break;

                case "Volga":
                    Gecko.poke08(address1, 0x2D);
                    break;

                case "Wizzro":
                    Gecko.poke08(address1, 0x2E);
                    break;

                case "Twili Midna":
                    Gecko.poke08(address1, 0x2F);
                    break;

                case "Young Link":
                    Gecko.poke08(address1, 0x30);
                    break;

                case "Tingle":
                    Gecko.poke08(address1, 0x31);
                    break;

                case "Ganon (Ganon-Mode)":
                    Gecko.poke08(address1, 0x32);
                    break;

                case "Cucco":
                    Gecko.poke08(address1, 0x33);
                    break;

                case "Linkle":
                    Gecko.poke08(address1, 0x34);
                    break;

                case "Skull Kid":
                    Gecko.poke08(address1, 0x35);
                    break;

                case "Toon-Link":
                    Gecko.poke08(address1, 0x36);
                    break;

                case "Tetra":
                    Gecko.poke08(address1, 0x37);
                    break;

                case "King Daphnes":
                    Gecko.poke08(address1, 0x38);
                    break;

                case "Medli":
                    Gecko.poke08(address1, 0x39);
                    break;

                case "Toon-Zelda":
                    Gecko.poke08(address1, 0x3A);
                    break;
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/missing-number.16713/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to character Select, set the new Character and just press A until the Mission starts!");
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D559C, 0x00000000); //lock link

        }

        private void button18_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D559C, 0x00000001); //unlock link

        }

        private void button19_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D55A0, 0xFFFFFFFF); //link costumes

        }

        private void button20_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D55A4, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D55A8, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D55AC, 0xFFFFFFFF); //link upgrades
            Gecko.poke32(0x356D55B0, 0xFFFFFFFF); //link upgrades

        }

        private void button25_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5878, 0x00000000); //lock impa

        }

        private void button27_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5878, 0x00000001); //unlock impa

        }

        private void button28_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D587C, 0xFFFFFFFF); //impa costumes

        }

        private void button30_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5880, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D5884, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D5888, 0xFFFFFFFF); //impa upgrades
            Gecko.poke32(0x356D588C, 0xFFFFFFFF); //impa upgrades

        }

        private void button32_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5892, 0xFFFFFFFF); //impa damage

        }

        private void button31_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5894, 0x4E20); //impa hearts

        }


        private void button33_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5784, 0x000000000); //lock sheik

        }

        private void button35_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5784, 0x00000001); //unlock sheik

        }

        private void button36_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5788, 0xFFFFFFFF); //costumes sheik

        }

        private void button38_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D578C, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D5790, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D5794, 0xFFFFFFFF); //skills sheik
            Gecko.poke32(0x356D5798, 0xFFFFFFFF); //skills sheik

        }

        private void button40_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D579C, 0xFFFFFFFF); //sheik damage

        }

        private void button39_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D57A0, 0x4E20); //sheik hearts

        }

        private void button41_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6200, 0x00000000); //lock lana

        }

        private void button43_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6200, 0x00000001); //unlock lana

        }

        private void button44_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6204, 0xFFFFFFFF); //costumes lana

        }

        private void button46_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6208, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D620C, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D6210, 0xFFFFFFFF); //skill lana
            Gecko.poke32(0x356D6214, 0xFFFFFFFF); //skill lana

        }

        private void button48_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6218, 0xFFFFFFFF); //lana damage

        }

        private void button47_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D621C, 0x4E20); //lana hearts

        }

        private void button49_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D7F8C, 0x00000000); //lock cia

        }

        private void button51_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D7F8C, 0x00000003); //unlock cia

        }

        private void button52_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D7F90, 0xFFFFFFFF); //Cia costumes

        }

        private void button54_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D7F94, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D7F98, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D7F9C, 0xFFFFFFFF); //Cia skill
            Gecko.poke32(0x356D7FA0, 0xFFFFFFFF); //Cia skill

        }

        private void button56_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D7FA4, 0xFFFFFFFF); //cia damage

        }

        private void button55_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D7FA8, 0x4E20); //cia hearts

        }


        private void button57_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5690, 0x00000000); //lock zelda

        }

        private void button59_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5690, 0x00000001); //unlock zelda

        }

        private void button60_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5694, 0xFFFFFFFF); //zelda costume

        }

        private void button62_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5698, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D569C, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D56A0, 0xFFFFFFFF); //zelda skill
            Gecko.poke32(0x356D56A4, 0xFFFFFFFF); //zelda skill

        }

        private void button64_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D56A8, 0xFFFFFFFF); //zelda damage

        }

        private void button63_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D56AC, 0x4E20); //zelda hearts

        }


        private void button65_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D596C, 0x00000000); //lock ganondorf

        }

        private void button67_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D596C, 0x00000001); //unlock ganondorf

        }

        private void button68_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5970, 0xFFFFFFFF); //ganondorf costumes

        }

        private void button70_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5974, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D5978, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D597C, 0xFFFFFFFF); //ganondorf skills
            Gecko.poke32(0x356D5980, 0xFFFFFFFF); //ganondorf skills

        }

        private void button72_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5984, 0xFFFFFFFF); //ganondorf damage

        }

        private void button71_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5988, 0x4E20); //ganondorf hearts

        }

        private void button73_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5A60, 0x00000000); //lock darunia

        }

        private void button75_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5A60, 0x00000001); //unlock darunia

        }

        private void button76_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5A64, 0xFFFFFFFF); //darunia costumes

        }

        private void button78_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5A68, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D5A6C, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D5A70, 0xFFFFFFFF); //darunia skill
            Gecko.poke32(0x356D5A74, 0xFFFFFFFF); //darunia skill

        }

        private void button80_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5A78, 0xFFFFFFFF); //darunia damage

        }

        private void button79_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5A7C, 0x4E20); //darunia hearts

        }

        private void button81_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B54, 0x00000000); //lock ruto

        }

        private void button83_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B54, 0x00000001); //unlock ruto

        }

        private void button84_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B58, 0xFFFFFFFF); //ruto costumes

        }

        private void button86_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B5C, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D5B60, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D5B64, 0xFFFFFFFF); //ruto skill
            Gecko.poke32(0x356D5B68, 0xFFFFFFFF); //ruto skill

        }

        private void button88_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5B6C, 0xFFFFFFFF); //ruto damage

        }

        private void button87_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5B70, 0x4E20); //ruto hearts

        }

        private void button89_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C48, 0x00000000); //lock Agnitha

        }

        private void button91_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C48, 0x00000001); //unlock Agnitha

        }

        private void button92_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C4C, 0xFFFFFFFF); //Agnitha Costumes

        }

        private void button94_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C50, 0xFFFFFFFF); //Agnitha Skills
            Gecko.poke32(0x356D5C54, 0xFFFFFFFF);
            Gecko.poke32(0x356D5C58, 0xFFFFFFFF);
            Gecko.poke32(0x356D5C5C, 0xFFFFFFFF);

        }

        private void button96_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5C60, 0xFFFFFFFF); //agni damage

        }

        private void button95_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5C64, 0x4E20); //agni hearts

        }

        private void button97_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D3C, 0x00000000); //lock Midna

        }

        private void button99_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D3C, 0x00000001); //unlock Midna

        }

        private void button100_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D40, 0xFFFFFFFF); //Midna Costumes

        }

        private void button102_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D44, 0xFFFFFFFF); //Minda Skills
            Gecko.poke32(0x356D5D48, 0xFFFFFFFF);
            Gecko.poke32(0x356D5D4C, 0xFFFFFFFF);
            Gecko.poke32(0x356D5D50, 0xFFFFFFFF);

        }

        private void button104_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5D54, 0xFFFFFFFF); //Midna damage

        }

        private void button103_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5D58, 0x4E20); //Midna Hearts

        }


        private void button105_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6018, 0x00000000); //lock Zant

        }

        private void button107_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6018, 0x00000001); //unlock Zant

        }

        private void button108_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D601C, 0xFFFFFFFF); //Zant Costumes

        }

        private void button110_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6020, 0xFFFFFFFF); //Zant skills
            Gecko.poke32(0x356D6024, 0xFFFFFFFF);
            Gecko.poke32(0x356D6028, 0xFFFFFFFF);
            Gecko.poke32(0x356D602C, 0xFFFFFFFF);

        }

        private void button112_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D6030, 0xFFFFFFFF); //Zant Damage

        }

        private void button111_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D6034, 0x4E20); //Zant Hearts

        }

        private void button113_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E30, 0x00000000); //lock Fi

        }

        private void button115_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E30, 0x00000001); //unlock Fi

        }

        private void button116_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E34, 0xFFFFFFFF); //Fi Costumes

        }

        private void button118_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E38, 0xFFFFFFFF); //Fi Skill
            Gecko.poke32(0x356D5E3C, 0xFFFFFFFF);
            Gecko.poke32(0x356D5E40, 0xFFFFFFFF);
            Gecko.poke32(0x356D5E44, 0xFFFFFFFF);

        }

        private void button120_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5E48, 0xFFFFFFFF); //Fi Damage

        }

        private void button119_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5E4C, 0x4E20); //Fi Hearts

        }

        private void button121_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F24, 0x00000000); //lock Ghira

        }

        private void button123_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F24, 0x00000001); //unlock Ghira

        }

        private void button124_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F28, 0xFFFFFFFF); //Ghira Costumes

        }

        private void button126_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F2C, 0xFFFFFFFF); //Ghira Skills
            Gecko.poke32(0x356D5F30, 0xFFFFFFFF);
            Gecko.poke32(0x356D5F34, 0xFFFFFFFF);
            Gecko.poke32(0x356D5F38, 0xFFFFFFFF);

        }

        private void button128_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D5F3C, 0xFFFFFFFF); //Ghira Damage

        }

        private void button127_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D5F40, 0x4E20); //Ghira Hearts

        }


        private void button129_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8080, 0x00000000); //lock Volga

        }

        private void button131_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8080, 0x00000003); //unlock Volga

        }

        private void button132_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8084, 0xFFFFFFFF); //volga costumes

        }

        private void button134_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8088, 0xFFFFFFFF); //Volga Skills
            Gecko.poke32(0x356D808C, 0xFFFFFFFF);
            Gecko.poke32(0x356D8090, 0xFFFFFFFF);
            Gecko.poke32(0x356D8094, 0xFFFFFFFF);

        }

        private void button136_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8098, 0xFFFFFFFF); //Volga Damage

        }

        private void button135_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D809C, 0x4E20); //Volga Hearts

        }

        private void button137_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8174, 0x00000000); //lock Wizzro

        }

        private void button139_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8174, 0x00000001); //lock Wizzro

        }

        private void button140_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8178, 0xFFFFFFFF); //Wizzro Costumes

        }

        private void button142_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D817C, 0xFFFFFFFF); //Wizzro Skills
            Gecko.poke32(0x356D8180, 0xFFFFFFFF);
            Gecko.poke32(0x356D8184, 0xFFFFFFFF);
            Gecko.poke32(0x356D8188, 0xFFFFFFFF);

        }

        private void button144_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D818E, 0xFFFFFFFF); //Wizzro Damage

        }

        private void button143_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8190, 0x4E20); //Wizzro hearts

        }

        private void button145_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8268, 0x00000000); //lock twimidna

        }

        private void button147_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8268, 0x00000003); //unlock twimidna

        }

        private void button150_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8270, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D8274, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D8278, 0xFFFFFFFF); //unlock twimidna
            Gecko.poke32(0x356D827C, 0xFFFFFFFF); //unlock twimidna

        }

        private void button152_Click(object sender, EventArgs e)
        {

            Gecko.poke32    (0x356D8280, 0xFFFFFFFF); //twimidna Damage

        }

        private void button151_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8284, 0x4E20); //twimidna hearts

        }


        private void button153_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D835C, 0x00000000); //lock younglink

        }

        private void button155_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D835C, 0x00000003); //unlock younglink

        }

        private void button158_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8364, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D8368, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D836C, 0xFFFFFFFF); //unlock younglink
            Gecko.poke32(0x356D8370, 0xFFFFFFFF); //unlock younglink

        }

        private void button160_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8374, 0xFFFFFFFF); //younglink Damage

        }

        private void button159_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8378, 0xFFFFFFFF); //younglink hearts

        }

        private void button161_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8450, 0x00000000); //lock tingle

        }

        private void button163_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8450, 0x00000003); //unlock tingle

        }

        private void button166_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8458, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D845C, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D8460, 0xFFFFFFFF); //unlock tingle
            Gecko.poke32(0x356D8464, 0xFFFFFFFF); //unlock tingle

        }

        private void button168_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8468, 0xFFFFFFFF); //tingle Damage

        }

        private void button167_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D846C, 0x4E20); //tingle hearts

        }


        private void button169_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D872C, 0x00000000); //lock Linkle

        }

        private void button171_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D872C, 0x00000003); //unlock Linkle

        }

        private void button174_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8734, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D8738, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D873C, 0xFFFFFFFF); //unlock Linkle
            Gecko.poke32(0x356D8740, 0xFFFFFFFF); //unlock Linkle

        }

        private void button176_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8744, 0xFFFFFFFF); //linkle Damage

        }

        private void button175_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8748, 0x4E20); //linkle hearts

        }


        private void button177_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8820, 0x00000000); //lock Skull Kid

        }

        private void button179_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8820, 0x00000003); //unlock Skull Kid

        }

        private void button182_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8828, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D882C, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D8830, 0xFFFFFFFF); //unlock Skull Kid
            Gecko.poke32(0x356D8834, 0xFFFFFFFF); //unlock Skull Kid

        }

        private void button184_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8838, 0xFFFFFFFF); //skull Damage

        }

        private void button183_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D883C, 0x4E20); //skull hearts

        }


        private void button185_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8914, 0x00000000); //lock Toon-Link

        }

        private void button187_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8914, 0x00000003); //unlock Toon-Link

        }

        private void button190_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D891C, 0xFFFFFFFF); //toonlink skill
            Gecko.poke32(0x356D8920, 0xFFFFFFFF);
            Gecko.poke32(0x356D8924, 0xFFFFFFFF);
            Gecko.poke32(0x356D8928, 0xFFFFFFFF);

        }

        private void button192_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D892C, 0xFFFFFFFF); //toon Damage

        }

        private void button191_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8930, 0x4E20); //toon hearts

        }


        private void button193_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8A08, 0x00000000); //lock Tetra

        }

        private void button195_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8A08, 0x00000003); //unlock Tetra

        }

        private void button198_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8A10, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D8A14, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D8A18, 0xFFFFFFFF); //tetra skills
            Gecko.poke32(0x356D8A1C, 0xFFFFFFFF); //tetra skills

        }

        private void button200_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8A20, 0xFFFFFFFF); //tetra Damage

        }

        private void button199_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8A24, 0x4E20); //tetra hearts

        }


        private void button201_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8AFC, 0x00000000); //lock King

        }

        private void button203_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8AFC, 0x00000003); //unlock King

        }

        private void button206_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8B04, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D8B08, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D8B0C, 0xFFFFFFFF); //skill King
            Gecko.poke32(0x356D8B10, 0xFFFFFFFF); //skill King

        }

        private void button208_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8B14, 0xFFFFFFFF); //king Damage

        }

        private void button207_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8B18, 0x4E20); //king hearts

        }

        private void button209_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8BF0, 0x00000000); //lock Medli

        }

        private void button211_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8BF0, 0x00000003); //unlock Medli

        }

        private void button214_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8BF8, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D8BFC, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D8C00, 0xFFFFFFFF); //Medli Skill
            Gecko.poke32(0x356D8C04, 0xFFFFFFFF); //Medli Skill

        }

        private void button216_Click(object sender, EventArgs e)
        {

            Gecko.poke32(0x356D8C08, 0xFFFFFFFF); //Medli Damage

        }

        private void button215_Click(object sender, EventArgs e)
        {

            Gecko.poke16(0x356D8C0C, 0x4E20); //medli hearts

        }

        private void button23_Click(object sender, EventArgs e)
        {

            freemode(0x3561780D, comboBox19.Text);

        }

        public void freemode(uint address1, string mode)
        {
            switch (mode)
            {
                case "Link":
                    Gecko.poke08(address1, 0x00);
                    break;

                case "Zelda":
                    Gecko.poke08(address1, 0x01);
                    break;

                case "Sheik":
                    Gecko.poke08(address1, 0x02);
                    break;

                case "Impa":
                    Gecko.poke08(address1, 0x03);
                    break;

                case "Ganondorf":
                    Gecko.poke08(address1, 0x04);
                    break;

                case "Darunia":
                    Gecko.poke08(address1, 0x05);
                    break;

                case "Ruto":
                    Gecko.poke08(address1, 0x06);
                    break;

                case "Agitha":
                    Gecko.poke08(address1, 0x07);
                    break;

                case "Midna":
                    Gecko.poke08(address1, 0x08);
                    break;

                case "Fi":
                    Gecko.poke08(address1, 0x09);
                    break;

                case "Ghirahim":
                    Gecko.poke08(address1, 0x0A);
                    break;

                case "Zant":
                    Gecko.poke08(address1, 0x0B);
                    break;

                case "Lana":
                    Gecko.poke08(address1, 0x0D);
                    break;

                case "Cia":
                    Gecko.poke08(address1, 0x2C);
                    break;

                case "Volga":
                    Gecko.poke08(address1, 0x2D);
                    break;

                case "Wizzro":
                    Gecko.poke08(address1, 0x2E);
                    break;

                case "Twili Midna":
                    Gecko.poke08(address1, 0x2F);
                    break;

                case "Young Link":
                    Gecko.poke08(address1, 0x30);
                    break;

                case "Tingle":
                    Gecko.poke08(address1, 0x31);
                    break;

                case "Ganon (Ganon-Mode)":
                    Gecko.poke08(address1, 0x32);
                    break;

                case "Cucco":
                    Gecko.poke08(address1, 0x33);
                    break;

                case "Linkle":
                    Gecko.poke08(address1, 0x34);
                    break;

                case "Skull Kid":
                    Gecko.poke08(address1, 0x35);
                    break;

                case "Toon-Link":
                    Gecko.poke08(address1, 0x36);
                    break;

                case "Tetra":
                    Gecko.poke08(address1, 0x37);
                    break;

                case "King Daphnes":
                    Gecko.poke08(address1, 0x38);
                    break;

                case "Medli":
                    Gecko.poke08(address1, 0x39);
                    break;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/jaguar9400.366384/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/wolf-snake.156732/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/gamepil.399819/");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Gecko.poke32(0x10713888, Convert.ToUInt32(numericUpDown6.Value));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x10713890, Convert.ToUInt32(numericUpDown9.Value));
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)

            {
                timer5.Start();
                button6.Enabled = false;
            }

            else

            {
                timer5.Stop();
                button6.Enabled = true;

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)

            {
                timer6.Start();
                button15.Enabled = false;
            }

            else

            {
                timer6.Stop();
                button15.Enabled = true;

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            termina(0x35637A04, comboBox2.Text);
        }

        public void termina(uint address1, string mode)
        {
            switch (mode)
            {
                case "24 Hours":
                    Gecko.poke32(address1, 0x18000000);
                    break;

                case "48 Hours":
                    Gecko.poke32(address1, 0x30000000);
                    break;

                case "72 Hours":
                    Gecko.poke32(address1, 0x48000000);
                    break;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D4F50, 0x01000389); // Twilight Minda Unlock
                Gecko.poke32(0x356D8268, 0x00000003); // Twilight Minda Unlock
                Gecko.poke32(0x356DF4AC, 0x00010100); // Twilight Minda Unlock
                Gecko.poke32(0x356DF4CC, 0x00010100); // Twilight Minda Unlock
                Gecko.poke32(0x356DF4EC, 0x00010100); // Twilight Minda Unlock
                Gecko.poke32(0x35709F94, 0x01000000); // Twilight Minda Unlock
                Gecko.poke32(0x356EA20C, 0x02000000); // Twilight Minda Unlock
                Gecko.poke32(0x356EA210, 0x00000060); // Twilight Minda Unlock
                Gecko.poke32(0x356EA214, 0x01180005); // Twilight Minda Unlock
                MessageBox.Show("Character Unlocked: \r\nTwili Midna");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D8ECC, 0x00000003); // Ravio
                Gecko.poke32(0x356EAA94, 0x02000000); // Ravio
                Gecko.poke32(0x356EAA98, 0x00000092); // Ravio
                Gecko.poke32(0x356EAA9C, 0x01180005); // Ravio
                Gecko.poke32(0x356D5054, 0x01000370); // Ravio
                Gecko.poke32(0x356DFAEC, 0x00010100); // Ravio
                Gecko.poke32(0x356DFB0C, 0x00010100); // Ravio
                Gecko.poke32(0x356DFB2C, 0x00010100); // Ravio
                Gecko.poke32(0x3570A264, 0x01000000); // Ravio
                Gecko.poke32(0x356D8FC0, 0x00000003); // Yuga
                Gecko.poke32(0x356EAB30, 0x02000000); // Yuga
                Gecko.poke32(0x356EAB34, 0x00000095); // Yuga
                Gecko.poke32(0x356EAB38, 0x01180005); // Yuga
                Gecko.poke32(0x356D5068, 0x01000389); // Yuga
                Gecko.poke32(0x356DFB4C, 0x00010100); // Yuga
                Gecko.poke32(0x356DFB6C, 0x00010100); // Yuga
                Gecko.poke32(0x356DFB8C, 0x00010100); // Yuga
                Gecko.poke32(0x3570A28C, 0x01000000); // Yuga
                MessageBox.Show("Character Unlocked: \r\nRavio\r\nYuga");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D835C, 0x00000003); // Majoras Toon
                Gecko.poke32(0x356EA344, 0x02000000); // Majoras Toon
                Gecko.poke32(0x356EA348, 0x00000069); // Majoras Toon
                Gecko.poke32(0x356EA34C, 0x01180005); // Majoras Toon
                Gecko.poke32(0x356D4F64, 0x01000357); // Majoras Toon
                Gecko.poke32(0x356DF5CC, 0x00010100); // Majoras Toon
                Gecko.poke32(0x356DF5EC, 0x00010100); // Majoras Toon
                Gecko.poke32(0x356DF60C, 0x00010100); // Majoras Toon
                Gecko.poke32(0x3570A00C, 0x01000000); // Majoras Toon
                Gecko.poke32(0x356D8450, 0x00000003); // Majoras Tingle
                Gecko.poke32(0x356EA3E0, 0x02000000); // Majoras Tingle
                Gecko.poke32(0x356EA3E4, 0x0000006C); // Majoras Tingle
                Gecko.poke32(0x356EA3E8, 0x01180005); // Majoras Tingle
                Gecko.poke32(0x356D4F78, 0x0100033E); // Majoras Tingle
                Gecko.poke32(0x356DF62C, 0x00010100); // Majoras Tingle
                Gecko.poke32(0x356DF64C, 0x00010100); // Majoras Tingle
                Gecko.poke32(0x356DF66C, 0x00010100); // Majoras Tingle
                Gecko.poke32(0x3570A034, 0x01000000); // Majoras Tingle
                MessageBox.Show("Character Unlocked: \r\nYoung Link\r\nTingle");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D872C, 0x00000003); // Legends Linkle
                Gecko.poke32(0x356EA518, 0x02000000); // Legends Linkle
                Gecko.poke32(0x356EA51C, 0x00000074); // Legends Linkle
                Gecko.poke32(0x356EA520, 0x01180005); // Legends Linkle
                Gecko.poke32(0x356EA5B4, 0x02000000); // Legends Linkle
                Gecko.poke32(0x356EA5B8, 0x00000089); // Legends Linkle
                Gecko.poke32(0x356EA5BC, 0x01180005); // Legends Linkle
                Gecko.poke32(0x356D4FB4, 0x01000357); // Legends Linkle
                Gecko.poke32(0x356DF72C, 0x00010100); // Legends Linkle
                Gecko.poke32(0x356DF74C, 0x00010100); // Legends Linkle
                Gecko.poke32(0x356DF9CC, 0x00010100); // Legends Linkle
                Gecko.poke32(0x356DF9EC, 0x00010100); // Legends Linkle
                Gecko.poke32(0x356DFA0C, 0x00010100); // Legends Linkle
                Gecko.poke32(0x3570A0D4, 0x01000000); // Legends Linkle
                Gecko.poke32(0x3570A1EC, 0x01000000); // Legends Linkle
                Gecko.poke32(0x356D8914, 0x00000003); // Legends Toon Link
                Gecko.poke32(0x356EA6EC, 0x02000000); // Legends Toon Link
                Gecko.poke32(0x356EA6F0, 0x0000007A); // Legends Toon Link
                Gecko.poke32(0x356EA6F4, 0x01180005); // Legends Toon Link
                Gecko.poke32(0x356EA788, 0x02000000); // Legends Toon Link
                Gecko.poke32(0x356EA78C, 0x0000008F); // Legends Toon Link
                Gecko.poke32(0x356EA790, 0x01180005); // Legends Toon Link
                Gecko.poke32(0x356D4FDC, 0x01000370); // Legends Toon Link
                Gecko.poke32(0x356DF7EC, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x356DF80C, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x356DF82C, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x356DFA8C, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x356DFAAC, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x356DFACC, 0x00010100); // Legends Toon Link
                Gecko.poke32(0x3570A124, 0x01000000); // Legends Toon Link
                Gecko.poke32(0x3570A23C, 0x01000000); // Legends Toon Link
                Gecko.poke32(0x356D8A08, 0x00000003); // Legends Tetra
                Gecko.poke32(0x356EA824, 0x02000000); // Legends Tetra
                Gecko.poke32(0x356EA828, 0x0000007D); // Legends Tetra
                Gecko.poke32(0x356EA82C, 0x01180005); // Legends Tetra
                Gecko.poke32(0x356D4FF0, 0x01000357); // Legends Tetra
                Gecko.poke32(0x356DF84C, 0x00010100); // Legends Tetra
                Gecko.poke32(0x356DF86C, 0x00010100); // Legends Tetra
                Gecko.poke32(0x356DF88C, 0x00010100); // Legends Tetra
                Gecko.poke32(0x3570A14C, 0x01000000); // Legends Tetra
                Gecko.poke32(0x356D8AFC, 0x00000003); // Legends King Daphnes
                Gecko.poke32(0x356EA8C0, 0x02000000); // Legends King Daphnes
                Gecko.poke32(0x356EA8C4, 0x00000080); // Legends King Daphnes
                Gecko.poke32(0x356EA8C8, 0x01180005); // Legends King Daphnes
                Gecko.poke32(0x356D5004, 0x01000389); // Legends King Daphnes
                Gecko.poke32(0x356DF8AC, 0x00010100); // Legends King Daphnes
                Gecko.poke32(0x356DF8CC, 0x00010100); // Legends King Daphnes
                Gecko.poke32(0x356DF8EC, 0x00010100); // Legends King Daphnes
                Gecko.poke32(0x3570A174, 0x01000000); // Legends King Daphnes
                Gecko.poke32(0x356D8820, 0x00000003); // Legends Skull Kid
                Gecko.poke32(0x356EA650, 0x02000000); // Legends Skull Kid
                Gecko.poke32(0x356EA654, 0x00000077); // Legends Skull Kid
                Gecko.poke32(0x356EA658, 0x01180005); // Legends Skull Kid
                Gecko.poke32(0x356D4FC8, 0x01000357); // Legends Skull Kid
                Gecko.poke32(0x356DF78C, 0x00010100); // Legends Skull Kid
                Gecko.poke32(0x356DF7AC, 0x00010100); // Legends Skull Kid
                Gecko.poke32(0x356DF7CC, 0x00010100); // Legends Skull Kid
                Gecko.poke32(0x3570A0FC, 0x01000000); // Legends Skull Kid
                Gecko.poke32(0x356EA47C, 0x02000000); // Legends Ganon Weapon
                Gecko.poke32(0x356EA480, 0x00000071); // Legends Ganon Weapon
                Gecko.poke32(0x356EA484, 0x01180005); // Legends Ganon Weapon

                MessageBox.Show("Character Unlocked: \r\nLinkle\r\nToon Link\r\nTetra\r\nKing Daphnes (To Do)\r\nSkull Kid\r\nGanon's Trident (Weapon)");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D8CE4, 0x00000003); // Awakening Marin
                Gecko.poke32(0x356EA95C, 0x02000000); // Awakening Marin
                Gecko.poke32(0x356EA960, 0x00000086); // Awakening Marin
                Gecko.poke32(0x356EA964, 0x01180005); // Awakening Marin
                Gecko.poke32(0x356D502C, 0x01000357); // Awakening Marin
                Gecko.poke32(0x356DF96C, 0x00010100); // Awakening Marin
                Gecko.poke32(0x356DF98C, 0x00010100); // Awakening Marin
                Gecko.poke32(0x356DF9AC, 0x00010100); // Awakening Marin
                Gecko.poke32(0x3570A1C4, 0x01000000); // Awakening Marin
                Gecko.poke32(0x356EA5B4, 0x02000000); // Legends Linkle
                Gecko.poke32(0x356EA5B8, 0x00000089); // Legends Linkle
                Gecko.poke32(0x356EA5BC, 0x01180005); // Legends Linkle

                MessageBox.Show("Character Unlocked: \r\nMarin\r\nLinkle - Boots (Weapon)");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you in the Title Screen?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Gecko.poke32(0x356D8DD8, 0x00000003); // Phantom Toon Zelda
                Gecko.poke32(0x356EA9F8, 0x02000000); // Phantom Toon Zelda
                Gecko.poke32(0x356EA9FC, 0x0000008C); // Phantom Toon Zelda
                Gecko.poke32(0x356EAA00, 0x01180005); // Phantom Toon Zelda
                Gecko.poke32(0x356D5040, 0x01000370); // Phantom Toon Zelda
                Gecko.poke32(0x356DFA2C, 0x00010100); // Phantom Toon Zelda
                Gecko.poke32(0x356DFA4C, 0x00010100); // Phantom Toon Zelda
                Gecko.poke32(0x356DFA6C, 0x00010100); // Phantom Toon Zelda
                Gecko.poke32(0x3570A214, 0x01000000); // Phantom Toon Zelda
                Gecko.poke32(0x356EA788, 0x02000000); // Legends Toon Link
                Gecko.poke32(0x356EA78C, 0x0000008F); // Legends Toon Link
                Gecko.poke32(0x356EA790, 0x01180005); // Legends Toon Link

                MessageBox.Show("Character Unlocked: \r\nToon Zelda\r\nToon Link - Sand Wand (Weapon)");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Please go into the Title Screen");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x3562AE74, 0x03E703E7);
            Gecko.poke32(0x3562AE78, 0x03E703E7);
            Gecko.poke32(0x3562AE7C, 0x03E703E7);
            Gecko.poke32(0x3562AE80, 0x03E703E7);
            Gecko.poke32(0x3562AE84, 0x03E703E7);
            Gecko.poke32(0x3562AE88, 0x03E703E7);
            Gecko.poke32(0x3562AE8C, 0x03E703E7);
            Gecko.poke32(0x3562AE90, 0x03E703E7);
            Gecko.poke32(0x3562AE94, 0x03E703E7);
            Gecko.poke32(0x3562AE98, 0x03E703E7);
            Gecko.poke32(0x3562AE9C, 0x03E703E7);
            Gecko.poke32(0x3562AEA0, 0x03E703E7);
            Gecko.poke32(0x3562AEA4, 0x03E703E7);
            Gecko.poke32(0x3562AEA8, 0x03E703E7);
            Gecko.poke32(0x3562AEAC, 0x03E703E7);
            Gecko.poke32(0x3562AEB0, 0x03E703E7);
            Gecko.poke32(0x3562AEB4, 0x03E703E7);
            Gecko.poke32(0x3562AEB8, 0x03E703E7);
            Gecko.poke32(0x3562AEBC, 0x03E703E7);
            Gecko.poke32(0x3562AEC0, 0x03E703E7);
            Gecko.poke32(0x3562AEC4, 0x03E703E7);
            Gecko.poke32(0x3562AEC8, 0x03E703E7);
            Gecko.poke32(0x3562AECC, 0x03E703E7);
            Gecko.poke32(0x3562AED0, 0x03E703E7);
            Gecko.poke32(0x3562AED4, 0x03E703E7);
            Gecko.poke32(0x3562AED8, 0x03E703E7);
            Gecko.poke32(0x3562AEDC, 0x03E703E7);
            Gecko.poke32(0x3562AEE0, 0x03E703E7);
            Gecko.poke32(0x3562AEE4, 0x03E703E7);
            Gecko.poke32(0x3562AEE8, 0x03E703E7);
            Gecko.poke32(0x3562AEEC, 0x03E703E7);
            Gecko.poke32(0x3562AEF0, 0x03E703E7);
            Gecko.poke32(0x3562AEF4, 0x03E703E7);
            Gecko.poke32(0x3562AEF8, 0x03E703E7);
            Gecko.poke32(0x3562AEFC, 0x03E703E7);
            Gecko.poke32(0x3562AF00, 0x03E703E7);
            Gecko.poke32(0x3562AE04, 0x03E703E7);
            Gecko.poke32(0x3562AE08, 0x03E703E7);
            Gecko.poke32(0x3562AE0C, 0x03E70000);
            Gecko.poke32(0x3562AF74, 0xFFFFFFFF);
            Gecko.poke32(0x3562AF78, 0xFFFFFFFF);
            Gecko.poke32(0x3562AF7C, 0xFF1F0000);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://gbatemp.net/members/steamboy0x7e0.404952/");
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D55B4, 0xFFFFFFFF); //link damage
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Gecko.poke16(0x356D55B8, 0x4E20); //link hearts
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8CE4, 0x00000000); // Marin Lock
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8CE4, 0x00000003); // Marin Unlock
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8CEC, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8CF0, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8CF4, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8CF8, 0xFFFFFFFF); //Marin Skill
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8CFC, 0xFFFFFFFF); // Marin Damage
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Gecko.poke16(0x356D8D00, 0x4E20); // Marin Hearts
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8DD8, 0x00000000); // Toon Zelda lock
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8DD8, 0x00000003); // Toon Zelda unlock
        }

        private void button85_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8DE0, 0xFFFFFFFF); //Toon Zelda
            Gecko.poke32(0x356D8DE4, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8DE8, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8DEC, 0xFFFFFFFF); //Marin Skill
        }

        private void button93_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8DF0, 0xFFFFFFFF); // Toon Zelda Damage
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Gecko.poke16(0x356D8DF4, 0x4E20); // Toon Zelda Hearts
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8ECC, 0x00000000); // Ravio Lock
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8ECC, 0x00000003); // Ravio Unlock
        }

        private void button106_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8ED4, 0xFFFFFFFF); //Ravio Skill
            Gecko.poke32(0x356D8ED8, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8EDC, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8EE0, 0xFFFFFFFF); //Marin Skill
        }

        private void button114_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8EE4, 0xFFFFFFFF); // Ravio Damage
        }

        private void button109_Click(object sender, EventArgs e)
        {
            Gecko.poke16(0x356D8EE8, 0x4E20); // Ravio Hearts
        }

        private void button117_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8FC0, 0x00000000); // Yuga Lock
        }

        private void button122_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8FC0, 0x00000003); // Yuga Unlock
        }

        private void button125_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8FC8, 0xFFFFFFFF); //Yuga Skill
            Gecko.poke32(0x356D8FCC, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8FD0, 0xFFFFFFFF); //Marin Skill
            Gecko.poke32(0x356D8FD4, 0xFFFFFFFF); //Marin Skill
        }

        private void button133_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x356D8FD8, 0xFFFFFFFF); //Yuga Damage
        }

        private void button130_Click(object sender, EventArgs e)
        {
            Gecko.poke16(0x356D8FDC, 0x4E20); //Yuga Hearts
        }
  
    }
}