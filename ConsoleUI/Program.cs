
using DemoLibrary;

Person owner = new Person
{
    FirstName = "Tim",
    LastName = "Corey",
    EmailAddress = "tim@corey.com",
    PhoneNumber = "6459999999"
};

Chore chore = new Chore
{
    ChoreName = "Take out the trash",
    Owner = owner
};

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();



