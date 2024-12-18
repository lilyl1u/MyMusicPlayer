namespace MyMusicPlayer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new AxWMPLib.AxWindowsMediaPlayer();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            trackBar1 = new TrackBar();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Enabled = true;
            Player.Location = new Point(-2, 0);
            Player.Name = "Player";
            Player.OcxState = (AxHost.State)resources.GetObject("Player.OcxState");
            Player.Size = new Size(684, 182);
            Player.TabIndex = 0;
            Player.Enter += Player_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-2, 149);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 33);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkKhaki;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(12, 194);
            button1.Name = "button1";
            button1.Size = new Size(71, 44);
            button1.TabIndex = 2;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(570, 194);
            button2.Name = "button2";
            button2.Size = new Size(97, 44);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(467, 194);
            button3.Name = "button3";
            button3.Size = new Size(97, 44);
            button3.TabIndex = 4;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(164, 194);
            button4.Name = "button4";
            button4.Size = new Size(72, 44);
            button4.TabIndex = 5;
            button4.Text = "Pause";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSeaGreen;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(89, 194);
            button5.Name = "button5";
            button5.Size = new Size(69, 44);
            button5.TabIndex = 6;
            button5.Text = "Play";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.BackColor = Color.Thistle;
            trackBar1.Location = new Point(133, 149);
            trackBar1.Margin = new Padding(1);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(144, 33);
            trackBar1.TabIndex = 7;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // timer2
            // 
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(679, 250);
            Controls.Add(trackBar1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Player);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Music Player";
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private TrackBar trackBar1;
        private Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}
