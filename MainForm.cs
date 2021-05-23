using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DLH
{
    //Please forgive me for this code.
    public partial class MainForm : Form
    {
        public string EntryJson = "entries.json";
        public string WindowName = "Discord Link Helper";
        public bool PerformingDeletion = false;
        public int? PreviousIndex = null;

        public MainForm()
        {
            InitializeComponent();
            this.entryList.SelectedIndexChanged += entryListChanged;
            LoadEntries();
        }

        public void LoadEntries()
        {
            //Check if entry file is empty or doesn't exist.
            if (!File.Exists(EntryJson) || File.ReadAllText(EntryJson) == string.Empty)
            {
                MessageBox.Show("Entries JSON file does not exist or is blank. The entry list will be blank.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileStream file = File.Create(EntryJson);
                file.Close();
                return;
            }

            //Load the entries.
            GlobalExchange.Inst.dlhEntries = JsonConvert.DeserializeObject<List<DLHEntry>>(File.ReadAllText(EntryJson));

            //Check if an entry is corrupted.
            bool hadToDelete = false;
            foreach(DLHEntry entry in GlobalExchange.Inst.dlhEntries.ToList())
            {
                if(entry.Name == string.Empty || entry.Link == string.Empty || entry.Type > 1 || entry.Type < 0)
                {
                    GlobalExchange.Inst.dlhEntries.Remove(entry);
                    hadToDelete = true;
                }
            }
            if(hadToDelete == true)
            {
                MessageBox.Show("Some entires were ignored due to corruption." +
                    " Please open the entries.json file and fix them manually.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            RemakeListView();
        }

        //Remakes the entire entry list. Inefficient.
        public void RemakeListView()
        {
            entryList.Items.Clear();
            foreach (DLHEntry entry in GlobalExchange.Inst.dlhEntries)
            {
                string entryType = entry.Type == 0 ? "Video" : "GIF";
                ListViewItem item = new ListViewItem(new[] { entry.Name, entryType, entry.Notes });
                entryList.Items.Add(item);
            }
        }

        //Update data when clicking an item in the entry list.
        private void entryListChanged(object sender, EventArgs e)
        {
            if (entryList.SelectedIndices.Count > 0)
            {
                if (PerformingDeletion == true) return;
                this.nameBox.Text = GlobalExchange.Inst.dlhEntries[entryList.SelectedIndices[0]].Name;
                this.linkBox.Text = GlobalExchange.Inst.dlhEntries[entryList.SelectedIndices[0]].Link;
                this.notesBox.Text = GlobalExchange.Inst.dlhEntries[entryList.SelectedIndices[0]].Notes;
                this.typeBox.SelectedIndex = GlobalExchange.Inst.dlhEntries[entryList.SelectedIndices[0]].Type;
            }
            else return;
        }
    }
}
