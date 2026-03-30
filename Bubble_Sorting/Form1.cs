namespace Bubble_Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
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
            return arr;
        }

        private void btnSortAscending_Click(object sender, EventArgs e)
        {
            // Get input from user
            string input = txtInputArray.Text;
            int[] numbers = input
    .Split(',', StringSplitOptions.RemoveEmptyEntries) // Ignore empty entries
    .Select(s => int.Parse(s.Trim())) // Remove spaces before parsing
    .ToArray();
            // No changes required in this file for IDE0305: Collection initialization can be simplified.
            // The provided code does not contain any explicit collection initializations that can be simplified.
            // If you have other code files or specific lines where collections are being initialized (e.g., new List<int>(); followed by Add calls), please provide them for targeted fixes.
            // Sort using procedural Bubble Sort
            int[] sortedNumbers = BubbleSort(numbers);

            // Display result
            txtResultAscending.Text = string.Join(", ", sortedNumbers);
        }

        private void txtResultAscending_Click(object sender, EventArgs e)
        {

        }
    }
}
