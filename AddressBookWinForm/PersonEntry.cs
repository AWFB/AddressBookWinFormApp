using DemoLibrary;
using System.ComponentModel;

namespace AddressBookWinForm
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();
            addressListBox.DataSource = addresses;
            addressListBox.DisplayMember = nameof(AddressModel.FullAddressView);
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);
            // Display the form
            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList(),
            };
        }
    }
}