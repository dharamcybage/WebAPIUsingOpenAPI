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
    public class StoreCodeApiController : ControllerBase
    { 
        /// <summary>
        /// Store Code
        /// </summary>
        /// <remarks>Store Code</remarks>
        /// <param name="storeCodes"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Store Code/api/consumer/v1/store-codes/{store_codes}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteStoreCodeApiConsumerV1StoreCodesByStoreCodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteStoreCodeApiConsumerV1StoreCodesByStoreCodes([FromRoute (Name = "store_codes")][Required]string storeCodes, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Store Code
        /// </summary>
        /// <remarks>Store Code</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Store Code/api/consumer/v1/store-codes")]
        [ValidateModelState]
        [SwaggerOperation("GetStoreCodeApiConsumerV1StoreCodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<StoreCodeDTO>), description: "OK")]
        public virtual IActionResult GetStoreCodeApiConsumerV1StoreCodes([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<StoreCodeDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"displayName\" : \"displayName\",\r\n  \"sisName\" : \"sisName\",\r\n  \"id\" : 0\r\n}, {\r\n  \"displayName\" : \"displayName\",\r\n  \"sisName\" : \"sisName\",\r\n  \"id\" : 0\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<StoreCodeDTO>>(exampleJson)
            : default(List<StoreCodeDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Store Code
        /// </summary>
        /// <remarks>Store Code</remarks>
        /// <param name="storeCodes"></param>
        /// <param name="storeCodeControllerEditStoreCodeRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Store Code/api/consumer/v1/store-codes/{store_codes}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchStoreCodeApiConsumerV1StoreCodesByStoreCodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchStoreCodeApiConsumerV1StoreCodesByStoreCodes([FromRoute (Name = "store_codes")][Required]string storeCodes, [FromBody]StoreCodeControllerEditStoreCodeRequest storeCodeControllerEditStoreCodeRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Store Code
        /// </summary>
        /// <remarks>Store Code</remarks>
        /// <param name="storeCodeControllerCreateStoreCodeRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Store Code/api/consumer/v1/store-codes")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostStoreCodeApiConsumerV1StoreCodes")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostStoreCodeApiConsumerV1StoreCodes([FromBody]StoreCodeControllerCreateStoreCodeRequest storeCodeControllerCreateStoreCodeRequest, [FromHeader (Name = "Authorization")]string authorization)
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
