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
    public class ScholarshipApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Scholarship/api/consumer/v1/scholarship/all</remarks>
        [HttpGet]
        [Route("/Scholarship/api/consumer/v1/scholarship/all")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipAllGet")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipAllGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Scholarship/api/consumer/v1/scholarship/bulk/activeness</remarks>
        [HttpPatch]
        [Route("/Scholarship/api/consumer/v1/scholarship/bulk/activeness")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipBulkActivenessPatch")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipBulkActivenessPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Scholarship/api/consumer/v1/scholarship/new</remarks>
        [HttpPost]
        [Route("/Scholarship/api/consumer/v1/scholarship/new")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipNewPost")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipNewPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Scholarship/api/consumer/v1/scholarship</remarks>
        [HttpPost]
        [Route("/Scholarship/api/consumer/v1/scholarship")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipPost")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Scholarship/api/consumer/v1/scholarship/:scholarships</remarks>
        [HttpDelete]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsDelete")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Scholarship/api/consumer/v1/scholarship/:scholarships</remarks>
        [HttpGet]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsGet")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Scholarship/api/consumer/v1/scholarship/:scholarships</remarks>
        [HttpPatch]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsPatch")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Scholarship/api/consumer/v1/scholarship/:scholarships</remarks>
        [HttpPost]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsPost")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Scholarship/api/consumer/v1/scholarship/:scholarships/student/:users/add</remarks>
        [HttpPost]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}/student/{users}/add")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsStudentUsersAddPost")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsStudentUsersAddPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Scholarship/api/consumer/v1/scholarship/:scholarships/students</remarks>
        [HttpGet]
        [Route("/Scholarship/api/consumer/v1/scholarship/{scholarships}/students")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipScholarshipsStudentsGet")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipScholarshipsStudentsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Scholarship/api/consumer/v1/scholarships/default</remarks>
        [HttpGet]
        [Route("/Scholarship/api/consumer/v1/scholarships/default")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipsDefaultGet")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipsDefaultGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Scholarship/api/consumer/v1/scholarships/district</remarks>
        [HttpGet]
        [Route("/Scholarship/api/consumer/v1/scholarships/district")]
        [ValidateModelState]
        [SwaggerOperation("ScholarshipApiConsumerV1ScholarshipsDistrictGet")]
        public virtual IActionResult ScholarshipApiConsumerV1ScholarshipsDistrictGet()
        {


            throw new NotImplementedException();
        }
    }
}
