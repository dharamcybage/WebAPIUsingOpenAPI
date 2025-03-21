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
    public class CollegeApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applicants/:collegeId</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applicants/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicantsCollegeIdGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicantsCollegeIdGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applicants/:collegeId/:status/:year</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applicants/{collegeId}/{status}/{year}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicantsCollegeIdStatusYearGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicantsCollegeIdStatusYearGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applications/additional-document-bundles/:collegeId</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applications/additional-document-bundles/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsAdditionalDocumentBundlesCollegeIdGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsAdditionalDocumentBundlesCollegeIdGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/applications/additional-document-bundles/:collegeId/:transcriptType</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/applications/additional-document-bundles/{collegeId}/{transcriptType}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsAdditionalDocumentBundlesCollegeIdTranscriptTypePost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsAdditionalDocumentBundlesCollegeIdTranscriptTypePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applications/attending</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applications/attending")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsAttendingGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsAttendingGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/attending/reset</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/attending/reset")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsAttendingResetPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsAttendingResetPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/attending/select</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/attending/select")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsAttendingSelectPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsAttendingSelectPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /College/api/consumer/v1/college/applications/document-bundle/:college_application_additional_documents</remarks>
        [HttpDelete]
        [Route("/College/api/consumer/v1/college/applications/document-bundle/{college_application_additional_documents}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeApplicationAdditionalDocumentsDelete")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeApplicationAdditionalDocumentsDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applications/document-bundle/:collegeId</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applications/document-bundle/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeIdGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeIdGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/document-bundle/:collegeId</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/document-bundle/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsDocumentBundleCollegeIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/applications/document-bundle/upload/:additional_college_doc_types</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/applications/document-bundle/upload/{additional_college_doc_types}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsDocumentBundleUploadAdditionalCollegeDocTypesPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsDocumentBundleUploadAdditionalCollegeDocTypesPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applications</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applications")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/notes/:collegeId</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/notes/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsNotesCollegeIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsNotesCollegeIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/applications</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/applications")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /College/api/consumer/v1/college/applications/status/:collegeId</remarks>
        [HttpDelete]
        [Route("/College/api/consumer/v1/college/applications/status/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdDelete")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/status/:collegeId/:status/:destination/application-form</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/status/{collegeId}/{status}/{destination}/application-form")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusDestinationApplicationFormPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusDestinationApplicationFormPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/status/:collegeId/:status</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/status/{collegeId}/{status}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/applications/status/:collegeId/:status/test-scores</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/applications/status/{collegeId}/{status}/test-scores")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusTestScoresPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStatusCollegeIdStatusTestScoresPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/applications/student</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/applications/student")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStudentGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStudentGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/applications/student/:studentId/add</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/applications/student/{studentId}/add")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeApplicationsStudentStudentIdAddPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeApplicationsStudentStudentIdAddPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/brag-sheets/:form_submissions</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/brag-sheets/{form_submissions}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeBragSheetsFormSubmissionsPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeBragSheetsFormSubmissionsPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/brag-sheets/metadata</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/brag-sheets/metadata")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeBragSheetsMetadataGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeBragSheetsMetadataGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/email-update/:collegeId</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/email-update/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeEmailUpdateCollegeIdPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeEmailUpdateCollegeIdPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/:id</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/{id}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeIdGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeIdGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/:id/scattergrams</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/{id}/scattergrams")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeIdScattergramsGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeIdScattergramsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/lor/brag-sheet-data/:users</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/lor/brag-sheet-data/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorBragSheetDataUsersGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorBragSheetDataUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/lor</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/lor")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/lor/:letter_of_rec_teacher</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/lor/{letter_of_rec_teacher}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorLetterOfRecTeacherPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorLetterOfRecTeacherPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/lor/student</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/lor/student")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorStudentPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorStudentPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/lors/form</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/lors/form")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorsFormGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorsFormGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/lors</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/lors")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorsGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/lors/staff</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/lors/staff")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeLorsStaffGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeLorsStaffGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/opt-out-ca/:id</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/opt-out-ca/{id}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeOptOutCaIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeOptOutCaIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/progress/admin</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/progress/admin")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressAdminGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressAdminGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/progress/ca-form-status/:collegeId</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/progress/ca-form-status/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressCaFormStatusCollegeIdGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressCaFormStatusCollegeIdGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/progress/dates/add/:collegeId</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/progress/dates/add/{collegeId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressDatesAddCollegeIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressDatesAddCollegeIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/progress/essays</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/progress/essays")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressEssaysGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressEssaysGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /College/api/consumer/v1/college/progress/essays</remarks>
        [HttpPost]
        [Route("/College/api/consumer/v1/college/progress/essays")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressEssaysPost")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressEssaysPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/progress/essays/toggle/:collegeId/:college_essays</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/progress/essays/toggle/{collegeId}/{college_essays}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressEssaysToggleCollegeIdCollegeEssaysPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressEssaysToggleCollegeIdCollegeEssaysPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/progress/lors/toggle/:collegeId/:lorId</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/progress/lors/toggle/{collegeId}/{lorId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressLorsToggleCollegeIdLorIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressLorsToggleCollegeIdLorIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/progress/overall</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/progress/overall")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressOverallGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressOverallGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /College/api/consumer/v1/college/progress/recommenders/toggle/:collegeId/:recommenderId</remarks>
        [HttpPatch]
        [Route("/College/api/consumer/v1/college/progress/recommenders/toggle/{collegeId}/{recommenderId}")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressRecommendersToggleCollegeIdRecommenderIdPatch")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressRecommendersToggleCollegeIdRecommenderIdPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /College/api/consumer/v1/college/progress/refresh-from-ca</remarks>
        [HttpGet]
        [Route("/College/api/consumer/v1/college/progress/refresh-from-ca")]
        [ValidateModelState]
        [SwaggerOperation("CollegeApiConsumerV1CollegeProgressRefreshFromCaGet")]
        public virtual IActionResult CollegeApiConsumerV1CollegeProgressRefreshFromCaGet()
        {


            throw new NotImplementedException();
        }
    }
}
