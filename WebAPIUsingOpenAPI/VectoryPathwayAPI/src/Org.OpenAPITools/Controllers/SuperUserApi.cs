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
    public class SuperUserApiController : ControllerBase
    { 
        /// <summary>
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="districtApiKeys"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Super User/api/consumer/v1/super-user/api-key/{district_api_keys}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteSuperUserApiConsumerV1SuperUserApiKeyByDistrictApiKeys")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteSuperUserApiConsumerV1SuperUserApiKeyByDistrictApiKeys([FromRoute (Name = "district_api_keys")][Required]string districtApiKeys, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Super User/api/consumer/v1/super-user/info")]
        [ValidateModelState]
        [SwaggerOperation("GetSuperUserApiConsumerV1SuperUserInfo")]
        [SwaggerResponse(statusCode: 200, type: typeof(SuperUserInformationResponse), description: "OK")]
        public virtual IActionResult GetSuperUserApiConsumerV1SuperUserInfo([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SuperUserInformationResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"districts\" : [ {\r\n    \"oneRosterConfig\" : \"{}\",\r\n    \"sftpPassword\" : \"sftpPassword\",\r\n    \"apiKeys\" : [ {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"createdBy\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\",\r\n        \"role\" : 1,\r\n        \"school\" : \"school\",\r\n        \"grade\" : 6,\r\n        \"id\" : 5,\r\n        \"profileImageUrl\" : \"profileImageUrl\",\r\n        \"email\" : \"email\"\r\n      },\r\n      \"id\" : 2,\r\n      \"created_by_id\" : 7,\r\n      \"district_id\" : 9,\r\n      \"key\" : \"key\"\r\n    }, {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"createdBy\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\",\r\n        \"role\" : 1,\r\n        \"school\" : \"school\",\r\n        \"grade\" : 6,\r\n        \"id\" : 5,\r\n        \"profileImageUrl\" : \"profileImageUrl\",\r\n        \"email\" : \"email\"\r\n      },\r\n      \"id\" : 2,\r\n      \"created_by_id\" : 7,\r\n      \"district_id\" : 9,\r\n      \"key\" : \"key\"\r\n    } ],\r\n    \"cleverDistrictId\" : \"cleverDistrictId\",\r\n    \"ncesID\" : \"ncesID\",\r\n    \"classlinkTenantId\" : \"classlinkTenantId\",\r\n    \"googleDomain\" : \"googleDomain\",\r\n    \"uploadLogs\" : [ null, null ],\r\n    \"microsoftDomain\" : \"microsoftDomain\",\r\n    \"arrowsLink\" : \"arrowsLink\",\r\n    \"schools\" : [ {\r\n      \"ssoId\" : \"ssoId\",\r\n      \"teachers\" : 6,\r\n      \"oneRosterId\" : \"oneRosterId\",\r\n      \"name\" : \"name\",\r\n      \"ncesId\" : \"ncesId\",\r\n      \"students\" : 5,\r\n      \"id\" : 5,\r\n      \"internalCode\" : \"internalCode\",\r\n      \"administrators\" : 1\r\n    }, {\r\n      \"ssoId\" : \"ssoId\",\r\n      \"teachers\" : 6,\r\n      \"oneRosterId\" : \"oneRosterId\",\r\n      \"name\" : \"name\",\r\n      \"ncesId\" : \"ncesId\",\r\n      \"students\" : 5,\r\n      \"id\" : 5,\r\n      \"internalCode\" : \"internalCode\",\r\n      \"administrators\" : 1\r\n    } ],\r\n    \"authenticationMethod\" : 3,\r\n    \"name\" : \"name\",\r\n    \"id\" : 0,\r\n    \"samlMetadata\" : \"samlMetadata\"\r\n  }, {\r\n    \"oneRosterConfig\" : \"{}\",\r\n    \"sftpPassword\" : \"sftpPassword\",\r\n    \"apiKeys\" : [ {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"createdBy\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\",\r\n        \"role\" : 1,\r\n        \"school\" : \"school\",\r\n        \"grade\" : 6,\r\n        \"id\" : 5,\r\n        \"profileImageUrl\" : \"profileImageUrl\",\r\n        \"email\" : \"email\"\r\n      },\r\n      \"id\" : 2,\r\n      \"created_by_id\" : 7,\r\n      \"district_id\" : 9,\r\n      \"key\" : \"key\"\r\n    }, {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"createdBy\" : {\r\n        \"firstName\" : \"firstName\",\r\n        \"lastName\" : \"lastName\",\r\n        \"role\" : 1,\r\n        \"school\" : \"school\",\r\n        \"grade\" : 6,\r\n        \"id\" : 5,\r\n        \"profileImageUrl\" : \"profileImageUrl\",\r\n        \"email\" : \"email\"\r\n      },\r\n      \"id\" : 2,\r\n      \"created_by_id\" : 7,\r\n      \"district_id\" : 9,\r\n      \"key\" : \"key\"\r\n    } ],\r\n    \"cleverDistrictId\" : \"cleverDistrictId\",\r\n    \"ncesID\" : \"ncesID\",\r\n    \"classlinkTenantId\" : \"classlinkTenantId\",\r\n    \"googleDomain\" : \"googleDomain\",\r\n    \"uploadLogs\" : [ null, null ],\r\n    \"microsoftDomain\" : \"microsoftDomain\",\r\n    \"arrowsLink\" : \"arrowsLink\",\r\n    \"schools\" : [ {\r\n      \"ssoId\" : \"ssoId\",\r\n      \"teachers\" : 6,\r\n      \"oneRosterId\" : \"oneRosterId\",\r\n      \"name\" : \"name\",\r\n      \"ncesId\" : \"ncesId\",\r\n      \"students\" : 5,\r\n      \"id\" : 5,\r\n      \"internalCode\" : \"internalCode\",\r\n      \"administrators\" : 1\r\n    }, {\r\n      \"ssoId\" : \"ssoId\",\r\n      \"teachers\" : 6,\r\n      \"oneRosterId\" : \"oneRosterId\",\r\n      \"name\" : \"name\",\r\n      \"ncesId\" : \"ncesId\",\r\n      \"students\" : 5,\r\n      \"id\" : 5,\r\n      \"internalCode\" : \"internalCode\",\r\n      \"administrators\" : 1\r\n    } ],\r\n    \"authenticationMethod\" : 3,\r\n    \"name\" : \"name\",\r\n    \"id\" : 0,\r\n    \"samlMetadata\" : \"samlMetadata\"\r\n  } ],\r\n  \"users\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<SuperUserInformationResponse>(exampleJson)
            : default(SuperUserInformationResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="oneRosterConfigs"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Super User/api/consumer/v1/super-user/one-roster/{one_roster_configs}")]
        [ValidateModelState]
        [SwaggerOperation("GetSuperUserApiConsumerV1SuperUserOneRosterByOneRosterConfigs")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Org>), description: "OK")]
        public virtual IActionResult GetSuperUserApiConsumerV1SuperUserOneRosterByOneRosterConfigs([FromRoute (Name = "one_roster_configs")][Required]string oneRosterConfigs, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Org>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"sourcedId\" : \"sourcedId\",\r\n  \"status\" : \"status\"\r\n}, {\r\n  \"sourcedId\" : \"sourcedId\",\r\n  \"status\" : \"status\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Org>>(exampleJson)
            : default(List<Org>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="districts"></param>
        /// <param name="updateDistrictSuperUserAuthRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Super User/api/consumer/v1/super-user/auth/{districts}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchSuperUserApiConsumerV1SuperUserAuthByDistricts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchSuperUserApiConsumerV1SuperUserAuthByDistricts([FromRoute (Name = "districts")][Required]string districts, [FromBody]UpdateDistrictSuperUserAuthRequest updateDistrictSuperUserAuthRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="oneRosterConfigs"></param>
        /// <param name="createOneRosterRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Super User/api/consumer/v1/super-user/one-roster/{one_roster_configs}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchSuperUserApiConsumerV1SuperUserOneRosterByOneRosterConfigs")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchSuperUserApiConsumerV1SuperUserOneRosterByOneRosterConfigs([FromRoute (Name = "one_roster_configs")][Required]string oneRosterConfigs, [FromBody]CreateOneRosterRequest createOneRosterRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="schools"></param>
        /// <param name="superUserUpdateSchoolRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Super User/api/consumer/v1/super-user/school/{schools}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchSuperUserApiConsumerV1SuperUserSchoolBySchools")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchSuperUserApiConsumerV1SuperUserSchoolBySchools([FromRoute (Name = "schools")][Required]string schools, [FromBody]SuperUserUpdateSchoolRequest superUserUpdateSchoolRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="districts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Super User/api/consumer/v1/super-user/api-key/{districts}")]
        [ValidateModelState]
        [SwaggerOperation("PostSuperUserApiConsumerV1SuperUserApiKeyByDistricts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostSuperUserApiConsumerV1SuperUserApiKeyByDistricts([FromRoute (Name = "districts")][Required]string districts, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="createSuperUserRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Super User/api/consumer/v1/super-user/create")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSuperUserApiConsumerV1SuperUserCreate")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostSuperUserApiConsumerV1SuperUserCreate([FromBody]CreateSuperUserRequest createSuperUserRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Super User
        /// </summary>
        /// <remarks>Super User</remarks>
        /// <param name="districts"></param>
        /// <param name="createOneRosterRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Super User/api/consumer/v1/super-user/one-roster/{districts}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostSuperUserApiConsumerV1SuperUserOneRosterByDistricts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostSuperUserApiConsumerV1SuperUserOneRosterByDistricts([FromRoute (Name = "districts")][Required]string districts, [FromBody]CreateOneRosterRequest createOneRosterRequest, [FromHeader (Name = "Authorization")]string authorization)
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
