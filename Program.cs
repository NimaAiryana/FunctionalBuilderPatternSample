var person = new PersonBuilder()
    .Called("Nima")
    .WorkAs("Airline")
    .LiveIn("Karaj", "1234567890")
    .Build();

Console.WriteLine($"name: {person.Name}, position: {person.Position}, live in: {person.City}, {person.PostalCode}");