using Dapper;
using System.Data;

namespace Dapper_Demo.NET6;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly IDbConnection _connection;
    
    public DepartmentRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Department> GetAllDepartments()
    {
        return _connection.Query<Department>("SELECT * FROM departments;");
    }

    //public Department GetDepartment(int newID)
    //{
    //    return _connection.QuerySingle<Department>("SELECT * FROM departments WHERE DepartmentId = @ID;",
    //        new { ID = newID });
    //}

    //public void InsertDepartment(string newDepartmentName)
    //{
    //    _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
    //        new { departmentName = newDepartmentName});
    //}

    //public void UpdateDepartment(int newID, string newName)
    //{
    //    _connection.Execute("UPDATE departments SET Name = @name WHERE DepartmentID = @id;",
    //        new { name = newName, id = newID });
    //}

    //public void DeleteDepartment(int newID)
    //{
    //    _connection.Execute("DELETE FROM departments WHERE DepartmentID = @id;", new { id = newID });
    //}

    ////public void DeleteDepartments(int startPosition, int endPosition)
    ////{
    ////    _connection.Execute("DELETE FROM departments WHERE DepartmentID BETWEEN @start AND @end;", new { start = startPosition, end = endPosition });
    ////}


}
