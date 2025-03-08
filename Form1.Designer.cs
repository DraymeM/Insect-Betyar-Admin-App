namespace Insect_Betyar_Admin_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            termekTorlesButton = new Button();
            termekBoxT = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            termekHozPictureBox = new PictureBox();
            termekMentesButton = new Button();
            keptermekfeltButton = new Button();
            kategoriaComboBox = new ComboBox();
            kategoriaLabel = new Label();
            leirasTexBox = new RichTextBox();
            artextBox = new TextBox();
            arLabel = new Label();
            leirasLabel = new Label();
            nevtermektextBox = new TextBox();
            NevLabel = new Label();
            tabPage2 = new TabPage();
            kategoriaTorlesButton = new Button();
            kategoriaBoxT = new ComboBox();
            kategoriaHozPictureBox = new PictureBox();
            kategoriaMentesButton = new Button();
            kepkategoriaFeltoltButton = new Button();
            nevkategoriaTextBox = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            termekFileButton = new Button();
            KategoriaFileButton = new Button();
            button1 = new Button();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)termekHozPictureBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kategoriaHozPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tabControl1.ImeMode = ImeMode.Off;
            tabControl1.Location = new Point(122, 12);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(508, 525);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(41, 48, 53);
            tabPage1.Controls.Add(termekTorlesButton);
            tabPage1.Controls.Add(termekBoxT);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(termekHozPictureBox);
            tabPage1.Controls.Add(termekMentesButton);
            tabPage1.Controls.Add(keptermekfeltButton);
            tabPage1.Controls.Add(kategoriaComboBox);
            tabPage1.Controls.Add(kategoriaLabel);
            tabPage1.Controls.Add(leirasTexBox);
            tabPage1.Controls.Add(artextBox);
            tabPage1.Controls.Add(arLabel);
            tabPage1.Controls.Add(leirasLabel);
            tabPage1.Controls.Add(nevtermektextBox);
            tabPage1.Controls.Add(NevLabel);
            tabPage1.ForeColor = SystemColors.ButtonHighlight;
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(500, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "+ Termék";
            // 
            // termekTorlesButton
            // 
            termekTorlesButton.BackColor = Color.Maroon;
            termekTorlesButton.Cursor = Cursors.Hand;
            termekTorlesButton.FlatStyle = FlatStyle.Popup;
            termekTorlesButton.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekTorlesButton.Location = new Point(358, 436);
            termekTorlesButton.Name = "termekTorlesButton";
            termekTorlesButton.Size = new Size(98, 38);
            termekTorlesButton.TabIndex = 22;
            termekTorlesButton.Text = "Termék törlése";
            termekTorlesButton.UseVisualStyleBackColor = false;
            termekTorlesButton.Click += termekTorlesButton_Click;
            // 
            // termekBoxT
            // 
            termekBoxT.BackColor = Color.FromArgb(33, 34, 36);
            termekBoxT.Cursor = Cursors.Hand;
            termekBoxT.DropDownStyle = ComboBoxStyle.DropDownList;
            termekBoxT.FlatStyle = FlatStyle.Flat;
            termekBoxT.ForeColor = SystemColors.Menu;
            termekBoxT.FormattingEnabled = true;
            termekBoxT.Location = new Point(118, 28);
            termekBoxT.Name = "termekBoxT";
            termekBoxT.Size = new Size(338, 27);
            termekBoxT.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.Location = new Point(232, 436);
            button2.Name = "button2";
            button2.Size = new Size(111, 38);
            button2.TabIndex = 20;
            button2.Text = "Termék módosítása";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 28);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 13;
            label4.Text = "Termékek";
            // 
            // termekHozPictureBox
            // 
            termekHozPictureBox.Location = new Point(322, 115);
            termekHozPictureBox.Name = "termekHozPictureBox";
            termekHozPictureBox.Size = new Size(134, 108);
            termekHozPictureBox.TabIndex = 11;
            termekHozPictureBox.TabStop = false;
            // 
            // termekMentesButton
            // 
            termekMentesButton.BackColor = Color.ForestGreen;
            termekMentesButton.Cursor = Cursors.Hand;
            termekMentesButton.FlatStyle = FlatStyle.Popup;
            termekMentesButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekMentesButton.Location = new Point(118, 436);
            termekMentesButton.Name = "termekMentesButton";
            termekMentesButton.Size = new Size(98, 38);
            termekMentesButton.TabIndex = 10;
            termekMentesButton.Text = "Termék hozzáadása";
            termekMentesButton.UseVisualStyleBackColor = false;
            termekMentesButton.Click += termekMentesButton_Click;
            // 
            // keptermekfeltButton
            // 
            keptermekfeltButton.BackColor = Color.FromArgb(0, 167, 218);
            keptermekfeltButton.Cursor = Cursors.Hand;
            keptermekfeltButton.FlatStyle = FlatStyle.Popup;
            keptermekfeltButton.Location = new Point(118, 115);
            keptermekfeltButton.Name = "keptermekfeltButton";
            keptermekfeltButton.Size = new Size(175, 38);
            keptermekfeltButton.TabIndex = 9;
            keptermekfeltButton.Text = "Kép feltöltés";
            keptermekfeltButton.UseVisualStyleBackColor = false;
            keptermekfeltButton.Click += keptermekfeltButton_Click;
            // 
            // kategoriaComboBox
            // 
            kategoriaComboBox.BackColor = Color.FromArgb(33, 34, 36);
            kategoriaComboBox.Cursor = Cursors.Hand;
            kategoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriaComboBox.FlatStyle = FlatStyle.Flat;
            kategoriaComboBox.ForeColor = SystemColors.Menu;
            kategoriaComboBox.FormattingEnabled = true;
            kategoriaComboBox.Location = new Point(117, 390);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new Size(338, 27);
            kategoriaComboBox.TabIndex = 8;
            // 
            // kategoriaLabel
            // 
            kategoriaLabel.AutoSize = true;
            kategoriaLabel.Location = new Point(22, 390);
            kategoriaLabel.Name = "kategoriaLabel";
            kategoriaLabel.Size = new Size(89, 19);
            kategoriaLabel.TabIndex = 7;
            kategoriaLabel.Text = "Kategória";
            // 
            // leirasTexBox
            // 
            leirasTexBox.BackColor = Color.FromArgb(33, 34, 36);
            leirasTexBox.BorderStyle = BorderStyle.FixedSingle;
            leirasTexBox.ForeColor = SystemColors.Window;
            leirasTexBox.Location = new Point(117, 233);
            leirasTexBox.Name = "leirasTexBox";
            leirasTexBox.Size = new Size(339, 96);
            leirasTexBox.TabIndex = 6;
            leirasTexBox.Text = "";
            // 
            // artextBox
            // 
            artextBox.BackColor = Color.FromArgb(33, 34, 36);
            artextBox.BorderStyle = BorderStyle.FixedSingle;
            artextBox.ForeColor = SystemColors.Menu;
            artextBox.Location = new Point(117, 344);
            artextBox.Name = "artextBox";
            artextBox.Size = new Size(339, 27);
            artextBox.TabIndex = 5;
            // 
            // arLabel
            // 
            arLabel.AutoSize = true;
            arLabel.Location = new Point(83, 346);
            arLabel.Name = "arLabel";
            arLabel.Size = new Size(28, 19);
            arLabel.TabIndex = 4;
            arLabel.Text = "Ár";
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Location = new Point(54, 233);
            leirasLabel.Name = "leirasLabel";
            leirasLabel.Size = new Size(58, 19);
            leirasLabel.TabIndex = 2;
            leirasLabel.Text = "Leírás";
            // 
            // nevtermektextBox
            // 
            nevtermektextBox.BackColor = Color.FromArgb(33, 34, 36);
            nevtermektextBox.BorderStyle = BorderStyle.FixedSingle;
            nevtermektextBox.ForeColor = SystemColors.Menu;
            nevtermektextBox.Location = new Point(117, 76);
            nevtermektextBox.Name = "nevtermektextBox";
            nevtermektextBox.Size = new Size(339, 27);
            nevtermektextBox.TabIndex = 1;
            // 
            // NevLabel
            // 
            NevLabel.AutoSize = true;
            NevLabel.Location = new Point(71, 78);
            NevLabel.Name = "NevLabel";
            NevLabel.Size = new Size(40, 19);
            NevLabel.TabIndex = 0;
            NevLabel.Text = "Név";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(41, 48, 53);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(kategoriaTorlesButton);
            tabPage2.Controls.Add(kategoriaBoxT);
            tabPage2.Controls.Add(kategoriaHozPictureBox);
            tabPage2.Controls.Add(kategoriaMentesButton);
            tabPage2.Controls.Add(kepkategoriaFeltoltButton);
            tabPage2.Controls.Add(nevkategoriaTextBox);
            tabPage2.Controls.Add(label1);
            tabPage2.ForeColor = SystemColors.Menu;
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(597, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "+ Kategoria";
            // 
            // kategoriaTorlesButton
            // 
            kategoriaTorlesButton.BackColor = Color.Maroon;
            kategoriaTorlesButton.Cursor = Cursors.Hand;
            kategoriaTorlesButton.FlatStyle = FlatStyle.Popup;
            kategoriaTorlesButton.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kategoriaTorlesButton.Location = new Point(357, 273);
            kategoriaTorlesButton.Name = "kategoriaTorlesButton";
            kategoriaTorlesButton.Size = new Size(98, 38);
            kategoriaTorlesButton.TabIndex = 17;
            kategoriaTorlesButton.Text = "Kategoria törlése";
            kategoriaTorlesButton.UseVisualStyleBackColor = false;
            kategoriaTorlesButton.Click += kategoriaTorlesButton_Click;
            // 
            // kategoriaBoxT
            // 
            kategoriaBoxT.BackColor = Color.FromArgb(33, 34, 36);
            kategoriaBoxT.Cursor = Cursors.Hand;
            kategoriaBoxT.DropDownStyle = ComboBoxStyle.DropDownList;
            kategoriaBoxT.FlatStyle = FlatStyle.Flat;
            kategoriaBoxT.ForeColor = SystemColors.Menu;
            kategoriaBoxT.FormattingEnabled = true;
            kategoriaBoxT.Location = new Point(116, 52);
            kategoriaBoxT.Name = "kategoriaBoxT";
            kategoriaBoxT.Size = new Size(338, 27);
            kategoriaBoxT.TabIndex = 16;
            // 
            // kategoriaHozPictureBox
            // 
            kategoriaHozPictureBox.Location = new Point(321, 141);
            kategoriaHozPictureBox.Name = "kategoriaHozPictureBox";
            kategoriaHozPictureBox.Size = new Size(134, 108);
            kategoriaHozPictureBox.TabIndex = 15;
            kategoriaHozPictureBox.TabStop = false;
            // 
            // kategoriaMentesButton
            // 
            kategoriaMentesButton.BackColor = Color.ForestGreen;
            kategoriaMentesButton.Cursor = Cursors.Hand;
            kategoriaMentesButton.FlatStyle = FlatStyle.Popup;
            kategoriaMentesButton.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kategoriaMentesButton.Location = new Point(116, 273);
            kategoriaMentesButton.Name = "kategoriaMentesButton";
            kategoriaMentesButton.Size = new Size(98, 38);
            kategoriaMentesButton.TabIndex = 14;
            kategoriaMentesButton.Text = "Kategoria mentése";
            kategoriaMentesButton.UseVisualStyleBackColor = false;
            kategoriaMentesButton.Click += kategoriaMentesButton_Click;
            // 
            // kepkategoriaFeltoltButton
            // 
            kepkategoriaFeltoltButton.BackColor = Color.FromArgb(0, 167, 218);
            kepkategoriaFeltoltButton.Cursor = Cursors.Hand;
            kepkategoriaFeltoltButton.FlatStyle = FlatStyle.Popup;
            kepkategoriaFeltoltButton.Location = new Point(116, 144);
            kepkategoriaFeltoltButton.Name = "kepkategoriaFeltoltButton";
            kepkategoriaFeltoltButton.Size = new Size(175, 38);
            kepkategoriaFeltoltButton.TabIndex = 13;
            kepkategoriaFeltoltButton.Text = "Kép feltöltés";
            kepkategoriaFeltoltButton.UseVisualStyleBackColor = false;
            kepkategoriaFeltoltButton.Click += kepkategoriaFeltoltButton_Click;
            // 
            // nevkategoriaTextBox
            // 
            nevkategoriaTextBox.BackColor = Color.FromArgb(33, 34, 36);
            nevkategoriaTextBox.BorderStyle = BorderStyle.FixedSingle;
            nevkategoriaTextBox.ForeColor = SystemColors.Menu;
            nevkategoriaTextBox.Location = new Point(116, 100);
            nevkategoriaTextBox.Name = "nevkategoriaTextBox";
            nevkategoriaTextBox.Size = new Size(339, 27);
            nevkategoriaTextBox.TabIndex = 12;
            nevkategoriaTextBox.TextChanged += nevkategoriaTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 102);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 11;
            label1.Text = "Név";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 107);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // termekFileButton
            // 
            termekFileButton.BackColor = Color.FromArgb(43, 42, 51);
            termekFileButton.FlatStyle = FlatStyle.Popup;
            termekFileButton.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekFileButton.ForeColor = Color.White;
            termekFileButton.Location = new Point(6, 151);
            termekFileButton.Name = "termekFileButton";
            termekFileButton.Size = new Size(110, 71);
            termekFileButton.TabIndex = 3;
            termekFileButton.Text = "Termék File";
            termekFileButton.UseVisualStyleBackColor = false;
            termekFileButton.Click += termekFileButton_Click;
            // 
            // KategoriaFileButton
            // 
            KategoriaFileButton.BackColor = Color.FromArgb(43, 42, 51);
            KategoriaFileButton.FlatStyle = FlatStyle.Popup;
            KategoriaFileButton.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            KategoriaFileButton.ForeColor = Color.White;
            KategoriaFileButton.Location = new Point(6, 251);
            KategoriaFileButton.Name = "KategoriaFileButton";
            KategoriaFileButton.Size = new Size(110, 71);
            KategoriaFileButton.TabIndex = 4;
            KategoriaFileButton.Text = "Kategoria File";
            KategoriaFileButton.UseVisualStyleBackColor = false;
            KategoriaFileButton.Click += KategoriaFileButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(238, 273);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 21;
            button1.Text = "Kategoria módosítása";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 22;
            label2.Text = "Kategoriák";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            ClientSize = new Size(646, 549);
            Controls.Add(KategoriaFileButton);
            Controls.Add(termekFileButton);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)termekHozPictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kategoriaHozPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Button termekFileButton;
        private Button KategoriaFileButton;
        private TextBox nevtermektextBox;
        private Label NevLabel;
        private Label leirasLabel;
        private RichTextBox leirasTexBox;
        private TextBox artextBox;
        private Label arLabel;
        private Label kategoriaLabel;
        private ComboBox kategoriaComboBox;
        private Button termekMentesButton;
        private Button keptermekfeltButton;
        private Button kategoriaMentesButton;
        private Button kepkategoriaFeltoltButton;
        private TextBox nevkategoriaTextBox;
        private Label label1;
        private PictureBox termekHozPictureBox;
        private PictureBox kategoriaHozPictureBox;
        private Label label4;
        private Button button2;
        private Button termekTorlesButton;
        private ComboBox termekBoxT;
        private Button kategoriaTorlesButton;
        private ComboBox kategoriaBoxT;
        private Label label2;
        private Button button1;
    }
}
