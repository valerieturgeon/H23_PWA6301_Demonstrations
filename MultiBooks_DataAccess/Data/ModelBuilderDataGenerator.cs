using Microsoft.EntityFrameworkCore;
using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MultiBooks_DataAccess.Data
{
   public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Données pour Subject
            builder.Entity<Subject>().HasData(new Subject() { Id = 1, Name = "Policier"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 2, Name = "Drame"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 3, Name = "Mystère" });
            builder.Entity<Subject>().HasData(new Subject() { Id = 4, Name = "Ressources humaines"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 5, Name = "Romance"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 6, Name = "Fantastique"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 7, Name = "Droits"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 8, Name = "Thriller"});
            builder.Entity<Subject>().HasData(new Subject() { Id = 9, Name = "Biographie"});
            #endregion


            #region Données pour Publisher
            builder.Entity<Publisher>().HasData(new Publisher() { Id = 1, Name = "ADA", Speciality = "Jeunesse, croissance personnelle", PublisherSite = "www.ada-inc.com" });
            builder.Entity<Publisher>().HasData(new Publisher() { Id = 2, Name = "Chenelière", Speciality = "Éducation, collégial, universitaire", PublisherSite = "www.cheneliere.ca" });
            builder.Entity<Publisher>().HasData(new Publisher() { Id = 3, Name = "Livre de poche", Speciality = "Drame, policier, biographie", PublisherSite = "www.livredepoche.com" });
            #endregion


            #region Données pour Author
            builder.Entity<Author>().HasData(new Author() { Id = 1, FirstName = "Elie", LastName = "Hanson", AuthorDetail_Id = 1, MentorId = null });
            builder.Entity<Author>().HasData(new Author() { Id = 2, FirstName = "Vincent", LastName = "Fournier-Boisvert", AuthorDetail_Id = 2, MentorId = 1 });
            builder.Entity<Author>().HasData(new Author() { Id = 3, FirstName = "Guy", LastName = "Bergeron", AuthorDetail_Id = 3, MentorId = null });
            builder.Entity<Author>().HasData(new Author() { Id = 4, FirstName = "Kim", LastName = "Messier", AuthorDetail_Id = null, MentorId = 7 });
            builder.Entity<Author>().HasData(new Author() { Id = 5, FirstName = "Bernard", LastName = "Turgeon", AuthorDetail_Id = null, MentorId = null });
            builder.Entity<Author>().HasData(new Author() { Id = 6, FirstName = "Dominic", LastName = "Lamaute", AuthorDetail_Id = null, MentorId = 5 });
            builder.Entity<Author>().HasData(new Author() { Id = 7, FirstName = "Agatha", LastName = "Christie", AuthorDetail_Id = null, MentorId = null});
            #endregion


            #region Données pour AuthorDetail
            builder.Entity<AuthorDetail>().HasData(new AuthorDetail() { Id = 1, Biography = "Né au Caire, diplômé en traduction et en littérature française, Elie Hanson est un globe-trotter qui a vécu sur quatre continents, avant de finalement s’installer à Montréal. Il a reçu la Médaille du jubilé de diamant de la reine Elizabeth II avec la première édition de son roman Le carnet maudit. Mission Arctik est son cinquième roman.", Photo = "" });
            builder.Entity<AuthorDetail>().HasData(new AuthorDetail() { Id = 2, Biography = "Originaire de St-Hyacinthe, Vincent Fournier-Boisvert est musicien et enseignant. Il a joué pour Cavalia et dans des groupes de trad, de free jazz et de black métal. Le puits est son premier roman.", Photo = "" });
            builder.Entity<AuthorDetail>().HasData(new AuthorDetail() { Id = 3, Biography = "Conseiller informatique résidant à Québec, Guy Bergeron a connu un succès considérable avec La trilogie de l’Orbe et sa fresque L’Héritière de Ferrolia. Après Coeur de Givre et Les âmes perdues, deux récits de la série Légendes d’Arménis, il a adapté à sa manière les grands classiques homériques avec Fils de Troie et Le retour d’Ulysse. Avec Évelyne est morte, il change de registre littéraire et signe un polar fantastique impeccable confirmant l’étendue de son talent.", Photo = "" });
            #endregion


            #region Données pour Book
            builder.Entity<Book>().HasData(new Book() { Id = 1, Title = "Mission Arctik", ISBN = "9782898190063", Price = 19.95, Subject_Id = 8, Publisher_Id = 1, PublishedDate = new DateTime(2020, 01, 15, 00, 00, 00)  });
            builder.Entity<Book>().HasData(new Book() { Id = 2, Title = "Le puit", ISBN = "9782898190001", Price = 19.95, Subject_Id = 1, Publisher_Id = 1, PublishedDate = new DateTime(2020, 01, 15, 00, 00, 00)  });
            builder.Entity<Book>().HasData(new Book() { Id = 3, Title = "Menvatts-valse macabre", ISBN = "9782898032752", Price = 19.95, Subject_Id = 8, Publisher_Id = 1, PublishedDate = new DateTime(2019, 09, 15, 00, 00, 00) });
            builder.Entity<Book>().HasData(new Book() { Id = 4, Title = "Menvatts-Uncia", ISBN = "9782898032813", Price = 19.95, Subject_Id = 8, Publisher_Id = 1, PublishedDate = new DateTime(2021, 09, 01, 00, 00, 00)  });
            builder.Entity<Book>().HasData(new Book() { Id = 5, Title = "De la supervision à la gestion des ressources humaines", ISBN = "9782765045281", Price = 61.95, Subject_Id = 4, Publisher_Id = 2, PublishedDate = new DateTime(2017, 06, 15, 00, 00, 00)  });
            builder.Entity<Book>().HasData(new Book() { Id = 6, Title = "Le management - À l ère des technologies de l information", ISBN = "9782765051527", Price = 59.95, Subject_Id = 4, Publisher_Id = 2, PublishedDate = new DateTime(2016, 06, 15, 00, 00, 00) });
            builder.Entity<Book>().HasData(new Book() { Id = 7, Title = "Affaires de styles", ISBN = "9782253167129", Price = 22, Subject_Id = 1, Publisher_Id = 3, PublishedDate = new DateTime(1920, 03, 01, 00, 00, 00) });
            builder.Entity<Book>().HasData(new Book() { Id = 8, Title = "Témoins muets", ISBN = "9782253167130", Price = 24, Subject_Id = 1, Publisher_Id = 3, PublishedDate = new DateTime(1937, 02, 14, 00, 00, 00) });
            builder.Entity<Book>().HasData(new Book() { Id = 9, Title = "Le Noël d Hercule Poirot", ISBN = "9782253177753", Price = 18.55, Subject_Id = 1, Publisher_Id = 3, PublishedDate = new DateTime(1938, 09, 02, 00, 00, 00) });
            #endregion


            #region Données pour AuthorBook
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 1, Author_Id = 1 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 2, Author_Id = 2 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 3, Author_Id = 3 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 4, Author_Id = 4 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 5, Author_Id = 5 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 6, Author_Id = 5 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 5, Author_Id = 6 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 6, Author_Id = 6 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 7, Author_Id = 7 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 8, Author_Id = 7 });
            builder.Entity<AuthorBook>().HasData(new AuthorBook() { Book_Id = 9, Author_Id = 7 });
            #endregion

        }
    }
}
