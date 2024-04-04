using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class ClientsForm : Form
    {

        private List<Client> clients = new List<Client>();
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            clients = new List<Client>();

        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            double loyaltyPoints;
            if (double.TryParse(textBoxClientLoyaltyPoints.Text, out loyaltyPoints))
            {
                var client = new Client(
                    textBoxClientId.Text,
                    textBoxClientFirstName.Text,
                    textBoxClientLastName.Text,
                    textBoxClientEmail.Text,
                    textBoxClientAddress.Text,
                    textBoxClientPhoneNumber.Text,
                    loyaltyPoints
                );
                clients.Add(client);

                ResetForm();
                DisplayParticipants();
            }
            else
            {
                MessageBox.Show("Invalid loyalty points value. Please enter a valid numeric value.");
            }


        }

        private void ResetForm()
        {
            textBoxClientAddress.Text = textBoxClientEmail.Text = textBoxClientFirstName.Text = textBoxClientId.Text
                = textBoxClientLastName.Text
                = textBoxClientPhoneNumber.Text = string.Empty;

            textBoxClientPhoneNumber.Text = null;
        }

        private void DisplayParticipants()
        {
            listViewClients.Items.Clear();
            foreach (var _client in clients)
            {
                var auxListItem = new ListViewItem(_client.ClientId);
                auxListItem.SubItems.Add(_client.ClientFirstName);
                auxListItem.SubItems.Add(_client.ClientLastName);
                auxListItem.SubItems.Add(_client.ClientEmail);
                auxListItem.SubItems.Add(_client.ClientAddress);
                auxListItem.SubItems.Add(_client.ClientPhoneNumber);
                auxListItem.SubItems.Add(_client.ClientLoyaltyPoints.ToString());

                auxListItem.Tag = _client;
                listViewClients.Items.Add(auxListItem);

            }
        }

        //private void buttonSaveClient_Click(object sender, EventArgs e)
        //{
        //    if (listViewClients.SelectedItems.Count > 0)
        //    {
        //        var _client = listViewClients.SelectedItems[0].Tag as Client;

        //        _client.ClientId = textBoxClientId.Text;
        //        _client.ClientFirstName = textBoxClientFirstName.Text;
        //        _client.ClientLastName = textBoxClientLastName.Text;
        //        _client.ClientEmail = textBoxClientEmail.Text;
        //        _client.ClientAddress = textBoxClientAddress.Text;
        //        _client.ClientPhoneNumber = textBoxClientPhoneNumber.Text;

        //        double loyaltyPoints;
        //        if (double.TryParse(textBoxClientLoyaltyPoints.Text, out loyaltyPoints))
        //        {
        //            _client.ClientLoyaltyPoints = loyaltyPoints;

        //            ResetForm();
        //            DisplayParticipants();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid loyalty points value. Please enter a valid numeric value.");
        //        }
        //    }
        //}

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                var selectedClient = listViewClients.SelectedItems[0].Tag as Client;

                double loyaltyPoints;
                if (double.TryParse(textBoxClientLoyaltyPoints.Text, out loyaltyPoints))
                {
                    selectedClient.ClientId = textBoxClientId.Text;
                    selectedClient.ClientFirstName = textBoxClientFirstName.Text;
                    selectedClient.ClientLastName = textBoxClientLastName.Text;
                    selectedClient.ClientEmail = textBoxClientEmail.Text;
                    selectedClient.ClientAddress = textBoxClientAddress.Text;
                    selectedClient.ClientPhoneNumber = textBoxClientPhoneNumber.Text;
                    selectedClient.ClientLoyaltyPoints = loyaltyPoints;

                    // Update the list view
                    listViewClients.SelectedItems[0].Text = textBoxClientId.Text;
                    listViewClients.SelectedItems[0].SubItems[1].Text = textBoxClientFirstName.Text;
                    listViewClients.SelectedItems[0].SubItems[2].Text = textBoxClientLastName.Text;
                    listViewClients.SelectedItems[0].SubItems[3].Text = textBoxClientEmail.Text;
                    listViewClients.SelectedItems[0].SubItems[4].Text = textBoxClientAddress.Text;
                    listViewClients.SelectedItems[0].SubItems[5].Text = textBoxClientPhoneNumber.Text;
                    listViewClients.SelectedItems[0].SubItems[6].Text = loyaltyPoints.ToString();

                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Invalid loyalty points value. Please enter a valid numeric value.");
                }
            }
        }


        private void buttonSaveClient_SelectedIndexChanges(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                var _client = listViewClients.SelectedItems[0].Tag as Client;

                _client.ClientId = textBoxClientId.Text;
                _client.ClientFirstName = textBoxClientFirstName.Text;
                _client.ClientLastName = textBoxClientLastName.Text;
                _client.ClientEmail = textBoxClientEmail.Text;
                _client.ClientAddress = textBoxClientAddress.Text;
                _client.ClientPhoneNumber = textBoxClientPhoneNumber.Text;

                double loyaltyPoints;
                if (double.TryParse(textBoxClientLoyaltyPoints.Text, out loyaltyPoints))
                {
                    _client.ClientLoyaltyPoints = loyaltyPoints;

                }
                else
                {
                    MessageBox.Show("Invalid loyalty points value. Please enter a valid numeric value.");
                }
            }
        }


        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                var _client = listViewClients.SelectedItems[0].Tag as Client;


                clients.Remove(_client);
                ResetForm();
                DisplayParticipants();

            }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                var selectedClient = listViewClients.SelectedItems[0].Tag as Client;

                // Display the details of the selected client in the textboxes
                textBoxClientId.Text = selectedClient.ClientId;
                textBoxClientFirstName.Text = selectedClient.ClientFirstName;
                textBoxClientLastName.Text = selectedClient.ClientLastName;
                textBoxClientEmail.Text = selectedClient.ClientEmail;
                textBoxClientAddress.Text = selectedClient.ClientAddress;
                textBoxClientPhoneNumber.Text = selectedClient.ClientPhoneNumber;
                textBoxClientLoyaltyPoints.Text = selectedClient.ClientLoyaltyPoints.ToString();
            }

        }



    }
}
