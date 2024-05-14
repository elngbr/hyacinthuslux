using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace hyacinthuslux
{
    public partial class Client_Form : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        private List<Client> clients = new List<Client>();
        public Client_Form()
        {
            InitializeComponent();
        }

        private void Client_Form_Load(object sender, EventArgs e)
        {
            clients = new List<Client>();
        }

        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (lvClients.SelectedItems.Count > 0)
        //    {
        //        var selectedClient = lvClients.SelectedItems[0].Tag as Client;

                
        //        numId.Value = selectedClient.clientId;
        //        tbFirstName.Text = selectedClient.clientFirstName;
        //        tbLastName.Text = selectedClient.clientLastName;
        //        tbEmail.Text = selectedClient.clientEmail;
        //        tbAddress.Text = selectedClient.clientAddress;
        //        tbPhoneNumber.Text = selectedClient.clientPhoneNumber;
        //        numLoy.Value = (decimal)selectedClient.clientLoyaltyPoints;
        //    }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Client _client = 
                new Client((int)numId.Value, tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbAddress.Text, tbPhoneNumber.Text, (int)numLoy.Value);
            clients.Add(_client);
            ResetForm();
            DisplayParticipants();
            

        }

        private void ResetForm()
        {
            tbFirstName.Text = tbLastName.Text = tbAddress.Text = tbPhoneNumber.Text = tbEmail.Text = string.Empty;
            numId.Value = numLoy.Value = 1;
        }

        private void DisplayParticipants()
        {
            lvClients.Items.Clear();

            foreach(var cl in clients)
            {
                {
                    var auxListItem = new ListViewItem(cl.clientId.ToString());
                    auxListItem.SubItems.Add(cl.clientFirstName);
                    auxListItem.SubItems.Add(cl.clientLastName);
                    auxListItem.SubItems.Add(cl.clientEmail);
                    auxListItem.SubItems.Add(cl.clientAddress);
                    auxListItem.SubItems.Add(cl.clientPhoneNumber);
                    auxListItem.SubItems.Add(cl.clientLoyaltyPoints.ToString());

                    auxListItem.Tag = cl;
                    lvClients.Items.Add(auxListItem);

                }
            }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if(lvClients.SelectedItems.Count>0)
            {
                var selectedClient = lvClients.SelectedItems[0].Tag as Client;

                selectedClient.clientId = (int)numId.Value;
                selectedClient.clientFirstName = tbFirstName.Text;
                selectedClient.clientLastName = tbLastName.Text;
                selectedClient.clientEmail = tbEmail.Text;
                selectedClient.clientAddress = tbAddress.Text;
                selectedClient.clientPhoneNumber = Phone.Text;
                selectedClient.clientLoyaltyPoints = (double)numLoy.Value;

                lvClients.SelectedItems[0].Text = numId.Value.ToString();
                lvClients.SelectedItems[0].SubItems[1].Text = tbFirstName.Text;
                lvClients.SelectedItems[0].SubItems[2].Text = tbLastName.Text;
                lvClients.SelectedItems[0].SubItems[3].Text = tbEmail.Text;
                lvClients.SelectedItems[0].SubItems[4].Text = tbAddress.Text;
                lvClients.SelectedItems[0].SubItems[5].Text = Phone.Text;
                lvClients.SelectedItems[0].SubItems[6].Text = numLoy.Value.ToString();

                ResetForm();
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                var _client = lvClients.SelectedItems[0].Tag as Client;


                clients.Remove(_client);
                ResetForm();
                DisplayParticipants();

            }
        }

        private void lvClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvClients.SelectedItems.Count > 0)
            {
                var selectedClient = lvClients.SelectedItems[0].Tag as Client;


                numId.Value = selectedClient.clientId;
                tbFirstName.Text = selectedClient.clientFirstName;
                tbLastName.Text = selectedClient.clientLastName;
                tbEmail.Text = selectedClient.clientEmail;
                tbAddress.Text = selectedClient.clientAddress;
                tbPhoneNumber.Text = selectedClient.clientPhoneNumber;
                numLoy.Value = (decimal)selectedClient.clientLoyaltyPoints;
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(tbFirstName.Text.Length<3)
            {
                e.Cancel = true;
                errorProvider.SetError(tbFirstName, "FirstName too short!");
            }

            if (String.IsNullOrEmpty(tbFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbFirstName, "It's compulsory to have a name!");
            }

            if (String.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbFirstName, "It's compulsory to have a name!");
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {

            if (tbLastName.Text.Length < 3)
            {
                e.Cancel=true;
                errorProvider.SetError(tbLastName, "FirstName too short!");
            }

            if (String.IsNullOrEmpty(tbLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbLastName, "It's compulsory to have a name!");
            }

            if (String.IsNullOrWhiteSpace(tbLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbLastName, "It's compulsory to have a name!");
            }
        }

        private void numId_Validating(object sender, CancelEventArgs e)
        {
            if (numId.Value > 100)
            {
                e.Cancel = true;

                errorProvider.SetError(numId, "Invalid id!");
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if(!tbAddress.Text.Contains(","))
            {
                e.Cancel = true;

                errorProvider.SetError(tbAddress, "Invalid address, use commas!");
            }


            if (String.IsNullOrEmpty(tbAddress.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbAddress, "It's compulsory to have an address!");
            }

            if (String.IsNullOrWhiteSpace(tbAddress.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbAddress, "It's compulsory to have an address!");
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!tbEmail.Text.Contains("@"))
            {
                e.Cancel = true;
                errorProvider.SetError(tbEmail, "Invalid email");
            }

            if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbEmail, "It's compulsory to have an email address!");
            }

            if (String.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbEmail, "It's compulsory to have an email address!");
            }
        }

        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbPhoneNumber, "It's compulsory to have a phone number!");
            }

            if (String.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbPhoneNumber, "It's compulsory to have a phone number!");
            }

            if(tbPhoneNumber.Text.Length>15|| tbPhoneNumber.Text.Length<7)
            {
                e.Cancel = true;
                errorProvider.SetError(tbPhoneNumber, "Invalid phone number length!");
            }
        }

        private void numLoy_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numLoy_Validating(object sender, CancelEventArgs e)
        {

            if (numLoy.Value > 99)
            {
                e.Cancel = true;
                MessageBox.Show("Invalid Loyalty points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            if (svf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(svf.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, clients);

                }
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    clients = (List<Client>)bf.Deserialize(fs);
                    DisplayParticipants();
                }
            }
        }

        private void contextMenuStripXML_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void serializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(svf.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Client>));

                    ser.Serialize(fs, clients);
                }
            }
        }

        private void deserializeXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Client>));
                    clients = (List<Client>)ser.Deserialize(fs);
                    DisplayParticipants();


                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbFirstName.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                tbFirstName.Text= Clipboard.GetText();
            }
        }

        private void tbPhoneNumber_MouseDown(object sender, MouseEventArgs e)
        {
            tbPhoneNumber.DoDragDrop(tbPhoneNumber.Text, DragDropEffects.Copy);
        }

        private void tbPhoneNumber_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect= DragDropEffects.Copy;
            }
        }

        private void tbPhoneNumber_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                tbPhoneNumber.Text=(string)e.Data.GetData(DataFormats.Text);
            }
        }
    }
}