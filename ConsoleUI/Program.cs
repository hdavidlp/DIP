

using ConsoleUI;
using DemoLibrary;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Tim";
owner.LastName = "Corey";
owner.EmailAddress = "tim@corey.com";
owner.PhoneNumber = "6459999999";


IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;

chore.PerformedWork(3);
chore.PerformedWork(1.5);
chore.CompleteChore();



