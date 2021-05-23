using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DLH
{
    public partial class MainForm : Form
    {
        private void deleteButton_Click(object sender, EventArgs e)
        {
            PerformingDeletion = true;
            foreach (ListViewItem item in entryList.SelectedItems)
            {
                dlhEntries.RemoveAt(item.Index);
                entryList.Items.Remove(item);
            }
            PerformingDeletion = false;
            this.Text = WindowName + " - Unsaved!";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dlhEntries.Count == 0)
            {
                MessageBox.Show("Entry list is empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string serializedJson = JsonConvert.SerializeObject(dlhEntries, Formatting.Indented);
            File.WriteAllText(EntryJson, serializedJson);

            this.Text = WindowName;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dlhEntries[entryList.SelectedIndices[0]].Link);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();

            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                DLHEntry newEntry = new DLHEntry()
                {
                    Name = newForm.nameBox.Text,
                    Type = newForm.typeBox.SelectedIndex,
                    Link = newForm.linkBox.Text,
                    Notes = newForm.notesBox.Text
                };
                dlhEntries.Add(newEntry);
                RemakeListView();
                newForm.Close();
                this.Text = WindowName + " - Unsaved!";
            }
            else
            {
                MessageBox.Show("Operation cancelled.", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lookButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            List<ListViewItem> possibleLastItem = new List<ListViewItem>();
            for (int i = 0; i < entryList.Items.Count; i++)
            {
                if (PreviousIndex != null && i == PreviousIndex)
                {
                    possibleLastItem.Add(entryList.Items[i]);
                    continue;
                }

                if (entryList.Items[i].Text.Contains(lookNameBox.Text))
                {
                    entryList.SelectedItems.Clear();
                    entryList.Items[i].Selected = true;
                    PreviousIndex = i;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                if (possibleLastItem.Count == 1)
                {
                    entryList.SelectedItems.Clear();
                    possibleLastItem[0].Selected = true;
                    return;
                }
                MessageBox.Show("Entry not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (entryList.SelectedIndices.Count > 0)
            {
                int itemIndex = entryList.SelectedIndices[0];
                dlhEntries[entryList.SelectedIndices[0]].Name = nameBox.Text;
                dlhEntries[entryList.SelectedIndices[0]].Link = linkBox.Text;
                dlhEntries[entryList.SelectedIndices[0]].Notes = notesBox.Text;
                dlhEntries[entryList.SelectedIndices[0]].Type = typeBox.SelectedIndex;
                RemakeListView();
                entryList.Items[itemIndex].Selected = true;
                this.Text = WindowName + " - Unsaved!";
            }
            else return;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
