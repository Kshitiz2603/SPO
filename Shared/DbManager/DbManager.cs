using System;
using System.ComponentModel;
using Data;
using Core;
using Interfaces;

namespace Shared
{
    public class DbManager : IDbManager
    {
        // Implementing the Initialize method
        public IDataAccess PortalDb { get; set; }
        public DbManager(){
            Init();
        }

        public void Init()
        {
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string

            PortalDb = new DapperDataAccess(connectionString, 1000);

            //portalDb = new Dappe
        }
    }
}
