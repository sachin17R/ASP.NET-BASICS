using System.Collections.Generic;

namespace MVCframework.DataComponent
{
    public interface ICarInfoRepo
    {
        void AddNewCar(CarInfo data);
        void DeleteCar(int entryId);
        CarInfo FindCar(int id);
        List<CarInfo> GetAllCars();
        void UpdateCar(CarInfo carInfo); 
    }
}