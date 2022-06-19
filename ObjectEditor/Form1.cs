using Newtonsoft.Json;
using krecikthegame.Models;

namespace ObjectEditor
{
    public partial class Form1 : Form
    {
        List<MapObject> objectList;
        MapObject currentWorking;

        string[] consoleColors = Enum.GetNames(typeof(ConsoleColor));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objectList = new List<MapObject>();
            currentWorking = new MapObject() {  ID = 1, Display = "?" };
           cmbDisplayColor.Items.Clear();
           cmbDisplayColor.Items.AddRange(consoleColors);
            cmbPrvCol.Items.Clear();
            cmbPrvCol.Items.AddRange(consoleColors);
        }

        private void LoadToEdit()
        {
            lblID.Text = "ID: " + currentWorking.ID;
            tbChar.Text = currentWorking.Display;
            tbDescription.Text = currentWorking.Name;
            tbColorID.Text = currentWorking.ColorID;
            cbColliding.Checked = currentWorking.IsColliding;
            cbInteractive.Checked = currentWorking.IsInteractive;
            cmbDisplayColor.SelectedIndex = Array.IndexOf(consoleColors,  Enum.GetName(typeof(ConsoleColor), currentWorking.DrawColor));
        }

        private void SetListBoxItems()
        {
            listBoxItems.Items.Clear();
            objectList.ForEach(obj => listBoxItems.Items.Add(String.Format("{00}  - {01}", obj.Display, obj.Name)));
        }

        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentWorking = new MapObject();
            currentWorking.ID = objectList[listBoxItems.SelectedIndex].ID;
            currentWorking.Display = objectList[listBoxItems.SelectedIndex].Display;
            currentWorking.Name = objectList[listBoxItems.SelectedIndex].Name;
            currentWorking.ColorID = objectList[listBoxItems.SelectedIndex].ColorID;
            currentWorking.DrawColor = objectList[listBoxItems.SelectedIndex].DrawColor;
            currentWorking.IsColliding = objectList[listBoxItems.SelectedIndex].IsColliding;
            currentWorking.IsInteractive = objectList[listBoxItems.SelectedIndex].IsInteractive;
            LoadToEdit();
        }

        private void cmbDisplayColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShowCharacter.ForeColor = Color.FromName((cmbDisplayColor.SelectedItem.ToString() == "DarkYellow")? "Gold" : cmbDisplayColor.SelectedItem.ToString());
        }

        private void cmbPrvCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShowCharacter.BackColor = Color.FromName(cmbPrvCol.SelectedItem.ToString());

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            objectList.Add(new MapObject() 
            {
                Display = "?",
                Name = "unnamed",
                ID = (objectList.Count > 0) ? objectList.Last().ID + 1 : 1
        });
            SetListBoxItems();
        }

        private void tbChar_TextChanged(object sender, EventArgs e)
        {
            lblShowCharacter.Text = tbChar.Text;
        }

        private void btnSaveObject_Click(object sender, EventArgs e)
        {
           // try
            //{
                currentWorking.Display = tbChar.Text;
                currentWorking.ColorID = tbColorID.Text;
                currentWorking.Name = tbDescription.Text;
                currentWorking.IsColliding = cbColliding.Checked;
                currentWorking.IsInteractive = cbInteractive.Checked;
                currentWorking.DrawColor = Enum.Parse<ConsoleColor>(cmbDisplayColor.SelectedItem.ToString());
                int findMatch = objectList.FindIndex(x => x.ID == currentWorking.ID);
                if (findMatch != -1)
                {
                    objectList[findMatch].Name = currentWorking.Name;
                    objectList[findMatch].Display = currentWorking.Display;
                    objectList[findMatch].IsColliding = currentWorking.IsColliding;
                    objectList[findMatch].IsInteractive = currentWorking.IsInteractive;
                    objectList[findMatch].ColorID = currentWorking.ColorID;
                    objectList[findMatch].DrawColor = currentWorking.DrawColor;

                }
                else
                {
                    currentWorking.ID = (objectList.Count > 0)? objectList.Last().ID + 1 : 1;
                    objectList.Add(currentWorking);
                }
                SetListBoxItems();
            //}
            //catch 
            //{
            //    MessageBox.Show("Make sure everything is filled in correctly", "Object Editor", MessageBoxButtons.OK);
            //}
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".json";
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save The Cave Map Objects list";
            saveFileDialog.FileName = "mapobjects";
            DialogResult result = saveFileDialog.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    String fileContent = Newtonsoft.Json.JsonConvert.SerializeObject(objectList, Formatting.Indented );
                    File.WriteAllText(saveFileDialog.FileName, fileContent);
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.TryAgain:
                    break;
                case DialogResult.Continue:
                    break;
                default:
                    break;
            }

            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open The Cave Map Objects file";
            openFileDialog.FileName = "mapobjects";
            openFileDialog.DefaultExt = ".json";
            openFileDialog.Filter = "The Cave Map Objects JSON files (*.json)|*.json";
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    objectList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MapObject>>(fileContent);
                    SetListBoxItems();
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.TryAgain:
                    break;
                case DialogResult.Continue:
                    break;
                default:
                    break;
            }

        }

        private void btnResetWindow_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You will lose all your unsaved changes.\nDo you want to continue?", "Object Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    objectList = new List<MapObject>();
                    ClearCurrentObject();
                    SetListBoxItems();
                    LoadToEdit();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.TryAgain:
                    break;
                case DialogResult.Continue:
                    break;
                default:
                    break;
            }
        }

        private void ClearCurrentObject()
        {
            currentWorking = new MapObject() { ID = (objectList.Count > 0) ? objectList.Last().ID + 1 : 1, Display = "?" };
            LoadToEdit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this object?", "Object Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    break;
                default:
                    return;
                    break;
            }
            int findMatch = objectList.FindIndex(x => x.ID == currentWorking.ID && x.Name == currentWorking.Name && x.ColorID == currentWorking.ColorID);
            ClearCurrentObject();
            if (findMatch != -1)
            {
                objectList.RemoveAt(findMatch);
                SetListBoxItems();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to quit?", "Object Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.TryAgain:
                    break;
                case DialogResult.Continue:
                    break;
                default:
                    break;
            }
        }
    }
}