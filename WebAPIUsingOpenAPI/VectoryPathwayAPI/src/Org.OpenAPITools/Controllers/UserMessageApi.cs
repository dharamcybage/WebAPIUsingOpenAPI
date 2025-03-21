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
    public class UserMessageApiController : ControllerBase
    { 
        /// <summary>
        /// User Messag
        /// </summary>
        /// <remarks>User Messag</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Events/User Message/api/consumer/v1/user-messages/admin")]
        [ValidateModelState]
        [SwaggerOperation("GetEventsUserMessageApiConsumerV1UserMessagesAdmin")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminMessageDTO), description: "OK")]
        public virtual IActionResult GetEventsUserMessageApiConsumerV1UserMessagesAdmin([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AdminMessageDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"students\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  } ],\r\n  \"groups\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 5\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 5\r\n  } ],\r\n  \"id\" : 0,\r\n  \"message\" : \"message\",\r\n  \"parents\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AdminMessageDTO>(exampleJson)
            : default(AdminMessageDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// User Message
        /// </summary>
        /// <remarks>User Messag</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Events/User Message/api/consumer/v1/user-messages/student")]
        [ValidateModelState]
        [SwaggerOperation("GetEventsUserMessageApiConsumerV1UserMessagesStudent")]
        [SwaggerResponse(statusCode: 200, type: typeof(StudentMessageDTO), description: "OK")]
        public virtual IActionResult GetEventsUserMessageApiConsumerV1UserMessagesStudent([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StudentMessageDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"date\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"sender\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"id\" : 0,\r\n  \"message\" : \"message\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StudentMessageDTO>(exampleJson)
            : default(StudentMessageDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// User Messag
        /// </summary>
        /// <remarks>User Messag</remarks>
        /// <param name="userMessageRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Events/User Message/api/consumer/v1/user-messages/send")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostEventsUserMessageApiConsumerV1UserMessagesSend")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostEventsUserMessageApiConsumerV1UserMessagesSend([FromBody]UserMessageRequest userMessageRequest, [FromHeader (Name = "Authorization")]string authorization)
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
    }
}
