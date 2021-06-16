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
    public class CompaniesController : ControllerBase
    {
        private readonly ILogger<CompaniesController> _logger;
        private readonly IRepository<Company> _companyRepo;

        public CompaniesController(ILogger<CompaniesController> logger, IRepository<Company> companyRepo)
        {
            _logger = logger;
            _companyRepo = companyRepo;
        }

        [HttpGet]
        [Route("/api/companies")]
        public ActionResult GetAll()
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug("[api/companies/get]");

            return Ok(_companyRepo.GetAll().Result);
        }

        [HttpPost]
        [Route("/api/companies")]
        public IEnumerable<Company> Query([FromBody] MapperObject map)
        {
            if (map != null)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug("[api/companies/query]");

                return _companyRepo.Query(map).Result;
            }
            else return null;

        }

        [HttpGet("/api/company/{id}")]
        public Company Get(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/company/get/{id}]");

            return _companyRepo.Get(id).Result;
        }

        [HttpPut]
        [Route("/api/company")]
        public ActionResult<string> Put([FromBody] Company company)
        {
            if (company.Id == Guid.Empty)
            {
                if (Environment.Options.LogDebug)
                    _logger.LogDebug($"[api/company/insert/[{company.CompanyName}]");

                if (_companyRepo.Insert(company).Result >= 0)
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
                    _logger.LogDebug($"[api/company/update/[{company.CompanyName}]");

                if (_companyRepo.Update(company).Result)
                {
                    return Ok();
                }
                else
                {
                    return Serializer.Serialize(new JsonErrorMessage() { Error = "could not update object" });
                }
            }
        }

        [HttpDelete("/api/company/{id}")]
        public ActionResult<string> Delete(Guid id)
        {
            if (Environment.Options.LogDebug)
                _logger.LogDebug($"[api/company/delete/{id}]");

            if (_companyRepo.Delete(id).Result >= 0)
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
