﻿using System;
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
    public class FitnessController : ControllerBase
    {
        /// <summary>
        /// creating referance variable of IFitnessClubServices and injecting in Controller Constructor
        /// </summary>
        private readonly IFitnessClubServices _fCServices;

        public FitnessController(IFitnessClubServices fitnessClubServices)
        {
            _fCServices = fitnessClubServices;
        }
        /// <summary>
        /// Get all Workout from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Workout>> GetAllWorkout()
        {
            return await _fCServices.AllWorkout();
        }
        /// <summary>
        /// Get a Workout Details by Workout Id
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("WorkoutById/{workoutId}")]
        public async Task<IActionResult> WorkoutById(string workoutId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getworkout = await _fCServices.GetWorkoutById(workoutId);
            if (getworkout == null)
            {
                return NotFound();
            }
            return CreatedAtAction("GetAllWorkout", new { WorkoutId = getworkout.WorkoutId }, getworkout);
        }
        /// <summary>
        /// Find Workout by workout by name and Workout Type
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Findworkout/{Name}")]
        public async Task<IActionResult> FindWorkout(string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var findworkout = await _fCServices.FindWorkout(name);
            if (findworkout == null)
            {
                return NotFound();
            }
            return CreatedAtAction("GetAllWorkout", findworkout);
        }
        /// <summary>
        /// Get all DietPlan from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("DietPlan")]
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            return await _fCServices.AllDietPlan();
        }
        /// <summary>
        /// Get a Diet Plan Details by dietplan Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DietPlanById/{dietplanId}")]
        public async Task<IActionResult> DietPlanById(string dietplanId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getdiet = await _fCServices.GetDietPlanById(dietplanId);
            if (getdiet == null)
            {
                return NotFound();
            }
            return CreatedAtAction("DietPlan", new { DietplanId = getdiet.DietplanId }, getdiet);
        }
        /// <summary>
        /// book Appointment by user and save data in MongoDb Appointment collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BookAppointment")]
        public async Task<IActionResult> BookAppointment([FromBody] AppointmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Appointment appointment = new Appointment
            {
                FullName = model.FullName,
                CurrentWeight = model.CurrentWeight,
                Height = model.Height,
                Age = model.Age,
                GoalWeight = model.GoalWeight,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Remark = model.Remark
            };
            var result = await _fCServices.BookAppointment(appointment);
            return Ok("Thanks for Taking Appointment, We contact you Soon..");
        }
        /// <summary>
        /// Get all Instructor from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllInstructor")]
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            return await _fCServices.AllInstructor();
        }
        /// <summary>
        /// Get all Tools from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllTools")]
        public async Task<IEnumerable<Tools>> GetAllTools()
        {
            return await _fCServices.AllTools();
        }
        /// <summary>
        /// Get a AppointmentInformation Details by appointment Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("AppointmentInformation/{appointmentId}")]
        public async Task<IActionResult> AppointmentInformation(string appointmentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getAInfo = await _fCServices.AppointmentInformation(appointmentId);
            if (getAInfo == null)
            {
                return NotFound();
            }
            return CreatedAtAction("UserAppointment", new { appointmentId = getAInfo.AppointmentId }, getAInfo);
        }
        /// <summary>
        /// Get all MemberShipPlan from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MemberShipPlan")]
        public async Task<IEnumerable<MemberShipPlan>> GetAllMemberShipPlan()
        {
            return await _fCServices.AllMemberShipPlan();
        }
        /// <summary>
        /// Get a Member Ship Plan By Id Details
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("MemberShipPlanById/{PlanId}")]
        public async Task<IActionResult> GetMemberShipPlanById(string PlanId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var getPlan = await _fCServices.GetMemberShipPlanById(PlanId);
            if (getPlan == null)
            {
                return NotFound();
            }
            return CreatedAtAction("GetAllMemberShipPlan", new { PlanId = getPlan.PlanId }, getPlan);
        }
        /// <summary>
        /// Conatct Us by User and save all message in ContactUs Db Collection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Contactus")]
        public async Task<IActionResult> ContactUs([FromBody] ContactUsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ContactUs message = new ContactUs
            {
                FullName = model.FullName,
                Phone = model.Phone,
                Email = model.Email,
                Message = model.Message,
                DateofMessage = model.DateofMessage
            };
            var result = await _fCServices.UserContactUs(message);
            return Ok("Thanks for Contact with Us Tour Guide We contact you Soon..");
        }
    }
}
