/*
 * Pathwayos API
 *
 * Pathwayos API description
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Org.OpenAPITools.Attributes;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ServiceOrganizationsApiController : ControllerBase
    { 
        /// <summary>
        /// Service Organizations
        /// </summary>
        /// <remarks>Service Organizations</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Service Organizations/api/consumer/v1/service-organizations")]
        [ValidateModelState]
        [SwaggerOperation("GetServiceOrganizationsApiConsumerV1ServiceOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(OrganizationsConsumerResponse), description: "OK")]
        public virtual IActionResult GetServiceOrganizationsApiConsumerV1ServiceOrganizations([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OrganizationsConsumerResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"organizations\" : [ {\r\n    \"website\" : \"website\",\r\n    \"code\" : \"code\",\r\n    \"contactEmail\" : \"contactEmail\",\r\n    \"contactName\" : \"contactName\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"student_id\" : 0,\r\n    \"id\" : 6,\r\n    \"contactPhone\" : \"contactPhone\"\r\n  }, {\r\n    \"website\" : \"website\",\r\n    \"code\" : \"code\",\r\n    \"contactEmail\" : \"contactEmail\",\r\n    \"contactName\" : \"contactName\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"student_id\" : 0,\r\n    \"id\" : 6,\r\n    \"contactPhone\" : \"contactPhone\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OrganizationsConsumerResponse>(exampleJson)
            : default(OrganizationsConsumerResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Service Organizations
        /// </summary>
        /// <remarks>Service Organizations</remarks>
        /// <param name="serviceOrganizations"></param>
        /// <param name="editServiceOrganizationRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Service Organizations/api/consumer/v1/service-organizations/{service_organizations}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchServiceOrganizationsApiConsumerV1ServiceOrganizationsByServiceOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchServiceOrganizationsApiConsumerV1ServiceOrganizationsByServiceOrganizations([FromRoute (Name = "service_organizations")][Required]string serviceOrganizations, [FromBody]EditServiceOrganizationRequest editServiceOrganizationRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Service Organizations
        /// </summary>
        /// <remarks>Service Organizations</remarks>
        /// <param name="serviceOrganizations"></param>
        /// <param name="deleteServiceOrgRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Service Organizations/api/consumer/v1/service-organizations/{service_organizations}/delete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchServiceOrganizationsApiConsumerV1ServiceOrganizationsByServiceOrganizationsDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchServiceOrganizationsApiConsumerV1ServiceOrganizationsByServiceOrganizationsDelete([FromRoute (Name = "service_organizations")][Required]string serviceOrganizations, [FromBody]DeleteServiceOrgRequest deleteServiceOrgRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Service Organizations
        /// </summary>
        /// <remarks>Service Organizations</remarks>
        /// <param name="createServiceOrgRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Service Organizations/api/consumer/v1/service-organizations")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostServiceOrganizationsApiConsumerV1ServiceOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(JSONServiceOrganization), description: "OK")]
        public virtual IActionResult PostServiceOrganizationsApiConsumerV1ServiceOrganizations([FromBody]CreateServiceOrgRequest createServiceOrgRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(JSONServiceOrganization));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"website\" : \"website\",\r\n  \"code\" : \"code\",\r\n  \"contactEmail\" : \"contactEmail\",\r\n  \"contactName\" : \"contactName\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"student_id\" : 0,\r\n  \"id\" : 6,\r\n  \"contactPhone\" : \"contactPhone\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<JSONServiceOrganization>(exampleJson)
            : default(JSONServiceOrganization);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
