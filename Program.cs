var person = new PersonBuilder()
    .Called("Nima", "Airyana")
    .WorkAs("Airline")
    .LiveIn("Karaj", "1234567890")
    .Build();

Console.WriteLine($"name: {person.FirstName} {person.LastName}, position: {person.Position}, live in: {person.City}, {person.PostalCode}");