namespace ObjectEditor
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.lblShowCharacter = new System.Windows.Forms.Label();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbColorID = new System.Windows.Forms.TextBox();
            this.cbColliding = new System.Windows.Forms.CheckBox();
            this.cbInteractive = new System.Windows.Forms.CheckBox();
            this.cmbDisplayColor = new System.Windows.Forms.ComboBox();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblDispCol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveObject = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnResetWindow = new System.Windows.Forms.Button();
            this.cmbPrvCol = new System.Windows.Forms.ComboBox();
            this.lbl_PrevBG = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 20;
            this.listBoxItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(150, 244);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // lblShowCharacter
            // 
            this.lblShowCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowCharacter.Font = new System.Drawing.Font("MxPlus IBM BIOS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowCharacter.Location = new System.Drawing.Point(3, 23);
            this.lblShowCharacter.Name = "lblShowCharacter";
            this.lblShowCharacter.Size = new System.Drawing.Size(164, 133);
            this.lblShowCharacter.TabIndex = 1;
            this.lblShowCharacter.Text = "☻";
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(322, 32);
            this.tbChar.MaxLength = 1;
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(36, 27);
            this.tbChar.TabIndex = 2;
            this.tbChar.TextChanged += new System.EventHandler(this.tbChar_TextChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(322, 65);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(163, 27);
            this.tbDescription.TabIndex = 3;
            // 
            // tbColorID
            // 
            this.tbColorID.Location = new System.Drawing.Point(322, 98);
            this.tbColorID.MaxLength = 7;
            this.tbColorID.Name = "tbColorID";
            this.tbColorID.Size = new System.Drawing.Size(163, 27);
            this.tbColorID.TabIndex = 4;
            // 
            // cbColliding
            // 
            this.cbColliding.AutoSize = true;
            this.cbColliding.Location = new System.Drawing.Point(204, 185);
            this.cbColliding.Name = "cbColliding";
            this.cbColliding.Size = new System.Drawing.Size(110, 24);
            this.cbColliding.TabIndex = 5;
            this.cbColliding.Text = "Is colliding?";
            this.cbColliding.UseVisualStyleBackColor = true;
            // 
            // cbInteractive
            // 
            this.cbInteractive.AutoSize = true;
            this.cbInteractive.Location = new System.Drawing.Point(322, 185);
            this.cbInteractive.Name = "cbInteractive";
            this.cbInteractive.Size = new System.Drawing.Size(121, 24);
            this.cbInteractive.TabIndex = 6;
            this.cbInteractive.Text = "Is Interactive?";
            this.cbInteractive.UseVisualStyleBackColor = true;
            // 
            // cmbDisplayColor
            // 
            this.cmbDisplayColor.FormattingEnabled = true;
            this.cmbDisplayColor.Location = new System.Drawing.Point(322, 140);
            this.cmbDisplayColor.Name = "cmbDisplayColor";
            this.cmbDisplayColor.Size = new System.Drawing.Size(163, 28);
            this.cmbDisplayColor.TabIndex = 7;
            this.cmbDisplayColor.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayColor_SelectedIndexChanged);
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(188, 35);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(126, 20);
            this.lblChar.TabIndex = 8;
            this.lblChar.Text = "Display character:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(262, 68);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(52, 20);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Name:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(219, 101);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(97, 20);
            this.lblCol.TabIndex = 10;
            this.lblCol.Text = "ColorID (hex)";
            // 
            // lblDispCol
            // 
            this.lblDispCol.AutoSize = true;
            this.lblDispCol.Location = new System.Drawing.Point(216, 143);
            this.lblDispCol.Name = "lblDispCol";
            this.lblDispCol.Size = new System.Drawing.Size(98, 20);
            this.lblDispCol.TabIndex = 11;
            this.lblDispCol.Text = "Display Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowCharacter);
            this.groupBox1.Location = new System.Drawing.Point(618, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // btnSaveObject
            // 
            this.btnSaveObject.Location = new System.Drawing.Point(618, 215);
            this.btnSaveObject.Name = "btnSaveObject";
            this.btnSaveObject.Size = new System.Drawing.Size(167, 29);
            this.btnSaveObject.TabIndex = 14;
            this.btnSaveObject.Text = "Save to list";
            this.btnSaveObject.UseVisualStyleBackColor = true;
            this.btnSaveObject.Click += new System.EventHandler(this.btnSaveObject_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(621, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 29);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 258);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 29);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Create new empty";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(472, 258);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(107, 29);
            this.btnSaveAs.TabIndex = 17;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(354, 258);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 29);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnResetWindow
            // 
            this.btnResetWindow.Location = new System.Drawing.Point(244, 258);
            this.btnResetWindow.Name = "btnResetWindow";
            this.btnResetWindow.Size = new System.Drawing.Size(104, 29);
            this.btnResetWindow.TabIndex = 19;
            this.btnResetWindow.Text = "Clear window";
            this.btnResetWindow.UseVisualStyleBackColor = true;
            this.btnResetWindow.Click += new System.EventHandler(this.btnResetWindow_Click);
            // 
            // cmbPrvCol
            // 
            this.cmbPrvCol.FormattingEnabled = true;
            this.cmbPrvCol.Location = new System.Drawing.Point(701, 259);
            this.cmbPrvCol.Name = "cmbPrvCol";
            this.cmbPrvCol.Size = new System.Drawing.Size(87, 28);
            this.cmbPrvCol.TabIndex = 20;
            this.cmbPrvCol.SelectedIndexChanged += new System.EventHandler(this.cmbPrvCol_SelectedIndexChanged);
            // 
            // lbl_PrevBG
            // 
            this.lbl_PrevBG.AutoSize = true;
            this.lbl_PrevBG.Location = new System.Drawing.Point(597, 262);
            this.lbl_PrevBG.Name = "lbl_PrevBG";
            this.lbl_PrevBG.Size = new System.Drawing.Size(98, 20);
            this.lbl_PrevBG.TabIndex = 21;
            this.lbl_PrevBG.Text = "Preview back:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(188, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbl_PrevBG);
            this.Controls.Add(this.cmbPrvCol);
            this.Controls.Add(this.btnResetWindow);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSaveObject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDispCol);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.cmbDisplayColor);
            this.Controls.Add(this.cbInteractive);
            this.Controls.Add(this.cbColliding);
            this.Controls.Add(this.tbColorID);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbChar);
            this.Controls.Add(this.listBoxItems);
            this.Name = "Form1";
            this.Text = "The Cave Map Object Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxItems;
        private Label lblShowCharacter;
        private TextBox tbChar;
        private TextBox tbDescription;
        private TextBox tbColorID;
        private CheckBox cbColliding;
        private CheckBox cbInteractive;
        private ComboBox cmbDisplayColor;
        private Label lblChar;
        private Label lblDesc;
        private Label lblCol;
        private Label lblDispCol;
        private GroupBox groupBox1;
        private Button btnSaveObject;
        private Button btnRemove;
        private Button btnNew;
        private Button btnSaveAs;
        private Button btnLoad;
        private Button btnResetWindow;
        private ComboBox cmbPrvCol;
        private Label lbl_PrevBG;
        private Label lblID;
    }
}