using System.Collections.Generic;

namespace DNP_Assignment.Models
{
    public interface AdultManager
    {
        void readAdults();
        void addAdult(Adult adult);
        List<Adult> getAllAdults();
        Adult getAdult(Adult adult);
        List<Adult> getAdultsByFirstName(string FirstName);
        List<Adult> getAdultsByLastName(string LastName);
        Adult getAdultsByID(int ID);
        List<Adult> getAdultsByHaircolor(string Haircolor);
        List<Adult> getAdultsByEyecolor(string Eyecolor);
        List<Adult> getAdultsByAge(int Age);
        List<Adult> getAdultsByHeight(int Height);
        List<Adult> getAdultsByWeight(double Weight);
        List<Adult> getAdultsByJob(string job);
        List<Adult> getAdultsBySex(string Sex);
    }
}
