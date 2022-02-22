using HotelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.Repo{
    public class HotelBooking : IHotelBooking<HotelDetails>
    {
       
        private readonly IHotelDetails<HotelDetails> hdm;

        public HotelBooking(IHotelDetails<HotelDetails> _hdm){

            hdm=_hdm;
            //hdm.PopulateHotels();
        }
       
        
        public void AddHotel(HotelDetails h)
        {
            hdm.AddHotel(h);
        }



        public void DeleteHotel(int id)
        {
            hdm.DeleteHotel(id);
        }

        public List<HotelDetails> FilterHotel(string name, string place)
        {
            return hdm.FilterHotel(name,place);
        }

        public List<HotelDetails> GetHotel()
        {
            return hdm.GetHotel();
        }

        public HotelDetails GetHotelById(int id)
        {
            return hdm.GetHotelById(id);
        }

        public List<HotelDetails> GetHotelByName(string name)
        {
            return hdm.GetHotelByName(name);
        }

        public List<HotelDetails> GetHotelByPlace(string place)
        {
            return hdm.GetHotelByPlace(place);
        }
    }
}