using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assenment.Models
{
    public partial class TrainingDBContext : DbContext
    {
        public TrainingDBContext()
        {
        }

        public TrainingDBContext(DbContextOptions<TrainingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abc> Abcs { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AjaxCrud> AjaxCruds { get; set; } = null!;
        public virtual DbSet<AjaxSonal> AjaxSonals { get; set; } = null!;
        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; } = null!;
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<Basic> Basics { get; set; } = null!;
        public virtual DbSet<BooKsample> BooKsamples { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<BookGallery> BookGalleries { get; set; } = null!;
        public virtual DbSet<BookModel> BookModels { get; set; } = null!;
        public virtual DbSet<BookStore> BookStores { get; set; } = null!;
        public virtual DbSet<BookTable1> BookTable1s { get; set; } = null!;
        public virtual DbSet<Candidate> Candidates { get; set; } = null!;
        public virtual DbSet<Card> Cards { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Choice> Choices { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<CityTable> CityTables { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<CountryTable> CountryTables { get; set; } = null!;
        public virtual DbSet<CrudAjax> CrudAjaxes { get; set; } = null!;
        public virtual DbSet<CrudFirst> CrudFirsts { get; set; } = null!;
        public virtual DbSet<Custmer> Custmers { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Ddvd> Ddvds { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentTbl> DepartmentTbls { get; set; } = null!;
        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<DroupdownTable> DroupdownTables { get; set; } = null!;
        public virtual DbSet<Dummy1> Dummy1s { get; set; } = null!;
        public virtual DbSet<Dummy2> Dummy2s { get; set; } = null!;
        public virtual DbSet<EmailAddress> EmailAddresses { get; set; } = null!;
        public virtual DbSet<Emplo> Emplos { get; set; } = null!;
        public virtual DbSet<Employ> Employs { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeCrud> EmployeeCruds { get; set; } = null!;
        public virtual DbSet<EmployeeModel> EmployeeModels { get; set; } = null!;
        public virtual DbSet<EmployeeScr> EmployeeScrs { get; set; } = null!;
        public virtual DbSet<EmployeeService> EmployeeServices { get; set; } = null!;
        public virtual DbSet<EmployeeSonal> EmployeeSonals { get; set; } = null!;
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; } = null!;
        public virtual DbSet<EmployeeTable1> EmployeeTables1 { get; set; } = null!;
        public virtual DbSet<EmployeeTbl> EmployeeTbls { get; set; } = null!;
        public virtual DbSet<EmployeesSs> EmployeesSses { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Exam1> Exams1 { get; set; } = null!;
        public virtual DbSet<ExamResult> ExamResults { get; set; } = null!;
        public virtual DbSet<Febr> Febrs { get; set; } = null!;
        public virtual DbSet<Febrr> Febrrs { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<HariomBookTable> HariomBookTables { get; set; } = null!;
        public virtual DbSet<HariomEmp> HariomEmps { get; set; } = null!;
        public virtual DbSet<HariomEmployee> HariomEmployees { get; set; } = null!;
        public virtual DbSet<HariomEmployeeDetail> HariomEmployeeDetails { get; set; } = null!;
        public virtual DbSet<HotelSystem> HotelSystems { get; set; } = null!;
        public virtual DbSet<Information> Information { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Management> Managements { get; set; } = null!;
        public virtual DbSet<ManishAjaxCrud> ManishAjaxCruds { get; set; } = null!;
        public virtual DbSet<ManishCodeFirst> ManishCodeFirsts { get; set; } = null!;
        public virtual DbSet<ManishCustomer> ManishCustomers { get; set; } = null!;
        public virtual DbSet<ManishDesignPattern> ManishDesignPatterns { get; set; } = null!;
        public virtual DbSet<ManishDropDownList> ManishDropDownLists { get; set; } = null!;
        public virtual DbSet<ManishEmployee> ManishEmployees { get; set; } = null!;
        public virtual DbSet<ManishItem> ManishItems { get; set; } = null!;
        public virtual DbSet<ManishOrder> ManishOrders { get; set; } = null!;
        public virtual DbSet<ManishProduct> ManishProducts { get; set; } = null!;
        public virtual DbSet<ManishSignUp> ManishSignUps { get; set; } = null!;
        public virtual DbSet<ManishUploadImage> ManishUploadImages { get; set; } = null!;
        public virtual DbSet<Masoom> Masooms { get; set; } = null!;
        public virtual DbSet<Masoom1> Masoom1s { get; set; } = null!;
        public virtual DbSet<MasoomBook> MasoomBooks { get; set; } = null!;
        public virtual DbSet<MasoomDepartment> MasoomDepartments { get; set; } = null!;
        public virtual DbSet<MasoomRaja> MasoomRajas { get; set; } = null!;
        public virtual DbSet<MasoomStudent> MasoomStudents { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MyEmployees1> MyEmployees1s { get; set; } = null!;
        public virtual DbSet<MyEmployees2> MyEmployees2s { get; set; } = null!;
        public virtual DbSet<MyEmployees3> MyEmployees3s { get; set; } = null!;
        public virtual DbSet<NishEmpSs> NishEmpSses { get; set; } = null!;
        public virtual DbSet<NishidEmp> NishidEmps { get; set; } = null!;
        public virtual DbSet<NishidEmployee> NishidEmployees { get; set; } = null!;
        public virtual DbSet<Normal> Normals { get; set; } = null!;
        public virtual DbSet<Operation> Operations { get; set; } = null!;
        public virtual DbSet<Parts2021> Parts2021s { get; set; } = null!;
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
        public virtual DbSet<PaymentDetails1> PaymentDetails1s { get; set; } = null!;
        public virtual DbSet<People1> People1s { get; set; } = null!;
        public virtual DbSet<PerUser> PerUsers { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<PiyushDailyStatus> PiyushDailyStatuses { get; set; } = null!;
        public virtual DbSet<PiyushDocument> PiyushDocuments { get; set; } = null!;
        public virtual DbSet<PiyushProject> PiyushProjects { get; set; } = null!;
        public virtual DbSet<PiyushSkill> PiyushSkills { get; set; } = null!;
        public virtual DbSet<PiyushToDoWork> PiyushToDoWorks { get; set; } = null!;
        public virtual DbSet<PiyushUser> PiyushUsers { get; set; } = null!;
        public virtual DbSet<Prod> Prods { get; set; } = null!;
        public virtual DbSet<Produc> Producs { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<PujaBook> PujaBooks { get; set; } = null!;
        public virtual DbSet<QnA> QnAs { get; set; } = null!;
        public virtual DbSet<Qualification> Qualifications { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Registered> Registereds { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Same> Sames { get; set; } = null!;
        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<SchoolStd> SchoolStds { get; set; } = null!;
        public virtual DbSet<Sf> Sfs { get; set; } = null!;
        public virtual DbSet<SonalDepartment> SonalDepartments { get; set; } = null!;
        public virtual DbSet<SonalRokade> SonalRokades { get; set; } = null!;
        public virtual DbSet<SonalStudent> SonalStudents { get; set; } = null!;
        public virtual DbSet<StateTable> StateTables { get; set; } = null!;
        public virtual DbSet<Std> Stds { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Student1> Student1s { get; set; } = null!;
        public virtual DbSet<Student2> Students1 { get; set; } = null!;
        public virtual DbSet<Student3> Student3s { get; set; } = null!;
        public virtual DbSet<StudentRecord> StudentRecords { get; set; } = null!;
        public virtual DbSet<SuyashAddressDetail> SuyashAddressDetails { get; set; } = null!;
        public virtual DbSet<SuyashAngularEmp> SuyashAngularEmps { get; set; } = null!;
        public virtual DbSet<SuyashCityTable> SuyashCityTables { get; set; } = null!;
        public virtual DbSet<SuyashCoutryTable> SuyashCoutryTables { get; set; } = null!;
        public virtual DbSet<SuyashDatum> SuyashData { get; set; } = null!;
        public virtual DbSet<SuyashEmpDetail> SuyashEmpDetails { get; set; } = null!;
        public virtual DbSet<SuyashEmpdatum> SuyashEmpdata { get; set; } = null!;
        public virtual DbSet<SuyashEmployeeDetail> SuyashEmployeeDetails { get; set; } = null!;
        public virtual DbSet<SuyashInterviewDatum> SuyashInterviewData { get; set; } = null!;
        public virtual DbSet<SuyashLibraryBookdetail> SuyashLibraryBookdetails { get; set; } = null!;
        public virtual DbSet<SuyashLogInOfficeDatum> SuyashLogInOfficeData { get; set; } = null!;
        public virtual DbSet<SuyashNew> SuyashNews { get; set; } = null!;
        public virtual DbSet<SuyashOfficeDatum> SuyashOfficeData { get; set; } = null!;
        public virtual DbSet<SuyashPracticeDatum> SuyashPracticeData { get; set; } = null!;
        public virtual DbSet<SuyashRoleTable> SuyashRoleTables { get; set; } = null!;
        public virtual DbSet<SuyashSchoolRecord> SuyashSchoolRecords { get; set; } = null!;
        public virtual DbSet<SuyashStateTable> SuyashStateTables { get; set; } = null!;
        public virtual DbSet<SuyashStudentDetail> SuyashStudentDetails { get; set; } = null!;
        public virtual DbSet<SuyashTable> SuyashTables { get; set; } = null!;
        public virtual DbSet<SuyashTable1> SuyashTable1s { get; set; } = null!;
        public virtual DbSet<SuyashUserDatum> SuyashUserData { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;
        public virtual DbSet<Table12> Table12s { get; set; } = null!;
        public virtual DbSet<Table21> Table21s { get; set; } = null!;
        public virtual DbSet<Table3> Table3s { get; set; } = null!;
        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblCountry> TblCountries { get; set; } = null!;
        public virtual DbSet<TblDesignation> TblDesignations { get; set; } = null!;
        public virtual DbSet<TblEmployee> TblEmployees { get; set; } = null!;
        public virtual DbSet<TblEmployee1> TblEmployees1 { get; set; } = null!;
        public virtual DbSet<TblPerson> TblPeople { get; set; } = null!;
        public virtual DbSet<TblPersonAddr> TblPersonAddrs { get; set; } = null!;
        public virtual DbSet<TblState> TblStates { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeamSchool> TeamSchools { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Todo> Todos { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<User1> Users1 { get; set; } = null!;
        public virtual DbSet<Userrr> Userrrs { get; set; } = null!;
        public virtual DbSet<Vaccine> Vaccines { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;
        public virtual DbSet<Workers1> Workers1s { get; set; } = null!;
        public virtual DbSet<Workers2> Workers2s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.7.41;Initial Catalog=TrainingDB;Persist Security Info=True;User ID=Sudhanshu27;Password=27.Download;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abc>(entity =>
            {
                entity.ToTable("abc");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Abcs)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_StateTable_Suyash_countryTable");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.PersonId, "IX_Addresses_PersonId");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StreetName).HasMaxLength(200);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<AjaxCrud>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Ajax_Crud");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiaryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Swiftcode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SWIFTCode");
            });

            modelBuilder.Entity<AjaxSonal>(entity =>
            {
                entity.ToTable("AJAX_SONAL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Pincode).HasColumnName("pincode");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => e.SlNo);

                entity.ToTable("Answer");

                entity.Property(e => e.SlNo).HasColumnName("Sl_No");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            });

            modelBuilder.Entity<ApplicationRole>(entity =>
            {
                entity.ToTable("ApplicationRole");

                entity.HasIndex(e => e.NormalizedName, "IX_ApplicationRole_NormalizedName");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("ApplicationUser");

                entity.HasIndex(e => e.NormalizedEmail, "IX_ApplicationUser_NormalizedEmail");

                entity.HasIndex(e => e.NormalizedUserName, "IX_ApplicationUser_NormalizedUserName");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "ApplicationUserRole",
                        l => l.HasOne<ApplicationRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ApplicationUserRole_Role"),
                        r => r.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ApplicationUserRole_User"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__Applicat__AF2760ADB8578FDC");

                            j.ToTable("ApplicationUserRole");
                        });
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Basic>(entity =>
            {
                entity.HasKey(e => e.MyId);
            });

            modelBuilder.Entity<BooKsample>(entity =>
            {
                entity.HasKey(e => e.BookName);

                entity.ToTable("BooKSample");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.LanguageId, "IX_Books_LanguageId");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.LanguageId);
            });

            modelBuilder.Entity<BookGallery>(entity =>
            {
                entity.ToTable("BookGallery");

                entity.HasIndex(e => e.BookId, "IX_BookGallery_BookId");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookGalleries)
                    .HasForeignKey(d => d.BookId);
            });

            modelBuilder.Entity<BookModel>(entity =>
            {
                entity.ToTable("bookModels");
            });

            modelBuilder.Entity<BookStore>(entity =>
            {
                entity.HasKey(e => e.Bid);

                entity.ToTable("BookStore");
            });

            modelBuilder.Entity<BookTable1>(entity =>
            {
                entity.HasKey(e => e.BookName);

                entity.ToTable("BookTable1");

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.Genre).HasMaxLength(50);
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.HasKey(e => e.SlNo);

                entity.ToTable("Candidate");

                entity.Property(e => e.SlNo).HasColumnName("Sl_No");

                entity.Property(e => e.CandidateId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Candidate_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Roles)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cvc).HasColumnName("CVC");
            });

            modelBuilder.Entity<Choice>(entity =>
            {
                entity.ToTable("Choice");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.LastUpdatedon).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            });

            modelBuilder.Entity<CityTable>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("CityTable");

                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeDesignation).HasMaxLength(100);

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.EmployeeSalary).HasMaxLength(20);

                entity.Property(e => e.EmployeeSkills).HasMaxLength(100);
            });

            modelBuilder.Entity<CountryTable>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("CountryTable");

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<CrudAjax>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("CRUD_AJAX");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Semester)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrudFirst>(entity =>
            {
                entity.ToTable("CRUD_FIRST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Custmer>(entity =>
            {
                entity.ToTable("Custmer");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ddvd>(entity =>
            {
                entity.ToTable("ddvd");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentTbl>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__72ABC2CC774AED92");

                entity.ToTable("Department_Tbl");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Id");

                entity.Property(e => e.DeptLocation)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Location");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Name");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.College)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SrId).HasColumnName("SR_Id");

                entity.HasOne(d => d.Sr)
                    .WithMany(p => p.Details)
                    .HasForeignKey(d => d.SrId)
                    .HasConstraintName("FK_Details_Sonal_Rokade");
            });

            modelBuilder.Entity<DroupdownTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DroupdownTable");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<Dummy1>(entity =>
            {
                entity.ToTable("Dummy1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("lName");

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Village)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('INDORE')");
            });

            modelBuilder.Entity<Dummy2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dummy2");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("lName");

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Yoj).HasColumnName("YOJ");
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasIndex(e => e.PersonId, "IX_EmailAddresses_PersonId");

                entity.Property(e => e.EmailAddress1)
                    .HasMaxLength(200)
                    .HasColumnName("EmailAddress");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EmailAddresses)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Emplo>(entity =>
            {
                entity.ToTable("Emplo");

                entity.HasIndex(e => e.DepartmentId, "IX_Emplo_DepartmentId");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Emplos)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYEE_DEPARTMENT");
            });

            modelBuilder.Entity<Employ>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Employ");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeCrud>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Employee_CRUD");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.ToTable("employeeModels");
            });

            modelBuilder.Entity<EmployeeScr>(entity =>
            {
                entity.ToTable("EmployeeScr");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<EmployeeService>(entity =>
            {
                entity.ToTable("Employee_Service");
            });

            modelBuilder.Entity<EmployeeSonal>(entity =>
            {
                entity.ToTable("Employee_Sonal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Employee Table");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeTable1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeTable");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<EmployeeTbl>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__262359ABBF810C27");

                entity.ToTable("Employee_Tbl");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("Emp_Id");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(50)
                    .HasColumnName("Dept_Id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Name");

                entity.Property(e => e.EmpSalary).HasColumnName("Emp_Salary");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.EmployeeTbls)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Employee___Dept___22401542");
            });

            modelBuilder.Entity<EmployeesSs>(entity =>
            {
                entity.ToTable("EmployeesSS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Fname).HasColumnName("fname");

                entity.Property(e => e.Lname).HasColumnName("lname");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FullMarks).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exam1>(entity =>
            {
                entity.ToTable("Exams");

                entity.HasIndex(e => e.GroupsId, "IX_Exams_GroupsId");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Groups)
                    .WithMany(p => p.Exam1s)
                    .HasForeignKey(d => d.GroupsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExamResult>(entity =>
            {
                entity.HasIndex(e => e.ExamsId, "IX_ExamResults_ExamsId");

                entity.HasIndex(e => e.QnAsId, "IX_ExamResults_QnAsId");

                entity.HasIndex(e => e.StudentsId, "IX_ExamResults_StudentsId");

                entity.HasOne(d => d.Exams)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.ExamsId);

                entity.HasOne(d => d.QnAs)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.QnAsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Students)
                    .WithMany(p => p.ExamResults)
                    .HasForeignKey(d => d.StudentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Febr>(entity =>
            {
                entity.ToTable("Febr");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Febrr>(entity =>
            {
                entity.ToTable("Febrr");

                entity.HasIndex(e => e.DepartmentId, "IX_Febrr_DepartmentId");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Febrrs)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMPLOYE_DEPARTMENT");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.UsersId, "IX_Groups_UsersId");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<HariomBookTable>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("HariomBookTable");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.Genre).HasMaxLength(50);
            });

            modelBuilder.Entity<HariomEmployee>(entity =>
            {
                entity.ToTable("Hariom_Employee");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(12);
            });

            modelBuilder.Entity<HariomEmployeeDetail>(entity =>
            {
                entity.ToTable("Hariom_EmployeeDetails");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("Address_");

                entity.Property(e => e.AnnualSalary).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.PfDeduction).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalaryPerMonth).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HariomEmployeeDetails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Hariom_Em__Emplo__7720AD13");
            });

            modelBuilder.Entity<HotelSystem>(entity =>
            {
                entity.HasKey(e => e.CustId);
            });

            modelBuilder.Entity<Information>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Informat__7AD04FF134481AC8");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Office)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");
            });

            modelBuilder.Entity<Management>(entity =>
            {
                entity.ToTable("Management");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Dept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<ManishAjaxCrud>(entity =>
            {
                entity.ToTable("Manish_AjaxCrud");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnrollmentNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishCodeFirst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manish_CodeFirst");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manish_Customer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishDesignPattern>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manish_DesignPattern");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishDropDownList>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Manish_DropDownList");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manish_Employee");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_Item");

                entity.ToTable("Manish_Item");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ManishOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Manish_Order");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Gtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GTotal");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmethod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PMethod");
            });

            modelBuilder.Entity<ManishProduct>(entity =>
            {
                entity.ToTable("Manish_Products");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishSignUp>(entity =>
            {
                entity.ToTable("Manish_SignUp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfirmPasssword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishUploadImage>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("Manish_UploadImage");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Masoom>(entity =>
            {
                entity.ToTable("Masoom");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Masoom1>(entity =>
            {
                entity.ToTable("Masoom1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.School)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasoomBook>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.ToTable("Masoom_Books");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<MasoomDepartment>(entity =>
            {
                entity.ToTable("Masoom_Departments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department).HasMaxLength(50);
            });

            modelBuilder.Entity<MasoomRaja>(entity =>
            {
                entity.ToTable("Masoom_Raja");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasoomStudent>(entity =>
            {
                entity.ToTable("Masoom_Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<MyEmployees1>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__MyEmploy__1299A8610D4A0611");

                entity.ToTable("MyEmployees1");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<MyEmployees2>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__MyEmploy__1299A86168D79497");

                entity.ToTable("MyEmployees2");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<MyEmployees3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MyEmployees3");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
            });

            modelBuilder.Entity<NishEmpSs>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("NishEmpSS");
            });

            modelBuilder.Entity<NishidEmp>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("NishidEmp");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NishidEmployee>(entity =>
            {
                entity.ToTable("NIshid_employees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city")
                    .IsFixedLength();

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .HasColumnName("designation")
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .IsFixedLength();

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Parts2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("parts2021");

                entity.Property(e => e.Column1)
                    .HasMaxLength(250)
                    .HasColumnName("column1");

                entity.Property(e => e.Column2).HasColumnName("column2");
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.HasKey(e => e.MyProperty);

                entity.Property(e => e.CardNumber).HasMaxLength(16);

                entity.Property(e => e.CardOwnerName).HasMaxLength(100);

                entity.Property(e => e.ExpirationDate).HasMaxLength(5);

                entity.Property(e => e.SecurityCode).HasMaxLength(3);
            });

            modelBuilder.Entity<PaymentDetails1>(entity =>
            {
                entity.HasKey(e => e.PaymentDetailId);

                entity.ToTable("PaymentDetails1");

                entity.Property(e => e.CardNumber).HasMaxLength(16);

                entity.Property(e => e.CardOwnerName).HasMaxLength(100);

                entity.Property(e => e.ExpirationDate).HasMaxLength(6);

                entity.Property(e => e.SecurityCode).HasMaxLength(3);
            });

            modelBuilder.Entity<People1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("People1");

                entity.Property(e => e.Fname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");
            });

            modelBuilder.Entity<PerUser>(entity =>
            {
                entity.ToTable("PerUser");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConformPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<PiyushDailyStatus>(entity =>
            {
                entity.ToTable("Piyush_DailyStatus");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Modify_By");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modify_Date");

                entity.Property(e => e.Name).HasMaxLength(70);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PiyushDailyStatuses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Piyush_DailyStatus_Piyush_User");
            });

            modelBuilder.Entity<PiyushDocument>(entity =>
            {
                entity.ToTable("Piyush_documents");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Modify_By");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modify_Date");

                entity.Property(e => e.Name).HasMaxLength(70);

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .HasColumnName("path");

                entity.Property(e => e.ProjectId).HasColumnName("Project_Id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PiyushDocuments)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Piyush_documents_Piyush_projects");
            });

            modelBuilder.Entity<PiyushProject>(entity =>
            {
                entity.ToTable("Piyush_projects");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Modify_By");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modify_Date");

                entity.Property(e => e.Name).HasMaxLength(70);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PiyushProjects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Piyush_projects_Piyush_User");
            });

            modelBuilder.Entity<PiyushSkill>(entity =>
            {
                entity.ToTable("Piyush_skills");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Modify_By");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modify_Date");

                entity.Property(e => e.Proficiancy)
                    .HasMaxLength(15)
                    .HasColumnName("proficiancy");

                entity.Property(e => e.Skill)
                    .HasMaxLength(70)
                    .HasColumnName("skill");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PiyushSkills)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Piyush_skills_Piyush_User");
            });

            modelBuilder.Entity<PiyushToDoWork>(entity =>
            {
                entity.ToTable("Piyush_ToDoWork");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("actualEnd_Date");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("actualStart_Date");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Modify_By");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modify_Date");

                entity.Property(e => e.Name).HasMaxLength(70);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PiyushToDoWorks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Piyush_ToDoWork_Piyush_User");
            });

            modelBuilder.Entity<PiyushUser>(entity =>
            {
                entity.ToTable("Piyush_User");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_Name");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining_Date");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_Name");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_Date");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Prod>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_dbo.Prod");

                entity.ToTable("Prod");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Produc>(entity =>
            {
                entity.ToTable("produc");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PujaBook>(entity =>
            {
                entity.ToTable("PujaBook");

                entity.Property(e => e.Author).HasMaxLength(50);

                entity.Property(e => e.BookName).HasMaxLength(50);

                entity.Property(e => e.Genre).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QnA>(entity =>
            {
                entity.HasIndex(e => e.ExamsId, "IX_QnAs_ExamsId");

                entity.Property(e => e.Option1).HasMaxLength(100);

                entity.Property(e => e.Option2).HasMaxLength(100);

                entity.Property(e => e.Option3).HasMaxLength(100);

                entity.Property(e => e.Option4).HasMaxLength(100);

                entity.HasOne(d => d.Exams)
                    .WithMany(p => p.QnAs)
                    .HasForeignKey(d => d.ExamsId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("Qualification");

                entity.Property(e => e.Degree)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Registered>(entity =>
            {
                entity.ToTable("Registered");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Contact)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => e.SlNo);

                entity.ToTable("Result");

                entity.Property(e => e.SlNo).HasColumnName("Sl_No");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.SelectedOptionId).HasColumnName("SelectedOptionID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");
            });

            modelBuilder.Entity<Same>(entity =>
            {
                entity.HasKey(e => e.MyId);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.Mobnumber).HasColumnName("mobnumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SchoolStd>(entity =>
            {
                entity.HasKey(e => e.StdId);

                entity.ToTable("SchoolStd");

                entity.Property(e => e.Course)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sf>(entity =>
            {
                entity.ToTable("sf");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Sfs)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_CityTable_Suyash_StateTable");
            });

            modelBuilder.Entity<SonalDepartment>(entity =>
            {
                entity.ToTable("Sonal_Department");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Department).HasMaxLength(50);
            });

            modelBuilder.Entity<SonalRokade>(entity =>
            {
                entity.ToTable("Sonal_Rokade");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonalStudent>(entity =>
            {
                entity.ToTable("Sonal_Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StateTable>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("StateTable");

                entity.Property(e => e.StateName).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("age");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Standard).HasColumnName("standard");
            });

            modelBuilder.Entity<Student1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student1");

                entity.Property(e => e.Address)
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student2>(entity =>
            {
                entity.ToTable("Students");

                entity.HasIndex(e => e.GroupsId, "IX_Students_GroupsId");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .HasColumnName("contact");

                entity.Property(e => e.CvfileName)
                    .HasMaxLength(250)
                    .HasColumnName("CVFileName");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PicturefileName).HasMaxLength(250);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Groups)
                    .WithMany(p => p.Student2s)
                    .HasForeignKey(d => d.GroupsId);
            });

            modelBuilder.Entity<Student3>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.ToTable("Student3");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Branch)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.College)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Age).HasMaxLength(12);

                entity.Property(e => e.MobileNo).HasMaxLength(12);

                entity.Property(e => e.Name).HasMaxLength(12);
            });

            modelBuilder.Entity<SuyashAddressDetail>(entity =>
            {
                entity.ToTable("Suyash_addressDetails");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuyashAngularEmp>(entity =>
            {
                entity.ToTable("Suyash_AngularEmp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<SuyashCityTable>(entity =>
            {
                entity.HasKey(e => e.CtyId)
                    .HasName("PK_Suyash_CityTable_1");

                entity.ToTable("Suyash_CityTable");

                entity.Property(e => e.CtyId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sid).HasColumnName("SId");

                entity.HasOne(d => d.SidNavigation)
                    .WithMany(p => p.SuyashCityTables)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_CityTable_Suyash_StateTable1");
            });

            modelBuilder.Entity<SuyashCoutryTable>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("Suyash_coutryTable");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CId");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SuyashDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Suyash_Data");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SuyashEmpDetail>(entity =>
            {
                entity.ToTable("Suyash_empDetails");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.GenderId).HasColumnName("genderId");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<SuyashEmpdatum>(entity =>
            {
                entity.ToTable("Suyash_empdata");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<SuyashEmployeeDetail>(entity =>
            {
                entity.ToTable("Suyash_employeeDetails");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.SuyashEmployeeDetails)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_employeeDetails_Suyash_addressDetails");
            });

            modelBuilder.Entity<SuyashInterviewDatum>(entity =>
            {
                entity.ToTable("Suyash_interviewData");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Resume)
                    .HasMaxLength(300)
                    .HasColumnName("resume");
            });

            modelBuilder.Entity<SuyashLibraryBookdetail>(entity =>
            {
                entity.ToTable("Suyash_LibraryBookdetails");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .HasColumnName("author");

                entity.Property(e => e.BookName)
                    .HasMaxLength(50)
                    .HasColumnName("bookName");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .HasColumnName("genre");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ReleaseDate)
                    .HasMaxLength(50)
                    .HasColumnName("releaseDate");
            });

            modelBuilder.Entity<SuyashLogInOfficeDatum>(entity =>
            {
                entity.ToTable("Suyash_logInOfficeData");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<SuyashNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SuyashNew");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("lName");

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Village).HasMaxLength(50);
            });

            modelBuilder.Entity<SuyashOfficeDatum>(entity =>
            {
                entity.ToTable("Suyash_officeData");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SuyashPracticeDatum>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__SuyashPr__AFB3EC0D71FCF601");

                entity.HasIndex(e => e.EmpPhoneNumber, "UQ__SuyashPr__757CD766D4326FAF")
                    .IsUnique();

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("empId");

                entity.Property(e => e.EmpDesignation)
                    .HasMaxLength(50)
                    .HasColumnName("empDesignation");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpPhoneNumber)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("empPhoneNumber");
            });

            modelBuilder.Entity<SuyashRoleTable>(entity =>
            {
                entity.ToTable("Suyash_roleTable");

                entity.Property(e => e.Roles).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SuyashRoleTables)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_roleTable_Suyash_logInOfficeData");
            });

            modelBuilder.Entity<SuyashSchoolRecord>(entity =>
            {
                entity.ToTable("Suyash_schoolRecord");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<SuyashStateTable>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK_Suyash_StateTable_1");

                entity.ToTable("Suyash_StateTable");

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("SId");

                entity.Property(e => e.Cid).HasColumnName("CId");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.SuyashStateTables)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suyash_StateTable_Suyash_coutryTable1");
            });

            modelBuilder.Entity<SuyashStudentDetail>(entity =>
            {
                entity.ToTable("Suyash_studentDetails");

                entity.Property(e => e.Class)
                    .HasMaxLength(50)
                    .HasColumnName("class");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.RollNumber).HasColumnName("rollNumber");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<SuyashTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SuyashTable");

                entity.Property(e => e.Class).HasMaxLength(30);

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("fName");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SuyashTable1>(entity =>
            {
                entity.ToTable("SuyashTable1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(30);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SuyashUserDatum>(entity =>
            {
                entity.ToTable("Suyash_userData");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Table12>(entity =>
            {
                entity.ToTable("Table_12");

                entity.Property(e => e.Designation).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Table21>(entity =>
            {
                entity.ToTable("Table_21");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Table3>(entity =>
            {
                entity.ToTable("Table3");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tblCity");

                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("TblCountry");

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDesignation>(entity =>
            {
                entity.ToTable("TblDesignation");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tbl_Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployee1>(entity =>
            {
                entity.ToTable("TblEmployee");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(150);
            });

            modelBuilder.Entity<TblPerson>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_Person");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.AddressNavigation)
                    .WithMany(p => p.TblPeople)
                    .HasForeignKey(d => d.Address)
                    .HasConstraintName("FK_tbl_Person_tbl_Person");
            });

            modelBuilder.Entity<TblPersonAddr>(entity =>
            {
                entity.ToTable("tbl_PersonAddr");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Details)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tblState");

                entity.Property(e => e.StateName).HasMaxLength(50);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Teacher");

                entity.Property(e => e.Address1)
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeamSchool>(entity =>
            {
                entity.ToTable("team_school");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Salary)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Todos_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Todos)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.Property(e => e.AccountNumber).HasMaxLength(12);

                entity.Property(e => e.BankName).HasMaxLength(12);

                entity.Property(e => e.BeneficiaryId).HasMaxLength(12);

                entity.Property(e => e.Date).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.GenderId).HasDefaultValueSql("(N'')");

                entity.Property(e => e.SwiftCode).HasMaxLength(12);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(25);

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__User__3214EC076DF1E77F");

                entity.ToTable("User");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.CreateOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.ToTable("Users");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Userrr>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Userrr");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NoOfVaccinationCentre).HasColumnName("No_of_vaccination_centre");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Workerid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Workers1>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__Workers1__0761845E6BA8D2ED");

                entity.ToTable("Workers1");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Workers2>(entity =>
            {
                entity.HasKey(e => e.Workerid)
                    .HasName("PK__Workers2__0761845ECC8A45F0");

                entity.ToTable("Workers2");

                entity.Property(e => e.Workerid).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
