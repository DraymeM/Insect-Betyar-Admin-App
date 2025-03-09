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
            button1 = new Button();
            termekTorlesButton = new Button();
            termekBoxT = new ComboBox();
            termekModositasButton = new Button();
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
            label2 = new Label();
            kategoriaModositasButton = new Button();
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
            termekButton = new Button();
            KategoriaButton = new Button();
            termekactivepanel = new Panel();
            panel2 = new Panel();
            kategoriaactivepanel = new Panel();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)termekHozPictureBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kategoriaHozPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            termekactivepanel.SuspendLayout();
            kategoriaactivepanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = ImeMode.Off;
            tabControl1.Location = new Point(122, -28);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(508, 530);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(41, 48, 53);
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(termekTorlesButton);
            tabPage1.Controls.Add(termekBoxT);
            tabPage1.Controls.Add(termekModositasButton);
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
            tabPage1.Size = new Size(500, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "+ Termék";
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(-5, -29);
            button1.Name = "button1";
            button1.Size = new Size(110, 30);
            button1.TabIndex = 6;
            button1.Text = "Termék";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // termekTorlesButton
            // 
            termekTorlesButton.BackColor = Color.Maroon;
            termekTorlesButton.BackgroundImageLayout = ImageLayout.Zoom;
            termekTorlesButton.Cursor = Cursors.Hand;
            termekTorlesButton.FlatStyle = FlatStyle.Popup;
            termekTorlesButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekTorlesButton.Image = (Image)resources.GetObject("termekTorlesButton.Image");
            termekTorlesButton.ImageAlign = ContentAlignment.TopCenter;
            termekTorlesButton.Location = new Point(346, 426);
            termekTorlesButton.Name = "termekTorlesButton";
            termekTorlesButton.Size = new Size(109, 51);
            termekTorlesButton.TabIndex = 22;
            termekTorlesButton.Text = "Törlés";
            termekTorlesButton.TextAlign = ContentAlignment.BottomCenter;
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
            termekBoxT.Location = new Point(117, 18);
            termekBoxT.Name = "termekBoxT";
            termekBoxT.Size = new Size(338, 27);
            termekBoxT.TabIndex = 21;
            // 
            // termekModositasButton
            // 
            termekModositasButton.BackColor = Color.Indigo;
            termekModositasButton.Cursor = Cursors.Hand;
            termekModositasButton.FlatStyle = FlatStyle.Popup;
            termekModositasButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekModositasButton.Image = (Image)resources.GetObject("termekModositasButton.Image");
            termekModositasButton.ImageAlign = ContentAlignment.TopCenter;
            termekModositasButton.Location = new Point(116, 426);
            termekModositasButton.Name = "termekModositasButton";
            termekModositasButton.Size = new Size(107, 51);
            termekModositasButton.TabIndex = 20;
            termekModositasButton.Text = "Módosítás";
            termekModositasButton.TextAlign = ContentAlignment.BottomCenter;
            termekModositasButton.UseVisualStyleBackColor = false;
            termekModositasButton.Click += termekModositasButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 13;
            label4.Text = "Termékek";
            // 
            // termekHozPictureBox
            // 
            termekHozPictureBox.Location = new Point(229, 105);
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
            termekMentesButton.Image = (Image)resources.GetObject("termekMentesButton.Image");
            termekMentesButton.ImageAlign = ContentAlignment.TopCenter;
            termekMentesButton.Location = new Point(229, 426);
            termekMentesButton.Name = "termekMentesButton";
            termekMentesButton.Size = new Size(111, 51);
            termekMentesButton.TabIndex = 10;
            termekMentesButton.Text = "Hozzáadás";
            termekMentesButton.TextAlign = ContentAlignment.BottomCenter;
            termekMentesButton.UseVisualStyleBackColor = false;
            termekMentesButton.Click += termekMentesButton_Click;
            // 
            // keptermekfeltButton
            // 
            keptermekfeltButton.BackColor = Color.FromArgb(0, 167, 218);
            keptermekfeltButton.Cursor = Cursors.Hand;
            keptermekfeltButton.FlatStyle = FlatStyle.Popup;
            keptermekfeltButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            keptermekfeltButton.Image = (Image)resources.GetObject("keptermekfeltButton.Image");
            keptermekfeltButton.ImageAlign = ContentAlignment.TopCenter;
            keptermekfeltButton.Location = new Point(116, 105);
            keptermekfeltButton.Name = "keptermekfeltButton";
            keptermekfeltButton.Size = new Size(107, 51);
            keptermekfeltButton.TabIndex = 9;
            keptermekfeltButton.Text = "Kép feltöltés";
            keptermekfeltButton.TextAlign = ContentAlignment.BottomCenter;
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
            kategoriaComboBox.Location = new Point(116, 380);
            kategoriaComboBox.Name = "kategoriaComboBox";
            kategoriaComboBox.Size = new Size(338, 27);
            kategoriaComboBox.TabIndex = 8;
            // 
            // kategoriaLabel
            // 
            kategoriaLabel.AutoSize = true;
            kategoriaLabel.Location = new Point(21, 380);
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
            leirasTexBox.Location = new Point(116, 223);
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
            artextBox.Location = new Point(116, 334);
            artextBox.Name = "artextBox";
            artextBox.Size = new Size(339, 27);
            artextBox.TabIndex = 5;
            // 
            // arLabel
            // 
            arLabel.AutoSize = true;
            arLabel.Location = new Point(82, 336);
            arLabel.Name = "arLabel";
            arLabel.Size = new Size(28, 19);
            arLabel.TabIndex = 4;
            arLabel.Text = "Ár";
            // 
            // leirasLabel
            // 
            leirasLabel.AutoSize = true;
            leirasLabel.Location = new Point(53, 223);
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
            nevtermektextBox.Location = new Point(116, 66);
            nevtermektextBox.Name = "nevtermektextBox";
            nevtermektextBox.Size = new Size(339, 27);
            nevtermektextBox.TabIndex = 1;
            // 
            // NevLabel
            // 
            NevLabel.AutoSize = true;
            NevLabel.Location = new Point(70, 68);
            NevLabel.Name = "NevLabel";
            NevLabel.Size = new Size(40, 19);
            NevLabel.TabIndex = 0;
            NevLabel.Text = "Név";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(41, 48, 53);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(kategoriaModositasButton);
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
            tabPage2.Size = new Size(500, 458);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "+ Kategoria";
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
            // kategoriaModositasButton
            // 
            kategoriaModositasButton.BackColor = Color.Indigo;
            kategoriaModositasButton.Cursor = Cursors.Hand;
            kategoriaModositasButton.FlatStyle = FlatStyle.Popup;
            kategoriaModositasButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kategoriaModositasButton.Image = (Image)resources.GetObject("kategoriaModositasButton.Image");
            kategoriaModositasButton.ImageAlign = ContentAlignment.TopCenter;
            kategoriaModositasButton.Location = new Point(116, 326);
            kategoriaModositasButton.Name = "kategoriaModositasButton";
            kategoriaModositasButton.Size = new Size(110, 48);
            kategoriaModositasButton.TabIndex = 21;
            kategoriaModositasButton.Text = "Módosítás";
            kategoriaModositasButton.TextAlign = ContentAlignment.BottomCenter;
            kategoriaModositasButton.UseVisualStyleBackColor = false;
            kategoriaModositasButton.Click += kategoriaModositasButton_Click;
            // 
            // kategoriaTorlesButton
            // 
            kategoriaTorlesButton.BackColor = Color.Maroon;
            kategoriaTorlesButton.Cursor = Cursors.Hand;
            kategoriaTorlesButton.FlatStyle = FlatStyle.Popup;
            kategoriaTorlesButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kategoriaTorlesButton.Image = (Image)resources.GetObject("kategoriaTorlesButton.Image");
            kategoriaTorlesButton.ImageAlign = ContentAlignment.TopCenter;
            kategoriaTorlesButton.Location = new Point(346, 326);
            kategoriaTorlesButton.Name = "kategoriaTorlesButton";
            kategoriaTorlesButton.Size = new Size(108, 48);
            kategoriaTorlesButton.TabIndex = 17;
            kategoriaTorlesButton.Text = "Törlés";
            kategoriaTorlesButton.TextAlign = ContentAlignment.BottomCenter;
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
            kategoriaHozPictureBox.Location = new Point(234, 141);
            kategoriaHozPictureBox.Name = "kategoriaHozPictureBox";
            kategoriaHozPictureBox.Size = new Size(178, 169);
            kategoriaHozPictureBox.TabIndex = 15;
            kategoriaHozPictureBox.TabStop = false;
            // 
            // kategoriaMentesButton
            // 
            kategoriaMentesButton.BackColor = Color.ForestGreen;
            kategoriaMentesButton.Cursor = Cursors.Hand;
            kategoriaMentesButton.FlatStyle = FlatStyle.Popup;
            kategoriaMentesButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kategoriaMentesButton.Image = (Image)resources.GetObject("kategoriaMentesButton.Image");
            kategoriaMentesButton.ImageAlign = ContentAlignment.TopCenter;
            kategoriaMentesButton.Location = new Point(234, 326);
            kategoriaMentesButton.Name = "kategoriaMentesButton";
            kategoriaMentesButton.Size = new Size(106, 48);
            kategoriaMentesButton.TabIndex = 14;
            kategoriaMentesButton.Text = "Hozzáadás";
            kategoriaMentesButton.TextAlign = ContentAlignment.BottomCenter;
            kategoriaMentesButton.UseVisualStyleBackColor = false;
            kategoriaMentesButton.Click += kategoriaMentesButton_Click;
            // 
            // kepkategoriaFeltoltButton
            // 
            kepkategoriaFeltoltButton.BackColor = Color.FromArgb(0, 167, 218);
            kepkategoriaFeltoltButton.Cursor = Cursors.Hand;
            kepkategoriaFeltoltButton.FlatStyle = FlatStyle.Popup;
            kepkategoriaFeltoltButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kepkategoriaFeltoltButton.Image = (Image)resources.GetObject("kepkategoriaFeltoltButton.Image");
            kepkategoriaFeltoltButton.ImageAlign = ContentAlignment.TopCenter;
            kepkategoriaFeltoltButton.Location = new Point(116, 141);
            kepkategoriaFeltoltButton.Name = "kepkategoriaFeltoltButton";
            kepkategoriaFeltoltButton.Size = new Size(110, 54);
            kepkategoriaFeltoltButton.TabIndex = 13;
            kepkategoriaFeltoltButton.Text = "Kép feltöltés";
            kepkategoriaFeltoltButton.TextAlign = ContentAlignment.BottomCenter;
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
            pictureBox1.Size = new Size(110, 108);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // termekFileButton
            // 
            termekFileButton.BackColor = Color.FromArgb(21, 21, 64);
            termekFileButton.FlatStyle = FlatStyle.Popup;
            termekFileButton.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekFileButton.ForeColor = Color.White;
            termekFileButton.Image = (Image)resources.GetObject("termekFileButton.Image");
            termekFileButton.ImageAlign = ContentAlignment.MiddleLeft;
            termekFileButton.Location = new Point(6, 373);
            termekFileButton.Name = "termekFileButton";
            termekFileButton.Size = new Size(110, 60);
            termekFileButton.TabIndex = 3;
            termekFileButton.Text = "         Termék File";
            termekFileButton.UseVisualStyleBackColor = false;
            termekFileButton.Click += termekFileButton_Click;
            // 
            // KategoriaFileButton
            // 
            KategoriaFileButton.BackColor = Color.FromArgb(21, 21, 64);
            KategoriaFileButton.FlatStyle = FlatStyle.Popup;
            KategoriaFileButton.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            KategoriaFileButton.ForeColor = Color.White;
            KategoriaFileButton.Image = (Image)resources.GetObject("KategoriaFileButton.Image");
            KategoriaFileButton.ImageAlign = ContentAlignment.MiddleLeft;
            KategoriaFileButton.Location = new Point(6, 296);
            KategoriaFileButton.Name = "KategoriaFileButton";
            KategoriaFileButton.Size = new Size(110, 60);
            KategoriaFileButton.TabIndex = 4;
            KategoriaFileButton.Text = "           Kategoria File";
            KategoriaFileButton.UseVisualStyleBackColor = false;
            KategoriaFileButton.Click += KategoriaFileButton_Click;
            // 
            // termekButton
            // 
            termekButton.BackColor = Color.FromArgb(21, 21, 64);
            termekButton.FlatStyle = FlatStyle.Popup;
            termekButton.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            termekButton.ForeColor = Color.White;
            termekButton.Image = (Image)resources.GetObject("termekButton.Image");
            termekButton.ImageAlign = ContentAlignment.MiddleLeft;
            termekButton.Location = new Point(6, 202);
            termekButton.Name = "termekButton";
            termekButton.Size = new Size(110, 60);
            termekButton.TabIndex = 5;
            termekButton.Text = "    Termék";
            termekButton.UseVisualStyleBackColor = false;
            termekButton.Click += termekButton_Click;
            // 
            // KategoriaButton
            // 
            KategoriaButton.BackColor = Color.FromArgb(21, 21, 64);
            KategoriaButton.FlatStyle = FlatStyle.Popup;
            KategoriaButton.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            KategoriaButton.ForeColor = Color.White;
            KategoriaButton.Image = (Image)resources.GetObject("KategoriaButton.Image");
            KategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            KategoriaButton.Location = new Point(6, 126);
            KategoriaButton.Name = "KategoriaButton";
            KategoriaButton.Size = new Size(110, 60);
            KategoriaButton.TabIndex = 6;
            KategoriaButton.Text = "       Kategoria";
            KategoriaButton.UseVisualStyleBackColor = false;
            KategoriaButton.Click += KategoriaButton_Click;
            // 
            // termekactivepanel
            // 
            termekactivepanel.BackColor = Color.DeepSkyBlue;
            termekactivepanel.Controls.Add(panel2);
            termekactivepanel.Location = new Point(110, 202);
            termekactivepanel.Name = "termekactivepanel";
            termekactivepanel.Size = new Size(21, 60);
            termekactivepanel.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(21, 21, 64);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 60);
            panel2.TabIndex = 10;
            // 
            // kategoriaactivepanel
            // 
            kategoriaactivepanel.BackColor = Color.DeepSkyBlue;
            kategoriaactivepanel.Controls.Add(panel1);
            kategoriaactivepanel.Location = new Point(110, 126);
            kategoriaactivepanel.Name = "kategoriaactivepanel";
            kategoriaactivepanel.Size = new Size(21, 60);
            kategoriaactivepanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(21, 21, 64);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(18, 60);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            ClientSize = new Size(622, 488);
            Controls.Add(kategoriaactivepanel);
            Controls.Add(termekactivepanel);
            Controls.Add(KategoriaButton);
            Controls.Add(termekButton);
            Controls.Add(KategoriaFileButton);
            Controls.Add(termekFileButton);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Admin App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)termekHozPictureBox).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kategoriaHozPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            termekactivepanel.ResumeLayout(false);
            kategoriaactivepanel.ResumeLayout(false);
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
        private Button termekModositasButton;
        private Button termekTorlesButton;
        private ComboBox termekBoxT;
        private Button kategoriaTorlesButton;
        private ComboBox kategoriaBoxT;
        private Label label2;
        private Button kategoriaModositasButton;
        private Button button1;
        private Button termekButton;
        private Button KategoriaButton;
        private Panel termekactivepanel;
        private Panel kategoriaactivepanel;
        private Panel panel1;
        private Panel panel2;
    }
}
