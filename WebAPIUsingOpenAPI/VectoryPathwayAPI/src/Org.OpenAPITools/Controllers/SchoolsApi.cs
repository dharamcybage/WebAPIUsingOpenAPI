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
    public class SchoolsApiController : ControllerBase
    { 
        /// <summary>
        /// Schools
        /// </summary>
        /// <remarks>Schools</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Schools/api/consumer/v1/schools")]
        [ValidateModelState]
        [SwaggerOperation("GetSchoolsApiConsumerV1Schools")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<BasicSchool>), description: "OK")]
        public virtual IActionResult GetSchoolsApiConsumerV1Schools([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BasicSchool>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"startingGrade\" : 0,\r\n  \"name\" : \"name\",\r\n  \"id\" : 1,\r\n  \"endingGrade\" : 6\r\n}, {\r\n  \"startingGrade\" : 0,\r\n  \"name\" : \"name\",\r\n  \"id\" : 1,\r\n  \"endingGrade\" : 6\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BasicSchool>>(exampleJson)
            : default(List<BasicSchool>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
