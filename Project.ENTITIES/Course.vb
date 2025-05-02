Public Class Course
    Public Property CourseID As Integer
    Public Property CourseName As String
    Public Overridable Property Enrollments As ICollection(Of Enrollment)
End Class
