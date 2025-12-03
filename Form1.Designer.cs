namespace YemenWhatsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainTabControl = new TabControl();
            chatTabPage = new TabPage();
            mainPanel = new Panel();
            chatPanel = new Panel();
            sendPanel = new Panel();
            inputPanel = new Panel();
            targetUsersComboBox = new ComboBox();
            privateRadioButton = new RadioButton();
            publicRadioButton = new RadioButton();
            sendButton = new Button();
            messageTextBox = new TextBox();
            attachButton = new Button();
            messagesPanel = new Panel();
            chatHeaderPanel = new Panel();
            chatStatusLabel = new Label();
            chatTitleLabel = new Label();
            profilePictureBox = new PictureBox();
            messagesFlowPanel = new FlowLayoutPanel();
            sidePanel = new Panel();
            usersListBox = new ListBox();
            label2 = new Label();
            connectionPanel = new Panel();
            connectButton = new Button();
            usernameTextBox = new TextBox();
            label3 = new Label();
            onlineCountLabel = new Label();
            label1 = new Label();
            topPanel = new Panel();
            statusLabel = new Label();
            appTitleLabel = new Label();
            settingsTabPage = new TabPage();
            groupBox2 = new GroupBox();
            infoLabel = new Label();
            groupBox1 = new GroupBox();
            serverUrlTextBox = new TextBox();
            label4 = new Label();
            mainTabControl.SuspendLayout();
            chatTabPage.SuspendLayout();
            mainPanel.SuspendLayout();
            chatPanel.SuspendLayout();
            sendPanel.SuspendLayout();
            inputPanel.SuspendLayout();
            messagesPanel.SuspendLayout();
            chatHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            sidePanel.SuspendLayout();
            connectionPanel.SuspendLayout();
            topPanel.SuspendLayout();
            settingsTabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(chatTabPage);
            mainTabControl.Controls.Add(settingsTabPage);
            resources.ApplyResources(mainTabControl, "mainTabControl");
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            // 
            // chatTabPage
            // 
            chatTabPage.Controls.Add(mainPanel);
            chatTabPage.Controls.Add(topPanel);
            resources.ApplyResources(chatTabPage, "chatTabPage");
            chatTabPage.Name = "chatTabPage";
            chatTabPage.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(240, 242, 245);
            mainPanel.Controls.Add(chatPanel);
            mainPanel.Controls.Add(sidePanel);
            resources.ApplyResources(mainPanel, "mainPanel");
            mainPanel.Name = "mainPanel";
            // 
            // chatPanel
            // 
            chatPanel.BackColor = Color.White;
            chatPanel.Controls.Add(sendPanel);
            chatPanel.Controls.Add(messagesPanel);
            resources.ApplyResources(chatPanel, "chatPanel");
            chatPanel.Name = "chatPanel";
            // 
            // sendPanel
            // 
            sendPanel.Controls.Add(inputPanel);
            resources.ApplyResources(sendPanel, "sendPanel");
            sendPanel.Name = "sendPanel";
            // 
            // inputPanel
            // 
            inputPanel.Controls.Add(targetUsersComboBox);
            inputPanel.Controls.Add(privateRadioButton);
            inputPanel.Controls.Add(publicRadioButton);
            inputPanel.Controls.Add(sendButton);
            inputPanel.Controls.Add(messageTextBox);
            inputPanel.Controls.Add(attachButton);
            resources.ApplyResources(inputPanel, "inputPanel");
            inputPanel.Name = "inputPanel";
            // 
            // targetUsersComboBox
            // 
            targetUsersComboBox.FormattingEnabled = true;
            resources.ApplyResources(targetUsersComboBox, "targetUsersComboBox");
            targetUsersComboBox.Name = "targetUsersComboBox";
            // 
            // privateRadioButton
            // 
            resources.ApplyResources(privateRadioButton, "privateRadioButton");
            privateRadioButton.Name = "privateRadioButton";
            privateRadioButton.UseVisualStyleBackColor = true;
            privateRadioButton.CheckedChanged += privateRadioButton_CheckedChanged;
            // 
            // publicRadioButton
            // 
            resources.ApplyResources(publicRadioButton, "publicRadioButton");
            publicRadioButton.Checked = true;
            publicRadioButton.Name = "publicRadioButton";
            publicRadioButton.TabStop = true;
            publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.FromArgb(0, 150, 255);
            resources.ApplyResources(sendButton, "sendButton");
            sendButton.ForeColor = Color.White;
            sendButton.Name = "sendButton";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            resources.ApplyResources(messageTextBox, "messageTextBox");
            messageTextBox.Name = "messageTextBox";
            // 
            // attachButton
            // 
            attachButton.BackColor = Color.Transparent;
            resources.ApplyResources(attachButton, "attachButton");
            attachButton.Name = "attachButton";
            attachButton.UseVisualStyleBackColor = false;
            // 
            // messagesPanel
            // 
            resources.ApplyResources(messagesPanel, "messagesPanel");
            messagesPanel.Controls.Add(chatHeaderPanel);
            messagesPanel.Controls.Add(messagesFlowPanel);
            messagesPanel.Name = "messagesPanel";
            // 
            // chatHeaderPanel
            // 
            chatHeaderPanel.BackColor = Color.FromArgb(0, 150, 136);
            chatHeaderPanel.Controls.Add(chatStatusLabel);
            chatHeaderPanel.Controls.Add(chatTitleLabel);
            chatHeaderPanel.Controls.Add(profilePictureBox);
            resources.ApplyResources(chatHeaderPanel, "chatHeaderPanel");
            chatHeaderPanel.Name = "chatHeaderPanel";
            chatHeaderPanel.Paint += chatHeaderPanel_Paint;
            // 
            // chatStatusLabel
            // 
            resources.ApplyResources(chatStatusLabel, "chatStatusLabel");
            chatStatusLabel.ForeColor = Color.FromArgb(220, 255, 220);
            chatStatusLabel.Name = "chatStatusLabel";
            // 
            // chatTitleLabel
            // 
            resources.ApplyResources(chatTitleLabel, "chatTitleLabel");
            chatTitleLabel.ForeColor = Color.White;
            chatTitleLabel.Name = "chatTitleLabel";
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.White;
            resources.ApplyResources(profilePictureBox, "profilePictureBox");
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
            // 
            // messagesFlowPanel
            // 
            resources.ApplyResources(messagesFlowPanel, "messagesFlowPanel");
            messagesFlowPanel.BackColor = Color.White;
            messagesFlowPanel.Name = "messagesFlowPanel";
            messagesFlowPanel.Paint += messagesFlowPanel_Paint;
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(usersListBox);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(connectionPanel);
            resources.ApplyResources(sidePanel, "sidePanel");
            sidePanel.Name = "sidePanel";
            // 
            // usersListBox
            // 
            resources.ApplyResources(usersListBox, "usersListBox");
            usersListBox.FormattingEnabled = true;
            usersListBox.Name = "usersListBox";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.FromArgb(0, 120, 215);
            label2.Name = "label2";
            // 
            // connectionPanel
            // 
            connectionPanel.BackColor = Color.FromArgb(250, 250, 250);
            connectionPanel.BorderStyle = BorderStyle.FixedSingle;
            connectionPanel.Controls.Add(connectButton);
            connectionPanel.Controls.Add(usernameTextBox);
            connectionPanel.Controls.Add(label3);
            connectionPanel.Controls.Add(onlineCountLabel);
            connectionPanel.Controls.Add(label1);
            resources.ApplyResources(connectionPanel, "connectionPanel");
            connectionPanel.Name = "connectionPanel";
            // 
            // connectButton
            // 
            connectButton.BackColor = Color.FromArgb(76, 175, 80);
            resources.ApplyResources(connectButton, "connectButton");
            connectButton.ForeColor = SystemColors.ButtonHighlight;
            connectButton.Name = "connectButton";
            connectButton.UseVisualStyleBackColor = false;
            connectButton.Click += connectButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Green;
            usernameTextBox.ForeColor = Color.White;
            resources.ApplyResources(usernameTextBox, "usernameTextBox");
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // onlineCountLabel
            // 
            resources.ApplyResources(onlineCountLabel, "onlineCountLabel");
            onlineCountLabel.ForeColor = Color.Gray;
            onlineCountLabel.Name = "onlineCountLabel";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 120, 215);
            label1.Name = "label1";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(0, 150, 136);
            topPanel.Controls.Add(statusLabel);
            topPanel.Controls.Add(appTitleLabel);
            resources.ApplyResources(topPanel, "topPanel");
            topPanel.Name = "topPanel";
            topPanel.Paint += topPanel_Paint;
            // 
            // statusLabel
            // 
            resources.ApplyResources(statusLabel, "statusLabel");
            statusLabel.ForeColor = Color.White;
            statusLabel.Name = "statusLabel";
            // 
            // appTitleLabel
            // 
            resources.ApplyResources(appTitleLabel, "appTitleLabel");
            appTitleLabel.ForeColor = Color.White;
            appTitleLabel.Name = "appTitleLabel";
            // 
            // settingsTabPage
            // 
            settingsTabPage.Controls.Add(groupBox2);
            settingsTabPage.Controls.Add(groupBox1);
            resources.ApplyResources(settingsTabPage, "settingsTabPage");
            settingsTabPage.Name = "settingsTabPage";
            settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(infoLabel);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // infoLabel
            // 
            resources.ApplyResources(infoLabel, "infoLabel");
            infoLabel.Name = "infoLabel";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(serverUrlTextBox);
            groupBox1.Controls.Add(label4);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // serverUrlTextBox
            // 
            resources.ApplyResources(serverUrlTextBox, "serverUrlTextBox");
            serverUrlTextBox.Name = "serverUrlTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainTabControl);
            Name = "Form1";
            mainTabControl.ResumeLayout(false);
            chatTabPage.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            chatPanel.ResumeLayout(false);
            sendPanel.ResumeLayout(false);
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            messagesPanel.ResumeLayout(false);
            chatHeaderPanel.ResumeLayout(false);
            chatHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            connectionPanel.ResumeLayout(false);
            connectionPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            settingsTabPage.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage chatTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label onlineCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Panel messagesPanel;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.Panel chatHeaderPanel;
        private System.Windows.Forms.Label chatStatusLabel;
        private System.Windows.Forms.Label chatTitleLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.FlowLayoutPanel messagesFlowPanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.ComboBox targetUsersComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox serverUrlTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

