using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services.Repository
{
    public interface IAdminFitnessClubRepository
    {
        Task<IEnumerable<Appointment>> UserAppointment();
        Task<IEnumerable<Instructor>> AllInstructor();
        Task<Instructor> InstructorById(string instructorId);
        Task<Instructor> UpdateInstructor(string instructorId, Instructor instructor);
        Task<bool> DeleteInstructor(string instructorId);
        Task<DietPlan> UpdateDietPlan(string dietplanId, DietPlan dietPlan);
        Task<bool> DeleteDietPlan(string dietplanId);
        Task<Workout> UpdateWorkout(string workoutId, Workout workout);
        Task<bool> DeleteWorkout(string WorkoutId);
        Task<MemberShipPlan> UpdateMemberShipPlan(string PlanId, MemberShipPlan memberShipPlan);
        Task<bool> DeleteMemberShipPlan(string PlanId);
        Task<Tools> ToolsById(string ToolsId);
        Task<Tools> UpdateTools(string ToolsId, Tools tools);
        Task<bool> DeleteTools(string ToolsId);
        Task<IEnumerable<ContactUs>> AllContactMessage();

        Task<DietPlan> AddDietPlan(DietPlan dietPlan);
        Task<Instructor> AddInstructor(Instructor instructor);
        Task<MemberShipPlan> AddMemberShipPlan(MemberShipPlan memberShipPlan);
        Task<Tools> AddTools(Tools tools);
        Task<Workout> Addworkout(Workout workout);
    }
}
