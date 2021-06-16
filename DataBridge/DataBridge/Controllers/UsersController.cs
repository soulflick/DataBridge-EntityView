using DataBridge.Classes;
using DataBridge.Interfaces;
using DataBridge.Shared.Classes;
using DataBridge.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using Serializer = System.Text.Json.JsonSerializer;

namespace DataBridge.Controllers
{
    [ApiController]
    [Route("/api")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IRepository<User> _userRepo;

        public UsersController(ILogger<UsersController> logger, IRepository<User> userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        [HttpGet]
        [Route("/api/users")]
        public ActionResult GetAll()
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug("[api/users/get]");

            return Ok(_userRepo.GetAll().Result);
        }

        [HttpPost]
        [Route("/api/users")]
        public IEnumerable<User> Query([FromBody] MapperObject map)
        {
            if (map != null)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug("[api/users/query]");

                return _userRepo.Query(map).Result;
            }
            else return null;
        }

        [HttpGet("/api/user/{id}")]
        public User Get(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/user/get/{id}]");

            return _userRepo.Get(id).Result;
        }

        [HttpPut]
        [Route("/api/user")]
        public ActionResult<string> Put([FromBody] User user)
        {
            if (user.Id == Guid.Empty)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug($"[api/user/insert/[{user.UserName}]");

                if (_userRepo.Insert(user).Result >= 0)
                {
                    return Ok();
                }
                else
                {
                    return Serializer.Serialize(new JsonErrorMessage() { Error = "could not create object" });
                }
            }
            else
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug($"[api/user/update/[{user.UserName}]");

                if (_userRepo.Update(user).Result)
                {
                    return Ok();
                }
                else
                {
                    return Serializer.Serialize(new JsonErrorMessage() { Error = "could not update object" });
                }
            }
        }

        [HttpDelete("/api/user/{id}")]
        public ActionResult<string> Delete(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/company/delete/{id}]");

            if (_userRepo.Delete(id).Result >= 0)
            {
                return Ok();
            }
            else
            {
                return Serializer.Serialize(new JsonErrorMessage() { Error = "could not update object" });
            }
        }


    }
}
