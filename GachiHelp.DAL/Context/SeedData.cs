using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace GachiHelp.DAL.Context
{
    internal static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Login = "admin",
                    Email = "admin@gachi.com",
                    Role = Role.Admin,
                    PasswordHash = HashPassword("admin"),
                    Surname = "Зубенко",
                    Name = "Михайло",
                    Patronym = "Петрович"
                },
                new User
                {
                    Id = 2,
                    Login = "tetiana",
                    Email = "tetiana@gachi.com",
                    Role = Role.Worker,
                    PasswordHash = HashPassword("tetiana"),
                    Surname = "Дякун",
                    Name = "Тетяна",
                    Patronym = "Ярославівна"
                },
                new User
                {
                    Id = 3,
                    Login = "jamal",
                    Email = "jamal@gachi.com",
                    Role = Role.Worker,
                    PasswordHash = HashPassword("jamal"),
                    Surname = "Сталоне",
                    Name = "Джамал",
                    Patronym = "Сільвестрович"
                },
                new User
                {
                    Id = 4,
                    Login = "mykola",
                    Email = "mykola@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("mykola"),
                    Surname = "Гірний",
                    Name = "Микола",
                    Patronym = "Олегович"
                },
                new User
                {
                    Id = 5,
                    Login = "ivan",
                    Email = "ivan@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("ivan"),
                    Surname = "Янович",
                    Name = "Іван",
                    Patronym = "Ігорович"
                },
                new User
                {
                    Id = 6,
                    Login = "olexandr",
                    Email = "olexandr@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("olexandr"),
                    Surname = "Білан",
                    Name = "Олександр",
                    Patronym = "Юрійович"
                },
                new User
                {
                    Id = 7,
                    Login = "vitaliy",
                    Email = "vitaliy@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("vitaliy"),
                    Surname = "Кіндрат",
                    Name = "Віталій",
                    Patronym = "Олегович"
                },
                new User
                {
                    Id = 8,
                    Login = "F91F0532-5205-6D4B-9D44-B0B5ED664182",
                    Email = "F91F0532-5205-6D4B-9D44-B0B5ED664182@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Теплицький",
                    Name = "Костянтин ",
                    Patronym = "Артемович"
                },
                new User
                {
                    Id = 9,
                    Login = "9BCBE1F9-10F8-5D12-2A8C-9B7F6D117881",
                    Email = "9BCBE1F9-10F8-5D12-2A8C-9B7F6D117881@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Троцюк",
                    Name = "Федір ",
                    Patronym = "Сарматович"
                },
                new User
                {
                    Id = 10,
                    Login = "8EEC0E45-437E-0E5F-A544-6A17581090CF",
                    Email = "8EEC0E45-437E-0E5F-A544-6A17581090CF@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Найдьонов",
                    Name = "Далібор ",
                    Patronym = "Тарасович"
                },
                new User
                {
                    Id = 11,
                    Login = "6048AC32-A77E-4E8A-61F0-32DC6A83053C",
                    Email = "6048AC32-A77E-4E8A-61F0-32DC6A83053C@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Стахів",
                    Name = "Бративой ",
                    Patronym = "Фролович"
                },
                new User
                {
                    Id = 12,
                    Login = "8C07AE86-0FB2-5733-448B-5B8E2F755EC5",
                    Email = "8C07AE86-0FB2-5733-448B-5B8E2F755EC5@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Фешовець",
                    Name = "Аскольд ",
                    Patronym = "Тихонович"
                },
                new User
                {
                    Id = 13,
                    Login = "2D3979D2-6209-0580-2A38-A210A0643804",
                    Email = "2D3979D2-6209-0580-2A38-A210A0643804@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гуляницький",
                    Name = "Вукол ",
                    Patronym = "Тимурович"
                },
                new User
                {
                    Id = 14,
                    Login = "8A48AEF7-51C1-6D83-A312-93E1DDCF0450",
                    Email = "8A48AEF7-51C1-6D83-A312-93E1DDCF0450@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Малишко",
                    Name = "Цвітан ",
                    Patronym = "Зорянович"
                },
                new User
                {
                    Id = 15,
                    Login = "1674085B-2D68-9D72-9310-F9F493120FDF",
                    Email = "1674085B-2D68-9D72-9310-F9F493120FDF@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Плішка",
                    Name = "Щастислав ",
                    Patronym = "Світанович"
                },
                new User
                {
                    Id = 16,
                    Login = "12872033-7D35-0B9F-12A4-C0EC32159379",
                    Email = "12872033-7D35-0B9F-12A4-C0EC32159379@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Косар",
                    Name = "Доброслав ",
                    Patronym = "Любомирович"
                },
                new User
                {
                    Id = 17,
                    Login = "7E086B8B-9EE3-69F5-0E39-ABCAD39588D0",
                    Email = "7E086B8B-9EE3-69F5-0E39-ABCAD39588D0@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ангелович",
                    Name = "Євлампій ",
                    Patronym = "Вадимович"
                },
                new User
                {
                    Id = 18,
                    Login = "5DD9E18B-6DCB-86FB-5142-7C33B37A0B65",
                    Email = "5DD9E18B-6DCB-86FB-5142-7C33B37A0B65@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Степченко",
                    Name = "Чара ",
                    Patronym = "Світанович"
                },
                new User
                {
                    Id = 19,
                    Login = "80BE8251-9489-51B8-3414-CD5FC70A477D",
                    Email = "80BE8251-9489-51B8-3414-CD5FC70A477D@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Герасимець",
                    Name = "Юхим ",
                    Patronym = "Макарович"
                },
                new User
                {
                    Id = 20,
                    Login = "F59689BA-56C5-0B92-7896-D68837926157",
                    Email = "F59689BA-56C5-0B92-7896-D68837926157@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Рябоконь",
                    Name = "Любослав ",
                    Patronym = "Азарович"
                },
                new User
                {
                    Id = 21,
                    Login = "A944A5A3-3E6C-2B8B-8CBC-A4D1DAEF4DCF",
                    Email = "A944A5A3-3E6C-2B8B-8CBC-A4D1DAEF4DCF@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Біленко",
                    Name = "Юхим ",
                    Patronym = "Юліанович"
                },
                new User
                {
                    Id = 22,
                    Login = "49AF543C-1068-7AFE-1268-0877F91B541B",
                    Email = "49AF543C-1068-7AFE-1268-0877F91B541B@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Семеніхін",
                    Name = "Щастибог ",
                    Patronym = "Вітанович"
                },
                new User
                {
                    Id = 23,
                    Login = "DEDFD2F7-48CA-5E1C-5B79-29B8073518C9",
                    Email = "DEDFD2F7-48CA-5E1C-5B79-29B8073518C9@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Собко",
                    Name = "Йонас ",
                    Patronym = "Тихонович"
                },
                new User
                {
                    Id = 24,
                    Login = "97DDDEC4-7F0F-0BAA-A2CD-7F211ED7A1A1",
                    Email = "97DDDEC4-7F0F-0BAA-A2CD-7F211ED7A1A1@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гопкало",
                    Name = "Хвала ",
                    Patronym = "Адріанович"
                },
                new User
                {
                    Id = 25,
                    Login = "BD93B82F-678B-A39D-4E65-3B9072546594",
                    Email = "BD93B82F-678B-A39D-4E65-3B9072546594@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кравчик",
                    Name = "Троян ",
                    Patronym = "Сарматович"
                },
                new User
                {
                    Id = 26,
                    Login = "D0B7A913-1475-8EE6-1895-D4A0B0A85EB0",
                    Email = "D0B7A913-1475-8EE6-1895-D4A0B0A85EB0@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ясинський",
                    Name = "Сергій ",
                    Patronym = "Найденович"
                },
                new User
                {
                    Id = 27,
                    Login = "9EF2DDF3-022A-071D-6E9B-24AA2B0F6824",
                    Email = "9EF2DDF3-022A-071D-6E9B-24AA2B0F6824@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Андрущенко",
                    Name = "Йомер ",
                    Patronym = "Арсенович"
                },
                new User
                {
                    Id = 28,
                    Login = "14CEC370-96FA-1698-5639-91FE3E9C18F9",
                    Email = "14CEC370-96FA-1698-5639-91FE3E9C18F9@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Авратинський",
                    Name = "Уличан ",
                    Patronym = "Ярославович"
                },
                new User
                {
                    Id = 29,
                    Login = "010CD3CA-4CD0-0501-8793-4E91C54E877E",
                    Email = "010CD3CA-4CD0-0501-8793-4E91C54E877E@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Євтушенко",
                    Name = "Еразм ",
                    Patronym = "Жданович"
                },
                new User
                {
                    Id = 30,
                    Login = "83791907-0C0C-3525-4716-56458101139B",
                    Email = "83791907-0C0C-3525-4716-56458101139B@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ємельяненко",
                    Name = "Йосеф ",
                    Patronym = "Милославович"
                },
                new User
                {
                    Id = 31,
                    Login = "B79D280F-49BF-32E7-6BF1-C664BF1C5522",
                    Email = "B79D280F-49BF-32E7-6BF1-C664BF1C5522@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Невінчаний",
                    Name = "Артем ",
                    Patronym = "Володимирович"
                },
                new User
                {
                    Id = 32,
                    Login = "89747AA0-3698-44E9-68D0-3499B0142687",
                    Email = "89747AA0-3698-44E9-68D0-3499B0142687@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Чехівський",
                    Name = "Братислав ",
                    Patronym = "Богданович"
                },
                new User
                {
                    Id = 33,
                    Login = "31949148-2468-32F8-21B7-F088FD1991A4",
                    Email = "31949148-2468-32F8-21B7-F088FD1991A4@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Медведюк",
                    Name = "Яртур ",
                    Patronym = "Юліанович"
                },
                new User
                {
                    Id = 34,
                    Login = "6901625F-A02D-6095-3C87-C917F7917680",
                    Email = "6901625F-A02D-6095-3C87-C917F7917680@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кузьма",
                    Name = "Осемрит ",
                    Patronym = "Яромирович"
                },
                new User
                {
                    Id = 35,
                    Login = "1D670A89-1520-0B85-57BB-42FAE98A9FDD",
                    Email = "1D670A89-1520-0B85-57BB-42FAE98A9FDD@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Підгаєцький",
                    Name = "Федір ",
                    Patronym = "Левович"
                },
                new User
                {
                    Id = 36,
                    Login = "C3071F09-2011-098B-909D-D44B6D5E38F6",
                    Email = "C3071F09-2011-098B-909D-D44B6D5E38F6@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Пашко",
                    Name = "Родослав ",
                    Patronym = "Федорович"
                },
                new User
                {
                    Id = 37,
                    Login = "7ACD243A-8B73-85AD-3181-5C1EED002DAA",
                    Email = "7ACD243A-8B73-85AD-3181-5C1EED002DAA@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Канішевський",
                    Name = "Живослав ",
                    Patronym = "Северинович"
                },
                new User
                {
                    Id = 38,
                    Login = "72547C4E-9C3C-966E-654A-14CFE7805294",
                    Email = "72547C4E-9C3C-966E-654A-14CFE7805294@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Арсенич",
                    Name = "Миробог ",
                    Patronym = "Тихонович"
                },
                new User
                {
                    Id = 39,
                    Login = "2F9054BA-570A-109A-5C1D-BF1EF5554C41",
                    Email = "2F9054BA-570A-109A-5C1D-BF1EF5554C41@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Корольчук",
                    Name = "Драган ",
                    Patronym = "Любомирович"
                },
                new User
                {
                    Id = 40,
                    Login = "659EC371-7A57-910D-9D99-DE95E1433E19",
                    Email = "659EC371-7A57-910D-9D99-DE95E1433E19@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Полотай",
                    Name = "Хотян ",
                    Patronym = "Мстиславович"
                },
                new User
                {
                    Id = 41,
                    Login = "F6372D04-740C-1F6B-43EF-A1C5440A41CC",
                    Email = "F6372D04-740C-1F6B-43EF-A1C5440A41CC@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Могиленко",
                    Name = "Життєлюб ",
                    Patronym = "Остапович"
                },
                new User
                {
                    Id = 42,
                    Login = "3E20B44A-1E80-4BDA-725A-6BE50C069549",
                    Email = "3E20B44A-1E80-4BDA-725A-6BE50C069549@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Пащук",
                    Name = "Анісій ",
                    Patronym = "Ростиславович"
                },
                new User
                {
                    Id = 43,
                    Login = "8414ED38-1EC0-883E-25BB-E14100613A9C",
                    Email = "8414ED38-1EC0-883E-25BB-E14100613A9C@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Щурат",
                    Name = "Йомер ",
                    Patronym = "Антонович"
                },
                new User
                {
                    Id = 44,
                    Login = "2F786E5F-3D2F-5D67-5005-7E2573EFA509",
                    Email = "2F786E5F-3D2F-5D67-5005-7E2573EFA509@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Роднянський",
                    Name = "Микита ",
                    Patronym = "Федорович"
                },
                new User
                {
                    Id = 45,
                    Login = "FF8DF46E-2C26-0C72-7FCB-3AAAD2426C11",
                    Email = "FF8DF46E-2C26-0C72-7FCB-3AAAD2426C11@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Хмелецький",
                    Name = "Щедрогост ",
                    Patronym = "Макарович"
                },
                new User
                {
                    Id = 46,
                    Login = "E4D2BCD0-9C9F-9F10-359E-F4ADCFE20652",
                    Email = "E4D2BCD0-9C9F-9F10-359E-F4ADCFE20652@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Авдієвський",
                    Name = "Данко ",
                    Patronym = "Августинович"
                },
                new User
                {
                    Id = 47,
                    Login = "1D747F30-52F4-1EA1-0D6C-766458B68580",
                    Email = "1D747F30-52F4-1EA1-0D6C-766458B68580@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Калениченко",
                    Name = "Хранимир ",
                    Patronym = "Орестович"
                },
                new User
                {
                    Id = 48,
                    Login = "11311BAB-012E-220F-4FF9-82A3703B2B2B",
                    Email = "11311BAB-012E-220F-4FF9-82A3703B2B2B@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Оніщенко",
                    Name = "Корнелій ",
                    Patronym = "Вадимович"
                },
                new User
                {
                    Id = 49,
                    Login = "AE0FDEC6-629A-67B7-0E32-B30B3B818203",
                    Email = "AE0FDEC6-629A-67B7-0E32-B30B3B818203@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Батенко",
                    Name = "Хранимир ",
                    Patronym = "Чеславович"
                },
                new User
                {
                    Id = 50,
                    Login = "9CB37CF8-365D-0E5B-7B60-0C5C5F4B0227",
                    Email = "9CB37CF8-365D-0E5B-7B60-0C5C5F4B0227@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Зазуляк",
                    Name = "Радан ",
                    Patronym = "Юліанович"
                },
                new User
                {
                    Id = 51,
                    Login = "D156F22F-66F4-01C0-0BF0-887E2C574A13",
                    Email = "D156F22F-66F4-01C0-0BF0-887E2C574A13@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Крамськой",
                    Name = "Дорофій ",
                    Patronym = "Юхимович"
                },
                new User
                {
                    Id = 52,
                    Login = "BB41BAAF-78FA-295B-4584-3470A1F14BBF",
                    Email = "BB41BAAF-78FA-295B-4584-3470A1F14BBF@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Громики",
                    Name = "Щедрогост ",
                    Patronym = "Леонідович"
                },
                new User
                {
                    Id = 53,
                    Login = "2B92A1B7-6AC4-6587-4EE1-C62620DC04CD",
                    Email = "2B92A1B7-6AC4-6587-4EE1-C62620DC04CD@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кайда",
                    Name = "Ничипір ",
                    Patronym = "Никодимович"
                },
                new User
                {
                    Id = 54,
                    Login = "B5A7111A-375B-8633-033F-0CE94AD283C7",
                    Email = "B5A7111A-375B-8633-033F-0CE94AD283C7@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Денисенко",
                    Name = "Еміль ",
                    Patronym = "Пилипович"
                },
                new User
                {
                    Id = 55,
                    Login = "CFF82BCF-63DA-9799-6638-A9C3077AA70F",
                    Email = "CFF82BCF-63DA-9799-6638-A9C3077AA70F@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Манзій",
                    Name = "Юліан ",
                    Patronym = "Левович"
                },
                new User
                {
                    Id = 56,
                    Login = "A4CA4802-348A-65E2-2B81-8E87F5E51FFB",
                    Email = "A4CA4802-348A-65E2-2B81-8E87F5E51FFB@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Марченко",
                    Name = "Адріан ",
                    Patronym = "Зорянович"
                },
                new User
                {
                    Id = 57,
                    Login = "5B057869-59E5-777D-9EEA-C517C7B31C7D",
                    Email = "5B057869-59E5-777D-9EEA-C517C7B31C7D@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Витвицький",
                    Name = "Києслав ",
                    Patronym = "Йосипович"
                },
                new User
                {
                    Id = 58,
                    Login = "47B22C1A-0F6C-8C7D-937F-A7841EA55DC7",
                    Email = "47B22C1A-0F6C-8C7D-937F-A7841EA55DC7@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Петрусь",
                    Name = "Єгор ",
                    Patronym = "Устимович"
                },
                new User
                {
                    Id = 59,
                    Login = "5AF954E2-2190-09A9-943C-4BF38BE8814A",
                    Email = "5AF954E2-2190-09A9-943C-4BF38BE8814A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Галаса",
                    Name = "Добривод ",
                    Patronym = "Тимурович"
                },
                new User
                {
                    Id = 60,
                    Login = "3B90E239-72E4-7106-9B81-3A79A1044C55",
                    Email = "3B90E239-72E4-7106-9B81-3A79A1044C55@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Прудіус",
                    Name = "Колодій ",
                    Patronym = "Драганович"
                },
                new User
                {
                    Id = 61,
                    Login = "665709BC-4BDB-0CAA-956D-34B529070270",
                    Email = "665709BC-4BDB-0CAA-956D-34B529070270@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Канішевський",
                    Name = "Наслав ",
                    Patronym = "Адамович"
                },
                new User
                {
                    Id = 62,
                    Login = "50965BC6-94FF-78DE-5D8F-9403FBE73741",
                    Email = "50965BC6-94FF-78DE-5D8F-9403FBE73741@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гриньків",
                    Name = "Панас ",
                    Patronym = "Северинович"
                },
                new User
                {
                    Id = 63,
                    Login = "5D68CD80-0B90-1320-2290-84ED50AB0FF7",
                    Email = "5D68CD80-0B90-1320-2290-84ED50AB0FF7@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Костюк",
                    Name = "Щедрогост ",
                    Patronym = "Тихонович"
                },
                new User
                {
                    Id = 64,
                    Login = "25D65028-2C8D-2BDE-6CE0-B7F48F022D31",
                    Email = "25D65028-2C8D-2BDE-6CE0-B7F48F022D31@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ткач",
                    Name = "Недан ",
                    Patronym = "Сарматович"
                },
                new User
                {
                    Id = 65,
                    Login = "A8A17287-0221-7CA2-9C33-E1590B1E1364",
                    Email = "A8A17287-0221-7CA2-9C33-E1590B1E1364@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Стець",
                    Name = "Малик ",
                    Patronym = "Вікторович"
                },
                new User
                {
                    Id = 66,
                    Login = "DBCF2ACA-27F5-12AC-376B-23C3447494FE",
                    Email = "DBCF2ACA-27F5-12AC-376B-23C3447494FE@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гомоляка",
                    Name = "Любим ",
                    Patronym = "Макарович"
                },
                new User
                {
                    Id = 67,
                    Login = "5A6D5CD4-2298-9D0E-8868-207977E4501A",
                    Email = "5A6D5CD4-2298-9D0E-8868-207977E4501A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Циба",
                    Name = "Ліпослав ",
                    Patronym = "Герасимович"
                },
                new User
                {
                    Id = 68,
                    Login = "81928FB8-83B6-0DAF-7488-703D099B19FB",
                    Email = "81928FB8-83B6-0DAF-7488-703D099B19FB@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Прилуцький",
                    Name = "Боримир ",
                    Patronym = "Остапович"
                },
                new User
                {
                    Id = 69,
                    Login = "7B3E0D13-7863-94A7-0A91-6ED740830198",
                    Email = "7B3E0D13-7863-94A7-0A91-6ED740830198@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Бараник",
                    Name = "Іоанн ",
                    Patronym = "Арсенович"
                },
                new User
                {
                    Id = 70,
                    Login = "CD78B3E4-5749-5D7D-A51C-0BFB856E97C6",
                    Email = "CD78B3E4-5749-5D7D-A51C-0BFB856E97C6@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Устиянович",
                    Name = "Май ",
                    Patronym = "Орестович"
                },
                new User
                {
                    Id = 71,
                    Login = "D37EB513-3AFA-96F9-1DD2-507C6F47976E",
                    Email = "D37EB513-3AFA-96F9-1DD2-507C6F47976E@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Андрійченко",
                    Name = "Осмомисл ",
                    Patronym = "Борисович"
                },
                new User
                {
                    Id = 72,
                    Login = "2E59C76F-0A87-7043-2578-C16164CD4577",
                    Email = "2E59C76F-0A87-7043-2578-C16164CD4577@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ситенко",
                    Name = "Власт ",
                    Patronym = "Семенович"
                },
                new User
                {
                    Id = 73,
                    Login = "E65BEB85-82F8-10B7-99C3-D1542F095D1A",
                    Email = "E65BEB85-82F8-10B7-99C3-D1542F095D1A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Мізецький",
                    Name = "Ладислав ",
                    Patronym = "Никодимович"
                },
                new User
                {
                    Id = 74,
                    Login = "B2638CE9-30F3-33D3-1808-083DF903745E",
                    Email = "B2638CE9-30F3-33D3-1808-083DF903745E@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кованько",
                    Name = "Щастибог ",
                    Patronym = "Олегович"
                },
                new User
                {
                    Id = 75,
                    Login = "B125252E-36B8-6944-691A-A1B2A1DE56DE",
                    Email = "B125252E-36B8-6944-691A-A1B2A1DE56DE@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Юцевич",
                    Name = "Ярило ",
                    Patronym = "Максимович"
                },
                new User
                {
                    Id = 76,
                    Login = "FCBE6D38-6528-532B-16DC-4F127E821F29",
                    Email = "FCBE6D38-6528-532B-16DC-4F127E821F29@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Лагодовський",
                    Name = "Єремій ",
                    Patronym = "Федорович"
                },
                new User
                {
                    Id = 77,
                    Login = "B3F92BF8-35CC-69B4-9B53-FE7D183A07BF",
                    Email = "B3F92BF8-35CC-69B4-9B53-FE7D183A07BF@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Коновалюк",
                    Name = "Дантур ",
                    Patronym = "Добромирович"
                },
                new User
                {
                    Id = 78,
                    Login = "DD503B0D-7537-4A41-6535-1BC2BC827DF8",
                    Email = "DD503B0D-7537-4A41-6535-1BC2BC827DF8@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Ярошенко",
                    Name = "Грива ",
                    Patronym = "Соломонович"
                },
                new User
                {
                    Id = 79,
                    Login = "E6825126-5B80-33E2-2CD9-FFDFBA88A611",
                    Email = "E6825126-5B80-33E2-2CD9-FFDFBA88A611@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Коробко",
                    Name = "Віст ",
                    Patronym = "Максимович"
                },
                new User
                {
                    Id = 80,
                    Login = "C1136E3F-379E-277D-8ADA-40F947F407EE",
                    Email = "C1136E3F-379E-277D-8ADA-40F947F407EE@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Адамовський",
                    Name = "Русан ",
                    Patronym = "Северинович"
                },
                new User
                {
                    Id = 81,
                    Login = "E6C92451-0D5B-6F8D-5DD0-DC807F9672FA",
                    Email = "E6C92451-0D5B-6F8D-5DD0-DC807F9672FA@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Коморовський",
                    Name = "Любодар ",
                    Patronym = "Найденович"
                },
                new User
                {
                    Id = 82,
                    Login = "D6708551-24E8-5202-270A-3B4FB4D41B33",
                    Email = "D6708551-24E8-5202-270A-3B4FB4D41B33@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Пантелюк",
                    Name = "Добролик ",
                    Patronym = "Мстиславович"
                },
                new User
                {
                    Id = 83,
                    Login = "8DF98409-7128-1E63-9A60-41D4AF585749",
                    Email = "8DF98409-7128-1E63-9A60-41D4AF585749@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Дудка",
                    Name = "Йошка ",
                    Patronym = "Фролович"
                },
                new User
                {
                    Id = 84,
                    Login = "09433710-7303-0006-4197-9955C6108A28",
                    Email = "09433710-7303-0006-4197-9955C6108A28@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Архипенко",
                    Name = "Жито ",
                    Patronym = "Семенович"
                },
                new User
                {
                    Id = 85,
                    Login = "AC912483-1D26-0AB4-723E-51A5628B131E",
                    Email = "AC912483-1D26-0AB4-723E-51A5628B131E@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Моравський",
                    Name = "Назарій ",
                    Patronym = "Радимович"
                },
                new User
                {
                    Id = 86,
                    Login = "A7918CE5-6432-8BEA-99F0-3AD624A72A9A",
                    Email = "A7918CE5-6432-8BEA-99F0-3AD624A72A9A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Сенюк",
                    Name = "Жито ",
                    Patronym = "Герасимович"
                },
                new User
                {
                    Id = 87,
                    Login = "2A178135-4A29-36D1-34E1-B258CBCF65C1",
                    Email = "2A178135-4A29-36D1-34E1-B258CBCF65C1@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Татарнюк",
                    Name = "Іоанн ",
                    Patronym = "Романович"
                },
                new User
                {
                    Id = 88,
                    Login = "3E07DBD0-2E94-46EF-6F1F-8E634324A750",
                    Email = "3E07DBD0-2E94-46EF-6F1F-8E634324A750@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Корчинський",
                    Name = "Надій ",
                    Patronym = "Арсенович"
                },
                new User
                {
                    Id = 89,
                    Login = "1964A89F-8B68-81FA-5A19-3E8D7E604C09",
                    Email = "1964A89F-8B68-81FA-5A19-3E8D7E604C09@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Галущинський",
                    Name = "Немир ",
                    Patronym = "Арсенович"
                },
                new User
                {
                    Id = 90,
                    Login = "7ED017FC-078A-5A37-6BD9-F11D6A6E0ED3",
                    Email = "7ED017FC-078A-5A37-6BD9-F11D6A6E0ED3@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Веремій",
                    Name = "Колодій ",
                    Patronym = "Полянович"
                },
                new User
                {
                    Id = 91,
                    Login = "D5733038-75B9-6CFC-14BE-45E7D2F52536",
                    Email = "D5733038-75B9-6CFC-14BE-45E7D2F52536@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Костогриз",
                    Name = "Милодух ",
                    Patronym = "Добромирович"
                },
                new User
                {
                    Id = 92,
                    Login = "0304531E-90C3-9C8D-4AC5-D1F0FAFD0CBB",
                    Email = "0304531E-90C3-9C8D-4AC5-D1F0FAFD0CBB@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Охримович",
                    Name = "Уличан ",
                    Patronym = "Вітанович"
                },
                new User
                {
                    Id = 93,
                    Login = "F944CB15-2500-6CD5-01E9-AAB7C1C37CC1",
                    Email = "F944CB15-2500-6CD5-01E9-AAB7C1C37CC1@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Оробець",
                    Name = "Юхим ",
                    Patronym = "Радимович"
                },
                new User
                {
                    Id = 94,
                    Login = "CF73E0E7-70D8-27F2-2C98-96971EA431DD",
                    Email = "CF73E0E7-70D8-27F2-2C98-96971EA431DD@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Лісовий",
                    Name = "Світовид ",
                    Patronym = "Семенович"
                },
                new User
                {
                    Id = 95,
                    Login = "0C3787AB-5A5D-570E-04AE-E28714A219F5",
                    Email = "0C3787AB-5A5D-570E-04AE-E28714A219F5@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гончарук",
                    Name = "Біловид ",
                    Patronym = "Семенович"
                },
                new User
                {
                    Id = 96,
                    Login = "423FA339-824D-09CC-659E-8C3558037A74",
                    Email = "423FA339-824D-09CC-659E-8C3558037A74@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Крижицький",
                    Name = "Цвітан ",
                    Patronym = "Сарматович"
                },
                new User
                {
                    Id = 97,
                    Login = "6FEEC903-3FCF-3FB7-9AC1-2BF684F662C0",
                    Email = "6FEEC903-3FCF-3FB7-9AC1-2BF684F662C0@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кирпань",
                    Name = "Ян ",
                    Patronym = "Антонович"
                },
                new User
                {
                    Id = 98,
                    Login = "99FC3F40-2E84-67D2-A50E-FAC99B6F91AE",
                    Email = "99FC3F40-2E84-67D2-A50E-FAC99B6F91AE@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Перебийніс",
                    Name = "Щастислав ",
                    Patronym = "Максимович"
                },
                new User
                {
                    Id = 99,
                    Login = "1533680A-7613-498F-2B1F-EFE88D0F8602",
                    Email = "1533680A-7613-498F-2B1F-EFE88D0F8602@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Черкасенко",
                    Name = "Єгор ",
                    Patronym = "Фролович"
                },
                new User
                {
                    Id = 100,
                    Login = "675C2EFE-4096-9B8A-7839-CEA053D61595",
                    Email = "675C2EFE-4096-9B8A-7839-CEA053D61595@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Загребельний",
                    Name = "Тиміш ",
                    Patronym = "Олегович"
                },
                new User
                {
                    Id = 101,
                    Login = "529526F7-46E1-52F4-9B17-94365A9121E2",
                    Email = "529526F7-46E1-52F4-9B17-94365A9121E2@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Маринченко",
                    Name = "Гервасій ",
                    Patronym = "Йосипович"
                },
                new User
                {
                    Id = 102,
                    Login = "4C8D17D2-A52A-3789-0201-740B8A4F0B6C",
                    Email = "4C8D17D2-A52A-3789-0201-740B8A4F0B6C@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Миронюк",
                    Name = "Флор ",
                    Patronym = "Милославович"
                },
                new User
                {
                    Id = 103,
                    Login = "60E10532-128F-236E-8098-6CAC90331750",
                    Email = "60E10532-128F-236E-8098-6CAC90331750@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Чучупак",
                    Name = "Єгор ",
                    Patronym = "Зорянович"
                },
                new User
                {
                    Id = 104,
                    Login = "8595E699-02B4-6EA5-4AF4-3D1764741C6A",
                    Email = "8595E699-02B4-6EA5-4AF4-3D1764741C6A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Чубатенко",
                    Name = "Магадар ",
                    Patronym = "Ростиславович"
                },
                new User
                {
                    Id = 105,
                    Login = "F699076B-9EC2-2BFF-3063-38FEEF9D9536",
                    Email = "F699076B-9EC2-2BFF-3063-38FEEF9D9536@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Гайденко",
                    Name = "Щедрогост ",
                    Patronym = "Захарович"
                },
                new User
                {
                    Id = 106,
                    Login = "226F839A-05A6-0BF7-2A5D-1759B2B79A0A",
                    Email = "226F839A-05A6-0BF7-2A5D-1759B2B79A0A@gachi.com",
                    Role = Role.User,
                    PasswordHash = HashPassword("password"),
                    Surname = "Кормош",
                    Name = "Шерлок ",
                    Patronym = "Арсенович"
                }
            );

            modelBuilder.Entity<HelpCategory>().HasData(
                new HelpCategory { Id = 1, Name = "Соціальна допомога" },
                new HelpCategory { Id = 2, Name = "Допомога по працевлаштуванню" },
                new HelpCategory { Id = 3, Name = "Медична допомога" },
                new HelpCategory { Id = 4, Name = "Психологічна допомога" },
                new HelpCategory { Id = 5, Name = "Юридична допомога" },
                new HelpCategory { Id = 6, Name = "Фінансова допомога" }
            );

            var help = Enumerable.Range(1, 2001).Select(n =>
            {
                Random r = new Random();
                int status = r.Next(100) switch
                {
                     >= 0 and <= 10 => 0,
                    > 10 and <= 95 => 1,
                    _ => 2
                };
                return new Help 
                { 
                    Id = n, 
                    AuthorId = r.Next(2, 107), 
                    Status = (DocumentStatus)status, 
                    HelpCategoryId = r.Next(1, 7), 
                    CreatedAt = DateTime.Now.AddDays(r.Next(-100, 500)) 
                };
            });

            modelBuilder.Entity<Help>().HasData(help);
        }
        private static string HashPassword(string password) => Convert.ToBase64String(SHA256.HashData(Encoding.Default.GetBytes(password)));
    }
}
