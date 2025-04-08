using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace web{
    public class SPOBaseController : ControllerBase
    {
        protected SPOBaseController()
        {
            // Initialize the DbManager or any other services here
            // _dbManager = new DbManager();
        }

        // [HttpGet]
        // [Route("GetCurrentUser")]

        // public async Task<GetUserInfo> GetCurrentUser()
        // {
        //     
        //     return await _securityManager.GetCurrentUser();
        // }
    }
}