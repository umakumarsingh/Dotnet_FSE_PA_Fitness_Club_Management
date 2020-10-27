using FitnessClubManagement.DataLayer;
using FitnessClubManagement.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services.Repository
{
    public class AdminFitnessClubRepository : IAdminFitnessClubRepository
    {
        /// <summary>
        /// Creating field and object or dbcontext and all collection, injecting IMongoDBContext
        /// in constructor and getting a Collection from MongoDb
        /// </summary>
        private readonly IMongoDBContext _mongoContext;
        private IMongoCollection<Appointment> _dbACollection;
        private IMongoCollection<ContactUs> _dbCCollection;
        private IMongoCollection<DietPlan> _dbDCollection;
        private IMongoCollection<Instructor> _dbICollection;
        private IMongoCollection<MemberShipPlan> _dbMPCollection;
        private IMongoCollection<Tools> _dbTCollection;
        private IMongoCollection<Workout> _dbWCollection;
        public AdminFitnessClubRepository(IMongoDBContext context)
        {
            _mongoContext = context;
            _dbACollection = _mongoContext.GetCollection<Appointment>(typeof(Appointment).Name);
            _dbCCollection = _mongoContext.GetCollection<ContactUs>(typeof(ContactUs).Name);
            _dbDCollection = _mongoContext.GetCollection<DietPlan>(typeof(DietPlan).Name);
            _dbICollection = _mongoContext.GetCollection<Instructor>(typeof(Instructor).Name);
            _dbMPCollection = _mongoContext.GetCollection<MemberShipPlan>(typeof(MemberShipPlan).Name);
            _dbTCollection = _mongoContext.GetCollection<Tools>(typeof(Tools).Name);
            _dbWCollection = _mongoContext.GetCollection<Workout>(typeof(Workout).Name);
        }
        /// <summary>
        /// add new DietPlan in MongoDb DietPlan Collection
        /// </summary>
        /// <param name="dietPlan"></param>
        /// <returns></returns>
        public async Task<DietPlan> AddDietPlan(DietPlan dietPlan)
        {
            try
            {
                if (dietPlan == null)
                {
                    throw new ArgumentNullException(typeof(DietPlan).Name + "Object is Null");
                }
                _dbDCollection = _mongoContext.GetCollection<DietPlan>(typeof(DietPlan).Name);
                await _dbDCollection.InsertOneAsync(dietPlan);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return dietPlan;
        }
        /// <summary>
        /// add new Instructor in MongoDb Instructor Collection
        /// </summary>
        /// <param name="instructor"></param>
        /// <returns></returns>
        public async Task<Instructor> AddInstructor(Instructor instructor)
        {
            try
            {
                if (instructor == null)
                {
                    throw new ArgumentNullException(typeof(Instructor).Name + "Object is Null");
                }
                _dbICollection = _mongoContext.GetCollection<Instructor>(typeof(Instructor).Name);
                await _dbICollection.InsertOneAsync(instructor);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return instructor;
        }
        /// <summary>
        /// Add new MemberShipPlan in MongoDb MemberShipPlan Collection
        /// </summary>
        /// <param name="memberShipPlan"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> AddMemberShipPlan(MemberShipPlan memberShipPlan)
        {
            try
            {
                if (memberShipPlan == null)
                {
                    throw new ArgumentNullException(typeof(MemberShipPlan).Name + "Object is Null");
                }
                _dbMPCollection = _mongoContext.GetCollection<MemberShipPlan>(typeof(MemberShipPlan).Name);
                await _dbMPCollection.InsertOneAsync(memberShipPlan);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return memberShipPlan;
        }
        /// <summary>
        /// Add new Tools in MongoDb Tools Collection
        /// </summary>
        /// <param name="tools"></param>
        /// <returns></returns>
        public async Task<Tools> AddTools(Tools tools)
        {
            try
            {
                if (tools == null)
                {
                    throw new ArgumentNullException(typeof(Tools).Name + "Object is Null");
                }
                _dbTCollection = _mongoContext.GetCollection<Tools>(typeof(Tools).Name);
                await _dbTCollection.InsertOneAsync(tools);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return tools;
        }
        /// <summary>
        /// Add new workout in MongoDb workout Collection
        /// </summary>
        /// <param name="workout"></param>
        /// <returns></returns>
        public async Task<Workout> Addworkout(Workout workout)
        {
            try
            {
                if (workout == null)
                {
                    throw new ArgumentNullException(typeof(Workout).Name + "Object is Null");
                }
                _dbWCollection = _mongoContext.GetCollection<Workout>(typeof(Workout).Name);
                await _dbWCollection.InsertOneAsync(workout);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return workout;
        }

        /// <summary
        /// Get all Information of Contact Message come from User in MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ContactUs>> AllContactMessage()
        {
            try
            {
                var list = _mongoContext.GetCollection<ContactUs>("ContactUs")
                .Find(Builders<ContactUs>.Filter.Empty, null)
                .SortByDescending(e => e.DateofMessage);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get all Information of Instructor come from Instructor MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Instructor>> AllInstructor()
        {
            try
            {
                var list = _mongoContext.GetCollection<Instructor>("Instructor")
                .Find(Builders<Instructor>.Filter.Empty, null)
                .SortByDescending(e => e.InstructorId);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delete DietPlan information from DietPlan Mongodb Collection by Id
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteDietPlan(string dietplanId)
        {
            try
            {
                var objectId = new ObjectId(dietplanId);
                FilterDefinition<DietPlan> filter = Builders<DietPlan>.Filter.Eq("DietplanId", objectId);
                var result = await _dbDCollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delete Instructor information from Instructor Mongodb Collection by Id
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteInstructor(string instructorId)
        {
            try
            {
                var objectId = new ObjectId(instructorId);
                FilterDefinition<Instructor> filter = Builders<Instructor>.Filter.Eq("InstructorId", objectId);
                var result = await _dbICollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delete MemberShipPlan information from MemberShipPlan Mongodb Collection by Id
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteMemberShipPlan(string PlanId)
        {
            try
            {
                var objectId = new ObjectId(PlanId);
                FilterDefinition<MemberShipPlan> filter = Builders<MemberShipPlan>.Filter.Eq("PlanId", objectId);
                var result = await _dbMPCollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delete Tools information from Tools Mongodb Collection by Id
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteTools(string ToolsId)
        {
            try
            {
                var objectId = new ObjectId(ToolsId);
                FilterDefinition<Tools> filter = Builders<Tools>.Filter.Eq("ToolsId", objectId);
                var result = await _dbTCollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Delete Workout information from Workout Mongodb Collection by Id
        /// </summary>
        /// <param name="WorkoutId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteWorkout(string WorkoutId)
        {
            try
            {
                var objectId = new ObjectId(WorkoutId);
                FilterDefinition<Workout> filter = Builders<Workout>.Filter.Eq("WorkoutId", objectId);
                var result = await _dbWCollection.DeleteOneAsync(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Instructor By Id by from MongoDb Collection
        /// </summary>
        /// <param name="instructorId"></param>
        /// <returns></returns>
        public async Task<Instructor> InstructorById(string instructorId)
        {
            try
            {
                var objectId = new ObjectId(instructorId);
                FilterDefinition<Instructor> filter = Builders<Instructor>.Filter.Eq("instructorId", objectId);
                _dbICollection = _mongoContext.GetCollection<Instructor>(typeof(Instructor).Name);
                return await _dbICollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Tools By Id by from MongoDb Collection
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <returns></returns>
        public async Task<Tools> ToolsById(string ToolsId)
        {
            try
            {
                var objectId = new ObjectId(ToolsId);
                FilterDefinition<Tools> filter = Builders<Tools>.Filter.Eq("ToolsId", objectId);
                _dbTCollection = _mongoContext.GetCollection<Tools>(typeof(Tools).Name);
                return await _dbTCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Update an existing DietPlan by dietplanId
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <param name="dietPlan"></param>
        /// <returns></returns>
        public async Task<DietPlan> UpdateDietPlan(string dietplanId, DietPlan dietPlan)
        {
            if (dietPlan == null && dietplanId == null)
            {
                throw new ArgumentNullException(typeof(DietPlan).Name + "Object or may be DietPlanId is Null");
            }
            var update = await _dbDCollection.FindOneAndUpdateAsync(Builders<DietPlan>.
                Filter.Eq("DietplanId", dietPlan.DietplanId), Builders<DietPlan>.
                Update.Set("Name", dietPlan.Name).Set("PlanOverview", dietPlan.PlanOverview).Set("Description", dietPlan.Description)
                .Set("History", dietPlan.History).Set("MealTimingFrequency", dietPlan.MealTimingFrequency).Set("RestrictionsLimitations", dietPlan.RestrictionsLimitations)
                .Set("Phases", dietPlan.Phases).Set("BestSuitedFor", dietPlan.BestSuitedFor).Set("HowToFollow", dietPlan.HowToFollow)
                .Set("Conclusion", dietPlan.Conclusion));
            return update;
        }
        /// <summary>
        /// Update an existing Instructor by InstructorId
        /// </summary>
        /// <param name="instructorId"></param>
        /// <param name="instructor"></param>
        /// <returns></returns>
        public async Task<Instructor> UpdateInstructor(string instructorId, Instructor instructor)
        {
            if (instructor == null && instructorId == null)
            {
                throw new ArgumentNullException(typeof(Instructor).Name + "Object or may be DietPlanId is Null");
            }
            var update = await _dbICollection.FindOneAndUpdateAsync(Builders<Instructor>.
                Filter.Eq("InstructorId", instructor.InstructorId), Builders<Instructor>.
                Update.Set("Profession", instructor.Profession).Set("Competition", instructor.Competition).Set("TopPlacing", instructor.TopPlacing)
                .Set("About", instructor.About).Set("SuggestedWorkOut", instructor.SuggestedWorkOut));
            return update;
        }
        /// <summary>
        /// Update an existing MemberShipPlan by PlanId
        /// </summary>
        /// <param name="PlanId"></param>
        /// <param name="memberShipPlan"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> UpdateMemberShipPlan(string PlanId, MemberShipPlan memberShipPlan)
        {
            if (memberShipPlan == null && PlanId == null)
            {
                throw new ArgumentNullException(typeof(MemberShipPlan).Name + "Object or may be PlanId is Null");
            }
            var update = await _dbMPCollection.FindOneAndUpdateAsync(Builders<MemberShipPlan>.
                Filter.Eq("PlanId", memberShipPlan.PlanId), Builders<MemberShipPlan>.
                Update.Set("PlanName", memberShipPlan.PlanName).Set("PlanDetails", memberShipPlan.PlanDetails).Set("PlanAmount", memberShipPlan.PlanAmount)
                .Set("ValidFor", memberShipPlan.ValidFor).Set("PlanStartDate", memberShipPlan.PlanStartDate)
                .Set("Remark", memberShipPlan.Remark));
            return update;
        }
        /// <summary>
        /// Update an existing Tools by ToolsId
        /// </summary>
        /// <param name="ToolsId"></param>
        /// <param name="tools"></param>
        /// <returns></returns>
        public async Task<Tools> UpdateTools(string ToolsId, Tools tools)
        {
            if (tools == null && ToolsId == null)
            {
                throw new ArgumentNullException(typeof(Tools).Name + "Object or may be ToolsId is Null");
            }
            var update = await _dbTCollection.FindOneAndUpdateAsync(Builders<Tools>.
                Filter.Eq("ToolsId", tools.ToolsId), Builders<Tools>.
                Update.Set("Name", tools.Name).Set("Description", tools.Description));
            return update;
        }
        /// <summary>
        /// Update an existing Workout by WorkoutId
        /// </summary>
        /// <param name="workoutId"></param>
        /// <param name="workout"></param>
        /// <returns></returns>
        public async Task<Workout> UpdateWorkout(string workoutId, Workout workout)
        {
            if (workout == null && workoutId == null)
            {
                throw new ArgumentNullException(typeof(MemberShipPlan).Name + "Object or may be workoutId is Null");
            }
            var update = await _dbWCollection.FindOneAndUpdateAsync(Builders<Workout>.
                Filter.Eq("WorkoutId", workout.WorkoutId), Builders<Workout>.
                Update.Set("Name", workout.Name).Set("Descriprtion", workout.Descriprtion).Set("MainGoal", workout.MainGoal)
                .Set("WorkoutType", workout.WorkoutType).Set("TrainingLevel", workout.TrainingLevel)
                .Set("ProgramDuration", workout.ProgramDuration).Set("DaysPerWeek", workout.DaysPerWeek).Set("TimePerWorkout", workout.TimePerWorkout)
                .Set("EquipmentRequired", workout.EquipmentRequired).Set("TargetGender", workout.TargetGender).Set("RecommendedSupplements", workout.RecommendedSupplements)
                .Set("Author", workout.Author).Set("WorkoutPDF", workout.WorkoutPDF));
            return update;
        }
        /// <summary>
        /// Get all Appointment from Appointment MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Appointment>> UserAppointment()
        {
            try
            {
                var list = _mongoContext.GetCollection<Appointment>("Appointment")
                .Find(Builders<Appointment>.Filter.Empty, null)
                .SortByDescending(e => e.AppointmentId);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
