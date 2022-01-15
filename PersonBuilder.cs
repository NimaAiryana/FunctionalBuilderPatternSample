using FunctionalBuilderPatternSample;

internal sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);

    public PersonBuilder WorkAs(string position) => Do(p => p.Position = position);

    // can add this method into PersonBuilderExtension or can be here
    //public PersonBuilder LiveIn(string city, string postalCode) => Do(p =>
    //{
    //    p.City = city;
    //    p.PostalCode = postalCode;
    //});
}
