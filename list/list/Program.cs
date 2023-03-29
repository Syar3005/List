using list;

HardDriveList hardDriveList = new HardDriveList();

hardDriveList.Insert(new HardDrive(1, "WD Blue", 1000, 5000));
hardDriveList.Insert(new HardDrive(2, "Seagate Barracuda", 2000, 7000));
hardDriveList.Insert(new HardDrive(3, "Samsung Evo", 500, 12000));
hardDriveList.Insert(new HardDrive(4, "Crucial MX500", 1000, 9000));

//Показать все
Console.WriteLine("GetAll");
List<HardDrive> allHardDrives = hardDriveList.GetAll();
ShowAll(allHardDrives);

//Показать по id
Console.WriteLine("GetById");
HardDrive hardDriveById = hardDriveList.GetById(2);
Console.WriteLine($"Id: {hardDriveById.Id}, Название: {hardDriveById.Name}, Емкость: {hardDriveById.Capacity}, Цена: {hardDriveById.Price}");

//Добавление
Console.WriteLine("Insert");
HardDrive newHardDrive = new HardDrive(5, "Intel Optane", 500, 15000);
hardDriveList.Insert(newHardDrive);

allHardDrives = hardDriveList.GetAll();
ShowAll(allHardDrives);

//Обновление
Console.WriteLine("Update");
HardDrive hardDriveToUpdate = new HardDrive(4, "Crucial MX500", 2000, 10000);
hardDriveList.Update(hardDriveToUpdate);

allHardDrives = hardDriveList.GetAll();
ShowAll(allHardDrives);

//Удаление
Console.WriteLine("Delete");
hardDriveList.Delete(5);

allHardDrives = hardDriveList.GetAll();
ShowAll(allHardDrives);

//Поиск по цене
Console.WriteLine("Find");
List<HardDrive> foundHardDrives = hardDriveList.Find(9000);
ShowAll(foundHardDrives);

//Метод, который выводит весь лист
void ShowAll(List<HardDrive> allHardDrives)
{
    foreach (HardDrive hardDrive in allHardDrives)
    {
        Console.WriteLine($"Id: {hardDrive.Id}, Название: {hardDrive.Name}, Емкость: {hardDrive.Capacity}, Цена: {hardDrive.Price}");
    }
}