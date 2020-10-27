using FitnessClubManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubManagement.BusinessLayer.Services.Repository
{
    public interface IFitnessClubRepository
    {
        Task<IEnumerable<Workout>> AllWorkout();
        Task<IEnumerable<Workout>> FindWorkout(string name);
        Task<Workout> GetWorkoutById(string workoutId);
        Task<IEnumerable<DietPlan>> AllDietPlan();
        Task<DietPlan> GetDietPlanById(string dietplanId);
        Task<Appointment> BookAppointment(Appointment appointment);
        Task<IEnumerable<Instructor>> AllInstructor();
        Task<IEnumerable<Tools>> AllTools();
        Task<Appointment> AppointmentInformation(string appointmentId);
        Task<IEnumerable<MemberShipPlan>> AllMemberShipPlan();
        Task<MemberShipPlan> GetMemberShipPlanById(string PlanId);
        Task<ContactUs> UserContactUs(ContactUs contactUs);
    }
}
