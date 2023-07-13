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
            this.πίσωToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τοΠανεπιστήμιοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.οικονομικώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.κριτικέςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σχετικάΜεΕμάςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideshow_timer = new System.Windows.Forms.Timer(this.components);
            this.mute_image = new System.Windows.Forms.PictureBox();
            this.homepage_main_image = new System.Windows.Forms.PictureBox();
            this.minima_proedrou_richTextBox = new System.Windows.Forms.RichTextBox();
            this.minima_proedrou_textBox = new System.Windows.Forms.TextBox();
            this.voice_sound_image = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.homepage_title_richTextBox = new System.Windows.Forms.RichTextBox();
            this.homepage_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepage_main_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voice_sound_image)).BeginInit();
            this.SuspendLayout();
            // 
            // homepage_menu
            // 
            this.homepage_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(66)))));
            this.homepage_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πίσωToolStripMenuItem,
            this.τοΠανεπιστήμιοToolStripMenuItem,
            this.κριτικέςToolStripMenuItem,
            this.σχετικάΜεΕμάςToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            resources.ApplyResources(this.homepage_menu, "homepage_menu");
            this.homepage_menu.Name = "homepage_menu";
            // 
            // πίσωToolStripMenuItem
            // 
            resources.ApplyResources(this.πίσωToolStripMenuItem, "πίσωToolStripMenuItem");
            this.πίσωToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.πίσωToolStripMenuItem.Name = "πίσωToolStripMenuItem";
            // 
            // τοΠανεπιστήμιοToolStripMenuItem
            // 
            this.τοΠανεπιστήμιοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.οικονομικώνToolStripMenuItem,
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem,
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem,
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem});
            resources.ApplyResources(this.τοΠανεπιστήμιοToolStripMenuItem, "τοΠανεπιστήμιοToolStripMenuItem");
            this.τοΠανεπιστήμιοToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.τοΠανεπιστήμιοToolStripMenuItem.Name = "τοΠανεπιστήμιοToolStripMenuItem";
            // 
            // οικονομικώνToolStripMenuItem
            // 
            this.οικονομικώνToolStripMenuItem.Name = "οικονομικώνToolStripMenuItem";
            resources.ApplyResources(this.οικονομικώνToolStripMenuItem, "οικονομικώνToolStripMenuItem");
            // 
            // ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem
            // 
            this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem.Name = "ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem";
            resources.ApplyResources(this.ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem, "ναυτιλίαςΚαιΒιομηχανίαςToolStripMenuItem");
            // 
            // χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem
            // 
            this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem.Name = "χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem";
            resources.ApplyResources(this.χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem, "χρηματοοικονομικήςΚαιΣτατιστικήςToolStripMenuItem");
            // 
            // τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem
            // 
            this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem.Name = "τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem";
            resources.ApplyResources(this.τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem, "τεχνολογιώνΠληροφορικήςΚαιΕπικοινωνιώνToolStripMenuItem");
            // 
            // κριτικέςToolStripMenuItem
            // 
            resources.ApplyResources(this.κριτικέςToolStripMenuItem, "κριτικέςToolStripMenuItem");
            this.κριτικέςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.κριτικέςToolStripMenuItem.Name = "κριτικέςToolStripMenuItem";
            // 
            // σχετικάΜεΕμάςToolStripMenuItem
            // 
            resources.ApplyResources(this.σχετικάΜεΕμάςToolStripMenuItem, "σχετικάΜεΕμάςToolStripMenuItem");
            this.σχετικάΜεΕμάςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.σχετικάΜεΕμάςToolStripMenuItem.Name = "σχετικάΜεΕμάςToolStripMenuItem";
            // 
            // έξοδοςToolStripMenuItem
            // 
            resources.ApplyResources(this.έξοδοςToolStripMenuItem, "έξοδοςToolStripMenuItem");
            this.έξοδοςToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            // 
            // slideshow_timer
            // 
            this.slideshow_timer.Interval = 1000;
            // 
            // mute_image
            // 
            this.mute_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.mute_image.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.mute_image, "mute_image");
            this.mute_image.Name = "mute_image";
            this.mute_image.TabStop = false;
            this.mute_image.Click += new System.EventHandler(this.mute_image_Click);
            // 
            // homepage_main_image
            // 
            resources.ApplyResources(this.homepage_main_image, "homepage_main_image");
            this.homepage_main_image.Name = "homepage_main_image";
            this.homepage_main_image.TabStop = false;
            // 
            // minima_proedrou_richTextBox
            // 
            this.minima_proedrou_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.minima_proedrou_richTextBox, "minima_proedrou_richTextBox");
            this.minima_proedrou_richTextBox.Name = "minima_proedrou_richTextBox";
            // 
            // minima_proedrou_textBox
            // 
            this.minima_proedrou_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.minima_proedrou_textBox, "minima_proedrou_textBox");
            this.minima_proedrou_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.minima_proedrou_textBox.Name = "minima_proedrou_textBox";
            // 
            // voice_sound_image
            // 
            this.voice_sound_image.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.voice_sound_image, "voice_sound_image");
            this.voice_sound_image.Name = "voice_sound_image";
            this.voice_sound_image.TabStop = false;
            this.voice_sound_image.Click += new System.EventHandler(this.voice_sound_image_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.login_button, "login_button");
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Name = "login_button";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // homepage_title_richTextBox
            // 
            resources.ApplyResources(this.homepage_title_richTextBox, "homepage_title_richTextBox");
            this.homepage_title_richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.homepage_title_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homepage_title_richTextBox.ForeColor = System.Drawing.Color.White;
            this.homepage_title_richTextBox.Name = "homepage_title_richTextBox";
            // 
            // homepage_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.voice_sound_image);
            this.Controls.Add(this.minima_proedrou_textBox);
            this.Controls.Add(this.minima_proedrou_richTextBox);
            this.Controls.Add(this.mute_image);
            this.Controls.Add(this.homepage_menu);
            this.Controls.Add(this.homepage_title_richTextBox);
            this.Controls.Add(this.homepage_main_image);
            this.MainMenuStrip = this.homepage_menu;
            this.Name = "homepage_form";
            this.Load += new System.EventHandler(this.homepage_form_Load);
            this.homepage_menu.ResumeLayout(false);
            this.homepage_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homepage_main_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voice_sound_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip homepage_menu;
        private System.Windows.Forms.ToolStripMenuItem πίσωToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem τοΠανεπιστήμιοToolStripMenuItem;
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
    }
}

