using System.Numerics;

namespace ExcelNumSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            // Code for opening CSV files
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files|*.csv|All Files|*.*",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                FileStream stream;
                // Check to make sure file isn't open on user's computer
                try
                {
                    stream = File.Open(selectedFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
                }
                catch (IOException)
                {
                    MessageBox.Show(text: "Please close the file before trying to read it.", caption: "File in Use");
                    return;
                }
                if (stream != null)
                {
                    stream.Close();
                }

                // Read all lines from the CSV file this loads full file into memory
                string[] lines = File.ReadAllLines(selectedFilePath);

                BigInteger totalSum = 0;

                foreach (string line in lines)
                {
                    // Split the line by the delimiter, apostrophes in this case
                    string[] values = line.Split('\'');

                    foreach (string value in values)
                    {
                        // Remove any leading or trailing spaces and parse the value
                        if (BigInteger.TryParse(value.Trim(), out BigInteger number))
                        {
                            totalSum += number;
                        }
                    }
                }

                // Get the final ten digits of the sum
                string finalTenDigits = totalSum.ToString().Substring(Math.Max(0, totalSum.ToString().Length - 10));

                // Display the sum in the text box
                outputBox.Text = $"Sum: {totalSum}\n";

                // Display each digit place
                for (int i = finalTenDigits.Length - 1; i >= 0; i--)
                {
                    string placeName = GetPlaceName(finalTenDigits.Length - 1 - i);
                    outputBox.AppendText($"\n{placeName}: {finalTenDigits[i]}");
                }
            }
        }

        // Helper method to get the name of the digit place
        private string GetPlaceName(int place)
        {
            switch (place)
            {
                case 0: return "Ones place";
                case 1: return "Tens place";
                case 2: return "Hundreds place";
                case 3: return "Thousands place";
                case 4: return "Ten Thousands place";
                case 5: return "Hundred Thousands place";
                case 6: return "Millions place";
                case 7: return "Ten Millions place";
                case 8: return "Hundred Millions place";
                case 9: return "Billions place";

                default: return $"Place {place}";
            }
        }
    }
}
