using krecikthegame.Models;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

namespace MapEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MapObject> mapObjects;
        MapObject selectedObject;

        bool ismousedown = false;
        bool isdoubleclicked = false;
        bool gumka = false;

        int canvaswidth;
        int canvasheight;
        int tilesize;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "mapobjects.json")))
            {
                try
                {

                    mapObjects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MapObject>>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "mapobjects.json")));

                    objectListBox.Items.Clear();
                    mapObjects.ForEach(obj => objectListBox.Items.Add(String.Format("{00}  - {01}", obj.Display, obj.Name)));

                }
                catch { }
            }
            panelCanvas.Controls.Clear();
            tbHeight.Text = "9";
            tbWidth.Text = "16";
            this.WindowState = FormWindowState.Maximized;
            int pixelsize = (panelCanvas.Width - 10) / Int32.Parse(tbWidth.Text);
            if (pixelsize * Int32.Parse(tbHeight.Text) > panelCanvas.Height - 10) pixelsize = (panelCanvas.Height - 10) / Int32.Parse(tbHeight.Text);
            panelCanvas.BackColor = Color.MintCream;
            tbPixelSize.Text = "" + pixelsize;
            lblPixelSize.Text = "Pixel size: " + pixelsize;
            Task pnl = Task.Factory.StartNew(() => UpdatePanelControls());
        }



        private void ResizePanels(int size, int width = 75, int height = 43)
        {
            int index = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Panel pnl = panelCanvas.Controls[index++] as Panel;
                    pnl.Width = size;
                    pnl.Height = size;
                    pnl.Top = (y * size) + 5;
                    pnl.Left = (x * size) + 5;
                    pnl.Controls[0].Font = new System.Drawing.Font("MxPlus IBM BIOS", (size- 2) * 1.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void UpdatePanelControls()
        {
            if (!InvokeRequired)
            {
                List<Control> controls = new List<Control>();
                Task spawn = Task.Factory.StartNew(() => SpawnPanels(Color.Transparent, out controls, Int32.Parse(tbPixelSize.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text)));
                spawn.Wait();
                panelCanvas.Visible = false;
                controls.ForEach(control => panelCanvas.Controls.Add(control));
                panelCanvas.Visible = true;
            }
            else
            {
                Invoke(new Action(UpdatePanelControls));
            }

        }

        private void SpawnPanels(Color defCol, out List<Control> spawned, int size = 15, int width = 75, int height = 43)
        {
            spawned = new List<Control>();
            canvasheight = height;
            canvaswidth = width;
            tilesize = size;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Panel add = new Panel()
                    {
                        Width = size,
                        Height = size,
                        Top = (y * size) + 5,
                        Left = (x * size) + 5,
                        BackColor = defCol,
                        Visible = true,
                        BorderStyle = BorderStyle.FixedSingle,
                        Name = "panel" + x + y
                    };
                    Label addlbl = new Label()
                    {
                        Text = " ",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new System.Drawing.Font("MxPlus IBM BIOS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                        Top = 0,
                        Left = 0,
                        Margin = new Padding(0),
                        Padding = new Padding(0),
                        BackColor = Color.Transparent
                };
                    addlbl.MouseDown += MouseDownLabel;
                    addlbl.DoubleClick += DoubleClickLabel;
                    
                    addlbl.MouseEnter += MouseEnterLabel;
                    
                    addlbl.MouseUp += MouseUp;
                    add.Controls.Add(addlbl);
                    add.MouseEnter += MouseEnterPanel;
                    add.MouseUp += MouseUp;
                    spawned.Add(add);

                }
            }
        }

        private void DoubleClickLabel(object? sender, EventArgs e)
        {

            Label lbl = sender as Label;
            Panel pnl = lbl.Parent as Panel;
            lbl.Text = " ";
            pnl.BackColor = Color.Transparent;
            ismousedown = true;
            isdoubleclicked = true;
            lbl.Capture = false;
            pnl.Capture = false;
        }

        private void MouseDownLabel(object? sender, EventArgs e)
        {
            if (mapObjects == null)
            {
                MessageBox.Show("Load object list file first!", "HOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            try
            {
                Label lbl = sender as Label;
                Panel pnl = lbl.Parent as Panel;
                if (cbEraser.Checked)
                {
                    pnl.BackColor = Color.Transparent;
                }
                else

                {
                    if (selectedObject == null)
                    {
                        MessageBox.Show("Select object from the list first!", "HOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    pnl.BackColor = System.Drawing.ColorTranslator.FromHtml(selectedObject.ColorID);
                    lbl.Text = selectedObject.Display;
                }

                lbl.Capture = false;
                pnl.Capture = false;
                ismousedown = true;
            }
            catch { }
        }

        private void MouseEnterLabel(object? sender, EventArgs e)
        {
            {
                        try
                        {
                            Label lbl = sender as Label;
                            Panel pnl = lbl.Parent as Panel;
                            lblCoords.Text = String.Format("[{0};{1}] - {2}", (pnl.Left - 5) / pnl.Width, (pnl.Top - 5) / pnl.Height, lbl.Text);
                            if (ismousedown)
                            {
                                if (cbEraser.Checked)
                                {
                                    lbl.Text = " ";
                                    pnl.BackColor = Color.Transparent;

                                }
                                else
                                {
                                    pnl.BackColor = System.Drawing.ColorTranslator.FromHtml(selectedObject.ColorID);
                                    lbl.Text = selectedObject.Display;
                                }
                                pnl.Capture = false;
                                lbl.Capture = false;
                                ismousedown = true;
                            }
                        }
                        catch { }
                    };
        }

        private void MouseEnterPanel(object? sender, EventArgs e)
        {
            try
            {
                Panel pnl = sender as Panel;
                if (ismousedown)
                {

                    //var ind = panel1.Controls.IndexOfKey(pnl).Name);
                    //panel1.Controls[ind].BackColor = Color.White;
                    if (cbEraser.Checked)
                    {

                        pnl.BackColor = Color.Transparent;
                        pnl.Capture = false;
                        pnl.Controls[0].Text = " ";
                    }
                    else
                    {
                        pnl.BackColor = System.Drawing.ColorTranslator.FromHtml(selectedObject.ColorID);
                        pnl.Capture = false;
                        pnl.Controls[0].Text = selectedObject.Display;

                    }
                }
            }
            catch { }
        }

        private void MouseUp(object? sender, EventArgs e)
        {
            ismousedown = false;
            isdoubleclicked = false;
        }


        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open The Cave Map Objects file";
            openFileDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            openFileDialog.FileName = "mapobjects";
            openFileDialog.DefaultExt = ".json";
            openFileDialog.Filter = "The Cave Map Objects JSON files (*.json)|*.json";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                mapObjects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MapObject>>(File.ReadAllText(openFileDialog.FileName));

                objectListBox.Items.Clear();
                mapObjects.ForEach(obj => objectListBox.Items.Add(String.Format("{00}  - {01}", obj.Display, obj.Name)));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedObject = mapObjects[objectListBox.SelectedIndex];
        }


        private void FillWithSelected()
        {
            Application.UseWaitCursor = true;
            this.UseWaitCursor = true;
            foreach (Panel control in panelCanvas.Controls)
            {
                control.BackColor = System.Drawing.ColorTranslator.FromHtml(selectedObject.ColorID);
                control.Controls[0].Text = selectedObject.Display;
            }
            Application.UseWaitCursor = false;
            this.UseWaitCursor = false;

        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            Application.UseWaitCursor = true;
            this.UseWaitCursor = true;
            int size = Int32.Parse(tbPixelSize.Text);
            lblPixelSize.Text = "Pixel size: " + size;
            panelCanvas.Visible = false;
            ResizePanels(Int32.Parse(tbPixelSize.Text), Int32.Parse(tbWidth.Text), Int32.Parse(tbHeight.Text));
            panelCanvas.Visible = true;
            this.UseWaitCursor = false;
            Application.UseWaitCursor = false;
            //Cursor.Current = Cursors.Default;
        }

        private void BtnFillCanvas_Click(object sender, EventArgs e)
        {
            if (mapObjects == null)
            {
                MessageBox.Show("Load object list file first!", "HOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("This will delete all data on canvas and fill it with selected object.\nContinue?", "HOME", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                panelCanvas.Visible = false;
                FillWithSelected();
                panelCanvas.Visible = true;
            }
        }

        private void lblPixelSize_Click(object sender, EventArgs e)
        {

        }

        private void tbPixelSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearCanvas_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This will delete all data, and create a new canvas with specified size.\nContinue?", "HOME", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            panelCanvas.Visible = false;
            panelCanvas.Controls.Clear();
            this.WindowState = FormWindowState.Maximized;
            int pixelsize = (panelCanvas.Width - 10) / Int32.Parse(tbWidth.Text);
            if (pixelsize * Int32.Parse(tbHeight.Text) > panelCanvas.Height - 10) pixelsize = (panelCanvas.Height - 10) / Int32.Parse(tbHeight.Text);
            lblPixelSize.Text = "Pixel size: " + pixelsize;
            tbPixelSize.Text = pixelsize + "";
            Task pnl = Task.Factory.StartNew(() => UpdatePanelControls());
            panelCanvas.Visible = true;
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            if (mapObjects == null) 
                    {
                MessageBox.Show("Load object list file first!", "HOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open The Cave Map Texture file";
            openFileDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            openFileDialog.FileName = "map";
            openFileDialog.DefaultExt = ".png";
            openFileDialog.Filter = "The Cave Map Texture files (*.png)|*.png";
            this.UseWaitCursor = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
               this.Text = "HOME [" + openFileDialog.FileName + "]";
                Bitmap import = new Bitmap(openFileDialog.FileName);
                panelCanvas.Controls.Clear();
                canvaswidth = import.Width;
                canvasheight = import.Height;
                tilesize = (panelCanvas.Width - 10) / canvaswidth;
                if (tilesize * canvasheight > (panelCanvas.Height - 10)) tilesize = (panelCanvas.Height - 10) / canvasheight;
                tbHeight.Text = canvasheight + "";
                tbWidth.Text = canvaswidth + "";
                tbPixelSize.Text = "" + tilesize;
                lblPixelSize.Text = "Pixel size: " + tilesize;
                for (int x = 0; x < canvaswidth; x++)
                {
                    for (int y = 0; y < canvasheight; y++)
                    {
                        Color currPixel = import.GetPixel(x, y);
                        MapObject? obj = mapObjects.Find(find => System.Drawing.ColorTranslator.FromHtml(find.ColorID) == currPixel);
                        Panel add = new Panel()
                        {
                            Width = tilesize,
                            Height = tilesize,
                            Top = (y * tilesize) + 5,
                            Left = (x * tilesize) + 5,
                            BackColor = (obj != null)? System.Drawing.ColorTranslator.FromHtml(obj.ColorID) : Color.Transparent,
                            Visible = true,
                            BorderStyle = BorderStyle.FixedSingle,
                            Name = "panel" + x + y
                        };
                        Label addlbl = new Label()
                        {
                            Text = (obj != null)? obj.Display : " ",
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Fill,
                            Font = new System.Drawing.Font("MxPlus IBM BIOS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                            Top = 0,
                            Left = 0,
                            Margin = new Padding(0),
                            Padding = new Padding(0),
                            BackColor = Color.Transparent
                        };
                        addlbl.MouseDown += MouseDownLabel;
                        addlbl.DoubleClick += DoubleClickLabel;

                        addlbl.MouseEnter += MouseEnterLabel;

                        addlbl.MouseUp += MouseUp;
                        add.Controls.Add(addlbl);
                        add.MouseEnter += MouseEnterPanel;
                        add.MouseUp += MouseUp;
                        panelCanvas.Controls.Add(add);

                    }
                }

            }
            this.UseWaitCursor = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (mapObjects == null)
            {
                MessageBox.Show("Load object list file first!", "HOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Panel plsWait = new Panel()
            {
                Width = this.Width,
                Height = this.Height,
                Name = "plsWait",
                BackColor = Color.Goldenrod
            };
            Label lblPlsWait = new Label()
            {
                Name = "lblPlsWait",
                Text = "Please wait",
                Visible = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("MxPlus IBM BIOS", 72 * 1.0f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        };
            this.Controls.Add(plsWait);
            this.Controls["plsWait"].BringToFront();
            this.Controls["plsWait"].Dock = DockStyle.Fill;
            this.Controls["plsWait"].Controls.Add(lblPlsWait);
            this.Controls["plsWait"].Controls["lblPlsWait"].Dock = DockStyle.Fill;
            plsWait.Visible = true;


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "PNG Map Texture file (*.png)|*.png";
            saveFileDialog.Title = "Save The Cave Map Texture file";
            saveFileDialog.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            saveFileDialog.FileName = "map";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Bitmap export = new Bitmap(canvaswidth, canvasheight);
                foreach (Panel item in panelCanvas.Controls)
                {
                    int x = (item.Left - 5) / tilesize;
                    int y = (item.Top - 5) / tilesize;
                    export.SetPixel(x, y, item.BackColor);
                }

                export.Save(saveFileDialog.FileName, ImageFormat.Png);
            }

            plsWait.Visible = false;

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Preview fakeConsole = new Preview(panelCanvas, canvaswidth, canvasheight, tilesize);
            fakeConsole.Show();
        }
    }
}