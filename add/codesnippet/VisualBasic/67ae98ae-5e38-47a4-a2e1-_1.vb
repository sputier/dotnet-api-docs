Imports System
Imports System.Globalization
Imports Microsoft.VisualBasic

Public Class SamplesThaiBuddhistCalendar   
   
   Public Shared Sub Main()

      ' Creates and initializes a ThaiBuddhistCalendar.
      Dim myCal As New ThaiBuddhistCalendar()

      ' Creates a holder for the last day of the second month (February).
      Dim iLastDay As Integer

      ' Displays the header.
      Console.Write("YEAR" + ControlChars.Tab)
      Dim y As Integer
      For y = 2544 To 2548
         Console.Write(ControlChars.Tab + "{0}", y)
      Next y
      Console.WriteLine()

      ' Checks five years in the current era.
      Console.Write("CurrentEra:")
      For y = 2544 To 2548
         iLastDay = myCal.GetDaysInMonth(y, 2, ThaiBuddhistCalendar.CurrentEra)
         Console.Write(ControlChars.Tab + "{0}", myCal.IsLeapDay(y, 2, iLastDay, ThaiBuddhistCalendar.CurrentEra))
      Next y
      Console.WriteLine()

      ' Checks five years in each of the eras.
      Dim i As Integer
      For i = 0 To myCal.Eras.Length - 1
         Console.Write("Era {0}:" + ControlChars.Tab, myCal.Eras(i))
         For y = 2544 To 2548
            iLastDay = myCal.GetDaysInMonth(y, 2, myCal.Eras(i))
            Console.Write(ControlChars.Tab + "{0}", myCal.IsLeapDay(y, 2, iLastDay, myCal.Eras(i)))
         Next y
         Console.WriteLine()
      Next i

   End Sub 'Main 

End Class 'SamplesThaiBuddhistCalendar


'This code produces the following output.

'

'YEAR            2544    2545    2546    2547    2548

'CurrentEra:     False   False   False   True    False

'Era 1:          False   False   False   True    False
