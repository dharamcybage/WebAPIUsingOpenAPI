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
    public class AssesmentApiController : ControllerBase
    { 
        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="onetOccupationExtraVideo"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Assesment/api/consumer/v1/assessments/extra-video/{onet_occupation_extra_video}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteAssesmentApiConsumerV1AssessmentsExtraVideoByOnetOccupationExtraVideo")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteAssesmentApiConsumerV1AssessmentsExtraVideoByOnetOccupationExtraVideo([FromRoute (Name = "onet_occupation_extra_video")][Required]string onetOccupationExtraVideo, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/assessments")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1Assessments")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentDTO>), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1Assessments([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"percentageComplete\" : 6.027456183070403,\r\n  \"answers\" : [ \"answers\", \"answers\" ],\r\n  \"questions\" : {\r\n    \"answerChoices\" : [ {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    }, {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    } ],\r\n    \"questions\" : [ {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    }, {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    } ]\r\n  },\r\n  \"riasecCodes\" : [ {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  }, {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  } ],\r\n  \"id\" : 0,\r\n  \"results\" : [ {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  }, {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  } ]\r\n}, {\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"percentageComplete\" : 6.027456183070403,\r\n  \"answers\" : [ \"answers\", \"answers\" ],\r\n  \"questions\" : {\r\n    \"answerChoices\" : [ {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    }, {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    } ],\r\n    \"questions\" : [ {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    }, {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    } ]\r\n  },\r\n  \"riasecCodes\" : [ {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  }, {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  } ],\r\n  \"id\" : 0,\r\n  \"results\" : [ {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  }, {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  } ]\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentDTO>>(exampleJson)
            : default(List<AssessmentDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>AAssesment</remarks>
        /// <param name="assessments"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/assessments/{assessments}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1AssessmentsByAssessments")]
        [SwaggerResponse(statusCode: 200, type: typeof(AssessmentDTO), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1AssessmentsByAssessments([FromRoute (Name = "assessments")][Required]string assessments, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AssessmentDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"percentageComplete\" : 6.027456183070403,\r\n  \"answers\" : [ \"answers\", \"answers\" ],\r\n  \"questions\" : {\r\n    \"answerChoices\" : [ {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    }, {\r\n      \"name\" : \"name\",\r\n      \"value\" : 1\r\n    } ],\r\n    \"questions\" : [ {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    }, {\r\n      \"area\" : \"area\",\r\n      \"index\" : 5,\r\n      \"text\" : \"text\"\r\n    } ]\r\n  },\r\n  \"riasecCodes\" : [ {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  }, {\r\n    \"area\" : \"area\",\r\n    \"score\" : 5.637376656633329\r\n  } ],\r\n  \"id\" : 0,\r\n  \"results\" : [ {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  }, {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AssessmentDTO>(exampleJson)
            : default(AssessmentDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="code"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/assessments/ocupation-data/{code}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1AssessmentsOcupationDataByCode")]
        [SwaggerResponse(statusCode: 200, type: typeof(OccupationDetailsResponse), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1AssessmentsOcupationDataByCode([FromRoute (Name = "code")][Required]string code, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(OccupationDetailsResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"extraVideoLinks\" : [ {\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"id\" : 5\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"link\" : \"link\",\r\n    \"id\" : 5\r\n  } ],\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"familyCode\" : \"familyCode\",\r\n  \"details\" : {\r\n    \"job_zone\" : {\r\n      \"job_zone_examples\" : \"job_zone_examples\",\r\n      \"education\" : \"education\",\r\n      \"job_training\" : \"job_training\",\r\n      \"title\" : \"title\",\r\n      \"related_experience\" : \"related_experience\",\r\n      \"value\" : 0\r\n    },\r\n    \"occupation\" : {\r\n      \"description\" : \"description\",\r\n      \"title\" : \"title\",\r\n      \"tags\" : {\r\n        \"bright_outlook\" : true\r\n      }\r\n    },\r\n    \"related_occupations\" : {\r\n      \"occupation\" : [ {\r\n        \"code\" : \"code\",\r\n        \"title\" : \"title\"\r\n      }, {\r\n        \"code\" : \"code\",\r\n        \"title\" : \"title\"\r\n      } ]\r\n    },\r\n    \"tasks\" : {\r\n      \"task\" : [ {\r\n        \"statement\" : \"statement\",\r\n        \"category\" : \"category\"\r\n      }, {\r\n        \"statement\" : \"statement\",\r\n        \"category\" : \"category\"\r\n      } ]\r\n    },\r\n    \"detailed_work_activities\" : {\r\n      \"activity\" : [ {\r\n        \"name\" : \"name\"\r\n      }, {\r\n        \"name\" : \"name\"\r\n      } ]\r\n    }\r\n  },\r\n  \"videoLink\" : \"videoLink\",\r\n  \"inList\" : true,\r\n  \"richText\" : \"richText\",\r\n  \"map\" : {\r\n    \"legend\" : {\r\n      \"width\" : 1,\r\n      \"content\" : \"content\",\r\n      \"height\" : 6\r\n    },\r\n    \"map\" : {\r\n      \"width\" : 1,\r\n      \"content\" : \"content\",\r\n      \"height\" : 6\r\n    }\r\n  },\r\n  \"outlook\" : {\r\n    \"salary\" : {\r\n      \"annual_median\" : 5.637376656633329\r\n    },\r\n    \"outlook\" : {\r\n      \"description\" : \"description\",\r\n      \"category\" : \"category\"\r\n    }\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<OccupationDetailsResponse>(exampleJson)
            : default(OccupationDetailsResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="questions"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/assessments/questions/{questions}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1AssessmentsQuestionsByQuestions")]
        [SwaggerResponse(statusCode: 200, type: typeof(AssessmentQuestionsDTO), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1AssessmentsQuestionsByQuestions([FromRoute (Name = "questions")][Required]string questions, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AssessmentQuestionsDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"answerChoices\" : [ {\r\n    \"name\" : \"name\",\r\n    \"value\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"value\" : 1\r\n  } ],\r\n  \"questions\" : [ {\r\n    \"area\" : \"area\",\r\n    \"index\" : 5,\r\n    \"text\" : \"text\"\r\n  }, {\r\n    \"area\" : \"area\",\r\n    \"index\" : 5,\r\n    \"text\" : \"text\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AssessmentQuestionsDTO>(exampleJson)
            : default(AssessmentQuestionsDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="users"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/assessments/student/{users}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1AssessmentsStudentByUsers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentResultDTO>), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1AssessmentsStudentByUsers([FromRoute (Name = "users")][Required]string users, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentResultDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"id\" : 0,\r\n  \"results\" : [ {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  }, {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  } ],\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}, {\r\n  \"id\" : 0,\r\n  \"results\" : [ {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  }, {\r\n    \"fit\" : \"fit\",\r\n    \"code\" : \"code\",\r\n    \"title\" : \"title\",\r\n    \"tags\" : {\r\n      \"green\" : true,\r\n      \"apprenticeship\" : true,\r\n      \"brightOutlook\" : true\r\n    }\r\n  } ],\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentResultDTO>>(exampleJson)
            : default(List<AssessmentResultDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/career-search/saved-careers")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1CareerSearchSavedCareers")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentControllerOccupationSearchResponse>), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1CareerSearchSavedCareers([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentControllerOccupationSearchResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n}, {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentControllerOccupationSearchResponse>>(exampleJson)
            : default(List<AssessmentControllerOccupationSearchResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="cluster"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/career-search/search/cluster/{cluster}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1CareerSearchSearchClusterByCluster")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentControllerOccupationSearchResponse>), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1CareerSearchSearchClusterByCluster([FromRoute (Name = "cluster")][Required]string cluster, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentControllerOccupationSearchResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n}, {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentControllerOccupationSearchResponse>>(exampleJson)
            : default(List<AssessmentControllerOccupationSearchResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="familyCode"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Assesment/api/consumer/v1/career-search/search/family/{familyCode}")]
        [ValidateModelState]
        [SwaggerOperation("GetAssesmentApiConsumerV1CareerSearchSearchFamilyByFamilyCode")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentControllerOccupationSearchResponse>), description: "OK")]
        public virtual IActionResult GetAssesmentApiConsumerV1CareerSearchSearchFamilyByFamilyCode([FromRoute (Name = "familyCode")][Required]string familyCode, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentControllerOccupationSearchResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n}, {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentControllerOccupationSearchResponse>>(exampleJson)
            : default(List<AssessmentControllerOccupationSearchResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="code"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Assesment/api/consumer/v1/assessments/toggle-career/{code}")]
        [ValidateModelState]
        [SwaggerOperation("PatchAssesmentApiConsumerV1AssessmentsToggleCareerByCode")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchAssesmentApiConsumerV1AssessmentsToggleCareerByCode([FromRoute (Name = "code")][Required]string code, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Assesment/api/consumer/v1/assessments")]
        [ValidateModelState]
        [SwaggerOperation("PostAssesmentApiConsumerV1Assessments")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult PostAssesmentApiConsumerV1Assessments([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="occupationExtraVideoRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Assesment/api/consumer/v1/assessments/post-extra-video")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAssesmentApiConsumerV1AssessmentsPostExtraVideo")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostAssesmentApiConsumerV1AssessmentsPostExtraVideo([FromBody]OccupationExtraVideoRequest occupationExtraVideoRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="occupationRichTextRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Assesment/api/consumer/v1/assessments/rich-text")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAssesmentApiConsumerV1AssessmentsRichText")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostAssesmentApiConsumerV1AssessmentsRichText([FromBody]OccupationRichTextRequest occupationRichTextRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="saveAssessmentRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Assesment/api/consumer/v1/assessments/save")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAssesmentApiConsumerV1AssessmentsSave")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostAssesmentApiConsumerV1AssessmentsSave([FromBody]SaveAssessmentRequest saveAssessmentRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Assesment
        /// </summary>
        /// <remarks>Assesment</remarks>
        /// <param name="searchRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Assesment/api/consumer/v1/career-search/search")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostAssesmentApiConsumerV1CareerSearchSearch")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AssessmentControllerOccupationSearchResponse>), description: "OK")]
        public virtual IActionResult PostAssesmentApiConsumerV1CareerSearchSearch([FromBody]SearchRequest searchRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AssessmentControllerOccupationSearchResponse>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n}, {\r\n  \"familyCode\" : \"familyCode\",\r\n  \"careerClusterId\" : \"careerClusterId\",\r\n  \"name\" : \"name\",\r\n  \"description\" : \"description\",\r\n  \"onetId\" : \"onetId\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AssessmentControllerOccupationSearchResponse>>(exampleJson)
            : default(List<AssessmentControllerOccupationSearchResponse>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
