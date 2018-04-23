using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Shape;
//...

namespace docShapes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Arrow.
            shape.Shape = new ShapeArrow();

            // Adjust the Arrow shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;
            
            // Adjust the Arrow shape's specific properties.
            ((ShapeArrow)shape.Shape).ArrowHeight = 50;
            ((ShapeArrow)shape.Shape).ArrowWidth = 50;
            ((ShapeArrow)shape.Shape).Fillet = 20;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Rectangle.
            shape.Shape = new ShapeRectangle();

            // Adjust the Rectangle shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;

            // Adjust the Rectangle shape's specific properties.
            ((ShapeRectangle)shape.Shape).Fillet = 20;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button3_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Ellipse.
            shape.Shape = new ShapeEllipse();

            // Adjust the Ellipse shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button4_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Polygon.
            shape.Shape = new ShapePolygon();

            // Adjust the Polygon shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;

            // Adjust the Polygon shape's specific properties.
            ((ShapePolygon)shape.Shape).NumberOfSides = 7;
            ((ShapePolygon)shape.Shape).Fillet = 5;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button5_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Star.
            shape.Shape = new ShapeStar();

            // Adjust the Star shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;

            // Adjust the Star shape's specific properties.
            ((ShapeStar)shape.Shape).Concavity = 50;
            ((ShapeStar)shape.Shape).StarPointCount = 7;
            ((ShapeStar)shape.Shape).Fillet = 5;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button6_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Line.
            shape.Shape = new ShapeLine();

            // Adjust the Line shape's main properties.
            shape.Angle = 45;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.Stretch = false;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button7_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Cross.
            shape.Shape = new ShapeCross();

            // Adjust the Cross shape's main properties.
            shape.Angle = 90;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.FillColor = Color.Beige;
            shape.Stretch = false;

            // Adjust the Cross shape's specific properties.
            ((ShapeCross)shape.Shape).HorizontalLineWidth = 50;
            ((ShapeCross)shape.Shape).VerticalLineWidth = 50;
            ((ShapeCross)shape.Shape).Fillet = 20;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button8_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Bracket.
            shape.Shape = new ShapeBracket();

            // Adjust the Bracket shape's main properties.
            shape.Angle = 180;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.Stretch = false;

            // Adjust the Bracket shape's specific properties.
            ((ShapeBracket)shape.Shape).TipLength = 20;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }

        private void button9_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();

            // Create a shape control.
            XRShape shape = new XRShape();

            // Set the shape's type to Brace.
            shape.Shape = new ShapeBrace();

            // Adjust the Brace shape's main properties.
            shape.Angle = 180;
            shape.Width = 200;
            shape.Height = 200;
            shape.ForeColor = Color.Brown;
            shape.Stretch = false;

            // Adjust the Brace shape's specific properties.
            ((ShapeBrace)shape.Shape).TipLength = 20;
            ((ShapeBrace)shape.Shape).TailLength = 20;
            ((ShapeBrace)shape.Shape).Fillet = 50;

            // Preview the report.
            report.Detail.Controls.Add(shape);
            report.ShowPreview();
        }
    }
}