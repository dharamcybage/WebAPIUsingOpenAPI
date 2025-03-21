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
using Swashbuckle.Swagger.Annotations; using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SmartTaskApiController : ControllerBase
    { 
        /// <summary>
        /// Smart Task
        /// </summary>
        /// <remarks>Smart Task</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Smart Task/api/consumer/v1/available-count")]
        [ValidateModelState]
        [SwaggerOperation("GetSmartTaskApiConsumerV1AvailableCount")]
        [SwaggerResponse(statusCode: 200, type: typeof(PendingSmartTasksDTO), description: "OK")]
        public virtual IActionResult GetSmartTaskApiConsumerV1AvailableCount([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PendingSmartTasksDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"count\" : 0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PendingSmartTasksDTO>(exampleJson)
            : default(PendingSmartTasksDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Smart Task
        /// </summary>
        /// <remarks>Smart Task</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Smart Task/api/consumer/v1/available-tasks")]
        [ValidateModelState]
        [SwaggerOperation("GetSmartTaskApiConsumerV1AvailableTasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SmartTaskDTO>), description: "OK")]
        public virtual IActionResult GetSmartTaskApiConsumerV1AvailableTasks([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SmartTaskDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"instructions\" : \"instructions\",\r\n  \"name\" : \"name\",\r\n  \"link\" : \"link\",\r\n  \"completed\" : true\r\n}, {\r\n  \"instructions\" : \"instructions\",\r\n  \"name\" : \"name\",\r\n  \"link\" : \"link\",\r\n  \"completed\" : true\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SmartTaskDTO>>(exampleJson)
            : default(List<SmartTaskDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
