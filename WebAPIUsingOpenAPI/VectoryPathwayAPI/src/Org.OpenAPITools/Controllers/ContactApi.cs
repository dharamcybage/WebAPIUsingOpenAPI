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
    public class ContactApiController : ControllerBase
    { 
        /// <summary>
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="contactNotes"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Contact/api/consumer/v1/contact-notes/{contact_notes}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteContactApiConsumerV1ContactNotesByContactNotes")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteContactApiConsumerV1ContactNotesByContactNotes([FromRoute (Name = "contact_notes")][Required]string contactNotes, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Contact/api/consumer/v1/contacts/{contacts}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteContactApiConsumerV1ContactsByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteContactApiConsumerV1ContactsByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Contact/api/consumer/v1/background-check-tokens")]
        [ValidateModelState]
        [SwaggerOperation("GetContactApiConsumerV1BackgroundCheckTokens")]
        [SwaggerResponse(statusCode: 200, type: typeof(BackgroundCheckTokenResponse), description: "OK")]
        public virtual IActionResult GetContactApiConsumerV1BackgroundCheckTokens([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BackgroundCheckTokenResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"basic\" : 0,\r\n  \"full\" : 6\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BackgroundCheckTokenResponse>(exampleJson)
            : default(BackgroundCheckTokenResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>Contact</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Contact/api/consumer/v1/contacts")]
        [ValidateModelState]
        [SwaggerOperation("GetContactApiConsumerV1Contacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<OrganizationContactData>), description: "OK")]
        public virtual IActionResult GetContactApiConsumerV1Contacts([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<OrganizationContactData>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"mainNotes\" : \"mainNotes\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"lastName\" : \"lastName\",\r\n  \"firstName\" : \"firstName\",\r\n  \"phone\" : \"phone\",\r\n  \"organization\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 0,\r\n    \"profileImageUrl\" : \"profileImageUrl\"\r\n  },\r\n  \"id\" : 6,\r\n  \"title\" : \"title\",\r\n  \"email\" : \"email\"\r\n}, {\r\n  \"mainNotes\" : \"mainNotes\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"lastName\" : \"lastName\",\r\n  \"firstName\" : \"firstName\",\r\n  \"phone\" : \"phone\",\r\n  \"organization\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 0,\r\n    \"profileImageUrl\" : \"profileImageUrl\"\r\n  },\r\n  \"id\" : 6,\r\n  \"title\" : \"title\",\r\n  \"email\" : \"email\"\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<OrganizationContactData>>(exampleJson)
            : default(List<OrganizationContactData>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>Contact</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Contact/api/consumer/v1/contacts/admin-table")]
        [ValidateModelState]
        [SwaggerOperation("GetContactApiConsumerV1ContactsAdminTable")]
        [SwaggerResponse(statusCode: 200, type: typeof(AdminTableResponseAdminTableContact), description: "OK")]
        public virtual IActionResult GetContactApiConsumerV1ContactsAdminTable([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AdminTableResponseAdminTableContact));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"form\" : {\r\n    \"externalToken\" : \"externalToken\",\r\n    \"description\" : \"description\",\r\n    \"canBeUsedByBusinessPartners\" : true,\r\n    \"appearsInMarketPlace\" : true,\r\n    \"premium\" : true,\r\n    \"name\" : \"name\",\r\n    \"files\" : [ {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"form_id\" : 0,\r\n      \"name\" : \"name\",\r\n      \"fileUrl\" : \"fileUrl\",\r\n      \"id\" : 6,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    }, {\r\n      \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n      \"form_id\" : 0,\r\n      \"name\" : \"name\",\r\n      \"fileUrl\" : \"fileUrl\",\r\n      \"id\" : 6,\r\n      \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n    } ],\r\n    \"id\" : 7,\r\n    \"canBeUsedInWorkflow\" : true,\r\n    \"fields\" : [ {\r\n      \"allowsOtherField\" : true,\r\n      \"studentsCanViewOnEntity\" : true,\r\n      \"values\" : [ {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      }, {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      } ],\r\n      \"showToStudentsInExperience\" : true,\r\n      \"description\" : \"description\",\r\n      \"characterLimit\" : 2,\r\n      \"type\" : 5,\r\n      \"wordLimit\" : 2,\r\n      \"availableOnExternalEntityForm\" : true,\r\n      \"required\" : true,\r\n      \"hiddenFromSchoolAdminOnStudentProfile\" : true,\r\n      \"hiddenFromStaffOnStudentProfile\" : true,\r\n      \"conditionalDisplayValue\" : 1,\r\n      \"hiddenFromStudents\" : true,\r\n      \"name\" : \"name\",\r\n      \"id\" : 5,\r\n      \"maxMultiSelect\" : 7\r\n    }, {\r\n      \"allowsOtherField\" : true,\r\n      \"studentsCanViewOnEntity\" : true,\r\n      \"values\" : [ {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      }, {\r\n        \"id\" : 3,\r\n        \"value\" : \"value\",\r\n        \"order\" : 9\r\n      } ],\r\n      \"showToStudentsInExperience\" : true,\r\n      \"description\" : \"description\",\r\n      \"characterLimit\" : 2,\r\n      \"type\" : 5,\r\n      \"wordLimit\" : 2,\r\n      \"availableOnExternalEntityForm\" : true,\r\n      \"required\" : true,\r\n      \"hiddenFromSchoolAdminOnStudentProfile\" : true,\r\n      \"hiddenFromStaffOnStudentProfile\" : true,\r\n      \"conditionalDisplayValue\" : 1,\r\n      \"hiddenFromStudents\" : true,\r\n      \"name\" : \"name\",\r\n      \"id\" : 5,\r\n      \"maxMultiSelect\" : 7\r\n    } ],\r\n    \"approvalWorkflow\" : 4,\r\n    \"folder_id\" : 1,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  },\r\n  \"objects\" : [ {\r\n    \"submission\" : {\r\n      \"id\" : 1,\r\n      \"fields\" : [ {\r\n        \"formFieldId\" : 5,\r\n        \"attachedValue\" : \"attachedValue\",\r\n        \"values\" : [ \"values\", \"values\" ],\r\n        \"type\" : 5,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"formFieldId\" : 5,\r\n        \"attachedValue\" : \"attachedValue\",\r\n        \"values\" : [ \"values\", \"values\" ],\r\n        \"type\" : 5,\r\n        \"value\" : \"value\"\r\n      } ]\r\n    },\r\n    \"object\" : {\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"phone\" : \"phone\",\r\n      \"bppStatus\" : \"bppStatus\",\r\n      \"organization\" : {\r\n        \"name\" : \"name\",\r\n        \"id\" : 6\r\n      },\r\n      \"id\" : 0,\r\n      \"title\" : \"title\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }, {\r\n    \"submission\" : {\r\n      \"id\" : 1,\r\n      \"fields\" : [ {\r\n        \"formFieldId\" : 5,\r\n        \"attachedValue\" : \"attachedValue\",\r\n        \"values\" : [ \"values\", \"values\" ],\r\n        \"type\" : 5,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"formFieldId\" : 5,\r\n        \"attachedValue\" : \"attachedValue\",\r\n        \"values\" : [ \"values\", \"values\" ],\r\n        \"type\" : 5,\r\n        \"value\" : \"value\"\r\n      } ]\r\n    },\r\n    \"object\" : {\r\n      \"mainNotes\" : \"mainNotes\",\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"phone\" : \"phone\",\r\n      \"bppStatus\" : \"bppStatus\",\r\n      \"organization\" : {\r\n        \"name\" : \"name\",\r\n        \"id\" : 6\r\n      },\r\n      \"id\" : 0,\r\n      \"title\" : \"title\",\r\n      \"email\" : \"email\"\r\n    }\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AdminTableResponseAdminTableContact>(exampleJson)
            : default(AdminTableResponseAdminTableContact);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>Contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Contact/api/consumer/v1/contacts-bpp-status/{contacts}")]
        [ValidateModelState]
        [SwaggerOperation("GetContactApiConsumerV1ContactsBppStatusByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ContactBusinessPartnerStatus), description: "OK")]
        public virtual IActionResult GetContactApiConsumerV1ContactsBppStatusByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContactBusinessPartnerStatus));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"districtIds\" : [ 6, 6 ],\r\n  \"status\" : 0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContactBusinessPartnerStatus>(exampleJson)
            : default(ContactBusinessPartnerStatus);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>Contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Contact/api/consumer/v1/contacts/{contacts}")]
        [ValidateModelState]
        [SwaggerOperation("GetContactApiConsumerV1ContactsByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(FullContactData), description: "OK")]
        public virtual IActionResult GetContactApiConsumerV1ContactsByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(FullContactData));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"createdByName\" : \"createdByName\",\r\n  \"lastName\" : \"lastName\",\r\n  \"notes\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"id\" : 3,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"notes\" : \"notes\",\r\n    \"id\" : 3,\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  } ],\r\n  \"customFields\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"approvals\" : [ {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    }, {\r\n      \"parent\" : {\r\n        \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n        \"lastName\" : \"lastName\",\r\n        \"firstName\" : \"firstName\",\r\n        \"approved\" : true,\r\n        \"phone\" : \"phone\",\r\n        \"student_id\" : 5,\r\n        \"id\" : 5,\r\n        \"email\" : \"email\",\r\n        \"token\" : \"token\",\r\n        \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n      },\r\n      \"signatureImageUrl\" : \"signatureImageUrl\"\r\n    } ],\r\n    \"associatedUsers\" : [ {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    }, {\r\n      \"lastName\" : \"lastName\",\r\n      \"firstName\" : \"firstName\",\r\n      \"formSubmissionId\" : 6,\r\n      \"id\" : 0\r\n    } ],\r\n    \"id\" : 1,\r\n    \"fields\" : [ {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    }, {\r\n      \"attachedValue\" : {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      },\r\n      \"values\" : [ {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      }, {\r\n        \"id\" : 7,\r\n        \"value\" : \"value\"\r\n      } ],\r\n      \"name\" : \"name\",\r\n      \"formSubmissionFieldId\" : 9,\r\n      \"id\" : 2,\r\n      \"type\" : 3,\r\n      \"value\" : \"value\"\r\n    } ],\r\n    \"user\" : {\r\n      \"firstName\" : \"firstName\",\r\n      \"lastName\" : \"lastName\",\r\n      \"role\" : 1,\r\n      \"school\" : \"school\",\r\n      \"grade\" : 6,\r\n      \"id\" : 5,\r\n      \"profileImageUrl\" : \"profileImageUrl\",\r\n      \"email\" : \"email\"\r\n    }\r\n  },\r\n  \"students\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ],\r\n  \"title\" : \"title\",\r\n  \"emails\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"subject\" : \"subject\",\r\n    \"from\" : \"from\",\r\n    \"id\" : 9,\r\n    \"to\" : \"to\",\r\n    \"contact_id\" : 7,\r\n    \"message\" : \"message\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"subject\" : \"subject\",\r\n    \"from\" : \"from\",\r\n    \"id\" : 9,\r\n    \"to\" : \"to\",\r\n    \"contact_id\" : 7,\r\n    \"message\" : \"message\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"mainNotes\" : \"mainNotes\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"externalCreatedByName\" : \"externalCreatedByName\",\r\n  \"backgroundChecks\" : [ {\r\n    \"externalReferenceId\" : \"externalReferenceId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"externalConsentUrl\" : \"externalConsentUrl\",\r\n    \"id\" : 5,\r\n    \"convictions\" : \"convictions\",\r\n    \"contact_id\" : 6,\r\n    \"type\" : 1,\r\n    \"externalWorkerReference\" : \"externalWorkerReference\",\r\n    \"status\" : 0,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"runBy\" : 5\r\n  }, {\r\n    \"externalReferenceId\" : \"externalReferenceId\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"externalConsentUrl\" : \"externalConsentUrl\",\r\n    \"id\" : 5,\r\n    \"convictions\" : \"convictions\",\r\n    \"contact_id\" : 6,\r\n    \"type\" : 1,\r\n    \"externalWorkerReference\" : \"externalWorkerReference\",\r\n    \"status\" : 0,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"runBy\" : 5\r\n  } ],\r\n  \"id\" : 2,\r\n  \"incomingEmail\" : \"incomingEmail\",\r\n  \"profileImageUrl\" : \"profileImageUrl\",\r\n  \"email\" : \"email\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"externalCreatedByEmail\" : \"externalCreatedByEmail\",\r\n  \"createdByDistrict\" : \"createdByDistrict\",\r\n  \"experiences\" : [ {\r\n    \"organizationName\" : \"organizationName\",\r\n    \"reflection_form_approval\" : 2,\r\n    \"form_submission_id\" : 4,\r\n    \"contactName\" : \"contactName\",\r\n    \"conditional_badge_group_id\" : 7,\r\n    \"form_id\" : 5,\r\n    \"description\" : \"description\",\r\n    \"allowsTotalTimelogHoursSubmission\" : true,\r\n    \"contact_id\" : 3,\r\n    \"created_by\" : 5,\r\n    \"location_id\" : 6,\r\n    \"numberOfSpots\" : 2,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"reflection_form_id\" : 0,\r\n    \"organization_id\" : 1,\r\n    \"name\" : \"name\",\r\n    \"hideFromSearch\" : true,\r\n    \"id\" : 9,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"organizationName\" : \"organizationName\",\r\n    \"reflection_form_approval\" : 2,\r\n    \"form_submission_id\" : 4,\r\n    \"contactName\" : \"contactName\",\r\n    \"conditional_badge_group_id\" : 7,\r\n    \"form_id\" : 5,\r\n    \"description\" : \"description\",\r\n    \"allowsTotalTimelogHoursSubmission\" : true,\r\n    \"contact_id\" : 3,\r\n    \"created_by\" : 5,\r\n    \"location_id\" : 6,\r\n    \"numberOfSpots\" : 2,\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"reflection_form_id\" : 0,\r\n    \"organization_id\" : 1,\r\n    \"name\" : \"name\",\r\n    \"hideFromSearch\" : true,\r\n    \"id\" : 9,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"tags\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 1,\r\n    \"sendsParentEmail\" : true,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 1,\r\n    \"sendsParentEmail\" : true,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"firstName\" : \"firstName\",\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"phone\" : \"phone\",\r\n  \"advisoryBoards\" : [ {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 0,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }, {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 0,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  } ],\r\n  \"organization\" : {\r\n    \"mainNotes\" : \"mainNotes\",\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"website\" : \"website\",\r\n    \"form_submission_id\" : 2,\r\n    \"phone\" : \"phone\",\r\n    \"locationDescription\" : \"locationDescription\",\r\n    \"name\" : \"name\",\r\n    \"id\" : 7,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  }\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<FullContactData>(exampleJson)
            : default(FullContactData);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="updateContactRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Contact/api/consumer/v1/contacts/{contacts}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchContactApiConsumerV1ContactsByContacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchContactApiConsumerV1ContactsByContacts([FromRoute (Name = "contacts")][Required]string contacts, [FromBody]UpdateContactRequest updateContactRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="updateEntityImageRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Contact/api/consumer/v1/contacts/{contacts}/image")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchContactApiConsumerV1ContactsByContactsImage")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchContactApiConsumerV1ContactsByContactsImage([FromRoute (Name = "contacts")][Required]string contacts, [FromBody]UpdateEntityImageRequest updateEntityImageRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// contacts
        /// </summary>
        /// <remarks>contacts</remarks>
        /// <param name="createContactRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Contact/api/consumer/v1/contacts")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostContactApiConsumerV1Contacts")]
        [SwaggerResponse(statusCode: 200, type: typeof(ContactDTO), description: "OK")]
        public virtual IActionResult PostContactApiConsumerV1Contacts([FromBody]CreateContactRequest createContactRequest, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContactDTO));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"lastName\" : \"lastName\",\r\n  \"organizationName\" : \"organizationName\",\r\n  \"form_submission_id\" : 6,\r\n  \"title\" : \"title\",\r\n  \"created_by\" : 6,\r\n  \"mainNotes\" : \"mainNotes\",\r\n  \"firstName\" : \"firstName\",\r\n  \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"phone\" : \"phone\",\r\n  \"organization_id\" : 3,\r\n  \"id\" : 5,\r\n  \"profileImageUrl\" : \"profileImageUrl\",\r\n  \"email\" : \"email\",\r\n  \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContactDTO>(exampleJson)
            : default(ContactDTO);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Edit contact
        /// </summary>
        /// <remarks>Edit contact</remarks>
        /// <param name="contacts"></param>
        /// <param name="runBackgroundCheckRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Contact/api/consumer/v1/contacts/{contacts}/run-background-check")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostContactApiConsumerV1ContactsByContactsRunBackgroundCheck")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostContactApiConsumerV1ContactsByContactsRunBackgroundCheck([FromRoute (Name = "contacts")][Required]string contacts, [FromBody]RunBackgroundCheckRequest runBackgroundCheckRequest, [FromHeader (Name = "Authorization")]string authorization)
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
