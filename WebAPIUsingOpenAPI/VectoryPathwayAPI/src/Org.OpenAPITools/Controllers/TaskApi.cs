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
    public class TaskApiController : ControllerBase
    { 
        /// <summary>
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpDelete]
        [Route("/Task/api/consumer/v1/tasks/{tasks}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteTaskApiConsumerV1TasksByTasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult DeleteTaskApiConsumerV1TasksByTasks([FromRoute (Name = "tasks")][Required]string tasks, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Task
        /// </summary>
        /// <remarks>Task</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Task/api/consumer/v1/tasks")]
        [ValidateModelState]
        [SwaggerOperation("GetTaskApiConsumerV1Tasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TaskUserData>), description: "OK")]
        public virtual IActionResult GetTaskApiConsumerV1Tasks([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TaskUserData>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"task\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 3,\r\n    \"created_by\" : 6,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"overdue\" : true,\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"complete\" : true\r\n}, {\r\n  \"task\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 3,\r\n    \"created_by\" : 6,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"overdue\" : true,\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"complete\" : true\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TaskUserData>>(exampleJson)
            : default(List<TaskUserData>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Task
        /// </summary>
        /// <remarks>Task</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Task/api/consumer/v1/tasks/admin")]
        [ValidateModelState]
        [SwaggerOperation("GetTaskApiConsumerV1TasksAdmin")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AdminTaskData>), description: "OK")]
        public virtual IActionResult GetTaskApiConsumerV1TasksAdmin([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AdminTaskData>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"studentsCompleted\" : 1,\r\n  \"description\" : \"description\",\r\n  \"studentsAssigned\" : 0,\r\n  \"id\" : 6\r\n}, {\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n  \"name\" : \"name\",\r\n  \"studentsCompleted\" : 1,\r\n  \"description\" : \"description\",\r\n  \"studentsAssigned\" : 0,\r\n  \"id\" : 6\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<AdminTaskData>>(exampleJson)
            : default(List<AdminTaskData>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Task/api/consumer/v1/tasks/{tasks}/completion")]
        [ValidateModelState]
        [SwaggerOperation("GetTaskApiConsumerV1TasksByTasksCompletion")]
        [SwaggerResponse(statusCode: 200, type: typeof(TasksCompletionResponse), description: "OK")]
        public virtual IActionResult GetTaskApiConsumerV1TasksByTasksCompletion([FromRoute (Name = "tasks")][Required]string tasks, [FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TasksCompletionResponse));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"pending\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ],\r\n  \"completed\" : [ {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  }, {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  } ]\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TasksCompletionResponse>(exampleJson)
            : default(TasksCompletionResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Task
        /// </summary>
        /// <remarks>Task</remarks>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpGet]
        [Route("/Task/api/consumer/v1/tasks/completed")]
        [ValidateModelState]
        [SwaggerOperation("GetTaskApiConsumerV1TasksCompleted")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TaskUserData>), description: "OK")]
        public virtual IActionResult GetTaskApiConsumerV1TasksCompleted([FromHeader (Name = "Authorization")]string authorization)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TaskUserData>));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"task\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 3,\r\n    \"created_by\" : 6,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"overdue\" : true,\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"complete\" : true\r\n}, {\r\n  \"task\" : {\r\n    \"createdAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"deletedAt\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"dueDate\" : \"2000-01-23T04:56:07.000+00:00\",\r\n    \"name\" : \"name\",\r\n    \"description\" : \"description\",\r\n    \"id\" : 3,\r\n    \"created_by\" : 6,\r\n    \"updatedAt\" : \"2000-01-23T04:56:07.000+00:00\"\r\n  },\r\n  \"overdue\" : true,\r\n  \"createdBy\" : {\r\n    \"firstName\" : \"firstName\",\r\n    \"lastName\" : \"lastName\",\r\n    \"role\" : 1,\r\n    \"school\" : \"school\",\r\n    \"grade\" : 6,\r\n    \"id\" : 5,\r\n    \"profileImageUrl\" : \"profileImageUrl\",\r\n    \"email\" : \"email\"\r\n  },\r\n  \"complete\" : true\r\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TaskUserData>>(exampleJson)
            : default(List<TaskUserData>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="updateTaskRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Task/api/consumer/v1/tasks/{tasks}")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchTaskApiConsumerV1TasksByTasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchTaskApiConsumerV1TasksByTasks([FromRoute (Name = "tasks")][Required]string tasks, [FromBody]UpdateTaskRequest updateTaskRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="assignTaskRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Task/api/consumer/v1/tasks/{tasks}/assign")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchTaskApiConsumerV1TasksByTasksAssign")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchTaskApiConsumerV1TasksByTasksAssign([FromRoute (Name = "tasks")][Required]string tasks, [FromBody]AssignTaskRequest assignTaskRequest, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="body"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Task/api/consumer/v1/tasks/{tasks}/complete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchTaskApiConsumerV1TasksByTasksComplete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchTaskApiConsumerV1TasksByTasksComplete([FromRoute (Name = "tasks")][Required]string tasks, [FromBody]Object body, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Edit Task
        /// </summary>
        /// <remarks>Edit Task</remarks>
        /// <param name="tasks"></param>
        /// <param name="body"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPatch]
        [Route("/Task/api/consumer/v1/tasks/{tasks}/uncomplete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PatchTaskApiConsumerV1TasksByTasksUncomplete")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PatchTaskApiConsumerV1TasksByTasksUncomplete([FromRoute (Name = "tasks")][Required]string tasks, [FromBody]Object body, [FromHeader (Name = "Authorization")]string authorization)
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
        /// Add Task
        /// </summary>
        /// <remarks>Add Task</remarks>
        /// <param name="createTaskRequest"></param>
        /// <param name="authorization"></param>
        /// <response code="200">OK</response>
        /// <response code="404">Not found</response>
        [HttpPost]
        [Route("/Task/api/consumer/v1/tasks")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostTaskApiConsumerV1Tasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(long), description: "OK")]
        public virtual IActionResult PostTaskApiConsumerV1Tasks([FromBody]CreateTaskRequest createTaskRequest, [FromHeader (Name = "Authorization")]string authorization)
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
