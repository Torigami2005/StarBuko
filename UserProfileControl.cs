using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarBuko
{
    public partial class UserProfileControl : UserControl
    {
        public UserProfileControl()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            this.Cursor = Cursors.Default;

        }



        public event EventHandler ProductClicked;

        private void TriggerClick(object sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UserProfileControl_Load(object sender, EventArgs e)
        {
            this.Click += TriggerClick;
            itemName.Click += TriggerClick;
            priceValue.Click += TriggerClick;
            prodPicture.Click += TriggerClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void itemName_Click(object sender, EventArgs e)
        {

        }


        private void prodPicture_Click(object sender, EventArgs e)
        {

        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image PictureBoxImage
        {
            get => prodPicture.Image;
            set => prodPicture.Image = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Title
        {
            get => itemName.Text;
            set => itemName.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelPrice
        {
            get => priceValue.Text;
            set => priceValue.Text = value;
        }

    }

}
