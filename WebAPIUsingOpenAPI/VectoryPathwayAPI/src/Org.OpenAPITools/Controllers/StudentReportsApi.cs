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
    public class StudentReportsApiController : ControllerBase
    { 
        /// <summary>
        /// Student Reports
        /// </summary>
        /// <remarks>Reports</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Student Reports/api/consumer/v1/student/report")]
        [ValidateModelState]
        [SwaggerOperation("GetStudentReportsApiConsumerV1StudentReport")]
        [SwaggerResponse(statusCode: 200, type: typeof(StudentReportResponse), description: "OK")]
        public virtual IActionResult GetStudentReportsApiConsumerV1StudentReport([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StudentReportResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"lifetimeHours\" : 0.8008281904610115,\r\n  \"hoursThisYear\" : 7.061401241503109,\r\n  \"pendingHours\" : 6.027456183070403,\r\n  \"hoursOverTime\" : [ {\r\n    \"hours\" : 5.962133916683182,\r\n    \"week\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"grade\" : 1\r\n  }, {\r\n    \"hours\" : 5.962133916683182,\r\n    \"week\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"grade\" : 1\r\n  } ],\r\n  \"goals\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 5,\r\n    \"value\" : 2.3021358869347655\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 5,\r\n    \"value\" : 2.3021358869347655\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StudentReportResponse>(exampleJson)
            : default(StudentReportResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Student Reports
        /// </summary>
        /// <remarks>Student Reports</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Student Reports/api/consumer/v1/student/report/serve")]
        [ValidateModelState]
        [SwaggerOperation("GetStudentReportsApiConsumerV1StudentReportServe")]
        [SwaggerResponse(statusCode: 200, type: typeof(StudentServeReportResponse), description: "OK")]
        public virtual IActionResult GetStudentReportsApiConsumerV1StudentReportServe([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StudentServeReportResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"totalHoursVerified\" : 2.3021358869347655,\r\n  \"lifetimeHours\" : 0.8008281904610115,\r\n  \"schoolSponsoredHours\" : 5.962133916683182,\r\n  \"numberServiceEvents\" : 5,\r\n  \"externalHours\" : 7.061401241503109,\r\n  \"years\" : [ {\r\n    \"isCurrent\" : true,\r\n    \"grade\" : 6,\r\n    \"id\" : 1\r\n  }, {\r\n    \"isCurrent\" : true,\r\n    \"grade\" : 6,\r\n    \"id\" : 1\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<StudentServeReportResponse>(exampleJson)
            : default(StudentServeReportResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Student Reports
        /// </summary>
        /// <remarks>Student Reports</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Student Reports/api/consumer/v1/student/report/serve/data")]
        [ValidateModelState]
        [SwaggerOperation("GetStudentReportsApiConsumerV1StudentReportServeData")]
        public virtual IActionResult GetStudentReportsApiConsumerV1StudentReportServeData([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }
    }
}
