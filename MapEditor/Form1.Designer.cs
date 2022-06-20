namespace MapEditor
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
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.btnClearCanvas = new System.Windows.Forms.Button();
            this.btnPixelSize = new System.Windows.Forms.Button();
            this.tbPixelSize = new System.Windows.Forms.TextBox();
            this.lblPixelSize = new System.Windows.Forms.Label();
            this.cbEraser = new System.Windows.Forms.CheckBox();
            this.lblCoords = new System.Windows.Forms.Label();
            this.btnFillAll = new System.Windows.Forms.Button();
            this.btnLoadObjects = new System.Windows.Forms.Button();
            this.objectListBox = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 0);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1155, 645);
            this.panelCanvas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnLoadMap);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cbEraser);
            this.panel2.Controls.Add(this.lblCoords);
            this.panel2.Controls.Add(this.btnFillAll);
            this.panel2.Controls.Add(this.btnLoadObjects);
            this.panel2.Controls.Add(this.objectListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 645);
            this.panel2.TabIndex = 1;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(3, 507);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(215, 31);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "console-like preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(4, 469);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(215, 31);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "export map texture";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(4, 432);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(215, 31);
            this.btnLoadMap.TabIndex = 11;
            this.btnLoadMap.Text = "load map texture";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbHeight);
            this.panel1.Controls.Add(this.lbHeight);
            this.panel1.Controls.Add(this.tbWidth);
            this.panel1.Controls.Add(this.lbWidth);
            this.panel1.Controls.Add(this.btnClearCanvas);
            this.panel1.Controls.Add(this.btnPixelSize);
            this.panel1.Controls.Add(this.tbPixelSize);
            this.panel1.Controls.Add(this.lblPixelSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 100);
            this.panel1.TabIndex = 10;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(166, 38);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(50, 23);
            this.tbHeight.TabIndex = 13;
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(121, 41);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(43, 15);
            this.lbHeight.TabIndex = 12;
            this.lbHeight.Text = "Height";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(60, 37);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(50, 23);
            this.tbWidth.TabIndex = 11;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(15, 41);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(39, 15);
            this.lbWidth.TabIndex = 10;
            this.lbWidth.Text = "Width";
            // 
            // btnClearCanvas
            // 
            this.btnClearCanvas.Location = new System.Drawing.Point(2, 67);
            this.btnClearCanvas.Name = "btnClearCanvas";
            this.btnClearCanvas.Size = new System.Drawing.Size(217, 30);
            this.btnClearCanvas.TabIndex = 9;
            this.btnClearCanvas.Text = "Reset canvas";
            this.btnClearCanvas.UseVisualStyleBackColor = true;
            this.btnClearCanvas.Click += new System.EventHandler(this.btnClearCanvas_Click);
            // 
            // btnPixelSize
            // 
            this.btnPixelSize.Location = new System.Drawing.Point(144, 3);
            this.btnPixelSize.Name = "btnPixelSize";
            this.btnPixelSize.Size = new System.Drawing.Size(75, 23);
            this.btnPixelSize.TabIndex = 5;
            this.btnPixelSize.Text = "set";
            this.btnPixelSize.UseVisualStyleBackColor = true;
            this.btnPixelSize.Click += new System.EventHandler(this.BtnResize_Click);
            // 
            // tbPixelSize
            // 
            this.tbPixelSize.Location = new System.Drawing.Point(88, 3);
            this.tbPixelSize.Name = "tbPixelSize";
            this.tbPixelSize.Size = new System.Drawing.Size(50, 23);
            this.tbPixelSize.TabIndex = 4;
            this.tbPixelSize.TextChanged += new System.EventHandler(this.tbPixelSize_TextChanged);
            // 
            // lblPixelSize
            // 
            this.lblPixelSize.AutoSize = true;
            this.lblPixelSize.Location = new System.Drawing.Point(4, 7);
            this.lblPixelSize.Name = "lblPixelSize";
            this.lblPixelSize.Size = new System.Drawing.Size(72, 15);
            this.lblPixelSize.TabIndex = 3;
            this.lblPixelSize.Text = "Pixel size: 15";
            this.lblPixelSize.Click += new System.EventHandler(this.lblPixelSize_Click);
            // 
            // cbEraser
            // 
            this.cbEraser.AutoSize = true;
            this.cbEraser.Location = new System.Drawing.Point(133, 3);
            this.cbEraser.Name = "cbEraser";
            this.cbEraser.Size = new System.Drawing.Size(87, 19);
            this.cbEraser.TabIndex = 8;
            this.cbEraser.Text = "Erase mode";
            this.cbEraser.UseVisualStyleBackColor = true;
            // 
            // lblCoords
            // 
            this.lblCoords.AutoSize = true;
            this.lblCoords.Location = new System.Drawing.Point(4, 7);
            this.lblCoords.Name = "lblCoords";
            this.lblCoords.Size = new System.Drawing.Size(38, 15);
            this.lblCoords.TabIndex = 7;
            this.lblCoords.Text = "label2";
            // 
            // btnFillAll
            // 
            this.btnFillAll.Location = new System.Drawing.Point(3, 335);
            this.btnFillAll.Name = "btnFillAll";
            this.btnFillAll.Size = new System.Drawing.Size(217, 30);
            this.btnFillAll.TabIndex = 6;
            this.btnFillAll.Text = "fill all with selected";
            this.btnFillAll.UseVisualStyleBackColor = true;
            this.btnFillAll.Click += new System.EventHandler(this.BtnFillCanvas_Click);
            // 
            // btnLoadObjects
            // 
            this.btnLoadObjects.Location = new System.Drawing.Point(4, 371);
            this.btnLoadObjects.Name = "btnLoadObjects";
            this.btnLoadObjects.Size = new System.Drawing.Size(215, 31);
            this.btnLoadObjects.TabIndex = 1;
            this.btnLoadObjects.Text = "load mapobjects file";
            this.btnLoadObjects.UseVisualStyleBackColor = true;
            this.btnLoadObjects.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // objectListBox
            // 
            this.objectListBox.FormattingEnabled = true;
            this.objectListBox.ItemHeight = 15;
            this.objectListBox.Location = new System.Drawing.Point(3, 25);
            this.objectListBox.Name = "objectListBox";
            this.objectListBox.Size = new System.Drawing.Size(217, 304);
            this.objectListBox.TabIndex = 0;
            this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 645);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "HOME - Highly unOptimized Map Editor  [The Cave]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCanvas;
        private Panel panel2;
        private Button btnLoadObjects;
        private ListBox objectListBox;
        private Label lblPixelSize;
        private Button btnPixelSize;
        private TextBox tbPixelSize;
        private Button btnFillAll;
        private Label lblCoords;
        private CheckBox cbEraser;
        private Button btnClearCanvas;
        private Panel panel1;
        private TextBox tbHeight;
        private Label lbHeight;
        private TextBox tbWidth;
        private Label lbWidth;
        private Button btnExport;
        private Button btnLoadMap;
        private Button btnPreview;
    }
}