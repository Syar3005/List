using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class HardDriveList
    {
        private List<HardDrive> hardDrives;

        public HardDriveList()
        {
            hardDrives = new List<HardDrive>();
        }

        public List<HardDrive> GetAll()
        {
            return hardDrives;
        }

        public HardDrive GetById(int id)
        {
            return hardDrives.Find(x => x.Id == id);
        }

        public void Insert(HardDrive hardDrive)
        {
            hardDrives.Add(hardDrive);
        }

        public void Delete(int id)
        {
            HardDrive hardDrive = GetById(id);
            hardDrives.Remove(hardDrive);
        }

        public void Update(HardDrive hardDrive)
        {
            HardDrive updatingHardDrive = GetById(hardDrive.Id);
            updatingHardDrive.Name = hardDrive.Name;
            updatingHardDrive.Capacity = hardDrive.Capacity;
            updatingHardDrive.Price = hardDrive.Price;
        }

        public List<HardDrive> Find(double price)
        {
            return hardDrives.FindAll(x => x.Price < price);
        }
    }
}
