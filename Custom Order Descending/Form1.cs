namespace Custom_Order_Descending
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            try
            {
      
                string input = txtInput.Text;
                int[] numbers = input
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray();

                Sorter sorter = new Sorter(numbers);
                sorter.SortDescending();
                int[] result = sorter.GetSortedArray();
                txtOutput.Text = string.Join(", ", result);
            }
            catch
            {
                MessageBox.Show("Invalid input! Use comma-separated numbers.");
            }
        }
    }
}
