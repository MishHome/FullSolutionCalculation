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
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(232, 173);
        button1.Name = "button1";
        button1.Size = new Size(112, 67);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox
        // 
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
        label1.Size = new Size(226, 32);
        label1.TabIndex = 2;
        label1.Text = "Введите целое число:";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(232, 4);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 32);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        textBox2.Location = new Point(232, 50);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 32);
        textBox2.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(0, 46);
        label2.Name = "label2";
        label2.Size = new Size(226, 36);
        label2.TabIndex = 5;
        label2.Text = "Введите целое число:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 361);
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
}
