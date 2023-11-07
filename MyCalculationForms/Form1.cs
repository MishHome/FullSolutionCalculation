using MyCalculation;
using static MyCalculation.Calculation;

namespace MyCalculationForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        comboBox.DataSource = Enum.GetValues(typeof(MyActions));
        comboBox.SelectedIndex = 0;
    }


    private void button1_Click(object sender, EventArgs e)
    {
        var selAction = (MyActions)this.comboBox.SelectedItem;
        var calc = new CalculationTwoNumbers();
        if (calc.CheckStringToValue(textBox1.Text) && calc.CheckStringToValue(textBox2.Text))
        {
            calc.A = decimal.Parse(textBox1.Text);
            calc.B= decimal.Parse(textBox2.Text);
        }
        calc.SelectedAction(selAction);

        labelAnswers.Text = calc.Result.ToString();
    }


}

