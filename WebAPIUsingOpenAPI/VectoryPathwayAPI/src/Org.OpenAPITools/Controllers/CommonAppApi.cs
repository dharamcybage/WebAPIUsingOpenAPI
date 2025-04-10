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
    public class CommonAppApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Common App/api/consumer/v1/admin-ca-checklist/counselor-list</remarks>
        [HttpPatch]
        [Route("/Common App/api/consumer/v1/admin-ca-checklist/counselor-list")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1AdminCaChecklistCounselorListPatch")]
        public virtual IActionResult CommonAppApiConsumerV1AdminCaChecklistCounselorListPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Common App/api/consumer/v1/admin-ca-checklist/delivery-center-users</remarks>
        [HttpPatch]
        [Route("/Common App/api/consumer/v1/admin-ca-checklist/delivery-center-users")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1AdminCaChecklistDeliveryCenterUsersPatch")]
        public virtual IActionResult CommonAppApiConsumerV1AdminCaChecklistDeliveryCenterUsersPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/admin-ca-checklist</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/admin-ca-checklist")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1AdminCaChecklistGet")]
        public virtual IActionResult CommonAppApiConsumerV1AdminCaChecklistGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Common App/api/consumer/v1/admin-ca-checklist/signature</remarks>
        [HttpPatch]
        [Route("/Common App/api/consumer/v1/admin-ca-checklist/signature")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1AdminCaChecklistSignaturePatch")]
        public virtual IActionResult CommonAppApiConsumerV1AdminCaChecklistSignaturePatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/colleges/:users</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/colleges/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsCollegesUsersGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsCollegesUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/data</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/data")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsDataGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsDataGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/early-decisions/:users/:type</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/early-decisions/{users}/{type}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsEarlyDecisionsUsersTypeGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsEarlyDecisionsUsersTypeGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/early-decisions/:users/:type</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/early-decisions/{users}/{type}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsEarlyDecisionsUsersTypePost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsEarlyDecisionsUsersTypePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/fee-waiver/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/fee-waiver/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsFeeWaiverUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsFeeWaiverUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/final-report/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/final-report/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsFinalReportUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsFinalReportUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/final-transcript/:users</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/final-transcript/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsFinalTranscriptUsersGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsFinalTranscriptUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/form-submission-data/:type/:users</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/form-submission-data/{type}/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsFormSubmissionDataTypeUsersGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsFormSubmissionDataTypeUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/initial-transcript/:users</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/initial-transcript/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsInitialTranscriptUsersGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsInitialTranscriptUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/mid-year-report/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/mid-year-report/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsMidYearReportUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsMidYearReportUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/mid-year-transcript/:users</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/mid-year-transcript/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsMidYearTranscriptUsersGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsMidYearTranscriptUsersGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/optional-report-2/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/optional-report-2/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsOptionalReport2UsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsOptionalReport2UsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/optional-report/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/optional-report/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsOptionalReportUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsOptionalReportUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/profile</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/profile")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsProfilePost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsProfilePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/recommendation/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/recommendation/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsRecommendationUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsRecommendationUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-counselor-forms/school-report/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/school-report/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsSchoolReportUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsSchoolReportUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/students</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/students")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsStudentsGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsStudentsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-counselor-forms/students-unlinked</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/students-unlinked")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsStudentsUnlinkedGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsStudentsUnlinkedGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Common App/api/consumer/v1/ca-counselor-forms/unlink-ca-account/:users</remarks>
        [HttpDelete]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/unlink-ca-account/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsUnlinkCaAccountUsersDelete")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsUnlinkCaAccountUsersDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Common App/api/consumer/v1/ca-counselor-forms/unsubmit-form/:type/:users</remarks>
        [HttpDelete]
        [Route("/Common App/api/consumer/v1/ca-counselor-forms/unsubmit-form/{type}/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaCounselorFormsUnsubmitFormTypeUsersDelete")]
        public virtual IActionResult CommonAppApiConsumerV1CaCounselorFormsUnsubmitFormTypeUsersDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-has-outstanding-school-profiles</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-has-outstanding-school-profiles")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaHasOutstandingSchoolProfilesGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaHasOutstandingSchoolProfilesGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-self-profile</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-self-profile")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaSelfProfileGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaSelfProfileGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Common App/api/consumer/v1/ca-self-profile</remarks>
        [HttpPatch]
        [Route("/Common App/api/consumer/v1/ca-self-profile")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaSelfProfilePatch")]
        public virtual IActionResult CommonAppApiConsumerV1CaSelfProfilePatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-teacher-forms/initial-profile</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-teacher-forms/initial-profile")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaTeacherFormsInitialProfilePost")]
        public virtual IActionResult CommonAppApiConsumerV1CaTeacherFormsInitialProfilePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/ca-teacher-forms/initial-profile-status</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/ca-teacher-forms/initial-profile-status")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaTeacherFormsInitialProfileStatusGet")]
        public virtual IActionResult CommonAppApiConsumerV1CaTeacherFormsInitialProfileStatusGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/ca-teacher-forms/recommendation/:users</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/ca-teacher-forms/recommendation/{users}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CaTeacherFormsRecommendationUsersPost")]
        public virtual IActionResult CommonAppApiConsumerV1CaTeacherFormsRecommendationUsersPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/common-app/colleges-link</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/common-app/colleges-link")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CommonAppCollegesLinkGet")]
        public virtual IActionResult CommonAppApiConsumerV1CommonAppCollegesLinkGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Common App/api/consumer/v1/common-app/connect</remarks>
        [HttpPatch]
        [Route("/Common App/api/consumer/v1/common-app/connect")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CommonAppConnectPatch")]
        public virtual IActionResult CommonAppApiConsumerV1CommonAppConnectPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/common-app/connection-url</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/common-app/connection-url")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CommonAppConnectionUrlGet")]
        public virtual IActionResult CommonAppApiConsumerV1CommonAppConnectionUrlGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/common-app/ferpa-url</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/common-app/ferpa-url")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CommonAppFerpaUrlGet")]
        public virtual IActionResult CommonAppApiConsumerV1CommonAppFerpaUrlGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/common-app/status</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/common-app/status")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1CommonAppStatusGet")]
        public virtual IActionResult CommonAppApiConsumerV1CommonAppStatusGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Common App/api/consumer/v1/external-school-profile/:token</remarks>
        [HttpGet]
        [Route("/Common App/api/consumer/v1/external-school-profile/{token}")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1ExternalSchoolProfileTokenGet")]
        public virtual IActionResult CommonAppApiConsumerV1ExternalSchoolProfileTokenGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/external-school-profile/:token/save</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/external-school-profile/{token}/save")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1ExternalSchoolProfileTokenSavePost")]
        public virtual IActionResult CommonAppApiConsumerV1ExternalSchoolProfileTokenSavePost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Common App/api/consumer/v1/external-school-profile/:token/submit</remarks>
        [HttpPost]
        [Route("/Common App/api/consumer/v1/external-school-profile/{token}/submit")]
        [ValidateModelState]
        [SwaggerOperation("CommonAppApiConsumerV1ExternalSchoolProfileTokenSubmitPost")]
        public virtual IActionResult CommonAppApiConsumerV1ExternalSchoolProfileTokenSubmitPost()
        {


            throw new NotImplementedException();
        }
    }
}
