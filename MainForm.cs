using AksenovaSecondTask.Models;
using System;
namespace AksenovaSecondTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            shapeTypeComboBox.SelectedIndex = 0;
        }
        private void ShapeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (shapeTypeComboBox.SelectedItem.ToString())
            {
                case "Точка":
                    ConfigureFields("X:", true, "Y:", true, null, false, null, false);
                    break;
                case "Линия":
                    ConfigureFields("Начальная X:", true, "Начальная Y:", true, "Конечная X:", true, "Конечная Y:", true);
                    break;
                case "Многоугольник":
                    ConfigureFields("Точки (x1:y1,x2:y2,...)", true, null, false, null, false, null, false);
                    break;
                case "Эллипс":
                    ConfigureFields("Центр X:", true, "Центр Y:", true, "Радиус X:", true, "Радиус Y:", true);
                    break;
            }
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Shape shape = null;
            try
            {
                // Создание соответствующей фигуры на основе входных данных
                switch (shapeTypeComboBox.SelectedItem.ToString())
                {
                    case "Точка":
                        var x = double.Parse(param1TextBox.Text);
                        var y = double.Parse(param2TextBox.Text);
                        shape = new Models.Point(x, y);
                        break;
                    case "Линия":
                        var startX = double.Parse(param1TextBox.Text);
                        var startY = double.Parse(param2TextBox.Text);
                        var endX = double.Parse(param3TextBox.Text);
                        var endY = double.Parse(param4TextBox.Text);
                        shape = new Line(startX, startY, endX, endY);
                        break;
                    case "Многоугольник":
                        var points = param1TextBox.Text.Split(',');
                        var vertices = new List<(double X, double Y)>();
                        foreach (string point in points)
                        {
                            var coords = point.Split(':');
                            vertices.Add((double.Parse(coords[0]), double.Parse(coords[1])));
                        }
                        shape = new Polygon(vertices);
                        break;
                    case "Эллипс":
                        var centerX = double.Parse(param1TextBox.Text);
                        var centerY = double.Parse(param2TextBox.Text);
                        var radiusX = double.Parse(param3TextBox.Text);
                        var radiusY = double.Parse(param4TextBox.Text);
                        shape = new Ellipse(centerX, centerY, radiusX, radiusY);
                        break;
                }
                if (shape != null)
                {
                    var boundingBox = shape.GetBoundingBox();
                    var area = shape.GetArea();
                    resultLabel.Text = $"Квадрат (x0,y0,ширина,высота): ({boundingBox.X:0.##}, {boundingBox.Y:0.##}, {boundingBox.Width:0.##}, {boundingBox.Height:0.##})"
                                     + $"\nПлощадь: {area:0.##}"
                                     + $"\nЦентр: ({shape.CenterX:0.##}, {shape.CenterY:0.##})";
                }
            }
            catch
            {
                resultLabel.Text = "Ошибка: данные заполнены некорректно!";
            }
        }
        // Метод для настройки видимости и текста полей ввода
        private void ConfigureFields(string param1LabelText, bool param1Visible,
                                     string param2LabelText, bool param2Visible,
                                     string param3LabelText, bool param3Visible,
                                     string param4LabelText, bool param4Visible)
        {
            param1Label.Text = param1LabelText ?? "";
            param1Label.Visible = param1Visible;
            param1TextBox.Text = "";
            param1TextBox.Visible = param1Visible;
            param2Label.Text = param2LabelText ?? "";
            param2Label.Visible = param2Visible;
            param2TextBox.Text = "";
            param2TextBox.Visible = param2Visible;
            param3Label.Text = param3LabelText ?? "";
            param3Label.Visible = param3Visible;
            param3TextBox.Text = "";
            param3TextBox.Visible = param3Visible;
            param4Label.Text = param4LabelText ?? "";
            param4Label.Visible = param4Visible;
            param4TextBox.Text = "";
            param4TextBox.Visible = param4Visible;
        }
    }
}
