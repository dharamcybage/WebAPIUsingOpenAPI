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
    public class CoCurricularEventsApiController : ControllerBase
    { 
        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/attending-list")]
        [ValidateModelState]
        [SwaggerOperation("GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttendingList")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerEventAttendingUsersResponse), description: "OK")]
        public virtual IActionResult GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttendingList([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerEventAttendingUsersResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"lastName\" : \"lastName\",\r\n  \"firstName\" : \"firstName\",\r\n  \"id\" : 0,\r\n  \"email\" : \"email\",\r\n  \"timeIn\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"timeOut\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerEventAttendingUsersResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerEventAttendingUsersResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/rsvp")]
        [ValidateModelState]
        [SwaggerOperation("GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvp")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerEventRSVPResponse), description: "OK")]
        public virtual IActionResult GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvp([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerEventRSVPResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"eventEndDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"lastName\" : \"lastName\",\r\n  \"role\" : 6,\r\n  \"external_attendee_id\" : 7,\r\n  \"co_curricular_event_date_id\" : 0,\r\n  \"shiftStartTime\" : \"shiftStartTime\",\r\n  \"shiftEndTime\" : \"shiftEndTime\",\r\n  \"checkInMethod\" : 4,\r\n  \"firstName\" : \"firstName\",\r\n  \"user_id\" : 5,\r\n  \"school\" : \"school\",\r\n  \"co_curricular_event_id\" : 2,\r\n  \"shift_id\" : 5,\r\n  \"district\" : \"district\",\r\n  \"grade\" : 2,\r\n  \"id\" : 3,\r\n  \"eventStartDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"email\" : \"email\",\r\n  \"registration_form_submission_id\" : 9,\r\n  \"status\" : 1\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerEventRSVPResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerEventRSVPResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="coCurricularEventAttendees"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/rsvp/{co_curricular_event_attendees}/form-data")]
        [ValidateModelState]
        [SwaggerOperation("GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvpByCoCurricularEventAttendeesFormData")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerFormDataResponse), description: "OK")]
        public virtual IActionResult GetAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvpByCoCurricularEventAttendeesFormData([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromRoute (Name = "co_curricular_event_attendees")][Required]string coCurricularEventAttendees, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerFormDataResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"form\" : {\r\n    \"externalToken\" : \"externalToken\",\r\n    \"description\" : \"description\",\r\n    \"canBeUsedByBusinessPartners\" : true,\r\n    \"appearsInMarketPlace\" : true,\r\n    \"premium\" : true,\r\n    \"name\" : \"name\",\r\n    \"files\" : [ {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"form_id\" : 0,\r\n      \"name\" : \"name\",\r\n      \"fileUrl\" : \"fileUrl\",\r\n      \"id\" : 6,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"form_id\" : 0,\r\n      \"name\" : \"name\",\r\n      \"fileUrl\" : \"fileUrl\",\r\n      \"id\" : 6,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"id\" : 7,\r\n    \"canBeUsedInWorkflow\" : true,\r\n    \"fields\" : [ {\r\n      \"allowsOtherField\" : true,\r\n      \"studentsCanViewOnEntity\" : true,\r\n      \"values\" : [ {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      }, {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      } ],\r\n      \"showToStudentsInExperience\" : true,\r\n      \"description\" : \"description\",\r\n      \"characterLimit\" : 2,\r\n      \"type\" : 5,\r\n      \"wordLimit\" : 2,\r\n      \"availableOnExternalEntityForm\" : true,\r\n      \"required\" : true,\r\n      \"hiddenFromSchoolAdminOnStudentProfile\" : true,\r\n      \"hiddenFromStaffOnStudentProfile\" : true,\r\n      \"conditionalDisplayValue\" : 1,\r\n      \"hiddenFromStudents\" : true,\r\n      \"name\" : \"name\",\r\n      \"id\" : 5,\r\n      \"maxMultiSelect\" : 7\r\n    }, {\r\n      \"allowsOtherField\" : true,\r\n      \"studentsCanViewOnEntity\" : true,\r\n      \"values\" : [ {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      }, {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      } ],\r\n      \"showToStudentsInExperience\" : true,\r\n      \"description\" : \"description\",\r\n      \"characterLimit\" : 2,\r\n      \"type\" : 5,\r\n      \"wordLimit\" : 2,\r\n      \"availableOnExternalEntityForm\" : true,\r\n      \"required\" : true,\r\n      \"hiddenFromSchoolAdminOnStudentProfile\" : true,\r\n      \"hiddenFromStaffOnStudentProfile\" : true,\r\n      \"conditionalDisplayValue\" : 1,\r\n      \"hiddenFromStudents\" : true,\r\n      \"name\" : \"name\",\r\n      \"id\" : 5,\r\n      \"maxMultiSelect\" : 7\r\n    } ],\r\n    \"approvalWorkflow\" : 4,\r\n    \"folder_id\" : 1,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  },\r\n  \"submission\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerFormDataResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerFormDataResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="coCurricularEventAttendeeControllerBulkDeleteAttendeesRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/attendees/delete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttendeesDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttendeesDelete([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromBody]CoCurricularEventAttendeeControllerBulkDeleteAttendeesRequest coCurricularEventAttendeeControllerBulkDeleteAttendeesRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="coCurricularEventAttendeeControllerBulkAddAttendeesToAttendance"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/attending")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttending")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesAttending([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromBody]CoCurricularEventAttendeeControllerBulkAddAttendeesToAttendance coCurricularEventAttendeeControllerBulkAddAttendeesToAttendance, [FromHeader (Name = "Authorization")]string authorization)
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
        /// CoCurricularGroupAnnouncement
        /// </summary>
        /// <remarks>CoCurricularGroupAnnouncement</remarks>
        /// <param name="coCurricularGroupAnnouncementControllerBulkDeleteAnnouncementRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Events/CoCurricular Events/api/consumer/v1/groups/messages/delete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchEventsCoCurricularEventsApiConsumerV1GroupsMessagesDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchEventsCoCurricularEventsApiConsumerV1GroupsMessagesDelete([FromBody]CoCurricularGroupAnnouncementControllerBulkDeleteAnnouncementRequest coCurricularGroupAnnouncementControllerBulkDeleteAnnouncementRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventDates"></param>
        /// <param name="coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/attendance/{co_curricular_event_dates}/rsvp-form-subs")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvpFormSubs")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse), description: "OK")]
        public virtual IActionResult PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementAttendanceByCoCurricularEventDatesRsvpFormSubs([FromRoute (Name = "co_curricular_event_dates")][Required]string coCurricularEventDates, [FromBody]CoCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"event_date_id\" : 1,\r\n  \"event_id\" : 0,\r\n  \"co_curricular_event_attendee_id\" : 6,\r\n  \"submission\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/rsvp/rsvp-data")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementRsvpRsvpData")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerEventRSVPResponse), description: "OK")]
        public virtual IActionResult PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementRsvpRsvpData([FromBody]CoCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerEventRSVPResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"eventEndDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"lastName\" : \"lastName\",\r\n  \"role\" : 6,\r\n  \"external_attendee_id\" : 7,\r\n  \"co_curricular_event_date_id\" : 0,\r\n  \"shiftStartTime\" : \"shiftStartTime\",\r\n  \"shiftEndTime\" : \"shiftEndTime\",\r\n  \"checkInMethod\" : 4,\r\n  \"firstName\" : \"firstName\",\r\n  \"user_id\" : 5,\r\n  \"school\" : \"school\",\r\n  \"co_curricular_event_id\" : 2,\r\n  \"shift_id\" : 5,\r\n  \"district\" : \"district\",\r\n  \"grade\" : 2,\r\n  \"id\" : 3,\r\n  \"eventStartDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"email\" : \"email\",\r\n  \"registration_form_submission_id\" : 9,\r\n  \"status\" : 1\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerEventRSVPResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerEventRSVPResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularEventAttendee
        /// </summary>
        /// <remarks>CoCurricularEventAttendee</remarks>
        /// <param name="coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Attenance/CoCurricular Events/api/consumer/v1/co-curricular-event-management/rsvp/subs-data")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementRsvpSubsData")]
        [SwaggerResponse(statusCode: 200, type: typeof(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse), description: "OK")]
        public virtual IActionResult PostAttenanceCoCurricularEventsApiConsumerV1CoCurricularEventManagementRsvpSubsData([FromBody]CoCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest coCurricularEventAttendeeControllerRequestRSVPSubmissionsRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"event_date_id\" : 1,\r\n  \"event_id\" : 0,\r\n  \"co_curricular_event_attendee_id\" : 6,\r\n  \"submission\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse>(exampleJson)
            : default(CoCurricularEventAttendeeControllerRSVPFormSubmissionResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// CoCurricularGroupAnnouncement
        /// </summary>
        /// <remarks>CoCurricularGroupAnnouncement</remarks>
        /// <param name="serviceGroups"></param>
        /// <param name="coCurricularGroupAnnouncementControllerCreateAnnouncementRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Events/CoCurricular Events/api/consumer/v1/groups/{service_groups}/messages/create")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostEventsCoCurricularEventsApiConsumerV1GroupsByServiceGroupsMessagesCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostEventsCoCurricularEventsApiConsumerV1GroupsByServiceGroupsMessagesCreate([FromRoute (Name = "service_groups")][Required]string serviceGroups, [FromBody]CoCurricularGroupAnnouncementControllerCreateAnnouncementRequest coCurricularGroupAnnouncementControllerCreateAnnouncementRequest, [FromHeader (Name = "Authorization")]string authorization)
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
