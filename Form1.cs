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
            var comboBox = sender as ToolStripComboBox;

            if (comboBox != null && comboBox.SelectedItem != null)
            {
                switch (comboBox.SelectedItem)
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
            var textBox = sender as ToolStripTextBox;

            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(textBox.Text, "�������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}