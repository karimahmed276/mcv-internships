CREATE PROCEDURE AddDepartment
    @DepartmentName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Department (DepartmentName)
    VALUES (@DepartmentName);
END
GO
EXEC AddDepartment 'Software Engineering';



CREATE PROCEDURE AddStudent
    @StudentName NVARCHAR(100),
    @Age INT,
    @DepartmentID INT
AS
BEGIN
    INSERT INTO Student (StudentName, Age, DepartmentID)
    VALUES (@StudentName, @Age, @DepartmentID);
END
GO
EXEC AddStudent 'Karim',20,1;


CREATE PROCEDURE UpdateStudent
    @StudentID INT,
    @StudentName NVARCHAR(100),
    @Age INT,
    @DepartmentID INT
AS
BEGIN
    UPDATE Student
    SET
        StudentName = @StudentName,
        Age = @Age,
        DepartmentID = @DepartmentID
    WHERE StudentID = @StudentID;
END
GO
EXEC UpdateStudent 1,'Ahmed Mohamed',21,2;




CREATE PROCEDURE GetStudents
AS
BEGIN
    SELECT
        StudentName,
        DepartmentName,
        Age
    FROM Student
    INNER JOIN Department
        ON Student.DepartmentID = Department.DepartmentID
    WHERE Age BETWEEN 18 AND 22
    ORDER BY Age;
END
GO
EXEC GetStudents;





CREATE PROCEDURE DepartmentStatistics
AS
BEGIN
    SELECT
        DepartmentName,
        COUNT(StudentID) AS NumberOfStudents,
        AVG(Age) AS AverageAge,
        MAX(Age) AS OldestStudent,
        MIN(Age) AS YoungestStudent
    FROM Department
    LEFT JOIN Student
        ON Department.DepartmentID = Student.DepartmentID
    GROUP BY DepartmentName;
END
GO
EXEC DepartmentStatistics;




CREATE PROCEDURE SearchStudentDepartment
    @Search NVARCHAR(100)
AS
BEGIN
    SELECT
        StudentName,
        DepartmentName,
        Age
    FROM Student
    INNER JOIN Department
        ON Student.DepartmentID = Department.DepartmentID
    WHERE StudentName LIKE '%' + @Search + '%'
       OR DepartmentName LIKE '%' + @Search + '%';
END
GO
EXEC SearchStudentDepartment 'Ahmed';


CREATE PROCEDURE DepartmentHighestLowest
AS
BEGIN
    ;WITH DeptCount AS
    (
        SELECT
            DepartmentName,
            COUNT(StudentID) AS StudentCount
        FROM Department
        LEFT JOIN Student
            ON Department.DepartmentID = Student.DepartmentID
        GROUP BY DepartmentName
    )

    SELECT *
    FROM DeptCount
    WHERE StudentCount =
          (SELECT MAX(StudentCount) FROM DeptCount)

    UNION

    SELECT *
    FROM DeptCount
    WHERE StudentCount =
          (SELECT MIN(StudentCount) FROM DeptCount);
END
GO
EXEC DepartmentHighestLowest;
