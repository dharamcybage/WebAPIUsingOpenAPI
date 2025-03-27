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
    public class CaseloadsApiController : ControllerBase
    { 
        /// <summary>
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="users"></param>
        /// <param name="studentId"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}/student/{student_id}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteCaseloadsApiConsumerV1CaseloadByUsersStudentByStudentId")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteCaseloadsApiConsumerV1CaseloadByUsersStudentByStudentId([FromRoute (Name = "users")][Required]string users, [FromRoute (Name = "student_id")][Required]string studentId, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}")]
        [ValidateModelState]
        [SwaggerOperation("GetCaseloadsApiConsumerV1CaseloadByUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(TeacherCaseloadResponse), description: "OK")]
        public virtual IActionResult GetCaseloadsApiConsumerV1CaseloadByUsers([FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TeacherCaseloadResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"count\" : 0,\r\n  \"students\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ],\r\n  \"user\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TeacherCaseloadResponse>(exampleJson)
            : default(TeacherCaseloadResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Caseloads/api/consumer/v1/caseloads")]
        [ValidateModelState]
        [SwaggerOperation("GetCaseloadsApiConsumerV1Caseloads")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TeacherCaseloadResponse>), description: "OK")]
        public virtual IActionResult GetCaseloadsApiConsumerV1Caseloads([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TeacherCaseloadResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"count\" : 0,\r\n  \"students\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ],\r\n  \"user\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }\r\n}, {\r\n  \"count\" : 0,\r\n  \"students\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ],\r\n  \"user\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TeacherCaseloadResponse>>(exampleJson)
            : default(List<TeacherCaseloadResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// FilteredCaseloads
        /// </summary>
        /// <remarks>FilteredCaseloads</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Caseloads/api/consumer/v1/caseloads/filter/available")]
        [ValidateModelState]
        [SwaggerOperation("GetCaseloadsApiConsumerV1CaseloadsFilterAvailable")]
        [SwaggerResponse(statusCode: 200, type: typeof(AvailableCaseloadFiltersDTO), description: "OK")]
        public virtual IActionResult GetCaseloadsApiConsumerV1CaseloadsFilterAvailable([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AvailableCaseloadFiltersDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"courses\" : [ {\r\n    \"name\" : \"name\",\r\n    \"courseId\" : 0\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"courseId\" : 0\r\n  } ],\r\n  \"schools\" : [ {\r\n    \"districtId\" : 1,\r\n    \"schoolId\" : 6,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"districtId\" : 1,\r\n    \"schoolId\" : 6,\r\n    \"name\" : \"name\"\r\n  } ],\r\n  \"subjects\" : [ {\r\n    \"name\" : \"name\",\r\n    \"subjectId\" : 5\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"subjectId\" : 5\r\n  } ],\r\n  \"districts\" : [ {\r\n    \"districtId\" : 5,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"districtId\" : 5,\r\n    \"name\" : \"name\"\r\n  } ],\r\n  \"grades\" : [ {\r\n    \"gradeId\" : 2,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"gradeId\" : 2,\r\n    \"name\" : \"name\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AvailableCaseloadFiltersDTO>(exampleJson)
            : default(AvailableCaseloadFiltersDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// FilteredCaseloads
        /// </summary>
        /// <remarks>FilteredCaseloads</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Caseloads/api/consumer/v1/caseloads/filter/current")]
        [ValidateModelState]
        [SwaggerOperation("GetCaseloadsApiConsumerV1CaseloadsFilterCurrent")]
        [SwaggerResponse(statusCode: 200, type: typeof(AvailableCaseloadFiltersDTO), description: "OK")]
        public virtual IActionResult GetCaseloadsApiConsumerV1CaseloadsFilterCurrent([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AvailableCaseloadFiltersDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"courses\" : [ {\r\n    \"name\" : \"name\",\r\n    \"courseId\" : 0\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"courseId\" : 0\r\n  } ],\r\n  \"schools\" : [ {\r\n    \"districtId\" : 1,\r\n    \"schoolId\" : 6,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"districtId\" : 1,\r\n    \"schoolId\" : 6,\r\n    \"name\" : \"name\"\r\n  } ],\r\n  \"subjects\" : [ {\r\n    \"name\" : \"name\",\r\n    \"subjectId\" : 5\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"subjectId\" : 5\r\n  } ],\r\n  \"districts\" : [ {\r\n    \"districtId\" : 5,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"districtId\" : 5,\r\n    \"name\" : \"name\"\r\n  } ],\r\n  \"grades\" : [ {\r\n    \"gradeId\" : 2,\r\n    \"name\" : \"name\"\r\n  }, {\r\n    \"gradeId\" : 2,\r\n    \"name\" : \"name\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AvailableCaseloadFiltersDTO>(exampleJson)
            : default(AvailableCaseloadFiltersDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}/add/students")]
        [ValidateModelState]
        [SwaggerOperation("PatchCaseloadsApiConsumerV1CaseloadByUsersAddStudents")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<long>), description: "OK")]
        public virtual IActionResult PatchCaseloadsApiConsumerV1CaseloadByUsersAddStudents([FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<long>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ 0, 0 ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<long>>(exampleJson)
            : default(List<long>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Upload Caseload
        /// </summary>
        /// <remarks>Upload Caseload</remarks>
        /// <param name="users"></param>
        /// <param name="uploadCaseloadRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}/csv")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchCaseloadsApiConsumerV1CaseloadByUsersCsv")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchCaseloadsApiConsumerV1CaseloadByUsersCsv([FromRoute (Name = "users")][Required]string users, [FromBody]UploadCaseloadRequest uploadCaseloadRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}/remove/students")]
        [ValidateModelState]
        [SwaggerOperation("PatchCaseloadsApiConsumerV1CaseloadByUsersRemoveStudents")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<long>), description: "OK")]
        public virtual IActionResult PatchCaseloadsApiConsumerV1CaseloadByUsersRemoveStudents([FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<long>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ 0, 0 ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<long>>(exampleJson)
            : default(List<long>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Caseloads
        /// </summary>
        /// <remarks>Caseloads</remarks>
        /// <param name="users"></param>
        /// <param name="studentId"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Caseloads/api/consumer/v1/caseload/{users}/student/{student_id}")]
        [ValidateModelState]
        [SwaggerOperation("PatchCaseloadsApiConsumerV1CaseloadByUsersStudentByStudentId")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchCaseloadsApiConsumerV1CaseloadByUsersStudentByStudentId([FromRoute (Name = "users")][Required]string users, [FromRoute (Name = "student_id")][Required]string studentId, [FromHeader (Name = "Authorization")]string authorization)
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
        /// CaseloadFilter
        /// </summary>
        /// <remarks>CaseloadFilter</remarks>
        /// <param name="caseloadFilterRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Caseloads/api/consumer/v1/caseloads/filter")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostCaseloadsApiConsumerV1CaseloadsFilter")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostCaseloadsApiConsumerV1CaseloadsFilter([FromBody]CaseloadFilterRequest caseloadFilterRequest, [FromHeader (Name = "Authorization")]string authorization)
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
