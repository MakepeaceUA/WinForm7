namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateToolStripBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ���������", "�����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColorToolStripComboBox_Click(object sender, EventArgs e)
        {
            var Box = sender as ToolStripComboBox;

            if (Box != null && Box.SelectedItem != null)
            {
                switch (Box.SelectedItem)
                {
                    case "�������":
                        BackColor = Color.Red;
                        break;
                    case "������":
                        BackColor = Color.Green;
                        break;
                    case "�����":
                        BackColor = Color.Blue;
                        break;
                }
            }
        }

        private void ToolStripTextBox_Click(object sender, EventArgs e)
        {
            var text = sender as ToolStripTextBox;

            if (text != null && !string.IsNullOrEmpty(text.Text))
            {
                MessageBox.Show(text.Text, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}