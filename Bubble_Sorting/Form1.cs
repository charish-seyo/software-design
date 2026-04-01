namespace Bubble_Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++) // fixed
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get input
                string input = txtInput.Text;

                // 2. Convert to array
                int[] numbers = input
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray();

                // 3. Sort
                BubbleSort(numbers);

                // 4. Display result (FIXED)
                txtOutput.Text = string.Join(", ", numbers);
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter numbers separated by commas.");
            }
        }
    }
}

       
    

