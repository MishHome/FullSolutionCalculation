﻿namespace MyCalculationForms;

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
        comboBox1 = new ComboBox();
        label1 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(238, 284);
        button1.Name = "button1";
        button1.Size = new Size(112, 67);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(12, 61);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(33, 100);
        label1.Name = "label1";
        label1.Size = new Size(185, 36);
        label1.TabIndex = 2;
        label1.Text = "label1";
        label1.Click += label1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 150);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(12, 199);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 23);
        textBox2.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(750, 513);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private ComboBox comboBox1;
    private Label label1;
    private TextBox textBox1;
    private TextBox textBox2;
}
