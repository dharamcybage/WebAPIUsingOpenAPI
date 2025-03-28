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
    public class DocumentApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/colleges</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/colleges")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterCollegesGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterCollegesGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Document/api/consumer/v1/document-center/document-types/:additional_college_doc_types</remarks>
        [HttpDelete]
        [Route("/Document/api/consumer/v1/document-center/document-types/{additional_college_doc_types}")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterDocumentTypesAdditionalCollegeDocTypesDelete")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterDocumentTypesAdditionalCollegeDocTypesDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Document/api/consumer/v1/document-center/document-types/:additional_college_doc_types</remarks>
        [HttpPatch]
        [Route("/Document/api/consumer/v1/document-center/document-types/{additional_college_doc_types}")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterDocumentTypesAdditionalCollegeDocTypesPatch")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterDocumentTypesAdditionalCollegeDocTypesPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/document-types</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/document-types")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterDocumentTypesGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterDocumentTypesGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Document/api/consumer/v1/document-center/document-types</remarks>
        [HttpPost]
        [Route("/Document/api/consumer/v1/document-center/document-types")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterDocumentTypesPost")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterDocumentTypesPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/requests/bundle-url/:document_bundle_requests</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/requests/bundle-url/{document_bundle_requests}")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsBundleUrlDocumentBundleRequestsGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsBundleUrlDocumentBundleRequestsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Document/api/consumer/v1/document-center/requests/:document_bundle_requests/complete</remarks>
        [HttpPatch]
        [Route("/Document/api/consumer/v1/document-center/requests/{document_bundle_requests}/complete")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsCompletePatch")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsCompletePatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Document/api/consumer/v1/document-center/requests/:document_bundle_requests/nch</remarks>
        [HttpPatch]
        [Route("/Document/api/consumer/v1/document-center/requests/{document_bundle_requests}/nch")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsNchPatch")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsNchPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Document/api/consumer/v1/document-center/requests/:document_bundle_requests/reject</remarks>
        [HttpPatch]
        [Route("/Document/api/consumer/v1/document-center/requests/{document_bundle_requests}/reject")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsRejectPatch")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsDocumentBundleRequestsRejectPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/requests</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/requests")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Document/api/consumer/v1/document-center/requests-standalone</remarks>
        [HttpPost]
        [Route("/Document/api/consumer/v1/document-center/requests-standalone")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterRequestsStandalonePost")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterRequestsStandalonePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/school-profile</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/school-profile")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterSchoolProfileGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterSchoolProfileGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Document/api/consumer/v1/document-center/school-profile</remarks>
        [HttpPatch]
        [Route("/Document/api/consumer/v1/document-center/school-profile")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterSchoolProfilePatch")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterSchoolProfilePatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Document/api/consumer/v1/document-center/transcripts/:users/count</remarks>
        [HttpGet]
        [Route("/Document/api/consumer/v1/document-center/transcripts/{users}/count")]
        [ValidateModelState]
        [SwaggerOperation("DocumentApiConsumerV1DocumentCenterTranscriptsUsersCountGet")]
        public virtual IActionResult DocumentApiConsumerV1DocumentCenterTranscriptsUsersCountGet()
        {


            throw new NotImplementedException();
        }
    }
}
