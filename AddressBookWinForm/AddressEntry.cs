﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookWinForm
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveAddress_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                County = countyText.Text,
                PostCode = postcodeText.Text,
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
