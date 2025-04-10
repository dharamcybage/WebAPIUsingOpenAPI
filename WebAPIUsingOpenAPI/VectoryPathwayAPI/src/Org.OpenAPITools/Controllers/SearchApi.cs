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
    public class SearchApiController : ControllerBase
    { 
        /// <summary>
        /// Jump Bar
        /// </summary>
        /// <remarks>Jump Bar</remarks>
        /// <param name="searchRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Search/api/consumer/v1/search")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSearchApiConsumerV1Search")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchResultsResponse), description: "OK")]
        public virtual IActionResult PostSearchApiConsumerV1Search([FromBody]SearchRequest searchRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SearchResultsResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"organizations\" : [ {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  } ],\r\n  \"experiences\" : [ {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  } ],\r\n  \"users\" : [ {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  } ],\r\n  \"contacts\" : [ {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"relativeUrl\" : \"relativeUrl\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SearchResultsResponse>(exampleJson)
            : default(SearchResultsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Jump Bar
        /// </summary>
        /// <remarks>Jump Bar</remarks>
        /// <param name="searchRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Search/api/consumer/v1/search-by-email")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSearchApiConsumerV1SearchByEmail")]
        [SwaggerResponse(statusCode: 200, type: typeof(BasicUser), description: "OK")]
        public virtual IActionResult PostSearchApiConsumerV1SearchByEmail([FromBody]SearchRequest searchRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BasicUser));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"firstName\" : \"firstName\",\r\n  \"lastName\" : \"lastName\",\r\n  \"role\" : 1,\r\n  \"school\" : \"school\",\r\n  \"grade\" : 6,\r\n  \"id\" : 5,\r\n  \"profileImageUrl\" : \"profileImageUrl\",\r\n  \"email\" : \"email\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BasicUser>(exampleJson)
            : default(BasicUser);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Search Student
        /// </summary>
        /// <remarks>Search Student</remarks>
        /// <param name="searchRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Search/api/consumer/v1/students/search")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSearchApiConsumerV1StudentsSearch")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<BasicUser>), description: "OK")]
        public virtual IActionResult PostSearchApiConsumerV1StudentsSearch([FromBody]SearchRequest searchRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BasicUser>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"firstName\" : \"firstName\",\r\n  \"lastName\" : \"lastName\",\r\n  \"role\" : 1,\r\n  \"school\" : \"school\",\r\n  \"grade\" : 6,\r\n  \"id\" : 5,\r\n  \"profileImageUrl\" : \"profileImageUrl\",\r\n  \"email\" : \"email\"\r\n}, {\r\n  \"firstName\" : \"firstName\",\r\n  \"lastName\" : \"lastName\",\r\n  \"role\" : 1,\r\n  \"school\" : \"school\",\r\n  \"grade\" : 6,\r\n  \"id\" : 5,\r\n  \"profileImageUrl\" : \"profileImageUrl\",\r\n  \"email\" : \"email\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BasicUser>>(exampleJson)
            : default(List<BasicUser>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
