using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace unipi_guide
{
    partial class homepage_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage_form));
            this.homepage_menu = new System.Windows.Forms.MenuStrip();
            this.τοΠανεπιστήμιοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σχολέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.οικονομικώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.κριτικέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σχετικάΜεΕμάςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshow_timer = new System.Windows.Forms.Timer(this.components);
            this.minima_proedrou_richTextBox = new System.Windows.Forms.RichTextBox();
            this.minima_proedrou_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.homepage_title_richTextBox = new System.Windows.Forms.RichTextBox();
            this.slideshow_images = new System.Windows.Forms.ImageList(this.components);
            this.sxoles_homepage_textBox = new System.Windows.Forms.TextBox();
            this.sxoles1_homepage_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sxoles2_homepage_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sxoles3_homepage_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sxoles4_homepage_richTextBox = new System.Windows.Forms.RichTextBox();
            this.sxoles1_homepage_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.slideshow_homepage_image = new System.Windows.Forms.PictureBox();
            this.voice_sound_image = new System.Windows.Forms.PictureBox();
            this.mute_image = new System.Windows.Forms.PictureBox();
            this.homepage_main_image = new System.Windows.Forms.PictureBox();
            this.homepage_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_homepage_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voice_sound_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepage_main_image)).BeginInit();
            this.SuspendLayout();
            // 
            // homepage_menu
            // 
            this.homepage_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.homepage_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.homepage_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.τοΠανεπιστήμιοToolStripMenuItem,
            this.σχολέςToolStripMenuItem,
            this.κριτικέςToolStripMenuItem,
            this.σχετικάΜεΕμάςToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            this.homepage_menu.Location = new System.Drawing.Point(0, 0);
            this.homepage_menu.Name = "homepage_menu";
            this.homepage_menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.homepage_menu.Size = new System.Drawing.Size(994, 24);
            this.homepage_menu.TabIndex = 0;
            this.homepage_menu.Text = "homepage_menu";
            // 
            // τοΠανεπιστήμιοToolStripMenuItem
            // 
            this.τοΠανεπιστήμιοToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.τοΠανεπιστήμιοToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.τοΠανεπιστήμιοToolStripMenuItem.Name = "τοΠανεπιστήμιοToolStripMenuItem";
            this.τοΠανεπιστήμιοToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.τοΠανεπιστήμιοToolStripMenuItem.Text = "Το Πανεπιστήμιο";
            this.τοΠανεπιστήμιοToolStripMenuItem.Click += new System.EventHandler(this.τοΠανεπιστήμιοToolStripMenuItem_Click);
            // 
            // σχολέςToolStripMenuItem
            // 
            this.σχολέςToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.οικονομικώνToolStripMenuItem,
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem,
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem,
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem});
            this.σχολέςToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.σχολέςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.σχολέςToolStripMenuItem.Name = "σχολέςToolStripMenuItem";
            this.σχολέςToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.σχολέςToolStripMenuItem.Text = "Σχολές";
            // 
            // οικονομικώνToolStripMenuItem
            // 
            this.οικονομικώνToolStripMenuItem.Name = "οικονομικώνToolStripMenuItem";
            this.οικονομικώνToolStripMenuItem.Size = new System.Drawing.Size(390, 22);
            this.οικονομικώνToolStripMenuItem.Text = "Οικονομικών, Επιχειρηματικών και Διεθνών Σπουδών ";
            // 
            // ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem
            // 
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem.Name = "ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem";
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem.Size = new System.Drawing.Size(390, 22);
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem.Text = "Ναυτιλίας και Βιομηχανίας";
            // 
            // χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem
            // 
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem.Name = "χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem";
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem.Size = new System.Drawing.Size(390, 22);
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem.Text = "Χρηματοοικονομικής και Στατιστικής";
            // 
            // τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem
            // 
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem.Name = "τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem";
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem.Size = new System.Drawing.Size(390, 22);
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem.Text = "Τεχνολογιών Πληροφορικής και Επικοινωνιών";
            // 
            // κριτικέςToolStripMenuItem
            // 
            this.κριτικέςToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.κριτικέςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.κριτικέςToolStripMenuItem.Name = "κριτικέςToolStripMenuItem";
            this.κριτικέςToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.κριτικέςToolStripMenuItem.Text = "Κριτικές";
            // 
            // σχετικάΜεΕμάςToolStripMenuItem
            // 
            this.σχετικάΜεΕμάςToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.σχετικάΜεΕμάςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.σχετικάΜεΕμάςToolStripMenuItem.Name = "σχετικάΜεΕμάςToolStripMenuItem";
            this.σχετικάΜεΕμάςToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.σχετικάΜεΕμάςToolStripMenuItem.Text = "Σχετικά με εμάς";
            this.σχετικάΜεΕμάςToolStripMenuItem.Click += new System.EventHandler(this.σχετικάΜεΕμάςToolStripMenuItem_Click);
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
            // slideshow_timer
            // 
            this.slideshow_timer.Enabled = true;
            this.slideshow_timer.Interval = 2000;
            this.slideshow_timer.Tick += new System.EventHandler(this.slideshow_timer_Tick);
            // 
            // minima_proedrou_richTextBox
            // 
            this.minima_proedrou_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minima_proedrou_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.minima_proedrou_richTextBox.Location = new System.Drawing.Point(36, 507);
            this.minima_proedrou_richTextBox.Name = "minima_proedrou_richTextBox";
            this.minima_proedrou_richTextBox.Size = new System.Drawing.Size(858, 126);
            this.minima_proedrou_richTextBox.TabIndex = 4;
            this.minima_proedrou_richTextBox.Text = resources.GetString("minima_proedrou_richTextBox.Text");
            // 
            // minima_proedrou_textBox
            // 
            this.minima_proedrou_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minima_proedrou_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.minima_proedrou_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.minima_proedrou_textBox.Location = new System.Drawing.Point(36, 454);
            this.minima_proedrou_textBox.Name = "minima_proedrou_textBox";
            this.minima_proedrou_textBox.Size = new System.Drawing.Size(221, 24);
            this.minima_proedrou_textBox.TabIndex = 5;
            this.minima_proedrou_textBox.Text = "Χαιρετισμός Πρύτανη";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(770, 31);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(124, 28);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Σύνδεση Χρήστη";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // homepage_title_richTextBox
            // 
            this.homepage_title_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepage_title_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.homepage_title_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homepage_title_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.homepage_title_richTextBox.ForeColor = System.Drawing.Color.White;
            this.homepage_title_richTextBox.Location = new System.Drawing.Point(0, 24);
            this.homepage_title_richTextBox.Name = "homepage_title_richTextBox";
            this.homepage_title_richTextBox.Size = new System.Drawing.Size(931, 94);
            this.homepage_title_richTextBox.TabIndex = 9;
            this.homepage_title_richTextBox.Text = "\n\t\t\t\t  Καλωσήρθατε στο Πανεπιστήμιο Πειραιώς";
            // 
            // slideshow_images
            // 
            this.slideshow_images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("slideshow_images.ImageStream")));
            this.slideshow_images.TransparentColor = System.Drawing.Color.Transparent;
            this.slideshow_images.Images.SetKeyName(0, "business_school.png");
            this.slideshow_images.Images.SetKeyName(1, "manufacturing_business_school.png");
            this.slideshow_images.Images.SetKeyName(2, "statistics_school.png");
            this.slideshow_images.Images.SetKeyName(3, "cs_school.png");
            // 
            // sxoles_homepage_textBox
            // 
            this.sxoles_homepage_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sxoles_homepage_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.sxoles_homepage_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.sxoles_homepage_textBox.Location = new System.Drawing.Point(36, 664);
            this.sxoles_homepage_textBox.Name = "sxoles_homepage_textBox";
            this.sxoles_homepage_textBox.Size = new System.Drawing.Size(107, 24);
            this.sxoles_homepage_textBox.TabIndex = 10;
            this.sxoles_homepage_textBox.Text = "Οι Σχολές";
            // 
            // sxoles1_homepage_richTextBox
            // 
            this.sxoles1_homepage_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sxoles1_homepage_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxoles1_homepage_richTextBox.Location = new System.Drawing.Point(335, 711);
            this.sxoles1_homepage_richTextBox.Name = "sxoles1_homepage_richTextBox";
            this.sxoles1_homepage_richTextBox.Size = new System.Drawing.Size(370, 29);
            this.sxoles1_homepage_richTextBox.TabIndex = 12;
            this.sxoles1_homepage_richTextBox.Text = "Οικονομικών, Επιχειρηματικών και Διεθνών Σπουδών";
            // 
            // sxoles2_homepage_richTextBox
            // 
            this.sxoles2_homepage_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sxoles2_homepage_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxoles2_homepage_richTextBox.Location = new System.Drawing.Point(335, 798);
            this.sxoles2_homepage_richTextBox.Name = "sxoles2_homepage_richTextBox";
            this.sxoles2_homepage_richTextBox.Size = new System.Drawing.Size(370, 29);
            this.sxoles2_homepage_richTextBox.TabIndex = 13;
            this.sxoles2_homepage_richTextBox.Text = "Ναυτιλίας και Βιομηχανίας";
            // 
            // sxoles3_homepage_richTextBox
            // 
            this.sxoles3_homepage_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sxoles3_homepage_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxoles3_homepage_richTextBox.Location = new System.Drawing.Point(335, 886);
            this.sxoles3_homepage_richTextBox.Name = "sxoles3_homepage_richTextBox";
            this.sxoles3_homepage_richTextBox.Size = new System.Drawing.Size(370, 29);
            this.sxoles3_homepage_richTextBox.TabIndex = 14;
            this.sxoles3_homepage_richTextBox.Text = "Χρηματοοικονομικής και Στατιστικής";
            // 
            // sxoles4_homepage_richTextBox
            // 
            this.sxoles4_homepage_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sxoles4_homepage_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxoles4_homepage_richTextBox.Location = new System.Drawing.Point(335, 970);
            this.sxoles4_homepage_richTextBox.Name = "sxoles4_homepage_richTextBox";
            this.sxoles4_homepage_richTextBox.Size = new System.Drawing.Size(370, 29);
            this.sxoles4_homepage_richTextBox.TabIndex = 15;
            this.sxoles4_homepage_richTextBox.Text = "Τεχνολογιών Πληροφορικής και Επικοινωνιών";
            // 
            // sxoles1_homepage_button
            // 
            this.sxoles1_homepage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.sxoles1_homepage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sxoles1_homepage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sxoles1_homepage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sxoles1_homepage_button.ForeColor = System.Drawing.Color.White;
            this.sxoles1_homepage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sxoles1_homepage_button.Location = new System.Drawing.Point(335, 743);
            this.sxoles1_homepage_button.Name = "sxoles1_homepage_button";
            this.sxoles1_homepage_button.Size = new System.Drawing.Size(182, 30);
            this.sxoles1_homepage_button.TabIndex = 16;
            this.sxoles1_homepage_button.Text = "Μάθε περισσότερα >>";
            this.sxoles1_homepage_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(335, 829);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Μάθε περισσότερα >>";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(335, 916);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 30);
            this.button2.TabIndex = 18;
            this.button2.Text = "Μάθε περισσότερα >>";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(335, 1001);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "Μάθε περισσότερα >>";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // slideshow_homepage_image
            // 
            this.slideshow_homepage_image.Location = new System.Drawing.Point(36, 711);
            this.slideshow_homepage_image.Name = "slideshow_homepage_image";
            this.slideshow_homepage_image.Size = new System.Drawing.Size(256, 256);
            this.slideshow_homepage_image.TabIndex = 11;
            this.slideshow_homepage_image.TabStop = false;
            // 
            // voice_sound_image
            // 
            this.voice_sound_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voice_sound_image.Image = ((System.Drawing.Image)(resources.GetObject("voice_sound_image.Image")));
            this.voice_sound_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.voice_sound_image.Location = new System.Drawing.Point(252, 454);
            this.voice_sound_image.Name = "voice_sound_image";
            this.voice_sound_image.Size = new System.Drawing.Size(29, 24);
            this.voice_sound_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voice_sound_image.TabIndex = 6;
            this.voice_sound_image.TabStop = false;
            this.voice_sound_image.Click += new System.EventHandler(this.voice_sound_image_Click);
            // 
            // mute_image
            // 
            this.mute_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.mute_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute_image.Image = ((System.Drawing.Image)(resources.GetObject("mute_image.Image")));
            this.mute_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mute_image.Location = new System.Drawing.Point(12, 27);
            this.mute_image.Name = "mute_image";
            this.mute_image.Size = new System.Drawing.Size(32, 26);
            this.mute_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute_image.TabIndex = 3;
            this.mute_image.TabStop = false;
            this.mute_image.Click += new System.EventHandler(this.mute_image_Click);
            // 
            // homepage_main_image
            // 
            this.homepage_main_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homepage_main_image.Image = ((System.Drawing.Image)(resources.GetObject("homepage_main_image.Image")));
            this.homepage_main_image.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.homepage_main_image.Location = new System.Drawing.Point(-11, 118);
            this.homepage_main_image.Margin = new System.Windows.Forms.Padding(0);
            this.homepage_main_image.Name = "homepage_main_image";
            this.homepage_main_image.Size = new System.Drawing.Size(958, 282);
            this.homepage_main_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homepage_main_image.TabIndex = 2;
            this.homepage_main_image.TabStop = false;
            // 
            // homepage_form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 795);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sxoles1_homepage_button);
            this.Controls.Add(this.sxoles4_homepage_richTextBox);
            this.Controls.Add(this.sxoles3_homepage_richTextBox);
            this.Controls.Add(this.sxoles2_homepage_richTextBox);
            this.Controls.Add(this.sxoles1_homepage_richTextBox);
            this.Controls.Add(this.slideshow_homepage_image);
            this.Controls.Add(this.sxoles_homepage_textBox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.voice_sound_image);
            this.Controls.Add(this.minima_proedrou_textBox);
            this.Controls.Add(this.minima_proedrou_richTextBox);
            this.Controls.Add(this.mute_image);
            this.Controls.Add(this.homepage_menu);
            this.Controls.Add(this.homepage_title_richTextBox);
            this.Controls.Add(this.homepage_main_image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.homepage_menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homepage_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πανεπιστήμιο Πειραιώς | Οδηγός";
            this.Load += new System.EventHandler(this.homepage_form_Load);
            this.homepage_menu.ResumeLayout(false);
            this.homepage_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideshow_homepage_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voice_sound_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepage_main_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip homepage_menu;
        private System.Windows.Forms.ToolStripMenuItem τοΠανεπιστήμιοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σχολέςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
        private Timer slideshow_timer;
        private PictureBox mute_image;
        private PictureBox homepage_main_image;
        private ToolStripMenuItem οικονομικώνToolStripMenuItem;
        private ToolStripMenuItem ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem;
        private ToolStripMenuItem χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem;
        private ToolStripMenuItem τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem;
        private ToolStripMenuItem κριτικέςToolStripMenuItem;
        private ToolStripMenuItem σχετικάΜεΕμάςToolStripMenuItem;
        private RichTextBox minima_proedrou_richTextBox;
        private System.Windows.Forms.TextBox minima_proedrou_textBox;
        private PictureBox voice_sound_image;
        private System.Windows.Forms.Button login_button;
        private RichTextBox homepage_title_richTextBox;
        private ImageList slideshow_images;
        private System.Windows.Forms.TextBox sxoles_homepage_textBox;
        private PictureBox slideshow_homepage_image;
        private RichTextBox sxoles1_homepage_richTextBox;
        private RichTextBox sxoles2_homepage_richTextBox;
        private RichTextBox sxoles3_homepage_richTextBox;
        private RichTextBox sxoles4_homepage_richTextBox;
        private System.Windows.Forms.Button sxoles1_homepage_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

