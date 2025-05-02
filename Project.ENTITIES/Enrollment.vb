Public Class Enrollment
    Public Property EnrollmentID As Integer
    Public Property StudentID As Integer
    Public Property CourseID As Integer
    Public Property EnrollmentDate As Date

    Public Overridable Property Student As Student
    Public Overridable Property Course As Course
End Class
