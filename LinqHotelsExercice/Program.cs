using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqHotelsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new List<Hotel>()//new Hotel[]
            {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
            };

            var rooms = new List<Room>()//new Room[]
            {
                new Room() {RoomNo = 1, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[0], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[0], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[0], Types = 'F', Price = 220},
                new Room() {RoomNo = 1, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 2, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 3, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 4, Hotel=hotels[1], Types = 'D', Price = 230},
                new Room() {RoomNo = 11, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 12, Hotel=hotels[1], Types = 'S', Price = 180},
                new Room() {RoomNo = 21, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[1], Types = 'F', Price = 300},
                new Room() {RoomNo = 1, Hotel=hotels[2], Types = 'D', Price = 175},
                new Room() {RoomNo = 2, Hotel=hotels[2], Types = 'D', Price = 180},
                new Room() {RoomNo = 11, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 21, Hotel=hotels[2], Types = 'S', Price = 100},
                new Room() {RoomNo = 31, Hotel=hotels[2], Types = 'F', Price = 200},
                new Room() {RoomNo = 32, Hotel=hotels[2], Types = 'F', Price = 230},
                new Room() {RoomNo = 1, Hotel=hotels[3], Types = 'D', Price = 500},
                new Room() {RoomNo = 2, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 3, Hotel=hotels[3], Types = 'D', Price = 550},
                new Room() {RoomNo = 11, Hotel=hotels[3], Types = 'S', Price = 350},
                new Room() {RoomNo = 12, Hotel=hotels[3], Types = 'S', Price = 360},
                new Room() {RoomNo = 1, Hotel=hotels[4], Types = 'D', Price = 250},
                new Room() {RoomNo = 2, Hotel=hotels[4], Types = 'D', Price = 170},
                new Room() {RoomNo = 11, Hotel=hotels[4], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[4], Types = 'F', Price = 300},
                new Room() {RoomNo = 22, Hotel=hotels[4], Types = 'F', Price = 310},
                new Room() {RoomNo = 23, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 24, Hotel=hotels[4], Types = 'F', Price = 320},
                new Room() {RoomNo = 1, Hotel=hotels[5], Types = 'D', Price = 290},
                new Room() {RoomNo = 11, Hotel=hotels[5], Types = 'S', Price = 185},
                new Room() {RoomNo = 21, Hotel=hotels[5], Types = 'F', Price = 360},
                new Room() {RoomNo = 22, Hotel=hotels[5], Types = 'F', Price = 370},
                new Room() {RoomNo = 23, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 24, Hotel=hotels[5], Types = 'F', Price = 380},
                new Room() {RoomNo = 1, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 2, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 3, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 4, Hotel=hotels[6], Types = 'D', Price = 200},
                new Room() {RoomNo = 11, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 12, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 13, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 14, Hotel=hotels[6], Types = 'S', Price = 150},
                new Room() {RoomNo = 21, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 22, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 23, Hotel=hotels[6], Types = 'F', Price = 220},
                new Room() {RoomNo = 24, Hotel=hotels[6], Types = 'F', Price = 220}
            };


            var bookings = new List<Booking>() {
                new Booking(){BookingId =1,HotelNo = 1,RoomNo = 11,GuestNo = 4,FromDate = DateTime.Parse("2011-02-02"),ToDate = DateTime.Parse("2011-02-06")},
                new Booking(){BookingId =2,HotelNo = 1,RoomNo = 22,GuestNo = 3,FromDate = DateTime.Parse("2011-04-04"),ToDate = DateTime.Parse("2011-04-06")},
                new Booking(){BookingId =3,HotelNo = 2,RoomNo = 11,GuestNo = 3,FromDate = DateTime.Parse("2011-03-18"),ToDate = DateTime.Parse("2011-03-22")},
                new Booking(){BookingId =4,HotelNo = 3,RoomNo = 31,GuestNo = 1,FromDate = DateTime.Parse("2011-05-22"),ToDate = DateTime.Parse("2011-05-28")},
                new Booking(){BookingId =5,HotelNo = 3,RoomNo = 21,GuestNo = 10,FromDate = DateTime.Parse("2011-02-04"),ToDate = DateTime.Parse("2011-02-12")},
                new Booking(){BookingId =6,HotelNo = 4,RoomNo = 3,GuestNo = 2,FromDate = DateTime.Parse("2011-02-02"),ToDate = DateTime.Parse("2011-02-06")},
                new Booking(){BookingId =7,HotelNo = 4,RoomNo = 3,GuestNo = 2,FromDate = DateTime.Parse("2011-04-20"),ToDate = DateTime.Parse("2011-04-24")},
                new Booking(){BookingId =8,HotelNo = 4,RoomNo = 2,GuestNo = 7,FromDate = DateTime.Parse("2011-04-19"),ToDate = DateTime.Parse("2011-04-24")},
                new Booking(){BookingId =9,HotelNo = 4,RoomNo = 12,GuestNo = 8,FromDate = DateTime.Parse("2011-02-28"),ToDate = DateTime.Parse("2011-03-05")},
                new Booking(){BookingId =11,HotelNo = 4,RoomNo = 11,GuestNo = 6,FromDate = DateTime.Parse("2011-04-11"),ToDate = DateTime.Parse("2011-04-12")},
                new Booking(){BookingId =12,HotelNo = 5,RoomNo = 11,GuestNo = 2,FromDate = DateTime.Parse("2011-02-02"),ToDate = DateTime.Parse("2011-02-06")},
                new Booking(){BookingId =13,HotelNo = 5,RoomNo = 21,GuestNo = 2,FromDate = DateTime.Parse("2011-04-11"),ToDate = DateTime.Parse("2011-04-14")},
                new Booking(){BookingId =14,HotelNo = 5,RoomNo = 2,GuestNo = 7,FromDate = DateTime.Parse("2011-04-16"),ToDate = DateTime.Parse("2011-04-21")},
                new Booking(){BookingId =15,HotelNo = 6,RoomNo = 22,GuestNo = 8,FromDate = DateTime.Parse("2011-02-28"),ToDate = DateTime.Parse("2011-03-03")},
                new Booking(){BookingId =16,HotelNo = 6,RoomNo = 1,GuestNo = 5,FromDate = DateTime.Parse("2011-03-07"),ToDate = DateTime.Parse("2011-03-10")},
                new Booking(){BookingId =17,HotelNo = 6,RoomNo = 11,GuestNo = 6,FromDate = DateTime.Parse("2011-04-02"),ToDate = DateTime.Parse("2011-04-06")},
                new Booking(){BookingId =18,HotelNo = 6,RoomNo = 21,GuestNo = 12,FromDate = DateTime.Parse("2011-02-02"),ToDate = DateTime.Parse("2011-02-07")},
                new Booking(){BookingId =19,HotelNo = 6,RoomNo = 22,GuestNo = 13,FromDate = DateTime.Parse("2011-02-04"),ToDate = DateTime.Parse("2011-02-08")},
                new Booking(){BookingId =20,HotelNo = 6,RoomNo = 23,GuestNo = 14,FromDate = DateTime.Parse("2011-02-05"),ToDate = DateTime.Parse("2011-02-09")},
                new Booking(){BookingId =21,HotelNo = 6,RoomNo = 1,GuestNo = 21,FromDate = DateTime.Parse("2011-02-06"),ToDate = DateTime.Parse("2011-02-10")},
                new Booking(){BookingId =22,HotelNo = 6,RoomNo = 11,GuestNo = 22,FromDate = DateTime.Parse("2011-02-07"),ToDate = DateTime.Parse("2011-02-11")},
                new Booking(){BookingId =23,HotelNo = 6,RoomNo = 21,GuestNo = 23,FromDate = DateTime.Parse("2011-02-08"),ToDate = DateTime.Parse("2011-02-12")},
                new Booking(){BookingId =24,HotelNo = 6,RoomNo = 22,GuestNo = 26,FromDate = DateTime.Parse("2011-02-09"),ToDate = DateTime.Parse("2011-02-13")},
                new Booking(){BookingId =25,HotelNo = 6,RoomNo = 23,GuestNo = 27,FromDate = DateTime.Parse("2011-02-10"),ToDate = DateTime.Parse("2011-02-14")},
                new Booking(){BookingId =26,HotelNo = 6,RoomNo = 24,GuestNo = 30,FromDate = DateTime.Parse("2011-02-11"),ToDate = DateTime.Parse("2011-02-15")},
                new Booking(){BookingId =27,HotelNo = 6,RoomNo = 1,GuestNo = 15,FromDate = DateTime.Parse("2011-02-12"),ToDate = DateTime.Parse("2011-02-16")},
                new Booking(){BookingId =28,HotelNo = 6,RoomNo = 11,GuestNo = 16,FromDate = DateTime.Parse("2011-02-13"),ToDate = DateTime.Parse("2011-02-17")},
                new Booking(){BookingId =29,HotelNo = 6,RoomNo = 21,GuestNo = 17,FromDate = DateTime.Parse("2011-02-14"),ToDate = DateTime.Parse("2011-02-18")},
                new Booking(){BookingId =30,HotelNo = 7,RoomNo = 1,GuestNo = 1,FromDate = DateTime.Parse("2011-02-02"),ToDate = DateTime.Parse("2011-02-06")},
                new Booking(){BookingId =31,HotelNo = 7,RoomNo = 2,GuestNo = 2,FromDate = DateTime.Parse("2011-02-03"),ToDate = DateTime.Parse("2011-02-07")},
                new Booking(){BookingId =32,HotelNo = 7,RoomNo = 3,GuestNo = 3,FromDate = DateTime.Parse("2011-02-04"),ToDate = DateTime.Parse("2011-02-08")},
                new Booking(){BookingId =33,HotelNo = 7,RoomNo = 4,GuestNo = 4,FromDate = DateTime.Parse("2011-02-05"),ToDate = DateTime.Parse("2011-02-09")},
                new Booking(){BookingId =34,HotelNo = 7,RoomNo = 11,GuestNo = 5,FromDate = DateTime.Parse("2011-02-07"),ToDate = DateTime.Parse("2011-02-11")},
                new Booking(){BookingId =35,HotelNo = 7,RoomNo = 21,GuestNo = 6,FromDate = DateTime.Parse("2011-02-08"),ToDate = DateTime.Parse("2011-02-12")},
                new Booking(){BookingId =36,HotelNo = 7,RoomNo = 22,GuestNo = 7,FromDate = DateTime.Parse("2011-02-09"),ToDate = DateTime.Parse("2011-02-13")},
                new Booking(){BookingId =37,HotelNo = 7,RoomNo = 23,GuestNo = 8,FromDate = DateTime.Parse("2011-02-10"),ToDate = DateTime.Parse("2011-02-14")},
                new Booking(){BookingId =38,HotelNo = 7,RoomNo = 24,GuestNo = 9,FromDate = DateTime.Parse("2011-02-11"),ToDate = DateTime.Parse("2011-02-15")},
                new Booking(){BookingId =39,HotelNo = 7,RoomNo = 1,GuestNo = 10,FromDate = DateTime.Parse("2011-02-12"),ToDate = DateTime.Parse("2011-02-16")},
                new Booking(){BookingId =40,HotelNo = 7,RoomNo = 11,GuestNo = 11,FromDate = DateTime.Parse("2011-02-13"),ToDate = DateTime.Parse("2011-02-17")},
                new Booking(){BookingId =41,HotelNo = 7,RoomNo = 21,GuestNo = 12,FromDate = DateTime.Parse("2011-02-14"),ToDate = DateTime.Parse("2011-02-18")},
                new Booking(){BookingId =42,HotelNo = 7,RoomNo = 1,GuestNo = 13,FromDate = DateTime.Parse("2011-02-15"),ToDate = DateTime.Parse("2011-02-16")},
                new Booking(){BookingId =43,HotelNo = 7,RoomNo = 2,GuestNo = 14,FromDate = DateTime.Parse("2011-02-16"),ToDate = DateTime.Parse("2011-02-17")},
                new Booking(){BookingId =44,HotelNo = 7,RoomNo = 3,GuestNo = 15,FromDate = DateTime.Parse("2011-02-17"),ToDate = DateTime.Parse("2011-02-18")},
                new Booking(){BookingId =45,HotelNo = 7,RoomNo = 4,GuestNo = 16,FromDate = DateTime.Parse("2011-02-18"),ToDate = DateTime.Parse("2011-02-19")},
                new Booking(){BookingId =46,HotelNo = 7,RoomNo = 11,GuestNo = 17,FromDate = DateTime.Parse("2011-02-19"),ToDate = DateTime.Parse("2011-02-20")},
                new Booking(){BookingId =47,HotelNo = 7,RoomNo = 21,GuestNo = 18,FromDate = DateTime.Parse("2011-02-20"),ToDate = DateTime.Parse("2011-02-21")},
                new Booking(){BookingId =48,HotelNo = 7,RoomNo = 22,GuestNo = 19,FromDate = DateTime.Parse("2011-02-21"),ToDate = DateTime.Parse("2011-02-22")},
                new Booking(){BookingId =49,HotelNo = 7,RoomNo = 23,GuestNo = 20,FromDate = DateTime.Parse("2011-02-22"),ToDate = DateTime.Parse("2011-02-23")},
                new Booking(){BookingId =50,HotelNo = 7,RoomNo = 24,GuestNo = 21,FromDate = DateTime.Parse("2011-02-23"),ToDate = DateTime.Parse("2011-02-24")},
                new Booking(){BookingId =51,HotelNo = 7,RoomNo = 1,GuestNo = 22,FromDate = DateTime.Parse("2011-02-24"),ToDate = DateTime.Parse("2011-02-25")},
                new Booking(){BookingId =52,HotelNo = 7,RoomNo = 11,GuestNo = 23,FromDate = DateTime.Parse("2011-02-25"),ToDate = DateTime.Parse("2011-02-26")},
                new Booking(){BookingId =53,HotelNo = 7,RoomNo = 21,GuestNo = 24,FromDate = DateTime.Parse("2011-02-26"),ToDate = DateTime.Parse("2011-02-28")},
                new Booking(){BookingId =54,HotelNo = 7,RoomNo = 1,GuestNo = 25,FromDate = DateTime.Parse("2011-02-26"),ToDate = DateTime.Parse("2011-02-28")},
                new Booking(){BookingId =55,HotelNo = 7,RoomNo = 2,GuestNo = 26,FromDate = DateTime.Parse("2011-02-27"),ToDate = DateTime.Parse("2011-02-28")},
                new Booking(){BookingId =56,HotelNo = 7,RoomNo = 3,GuestNo = 27,FromDate = DateTime.Parse("2011-02-28"),ToDate = DateTime.Parse("2011-03-01")},
            }
            ;

            //LINQ SIMPLE SELECT
            //var bookingList =
            //    from mybookings in bookings
            //    select mybookings;

            //var bookingList =
            //    bookings.Select(mybookings => mybookings);

            //Simple select with new Anonoumous type
            //var bookingList =
            //    from mybookings in bookings
            //    select new {mybookings.BookingId,mybookings.GuestNo, mybookings.RoomNo}
            //    ;

            //var bookingList =
            //    bookings.Select(mybookings => new { mybookings.BookingId, mybookings.GuestNo, mybookings.RoomNo })
            //    ;

            //SIMPLE SELECT with where
            //var bookingList =
            //    from mybookings in bookings
            //    where mybookings.GuestNo == 1
            //    select mybookings;

            //SELECT with contains
            //var bookingList =
            //    from mybookings in bookings
            //    where mybookings.HotelNo.ToString().Contains("5")
            //select mybookings;

            //var bookingList =
            //    from mybookings in bookings
            //    orderby mybookings.GuestNo descending, mybookings.RoomNo
            //    select mybookings;

            var bookingList =
                bookings.OrderByDescending(mybookings => mybookings.GuestNo)
                .ThenBy(mybookings => mybookings.RoomNo);


            foreach (var b in bookingList)
            {
               
                Console.WriteLine(b.ToString());
            }



            //Exercise, use LINQ to retrive the following information about Hotels and Rooms:

            // 1) List full details of all Hotels:

            // 2) List full details of all hotels in Roskilde:

            // 3) List the names of all hotels in Roskilde:

            // 4) List all double rooms with a price below 400 pr night:

            // 5) List all double or family rooms with a price below 400 pr night in ascending order of price:

            // 6) List all hotels that starts with 'P':

            // 7) List the number of hotels:

            // 8) List the number of hotels in Roskilde:

            // 9) what is the average price of a room:

            //10) what is the average price of a room at Hotel Scandic:

            //11) what is the total revenue per night from all double rooms:

            //12) List price and type of all rooms at Hotel Prindsen:

            //13) List distinct price and type of all rooms at Hotel Prindsen:

            //14) Join the Hotels and Rooms 

            //15) Be creative....use the join and some aggregate functions..

            Console.ReadLine();

        }
    }
}
