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
    public class SegmentsApiController : ControllerBase
    { 
        /// <summary>
        /// Segments
        /// </summary>
        /// <remarks>Segments</remarks>
        /// <param name="segments"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Segments/api/consumer/v1/segments/{segments}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteSegmentsApiConsumerV1SegmentsBySegments")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteSegmentsApiConsumerV1SegmentsBySegments([FromRoute (Name = "segments")][Required]string segments, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Create Segments
        /// </summary>
        /// <remarks>Create Segments</remarks>
        /// <param name="segments"></param>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Segments/api/consumer/v1/segments/{segments}/users/{users}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteSegmentsApiConsumerV1SegmentsBySegmentsUsersByUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteSegmentsApiConsumerV1SegmentsBySegmentsUsersByUsers([FromRoute (Name = "segments")][Required]string segments, [FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Segments
        /// </summary>
        /// <remarks>Segments</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Segments/api/consumer/v1/segments")]
        [ValidateModelState]
        [SwaggerOperation("GetSegmentsApiConsumerV1Segments")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SegmentDTO>), description: "OK")]
        public virtual IActionResult GetSegmentsApiConsumerV1Segments([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SegmentDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"id\" : 0,\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"id\" : 0,\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<SegmentDTO>>(exampleJson)
            : default(List<SegmentDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Segments
        /// </summary>
        /// <remarks>Segments</remarks>
        /// <param name="segments"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Segments/api/consumer/v1/segments/{segments}/users")]
        [ValidateModelState]
        [SwaggerOperation("GetSegmentsApiConsumerV1SegmentsBySegmentsUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<BasicUser>), description: "OK")]
        public virtual IActionResult GetSegmentsApiConsumerV1SegmentsBySegmentsUsers([FromRoute (Name = "segments")][Required]string segments, [FromHeader (Name = "Authorization")]string authorization)
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

        /// <summary>
        /// Segments
        /// </summary>
        /// <remarks>Segments</remarks>
        /// <param name="segments"></param>
        /// <param name="editSegmentRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Segments/api/consumer/v1/segments/{segments}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchSegmentsApiConsumerV1SegmentsBySegments")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchSegmentsApiConsumerV1SegmentsBySegments([FromRoute (Name = "segments")][Required]string segments, [FromBody]EditSegmentRequest editSegmentRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Create Segments
        /// </summary>
        /// <remarks>Create Segments</remarks>
        /// <param name="segments"></param>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Segments/api/consumer/v1/segments/{segments}/users/{users}")]
        [ValidateModelState]
        [SwaggerOperation("PatchSegmentsApiConsumerV1SegmentsBySegmentsUsersByUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchSegmentsApiConsumerV1SegmentsBySegmentsUsersByUsers([FromRoute (Name = "segments")][Required]string segments, [FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Create Segments
        /// </summary>
        /// <remarks>Create Segments</remarks>
        /// <param name="createSegmentRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Segments/api/consumer/v1/segments")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSegmentsApiConsumerV1Segments")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostSegmentsApiConsumerV1Segments([FromBody]CreateSegmentRequest createSegmentRequest, [FromHeader (Name = "Authorization")]string authorization)
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
