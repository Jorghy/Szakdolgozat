using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Szakdolgozat.DTO.Models;

namespace Szakdolgozat.DAL
{
    public class BookStoreInitializer : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            #region Author
            ICollection<AuthorCo> AuthorList = new List<AuthorCo>();
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 1,
                LastName = "Bennet",
                FirstName = "Abraham",
                Phone = "415 658-9932",
                City = "Berkeley",
                EmailAddress = "abraham.bennet@gmail.com"
            });
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 2,
                LastName = "Stringer",
                FirstName = "Dirk",
                Phone = "415 843-2991",
                Address = "5420 Telegraph Av.",
                City = "Oakland",
                State = "CA",
                Zip = "94609",
                EmailAddress = "dirk.stringer@gmail.com"
            });
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 3,
                LastName = "McBadden",
                FirstName = "Heather",
                Phone = "707 448-4982",
                Address = "301 Putnam",
                City = "Vacaville",
                State = "CA",
                Zip = "95688",
                EmailAddress = "heather.mcbadden@gmail.com"
            });
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 4,
                LastName = "Del Castillo",
                FirstName = "Innes",
                Phone = "615 996-8275",
                Address = "2286 Cram Pl. #86",
                City = "Ann Arbor",
                State = "MI",
                Zip = "48105",
                EmailAddress = "innes.del castillo@gmail.com"
            });
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 5,
                LastName = "White",
                FirstName = "Johnson",
                Phone = "408 496-7223",
                Address = "10932 Bigge Rd.",
                City = "Menlo Park",
                State = "CA",
                Zip = "94025",
                EmailAddress = "johnson.white@gmail.com"
            });
            AuthorList.Add(new AuthorCo
            {
                AuthorId = 6,
                LastName = "Karsen",
                FirstName = "Livia",
                Phone = "415 534-9219",
                Address = "5720 McAuley St.",
                City = "Oakland",
                State = "CA",
                Zip = "94609",
                EmailAddress = "livia.karsen@gmail.com"
            });
            context.Authors.AddRange(AuthorList);
            #endregion

            #region Publisher
            ICollection<PublisherCo> PublisherList = new List<PublisherCo>();
            PublisherList.Add(new PublisherCo
            {
                PublisherId = 1,
                PublisherName = "New Moon Books",
                City = "Boston",
                State = "MA",
                Country = "USA"
            });
            PublisherList.Add(new PublisherCo
            {
                PublisherId = 2,
                PublisherName = "Binnet & Hardley",
                City = "Washington",
                State = "DC",
                Country = "USA"
            });
            PublisherList.Add(new PublisherCo
            {
                PublisherId = 3,
                PublisherName = "Algodata Infosystems",
                City = "Berkeley",
                State = "CA",
                Country = "USA"
            });
            PublisherList.Add(new PublisherCo
            {
                PublisherId = 4,
                PublisherName = "Five Lakes Publishing",
                City = "Chicago",
                State = "IL",
                Country = "USA"
            });
            context.Publishers.AddRange(PublisherList);
            #endregion

            #region Book
            ICollection<BookCo> BookList = new List<BookCo>();
            BookList.Add(new BookCo
            {
                BookId = 1,
                Title = "The Busy Executive's Database Guide",
                Type = "Business",
                PublisherId = 1,
                Price = Decimal.Parse("19.99"),
                Royality = 10,
                YtdSales = 4095,
                Notes = "An overview of available database systems with emphasis on common business applications. Illustrated.",
                PublishedDate = new DateTime(1991,06,12,0,0,0)
            });
            BookList.Add(new BookCo
            {
                BookId = 2,
                Title = "Cooking with Computers: Surreptitious Balance Sheets",
                Type = "Business",
                PublisherId = 2,
                Price = Decimal.Parse("11.95"),
                Royality = 10,
                YtdSales = 3876,
                Notes = "Helpful hints on how to use your electronic resources to the best advantage.",
                PublishedDate = new DateTime(1991, 06, 09, 0, 0, 0)
            });
            BookList.Add(new BookCo
            {
                BookId = 3,
                Title = "You Can Combat Computer Stress!",
                Type = "Business",
                PublisherId = 3,
                Price = Decimal.Parse("2.99"),
                Royality = 24,
                YtdSales = 18722,
                Notes = "The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.",
                PublishedDate = new DateTime(1991, 06, 30, 0, 0, 0)
            });
            context.Books.AddRange(BookList);
            #endregion

            #region BookAuthor
            ICollection<BookAuthorCo> BookAuthorList = new List<BookAuthorCo>();
            BookAuthorList.Add(new BookAuthorCo
            {
                AuthorId = 1,
                BookId = 1,
                AuthorOrder = 1
            });
            context.BookAuthors.AddRange(BookAuthorList);
            #endregion

            #region Job
            ICollection<JobCo> JobList = new List<JobCo>();
            JobList.Add(new JobCo
            {
                JobId = 1,
                JobDesc = "New Hire - Job not specified"
            });
            JobList.Add(new JobCo
            {
                JobId = 2,
                JobDesc = "Chief Executive Officer"
            });
            JobList.Add(new JobCo
            {
                JobId = 3,
                JobDesc = "Business Operations Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 4,
                JobDesc = "Chief Financial Officier"
            });
            JobList.Add(new JobCo
            {
                JobId = 5,
                JobDesc = "Publisher"
            });
            JobList.Add(new JobCo
            {
                JobId = 6,
                JobDesc = "Managing Editor"
            });
            JobList.Add(new JobCo
            {
                JobId = 7,
                JobDesc = "Marketing Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 8,
                JobDesc = "Public Relations Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 9,
                JobDesc = "Acquisitions Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 10,
                JobDesc = "Productions Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 11,
                JobDesc = "Operations Manager"
            });
            JobList.Add(new JobCo
            {
                JobId = 12,
                JobDesc = "Editor"
            });
            JobList.Add(new JobCo
            {
                JobId = 13,
                JobDesc = "Sales Representative"
            });
            JobList.Add(new JobCo
            {
                JobId = 14,
                JobDesc = "Designer"
            });
            context.Jobs.AddRange(JobList);
            #endregion

            #region Role
            ICollection<RoleCo> RoleList = new List<RoleCo>();
            RoleList.Add(new RoleCo
            {
                RoleId = 1,
                RoleDesc = "Shopkeeper"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 2,
                RoleDesc = "CEO"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 3,
                RoleDesc = "Business Operations Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 4,
                RoleDesc = "Chief Financial Officier"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 5,
                RoleDesc = "Publisher"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 6,
                RoleDesc = "Managing Editor"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 7,
                RoleDesc = "Marketing Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 8,
                RoleDesc = "Public Relations Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 9,
                RoleDesc = "Acquisitions Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 10,
                RoleDesc = "Productions Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 11,
                RoleDesc = "Operations Manager"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 12,
                RoleDesc = "Editor"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 13,
                RoleDesc = "Sales Representative"
            });
            RoleList.Add(new RoleCo
            {
                RoleId = 14,
                RoleDesc = "Designer"
            });
            context.Roles.AddRange(RoleList);
            #endregion

            #region Store
            ICollection<StoreCo> StoreList = new List<StoreCo>();
            StoreList.Add(new StoreCo
            {
                StoreId = 1,
                StoreName = "Eric the Read Books",
                StoreAddress = "788 Catamaugus Ave.",
                City = "Seattle",
                State = "WA",
                Zip = "98056"
            });
            StoreList.Add(new StoreCo
            {
                StoreId = 2,
                StoreName = "Barnum's",
                StoreAddress = "567 Pasadena Ave.",
                City = "Tustin",
                State = "CA",
                Zip = "92789"
            });
            StoreList.Add(new StoreCo
            {
                StoreId = 3,
                StoreName = "News & Brews",
                StoreAddress = "577 First St.",
                City = "Los Gatos",
                State = "CA",
                Zip = "96745"
            });
            StoreList.Add(new StoreCo
            {
                StoreId = 4,
                StoreName = "Doc-U-Mat: Quality Laundry and Books",
                StoreAddress = "24-A Avogadro Way",
                City = "Remulade",
                State = "WA",
                Zip = "98014"
            });
            StoreList.Add(new StoreCo
            {
                StoreId = 5,
                StoreName = "Fricative Bookshop",
                StoreAddress = "89 Madison St.",
                City = "Fremont",
                State = "CA",
                Zip = "90019"
            });
            StoreList.Add(new StoreCo
            {
                StoreId = 6,
                StoreName = "Bookbeat",
                StoreAddress = "679 Carson St.",
                City = "Portland",
                State = "OR",
                Zip = "89076"
            });
            context.Stores.AddRange(StoreList);
            #endregion

            #region Sale
            ICollection<SaleCo> SaleList = new List<SaleCo>();
            SaleList.Add(new SaleCo
            {
                SaleId = 1,
                StoreId = 1,
                OrderNum = "6871",
                OrderDate = new DateTime(1994,09,14,00,00,00),
                Quantity = 5,
                PayTerms = "Net 60",
                BookId = 1
            });
            SaleList.Add(new SaleCo
            {
                SaleId = 2,
                StoreId = 1,
                OrderNum = "A2976",
                OrderDate = new DateTime(1993, 05, 24, 00, 00, 00),
                Quantity = 50,
                PayTerms = "Net 30",
                BookId = 1
            });
            SaleList.Add(new SaleCo
            {
                SaleId = 3,
                StoreId = 1,
                OrderNum = "D4482",
                OrderDate = new DateTime(1994, 09, 14, 00, 00, 00),
                Quantity = 10,
                PayTerms = "Net 60",
                BookId = 2
            });
            SaleList.Add(new SaleCo
            {
                SaleId = 4,
                StoreId = 1,
                OrderNum = "N914008",
                OrderDate = new DateTime(1994, 09, 14, 00, 00, 00),
                Quantity = 20,
                PayTerms = "Net 30",
                BookId = 2
            });
            SaleList.Add(new SaleCo
            {
                SaleId = 5,
                StoreId = 1,
                OrderNum = "QQ2299",
                OrderDate = new DateTime(1993, 10, 28, 00, 00, 00),
                Quantity = 15,
                PayTerms = "ON invoice",
                BookId = 3
            });
            SaleList.Add(new SaleCo
            {
                SaleId = 6,
                StoreId = 1,
                OrderNum = "423LL922",
                OrderDate = new DateTime(1994, 09, 14, 00, 00, 00),
                Quantity = 15,
                PayTerms = "ON invoice",
                BookId = 3
            });
            context.Sales.AddRange(SaleList);
            #endregion

            #region User
            ICollection<UserCo> UserList = new List<UserCo>();
            UserList.Add(new UserCo
            {

            });
            #endregion

            base.Seed(context);
        }
    }
}
