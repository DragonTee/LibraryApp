using System.Windows.Forms;

namespace LibraryApp
{
    public partial class OrderBookDialog : Form
    {
        public OrderBookDialog()
        {
            InitializeComponent();
            OrderBtn.Click += (sender, args) =>
            {
                DialogResult = DialogResult.OK;
            };
        }

        public int GetUserId()
        {
            return (int)UserId.Value;
        }
    }
}