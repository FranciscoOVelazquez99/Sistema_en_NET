Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim graphics As Graphics = pevent.Graphics

        ' Activa el antialiasing para mejorar la calidad de los bordes
        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim borderRadius As Integer = 40 ' Ajusta el radio de las esquinas

        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90)
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90)
            path.AddArc(rect.X + rect.Width - borderRadius, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 0, 90)
            path.AddArc(rect.X, rect.Y + rect.Height - borderRadius, borderRadius, borderRadius, 90, 90)
            path.CloseFigure()

            ' Aplica la región redondeada al botón
            Me.Region = New Region(path)

            ' Relleno del botón con color de fondo
            Using brush As New SolidBrush(Me.BackColor)
                graphics.FillPath(brush, path)
            End Using

            ' Dibujar el borde con un pincel suave
            Using pen As New Pen(Me.ForeColor, 1.6F)
                graphics.DrawPath(pen, path)
            End Using
        End Using

        ' Dibuja el texto del botón con suavizado
        TextRenderer.DrawText(graphics, Me.Text, Me.Font, rect, Me.ForeColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub
End Class