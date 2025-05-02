Imports Microsoft.EntityFrameworkCore
Imports Microsoft.VisualBasic.Devices
Imports Project.ENTITIES
Imports System.Data.Entity

Public Class StudentDbContext

    Public Class StudentDbContext
        Inherits DbContext

        Private Const V As String = "name=NTIERSTUDENT"

        Public Sub New(V As String)
            MyBase.New()
        End Sub

        Public Property Students As DbSet(Of Student)
        Public Property Courses As DbSet(Of Course)
        Public Property Enrollments As DbSet(Of Enrollment)
    End Class
End Class
