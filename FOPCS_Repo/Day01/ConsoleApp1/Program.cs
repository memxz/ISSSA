// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Workshop_EF_Core.Models;
using Workshop_EF_Core;

var ctx = new MyDbContext();

// database creation
Console.WriteLine("Creating Database.");
CreateDB(ctx);

// adding to database
Console.WriteLine("Creating Staff.");
AddStaff(ctx, "Tiger Woods", "woods@gmail.com");
AddStaff(ctx, "Michael Jordan", "mike@bulls.com");
AddStaff(ctx, "James Worthy", "james@lakers.com");
AddStaff(ctx, "Larry Bird", "bird@celtics.com");
AddStaff(ctx, "Lin Dan", "lindan@gmail.com");
AddStaff(ctx, "Lee Chong Wei", "lcw@gmail.com");

Console.WriteLine("Creating Rooms.");
AddRoom(ctx, "05-01");
AddRoom(ctx, "05-02");
AddRoom(ctx, "05-03");

// updating database
Console.WriteLine("Assigning Rooms.");
AssignRoomFor(ctx, "Tiger Woods", "05-01");
AssignRoomFor(ctx, "Michael Jordan", "05-01");
AssignRoomFor(ctx, "James Worthy", "05-01");
AssignRoomFor(ctx, "Larry Bird", "05-02");
AssignRoomFor(ctx, "Lin Dan", "05-02");
AssignRoomFor(ctx, "Lee Chong Wei", "05-02");

Console.WriteLine("Re-assigning Rooms.");
if (ReassignRoom(ctx, "05-01", "05-03"))
{
    Console.WriteLine("Room assignment successful.");
}

// searching database
Console.WriteLine("Locating Roommates.");
List<Lecturer>? roommates = FindRoommatesOf(ctx, "Tiger Woods");
if (roommates != null)
{
    foreach (Lecturer roommate in roommates)
    {
        Console.WriteLine(roommate.Name);
    }
}

Console.WriteLine("Locating Empty Rooms.");
List<Room> rooms = FindRoomsWithNoOccupants(ctx);
if (rooms.Count == 0)
{
    Console.WriteLine("All rooms are occupied.");
}
else
{
    Console.WriteLine("The following rooms have no occupants.");
    foreach (Room room in rooms)
    {
        Console.WriteLine(room.Number);
    }
}


/*
 * Create a new database; delete existing if exists.
 */
void CreateDB(DbContext ctx)
{
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

/*
 * New staff has joined.
 */
void AddStaff(MyDbContext ctx, string staffName, string staffEmail)
{
    Lecturer lecturer = new Lecturer
    {
        Name = staffName,
        Email = staffEmail
    };

    ctx.Add(lecturer);
    ctx.SaveChanges();
}

/*
 * Add a new room.
 */
void AddRoom(MyDbContext ctx, string roomNo)
{
    Room room = new Room
    {
        Number = roomNo
    };

    ctx.Add(room);
    ctx.SaveChanges();
}

/*
 * Assign room to a staff.
 */
bool AssignRoomFor(MyDbContext ctx, string staffName, string roomNo)
{
    Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer == null)
    {
        return false;
    }

    Room? room = ctx.Room!.FirstOrDefault(x => x.Number == roomNo);
    if (room == null)
    {
        return false;
    }

    lecturer.Room = room;
    ctx.SaveChanges();

    return true;
}

/*
 * Find roommates of a lecturer.
 */
List<Lecturer>? FindRoommatesOf(MyDbContext ctx, string staffName)
{
    // locate the lecturer first
    Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer == null)
    {
        return null;
    }

    List<Lecturer> roommates = new List<Lecturer>();

    // look for the room that this lecturer is in
    List<Lecturer> lecturers = lecturer!.Room!.Lecturer.ToList();

    // find the rest of the lecturers in that room
    foreach (Lecturer roomie in lecturers)
    {
        if (roomie.Id != lecturer.Id)
        {
            roommates.Add(roomie);
        }
    }

    return roommates;
}

/*
 * Re-assign all lecturers in a particular room to a different one.
 */
bool ReassignRoom(MyDbContext ctx, string oldRoomNo, string newRoomNo)
{
    // get hold of the old room
    Room? oldRoom = ctx.Room!.FirstOrDefault(x => x.Number == oldRoomNo);
    if (oldRoom == null)
    {
        return false;
    }

    // get hold of the new room
    Room? newRoom = ctx.Room!.FirstOrDefault(x => x.Number == newRoomNo);
    if (newRoom == null)
    {
        return false;
    }

    List<Lecturer> lecturers = oldRoom.Lecturer.ToList();

    // add lecturers to new room
    foreach (Lecturer lecturer in lecturers)
    {
        newRoom.Lecturer.Add(lecturer);
    }

    // remove lecturers from old room
    oldRoom.Lecturer.Clear();

    // database commit
    ctx.SaveChanges();

    return true;
}

/*
 * List rooms that have not been assigned to any staff.
 */
List<Room> FindRoomsWithNoOccupants(MyDbContext ctx)
{
    return ctx.Room!.Where(x => x.Lecturer.Count == 0).ToList();
}


