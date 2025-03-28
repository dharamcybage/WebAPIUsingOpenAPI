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
    public class ClusterApiController : ControllerBase
    { 
        /// <summary>
        /// Cluster
        /// </summary>
        /// <remarks>Cluster</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Cluster/api/consumer/v1/clusters")]
        [ValidateModelState]
        [SwaggerOperation("GetClusterApiConsumerV1Clusters")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<CareerClusterDTO>), description: "OK")]
        public virtual IActionResult GetClusterApiConsumerV1Clusters([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<CareerClusterDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"id\" : 6,\r\n  \"shortName\" : \"shortName\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"id\" : 6,\r\n  \"shortName\" : \"shortName\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<CareerClusterDTO>>(exampleJson)
            : default(List<CareerClusterDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
