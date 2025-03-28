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
    public class DashboardApiController : ControllerBase
    { 
        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/dashboard")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1Dashboard")]
        public virtual IActionResult GetDashboardApiConsumerV1Dashboard([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/dashboard/badges")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1DashboardBadges")]
        public virtual IActionResult GetDashboardApiConsumerV1DashboardBadges([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/dashboard/outstanding-workflows")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1DashboardOutstandingWorkflows")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<OustandingStudentWorkflowResponse>), description: "OK")]
        public virtual IActionResult GetDashboardApiConsumerV1DashboardOutstandingWorkflows([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<OustandingStudentWorkflowResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"link\" : \"link\",\r\n  \"experienceName\" : \"experienceName\",\r\n  \"workflowName\" : \"workflowName\"\r\n}, {\r\n  \"link\" : \"link\",\r\n  \"experienceName\" : \"experienceName\",\r\n  \"workflowName\" : \"workflowName\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<OustandingStudentWorkflowResponse>>(exampleJson)
            : default(List<OustandingStudentWorkflowResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/pathwayos-dashboard")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1PathwayosDashboard")]
        [SwaggerResponse(statusCode: 200, type: typeof(PathwayOSAdminDashboardResponse), description: "OK")]
        public virtual IActionResult GetDashboardApiConsumerV1PathwayosDashboard([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PathwayOSAdminDashboardResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"studentUserExperienceTable\" : [ {\r\n    \"experienceOrganizationName\" : \"experienceOrganizationName\",\r\n    \"userExperienceId\" : 1,\r\n    \"studentSpecialPopulation\" : [ 6, 6 ],\r\n    \"failedToClockOut\" : 0,\r\n    \"experienceEndDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"experienceOrganizationId\" : 1,\r\n    \"timeLogsToBePartnerApproved\" : 9,\r\n    \"studentId\" : \"studentId\",\r\n    \"evaluationEventsTotal\" : 2,\r\n    \"experienceId\" : 1,\r\n    \"studentEmail\" : \"studentEmail\",\r\n    \"studentGrade\" : 7,\r\n    \"studentGender\" : 3,\r\n    \"studentUserId\" : 7,\r\n    \"schoolId\" : 6,\r\n    \"experienceClusters\" : [ \"experienceClusters\", \"experienceClusters\" ],\r\n    \"experienceName\" : \"experienceName\",\r\n    \"schoolName\" : \"schoolName\",\r\n    \"timeLogsToBeAdminApproved\" : 1,\r\n    \"workflowFormCompletedSignatures\" : 5,\r\n    \"studentFirstName\" : \"studentFirstName\",\r\n    \"totalApprovedHours\" : 7.457744773683766,\r\n    \"studentLastName\" : \"studentLastName\",\r\n    \"evaluationEventsToBeStudentSigned\" : 5,\r\n    \"evaluationEventsOverdueByPartner\" : 5,\r\n    \"overduePayPeriods\" : 4,\r\n    \"experienceStartDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"pendingPayPeriods\" : 2,\r\n    \"studentClusters\" : \"studentClusters\",\r\n    \"evaluationEventsCompleted\" : 4,\r\n    \"workflowFormTotalSignatures\" : 1,\r\n    \"studentRace\" : \"studentRace\"\r\n  }, {\r\n    \"experienceOrganizationName\" : \"experienceOrganizationName\",\r\n    \"userExperienceId\" : 1,\r\n    \"studentSpecialPopulation\" : [ 6, 6 ],\r\n    \"failedToClockOut\" : 0,\r\n    \"experienceEndDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"experienceOrganizationId\" : 1,\r\n    \"timeLogsToBePartnerApproved\" : 9,\r\n    \"studentId\" : \"studentId\",\r\n    \"evaluationEventsTotal\" : 2,\r\n    \"experienceId\" : 1,\r\n    \"studentEmail\" : \"studentEmail\",\r\n    \"studentGrade\" : 7,\r\n    \"studentGender\" : 3,\r\n    \"studentUserId\" : 7,\r\n    \"schoolId\" : 6,\r\n    \"experienceClusters\" : [ \"experienceClusters\", \"experienceClusters\" ],\r\n    \"experienceName\" : \"experienceName\",\r\n    \"schoolName\" : \"schoolName\",\r\n    \"timeLogsToBeAdminApproved\" : 1,\r\n    \"workflowFormCompletedSignatures\" : 5,\r\n    \"studentFirstName\" : \"studentFirstName\",\r\n    \"totalApprovedHours\" : 7.457744773683766,\r\n    \"studentLastName\" : \"studentLastName\",\r\n    \"evaluationEventsToBeStudentSigned\" : 5,\r\n    \"evaluationEventsOverdueByPartner\" : 5,\r\n    \"overduePayPeriods\" : 4,\r\n    \"experienceStartDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"pendingPayPeriods\" : 2,\r\n    \"studentClusters\" : \"studentClusters\",\r\n    \"evaluationEventsCompleted\" : 4,\r\n    \"workflowFormTotalSignatures\" : 1,\r\n    \"studentRace\" : \"studentRace\"\r\n  } ],\r\n  \"filterApplied\" : true\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PathwayOSAdminDashboardResponse>(exampleJson)
            : default(PathwayOSAdminDashboardResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/pathwayos-dashboard/actions")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1PathwayosDashboardActions")]
        [SwaggerResponse(statusCode: 200, type: typeof(PathwayOSAdminDashboardActionsResponse), description: "OK")]
        public virtual IActionResult GetDashboardApiConsumerV1PathwayosDashboardActions([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PathwayOSAdminDashboardActionsResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"numberOfPendingExternalContacts\" : 0,\r\n  \"numberOfActiveExperiences\" : 6\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PathwayOSAdminDashboardActionsResponse>(exampleJson)
            : default(PathwayOSAdminDashboardActionsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/pathwayos-dashboard-approvals")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1PathwayosDashboardApprovals")]
        [SwaggerResponse(statusCode: 200, type: typeof(DashboardHelperApprovalCounts), description: "OK")]
        public virtual IActionResult GetDashboardApiConsumerV1PathwayosDashboardApprovals([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DashboardHelperApprovalCounts));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"careerPlans\" : 2,\r\n  \"total\" : 6,\r\n  \"eventProposals\" : 7,\r\n  \"experienceProposals\" : 4,\r\n  \"activities\" : 1,\r\n  \"timeLogs\" : 2,\r\n  \"serviceProposals\" : 5,\r\n  \"orgs\" : 5,\r\n  \"contacts\" : 9,\r\n  \"serviceLogs\" : 0,\r\n  \"applications\" : 3\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<DashboardHelperApprovalCounts>(exampleJson)
            : default(DashboardHelperApprovalCounts);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Dashboard
        /// </summary>
        /// <remarks>Dashboard</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Dashboard/api/consumer/v1/pathwayos-dashboard/metrics")]
        [ValidateModelState]
        [SwaggerOperation("GetDashboardApiConsumerV1PathwayosDashboardMetrics")]
        [SwaggerResponse(statusCode: 200, type: typeof(PathwayOSAdminDashboardMetricsResponse), description: "OK")]
        public virtual IActionResult GetDashboardApiConsumerV1PathwayosDashboardMetrics([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PathwayOSAdminDashboardMetricsResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"averageHoursPerTimeLog\" : 5.637376656633329,\r\n  \"numberOfPartnerOrganizations\" : 2,\r\n  \"numberOfParticipatingStudents\" : 0,\r\n  \"numberOfPartnerContacts\" : 5,\r\n  \"numberOfExperiencesOffered\" : 1,\r\n  \"numberOfActivitiesOffered\" : 6,\r\n  \"numberOfCompletedHours\" : 7.061401241503109\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<PathwayOSAdminDashboardMetricsResponse>(exampleJson)
            : default(PathwayOSAdminDashboardMetricsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Tags Dashboard
        /// </summary>
        /// <remarks>Tags Dashboard</remarks>
        /// <param name="tagsDashboardRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Dashboard/api/consumer/v1/tags-dashboard/contacts")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostDashboardApiConsumerV1TagsDashboardContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ContactsTagsDashboardResponse>), description: "OK")]
        public virtual IActionResult PostDashboardApiConsumerV1TagsDashboardContacts([FromBody]TagsDashboardRequest tagsDashboardRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContactsTagsDashboardResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"contact\" : {\r\n    \"lastName\" : \"lastName\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"form_submission_id\" : 6,\r\n    \"title\" : \"title\",\r\n    \"created_by\" : 6,\r\n    \"mainNotes\" : \"mainNotes\",\r\n    \"firstName\" : \"firstName\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phone\" : \"phone\",\r\n    \"organization_id\" : 3,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}, {\r\n  \"contact\" : {\r\n    \"lastName\" : \"lastName\",\r\n    \"organizationName\" : \"organizationName\",\r\n    \"form_submission_id\" : 6,\r\n    \"title\" : \"title\",\r\n    \"created_by\" : 6,\r\n    \"mainNotes\" : \"mainNotes\",\r\n    \"firstName\" : \"firstName\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"phone\" : \"phone\",\r\n    \"organization_id\" : 3,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ContactsTagsDashboardResponse>>(exampleJson)
            : default(List<ContactsTagsDashboardResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Tags Dashboard
        /// </summary>
        /// <remarks>Tags Dashboard</remarks>
        /// <param name="tagsDashboardRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Dashboard/api/consumer/v1/tags-dashboard/experiences")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostDashboardApiConsumerV1TagsDashboardExperiences")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ExperiencesTagsDashboardResponse>), description: "OK")]
        public virtual IActionResult PostDashboardApiConsumerV1TagsDashboardExperiences([FromBody]TagsDashboardRequest tagsDashboardRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ExperiencesTagsDashboardResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"experience\" : {\r\n    \"organizationName\" : \"organizationName\",\r\n    \"reflection_form_approval\" : 2,\r\n    \"form_submission_id\" : 4,\r\n    \"contactName\" : \"contactName\",\r\n    \"conditional_badge_group_id\" : 7,\r\n    \"form_id\" : 5,\r\n    \"description\" : \"description\",\r\n    \"allowsTotalTimelogHoursSubmission\" : true,\r\n    \"contact_id\" : 3,\r\n    \"created_by\" : 5,\r\n    \"location_id\" : 6,\r\n    \"numberOfSpots\" : 2,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"reflection_form_id\" : 0,\r\n    \"organization_id\" : 1,\r\n    \"name\" : \"name\",\r\n    \"hideFromSearch\" : true,\r\n    \"id\" : 9,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}, {\r\n  \"experience\" : {\r\n    \"organizationName\" : \"organizationName\",\r\n    \"reflection_form_approval\" : 2,\r\n    \"form_submission_id\" : 4,\r\n    \"contactName\" : \"contactName\",\r\n    \"conditional_badge_group_id\" : 7,\r\n    \"form_id\" : 5,\r\n    \"description\" : \"description\",\r\n    \"allowsTotalTimelogHoursSubmission\" : true,\r\n    \"contact_id\" : 3,\r\n    \"created_by\" : 5,\r\n    \"location_id\" : 6,\r\n    \"numberOfSpots\" : 2,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"reflection_form_id\" : 0,\r\n    \"organization_id\" : 1,\r\n    \"name\" : \"name\",\r\n    \"hideFromSearch\" : true,\r\n    \"id\" : 9,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ExperiencesTagsDashboardResponse>>(exampleJson)
            : default(List<ExperiencesTagsDashboardResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Tags Dashboard
        /// </summary>
        /// <remarks>Tags Dashboards</remarks>
        /// <param name="tagsDashboardRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Dashboard/api/consumer/v1/tags-dashboard/organizations")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostDashboardApiConsumerV1TagsDashboardOrganizations")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<OrgsTagsDashboardResponse>), description: "OK")]
        public virtual IActionResult PostDashboardApiConsumerV1TagsDashboardOrganizations([FromBody]TagsDashboardRequest tagsDashboardRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<OrgsTagsDashboardResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"org\" : {\r\n    \"mainNotes\" : \"mainNotes\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"website\" : \"website\",\r\n    \"form_submission_id\" : 2,\r\n    \"phone\" : \"phone\",\r\n    \"locationDescription\" : \"locationDescription\",\r\n    \"name\" : \"name\",\r\n    \"id\" : 7,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n}, {\r\n  \"org\" : {\r\n    \"mainNotes\" : \"mainNotes\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"website\" : \"website\",\r\n    \"form_submission_id\" : 2,\r\n    \"phone\" : \"phone\",\r\n    \"locationDescription\" : \"locationDescription\",\r\n    \"name\" : \"name\",\r\n    \"id\" : 7,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"formResponse\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<OrgsTagsDashboardResponse>>(exampleJson)
            : default(List<OrgsTagsDashboardResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
