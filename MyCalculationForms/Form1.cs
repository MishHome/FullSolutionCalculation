using MyCalculation;
using static MyCalculation.Calculation;

namespace MyCalculationForms;

public partial class Form1 : Form
{
    bool MyCheck { get; set; } = false;
    public Form1()
    {
        InitializeComponent();
        comboBox.DataSource = Enum.GetValues(typeof(MyActions));
        comboBox.SelectedIndex = 0;

        comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {

        try
        {
            IGetResult result;
            if (MyCheck)
            {
                result = new CalculationTwoNumbers();
            }
            else
            {
                result = new CalculationStrings();
            }

            labelAnswers.Text = result.GetResult(textBox1.Text, textBox2.Text, (MyActions)this.comboBox.SelectedItem);
        }
        catch (DivideByZeroException ex)
        {
            MessageBox.Show(ex.Message);
        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.StackTrace);
            //throw;
        }
    }
    
    private void comboBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex == 0)
        {
            MyCheck = true;
        }
        else
        {
            MyCheck = false;
        }
    }
}