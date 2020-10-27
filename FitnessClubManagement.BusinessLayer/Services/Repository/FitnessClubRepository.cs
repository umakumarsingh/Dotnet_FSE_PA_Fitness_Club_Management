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
    public class FitnessClubRepository : IFitnessClubRepository
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
        public FitnessClubRepository(IMongoDBContext context)
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
        /// Get List of All Diet Plan fron DietPlan MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DietPlan>> AllDietPlan()
        {
            try
            {
                var list = _mongoContext.GetCollection<DietPlan>("DietPlan")
                .Find(Builders<DietPlan>.Filter.Empty, null)
                .SortByDescending(e => e.Name);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get List of All Instructor fron Instructor MongoDb Collection
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
        /// Get List of All MemberShipPlan fron MemberShipPlan MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MemberShipPlan>> AllMemberShipPlan()
        {
            try
            {
                var list = _mongoContext.GetCollection<MemberShipPlan>("MemberShipPlan")
                .Find(Builders<MemberShipPlan>.Filter.Empty, null)
                .SortByDescending(e => e.PlanName);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get List of All Tools fron Tools MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Tools>> AllTools()
        {
            try
            {
                var list = _mongoContext.GetCollection<Tools>("Tools")
                .Find(Builders<Tools>.Filter.Empty, null)
                .SortByDescending(e => e.Name);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get List of All Workout fron Workout MongoDb Collection
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> AllWorkout()
        {
            try
            {
                var list = _mongoContext.GetCollection<Workout>("Workout")
                .Find(Builders<Workout>.Filter.Empty, null)
                .SortByDescending(e => e.Name);
                return await list.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Appointment by AppointmentId from Appointment MongoDb Collection
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> AppointmentInformation(string appointmentId)
        {
            try
            {
                var objectId = new ObjectId(appointmentId);
                FilterDefinition<Appointment> filter = Builders<Appointment>.Filter.Eq("AppointmentId", objectId);
                _dbACollection = _mongoContext.GetCollection<Appointment>(typeof(Appointment).Name);
                return await _dbACollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Book Appointment by Appointment object
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> BookAppointment(Appointment appointment)
        {
            try
            {
                if (appointment == null)
                {
                    throw new ArgumentNullException(typeof(Appointment).Name + "Object is Null");
                }
                _dbACollection = _mongoContext.GetCollection<Appointment>(typeof(Appointment).Name);
                await _dbACollection.InsertOneAsync(appointment);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return appointment;
        }
        /// <summary>
        /// Find workout by Name and WorkoutType
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Workout>> FindWorkout(string name)
        {
            try
            {
                var filterBuilder = new FilterDefinitionBuilder<Workout>();
                var findName = filterBuilder.Eq(s => s.Name, name);
                var findWorkoutType = filterBuilder.Eq(s => s.WorkoutType, name.ToString());
                _dbWCollection = _mongoContext.GetCollection<Workout>(typeof(Workout).Name);
                var result = await _dbWCollection.FindAsync(findName | findWorkoutType).Result.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get DietPlan By Id form DietPlan MongoDb Collection
        /// </summary>
        /// <param name="dietplanId"></param>
        /// <returns></returns>
        public async Task<DietPlan> GetDietPlanById(string dietplanId)
        {
            try
            {
                var objectId = new ObjectId(dietplanId);
                FilterDefinition<DietPlan> filter = Builders<DietPlan>.Filter.Eq("DietplanId", objectId);
                _dbDCollection = _mongoContext.GetCollection<DietPlan>(typeof(DietPlan).Name);
                return await _dbDCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Member Ship Plan By Id form MemberShipPlan MongoDb Collection
        /// </summary>
        /// <param name="PlanId"></param>
        /// <returns></returns>
        public async Task<MemberShipPlan> GetMemberShipPlanById(string PlanId)
        {
            try
            {
                var objectId = new ObjectId(PlanId);
                FilterDefinition<MemberShipPlan> filter = Builders<MemberShipPlan>.Filter.Eq("PlanId", objectId);
                _dbMPCollection = _mongoContext.GetCollection<MemberShipPlan>(typeof(MemberShipPlan).Name);
                return await _dbMPCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Get Workout By Id form Workout MongoDb Collection
        /// </summary>
        /// <param name="workoutId"></param>
        /// <returns></returns>
        public async Task<Workout> GetWorkoutById(string workoutId)
        {
            try
            {
                var objectId = new ObjectId(workoutId);
                FilterDefinition<Workout> filter = Builders<Workout>.Filter.Eq("WorkoutId", objectId);
                _dbMPCollection = _mongoContext.GetCollection<MemberShipPlan>(typeof(Workout).Name);
                return await _dbWCollection.FindAsync(filter).Result.FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// Add new Contact us Message by User
        /// </summary>
        /// <param name="contactUs"></param>
        /// <returns></returns>
        public async Task<ContactUs> UserContactUs(ContactUs contactUs)
        {
            try
            {
                if (contactUs == null)
                {
                    throw new ArgumentNullException(typeof(ContactUs).Name + "Object is Null");
                }
                _dbCCollection = _mongoContext.GetCollection<ContactUs>(typeof(ContactUs).Name);
                await _dbCCollection.InsertOneAsync(contactUs);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return contactUs;
        }
    }
}
