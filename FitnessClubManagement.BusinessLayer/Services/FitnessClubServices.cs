using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.Services.Repository;
using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services
{
    public class FitnessClubServices : IFitnessClubServices
    {
        /// <summary>
        /// Creating referance variable of IFitnessClubRepository and injecting in Constructor
        /// </summary>
        private readonly IFitnessClubRepository _fcRepository;

        public FitnessClubServices(IFitnessClubRepository fitnessClubRepository)
        {
            _fcRepository = fitnessClubRepository;
        }
        /// <summary>
        /// Get all DietPlan from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Instructor from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Member Ship Plan from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MemberShipPlan>> AllMemberShipPlan()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Tools from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Workout from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Appointment by appointment Id from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> AppointmentInformation(string appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Book New Appointment by appointment Object and store Data in MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Workout by appointment Name from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get DietPlan by DietPlan Id from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(string dietplanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get MemberShipPlan by PlanId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> GetMemberShipPlanById(string PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Workout by workoutId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(string workoutId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// create ContactUs message by ContactUs Object and store in MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="contactUs"></param>
        /// <returns></returns>
        public async Task<ContactUs> UserContactUs(ContactUs contactUs)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
