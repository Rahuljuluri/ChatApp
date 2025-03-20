namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textlocalport = new TextBox();
            textlocalip = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textremoteport = new TextBox();
            textremoteip = new TextBox();
            label4 = new Label();
            label3 = new Label();
            buttonConnect = new Button();
            textMessage = new TextBox();
            listMessage = new ListBox();
            buttonsend = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GrayText;
            groupBox1.Controls.Add(textlocalport);
            groupBox1.Controls.Add(textlocalip);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Me";
            // 
            // textlocalport
            // 
            textlocalport.Location = new Point(95, 76);
            textlocalport.Name = "textlocalport";
            textlocalport.Size = new Size(125, 27);
            textlocalport.TabIndex = 3;
            // 
            // textlocalip
            // 
            textlocalip.Location = new Point(95, 30);
            textlocalip.Name = "textlocalip";
            textlocalip.Size = new Size(125, 27);
            textlocalip.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "PORT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(textremoteport);
            groupBox2.Controls.Add(textremoteip);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(424, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Frd";
            // 
            // textremoteport
            // 
            textremoteport.Location = new Point(96, 79);
            textremoteport.Name = "textremoteport";
            textremoteport.Size = new Size(125, 27);
            textremoteport.TabIndex = 4;
            // 
            // textremoteip
            // 
            textremoteip.Location = new Point(96, 34);
            textremoteip.Name = "textremoteip";
            textremoteip.Size = new Size(125, 27);
            textremoteip.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 86);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 2;
            label4.Text = "PORT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 41);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 1;
            label3.Text = "IP";
            // 
            // buttonConnect
            // 
            buttonConnect.BackColor = SystemColors.WindowFrame;
            buttonConnect.Location = new Point(774, 84);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(94, 29);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = false;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // textMessage
            // 
            textMessage.Location = new Point(40, 498);
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(739, 27);
            textMessage.TabIndex = 3;
            // 
            // listMessage
            // 
            listMessage.FormattingEnabled = true;
            listMessage.Location = new Point(40, 194);
            listMessage.Name = "listMessage";
            listMessage.Size = new Size(841, 284);
            listMessage.TabIndex = 4;
            // 
            // buttonsend
            // 
            buttonsend.Location = new Point(787, 497);
            buttonsend.Name = "buttonsend";
            buttonsend.Size = new Size(94, 29);
            buttonsend.TabIndex = 5;
            buttonsend.Text = "Send";
            buttonsend.UseVisualStyleBackColor = true;
            buttonsend.Click += buttonsend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(924, 549);
            Controls.Add(buttonsend);
            Controls.Add(listMessage);
            Controls.Add(textMessage);
            Controls.Add(buttonConnect);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ChatApp";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textlocalport;
        private TextBox textlocalip;
        private Label label2;
        private Label label1;
        private TextBox textremoteport;
        private TextBox textremoteip;
        private Label label4;
        private Label label3;
        private Button buttonConnect;
        private TextBox textMessage;
        private ListBox listMessage;
        private Button buttonsend;
    }
}
