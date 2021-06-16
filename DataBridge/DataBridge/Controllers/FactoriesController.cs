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
    public class FactoriesController : ControllerBase
    {
        private readonly ILogger<FactoriesController> _logger;
        private readonly IRepository<Factory> _factoryRepo;

        public FactoriesController(ILogger<FactoriesController> logger, IRepository<Factory> factoryRepo)
        {
            _logger = logger;
            _factoryRepo = factoryRepo;
        }

        [HttpGet]
        [Route("/api/factories")]
        public ActionResult GetAll()
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug("[api/factories/get]");

            return Ok(_factoryRepo.GetAll().Result);
        }

        [HttpPost]
        [Route("/api/factories")]
        public IEnumerable<Factory> Query(MapperObject map)
        {
            if (map != null)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug("[api/factories/query]");

                return _factoryRepo.Query(map).Result;
            }
            else return null;
        }

        [HttpGet("/api/factory/{id}")]
        public Factory Get(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/factory/get/{id}]");

            return _factoryRepo.Get(id).Result;
        }

        [HttpPut]
        [Route("/api/factory")]
        public ActionResult<string> Put([FromBody] Factory factory)
        {
            if (factory.Id == Guid.Empty)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug($"[api/factory/insert/[{factory.FactoryName}]");

                if (_factoryRepo.Insert(factory).Result >= 0)
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
                    _logger.LogDebug($"[api/factory/update/[{factory.FactoryName}]");

                if (_factoryRepo.Update(factory).Result)
                {
                    return Ok();
                }
                else
                {
                    return Serializer.Serialize(new JsonErrorMessage() { Error = "could not update object" });
                }
            }
        }

        [HttpDelete("/api/factory/{id}")]
        public ActionResult<string> Delete(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/company/delete/{id}]");

            if (_factoryRepo.Delete(id).Result >= 0)
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
