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
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all DietPlan from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("DietPlan")]
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Instructor from MongoDb Collection
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
        /// Get all Tools from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllTools")]
        public async Task<IEnumerable<Tools>> GetAllTools()
        {
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all MemberShipPlan from MongoDb Collection
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("MemberShipPlan")]
        public async Task<IEnumerable<MemberShipPlan>> GetAllMemberShipPlan()
        {
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
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
            //Do code here
            throw new NotImplementedException();
        }
    }
}
