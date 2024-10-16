using JourneyExpertSystem.Models;

namespace JourneyExpertSystem
{
    internal class AppData
    {
        internal static string? UserBudget;
        internal static string? UserHasVisa;
        internal static string? UserPreferences;

        internal static List<Question> Questions { get; set; } = [

            new Question("Ваш бюджет?", [
                new Answer("Маленький", () => UserBudget = "small"),
                new Answer("Средний", () => UserBudget = "medium"),
                new Answer("Большой", () => UserBudget = "high")
            ]),

            new Question("У вас есть виза?", [
                new Answer("Да", () => UserHasVisa = "yes"),
                new Answer("Нет", () => UserHasVisa = "no"),
            ]),

            new Question("Предпочтения", [
                new Answer("Не важно", () => UserPreferences = "no matter"),
                new Answer("Горы", () => UserPreferences = "mountains"),
                new Answer("Море", () => UserPreferences = "sea")
            ])
        ];

        internal static IEnumerable<Country> Countries { get; set; } = [
            new Country(
                name: "США",
                budget: "high",
                requiredVisa: "yes",
                features: "sea"
            )
        ];

        internal static IEnumerable<Country> AvailiableCountries => Countries
            .Where(country => string.IsNullOrEmpty(UserBudget) || country.Budget == UserBudget)
            .Where(country => string.IsNullOrEmpty(UserHasVisa) || country.RequiredVisa == UserHasVisa)
            .Where(country => string.IsNullOrEmpty(UserPreferences) || country.Features == UserPreferences);
    }
}
