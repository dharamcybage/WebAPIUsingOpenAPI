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
    public class TableViewApiController : ControllerBase
    { 
        /// <summary>
        /// Table View
        /// </summary>
        /// <remarks>Table View</remarks>
        /// <param name="tableViews"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Table View/api/consumer/v1/table-view/view/{table_views}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteTableViewApiConsumerV1TableViewViewByTableViews")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteTableViewApiConsumerV1TableViewViewByTableViews([FromRoute (Name = "table_views")][Required]string tableViews, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Table View
        /// </summary>
        /// <remarks>Table View</remarks>
        /// <param name="tableId"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Table View/api/consumer/v1/table-view/{tableId}/view")]
        [ValidateModelState]
        [SwaggerOperation("GetTableViewApiConsumerV1TableViewByTableIdView")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TableViewControllerTableViewDTO>), description: "OK")]
        public virtual IActionResult GetTableViewApiConsumerV1TableViewByTableIdView([FromRoute (Name = "tableId")][Required]string tableId, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TableViewControllerTableViewDTO>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"configuration\" : \"configuration\",\r\n  \"name\" : \"name\",\r\n  \"creatorId\" : 6,\r\n  \"tableId\" : \"tableId\",\r\n  \"id\" : 0\r\n}, {\r\n  \"configuration\" : \"configuration\",\r\n  \"name\" : \"name\",\r\n  \"creatorId\" : 6,\r\n  \"tableId\" : \"tableId\",\r\n  \"id\" : 0\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TableViewControllerTableViewDTO>>(exampleJson)
            : default(List<TableViewControllerTableViewDTO>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Table View
        /// </summary>
        /// <remarks>Table View</remarks>
        /// <param name="tableViews"></param>
        /// <param name="tableViewControllerEditTableViewRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Table View/api/consumer/v1/table-view/view/{table_views}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchTableViewApiConsumerV1TableViewViewByTableViews")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchTableViewApiConsumerV1TableViewViewByTableViews([FromRoute (Name = "table_views")][Required]string tableViews, [FromBody]TableViewControllerEditTableViewRequest tableViewControllerEditTableViewRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Table View
        /// </summary>
        /// <remarks>Table View</remarks>
        /// <param name="tableId"></param>
        /// <param name="tableViewControllerCreateTableViewRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Table View/api/consumer/v1/table-view/{tableId}/view")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostTableViewApiConsumerV1TableViewByTableIdView")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostTableViewApiConsumerV1TableViewByTableIdView([FromRoute (Name = "tableId")][Required]string tableId, [FromBody]TableViewControllerCreateTableViewRequest tableViewControllerCreateTableViewRequest, [FromHeader (Name = "Authorization")]string authorization)
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
