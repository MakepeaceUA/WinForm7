namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(FirstNumTextBox.Text, out num1) && int.TryParse(SecondNumTextBox.Text, out num2))
            {
                MessageBox.Show($"Сумма: {num1 + num2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(FirstNumTextBox.Text, out num1) && int.TryParse(SecondNumTextBox.Text, out num2))
            {
                MessageBox.Show($"Разница: {num1 - num2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstNumTextBox.Clear();
            SecondNumTextBox.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddingToolStripBTN_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(FirstNumTextBox.Text, out num1) && int.TryParse(SecondNumTextBox.Text, out num2))
            {
                MessageBox.Show($"Сумма: {num1 + num2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubtractionToolStripBTN_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(FirstNumTextBox.Text, out num1) && int.TryParse(SecondNumTextBox.Text, out num2))
            {
                MessageBox.Show($"Разница: {num1 - num2}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Поля заполнены некорректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearToolStripButton_Click(object sender, EventArgs e)
        {
            FirstNumTextBox.Clear();
            SecondNumTextBox.Clear();
        }
    }
}