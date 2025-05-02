Public Class Student
    Public Property StudentID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DateOfBirth As Date
    Public Overridable Property Enrollments As ICollection(Of Enrollment)
End Class
