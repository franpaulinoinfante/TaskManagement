using TaskManagement.Types;

namespace TaskManagement.TaskViews.CategoryViews;

public class SubCategories
{
    public static Dictionary<Category, Category[]> SubCategoriesDic = new()
    {
        {
            Category.Personal, new[]
            {
                Category.PersonalDevelopment,
                Category.GoalsAndPlanning,
                Category.SelfLearning,
                Category.JournalingAndReflections,
                Category.HabitsAndRoutines
            }
        },
        {
            Category.Work, new[]
            {
                Category.Meetings,
                Category.Reports,
                Category.SoftwareDevelopment,
                Category.DataAnalysis,
                Category.Presentations
            }
        },
        {
            Category.Studies, new[]
            {
                Category.TasksAndProjects,
                Category.Exams,
                Category.PendingReadings,
                Category.ClassesAndCourses
            }
        },
        {
            Category.Home, new[]
            {
                Category.Cleaning,
                Category.HouseholdShopping,
                Category.Maintenance,
                Category.UtilityPayments
            }
        },
        {
            Category.HealthAndWellness, new[]
            {
                Category.MedicalAppointments,
                Category.Exercise,
                Category.Nutrition,
                Category.Rest
            }
        }
    };
}
