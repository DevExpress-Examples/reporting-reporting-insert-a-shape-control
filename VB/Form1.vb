Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Shape
'...

Namespace docShapes
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Arrow.
            shape.Shape = New ShapeArrow()

            ' Adjust the Arrow shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Adjust the Arrow shape's specific properties.
            CType(shape.Shape, ShapeArrow).ArrowHeight = 50
            CType(shape.Shape, ShapeArrow).ArrowWidth = 50
            CType(shape.Shape, ShapeArrow).Fillet = 20

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button2.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Rectangle.
            shape.Shape = New ShapeRectangle()

            ' Adjust the Rectangle shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Adjust the Rectangle shape's specific properties.
            CType(shape.Shape, ShapeRectangle).Fillet = 20

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button3.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Ellipse.
            shape.Shape = New ShapeEllipse()

            ' Adjust the Ellipse shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button4.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Polygon.
            shape.Shape = New ShapePolygon()

            ' Adjust the Polygon shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Adjust the Polygon shape's specific properties.
            CType(shape.Shape, ShapePolygon).NumberOfSides = 7
            CType(shape.Shape, ShapePolygon).Fillet = 5

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button5.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Star.
            shape.Shape = New ShapeStar()

            ' Adjust the Star shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Adjust the Star shape's specific properties.
            CType(shape.Shape, ShapeStar).Concavity = 50
            CType(shape.Shape, ShapeStar).StarPointCount = 7
            CType(shape.Shape, ShapeStar).Fillet = 5

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button6.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Line.
            shape.Shape = New ShapeLine()

            ' Adjust the Line shape's main properties.
            shape.Angle = 45
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.Stretch = False

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button7.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Cross.
            shape.Shape = New ShapeCross()

            ' Adjust the Cross shape's main properties.
            shape.Angle = 90
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.FillColor = Color.Beige
            shape.Stretch = False

            ' Adjust the Cross shape's specific properties.
            CType(shape.Shape, ShapeCross).HorizontalLineWidth = 50
            CType(shape.Shape, ShapeCross).VerticalLineWidth = 50
            CType(shape.Shape, ShapeCross).Fillet = 20

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button8.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Bracket.
            shape.Shape = New ShapeBracket()

            ' Adjust the Bracket shape's main properties.
            shape.Angle = 180
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.Stretch = False

            ' Adjust the Bracket shape's specific properties.
            CType(shape.Shape, ShapeBracket).TipLength = 20

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub

        Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button9.Click
            Dim report As New XtraReport1()

            ' Create a shape control.
            Dim shape As New XRShape()

            ' Set the shape's type to Brace.
            shape.Shape = New ShapeBrace()

            ' Adjust the Brace shape's main properties.
            shape.Angle = 180
            shape.Width = 200
            shape.Height = 200
            shape.ForeColor = Color.Brown
            shape.Stretch = False

            ' Adjust the Brace shape's specific properties.
            CType(shape.Shape, ShapeBrace).TipLength = 20
            CType(shape.Shape, ShapeBrace).TailLength = 20
            CType(shape.Shape, ShapeBrace).Fillet = 50

            ' Preview the report.
            report.Detail.Controls.Add(shape)
            report.ShowPreview()
        End Sub
    End Class
End Namespace