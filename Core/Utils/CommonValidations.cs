namespace Core.Utils
{
    public static class CommonValidations
    {
        public static bool BeAValidDate(DateTime date)   
            => date.Date <= DateTime.Now.Date;
    }
}
