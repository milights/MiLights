Imports System

Module Program

    Dim zone As Integer

    Sub Main(args As String())

        Dim k As New MiLight

        For i As Integer = 0 To args.Length - 1
            'Console.WriteLine("Arg: " & i & " is " & args(i))
            ' For Each substring In split(args(i))
            'Console.WriteLine(substring)
            'Next
            'Console.WriteLine(split(args(i))(0))
            'Console.WriteLine(split(args(i))(1))

            If split(args(i))(0).ToString.ToLower = "zone" Then
                k.Zone = split(args(i))(1)
            End If

            If split(args(i))(0).ToString.ToLower = "color" Then
                k.Color = split(args(i))(1)
            End If

            If split(args(i))(0).ToString.ToLower = "brightness" Then
                k.Brightness = split(args(i))(1)
            End If

            If split(args(i))(0).ToString.ToLower = "saturation" Then
                k.Saturation = split(args(i))(1)
            End If

        Next

        Console.WriteLine("Zone : " & k.Zone)
        Console.WriteLine("Color : " & k.Color)
        Console.WriteLine("Brightness : " & k.Brightness)
        Console.WriteLine("Saturation : " & k.Saturation)

        AddHandler k.ColorChanged, AddressOf Colorchanged


        k.change()


        ' Dim k As New MiLight(0, 100, 100, 20)

        Console.ReadKey()

    End Sub

    Private Sub Colorchanged()

        Console.WriteLine("Color Changed Succesfully")

    End Sub

    Function split(value As String)

        Dim delimiter As Char = "="c
        Dim substrings() As String = value.Split(delimiter)
        'For Each substring In substrings
        'Console.WriteLine(substring)
        'Next
        Return substrings
    End Function


End Module
