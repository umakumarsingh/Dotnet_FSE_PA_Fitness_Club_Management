using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.Services.Repository;
using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services
{
    public class AdminFitnessClubServices : IAdminFitnessClubServices
    {
        /// <summary>
        /// Creating referance variable of IAdminFitnessClubRepository and injecting in Constructor
        /// </summary>
        private readonly IAdminFitnessClubRepository _adClubRepository;

        public AdminFitnessClubServices(IAdminFitnessClubRepository adminFitnessClubRepository)
        {
            _adClubRepository = adminFitnessClubRepository;
        }
        /// <summary>
        /// add new DietPlan in MongoDb DietPlan Collection
        /// </summary>
        /// <param name="dietPlan"></param>
        /// <returns></returns>
        public async Task<DietPlan> AddDietPlan(DietPlan dietPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// add new Instructor in MongoDb Instructor Collection
        /// </summary>
        /// <param name="instructor"></param>
        /// <returns></returns>
        public async Task<Instructor> AddInstructor(Instructor instructor)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// add new MemberShipPlan in MongoDb MemberShipPlan Collection
        /// </summary>
        /// <param name="memberShipPlan"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> AddMemberShipPlan(MemberShipPlan memberShipPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// add new Tools in MongoDb Tools Collection
        /// </summary>
        /// <param name="tools"></param>
        /// <returns></returns>
        public async Task<Tools> AddTools(Tools tools)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// add new Workout in MongoDb Workout Collection
        /// </summary>
        /// <param name="workout"></param>
        /// <returns></returns>
        public async Task<Workout> Addworkout(Workout workout)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all contact message from MongoDb collection by Repository Method
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ContactUs>> AllContactMessage()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get all Instructor from MongoDb collection by Repository Method
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing DietPlan from MongoDb Collection by dietplan Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteDietPlan(string dietplanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Instructor from MongoDb Collection by instructor Id
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInstructor(string instructorId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Member Ship Plan from MongoDb Collection by instructor Plan Id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteMemberShipPlan(string PlanId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Tools from MongoDb Collection by instructor Tools Id
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteTools(string ToolsId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete an Existing Workout from MongoDb Collection by instructor Workout Id
        /// </summary>
        /// <param name="WorkoutId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteWorkout(string WorkoutId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Instructor by InstructorId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public async Task<Instructor> InstructorById(string instructorId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Tools by ToolsId from MongoDb Collection by Repository Interface
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <returns></returns>
        public async Task<Tools> ToolsById(string ToolsId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Diet Plan by dietPlan object and Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <param name="dietPlan"></param>
        /// <returns></returns>
        public async Task<DietPlan> UpdateDietPlan(string dietplanId, DietPlan dietPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Instructor by Instructor object and Id
        /// </summary>
        /// <param name="instructorId"></param>
        /// <param name="instructor"></param>
        /// <returns></returns>
        public async Task<Instructor> UpdateInstructor(string instructorId, Instructor instructor)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing MemberShipPlan by MemberShipPlan object and Id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <param name="memberShipPlan"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> UpdateMemberShipPlan(string PlanId, MemberShipPlan memberShipPlan)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Tools by Tools object and Id
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <param name="tools"></param>
        /// <returns></returns>
        public async Task<Tools> UpdateTools(string ToolsId, Tools tools)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing Workout by Workout object and Id
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="workout"></param>
        /// <returns></returns>
        public async Task<Workout> UpdateWorkout(string workoutId, Workout workout)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get list of Appointment
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> UserAppointment()
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
