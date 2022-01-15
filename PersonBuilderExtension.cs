internal static class PersonBuilderExtension
{
    // this method can placed inside PersonBuilder class, this is just an example of Extensions from Builders
    public static PersonBuilder LiveIn(this PersonBuilder personBuilder, string city, string postalCode) => personBuilder.Do(p =>
    {
        p.City = city;
        p.PostalCode = postalCode;
    });
}
