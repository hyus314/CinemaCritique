namespace CinemaCritique.Common
{
    public static class EntityValidations
    {
        public static class Movie
        {
            public const int TitleMaxLength = 50;
            
            public const int DirectorMaxLength = 40;
            public const int DescriptionMaxLength = 300;
            
            public const int YearPublishedMax = 2024;
            public const int YearPublishedMin = 1888;
            
            public const int URLMaxLength = 2000;

            public const int MainRolesMaxLength = 150;
        }

        public static class Review
        {
            public const int ContentMaxLength = 300;
            
            public const int RatingMinValue = 1;
            public const int RatingMaxValue = 10;
        }

        public static class Genre
        {
            public const int NameMaxLength = 20;
        }

        public static class User
        {
            public const int FirstNameMaxLength = 30;
            public const int LastNameMaxLength = 30;
        }
    }
}