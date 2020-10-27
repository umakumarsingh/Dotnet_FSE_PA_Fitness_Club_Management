using FitnessClubManagement.BusinessLayer.Interfaces;
using FitnessClubManagement.BusinessLayer.Services;
using FitnessClubManagement.BusinessLayer.Services.Repository;
using FitnessClubManagement.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FitnessClubManagement.Test.TestCases
{
    public class BoundaryTest
    {
        /// <summary>
        /// Creating Referance of all Service Interfaces and Mocking All Repository
        /// </summary>
        private readonly IAdminFitnessClubServices _adminFCS;
        private readonly IFitnessClubServices _fitnessCS;
        public readonly Mock<IAdminFitnessClubRepository> adminService = new Mock<IAdminFitnessClubRepository>();
        public readonly Mock<IFitnessClubRepository> fitnessService = new Mock<IFitnessClubRepository>();
        private Appointment _appointment;
        private ContactUs _contactUs;
        private DietPlan _dietPlan;
        private Instructor _instructor;
        private MemberShipPlan _memberShip;
        private Tools _tools;
        private Workout _workout;
        public BoundaryTest()
        {
            _adminFCS = new AdminFitnessClubServices(adminService.Object);
            _fitnessCS = new FitnessClubServices(fitnessService.Object);
            _appointment = new Appointment
            {
                AppointmentId = "5f97c10d705ed1a8066197ce",
                FullName = "Kumar singh",
                CurrentWeight = 70,
                Height = 172,
                Age = 30,
                GoalWeight = 60,
                Address = "New Delhi",
                PhoneNumber = 9631425152,
                Email = "kumarsingh@gmail.com",
                Remark = "Want wet Loose"
            };
            _dietPlan = new DietPlan
            {
                DietplanId = "5f97c631705ed1a8066197d1",
                Name = "Clean Eating",
                PlanOverview = "Learn everything you need to know before starting the Clean Eating Diet plan including it's history, guidelines & components, & all of the science behind it.",
                Description = "When we discuss diet plans we can typically put them along a spectrum where food quantity is on one end and food quality is on the other. Diets like If It Fits Your Macros(IIFYM) fall as far to the food quantity side as possible while clean eating falls as far to the food quality side as possible.<br> Additionally, in direct opposition to diets like IIFYM it imposes guidelines of what types of foods to eat and does not regulate calories of macros to any meaningful degree. The main principles of clean eating are centered around focusing on the quality of the foods you consume and ensuring they are “clean”. The principles can be summarized in one tenant: Choose whole, natural foods and seek to eliminate processed foods.",
                History = "As clean eating is not a well-defined dietary program it is difficult to trace the history of it as a dieting paradigm back to a singular beginning. One could give credit to the ancient Greek physician Hippocrates who penned one of the first works on dietary principles and is responsible for the famous quote, “Let food by the medicine and medicine be thy food”. <br>General Overview of Components & Main Principles of The Clean Eating Diet<br>Clean eating is based on the principle of eating whole, natural unprocessed foods. Most proponents of clean eating will suggest it is not truly a diet, but rather a view on what to eat and what not to eat. It focuses on food quality and not quantity, so calorie counting is not utilized in this dietary framework.",
                MealTimingFrequency = "On principle, clean eating does not have strict requirements for meal timing or meal frequency (read: how many times a day you eat). <br>However, in application most clean eating programs suggest people eat 5 - 6 smaller, clean food, meals and snacks throughout the day rather than 3 main meals.",
                RestrictionsLimitations = "Clean eating places fairly substantial food restrictions on individuals. Clean eating diets require that people consume only whole, natural foods and eschew everything that is processed. This excludes pastas, breads, crackers, chips, cereals, and anything else that has been processed. This approach also excludes things like condiments (e.g. mustards and spreads) as well as dressings.<br> Additionally most beverages are restricted; this includes alcohol, soda, and juice.",
                Phases = "As traditionally thought of, the clean eating diet does not usually include phases.<br> Most prescriptions of the clean eating diet as instantiated in books, articles, and programs have people initiate the full spectrum of the diet at the outset. Some even include 30 day challenges in which whole, natural foods must be consumed for the entirety of the 30 days with no deviation from the protocol.",
                BestSuitedFor = "Clean eating is best suited for people who are focused on the health properties of food, do not feel the desire to track the calories in their food, and who do not mind fairly restrictive approaches to nutrition. Clean eating allows substantial flexibility in the amount of food one eats, the timing and frequency, and with some effort and diligence the diet can be used for a wide range of people with drastically different goals (e.g. fat loss, muscle gain, or sport performance).",
                HowToFollow = "How easy it is to follow the clean eating diet really depends on what type of person you are and your food preferences. For people who enjoy eating a wide variety of food, do not enjoy food restrictions, and would rather focus on the quantity of their food (i.e. the calories and macros) clean eating may be rather difficult to follow.<br> For people who are creatures of habit, do not mind eating within restricted dietary frameworks and do not enjoy counting their calories of macros clean eating can be an excellent dietary framework to follow.<br> Most people who practice clean eating long term usually build in small amounts of flexibility and follow either an 80/20 or 90/10 rule where they allow themselves to eat food on the restricted list 10-20% of the time.",
                Conclusion = "Clean eating falls on the opposite end of the dietary spectrum from approaches like IIFYM or flexible dieting and focuses almost exclusively on food quality, not food quantity. The main principles of clean eating are centered around focusing on the quality of the foods you consume and ensuring they are “clean”.<br>The principles can be summarized in one tenant: Choose whole, natural foods and seek to eliminate processed foods.<br>The core principles of the diet can be listed as follows: avoid processed foods, avoid refined foods, avoid artificial ingredients, avoid alcohol, avoid soda and fruit juice.",
            };
            _instructor = new Instructor
            {
                InstructorId = "5f97c4ea705ed1a8066197d0",
                Profession = "Gym Owner",
                Competition = "Ex-Bodybuilder",
                TopPlacing = "2nd, British Championships",
                About = "Doug started out as a physical trainer in the army. He was a competitive gymnast, diver and trampolinist. After leaving the army Doug worked as a personal trainer at his local gym. It was then Doug first started bodybuilding. After only 12 months on the bodybuilding scene Doug competed in the British championships where he placed a respectable 5th! In the following year Doug competed again to win 2nd place. Unfortunately Doug tore his rotator cuff and could no longer compete. He then became a national bodybuilding judge with the Natural Bodybuilders Association. Doug now runs a successful fitness centre where he trains males for bodybuilding and powerlifter competitions and females for physique and figure competitions. All of Doug's trainees have reached British championship level. Doug also provides sports specific training services and diet serivces for people from the UK, Europe and the US. Doug has 2 websites, Gemini Fitness Center & Pro Diets.",
                SuggestedWorkOut = "Doug's 4 Day Split Workout (extemely popular workout on M&S), The Super Toning Training Routine, 12 Week Beginners Routine, Maximum Strength Workout, Doug's Mega Cutting Routine."
            };
            _tools = new Tools
            {
                ToolsId = "5f97c86e705ed1a8066197d4",
                Name = "Treadmill",
                Description = "It is one of the widely popular commercial gym equipment. This equipment offers a great warm up exercise before you indulge yourself in a hardcore, and more muscle and bone-stressing exercise machine. If you just want to shed off some weight and burn extra calories, this gym equipment will do the trick.",
            };
            _workout = new Workout
            {
                WorkoutId = "5f97c72b705ed1a8066197d2",
                Name = "Muscle Building",
                Descriprtion = "A 12 week full body beginner workout routine designed to introduce you to a range of gym equipment and basic bodybuilding exercises in under 60 minutes.",
                MainGoal = "Build Muscle",
                WorkoutType = "Full Body",
                TrainingLevel = "Beginner",
                ProgramDuration = "12 Week",
                DaysPerWeek = 3,
                TimePerWorkout = "30-45 Minutes",
                EquipmentRequired = "Barbell, Bodyweight, Cables, Dumbbells, Machines",
                TargetGender = "Male & Female",
                RecommendedSupplements = "Whey Protein, Multivitamin, Fish Oil",
                Author = "Doug Lawrenson",
                WorkoutPDF = ""
            };
            _contactUs = new ContactUs()
            {
                ContactId = "5f8c4b27d90e94643c8a402e",
                FullName = "Kumar Uma",
                Phone = 9631438113,
                Email = "kumarumasingh@iiht.co.in",
                Message = "Call me need to how to book a Tour Guide",
                DateofMessage = DateTime.Now
            };
            _memberShip = new MemberShipPlan()
            {
                PlanId = "5f97c7fe705ed1a8066197d3",
                PlanName = "Starter",
                PlanDetails = "",
                PlanAmount = 4500,
                ValidFor = "",
                PlanStartDate = DateTime.Now
            };
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Testfor_Validate_ContactId is used to test Contact Message is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ContactId()
        {
            //Arrange
            bool res = false;
            //Act
            fitnessService.Setup(repo => repo.UserContactUs(_contactUs)).ReturnsAsync(_contactUs);
            var result = await _fitnessCS.UserContactUs(_contactUs);

            if (result.ContactId.Length.ToString() == _contactUs.ContactId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_ContactId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_AppointmentId is used to test Appointment Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_AppointmentId()
        {
            //Arrange
            bool res = false;
            //Act
            fitnessService.Setup(repo => repo.BookAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _fitnessCS.BookAppointment(_appointment);

            if (result.AppointmentId.Length.ToString() == _appointment.AppointmentId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_AppointmentId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_DietPlanId is used to test DietPlan Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_DietPlanId()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddDietPlan(_dietPlan)).ReturnsAsync(_dietPlan);
            var result = await _adminFCS.AddDietPlan(_dietPlan);

            if (result.DietplanId.Length.ToString() == _dietPlan.DietplanId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_DietPlanId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_InstructorId is used to test Instructor Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_InstructorId()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddInstructor(_instructor)).ReturnsAsync(_instructor);
            var result = await _adminFCS.AddInstructor(_instructor);

            if (result.InstructorId.Length.ToString() == _instructor.InstructorId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_InstructorId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_MemberShipPlanId is used to test MemberShipPlan Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_MemberShipPlanId()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddMemberShipPlan(_memberShip)).ReturnsAsync(_memberShip);
            var result = await _adminFCS.AddMemberShipPlan(_memberShip);

            if (result.PlanId.Length.ToString() == _memberShip.PlanId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_MemberShipPlanId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_ToolsId is used to test Tools Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_ToolsId()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddTools(_tools)).ReturnsAsync(_tools);
            var result = await _adminFCS.AddTools(_tools);

            if (result.ToolsId.Length.ToString() == _tools.ToolsId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_ToolsId=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_workoutId is used to test workout Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_workoutId()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.Addworkout(_workout)).ReturnsAsync(_workout);
            var result = await _adminFCS.Addworkout(_workout);

            if (result.WorkoutId.Length.ToString() == _workout.WorkoutId.Length.ToString())
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "Testfor_Validate_workoutId=" + res + "\n");
            return res;
        }
    }
}
