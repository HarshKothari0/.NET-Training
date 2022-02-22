using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.Models;

namespace HotelAPI.Repo{

    public interface IHotelBooking<HotelDetails>{
       
        public void AddHotel(HotelDetails h);
        public void DeleteHotel(int id);
        public List<HotelDetails> GetHotel();
        public HotelDetails GetHotelById(int id);
        public List<HotelDetails> GetHotelByName(string name);
        public List<HotelDetails> GetHotelByPlace(string place);
        public List<HotelDetails> FilterHotel(string name,string place);
        
        

    }
}