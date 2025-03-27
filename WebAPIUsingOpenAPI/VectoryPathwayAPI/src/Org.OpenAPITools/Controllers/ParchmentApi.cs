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
    public class ParchmentApiController : ControllerBase
    { 
        /// <summary>
        /// Pachment Request Data
        /// </summary>
        /// <remarks>Pachment Request Data</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment/data/{parchment_requests}")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentDataByParchmentRequests")]
        [SwaggerResponse(statusCode: 200, type: typeof(ParchmentFullListResponse), description: "OK")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentDataByParchmentRequests([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ParchmentFullListResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"request\" : {\r\n    \"standalone_district_id\" : 0,\r\n    \"requestTrackingId\" : \"requestTrackingId\",\r\n    \"documentUrl\" : \"documentUrl\",\r\n    \"introText\" : \"introText\",\r\n    \"numberOfStandaloneTokensAssigned\" : 2,\r\n    \"totalTokensRequired\" : 5,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"batch_token_set_id\" : 7,\r\n    \"user_id\" : 6,\r\n    \"name\" : \"name\",\r\n    \"id\" : 1,\r\n    \"conclusionText\" : \"conclusionText\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"status\" : 5\r\n  },\r\n  \"receiverObjects\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"parchment_request_id\" : 4,\r\n    \"receiver_id\" : 7,\r\n    \"requestTrackingId\" : \"requestTrackingId\",\r\n    \"errorMessage\" : \"errorMessage\",\r\n    \"documentId\" : \"documentId\",\r\n    \"id\" : 1,\r\n    \"successMessage\" : \"successMessage\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"status\" : 5\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"parchment_request_id\" : 4,\r\n    \"receiver_id\" : 7,\r\n    \"requestTrackingId\" : \"requestTrackingId\",\r\n    \"errorMessage\" : \"errorMessage\",\r\n    \"documentId\" : \"documentId\",\r\n    \"id\" : 1,\r\n    \"successMessage\" : \"successMessage\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"status\" : 5\r\n  } ],\r\n  \"receivers\" : [ {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"experiences\" : [ {\r\n    \"experience_id\" : 6,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"parchment_request_id\" : 9,\r\n    \"id\" : 9,\r\n    \"experience\" : {\r\n      \"organizationName\" : \"organizationName\",\r\n      \"reflection_form_approval\" : 2,\r\n      \"form_submission_id\" : 4,\r\n      \"contactName\" : \"contactName\",\r\n      \"conditional_badge_group_id\" : 7,\r\n      \"form_id\" : 5,\r\n      \"description\" : \"description\",\r\n      \"allowsTotalTimelogHoursSubmission\" : true,\r\n      \"contact_id\" : 3,\r\n      \"created_by\" : 5,\r\n      \"location_id\" : 6,\r\n      \"numberOfSpots\" : 2,\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"reflection_form_id\" : 0,\r\n      \"organization_id\" : 1,\r\n      \"name\" : \"name\",\r\n      \"hideFromSearch\" : true,\r\n      \"id\" : 9,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"experience_id\" : 6,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"parchment_request_id\" : 9,\r\n    \"id\" : 9,\r\n    \"experience\" : {\r\n      \"organizationName\" : \"organizationName\",\r\n      \"reflection_form_approval\" : 2,\r\n      \"form_submission_id\" : 4,\r\n      \"contactName\" : \"contactName\",\r\n      \"conditional_badge_group_id\" : 7,\r\n      \"form_id\" : 5,\r\n      \"description\" : \"description\",\r\n      \"allowsTotalTimelogHoursSubmission\" : true,\r\n      \"contact_id\" : 3,\r\n      \"created_by\" : 5,\r\n      \"location_id\" : 6,\r\n      \"numberOfSpots\" : 2,\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"reflection_form_id\" : 0,\r\n      \"organization_id\" : 1,\r\n      \"name\" : \"name\",\r\n      \"hideFromSearch\" : true,\r\n      \"id\" : 9,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"events\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"parchment_request_id\" : 1,\r\n    \"service_event_id\" : 1,\r\n    \"id\" : 6,\r\n    \"serviceEvent\" : {\r\n      \"requireSignup\" : true,\r\n      \"endDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"description\" : \"description\",\r\n      \"type\" : 4,\r\n      \"sponsor_id\" : 3,\r\n      \"isGroupLevelEvent\" : true,\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"group_id\" : 9,\r\n      \"organization_id\" : 2,\r\n      \"name\" : \"name\",\r\n      \"location\" : \"location\",\r\n      \"time\" : \"time\",\r\n      \"id\" : 7,\r\n      \"maximumRegisteredStudents\" : 1,\r\n      \"acceptingRegistrations\" : true,\r\n      \"startDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"parchment_request_id\" : 1,\r\n    \"service_event_id\" : 1,\r\n    \"id\" : 6,\r\n    \"serviceEvent\" : {\r\n      \"requireSignup\" : true,\r\n      \"endDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"description\" : \"description\",\r\n      \"type\" : 4,\r\n      \"sponsor_id\" : 3,\r\n      \"isGroupLevelEvent\" : true,\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"group_id\" : 9,\r\n      \"organization_id\" : 2,\r\n      \"name\" : \"name\",\r\n      \"location\" : \"location\",\r\n      \"time\" : \"time\",\r\n      \"id\" : 7,\r\n      \"maximumRegisteredStudents\" : 1,\r\n      \"acceptingRegistrations\" : true,\r\n      \"startDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ParchmentFullListResponse>(exampleJson)
            : default(ParchmentFullListResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create Pachment Request
        /// </summary>
        /// <remarks>Create Pachment Request</remarks>
        /// <param name="token"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment-external-pdf/{token}")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentExternalPdfByToken")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentExternalPdfByToken([FromRoute (Name = "token")][Required]string token)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="authorization"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment/request/{parchment_requests}/pdf")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentRequestByParchmentRequestsPdf")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentRequestByParchmentRequestsPdf([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment/requests")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentRequests")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ParchmentListResponse>), description: "OK")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentRequests([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ParchmentListResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"request\" : {\r\n    \"standalone_district_id\" : 0,\r\n    \"requestTrackingId\" : \"requestTrackingId\",\r\n    \"documentUrl\" : \"documentUrl\",\r\n    \"introText\" : \"introText\",\r\n    \"numberOfStandaloneTokensAssigned\" : 2,\r\n    \"totalTokensRequired\" : 5,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"batch_token_set_id\" : 7,\r\n    \"user_id\" : 6,\r\n    \"name\" : \"name\",\r\n    \"id\" : 1,\r\n    \"conclusionText\" : \"conclusionText\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"status\" : 5\r\n  },\r\n  \"receivers\" : [ {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ]\r\n}, {\r\n  \"request\" : {\r\n    \"standalone_district_id\" : 0,\r\n    \"requestTrackingId\" : \"requestTrackingId\",\r\n    \"documentUrl\" : \"documentUrl\",\r\n    \"introText\" : \"introText\",\r\n    \"numberOfStandaloneTokensAssigned\" : 2,\r\n    \"totalTokensRequired\" : 5,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"batch_token_set_id\" : 7,\r\n    \"user_id\" : 6,\r\n    \"name\" : \"name\",\r\n    \"id\" : 1,\r\n    \"conclusionText\" : \"conclusionText\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"status\" : 5\r\n  },\r\n  \"receivers\" : [ {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"country\" : \"country\",\r\n    \"zipCode\" : \"zipCode\",\r\n    \"ceebCode\" : \"ceebCode\",\r\n    \"parchmentId\" : 6,\r\n    \"city\" : \"city\",\r\n    \"ncesId\" : \"ncesId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phoneNumber\" : \"phoneNumber\",\r\n    \"name\" : \"name\",\r\n    \"memberType\" : \"memberType\",\r\n    \"id\" : 0,\r\n    \"state\" : \"state\",\r\n    \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n    \"addressOne\" : \"addressOne\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ]\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ParchmentListResponse>>(exampleJson)
            : default(List<ParchmentListResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Pachment Request Data
        /// </summary>
        /// <remarks>Pachment Request Data</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment/student-persistent-data")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentStudentPersistentData")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserParchmentPersistentDataResponse), description: "OK")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentStudentPersistentData([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserParchmentPersistentDataResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"birthday\" : \"birthday\",\r\n  \"approxExitDate\" : \"approxExitDate\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<UserParchmentPersistentDataResponse>(exampleJson)
            : default(UserParchmentPersistentDataResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create Pachment Request
        /// </summary>
        /// <remarks>Create Pachment Request</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Parchment/api/consumer/v1/parchment/tokens/remaining")]
        [ValidateModelState]
        [SwaggerOperation("GetParchmentApiConsumerV1ParchmentTokensRemaining")]
        [SwaggerResponse(statusCode: 200, type: typeof(ExtensioninRunUserParchmentTokenBreakdown), description: "OK")]
        public virtual IActionResult GetParchmentApiConsumerV1ParchmentTokensRemaining([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ExtensioninRunUserParchmentTokenBreakdown));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"districtProvided\" : 6,\r\n  \"studentProvided\" : 0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ExtensioninRunUserParchmentTokenBreakdown>(exampleJson)
            : default(ExtensioninRunUserParchmentTokenBreakdown);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Pachment Request Data
        /// </summary>
        /// <remarks>Pachment Request Data</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="parchmentReceivers"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Parchment/api/consumer/v1/parchment/data/{parchment_requests}/receiver/{parchment_receivers}")]
        [ValidateModelState]
        [SwaggerOperation("PatchParchmentApiConsumerV1ParchmentDataByParchmentRequestsReceiverByParchmentReceivers")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchParchmentApiConsumerV1ParchmentDataByParchmentRequestsReceiverByParchmentReceivers([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromRoute (Name = "parchment_receivers")][Required]string parchmentReceivers, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="updateParchmentRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Parchment/api/consumer/v1/parchment/request/{parchment_requests}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequests")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequests([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromBody]UpdateParchmentRequest updateParchmentRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="experiences"></param>
        /// <param name="addParchmentRequestModel"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Parchment/api/consumer/v1/parchment/request/{parchment_requests}/experience/{experiences}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequestsExperienceByExperiences")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequestsExperienceByExperiences([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromRoute (Name = "experiences")][Required]string experiences, [FromBody]AddParchmentRequestModel addParchmentRequestModel, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="serviceEvents"></param>
        /// <param name="addParchmentRequestModel"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Parchment/api/consumer/v1/parchment/request/{parchment_requests}/service-event/{service_events}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequestsServiceEventByServiceEvents")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchParchmentApiConsumerV1ParchmentRequestByParchmentRequestsServiceEventByServiceEvents([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromRoute (Name = "service_events")][Required]string serviceEvents, [FromBody]AddParchmentRequestModel addParchmentRequestModel, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Create Pachment Request
        /// </summary>
        /// <remarks>Create Pachment Request</remarks>
        /// <param name="initiateParchmentPurchaseRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Parchment/api/consumer/v1/parchment/purchase/link")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostParchmentApiConsumerV1ParchmentPurchaseLink")]
        [SwaggerResponse(statusCode: 200, type: typeof(ParchmentPaymentInitiationResponse), description: "OK")]
        public virtual IActionResult PostParchmentApiConsumerV1ParchmentPurchaseLink([FromBody]InitiateParchmentPurchaseRequest initiateParchmentPurchaseRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ParchmentPaymentInitiationResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"id\" : \"id\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ParchmentPaymentInitiationResponse>(exampleJson)
            : default(ParchmentPaymentInitiationResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Pachment Request
        /// </summary>
        /// <remarks>Pachment Request</remarks>
        /// <param name="searchRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Parchment/api/consumer/v1/parchment/receivers")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostParchmentApiConsumerV1ParchmentReceivers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ParchmentReceiverDTO>), description: "OK")]
        public virtual IActionResult PostParchmentApiConsumerV1ParchmentReceivers([FromBody]SearchRequest searchRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ParchmentReceiverDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"country\" : \"country\",\r\n  \"zipCode\" : \"zipCode\",\r\n  \"ceebCode\" : \"ceebCode\",\r\n  \"parchmentId\" : 6,\r\n  \"city\" : \"city\",\r\n  \"ncesId\" : \"ncesId\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"phoneNumber\" : \"phoneNumber\",\r\n  \"name\" : \"name\",\r\n  \"memberType\" : \"memberType\",\r\n  \"id\" : 0,\r\n  \"state\" : \"state\",\r\n  \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n  \"addressOne\" : \"addressOne\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"country\" : \"country\",\r\n  \"zipCode\" : \"zipCode\",\r\n  \"ceebCode\" : \"ceebCode\",\r\n  \"parchmentId\" : 6,\r\n  \"city\" : \"city\",\r\n  \"ncesId\" : \"ncesId\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"phoneNumber\" : \"phoneNumber\",\r\n  \"name\" : \"name\",\r\n  \"memberType\" : \"memberType\",\r\n  \"id\" : 0,\r\n  \"state\" : \"state\",\r\n  \"nicknames\" : [ \"nicknames\", \"nicknames\" ],\r\n  \"addressOne\" : \"addressOne\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ParchmentReceiverDTO>>(exampleJson)
            : default(List<ParchmentReceiverDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create Pachment Request
        /// </summary>
        /// <remarks>Create Pachment Request</remarks>
        /// <param name="createParchmentRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Parchment/api/consumer/v1/parchment/request")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostParchmentApiConsumerV1ParchmentRequest")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostParchmentApiConsumerV1ParchmentRequest([FromBody]CreateParchmentRequest createParchmentRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Submit Pachment Request
        /// </summary>
        /// <remarks>Submit Pachment Request</remarks>
        /// <param name="parchmentRequests"></param>
        /// <param name="submitTranscriptRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Parchment/api/consumer/v1/parchment/request/{parchment_requests}/send")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostParchmentApiConsumerV1ParchmentRequestByParchmentRequestsSend")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostParchmentApiConsumerV1ParchmentRequestByParchmentRequestsSend([FromRoute (Name = "parchment_requests")][Required]string parchmentRequests, [FromBody]SubmitTranscriptRequest submitTranscriptRequest, [FromHeader (Name = "Authorization")]string authorization)
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
