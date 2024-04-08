namespace UdpClientApp
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
            Command = new TextBox();
            Text = new TextBox();
            IpTo = new TextBox();
            SendMessage = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Command
            // 
            Command.Location = new Point(34, 38);
            Command.Name = "Command";
            Command.Size = new Size(100, 23);
            Command.TabIndex = 0;
            // 
            // Text
            // 
            Text.Location = new Point(149, 38);
            Text.Name = "Text";
            Text.Size = new Size(100, 23);
            Text.TabIndex = 1;
            // 
            // IpTo
            // 
            IpTo.Location = new Point(268, 38);
            IpTo.Name = "IpTo";
            IpTo.Size = new Size(100, 23);
            IpTo.TabIndex = 2;
            // 
            // SendMessage
            // 
            SendMessage.Location = new Point(34, 91);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new Size(75, 23);
            SendMessage.TabIndex = 3;
            SendMessage.Text = "Send";
            SendMessage.UseVisualStyleBackColor = true;
            SendMessage.Click += SendMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Command";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 20);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 20);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "IpTo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 159);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SendMessage);
            Controls.Add(IpTo);
            Controls.Add(Text);
            Controls.Add(Command);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Command;
        private TextBox Text;
        private TextBox IpTo;
        private Button SendMessage;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
