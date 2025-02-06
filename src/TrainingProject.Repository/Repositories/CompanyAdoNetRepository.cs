using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;

namespace TrainingProject.Repositories.Repositories
{
    public class CompanyAdoNetRepository
    {
        private string _connectionString = "";
        public async Task<Company> CreateAsync(Company company)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = @"INSERT INTO Companies (Id, Name, Street, PostalCode, City, Country, PhoneNumber, Email, Website, IsActive, InsertedAt, InsertedBy, IsDeleted)
                          VALUES (@Id, @Name, @Street, @PostalCode, @City, @Country, @PhoneNumber, @Email, @Website, @IsActive, @InsertedAt, @InsertedBy, @IsDeleted)";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", company.Id);
            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@Street", company.Street);
            command.Parameters.AddWithValue("@PostalCode", company.PostalCode);
            command.Parameters.AddWithValue("@City", company.City);
            command.Parameters.AddWithValue("@Country", company.Country);
            command.Parameters.AddWithValue("@PhoneNumber", company.PhoneNumber);
            command.Parameters.AddWithValue("@Email", company.Email);
            command.Parameters.AddWithValue("@Website", company.Website ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", company.IsActive);
            command.Parameters.AddWithValue("@InsertedAt", company.InsertedAt);
            command.Parameters.AddWithValue("@InsertedBy", company.InsertedBy ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@IsDeleted", company.IsDeleted);

            await command.ExecuteNonQueryAsync();
            return company;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = "UPDATE Companies SET IsDeleted = 1, DeletedAt = @DeletedAt WHERE Id = @Id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@DeletedAt", DateTime.UtcNow);

            var rowsAffected = await command.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }

        public async Task<Company> SelectById(Guid id)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = "SELECT * FROM Companies WHERE Id = @Id AND IsDeleted = 0";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return MapToCompany(reader);
            }
            return null;
        }

        public async Task<Company> UpdateAsync(Company company)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = @"UPDATE Companies SET 
                            Name = @Name, Street = @Street, PostalCode = @PostalCode, 
                            City = @City, Country = @Country, PhoneNumber = @PhoneNumber, 
                            Email = @Email, Website = @Website, IsActive = @IsActive, 
                            ChangedAt = @ChangedAt, ChangedBy = @ChangedBy
                          WHERE Id = @Id AND IsDeleted = 0";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", company.Id);
            command.Parameters.AddWithValue("@Name", company.Name);
            command.Parameters.AddWithValue("@Street", company.Street);
            command.Parameters.AddWithValue("@PostalCode", company.PostalCode);
            command.Parameters.AddWithValue("@City", company.City);
            command.Parameters.AddWithValue("@Country", company.Country);
            command.Parameters.AddWithValue("@PhoneNumber", company.PhoneNumber);
            command.Parameters.AddWithValue("@Email", company.Email);
            command.Parameters.AddWithValue("@Website", company.Website ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", company.IsActive);
            command.Parameters.AddWithValue("@ChangedAt", DateTime.UtcNow);
            command.Parameters.AddWithValue("@ChangedBy", company.ChangedBy ?? (object)DBNull.Value);

            await command.ExecuteNonQueryAsync();
            return company;
        }

        public async Task<List<Company>> SelectAll()
        {
            var companies = new List<Company>();

            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var query = "SELECT * FROM Companies WHERE IsDeleted = 0";

            using var command = new SqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                companies.Add(MapToCompany(reader));
            }

            return companies;
        }

        private static Company MapToCompany(SqlDataReader reader)
        {
            return new Company
            {
                Id = reader.GetGuid(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Street = reader.GetString(reader.GetOrdinal("Street")),
                PostalCode = reader.GetString(reader.GetOrdinal("PostalCode")),
                City = reader.GetString(reader.GetOrdinal("City")),
                Country = reader.GetString(reader.GetOrdinal("Country")),
                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Website = reader.IsDBNull(reader.GetOrdinal("Website")) ? null : reader.GetString(reader.GetOrdinal("Website")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                ChangedAt = reader.IsDBNull(reader.GetOrdinal("ChangedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("ChangedAt")),
                ChangedBy = reader.IsDBNull(reader.GetOrdinal("ChangedBy")) ? null : reader.GetString(reader.GetOrdinal("ChangedBy")),
                InsertedAt = reader.GetDateTime(reader.GetOrdinal("InsertedAt")),
                InsertedBy = reader.IsDBNull(reader.GetOrdinal("InsertedBy")) ? null : reader.GetString(reader.GetOrdinal("InsertedBy")),
                DeletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? null : reader.GetDateTime(reader.GetOrdinal("DeletedAt")),
                DeletedBy = reader.IsDBNull(reader.GetOrdinal("DeletedBy")) ? null : reader.GetString(reader.GetOrdinal("DeletedBy")),
                IsDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted"))
            };
        }
    }
}
