using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;

namespace Mailing.Model
{
    public partial class MyEmail
    {
        
        public int id { get; set; }
        public string email { get; set; }

    }
    public class Email_rep
    {

        string connectionString = $"Data Source=" + Directory.GetCurrentDirectory() + @"\Emails.sqlite3;"; 
       // string connectionString = "Data Source=Emails.sqlite3";
        public IEnumerable<MyEmail> GetColl()
        {
            List<MyEmail> coll = new List<MyEmail>();
            using (IDbConnection db = new SqliteConnection(connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        coll = db.Query<MyEmail>("SELECT * FROM email", transaction).ToList();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                db.Close();
            }
            return coll;
        }

       

        public void Create(MyEmail value)
        {
            using (IDbConnection db = new SqliteConnection(connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "INSERT INTO  email (email)" +
                                 "VALUES(@email);";
                        db.Execute(sqlQuery,
                           new
                           {
                               email = value.email                             
                           },
                           transaction);
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                db.Close();
            }
        }      
        public void Delete(MyEmail value)
        {
            using (IDbConnection db = new SqliteConnection(connectionString))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "DELETE FROM  email WHERE email = @email";
                        db.Execute(sqlQuery, new { value.email }, transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                db.Close();
            }
        }


    }

}

