using SalesWebMvc.Models.Enums;
using System;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amounth, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amounth = amounth;
            Status = status;
            Seller = seller;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amounth { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }
    }
}
