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
    public class FuctionalTests
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
        public FuctionalTests()
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
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Using this test methd try to test and get all Workout from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetAllWorkout()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AllWorkout());
            var result = await _fitnessCS.AllWorkout();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetAllWorkout=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to get Workout by Name, if get taest is passed to True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_FindWorkoutByName()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.FindWorkout(_workout.Name));
            var result = await _fitnessCS.FindWorkout(_workout.Name);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_FindWorkoutByName=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to get workout by Id, if get test is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetWorkoutById()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.GetWorkoutById(_workout.WorkoutId)).ReturnsAsync(_workout);
            var result = await _fitnessCS.GetWorkoutById(_workout.WorkoutId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetWorkoutById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all Diet Plan from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AllDietPlan()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AllDietPlan());
            var result = await _fitnessCS.AllDietPlan();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AllDietPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to Get DietPlan By Id, if get test is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetDietPlanById()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.GetDietPlanById(_dietPlan.DietplanId)).ReturnsAsync(_dietPlan);
            var result = await _fitnessCS.GetDietPlanById(_dietPlan.DietplanId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetDietPlanById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Testfor_Validate_Valid_Appointment if all data is passed, cas is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Valid_BookAppointment()
        {
            //Arrange
            bool res = false;
            //Act
            fitnessService.Setup(repo => repo.BookAppointment(_appointment)).ReturnsAsync(_appointment);
            var result = await _fitnessCS.BookAppointment(_appointment);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Valid_BookAppointment=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all Instructor from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AllInstructor()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AllInstructor());
            var result = await _fitnessCS.AllInstructor();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AllInstructor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all Tools from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AllTools()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AllTools());
            var result = await _fitnessCS.AllTools();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AllTools=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Appointment Information after take appointment
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AppointmentInformation()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AppointmentInformation(_appointment.AppointmentId)).ReturnsAsync(_appointment);
            var result = await _fitnessCS.AppointmentInformation(_appointment.AppointmentId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AppointmentInformation=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all MemberShipPlan from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AllMemberShipPlan()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.AllMemberShipPlan());
            var result = await _fitnessCS.AllMemberShipPlan();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AllMemberShipPlan=" + res + "\n");
            return res;
        }
        /// <summary>Get Member Ship Plan ById, if get test is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetMemberShipPlanById()
        {
            //Arrange
            var res = false;
            //Action
            fitnessService.Setup(repos => repos.GetMemberShipPlanById(_memberShip.PlanId)).ReturnsAsync(_memberShip);
            var result = await _fitnessCS.GetMemberShipPlanById(_memberShip.PlanId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetMemberShipPlanById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add Contact Us information is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_UserContactUs()
        {
            //Arrange
            bool res = false;
            //Act
            fitnessService.Setup(repo => repo.UserContactUs(_contactUs)).ReturnsAsync(_contactUs);
            var result = await _fitnessCS.UserContactUs(_contactUs);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_UserContactUs=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get all UserAppointment from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_UserAppointment()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.UserAppointment());
            var result = await _adminFCS.UserAppointment();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_UserAppointment=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get All Instructor from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Admin_AllInstructor()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.AllInstructor());
            var result = await _adminFCS.AllInstructor();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Admin_AllInstructor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get Instructor By Id, if get test is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetInstructorById()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.InstructorById(_instructor.InstructorId)).ReturnsAsync(_instructor);
            var result = await _adminFCS.InstructorById(_instructor.InstructorId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetInstructorById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to update existing Instructor by Instructor Id and Instructor Collection
        /// if get updated then test Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_UpdateInstructor()
        {
            //Arrange
            bool res = false;
            var _instructorUpdate = new Instructor()
            {
                InstructorId = "",
                Profession = "Gym Owner",
                Competition = "Ex-Bodybuilder",
                TopPlacing = "2nd, British Championships",
                About = "Doug started out as a physical trainer in the army. He was a competitive gymnast, diver and trampolinist. After leaving the army Doug worked as a personal trainer at his local gym. It was then Doug first started bodybuilding. After only 12 months on the bodybuilding scene Doug competed in the British championships where he placed a respectable 5th! In the following year Doug competed again to win 2nd place. Unfortunately Doug tore his rotator cuff and could no longer compete. He then became a national bodybuilding judge with the Natural Bodybuilders Association. Doug now runs a successful fitness centre where he trains males for bodybuilding and powerlifter competitions and females for physique and figure competitions. All of Doug's trainees have reached British championship level. Doug also provides sports specific training services and diet serivces for people from the UK, Europe and the US. Doug has 2 websites, Gemini Fitness Center & Pro Diets.",
                SuggestedWorkOut = "Doug's 4 Day Split Workout (extemely popular workout on M&S), The Super Toning Training Routine, 12 Week Beginners Routine, Maximum Strength Workout, Doug's Mega Cutting Routine."
            };
            //Act
            adminService.Setup(repo => repo.UpdateInstructor(_instructorUpdate.InstructorId, _instructorUpdate)).ReturnsAsync(_instructorUpdate);
            var result = await _adminFCS.UpdateInstructor(_instructorUpdate.InstructorId, _instructorUpdate);
            if (result == _instructorUpdate)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_UpdateInstructor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to Delete Instructor by InstructorId Id, if get then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_DeleteInstructor()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.DeleteInstructor(_instructor.InstructorId)).ReturnsAsync(true);
            var resultDelete = await _adminFCS.DeleteInstructor(_instructor.InstructorId);
            //Assertion
            if (resultDelete == true)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFor_DeleteInstructor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to update existing DietPlan by DietPlan Id and DietPlan Collection
        /// if get updated then test Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_UpdateDietPlan()
        {
            //Arrange
            bool res = false;
            var _dietPlanUpdate = new DietPlan
            {
                DietplanId = "",
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
            //Act
            adminService.Setup(repo => repo.UpdateDietPlan(_dietPlanUpdate.DietplanId, _dietPlanUpdate)).ReturnsAsync(_dietPlanUpdate);
            var result = await _adminFCS.UpdateDietPlan(_dietPlanUpdate.DietplanId, _dietPlanUpdate);
            if (result == _dietPlanUpdate)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_UpdateDietPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to Delete DietPlan by DietPlan Id, if get then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_DeleteDietPlan()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.DeleteDietPlan(_dietPlan.DietplanId)).ReturnsAsync(true);
            var resultDelete = await _adminFCS.DeleteDietPlan(_dietPlan.DietplanId);
            //Assertion
            if (resultDelete == true)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFor_DeleteDietPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to update existing Workout by Workout Id and Workout Collection
        /// if get updated then test Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_UpdateWorkout()
        {
            //Arrange
            bool res = false;
            var _workoutUpdate = new Workout
            {
                WorkoutId = "",
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
            //Act
            adminService.Setup(repo => repo.UpdateWorkout(_workoutUpdate.WorkoutId, _workoutUpdate)).ReturnsAsync(_workoutUpdate);
            var result = await _adminFCS.UpdateWorkout(_workoutUpdate.WorkoutId, _workoutUpdate);
            if (result == _workoutUpdate)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_UpdateWorkout=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to Delete Workout by Workout Id, if get then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_DeleteWorkout()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.DeleteWorkout(_workout.WorkoutId)).ReturnsAsync(true);
            var resultDelete = await _adminFCS.DeleteWorkout(_workout.WorkoutId);
            //Assertion
            if (resultDelete == true)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFor_DeleteWorkout=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to update existing MemberShipPlan by Plan Id and MemberShipPlan Collection
        /// if get updated then test Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_UpdateMemberShipPlan()
        {
            //Arrange
            bool res = false;
            var _memberShipUpdate = new MemberShipPlan()
            {
                PlanId = "",
                PlanName = "",
                PlanDetails = "",
                PlanAmount = 4500,
                ValidFor = "",
                PlanStartDate = DateTime.Now
            };
            //Act
            adminService.Setup(repo => repo.UpdateMemberShipPlan(_memberShipUpdate.PlanId, _memberShipUpdate)).ReturnsAsync(_memberShipUpdate);
            var result = await _adminFCS.UpdateMemberShipPlan(_memberShipUpdate.PlanId, _memberShipUpdate);
            if (result == _memberShipUpdate)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_UpdateMemberShipPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to Delete MemberShipPlan by Plan Id, if get then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_DeleteMemberShipPlan()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.DeleteMemberShipPlan(_memberShip.PlanId)).ReturnsAsync(true);
            var resultDelete = await _adminFCS.DeleteMemberShipPlan(_memberShip.PlanId);
            //Assertion
            if (resultDelete == true)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFor_DeleteMemberShipPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test to Get Tools By Id, if get test is True
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_GetToolsById()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.ToolsById(_tools.ToolsId)).ReturnsAsync(_tools);
            var result = await _adminFCS.ToolsById(_tools.ToolsId);
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_GetToolsById=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to update existing Tools by tools Id and Tools Collection
        /// if get updated then test Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_UpdateTools()
        {
            //Arrange
            bool res = false;
            var _toolsUpdate = new Tools
            {
                ToolsId = "",
                Name = "Treadmill",
                Description = "It is one of the widely popular commercial gym equipment. This equipment offers a great warm up exercise before you indulge yourself in a hardcore, and more muscle and bone-stressing exercise machine. If you just want to shed off some weight and burn extra calories, this gym equipment will do the trick.",
            };
            //Act
            adminService.Setup(repo => repo.UpdateTools(_toolsUpdate.ToolsId, _toolsUpdate)).ReturnsAsync(_toolsUpdate);
            var result = await _adminFCS.UpdateTools(_toolsUpdate.ToolsId, _toolsUpdate);
            if (result == _toolsUpdate)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_UpdateTools=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to Delete Tools by Tools Id, if get then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_DeleteTools()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.DeleteTools(_tools.ToolsId)).ReturnsAsync(true);
            var resultDelete = await _adminFCS.DeleteTools(_tools.ToolsId);
            //Assertion
            if (resultDelete == true)
            {
                res = true;
            }
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestFor_DeleteTools=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using this test methd try to test and get All Contact Message from Services and Repository method
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_AllContactMessage()
        {
            //Arrange
            var res = false;
            //Action
            adminService.Setup(repos => repos.AllContactMessage());
            var result = await _adminFCS.AllContactMessage();
            //Assertion
            if (result != null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_AllContactMessage=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add new DietPlan is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_AddDietPlan()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddDietPlan(_dietPlan)).ReturnsAsync(_dietPlan);
            var result = await _adminFCS.AddDietPlan(_dietPlan);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_AddDietPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add new Instructor is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_AddInstructor()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddInstructor(_instructor)).ReturnsAsync(_instructor);
            var result = await _adminFCS.AddInstructor(_instructor);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_AddInstructor=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add new MemberShipPlan is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_MemberShipPlan()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddMemberShipPlan(_memberShip)).ReturnsAsync(_memberShip);
            var result = await _adminFCS.AddMemberShipPlan(_memberShip);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_MemberShipPlan=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add new Tools is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_Tools()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.AddTools(_tools)).ReturnsAsync(_tools);
            var result = await _adminFCS.AddTools(_tools);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_Tools=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Using the test method try to test Add new Addworkout is getting added, if added then Passed to true
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> Testfor_Validate_Add_Valid_Addworkout()
        {
            //Arrange
            bool res = false;
            //Act
            adminService.Setup(repo => repo.Addworkout(_workout)).ReturnsAsync(_workout);
            var result = await _adminFCS.Addworkout(_workout);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "Testfor_Validate_Add_Valid_Addworkout=" + res + "\n");
            return res;
        }
    }
}
