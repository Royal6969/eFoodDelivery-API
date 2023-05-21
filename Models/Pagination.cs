namespace eFoodDelivery_API.Models
{
    public class Pagination
    {
        public int ActualPage { get; set; }     // the current page that you are on
        public int PageSize { get; set; }       // how many records you want on one page will be the page size
        public int RecordsNumber { get; set; }  // total records will be the total number of records that are avaible for the search that they have
    }
}
