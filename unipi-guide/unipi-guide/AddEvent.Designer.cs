namespace unipi_guide
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.login_menu = new System.Windows.Forms.MenuStrip();
            this.αρχικήStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.date_richTextBox = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.event_richTextBox = new System.Windows.Forms.RichTextBox();
            this.play_music_image = new System.Windows.Forms.PictureBox();
            this.mute_image = new System.Windows.Forms.PictureBox();
            this.addEvent_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play_music_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).BeginInit();
            this.SuspendLayout();
            // 
            // login_menu
            // 
            this.login_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.login_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.login_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχικήStripMenuItem1,
            this.έξοδοςToolStripMenuItem});
            this.login_menu.Location = new System.Drawing.Point(0, 0);
            this.login_menu.Name = "login_menu";
            this.login_menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.login_menu.Size = new System.Drawing.Size(746, 24);
            this.login_menu.TabIndex = 2;
            this.login_menu.Text = "login_menu";
            // 
            // αρχικήStripMenuItem1
            // 
            this.αρχικήStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.αρχικήStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.αρχικήStripMenuItem1.Name = "αρχικήStripMenuItem1";
            this.αρχικήStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.αρχικήStripMenuItem1.Text = "Αρχική";
            this.αρχικήStripMenuItem1.Click += new System.EventHandler(this.αρχικήStripMenuItem1_Click);
            // 
            // έξοδοςToolStripMenuItem
            // 
            this.έξοδοςToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.έξοδοςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            this.έξοδοςToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.έξοδοςToolStripMenuItem.Text = "Έξοδος";
            this.έξοδοςToolStripMenuItem.Click += new System.EventHandler(this.έξοδοςToolStripMenuItem_Click);
            // 
            // date_richTextBox
            // 
            this.date_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.date_richTextBox.Location = new System.Drawing.Point(18, 119);
            this.date_richTextBox.Name = "date_richTextBox";
            this.date_richTextBox.Size = new System.Drawing.Size(190, 31);
            this.date_richTextBox.TabIndex = 4;
            this.date_richTextBox.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(515, 156);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // event_richTextBox
            // 
            this.event_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.event_richTextBox.ForeColor = System.Drawing.Color.Gray;
            this.event_richTextBox.Location = new System.Drawing.Point(18, 156);
            this.event_richTextBox.Name = "event_richTextBox";
            this.event_richTextBox.Size = new System.Drawing.Size(464, 193);
            this.event_richTextBox.TabIndex = 6;
            this.event_richTextBox.Text = "π.χ. 18:00 - Αναδάσωση της Πάρνηθας";
            this.event_richTextBox.Click += new System.EventHandler(this.event_richTextBox_Click);
            // 
            // play_music_image
            // 
            this.play_music_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.play_music_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_music_image.Image = ((System.Drawing.Image)(resources.GetObject("play_music_image.Image")));
            this.play_music_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.play_music_image.Location = new System.Drawing.Point(696, 34);
            this.play_music_image.Margin = new System.Windows.Forms.Padding(4);
            this.play_music_image.Name = "play_music_image";
            this.play_music_image.Size = new System.Drawing.Size(32, 26);
            this.play_music_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_music_image.TabIndex = 29;
            this.play_music_image.TabStop = false;
            this.play_music_image.Click += new System.EventHandler(this.play_music_image_Click);
            // 
            // mute_image
            // 
            this.mute_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.mute_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute_image.Image = ((System.Drawing.Image)(resources.GetObject("mute_image.Image")));
            this.mute_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mute_image.Location = new System.Drawing.Point(696, 34);
            this.mute_image.Name = "mute_image";
            this.mute_image.Size = new System.Drawing.Size(32, 26);
            this.mute_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute_image.TabIndex = 30;
            this.mute_image.TabStop = false;
            this.mute_image.Click += new System.EventHandler(this.mute_image_Click);
            // 
            // addEvent_button
            // 
            this.addEvent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.addEvent_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEvent_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEvent_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addEvent_button.ForeColor = System.Drawing.Color.White;
            this.addEvent_button.Location = new System.Drawing.Point(560, 321);
            this.addEvent_button.Name = "addEvent_button";
            this.addEvent_button.Size = new System.Drawing.Size(124, 28);
            this.addEvent_button.TabIndex = 31;
            this.addEvent_button.Text = "Προσθήκη";
            this.addEvent_button.UseVisualStyleBackColor = false;
            this.addEvent_button.Click += new System.EventHandler(this.addEvent_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 75);
            this.label1.TabIndex = 32;
            this.label1.Text = "Επιλέξτε μια ημερμηνία στο ημερολόγιο και στην συνέχεια \r\nπροσθέστε την εκδήλωση " +
    "που θέλετε \r\n(με την μορφή  Ώρα - Εκδήλωση):";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(746, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEvent_button);
            this.Controls.Add(this.mute_image);
            this.Controls.Add(this.play_music_image);
            this.Controls.Add(this.event_richTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.date_richTextBox);
            this.Controls.Add(this.login_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEvent";
            this.Text = "Προσθήκη Εκδήλωσης| Πανεπιστήμιο Πειραιώς";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.login_menu.ResumeLayout(false);
            this.login_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play_music_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip login_menu;
        private System.Windows.Forms.ToolStripMenuItem αρχικήStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
        private System.Windows.Forms.RichTextBox date_richTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox event_richTextBox;
        private System.Windows.Forms.PictureBox play_music_image;
        private System.Windows.Forms.PictureBox mute_image;
        private System.Windows.Forms.Button addEvent_button;
        private System.Windows.Forms.Label label1;
    }
}