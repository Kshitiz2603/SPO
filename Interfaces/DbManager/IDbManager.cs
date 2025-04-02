using Core;
using Data;
using System;

namespace Interfaces{
    public interface IDbManager
    {
         IDataAccess PortalDb { get; set; }
    }
}