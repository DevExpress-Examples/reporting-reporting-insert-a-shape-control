Namespace docShapes

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.button6 = New System.Windows.Forms.Button()
            Me.button7 = New System.Windows.Forms.Button()
            Me.button8 = New System.Windows.Forms.Button()
            Me.button9 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(41, 23)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(87, 35)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Arrow"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(134, 23)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(87, 35)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Rectangle"
            Me.button2.UseVisualStyleBackColor = True
            AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click)
            ' 
            ' button3
            ' 
            Me.button3.Location = New System.Drawing.Point(227, 23)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(87, 35)
            Me.button3.TabIndex = 1
            Me.button3.Text = "Ellipse"
            Me.button3.UseVisualStyleBackColor = True
            AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button3_Click)
            ' 
            ' button4
            ' 
            Me.button4.Location = New System.Drawing.Point(41, 85)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(87, 35)
            Me.button4.TabIndex = 1
            Me.button4.Text = "Polygon"
            Me.button4.UseVisualStyleBackColor = True
            AddHandler Me.button4.Click, New System.EventHandler(AddressOf Me.button4_Click)
            ' 
            ' button5
            ' 
            Me.button5.Location = New System.Drawing.Point(134, 85)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(87, 35)
            Me.button5.TabIndex = 1
            Me.button5.Text = "Star"
            Me.button5.UseVisualStyleBackColor = True
            AddHandler Me.button5.Click, New System.EventHandler(AddressOf Me.button5_Click)
            ' 
            ' button6
            ' 
            Me.button6.Location = New System.Drawing.Point(227, 85)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(87, 35)
            Me.button6.TabIndex = 0
            Me.button6.Text = "Line"
            Me.button6.UseVisualStyleBackColor = True
            AddHandler Me.button6.Click, New System.EventHandler(AddressOf Me.button6_Click)
            ' 
            ' button7
            ' 
            Me.button7.Location = New System.Drawing.Point(41, 147)
            Me.button7.Name = "button7"
            Me.button7.Size = New System.Drawing.Size(87, 35)
            Me.button7.TabIndex = 1
            Me.button7.Text = "Cross"
            Me.button7.UseVisualStyleBackColor = True
            AddHandler Me.button7.Click, New System.EventHandler(AddressOf Me.button7_Click)
            ' 
            ' button8
            ' 
            Me.button8.Location = New System.Drawing.Point(134, 147)
            Me.button8.Name = "button8"
            Me.button8.Size = New System.Drawing.Size(87, 35)
            Me.button8.TabIndex = 1
            Me.button8.Text = "Bracket"
            Me.button8.UseVisualStyleBackColor = True
            AddHandler Me.button8.Click, New System.EventHandler(AddressOf Me.button8_Click)
            ' 
            ' button9
            ' 
            Me.button9.Location = New System.Drawing.Point(227, 147)
            Me.button9.Name = "button9"
            Me.button9.Size = New System.Drawing.Size(87, 35)
            Me.button9.TabIndex = 1
            Me.button9.Text = "Brace"
            Me.button9.UseVisualStyleBackColor = True
            AddHandler Me.button9.Click, New System.EventHandler(AddressOf Me.button9_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(363, 212)
            Me.Controls.Add(Me.button5)
            Me.Controls.Add(Me.button9)
            Me.Controls.Add(Me.button8)
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button7)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.button6)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private button1 As System.Windows.Forms.Button

        Private button2 As System.Windows.Forms.Button

        Private button3 As System.Windows.Forms.Button

        Private button4 As System.Windows.Forms.Button

        Private button5 As System.Windows.Forms.Button

        Private button6 As System.Windows.Forms.Button

        Private button7 As System.Windows.Forms.Button

        Private button8 As System.Windows.Forms.Button

        Private button9 As System.Windows.Forms.Button
    End Class
End Namespace
