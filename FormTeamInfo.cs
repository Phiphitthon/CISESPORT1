using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormTeamInfo : Form
    {
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxTeam1;
        private TextBox textBoxMember1;
        private TextBox textBoxName1;
        private TextBox textBoxGName1;
        private TextBox textBoxTeam2;
        private TextBox textBoxMember2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxTeam3;
        private TextBox textBoxGName2;
        private TextBox textBoxName2;
        private TextBox textBoxGName3;
        private TextBox textBoxName3;
        private TextBox textBoxMember3;
        private Button button1;
        private Button button2;
        private TextBox textBoxGName4;
        private TextBox textBoxName4;
        private TextBox textBoxMember4;
        private TextBox textBoxTeam4;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button3;
        private Button button4;
        private Label label1;

        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTeam1 = new System.Windows.Forms.TextBox();
            this.textBoxMember1 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxGName1 = new System.Windows.Forms.TextBox();
            this.textBoxTeam2 = new System.Windows.Forms.TextBox();
            this.textBoxMember2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTeam3 = new System.Windows.Forms.TextBox();
            this.textBoxGName2 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxGName3 = new System.Windows.Forms.TextBox();
            this.textBoxName3 = new System.Windows.Forms.TextBox();
            this.textBoxMember3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxGName4 = new System.Windows.Forms.TextBox();
            this.textBoxName4 = new System.Windows.Forms.TextBox();
            this.textBoxMember4 = new System.Windows.Forms.TextBox();
            this.textBoxTeam4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อทีม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อสมาชิก";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ชื่อในเกม";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ชื่อทีม";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "ชื่อสมาชิก";
            // 
            // textBoxTeam1
            // 
            this.textBoxTeam1.Location = new System.Drawing.Point(67, 10);
            this.textBoxTeam1.Name = "textBoxTeam1";
            this.textBoxTeam1.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeam1.TabIndex = 6;
            // 
            // textBoxMember1
            // 
            this.textBoxMember1.Location = new System.Drawing.Point(67, 39);
            this.textBoxMember1.Name = "textBoxMember1";
            this.textBoxMember1.Size = new System.Drawing.Size(100, 23);
            this.textBoxMember1.TabIndex = 7;
            // 
            // textBoxName1
            // 
            this.textBoxName1.Location = new System.Drawing.Point(67, 68);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 23);
            this.textBoxName1.TabIndex = 8;
            // 
            // textBoxGName1
            // 
            this.textBoxGName1.Location = new System.Drawing.Point(67, 97);
            this.textBoxGName1.Name = "textBoxGName1";
            this.textBoxGName1.Size = new System.Drawing.Size(100, 23);
            this.textBoxGName1.TabIndex = 9;
            // 
            // textBoxTeam2
            // 
            this.textBoxTeam2.Location = new System.Drawing.Point(284, 10);
            this.textBoxTeam2.Name = "textBoxTeam2";
            this.textBoxTeam2.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeam2.TabIndex = 10;
            // 
            // textBoxMember2
            // 
            this.textBoxMember2.Location = new System.Drawing.Point(284, 39);
            this.textBoxMember2.Name = "textBoxMember2";
            this.textBoxMember2.Size = new System.Drawing.Size(100, 23);
            this.textBoxMember2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "ชื่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "ชื่อในเกม";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "ชื่อทีม";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "ชื่อสมาชิก";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "ชื่อ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "ชื่อในเกม";
            // 
            // textBoxTeam3
            // 
            this.textBoxTeam3.Location = new System.Drawing.Point(67, 181);
            this.textBoxTeam3.Name = "textBoxTeam3";
            this.textBoxTeam3.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeam3.TabIndex = 20;
            // 
            // textBoxGName2
            // 
            this.textBoxGName2.Location = new System.Drawing.Point(284, 97);
            this.textBoxGName2.Name = "textBoxGName2";
            this.textBoxGName2.Size = new System.Drawing.Size(100, 23);
            this.textBoxGName2.TabIndex = 19;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Location = new System.Drawing.Point(284, 68);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 23);
            this.textBoxName2.TabIndex = 18;
            // 
            // textBoxGName3
            // 
            this.textBoxGName3.Location = new System.Drawing.Point(67, 268);
            this.textBoxGName3.Name = "textBoxGName3";
            this.textBoxGName3.Size = new System.Drawing.Size(100, 23);
            this.textBoxGName3.TabIndex = 23;
            // 
            // textBoxName3
            // 
            this.textBoxName3.Location = new System.Drawing.Point(67, 239);
            this.textBoxName3.Name = "textBoxName3";
            this.textBoxName3.Size = new System.Drawing.Size(100, 23);
            this.textBoxName3.TabIndex = 22;
            // 
            // textBoxMember3
            // 
            this.textBoxMember3.Location = new System.Drawing.Point(67, 210);
            this.textBoxMember3.Name = "textBoxMember3";
            this.textBoxMember3.Size = new System.Drawing.Size(100, 23);
            this.textBoxMember3.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxGName4
            // 
            this.textBoxGName4.Location = new System.Drawing.Point(284, 268);
            this.textBoxGName4.Name = "textBoxGName4";
            this.textBoxGName4.Size = new System.Drawing.Size(100, 23);
            this.textBoxGName4.TabIndex = 33;
            // 
            // textBoxName4
            // 
            this.textBoxName4.Location = new System.Drawing.Point(284, 239);
            this.textBoxName4.Name = "textBoxName4";
            this.textBoxName4.Size = new System.Drawing.Size(100, 23);
            this.textBoxName4.TabIndex = 32;
            // 
            // textBoxMember4
            // 
            this.textBoxMember4.Location = new System.Drawing.Point(284, 210);
            this.textBoxMember4.Name = "textBoxMember4";
            this.textBoxMember4.Size = new System.Drawing.Size(100, 23);
            this.textBoxMember4.TabIndex = 31;
            // 
            // textBoxTeam4
            // 
            this.textBoxTeam4.Location = new System.Drawing.Point(284, 181);
            this.textBoxTeam4.Name = "textBoxTeam4";
            this.textBoxTeam4.Size = new System.Drawing.Size(100, 23);
            this.textBoxTeam4.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "ชื่อในเกม";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "ชื่อ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "ชื่อสมาชิก";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(229, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "ชื่อทีม";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormTeamInfo
            // 
            this.ClientSize = new System.Drawing.Size(448, 448);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxGName4);
            this.Controls.Add(this.textBoxName4);
            this.Controls.Add(this.textBoxMember4);
            this.Controls.Add(this.textBoxTeam4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGName3);
            this.Controls.Add(this.textBoxName3);
            this.Controls.Add(this.textBoxMember3);
            this.Controls.Add(this.textBoxTeam3);
            this.Controls.Add(this.textBoxGName2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMember2);
            this.Controls.Add(this.textBoxTeam2);
            this.Controls.Add(this.textBoxGName1);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.textBoxMember1);
            this.Controls.Add(this.textBoxTeam1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTeamInfo";
            this.Load += new System.EventHandler(this.FormTeamInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
