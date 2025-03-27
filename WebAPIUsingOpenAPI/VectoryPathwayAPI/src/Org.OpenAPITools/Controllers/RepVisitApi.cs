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
    public class RepVisitApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Rep Visit/api/consumer/v1/rep-visits/register/toggle/:college_rep_visits</remarks>
        [HttpPatch]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/register/toggle/{college_rep_visits}")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsRegisterToggleCollegeRepVisitsPatch")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsRegisterToggleCollegeRepVisitsPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Rep Visit/api/consumer/v1/rep-visits/registrations/:college_rep_visits</remarks>
        [HttpGet]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/registrations/{college_rep_visits}")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsRegistrationsCollegeRepVisitsGet")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsRegistrationsCollegeRepVisitsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Rep Visit/api/consumer/v1/rep-visits/reps</remarks>
        [HttpGet]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/reps")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsRepsGet")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsRepsGet()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Rep Visit/api/consumer/v1/rep-visits/reps</remarks>
        [HttpPost]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/reps")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsRepsPost")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsRepsPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>DELETE /Rep Visit/api/consumer/v1/rep-visits/visit/:college_rep_visits</remarks>
        [HttpDelete]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/visit/{college_rep_visits}")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsVisitCollegeRepVisitsDelete")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsVisitCollegeRepVisitsDelete()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>PATCH /Rep Visit/api/consumer/v1/rep-visits/visit/:college_rep_visits</remarks>
        [HttpPatch]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/visit/{college_rep_visits}")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsVisitCollegeRepVisitsPatch")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsVisitCollegeRepVisitsPatch()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>POST /Rep Visit/api/consumer/v1/rep-visits/visit</remarks>
        [HttpPost]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/visit")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsVisitPost")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsVisitPost()
        {


            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>GET /Rep Visit/api/consumer/v1/rep-visits/visits</remarks>
        [HttpGet]
        [Route("/Rep Visit/api/consumer/v1/rep-visits/visits")]
        [ValidateModelState]
        [SwaggerOperation("RepVisitApiConsumerV1RepVisitsVisitsGet")]
        public virtual IActionResult RepVisitApiConsumerV1RepVisitsVisitsGet()
        {


            throw new NotImplementedException();
        }
    }
}
