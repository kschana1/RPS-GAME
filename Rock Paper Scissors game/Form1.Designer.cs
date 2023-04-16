namespace Rock_Paper_Scissors_game
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
            this.components = new System.ComponentModel.Container();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.spockbutton = new System.Windows.Forms.RadioButton();
            this.lizardbutton = new System.Windows.Forms.RadioButton();
            this.readybtn = new System.Windows.Forms.Button();
            this.scibutton = new System.Windows.Forms.RadioButton();
            this.paperbutton = new System.Windows.Forms.RadioButton();
            this.rockbutton = new System.Windows.Forms.RadioButton();
            this.textbox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.scorestxt = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.winbox = new System.Windows.Forms.RichTextBox();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.spockbutton);
            this.gb1.Controls.Add(this.lizardbutton);
            this.gb1.Controls.Add(this.readybtn);
            this.gb1.Controls.Add(this.scibutton);
            this.gb1.Controls.Add(this.paperbutton);
            this.gb1.Controls.Add(this.rockbutton);
            this.gb1.Location = new System.Drawing.Point(65, 75);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(188, 246);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // spockbutton
            // 
            this.spockbutton.AutoSize = true;
            this.spockbutton.Location = new System.Drawing.Point(6, 122);
            this.spockbutton.Name = "spockbutton";
            this.spockbutton.Size = new System.Drawing.Size(57, 19);
            this.spockbutton.TabIndex = 2;
            this.spockbutton.TabStop = true;
            this.spockbutton.Text = "Spock";
            this.spockbutton.UseVisualStyleBackColor = true;
            this.spockbutton.CheckedChanged += new System.EventHandler(this.spockbutton_CheckedChanged);
            // 
            // lizardbutton
            // 
            this.lizardbutton.AutoSize = true;
            this.lizardbutton.Location = new System.Drawing.Point(6, 97);
            this.lizardbutton.Name = "lizardbutton";
            this.lizardbutton.Size = new System.Drawing.Size(56, 19);
            this.lizardbutton.TabIndex = 3;
            this.lizardbutton.TabStop = true;
            this.lizardbutton.Text = "Lizard";
            this.lizardbutton.UseVisualStyleBackColor = true;
            this.lizardbutton.CheckedChanged += new System.EventHandler(this.lizardbutton_CheckedChanged);
            // 
            // readybtn
            // 
            this.readybtn.Location = new System.Drawing.Point(56, 164);
            this.readybtn.Name = "readybtn";
            this.readybtn.Size = new System.Drawing.Size(75, 23);
            this.readybtn.TabIndex = 2;
            this.readybtn.Text = "Ready!";
            this.readybtn.UseVisualStyleBackColor = true;
            this.readybtn.Click += new System.EventHandler(this.readybtn_Click);
            // 
            // scibutton
            // 
            this.scibutton.AutoSize = true;
            this.scibutton.Location = new System.Drawing.Point(6, 72);
            this.scibutton.Name = "scibutton";
            this.scibutton.Size = new System.Drawing.Size(66, 19);
            this.scibutton.TabIndex = 1;
            this.scibutton.TabStop = true;
            this.scibutton.Text = "Scissors";
            this.scibutton.UseVisualStyleBackColor = true;
            this.scibutton.CheckedChanged += new System.EventHandler(this.scibutton_CheckedChanged);
            // 
            // paperbutton
            // 
            this.paperbutton.AutoSize = true;
            this.paperbutton.Location = new System.Drawing.Point(6, 47);
            this.paperbutton.Name = "paperbutton";
            this.paperbutton.Size = new System.Drawing.Size(55, 19);
            this.paperbutton.TabIndex = 1;
            this.paperbutton.TabStop = true;
            this.paperbutton.Text = "Paper";
            this.paperbutton.UseVisualStyleBackColor = true;
            this.paperbutton.CheckedChanged += new System.EventHandler(this.paperbutton_CheckedChanged);
            // 
            // rockbutton
            // 
            this.rockbutton.AutoSize = true;
            this.rockbutton.Location = new System.Drawing.Point(6, 22);
            this.rockbutton.Name = "rockbutton";
            this.rockbutton.Size = new System.Drawing.Size(51, 19);
            this.rockbutton.TabIndex = 1;
            this.rockbutton.TabStop = true;
            this.rockbutton.Text = "Rock";
            this.rockbutton.UseVisualStyleBackColor = true;
            this.rockbutton.CheckedChanged += new System.EventHandler(this.rockbutton_CheckedChanged);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(286, 83);
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(126, 159);
            this.textbox.TabIndex = 1;
            this.textbox.Text = "";
            this.textbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "RULES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scissors cuts Paper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paper covers Rock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rock crushes Lizard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lizard poisons Spock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Spock smashes Scissors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Scissors decapitates Lizard";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lizard eats Paper";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Paper disproves Spock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Spock vaporizes Rock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "(and as it always has) Rock crushes Scissors";
            // 
            // scorestxt
            // 
            this.scorestxt.Location = new System.Drawing.Point(286, 256);
            this.scorestxt.Name = "scorestxt";
            this.scorestxt.ReadOnly = true;
            this.scorestxt.Size = new System.Drawing.Size(126, 99);
            this.scorestxt.TabIndex = 14;
            this.scorestxt.Tag = "";
            this.scorestxt.Text = "Scores:";
            this.scorestxt.TextChanged += new System.EventHandler(this.scorestxt_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(616, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "THIS GAME IS BEST OUT OF 5";
            // 
            // winbox
            // 
            this.winbox.Location = new System.Drawing.Point(285, 372);
            this.winbox.Name = "winbox";
            this.winbox.ReadOnly = true;
            this.winbox.Size = new System.Drawing.Size(127, 23);
            this.winbox.TabIndex = 17;
            this.winbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.scorestxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gb1;
        private RadioButton scibutton;
        private RadioButton paperbutton;
        private RadioButton rockbutton;
        private RichTextBox textbox;
        private Button readybtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton spockbutton;
        private RadioButton lizardbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox scorestxt;
        private NotifyIcon notifyIcon1;
        private Label label12;
        private RichTextBox winbox;
    }
}