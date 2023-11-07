namespace MyCalculationForms;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        comboBox = new ComboBox();
        label1 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        labelAnswers = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(0, 168);
        button1.Name = "button1";
        button1.Size = new Size(112, 67);
        button1.TabIndex = 0;
        button1.Text = "Расчёт";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox
        // 
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        comboBox.FormattingEnabled = true;
        comboBox.Items.AddRange(new object[] { "Сложение" });
        comboBox.Location = new Point(6, 85);
        comboBox.Name = "comboBox";
        comboBox.Size = new Size(220, 32);
        comboBox.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(162, 32);
        label1.TabIndex = 2;
        label1.Text = "Введите число:";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(168, 0);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 32);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        textBox2.Location = new Point(168, 46);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 32);
        textBox2.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(0, 46);
        label2.Name = "label2";
        label2.Size = new Size(162, 36);
        label2.TabIndex = 5;
        label2.Text = "Введите число:";
        // 
        // label3
        // 
        label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(6, 120);
        label3.Name = "label3";
        label3.Size = new Size(77, 36);
        label3.TabIndex = 6;
        label3.Text = "Ответ:";
        // 
        // labelAnswers
        // 
        labelAnswers.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        labelAnswers.Location = new Point(89, 120);
        labelAnswers.Name = "labelAnswers";
        labelAnswers.Size = new Size(430, 36);
        labelAnswers.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 361);
        Controls.Add(labelAnswers);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(comboBox);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private ComboBox comboBox;
    private Label label1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label2;
    private Label label3;
    private Label labelAnswers;
}
