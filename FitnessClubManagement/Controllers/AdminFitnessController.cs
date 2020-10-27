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
            return await _aFClubServices.UserAppointment();
        }
        /// <summary>
        /// Get all User Appointment from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllInstructor")]
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            return await _aFClubServices.AllInstructor();
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Instructor newInstructor = new Instructor
            {
                Profession = model.Profession,
                Competition = model.Competition,
                TopPlacing = model.TopPlacing,
                About = model.About,
                SuggestedWorkOut = model.SuggestedWorkOut
            };
            var result = await _aFClubServices.AddInstructor(newInstructor);
            return Ok("New Instructor added...");
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getInstructor = _aFClubServices.InstructorById(instructorId);
            if (getInstructor == null)
            {
                return NotFound();
            }
            await _aFClubServices.UpdateInstructor(instructorId, instructor);
            return CreatedAtAction("AllInstructor", new { InstructorId = instructor.InstructorId }, instructor);
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
            if (instructorId == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await _aFClubServices.DeleteInstructor(instructorId);
                if (result == false)
                {
                    return NotFound();
                }
                return Ok("instructor Deleted...");
            }
            catch (Exception)
            {
                return BadRequest();
            }
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DietPlan newPlan = new DietPlan
            {
                Name = model.Name,
                PlanOverview = model.PlanOverview,
                Description = model.Description,
                History = model.History,
                MealTimingFrequency = model.MealTimingFrequency,
                RestrictionsLimitations = model.RestrictionsLimitations,
                Phases = model.Phases,
                BestSuitedFor = model.BestSuitedFor,
                HowToFollow = model.HowToFollow,
                Conclusion = model.Conclusion
            };
            var result = await _aFClubServices.AddDietPlan(newPlan);
            return Ok("New Diet Plan added...");
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getDiet = _fClubServices.GetDietPlanById(dietplanId);
            if (getDiet == null)
            {
                return NotFound();
            }
            await _aFClubServices.UpdateDietPlan(dietplanId, dietPlan);
            return CreatedAtAction("AllDietPlan", "Fitness", new { DietplanId = dietPlan.DietplanId }, dietPlan);
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
            if (dietplanId == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await _aFClubServices.DeleteDietPlan(dietplanId);
                if (result == false)
                {
                    return NotFound();
                }
                return Ok("DietPlan Deleted...");
            }
            catch (Exception)
            {
                return BadRequest();
            }
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Workout newWorkout = new Workout
            {
                Name = model.Name,
                Descriprtion = model.Descriprtion,
                MainGoal = model.MainGoal,
                WorkoutType = model.WorkoutType,
                TrainingLevel = model.TrainingLevel,
                ProgramDuration = model.ProgramDuration,
                DaysPerWeek = model.DaysPerWeek,
                TimePerWorkout = model.TimePerWorkout,
                EquipmentRequired = model.EquipmentRequired,
                TargetGender = model.TargetGender,
                RecommendedSupplements = model.RecommendedSupplements,
                Author = model.Author,
                WorkoutPDF = model.WorkoutPDF
            };
            var result = await _aFClubServices.Addworkout(newWorkout);
            return Ok("New Workout added...");
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getworkout = _fClubServices.GetWorkoutById(workoutId);
            if (getworkout == null)
            {
                return NotFound();
            }
            await _aFClubServices.UpdateWorkout(workoutId, workout);
            return CreatedAtAction("GetAllWorkout", "Fitness", new { WorkoutId = workout.WorkoutId }, workout);
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
            if (WorkoutId == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await _aFClubServices.DeleteWorkout(WorkoutId);
                if (result == false)
                {
                    return NotFound();
                }
                return Ok("Workout Deleted...");
            }
            catch (Exception)
            {
                return BadRequest();
            }
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            MemberShipPlan newMPlan = new MemberShipPlan
            {
                PlanName = model.PlanName,
                PlanDetails = model.PlanDetails,
                PlanAmount = model.PlanAmount,
                ValidFor = model.ValidFor,
                PlanStartDate = model.PlanStartDate,
                Remark = model.Remark
            };
            var result = await _aFClubServices.AddMemberShipPlan(newMPlan);
            return Ok("New MemberShip Plan added...");
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getMplan = _fClubServices.GetMemberShipPlanById(PlanId);
            if (getMplan == null)
            {
                return NotFound();
            }
            await _aFClubServices.UpdateMemberShipPlan(PlanId, memberShipPlan);
            return CreatedAtAction("MemberShipPlan", "Fitness", new { PlanId = memberShipPlan.PlanId }, memberShipPlan);
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
            if (PlanId == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await _aFClubServices.DeleteMemberShipPlan(PlanId);
                if (result == false)
                {
                    return NotFound();
                }
                return Ok("Member Ship Plan Deleted...");
            }
            catch (Exception)
            {
                return BadRequest();
            }
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Tools newTools = new Tools
            {
                Name = model.Name,
                Description = model.Description
            };
            var result = await _aFClubServices.AddTools(newTools);
            return Ok("New Tools added...");
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getTools = _aFClubServices.ToolsById(ToolsId);
            if (getTools == null)
            {
                return NotFound();
            }
            await _aFClubServices.UpdateTools(ToolsId, tools);
            return CreatedAtAction("AllTools", "Fitness", new { PlanId = tools.ToolsId }, tools);
        }
        [HttpDelete]
        [Route("DeleteTools/{ToolsId}")]
        public async Task<IActionResult> DeleteTools(string ToolsId)
        {
            if (ToolsId == null)
            {
                return BadRequest();
            }
            try
            {
                var result = await _aFClubServices.DeleteTools(ToolsId);
                if (result == false)
                {
                    return NotFound();
                }
                return Ok("Tools Deleted...");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Get All Contact Message from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("ContactMessage")]
        public async Task<IEnumerable<ContactUs>> AllContactMessage()
        {
            return await _aFClubServices.AllContactMessage();
        }
    }
}
