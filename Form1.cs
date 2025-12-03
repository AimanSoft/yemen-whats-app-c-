using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace YemenWhatsApp
{
    public partial class Form1 : Form
    {
        // قائمة المستخدمين التجريبية
        private List<string> onlineUsers = new List<string> { "أحمد", "محمد", "سارة", "خالد" };
        private string currentUser = "";
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // إعداد الحالة الأولية
            statusLabel.Text = " غير متصل";
            chatStatusLabel.Text = " اتصال فوري";
            appTitleLabel.Text = "🇾🇪 Yemen WhatsApp";
            chatTitleLabel.Text = "Yemen Chat Group";
            onlineCountLabel.Text = "0 متصل";

            // تعطيل الأزرار حتى الاتصال
            sendButton.Enabled = false;
            messageTextBox.Enabled = false;
            attachButton.Enabled = false;

            // إعداد ألوان الحقول
            usernameTextBox.BackColor = Color.FromArgb(220, 255, 220);
            messageTextBox.BackColor = Color.White;
            serverUrlTextBox.BackColor = Color.White;

            // إعداد القوائم المنسدلة
            InitializeComboBoxes();

            // إضافة بعض المستخدمين التجريبيين
            LoadSampleUsers();

            // معلومات التطبيق
            infoLabel.Text = @"Yemen WhatsApp Desktop
الإصدار: 1.0.0

مميزات التطبيق:
• دردشة فورية عامة وخاصة
• واجهة مشابهة للواتساب
• قاعدة بيانات SQL Server
• متعدد المستخدمين
برمجة :ايمن عبدالوهاب الصالحي";
        }

        private void InitializeComboBoxes()
        {
            targetUsersComboBox.Items.Clear();
            foreach (var user in onlineUsers)
            {
                targetUsersComboBox.Items.Add(user);
            }

            if (targetUsersComboBox.Items.Count > 0)
                targetUsersComboBox.SelectedIndex = 0;
        }

        private void LoadSampleUsers()
        {
            usersListBox.Items.Clear();
            usersListBox.Items.Add(" أحمد (متصل)");
            usersListBox.Items.Add(" محمد (متصل)");
            usersListBox.Items.Add(" سارة (غير متصل)");
            usersListBox.Items.Add(" خالد (متصل)");
            usersListBox.Items.Add(" فاطمة (غير متصل)");

            onlineCountLabel.Text = "3 متصل";
        }

        // ============= أحداث الأزرار الرئيسية =============

        private void connectButton_Click(object sender, EventArgs e)
        {
            currentUser = usernameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(currentUser) || currentUser.Length < 3)
            {
                MessageBox.Show("الرجاء إدخال اسم مستخدم صالح (3 أحرف على الأقل)",
                    "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isConnected)
            {
                // عملية الاتصال
                isConnected = true;
                statusLabel.Text = " متصل";
                chatStatusLabel.Text = " متصل بالخادم";
                connectButton.Text = "❌ قطع الاتصال";
                sendButton.Enabled = true;
                messageTextBox.Enabled = true;
                attachButton.Enabled = true;
                usernameTextBox.Enabled = false;

                // رسالة ترحيبية
                AddSystemMessage($" تم الاتصال بنجاح كـ {currentUser}");
                AddSystemMessage(" يمكنك الآن البدء في الدردشة!");

                // تحديث قائمة المستخدمين
                usersListBox.Items.Insert(0, $" {currentUser} (أنت)");
                onlineCountLabel.Text = "4 متصل";

                // إضافة المستخدم الجديد للقائمة المنسدلة (للمستخدمين الآخرين)
                if (!targetUsersComboBox.Items.Contains(currentUser))
                {
                    targetUsersComboBox.Items.Add(currentUser);
                }
            }
            else
            {
                // عملية قطع الاتصال
                isConnected = false;
                statusLabel.Text = " غير متصل";
                chatStatusLabel.Text = " غير متصل";
                connectButton.Text = " الاتصال";
                sendButton.Enabled = false;
                messageTextBox.Enabled = false;
                attachButton.Enabled = false;
                usernameTextBox.Enabled = true;

                AddSystemMessage("تم قطع الاتصال بالخادم");

                // إزالة المستخدم من القائمة
                for (int i = 0; i < usersListBox.Items.Count; i++)
                {
                    if (usersListBox.Items[i].ToString().Contains(currentUser))
                    {
                        usersListBox.Items.RemoveAt(i);
                        break;
                    }
                }
                onlineCountLabel.Text = "3 متصل";
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "إرسال ملف",
                Filter = "جميع الملفات (*.*)|*.*|صور (*.jpg;*.png)|*.jpg;*.png|مستندات (*.pdf;*.docx)|*.pdf;*.docx"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = System.IO.Path.GetFileName(dialog.FileName);
                AddSystemMessage($"📎 جاري إرسال الملف: {fileName}");
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"👤 الملف الشخصي\n\nالاسم: {currentUser}\nالحالة: {(isConnected ? "🟢 متصل" : " غير متصل")}",
                "الملف الشخصي", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============= إدارة الرسائل =============

        private void SendMessage()
        {
            if (!isConnected || string.IsNullOrWhiteSpace(messageTextBox.Text))
                return;

            string message = messageTextBox.Text.Trim();
            bool isPrivate = privateRadioButton.Checked;
            string targetUser = isPrivate ? targetUsersComboBox.SelectedItem?.ToString() : "الجميع";

            // التحقق في الدردشة الخاصة
            if (isPrivate && string.IsNullOrEmpty(targetUser))
            {
                MessageBox.Show("الرجاء اختيار مستخدم للدردشة الخاصة",
                    "دردشة خاصة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // عرض الرسالة
            AddChatMessage(currentUser, message, DateTime.Now, true, isPrivate);

            // محاكاة استجابة من مستخدم آخر (للاختبار)
            if (!isPrivate)
            {
                // رد تلقائي بعد ثانيتين
                Timer responseTimer = new Timer { Interval = 2000 };
                responseTimer.Tick += (s, ev) =>
                {
                    string[] responses = { "مرحباً!", "كيف الحال؟", "أهلاً وسهلاً", "شكراً لك" };
                    string randomResponse = responses[new Random().Next(responses.Length)];

                    this.Invoke(new Action(() =>
                    {
                        AddChatMessage("أحمد", randomResponse, DateTime.Now, false, false);
                    }));

                    ((Timer)s).Stop();
                    ((Timer)s).Dispose();
                };
                responseTimer.Start();
            }

            // مسح حقل النص
            messageTextBox.Clear();
            messageTextBox.Focus();
        }

        private void AddChatMessage(string sender, string message, DateTime time, bool isMe, bool isPrivate)
        {
            // إنشاء حاوية الرسالة
            Panel container = new Panel
            {
                Margin = new Padding(10, 8, 10, 8),
                Width = messagesFlowPanel.ClientSize.Width - 30,
                BackColor = Color.Transparent
            };

            // فقاعة الرسالة
            Panel bubble = new Panel
            {
                MaximumSize = new Size(500, 0),
                AutoSize = true,
                Padding = new Padding(15, 12, 15, 35)
            };

            // تحديد لون الفقاعة
            if (isMe)
            {
                bubble.BackColor = Color.FromArgb(220, 248, 198); // لون فاتح أخضر
            }
            else if (isPrivate)
            {
                bubble.BackColor = Color.FromArgb(255, 245, 220); // لون بيج فاتح
            }
            else
            {
                bubble.BackColor = Color.White;
            }

            // نص الرسالة
            Label lblText = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                AutoSize = true,
                MaximumSize = new Size(450, 0)
            };

            // وقت الرسالة
            Label lblTime = new Label
            {
                Text = time.ToString("hh:mm tt"),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                AutoSize = true
            };

            // حساب المواقع
            bubble.Controls.Add(lblText);
            lblTime.Location = new Point(15, lblText.Height + 5);
            bubble.Controls.Add(lblTime);

            bubble.Height = lblText.Height + 40;
            bubble.Width = Math.Min(lblText.Width + 30, 500);

            // تحديد موقع الفقاعة
            if (isMe)
            {
                container.Dock = DockStyle.Right;
                bubble.Location = new Point(container.Width - bubble.Width - 10, 0);

                // إضافة علامة تسليم صغيرة
                Label lblDelivered = new Label
                {
                    Text = "✓✓",
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    AutoSize = true
                };
                lblDelivered.Location = new Point(bubble.Width - 25, lblText.Height + 7);
                bubble.Controls.Add(lblDelivered);
            }
            else
            {
                container.Dock = DockStyle.Left;
                bubble.Location = new Point(10, 0);

                // إضافة اسم المرسل للرسائل الخاصة
                if (isPrivate)
                {
                    Label lblSender = new Label
                    {
                        Text = $"{sender} ↙",
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        ForeColor = Color.FromArgb(0, 120, 215),
                        AutoSize = true
                    };
                    lblSender.Location = new Point(15, -18);
                    container.Controls.Add(lblSender);
                    container.Height = bubble.Height + 20;
                }
            }

            // إضافة حواف مستديرة (رسم يدوي)
            bubble.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, bubble.Width - 1, bubble.Height - 1), 15, bubble.BackColor);
            };

            container.Controls.Add(bubble);
            if (!isPrivate) container.Height = bubble.Height;

            messagesFlowPanel.Controls.Add(container);
            ScrollToBottom();
        }

        private void AddSystemMessage(string message)
        {
            Label lbl = new Label
            {
                Text = $"• {message} •",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                BackColor = Color.FromArgb(245, 245, 245),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0, 10, 0, 10),
                Dock = DockStyle.Top
            };

            messagesFlowPanel.Controls.Add(lbl);
            ScrollToBottom();
        }

        // ============= دوال الرسم المساعدة =============

        private void DrawRoundedRectangle(Graphics g, Rectangle bounds, int radius, Color fillColor)
        {
            using (SolidBrush brush = new SolidBrush(fillColor))
            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200), 1))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }
        }

        private void ScrollToBottom()
        {
            if (messagesFlowPanel.Controls.Count > 0)
            {
                messagesFlowPanel.ScrollControlIntoView(
                    messagesFlowPanel.Controls[messagesFlowPanel.Controls.Count - 1]);
            }
        }

        // ============= أحداث التحكمات =============

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // التحقق من صحة اسم المستخدم
            if (usernameTextBox.Text.Length >= 3)
            {
                usernameTextBox.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                usernameTextBox.BackColor = Color.FromArgb(255, 220, 220);
            }
        }

        private void messageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // إرسال الرسالة عند الضغط على Enter (بدون Shift)
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                if (Control.ModifierKeys != Keys.Shift)
                {
                    SendMessage();
                    e.Handled = true;
                }
            }
        }

        private void privateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // إظهار/إخفاء قائمة المستخدمين المستهدفين
            targetUsersComboBox.Visible = privateRadioButton.Checked;

            // تحديث عنوان الدردشة
            if (privateRadioButton.Checked && targetUsersComboBox.SelectedItem != null)
            {
                chatTitleLabel.Text = $"الدردشة مع {targetUsersComboBox.SelectedItem}";
            }
            else
            {
                chatTitleLabel.Text = "Yemen Chat Group";
            }
        }

        private void targetUsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (privateRadioButton.Checked && targetUsersComboBox.SelectedItem != null)
            {
                chatTitleLabel.Text = $"الدردشة مع {targetUsersComboBox.SelectedItem}";
            }
        }

        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersListBox.SelectedItem != null)
            {
                string selectedUser = usersListBox.SelectedItem.ToString()
                    .Replace("🟢 ", "")
                    .Replace("⚫ ", "")
                    .Split('(')[0].Trim();

                // تحويل للدردشة الخاصة مع المستخدم المحدد
                if (selectedUser != currentUser && !selectedUser.Contains("أنت"))
                {
                    privateRadioButton.Checked = true;

                    if (targetUsersComboBox.Items.Contains(selectedUser))
                    {
                        targetUsersComboBox.SelectedItem = selectedUser;
                    }
                }
            }
        }

        // ============= أحداث الرسم للوحات =============

        private void messagesFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            // خلفية فاتحة لمنطقة الرسائل
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(240, 245, 240)))
            {
                e.Graphics.FillRectangle(brush, messagesFlowPanel.ClientRectangle);
            }
        }

        private void chatHeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            // خلفية متدرجة لرأس الدردشة
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 150, 136)))
            {
                e.Graphics.FillRectangle(brush, chatHeaderPanel.ClientRectangle);
            }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            // خلفية متدرجة للوحة العلوية
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 150, 136)))
            {
                e.Graphics.FillRectangle(brush, topPanel.ClientRectangle);
            }
        }

        // ============= أحداث الإعدادات =============

        private void serverUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            // التحقق من صحة عنوان URL
            if (IsValidUrl(serverUrlTextBox.Text))
            {
                serverUrlTextBox.BackColor = Color.FromArgb(220, 255, 220);
            }
            else
            {
                serverUrlTextBox.BackColor = Color.FromArgb(255, 220, 220);
            }
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        // ============= دالة لرسم صورة الملف الشخصي =============

        private void profilePictureBox_Paint(object sender, PaintEventArgs e)
        {
            // رسم صورة مستديرة
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // خلفية دائرية
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 120, 215)))
            {
                e.Graphics.FillEllipse(brush, 0, 0, 44, 44);
            }

            // أيقونة المستخدم
            e.Graphics.DrawString("👤", new Font("Segoe UI", 16), Brushes.White, 8, 5);

            // حد دائري
            using (Pen pen = new Pen(Color.White, 2))
            {
                e.Graphics.DrawEllipse(pen, 1, 1, 42, 42);
            }
        }

        
    }
}
