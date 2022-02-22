using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelAPI.Repo;
using HotelAPI.Models;

namespace HotelAPI{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController:ControllerBase{
        private readonly IHotelBooking<HotelDetails> hb;
        public HotelController(IHotelBooking<HotelDetails> _hb){
            hb=_hb;
        }
        

        [HttpPost("AddHotel")]
        public void AddHotel([FromBody] HotelDetails h){
            hb.AddHotel(h);
        }

        [HttpDelete("DeleteHotel/{id}")]
        public void DeleteHotel(int id){
            hb.DeleteHotel(id);
        }

        [HttpGet("GetHotel")]
        public List<HotelDetails> GetHotel(){
            return hb.GetHotel();
        }

        [HttpGet("GetHotel/{id}")]
        public HotelDetails GetHotelById(int id){
            return hb.GetHotelById(id);
        }

        [HttpGet("GetHotelName/{name}")]
        public List<HotelDetails> GetHotelByName(string name){
            return hb.GetHotelByName(name);
        }

        [HttpGet("GetHotelPlace/{place}")]
        public List<HotelDetails> GetHotelByPlace(string place){
            return hb.GetHotelByPlace(place);
        }

        [HttpGet("FilterHotel/{name}/{place}")]
        public List<HotelDetails> FilterHotel(string name, string place)
        {
            return hb.FilterHotel(name,place);
        }

        [HttpPut("EditHotel/{id}")]
        public void ModifyHotel(int id,[FromBody] HotelDetails hd){
            hb.DeleteHotel(hd.Hid);
            hb.AddHotel(hd);
        }

    }
}