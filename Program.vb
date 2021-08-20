Imports System

Module Program
    Sub Main()
        'Vamos desenvolver um sistema para realizar um cálculo de média de duas notas
        Dim nota1, nota2, nota3, nota4, media As Double
        Dim aluno As String

        Console.WriteLine("Digite o nome do aluno: ")
        aluno = Console.ReadLine()

        Console.WriteLine("Digite a primeira nota do aluno: ")
        nota1 = Console.ReadLine()

        Console.WriteLine("Digite a segunda nota do aluno: ")
        nota2 = Console.ReadLine()

        Console.WriteLine("Digite a terceira nota do aluno: ")
        nota3 = Console.ReadLine()

        Console.WriteLine("Digite a quarta nota do aluno: ")
        nota4 = Console.ReadLine()

        media = (nota1 + nota2 + nota3 + nota4) / 4

        Console.WriteLine("A média do aluno " & aluno & " é igual a " & media)

    End Sub
End Module
