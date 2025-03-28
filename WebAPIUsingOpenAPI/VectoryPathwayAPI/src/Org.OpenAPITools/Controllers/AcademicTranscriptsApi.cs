/*
 * Pathwayos API
 *
 * Pathwayos API description
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using Microsoft.AspNetCore.Mvc;
using Org.OpenAPITools.Attributes;
using Swashbuckle.AspNetCore.Annotations;


namespace Org.OpenAPITools.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AcademicTranscriptsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Academic Transcripts/api/consumer/v1/academic-transcript/cancel-request/:transcriptRequestId</remarks>
        [HttpDelete]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcript/cancel-request/{transcriptRequestId}")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptCancelRequestTranscriptRequestIdDelete")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptCancelRequestTranscriptRequestIdDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Academic Transcripts/api/consumer/v1/academic-transcript/request/:type/:collegeid/:documentType</remarks>
        [HttpPost]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcript/request/{type}/{collegeid}/{documentType}")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptRequestTypeCollegeidDocumentTypePost")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptRequestTypeCollegeidDocumentTypePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Academic Transcripts/api/consumer/v1/academic-transcripts/:academic_transcript_upload</remarks>
        [HttpDelete]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcripts/{academic_transcript_upload}")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptsAcademicTranscriptUploadDelete")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptsAcademicTranscriptUploadDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Academic Transcripts/api/consumer/v1/academic-transcripts/:academic_transcript_upload/matches</remarks>
        [HttpGet]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcripts/{academic_transcript_upload}/matches")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptsAcademicTranscriptUploadMatchesGet")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptsAcademicTranscriptUploadMatchesGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Academic Transcripts/api/consumer/v1/academic-transcripts/generate-stream-url/:schools/:type</remarks>
        [HttpPost]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcripts/generate-stream-url/{schools}/{type}")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptsGenerateStreamUrlSchoolsTypePost")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptsGenerateStreamUrlSchoolsTypePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Academic Transcripts/api/consumer/v1/academic-transcripts</remarks>
        [HttpGet]
        [Route("/Academic Transcripts/api/consumer/v1/academic-transcripts")]
        [ValidateModelState]
        [SwaggerOperation("AcademicTranscriptsApiConsumerV1AcademicTranscriptsGet")]
        public virtual IActionResult AcademicTranscriptsApiConsumerV1AcademicTranscriptsGet()
        {


            throw new NotImplementedException();
        }
    }
}
