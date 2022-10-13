using EntityFrameworkDemo;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkDemo.Models;

var ctx = new MyDbContext();

// database creation
Console.WriteLine("Creating Database.");
CreateDB(ctx);

// adding to database
Console.WriteLine("Creating Staff.");
AddStaff(ctx, "Tiger Woods");
AddStaff(ctx, "Michael Jordan");
AddStaff(ctx, "James Worthy");

Console.WriteLine("Creating Rooms.");
AddRoom(ctx, "05-01");
AddRoom(ctx, "05-02");
AddRoom(ctx, "05-03");
AddRoom(ctx, "05-04");
AddRoom(ctx, "05-05");

// updating database
Console.WriteLine("Assigning Rooms.");
AssignRoomFor(ctx, "Tiger Woods", "05-01");
AssignRoomFor(ctx, "Michael Jordan", "05-02");
AssignRoomFor(ctx, "James Worthy", "05-03");

Console.WriteLine("Changing Room.");
ChangeRoomFor(ctx, "Tiger Woods", "05-04");

// searching database
Console.WriteLine("Locating Staff.");
string? roomNo = FindRoomFor(ctx, "Michael Jordan");
if (roomNo != null) {
    Console.WriteLine("Staff located in room '{0}'", roomNo);
}

// deleting from database
Console.WriteLine("Removing Staff.");
if (RemoveStaff(ctx, "James Worthy")) {
    Console.WriteLine("Successfully removed staff.");
}
else {
    Console.WriteLine("Failed to remove staff.");
}

// list all staff
Console.WriteLine("Listing all Staff.");
List<Lecturer> lecturers = GetAllLecturers(ctx);
foreach (Lecturer lecturer in lecturers) {
    Console.WriteLine(lecturer.Name);
}




/*
 * Delete database (if exists) and create a new one.
 */
void CreateDB(DbContext ctx) {
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

/*
 * New staff has joined.
 */
void AddStaff(MyDbContext ctx, string staffName) {
    Lecturer lecturer = new Lecturer {
        Name = staffName
    };

    ctx.Add(lecturer);
    ctx.SaveChanges();
}

/*
 * Add a new room.
 */
void AddRoom(MyDbContext ctx, string roomNo)
{
    Room room = new Room {
        Number = roomNo
    };

	ctx.Add(room);
	ctx.SaveChanges();
}

/*
 * Find which room a staff is assigned to.
 */
string? FindRoomFor(MyDbContext ctx, string staffName) {
    Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer != null && lecturer.Room != null) {
        return lecturer.Room.Number;
	}

    return null;
}

/*
 * Staff has resigned.
 */
bool RemoveStaff(MyDbContext ctx, string staffName) {
	Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer != null) {
        ctx.Remove(lecturer);
        ctx.SaveChanges();
        return true;
	}

    return false;
}

/*
 * Assign room to a staff.
 */
bool AssignRoomFor(MyDbContext ctx, string staffName, string roomNo) {
	Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer == null) {
        return false;
	}

    Room? room = ctx.Room!.FirstOrDefault(x => x.Number == roomNo);
    if (room == null) {
        return false;
	}

    lecturer.Room = room;
    ctx.SaveChanges();

    return true;
}

/*
 * Only assign room if it is empty.
 */
bool ChangeRoomFor(MyDbContext ctx, string staffName, string roomNo)
{
    Lecturer? lecturer = ctx.Lecturer!.FirstOrDefault(x => x.Name == staffName);
    if (lecturer == null) {
        return false;
    }

    Room? room = ctx.Room!.FirstOrDefault(x => x.Number == roomNo);
    if (room != null) {
        room.Lecturer = lecturer;
        ctx.SaveChanges();

        return true;
    }

    return false;
}

/*
 * Equivalent to a "SELECT * FROM Lecturers".
 */
List<Lecturer> GetAllLecturers(MyDbContext ctx) {
    return ctx.Lecturer!.ToList();
}