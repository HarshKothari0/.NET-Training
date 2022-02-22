using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAPI.Models{
    public class HotelDetails : IHotelDetails<HotelDetails>
    {
        public int Hid{get;set;}
        public string HName{get;set;}
        public string HLocation{get;set;}
        public string HAddress{get;set;}
        public int DoubleBed{get;set;}
        public int SingleBed{get;set;}
        public double DoublePrice{get;set;}
        public double SinglePrice{get;set;}
        public string ImagePath{get;set;}

        //public static List<HotelDetails> hotels=new List<HotelDetails>();
        

        public HotelDetails(){

        }

        public HotelDetails(int Hid,string HName,string HLocation,string HAddress,int DoubleBed,int SingleBed,double DoublePrice,double SinglePrice,string ImagePath){
            this.Hid=Hid;
            this.HName=HName;
            this.HLocation=HLocation;
            this.HAddress=HAddress;
            this.DoubleBed=DoubleBed;
            this.SingleBed=SingleBed;
            this.DoublePrice=DoublePrice;
            this.SinglePrice=SinglePrice;
            this.ImagePath=ImagePath;
        }
        public static List<HotelDetails> hotels=PopulateHotels();
        public void AddHotel(HotelDetails h)
        {
            hotels.Add(h);
        }

        public void DeleteHotel(int id)
        {
            HotelDetails hotel=GetHotelById(id);
            hotels.Remove(hotel);
        }

        public List<HotelDetails> GetHotel()
        {   
            
            return hotels;
        }

        


        public HotelDetails GetHotelById(int id)
        {
            hotels=GetHotel();
            HotelDetails hotel=hotels.Where(x=>x.Hid==id).FirstOrDefault();
            return hotel;

        }

        public List<HotelDetails> GetHotelByName(string name)
        {
            hotels=GetHotel();
            List<HotelDetails> temp=new List<HotelDetails>();
            temp=hotels.Where(x=>x.HName==name).Select(x=>x).ToList();
            return temp;
        }

        public List<HotelDetails> GetHotelByPlace(string place)
        {
            hotels=GetHotel();
            List<HotelDetails> temp=new List<HotelDetails>();
            temp=hotels.Where(x=>x.HLocation==place).Select(x=>x).ToList();
            return temp;
        }

        public static List<HotelDetails> PopulateHotels()
        {
            List<HotelDetails> temp=new List<HotelDetails>();
            temp.Add(new HotelDetails(1,"Radissons","Jaipur","Near City Center Mall",30,40,6000,4000,"~/images/radissons.jpg"));
            temp.Add(new HotelDetails(2,"The TAJ","Mumbai","Opposite to Arabian Sea",20,36,25000,14000,"~/images/taj.jpg"));
            temp.Add(new HotelDetails(3,"The Oberois","Udaipur","Lake Pichola",60,8,16000,12000,"~/images/oberoi.jpg"));
            temp.Add(new HotelDetails(4,"The Trident","Mumbai","Marine Drive",30,40,22000,19000,"~/images/trident.jpg"));
            return temp;
        }

        public List<HotelDetails> FilterHotel(string name, string place)
        {
            hotels=GetHotel();
            List<HotelDetails> temp=new List<HotelDetails>();
            temp=hotels.Where(x=>x.HLocation==place && x.HName==name).Select(x=>x).ToList();
            return temp;
        }
    }


}