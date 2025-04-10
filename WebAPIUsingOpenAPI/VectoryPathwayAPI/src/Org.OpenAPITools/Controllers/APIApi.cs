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
    public class ApiApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/students/export</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/students/export")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsExportGet")]
        public virtual IActionResult ApiConsumerV1StudentsExportGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/students</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/students")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsGet")]
        public virtual IActionResult ApiConsumerV1StudentsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/students/parents-report</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/students/parents-report")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsParentsReportGet")]
        public virtual IActionResult ApiConsumerV1StudentsParentsReportGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /api/consumer/v1/students/pending/approve</remarks>
        [HttpPatch]
        [Route("/api/consumer/v1/students/pending/approve")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsPendingApprovePatch")]
        public virtual IActionResult ApiConsumerV1StudentsPendingApprovePatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/students/pending</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/students/pending")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsPendingGet")]
        public virtual IActionResult ApiConsumerV1StudentsPendingGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /api/consumer/v1/students/pending/reject</remarks>
        [HttpPatch]
        [Route("/api/consumer/v1/students/pending/reject")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsPendingRejectPatch")]
        public virtual IActionResult ApiConsumerV1StudentsPendingRejectPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /api/consumer/v1/students</remarks>
        [HttpPost]
        [Route("/api/consumer/v1/students")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsPost")]
        public virtual IActionResult ApiConsumerV1StudentsPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/students/required-profile-form</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/students/required-profile-form")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1StudentsRequiredProfileFormGet")]
        public virtual IActionResult ApiConsumerV1StudentsRequiredProfileFormGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /api/consumer/v1/sunset-data/export</remarks>
        [HttpPost]
        [Route("/api/consumer/v1/sunset-data/export")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1SunsetDataExportPost")]
        public virtual IActionResult ApiConsumerV1SunsetDataExportPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /api/consumer/v1/sunset-data/token-export/:token</remarks>
        [HttpGet]
        [Route("/api/consumer/v1/sunset-data/token-export/{token}")]
        [ValidateModelState]
        [SwaggerOperation("ApiConsumerV1SunsetDataTokenExportTokenGet")]
        public virtual IActionResult ApiConsumerV1SunsetDataTokenExportTokenGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /api/vendor/v1/amazon/sns-endpoint</remarks>
        [HttpPost]
        [Route("/api/vendor/v1/amazon/sns-endpoint")]
        [ValidateModelState]
        [SwaggerOperation("ApiVendorV1AmazonSnsEndpointPost")]
        public virtual IActionResult ApiVendorV1AmazonSnsEndpointPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="experiences"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/consumer/v1/experiences/{experiences}/applications")]
        [ValidateModelState]
        [SwaggerOperation("GetApiConsumerV1ExperiencesByExperiencesApplications")]
        [SwaggerResponse(statusCode: 200, type: typeof(ExperienceApplications), description: "OK")]
        public virtual IActionResult GetApiConsumerV1ExperiencesByExperiencesApplications([FromRoute (Name = "experiences")][Required]string experiences, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ExperienceApplications));
            string exampleJson = null;
            exampleJson = "{\r\n  \"experience\" : {\r\n    \"formId\" : 5,\r\n    \"contact\" : {\r\n      \"lastName\" : \"lastName\",\r\n      \"organizationName\" : \"organizationName\",\r\n      \"form_submission_id\" : 6,\r\n      \"title\" : \"title\",\r\n      \"created_by\" : 6,\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"firstName\" : \"firstName\",\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"phone\" : \"phone\",\r\n      \"organization_id\" : 3,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"organization\" : {\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"website\" : \"website\",\r\n      \"form_submission_id\" : 2,\r\n      \"phone\" : \"phone\",\r\n      \"locationDescription\" : \"locationDescription\",\r\n      \"name\" : \"name\",\r\n      \"id\" : 7,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"location\" : {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"address\" : \"address\",\r\n      \"organization_id\" : 1,\r\n      \"latitude\" : \"latitude\",\r\n      \"nickname\" : \"nickname\",\r\n      \"id\" : 6,\r\n      \"longitude\" : \"longitude\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"id\" : 1\r\n  },\r\n  \"applications\" : [ {\r\n    \"application\" : \"application\",\r\n    \"formSubmissionId\" : 6,\r\n    \"id\" : 0,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    },\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"application\" : \"application\",\r\n    \"formSubmissionId\" : 6,\r\n    \"id\" : 0,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    },\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ExperienceApplications>(exampleJson)
            : default(ExperienceApplications);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/api/consumer/v1/experiences/pending/list")]
        [ValidateModelState]
        [SwaggerOperation("GetApiConsumerV1ExperiencesPendingList")]
        [SwaggerResponse(statusCode: 200, type: typeof(ExperienceDTO), description: "OK")]
        public virtual IActionResult GetApiConsumerV1ExperiencesPendingList([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ExperienceDTO));
            string exampleJson = null;
            exampleJson = "{\r\n  \"organizationName\" : \"organizationName\",\r\n  \"reflection_form_approval\" : 2,\r\n  \"form_submission_id\" : 4,\r\n  \"contactName\" : \"contactName\",\r\n  \"conditional_badge_group_id\" : 7,\r\n  \"form_id\" : 5,\r\n  \"description\" : \"description\",\r\n  \"allowsTotalTimelogHoursSubmission\" : true,\r\n  \"contact_id\" : 3,\r\n  \"created_by\" : 5,\r\n  \"location_id\" : 6,\r\n  \"numberOfSpots\" : 2,\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"reflection_form_id\" : 0,\r\n  \"organization_id\" : 1,\r\n  \"name\" : \"name\",\r\n  \"hideFromSearch\" : true,\r\n  \"id\" : 9,\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ExperienceDTO>(exampleJson)
            : default(ExperienceDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="contacts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/archive-entity/contact/{contacts}")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ArchiveEntityContactByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ArchiveEntityContactByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="experiences"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/archive-entity/experience/{experiences}")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ArchiveEntityExperienceByExperiences")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ArchiveEntityExperienceByExperiences([FromRoute (Name = "experiences")][Required]string experiences, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="organizations"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/archive-entity/organization/{organizations}")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ArchiveEntityOrganizationByOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ArchiveEntityOrganizationByOrganizations([FromRoute (Name = "organizations")][Required]string organizations, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="adminExperiencesControllerRejectApproveBulkExperienceRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/experiences/pending/bulk-reject")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ExperiencesPendingBulkReject")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ExperiencesPendingBulkReject([FromBody]AdminExperiencesControllerRejectApproveBulkExperienceRequest adminExperiencesControllerRejectApproveBulkExperienceRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="pendingUserExperience"></param>
        /// <param name="scheduleInterviewRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/experiences/pending/{pending_user_experience}/interview")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceInterview")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceInterview([FromRoute (Name = "pending_user_experience")][Required]string pendingUserExperience, [FromBody]ScheduleInterviewRequest scheduleInterviewRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="pendingUserExperience"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/experiences/pending/{pending_user_experience}/offer")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceOffer")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceOffer([FromRoute (Name = "pending_user_experience")][Required]string pendingUserExperience, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="pendingUserExperience"></param>
        /// <param name="actionExperienceRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/experiences/pending/{pending_user_experience}/reject")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceReject")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceReject([FromRoute (Name = "pending_user_experience")][Required]string pendingUserExperience, [FromBody]ActionExperienceRequest actionExperienceRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="pendingUserExperience"></param>
        /// <param name="actionExperienceRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/experiences/pending/{pending_user_experience}/revert")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceRevert")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1ExperiencesPendingByPendingUserExperienceRevert([FromRoute (Name = "pending_user_experience")][Required]string pendingUserExperience, [FromBody]ActionExperienceRequest actionExperienceRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="contacts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/unarchive-entity/contact/{contacts}")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1UnarchiveEntityContactByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1UnarchiveEntityContactByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="experiences"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/unarchive-entity/experience/{experiences}")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1UnarchiveEntityExperienceByExperiences")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1UnarchiveEntityExperienceByExperiences([FromRoute (Name = "experiences")][Required]string experiences, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="organizations"></param>
        /// <param name="createContactRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/api/consumer/v1/unarchive-entity/organization/{organizations}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchApiConsumerV1UnarchiveEntityOrganizationByOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchApiConsumerV1UnarchiveEntityOrganizationByOrganizations([FromRoute (Name = "organizations")][Required]string organizations, [FromBody]CreateContactRequest createContactRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="entityArchivingRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/api/consumer/v1/archive-entity/multiple")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostApiConsumerV1ArchiveEntityMultiple")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostApiConsumerV1ArchiveEntityMultiple([FromBody]EntityArchivingRequest entityArchivingRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// AdminExperiences
        /// </summary>
        /// <remarks>AdminExperiences</remarks>
        /// <param name="bulkExperienceRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/api/consumer/v1/experiences-bulk/applications")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostApiConsumerV1ExperiencesBulkApplications")]
        [SwaggerResponse(statusCode: 200, type: typeof(ExperienceApplications), description: "OK")]
        public virtual IActionResult PostApiConsumerV1ExperiencesBulkApplications([FromBody]BulkExperienceRequest bulkExperienceRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ExperienceApplications));
            string exampleJson = null;
            exampleJson = "{\r\n  \"experience\" : {\r\n    \"formId\" : 5,\r\n    \"contact\" : {\r\n      \"lastName\" : \"lastName\",\r\n      \"organizationName\" : \"organizationName\",\r\n      \"form_submission_id\" : 6,\r\n      \"title\" : \"title\",\r\n      \"created_by\" : 6,\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"firstName\" : \"firstName\",\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"phone\" : \"phone\",\r\n      \"organization_id\" : 3,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"organization\" : {\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"website\" : \"website\",\r\n      \"form_submission_id\" : 2,\r\n      \"phone\" : \"phone\",\r\n      \"locationDescription\" : \"locationDescription\",\r\n      \"name\" : \"name\",\r\n      \"id\" : 7,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"location\" : {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"address\" : \"address\",\r\n      \"organization_id\" : 1,\r\n      \"latitude\" : \"latitude\",\r\n      \"nickname\" : \"nickname\",\r\n      \"id\" : 6,\r\n      \"longitude\" : \"longitude\",\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    },\r\n    \"id\" : 1\r\n  },\r\n  \"applications\" : [ {\r\n    \"application\" : \"application\",\r\n    \"formSubmissionId\" : 6,\r\n    \"id\" : 0,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    },\r\n    \"status\" : \"status\"\r\n  }, {\r\n    \"application\" : \"application\",\r\n    \"formSubmissionId\" : 6,\r\n    \"id\" : 0,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    },\r\n    \"status\" : \"status\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ExperienceApplications>(exampleJson)
            : default(ExperienceApplications);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Add Forms
        /// </summary>
        /// <remarks>Add Forms</remarks>
        /// <param name="createFormRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/api/consumer/v1/forms")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostApiConsumerV1Forms")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostApiConsumerV1Forms([FromBody]CreateFormRequest createFormRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Add Forms
        /// </summary>
        /// <remarks>Add Forms</remarks>
        /// <param name="forms"></param>
        /// <param name="body"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/api/consumer/v1/forms/{forms}/clone")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostApiConsumerV1FormsByFormsClone")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostApiConsumerV1FormsByFormsClone([FromRoute (Name = "forms")][Required]string forms, [FromBody]Object body, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// ArchivedEntities
        /// </summary>
        /// <remarks>ArchivedEntities</remarks>
        /// <param name="entityArchivingRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/api/consumer/v1/unarchive-entity/multiple")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostApiConsumerV1UnarchiveEntityMultiple")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostApiConsumerV1UnarchiveEntityMultiple([FromBody]EntityArchivingRequest entityArchivingRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(long));
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<long>(exampleJson)
            : default(long);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
