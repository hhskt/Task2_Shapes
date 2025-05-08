using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AksenovaSecondTask
{
    partial class MainForm
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
            shapeTypeComboBox = new ComboBox();
            param1TextBox = new TextBox();
            param2TextBox = new TextBox();
            param3TextBox = new TextBox();
            param4TextBox = new TextBox();
            param1Label = new Label();
            param2Label = new Label();
            param3Label = new Label();
            param4Label = new Label();
            resultLabel = new Label();
            calculateButton = new Button();
            shapeLabel = new Label();
            SuspendLayout();
            // 
            // shapeTypeComboBox
            // 
            shapeTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            shapeTypeComboBox.FormattingEnabled = true;
            shapeTypeComboBox.Items.AddRange(new object[] { "Точка", "Линия", "Многоугольник", "Эллипс" });
            shapeTypeComboBox.Location = new Point(30, 52);
            shapeTypeComboBox.Name = "shapeTypeComboBox";
            shapeTypeComboBox.Size = new Size(371, 33);
            shapeTypeComboBox.TabIndex = 0;
            shapeTypeComboBox.SelectedIndexChanged += ShapeTypeComboBox_SelectedIndexChanged;
            // 
            // param1TextBox
            // 
            param1TextBox.Location = new Point(221, 92);
            param1TextBox.Name = "param1TextBox";
            param1TextBox.Size = new Size(180, 31);
            param1TextBox.TabIndex = 1;
            // 
            // param2TextBox
            // 
            param2TextBox.Location = new Point(221, 122);
            param2TextBox.Name = "param2TextBox";
            param2TextBox.Size = new Size(180, 31);
            param2TextBox.TabIndex = 2;
            // 
            // param3TextBox
            // 
            param3TextBox.Location = new Point(221, 152);
            param3TextBox.Name = "param3TextBox";
            param3TextBox.Size = new Size(180, 31);
            param3TextBox.TabIndex = 3;
            // 
            // param4TextBox
            // 
            param4TextBox.Location = new Point(221, 182);
            param4TextBox.Name = "param4TextBox";
            param4TextBox.Size = new Size(180, 31);
            param4TextBox.TabIndex = 4;
            // 
            // param1Label
            // 
            param1Label.AutoSize = true;
            param1Label.Location = new Point(30, 92);
            param1Label.Name = "param1Label";
            param1Label.Size = new Size(71, 25);
            param1Label.TabIndex = 5;
            param1Label.Text = "Param1";
            // 
            // param2Label
            // 
            param2Label.AutoSize = true;
            param2Label.Location = new Point(30, 122);
            param2Label.Name = "param2Label";
            param2Label.Size = new Size(71, 25);
            param2Label.TabIndex = 6;
            param2Label.Text = "Param2";
            // 
            // param3Label
            // 
            param3Label.AutoSize = true;
            param3Label.Location = new Point(30, 152);
            param3Label.Name = "param3Label";
            param3Label.Size = new Size(71, 25);
            param3Label.TabIndex = 7;
            param3Label.Text = "Param3";
            // 
            // param4Label
            // 
            param4Label.AutoSize = true;
            param4Label.Location = new Point(30, 182);
            param4Label.Name = "param4Label";
            param4Label.Size = new Size(71, 25);
            param4Label.TabIndex = 8;
            param4Label.Text = "Param4";
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(30, 262);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(371, 105);
            resultLabel.TabIndex = 10;
            resultLabel.Text = "Результат:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(30, 222);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(371, 34);
            calculateButton.TabIndex = 9;
            calculateButton.Text = "Вычислить";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += CalculateButton_Click;
            // 
            // shapeLabel
            // 
            shapeLabel.AutoSize = true;
            shapeLabel.Location = new Point(30, 24);
            shapeLabel.Name = "shapeLabel";
            shapeLabel.Size = new Size(108, 25);
            shapeLabel.TabIndex = 11;
            shapeLabel.Text = "Тип фигуры";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 386);
            Controls.Add(shapeLabel);
            Controls.Add(shapeTypeComboBox);
            Controls.Add(param1Label);
            Controls.Add(param1TextBox);
            Controls.Add(param2Label);
            Controls.Add(param2TextBox);
            Controls.Add(param3Label);
            Controls.Add(param3TextBox);
            Controls.Add(param4Label);
            Controls.Add(param4TextBox);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Aksenova Shapes";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private ComboBox shapeTypeComboBox;
        private TextBox param1TextBox;
        private TextBox param2TextBox;
        private TextBox param3TextBox;
        private TextBox param4TextBox;
        private Label param1Label;
        private Label param2Label;
        private Label param3Label;
        private Label param4Label;
        private Label resultLabel;
        private Button calculateButton;
        private Label shapeLabel;
    }
}
