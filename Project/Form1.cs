using System;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public UserData userData
        {
            get => new UserData
            {
                PassSeries = passSeries.Text,
                PassNumber = passNumber.Text,
                PassFullName = passFullName.Text,
                PassReceivingDate = passReceivingDate.Value,
                PassIss = passIss.Text,
                PassAddress = passAddress.Text,
                LicenseSeries = licenseSeries.Text,
                LicenseNumber = licenseNumber.Text,
                LicenseReceivingDate = licenseReceivingDate.Value,
                CarList = listView.Items.Cast<ListViewItem>().Select(x => x.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(y => y.Text).ToArray()).ToArray()
            };
            set
            {
                passSeries.Text = value.PassSeries;
                passSeries.Text = value.PassSeries;
                passNumber.Text = value.PassNumber;
                passFullName.Text = value.PassFullName;
                passReceivingDate.Value = value.PassReceivingDate;
                passIss.Text = value.PassIss;
                passAddress.Text = value.PassAddress;
                licenseSeries.Text = value.LicenseSeries;
                licenseNumber.Text = value.LicenseNumber;
                licenseReceivingDate.Value = value.LicenseReceivingDate;
                listView.Items.Clear();
                listView.Items.AddRange(value.CarList.Select(x => new ListViewItem(x)).ToArray());
            }
        }
        XmlSerializer formatter = new XmlSerializer(typeof(UserData));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passSeries.Mask = "0000";
            passNumber.Mask = "000000";
            licenseSeries.Mask = "0000";
            licenseNumber.Mask = "000000";
            carNumber.Mask = "L000LL 000";
            licenseReceivingDate.MaxDate = DateTime.Today;
            passReceivingDate.MaxDate = DateTime.Today;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                formatter.Serialize(fs, userData);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все несохраненные данные будут утеряны", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel ||
                openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                userData = (UserData)formatter.Deserialize(fs);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            listView.Items.Add(new ListViewItem(new[] { carNumber.Text, carModel.Text, duration.Text, price.Text }));
            carNumber.Clear();
            carModel.Clear();
            duration.Value = 1;
            price.Value = 1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Items.RemoveAt(listView.SelectedIndices[0]);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Запись не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    [Serializable]
    public class UserData
    {
        public string PassSeries { get; set; }
        public string PassNumber { get; set; }
        public string PassFullName { get; set; }
        public DateTime PassReceivingDate { get; set; }
        public string PassIss { get; set; }
        public string PassAddress { get; set; }
        public string LicenseSeries { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime LicenseReceivingDate { get; set; }
        public string[][] CarList { get; set; }
    }
}
