using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.ViewModels;
using FitnessClubManagement.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClubManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminFitnessController : ControllerBase
    {
        /// <summary>
        /// creating referance variable of IAdminFitnessClubServices and injecting in Controller Constructor
        /// </summary>
        private readonly IAdminFitnessClubServices _aFClubServices;
        public readonly IFitnessClubServices _fClubServices;

        public AdminFitnessController(IAdminFitnessClubServices adminFitnessClubServices,
            IFitnessClubServices fitnessClubServices)
        {
            _aFClubServices = adminFitnessClubServices;
            _fClubServices = fitnessClubServices;
        }
        /// <summary>
        /// Get all User Appointment from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Appointment>> UserAppointment()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all User Appointment from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllInstructor")]
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new DietPlan in MongoDb DietPlan Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddInstructor")]
        public async Task<IActionResult> AddInstructor([FromBody] InstructorViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Instructor by its Id and Instructor Collection
        /// </summary>
        /// <param name="instructorId"></param>
        /// <param name="instructor"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateInstructor/{instructorId}")]
        public async Task<IActionResult> UpdateInstructor(string instructorId, [FromBody] Instructor instructor)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Instructor by instructorId
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteInstructor/{instructorId}")]
        public async Task<IActionResult> DeleteInstructor(string instructorId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add new DietPlan in MongoDb DietPlan Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddDietPlan")]
        public async Task<IActionResult> AddDietPlan([FromBody] DietPlanViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing DietPlan by its Id and DietPlan Collection
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <param name="dietPlan"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateDietPlan/{dietplanId}")]
        public async Task<IActionResult> UpdateDietPlan(string dietplanId, [FromBody] DietPlan dietPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing DietPlan by dietplanId
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteDietPlan/{dietplanId}")]
        public async Task<IActionResult> DeleteDietPlan(string dietplanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add workout in MongoDb workout Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddWorkout")]
        public async Task<IActionResult> Addworkout([FromBody] WorkoutViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Workout by its Id and Workout Collection
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="workout"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateWorkout/{workoutId}")]
        public async Task<IActionResult> UpdateWorkout(string workoutId, [FromBody] Workout workout)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Workout by WorkoutId
        /// </summary>
        /// <param name="WorkoutId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteWorkout/{WorkoutId}")]
        public async Task<IActionResult> DeleteWorkout(string WorkoutId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add MemberShip Plan in MongoDb MemberShipPlan Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMemberShipPlan")]
        public async Task<IActionResult> AddMemberShipPlan([FromBody] MemberShipPlanViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing memberShipPlan by its Id and memberShipPlan Collection
        /// </summary>
        /// <param name="PlanId"></param>
        /// <param name="memberShipPlan"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateMemberShipPlan/{PlanId}")]
        public async Task<IActionResult> UpdateMemberShipPlan(string PlanId, [FromBody] MemberShipPlan memberShipPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Member Ship Plan by PlanId
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteMemberShipPlan/{PlanId}")]
        public async Task<IActionResult> DeleteMemberShipPlan(string PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add Tools in MongoDb Tools Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddTools")]
        public async Task<IActionResult> AddTools([FromBody] ToolsViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Tools by its Id and Tools Collection
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <param name="tools"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateTools/{ToolsId}")]
        public async Task<IActionResult> UpdateTools(string ToolsId,[FromBody] Tools tools)
        {
            //Do code here
            throw new NotImplementedException();
        }
        [HttpDelete]
        [Route("DeleteTools/{ToolsId}")]
        public async Task<IActionResult> DeleteTools(string ToolsId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All Contact Message from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ContactMessage")]
        public async Task<IEnumerable<ContactUs>> AllContactMessage()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
