using Jupiter.Business.Core.Interface;
using Jupiter.Business.Models;
using Jupiter.Utility.Utility;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Jupiter.Business.Core.Implementation
{
    public class EmergencyService : IEmergencyService
    {
        //public async Task<EmployeeNotification> ManageEmergency(EmergencyModel oEmergency)
        //{
        //    EmployeeNotification oEmployee= null;
        //    SqlParameter[] osqlParameter =
        //    {
        //        new SqlParameter("@Email", oLogin.Email),
        //        new SqlParameter("@Password", UtilityHelper.GenerateSHA256String(oLogin.Password))
        //    };

        //    var UserList = await _repository.GetBySP("usp_User_VerifyUserLogin", System.Data.CommandType.StoredProcedure, osqlParameter);

        //    if (UserList != null && UserList.Rows.Count > 0)
        //    {
        //        oUser = new UserSessionEntity();
        //        oUser.UserName = UserList.Rows[0]["UserName"].ToString();
        //        oUser.Email = UserList.Rows[0]["EmailAddress"].ToString();
        //        oUser.RoleName = UserList.Rows[0]["RoleName"].ToString();

        //        oUser.RoleId = Convert.ToInt32(UserList.Rows[0]["RoleId"]);
        //        oUser.UserId = Convert.ToInt32(UserList.Rows[0]["UserId"]);
        //    }
        //    return oUser;
        //}

        private static IConfiguration currentConfig;

        public static void SetConfig(IConfiguration configuration)
        {
            currentConfig = configuration;
        }

        public static NpgsqlConnection GetConnection
        {
            get
            {
                string connectionString = "Host=localhost;Username=postgres;Password=Ameeq@12345;Database=TestDB"; //currentConfig.GetConnectionString("PostgreDB");
                // Create a new connection for each query.
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                return connection;
            }
        }

        public async Task<bool> Create(Employee employee)
        {
            NpgsqlConnection connection = GetConnection;
            const string insertQuery =
                "INSERT INTO EMSTest.employee (first_name, last_name, job_title, salary, hire_date) " +
                "VALUES (@FirstName, @LastName, @JobTitle, @Salary, @HireDate)";

            using var cmd = connection.CreateCommand();
            cmd.CommandText = insertQuery;
            AddParameters(cmd, employee);
            await connection.OpenAsync();
            var rowAffected = await cmd.ExecuteNonQueryAsync();
            await connection.CloseAsync();
            return rowAffected > 0;

        }

        private static void AddParameters(NpgsqlCommand command, Employee employee)
        {
            var parameters = command.Parameters;

            parameters.AddWithValue("@Id", employee.Id);
            parameters.AddWithValue("@FirstName", employee.FirstName ?? string.Empty);
            parameters.AddWithValue("@LastName", employee.LastName ?? string.Empty);
            parameters.AddWithValue("@JobTitle", employee.JobTitle ?? string.Empty);
            parameters.AddWithValue("@Salary", employee.Salary);
            parameters.AddWithValue("@HireDate", employee.HireDate);
        }
    }
}
