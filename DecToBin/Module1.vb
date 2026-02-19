Module Module1

    Sub Main()
        Dim uNumber As UInteger
        Console.WriteLine("Input an unsigned integer number")
        Dim bIsRightNumber = (UInteger.TryParse(Console.ReadLine(), uNumber)) AndAlso
                     (uNumber <= UInteger.MaxValue)
        If (Not bIsRightNumber) Then
            Console.WriteLine("Invalid number format or number too big")
            Console.Read()
            Return
        End If
        Dim strBinNum = ""
        Dim uTempVal = uNumber
        Do While (uTempVal > 0)
            strBinNum = CInt(uTempVal Mod 2).ToString() + strBinNum
            uTempVal /= 2
        Loop
        If (strBinNum.Length = 0) Then
            strBinNum = "0"
        End If
        Console.WriteLine _
        (
            "The binary equavalent of the decimal number {0} is: {1}",
            uNumber, strBinNum
        )
        Console.Read()
    End Sub

End Module
