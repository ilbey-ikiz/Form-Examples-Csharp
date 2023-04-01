using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi
{
    public static class Helper
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                else if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.Items.Clear();
                }
                else if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Name == "Küçük")
                        radioButton.Checked = true;
                    else radioButton.Checked = false;
                }
                else if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    numericUpDown.Value = 0;
                }
                else if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                    foreach (var checkBox in flowLayoutPanel.Controls)
                    {
                        ((CheckBox)checkBox).Checked= false;
                    }
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Temizle(groupBox.Controls);
                }
            }

        }
    }
}
