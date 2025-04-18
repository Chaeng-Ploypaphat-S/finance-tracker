
namespace finance_tracker
{
    public static class CheckBoxFactory
    {
        public static CheckBox CreateCheckBox(string text, Point location)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Text = text;
            checkBox.Location = location;
            checkBox.AutoSize = true; 

            checkBox.CheckedChanged += (sender, e) =>
            {
                if (checkBox.Checked)
                {
                    MessageBox.Show($"{text} Enabled!");
                }
                else
                {
                    MessageBox.Show($"{text} Disabled!");
                }
            };

            return checkBox;
        }

        public static List<CheckBox> CreateCheckBoxList(List<string> items, Point startLocation, int verticalSpacing)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            int yPosition = startLocation.Y;

            foreach (var item in items)
            {
                // Create a new CheckBox for each item
                CheckBox checkBox = CreateCheckBox(item, new Point(startLocation.X, yPosition));
                checkBoxes.Add(checkBox);

                // Update the Y position for the next CheckBox
                yPosition += verticalSpacing;
            }

            return checkBoxes;
        }
    }
}