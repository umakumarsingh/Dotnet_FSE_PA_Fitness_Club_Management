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
            var dietplan = await _fcRepository.AllDietPlan();
            return dietplan;
        }
        /// <summary>
        /// Get all Instructor from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            var instructor = await _fcRepository.AllInstructor();
            return instructor;
        }
        /// <summary>
        /// Get all Member Ship Plan from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MemberShipPlan>> AllMemberShipPlan()
        {
            var plan = await _fcRepository.AllMemberShipPlan();
            return plan;
        }
        /// <summary>
        /// Get all Tools from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            var tools = await _fcRepository.AllTools();
            return tools;
        }
        /// <summary>
        /// Get all Workout from MongoDb Collection by Repository Interface
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            var workout = await _fcRepository.AllWorkout();
            return workout;
        }
        /// <summary>
        /// Get Appointment by appointment Id from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> AppointmentInformation(string appointmentId)
        {
            var appointment = await _fcRepository.AppointmentInformation(appointmentId);
            return appointment;
        }
        /// <summary>
        /// Book New Appointment by appointment Object and store Data in MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            var newAppointment = await _fcRepository.BookAppointment(appointment);
            return newAppointment;
        }
        /// <summary>
        /// Get Workout by appointment Name from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            var workout = await _fcRepository.FindWorkout(name);
            return workout;
        }
        /// <summary>
        /// Get DietPlan by DietPlan Id from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(string dietplanId)
        {
            var dietplan = await _fcRepository.GetDietPlanById(dietplanId);
            return dietplan;
        }
        /// <summary>
        /// Get MemberShipPlan by PlanId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> GetMemberShipPlanById(string PlanId)
        {
            var plan = await _fcRepository.GetMemberShipPlanById(PlanId);
            return plan;
        }
        /// <summary>
        /// Get Workout by workoutId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(string workoutId)
        {
            var workout = await _fcRepository.GetWorkoutById(workoutId);
            return workout;
        }
        /// <summary>
        /// create ContactUs message by ContactUs Object and store in MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="contactUs"></param>
        /// <returns></returns>
        public async Task<ContactUs> UserContactUs(ContactUs contactUs)
        {
            var contactMsg = await _fcRepository.UserContactUs(contactUs);
            return contactMsg;
        }
    }
}
