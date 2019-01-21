Public Class MainForm

    Friend TotalChargesDecimal, TotalHoursDecimal, AverageDecimal As Decimal
    Friend TotalCharterInteger As Integer

    Dim RowInteger As Integer

    Const SIZE_22_Decimal As Decimal = 95D
    Const SIZE_24_Decimal As Decimal = 137D
    Const SIZE_30_Decimal As Decimal = 160D
    Const SIZE_32_Decimal As Decimal = 192D
    Const SIZE_36_Decimal As Decimal = 250D
    Const SIZE_38_Decimal As Decimal = 400D
    Const SIZE_45_Decimal As Decimal = 550D


    Private Sub OkButton_Click(sender As System.Object, e As System.EventArgs) Handles OkButton.Click

        Dim HoursDecimal, RateDecimal, CurrentChargeDecimal As Decimal
        Dim LengthInteger As Integer

        If PartyTextBox.Text <> "" Then
            Try
                HoursDecimal = Decimal.Parse(HoursTextBox.Text)

                If TypeComboBox.SelectedIndex <> -1 Then
                    If TypeComboBox.SelectedIndex <> -1 Then
                        LengthInteger = Integer.Parse(LengthComboBox.Text)
                        Select Case LengthInteger
                            Case 22
                                RateDecimal = SIZE_22_Decimal
                            Case 24
                                RateDecimal = SIZE_24_Decimal
                            Case 30
                                RateDecimal = SIZE_30_Decimal
                            Case 32
                                RateDecimal = SIZE_32_Decimal
                            Case 36
                                RateDecimal = SIZE_36_Decimal
                            Case 38
                                RateDecimal = SIZE_38_Decimal
                            Case 45
                                RateDecimal = SIZE_45_Decimal
                        End Select
                    Else
                        MessageBox.Show("Please select the yacht type.", _
                            "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If
                Else
                    MessageBox.Show("Please select the yacht length.", _
                        "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                   

                End If
            Catch
                MessageBox.Show("Please enter the number of hours the yacht will be chartered.", _
                "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With HoursTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Else
            MessageBox.Show("Please enter the name of the responsible party", "Input Needed", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With PartyTextBox
                .Focus()
                .SelectAll()
            End With
        End If

        'Add to totals
        TotalCharterInteger += 1
        CurrentChargeDecimal = RateDecimal * HoursDecimal

        TotalChargesDecimal += CurrentChargeDecimal
        TotalHoursDecimal += HoursDecimal

        AverageDecimal = (TotalHoursDecimal / TotalCharterInteger)

        TotalTextBox.Text = CurrentChargeDecimal.ToString("C")
    End Sub




    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click, ClearForNextCharterToolStripMenuItem.Click

        PartyTextBox.Clear()
        HoursTextBox.Clear()
        TotalTextBox.Clear()


    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click

        'Prints Summary
        If TotalCharterInteger > 0 Then
            PrintPreviewDialog.Document = PrintDocumentTwo
            PrintPreviewDialog.ShowDialog()
        Else
            MessageBox.Show("There is no summary information to print", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub



    Private Sub PrintYachtTypesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintYachtTypesToolStripMenuItem.Click


        'Prints Yacht Types
        If TypeComboBox.Items.Count > 0 Then
            PrintPreviewDialog.Document = PrintDocumentOne
            PrintPreviewDialog.ShowDialog()
        Else
            MessageBox.Show("There are no yachts in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        AboutBox.ShowDialog()

    End Sub

    
    Private Sub PrintDocumentOne_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentOne.PrintPage

        Dim PrintFont As New Font("Arial", 12)
        Dim HeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String


        PrintLineString = "Programmed by: Kris Trinidad"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, 100, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += HeightSingle * 2

        'Print the heading
        Using HeadingFont As New Font("Arial", 14, FontStyle.Bold)

            'Print a heading and then the yacht list
            PrintLineString = "Yacht Types"
            e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            PrintLineString = "_________________"
            e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += HeightSingle
        End Using

        'Loop through the yacht list and print each item in the list

        With TypeComboBox
            Do While RowInteger < .Items.Count

                PrintLineString = TypeComboBox.Items(RowInteger).ToString()

                e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)

                VerticalPrintLocationSingle += HeightSingle

            Loop

            RowInteger = 0
        End With

    End Sub



    Private Sub PrintDocumentTwo_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentTwo.PrintPage

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14)
        Dim HeightSingle As Single = printFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top

        e.Graphics.DrawString("Summary of Yacht Charters", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += HeightSingle * 2

        e.Graphics.DrawString("Number of Charters: " & TotalCharterInteger, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += HeightSingle

        e.Graphics.DrawString("Total Revenue: " & TotalChargesDecimal.ToString("C"), PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += HeightSingle

        e.Graphics.DrawString("Average Hours Chartered: " & AverageDecimal.ToString("N1"), PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
    End Sub


    Private Sub DisplayCountOfYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisplayCountOfYachtTypeToolStripMenuItem.Click

        MessageBox.Show("The number of yacht types is: " & TypeComboBox.Items.Count, "Yacht Type Count", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click

        With TypeComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("Select a yacht type to remove", "No Selection Made", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddYachtTypeToolStripMenuItem.Click

        Dim AddBoolean As Boolean
        Dim YachtInteger As Integer

        With TypeComboBox
            If .Text <> "" Then
                Do Until AddBoolean Or YachtInteger = .Items.Count
                    If .Text = .Items(YachtInteger).ToString Then
                        AddBoolean = True
                        Exit Do
                    Else
                        YachtInteger += 1
                    End If
                Loop


                If AddBoolean Then
                    MessageBox.Show("Yacht type already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    'If it's not in the list, add it.
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Please enter a Yacht type to add.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With

    End Sub
End Class
