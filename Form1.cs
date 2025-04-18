
namespace finance_tracker;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        string filePath = "data/category.txt";
        List<string> items = new List<string>();

        if (File.Exists(filePath))
        {
            items = File.ReadAllLines(filePath).ToList();
        }
        else
        {
            MessageBox.Show($"File '{filePath}' not found. Please create the file and add categories.");
            return;
        }

        List<CheckBox> checkBoxes = CheckBoxFactory.CreateCheckBoxList(items, new Point(20, 20), 30);
        foreach (var checkBox in checkBoxes)
        {
            this.Controls.Add(checkBox);
        }
    }
}