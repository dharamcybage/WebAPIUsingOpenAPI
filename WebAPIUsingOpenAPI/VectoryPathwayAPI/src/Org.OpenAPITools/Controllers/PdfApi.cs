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
    public class PdfApiController : ControllerBase
    { 
        /// <summary>
        /// Teacher Profile
        /// </summary>
        /// <remarks>Teacher Profile</remarks>
        /// <param name="pdfControllerPdfRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">Successful operation</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Pdf/api/consumer/v1/pdf/build")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostPdfApiConsumerV1PdfBuild")]
        public virtual IActionResult PostPdfApiConsumerV1PdfBuild([FromBody]PdfControllerPdfRequest pdfControllerPdfRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }
    }
}
