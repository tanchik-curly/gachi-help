using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GachiHelp.WebApi.Migrations
{
    public partial class AddedHelp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HelpCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Helps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpCategoryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Helps_HelpCategories_HelpCategoryId",
                        column: x => x.HelpCategoryId,
                        principalTable: "HelpCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Helps_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HelpCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Соціальна допомога" },
                    { 2, "Допомога по працевлаштуванню" },
                    { 3, "Медична допомога" },
                    { 4, "Психологічна допомога" },
                    { 5, "Юридична допомога" },
                    { 6, "Фінансова допомога" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Name", "PasswordHash", "Patronym", "Role", "Surname" },
                values: new object[,]
                {
                    { 8, "F91F0532-5205-6D4B-9D44-B0B5ED664182@gachi.com", "F91F0532-5205-6D4B-9D44-B0B5ED664182", "Костянтин ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Артемович", (byte)0, "Теплицький" },
                    { 9, "9BCBE1F9-10F8-5D12-2A8C-9B7F6D117881@gachi.com", "9BCBE1F9-10F8-5D12-2A8C-9B7F6D117881", "Федір ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Сарматович", (byte)0, "Троцюк" },
                    { 10, "8EEC0E45-437E-0E5F-A544-6A17581090CF@gachi.com", "8EEC0E45-437E-0E5F-A544-6A17581090CF", "Далібор ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тарасович", (byte)0, "Найдьонов" },
                    { 11, "6048AC32-A77E-4E8A-61F0-32DC6A83053C@gachi.com", "6048AC32-A77E-4E8A-61F0-32DC6A83053C", "Бративой ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Фролович", (byte)0, "Стахів" },
                    { 12, "8C07AE86-0FB2-5733-448B-5B8E2F755EC5@gachi.com", "8C07AE86-0FB2-5733-448B-5B8E2F755EC5", "Аскольд ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тихонович", (byte)0, "Фешовець" },
                    { 13, "2D3979D2-6209-0580-2A38-A210A0643804@gachi.com", "2D3979D2-6209-0580-2A38-A210A0643804", "Вукол ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тимурович", (byte)0, "Гуляницький" },
                    { 14, "8A48AEF7-51C1-6D83-A312-93E1DDCF0450@gachi.com", "8A48AEF7-51C1-6D83-A312-93E1DDCF0450", "Цвітан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Зорянович", (byte)0, "Малишко" },
                    { 15, "1674085B-2D68-9D72-9310-F9F493120FDF@gachi.com", "1674085B-2D68-9D72-9310-F9F493120FDF", "Щастислав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Світанович", (byte)0, "Плішка" },
                    { 16, "12872033-7D35-0B9F-12A4-C0EC32159379@gachi.com", "12872033-7D35-0B9F-12A4-C0EC32159379", "Доброслав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Любомирович", (byte)0, "Косар" },
                    { 17, "7E086B8B-9EE3-69F5-0E39-ABCAD39588D0@gachi.com", "7E086B8B-9EE3-69F5-0E39-ABCAD39588D0", "Євлампій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Вадимович", (byte)0, "Ангелович" },
                    { 18, "5DD9E18B-6DCB-86FB-5142-7C33B37A0B65@gachi.com", "5DD9E18B-6DCB-86FB-5142-7C33B37A0B65", "Чара ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Світанович", (byte)0, "Степченко" },
                    { 19, "80BE8251-9489-51B8-3414-CD5FC70A477D@gachi.com", "80BE8251-9489-51B8-3414-CD5FC70A477D", "Юхим ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Макарович", (byte)0, "Герасимець" },
                    { 20, "F59689BA-56C5-0B92-7896-D68837926157@gachi.com", "F59689BA-56C5-0B92-7896-D68837926157", "Любослав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Азарович", (byte)0, "Рябоконь" },
                    { 21, "A944A5A3-3E6C-2B8B-8CBC-A4D1DAEF4DCF@gachi.com", "A944A5A3-3E6C-2B8B-8CBC-A4D1DAEF4DCF", "Юхим ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Юліанович", (byte)0, "Біленко" },
                    { 22, "49AF543C-1068-7AFE-1268-0877F91B541B@gachi.com", "49AF543C-1068-7AFE-1268-0877F91B541B", "Щастибог ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Вітанович", (byte)0, "Семеніхін" },
                    { 23, "DEDFD2F7-48CA-5E1C-5B79-29B8073518C9@gachi.com", "DEDFD2F7-48CA-5E1C-5B79-29B8073518C9", "Йонас ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тихонович", (byte)0, "Собко" },
                    { 24, "97DDDEC4-7F0F-0BAA-A2CD-7F211ED7A1A1@gachi.com", "97DDDEC4-7F0F-0BAA-A2CD-7F211ED7A1A1", "Хвала ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Адріанович", (byte)0, "Гопкало" },
                    { 25, "BD93B82F-678B-A39D-4E65-3B9072546594@gachi.com", "BD93B82F-678B-A39D-4E65-3B9072546594", "Троян ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Сарматович", (byte)0, "Кравчик" },
                    { 26, "D0B7A913-1475-8EE6-1895-D4A0B0A85EB0@gachi.com", "D0B7A913-1475-8EE6-1895-D4A0B0A85EB0", "Сергій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Найденович", (byte)0, "Ясинський" },
                    { 27, "9EF2DDF3-022A-071D-6E9B-24AA2B0F6824@gachi.com", "9EF2DDF3-022A-071D-6E9B-24AA2B0F6824", "Йомер ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Арсенович", (byte)0, "Андрущенко" },
                    { 28, "14CEC370-96FA-1698-5639-91FE3E9C18F9@gachi.com", "14CEC370-96FA-1698-5639-91FE3E9C18F9", "Уличан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Ярославович", (byte)0, "Авратинський" },
                    { 29, "010CD3CA-4CD0-0501-8793-4E91C54E877E@gachi.com", "010CD3CA-4CD0-0501-8793-4E91C54E877E", "Еразм ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Жданович", (byte)0, "Євтушенко" },
                    { 30, "83791907-0C0C-3525-4716-56458101139B@gachi.com", "83791907-0C0C-3525-4716-56458101139B", "Йосеф ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Милославович", (byte)0, "Ємельяненко" },
                    { 31, "B79D280F-49BF-32E7-6BF1-C664BF1C5522@gachi.com", "B79D280F-49BF-32E7-6BF1-C664BF1C5522", "Артем ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Володимирович", (byte)0, "Невінчаний" },
                    { 32, "89747AA0-3698-44E9-68D0-3499B0142687@gachi.com", "89747AA0-3698-44E9-68D0-3499B0142687", "Братислав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Богданович", (byte)0, "Чехівський" },
                    { 33, "31949148-2468-32F8-21B7-F088FD1991A4@gachi.com", "31949148-2468-32F8-21B7-F088FD1991A4", "Яртур ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Юліанович", (byte)0, "Медведюк" },
                    { 34, "6901625F-A02D-6095-3C87-C917F7917680@gachi.com", "6901625F-A02D-6095-3C87-C917F7917680", "Осемрит ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Яромирович", (byte)0, "Кузьма" },
                    { 35, "1D670A89-1520-0B85-57BB-42FAE98A9FDD@gachi.com", "1D670A89-1520-0B85-57BB-42FAE98A9FDD", "Федір ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Левович", (byte)0, "Підгаєцький" },
                    { 36, "C3071F09-2011-098B-909D-D44B6D5E38F6@gachi.com", "C3071F09-2011-098B-909D-D44B6D5E38F6", "Родослав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Федорович", (byte)0, "Пашко" },
                    { 37, "7ACD243A-8B73-85AD-3181-5C1EED002DAA@gachi.com", "7ACD243A-8B73-85AD-3181-5C1EED002DAA", "Живослав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Северинович", (byte)0, "Канішевський" },
                    { 38, "72547C4E-9C3C-966E-654A-14CFE7805294@gachi.com", "72547C4E-9C3C-966E-654A-14CFE7805294", "Миробог ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тихонович", (byte)0, "Арсенич" },
                    { 39, "2F9054BA-570A-109A-5C1D-BF1EF5554C41@gachi.com", "2F9054BA-570A-109A-5C1D-BF1EF5554C41", "Драган ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Любомирович", (byte)0, "Корольчук" },
                    { 40, "659EC371-7A57-910D-9D99-DE95E1433E19@gachi.com", "659EC371-7A57-910D-9D99-DE95E1433E19", "Хотян ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Мстиславович", (byte)0, "Полотай" },
                    { 41, "F6372D04-740C-1F6B-43EF-A1C5440A41CC@gachi.com", "F6372D04-740C-1F6B-43EF-A1C5440A41CC", "Життєлюб ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Остапович", (byte)0, "Могиленко" },
                    { 42, "3E20B44A-1E80-4BDA-725A-6BE50C069549@gachi.com", "3E20B44A-1E80-4BDA-725A-6BE50C069549", "Анісій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Ростиславович", (byte)0, "Пащук" },
                    { 43, "8414ED38-1EC0-883E-25BB-E14100613A9C@gachi.com", "8414ED38-1EC0-883E-25BB-E14100613A9C", "Йомер ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Антонович", (byte)0, "Щурат" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Name", "PasswordHash", "Patronym", "Role", "Surname" },
                values: new object[,]
                {
                    { 44, "2F786E5F-3D2F-5D67-5005-7E2573EFA509@gachi.com", "2F786E5F-3D2F-5D67-5005-7E2573EFA509", "Микита ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Федорович", (byte)0, "Роднянський" },
                    { 45, "FF8DF46E-2C26-0C72-7FCB-3AAAD2426C11@gachi.com", "FF8DF46E-2C26-0C72-7FCB-3AAAD2426C11", "Щедрогост ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Макарович", (byte)0, "Хмелецький" },
                    { 46, "E4D2BCD0-9C9F-9F10-359E-F4ADCFE20652@gachi.com", "E4D2BCD0-9C9F-9F10-359E-F4ADCFE20652", "Данко ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Августинович", (byte)0, "Авдієвський" },
                    { 47, "1D747F30-52F4-1EA1-0D6C-766458B68580@gachi.com", "1D747F30-52F4-1EA1-0D6C-766458B68580", "Хранимир ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Орестович", (byte)0, "Калениченко" },
                    { 48, "11311BAB-012E-220F-4FF9-82A3703B2B2B@gachi.com", "11311BAB-012E-220F-4FF9-82A3703B2B2B", "Корнелій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Вадимович", (byte)0, "Оніщенко" },
                    { 49, "AE0FDEC6-629A-67B7-0E32-B30B3B818203@gachi.com", "AE0FDEC6-629A-67B7-0E32-B30B3B818203", "Хранимир ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Чеславович", (byte)0, "Батенко" },
                    { 50, "9CB37CF8-365D-0E5B-7B60-0C5C5F4B0227@gachi.com", "9CB37CF8-365D-0E5B-7B60-0C5C5F4B0227", "Радан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Юліанович", (byte)0, "Зазуляк" },
                    { 51, "D156F22F-66F4-01C0-0BF0-887E2C574A13@gachi.com", "D156F22F-66F4-01C0-0BF0-887E2C574A13", "Дорофій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Юхимович", (byte)0, "Крамськой" },
                    { 52, "BB41BAAF-78FA-295B-4584-3470A1F14BBF@gachi.com", "BB41BAAF-78FA-295B-4584-3470A1F14BBF", "Щедрогост ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Леонідович", (byte)0, "Громики" },
                    { 53, "2B92A1B7-6AC4-6587-4EE1-C62620DC04CD@gachi.com", "2B92A1B7-6AC4-6587-4EE1-C62620DC04CD", "Ничипір ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Никодимович", (byte)0, "Кайда" },
                    { 54, "B5A7111A-375B-8633-033F-0CE94AD283C7@gachi.com", "B5A7111A-375B-8633-033F-0CE94AD283C7", "Еміль ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Пилипович", (byte)0, "Денисенко" },
                    { 55, "CFF82BCF-63DA-9799-6638-A9C3077AA70F@gachi.com", "CFF82BCF-63DA-9799-6638-A9C3077AA70F", "Юліан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Левович", (byte)0, "Манзій" },
                    { 56, "A4CA4802-348A-65E2-2B81-8E87F5E51FFB@gachi.com", "A4CA4802-348A-65E2-2B81-8E87F5E51FFB", "Адріан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Зорянович", (byte)0, "Марченко" },
                    { 57, "5B057869-59E5-777D-9EEA-C517C7B31C7D@gachi.com", "5B057869-59E5-777D-9EEA-C517C7B31C7D", "Києслав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Йосипович", (byte)0, "Витвицький" },
                    { 58, "47B22C1A-0F6C-8C7D-937F-A7841EA55DC7@gachi.com", "47B22C1A-0F6C-8C7D-937F-A7841EA55DC7", "Єгор ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Устимович", (byte)0, "Петрусь" },
                    { 59, "5AF954E2-2190-09A9-943C-4BF38BE8814A@gachi.com", "5AF954E2-2190-09A9-943C-4BF38BE8814A", "Добривод ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тимурович", (byte)0, "Галаса" },
                    { 60, "3B90E239-72E4-7106-9B81-3A79A1044C55@gachi.com", "3B90E239-72E4-7106-9B81-3A79A1044C55", "Колодій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Драганович", (byte)0, "Прудіус" },
                    { 61, "665709BC-4BDB-0CAA-956D-34B529070270@gachi.com", "665709BC-4BDB-0CAA-956D-34B529070270", "Наслав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Адамович", (byte)0, "Канішевський" },
                    { 62, "50965BC6-94FF-78DE-5D8F-9403FBE73741@gachi.com", "50965BC6-94FF-78DE-5D8F-9403FBE73741", "Панас ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Северинович", (byte)0, "Гриньків" },
                    { 63, "5D68CD80-0B90-1320-2290-84ED50AB0FF7@gachi.com", "5D68CD80-0B90-1320-2290-84ED50AB0FF7", "Щедрогост ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Тихонович", (byte)0, "Костюк" },
                    { 64, "25D65028-2C8D-2BDE-6CE0-B7F48F022D31@gachi.com", "25D65028-2C8D-2BDE-6CE0-B7F48F022D31", "Недан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Сарматович", (byte)0, "Ткач" },
                    { 65, "A8A17287-0221-7CA2-9C33-E1590B1E1364@gachi.com", "A8A17287-0221-7CA2-9C33-E1590B1E1364", "Малик ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Вікторович", (byte)0, "Стець" },
                    { 66, "DBCF2ACA-27F5-12AC-376B-23C3447494FE@gachi.com", "DBCF2ACA-27F5-12AC-376B-23C3447494FE", "Любим ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Макарович", (byte)0, "Гомоляка" },
                    { 67, "5A6D5CD4-2298-9D0E-8868-207977E4501A@gachi.com", "5A6D5CD4-2298-9D0E-8868-207977E4501A", "Ліпослав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Герасимович", (byte)0, "Циба" },
                    { 68, "81928FB8-83B6-0DAF-7488-703D099B19FB@gachi.com", "81928FB8-83B6-0DAF-7488-703D099B19FB", "Боримир ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Остапович", (byte)0, "Прилуцький" },
                    { 69, "7B3E0D13-7863-94A7-0A91-6ED740830198@gachi.com", "7B3E0D13-7863-94A7-0A91-6ED740830198", "Іоанн ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Арсенович", (byte)0, "Бараник" },
                    { 70, "CD78B3E4-5749-5D7D-A51C-0BFB856E97C6@gachi.com", "CD78B3E4-5749-5D7D-A51C-0BFB856E97C6", "Май ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Орестович", (byte)0, "Устиянович" },
                    { 71, "D37EB513-3AFA-96F9-1DD2-507C6F47976E@gachi.com", "D37EB513-3AFA-96F9-1DD2-507C6F47976E", "Осмомисл ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Борисович", (byte)0, "Андрійченко" },
                    { 72, "2E59C76F-0A87-7043-2578-C16164CD4577@gachi.com", "2E59C76F-0A87-7043-2578-C16164CD4577", "Власт ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Семенович", (byte)0, "Ситенко" },
                    { 73, "E65BEB85-82F8-10B7-99C3-D1542F095D1A@gachi.com", "E65BEB85-82F8-10B7-99C3-D1542F095D1A", "Ладислав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Никодимович", (byte)0, "Мізецький" },
                    { 74, "B2638CE9-30F3-33D3-1808-083DF903745E@gachi.com", "B2638CE9-30F3-33D3-1808-083DF903745E", "Щастибог ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Олегович", (byte)0, "Кованько" },
                    { 75, "B125252E-36B8-6944-691A-A1B2A1DE56DE@gachi.com", "B125252E-36B8-6944-691A-A1B2A1DE56DE", "Ярило ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Максимович", (byte)0, "Юцевич" },
                    { 76, "FCBE6D38-6528-532B-16DC-4F127E821F29@gachi.com", "FCBE6D38-6528-532B-16DC-4F127E821F29", "Єремій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Федорович", (byte)0, "Лагодовський" },
                    { 77, "B3F92BF8-35CC-69B4-9B53-FE7D183A07BF@gachi.com", "B3F92BF8-35CC-69B4-9B53-FE7D183A07BF", "Дантур ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Добромирович", (byte)0, "Коновалюк" },
                    { 78, "DD503B0D-7537-4A41-6535-1BC2BC827DF8@gachi.com", "DD503B0D-7537-4A41-6535-1BC2BC827DF8", "Грива ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Соломонович", (byte)0, "Ярошенко" },
                    { 79, "E6825126-5B80-33E2-2CD9-FFDFBA88A611@gachi.com", "E6825126-5B80-33E2-2CD9-FFDFBA88A611", "Віст ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Максимович", (byte)0, "Коробко" },
                    { 80, "C1136E3F-379E-277D-8ADA-40F947F407EE@gachi.com", "C1136E3F-379E-277D-8ADA-40F947F407EE", "Русан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Северинович", (byte)0, "Адамовський" },
                    { 81, "E6C92451-0D5B-6F8D-5DD0-DC807F9672FA@gachi.com", "E6C92451-0D5B-6F8D-5DD0-DC807F9672FA", "Любодар ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Найденович", (byte)0, "Коморовський" },
                    { 82, "D6708551-24E8-5202-270A-3B4FB4D41B33@gachi.com", "D6708551-24E8-5202-270A-3B4FB4D41B33", "Добролик ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Мстиславович", (byte)0, "Пантелюк" },
                    { 83, "8DF98409-7128-1E63-9A60-41D4AF585749@gachi.com", "8DF98409-7128-1E63-9A60-41D4AF585749", "Йошка ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Фролович", (byte)0, "Дудка" },
                    { 84, "09433710-7303-0006-4197-9955C6108A28@gachi.com", "09433710-7303-0006-4197-9955C6108A28", "Жито ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Семенович", (byte)0, "Архипенко" },
                    { 85, "AC912483-1D26-0AB4-723E-51A5628B131E@gachi.com", "AC912483-1D26-0AB4-723E-51A5628B131E", "Назарій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Радимович", (byte)0, "Моравський" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Name", "PasswordHash", "Patronym", "Role", "Surname" },
                values: new object[,]
                {
                    { 86, "A7918CE5-6432-8BEA-99F0-3AD624A72A9A@gachi.com", "A7918CE5-6432-8BEA-99F0-3AD624A72A9A", "Жито ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Герасимович", (byte)0, "Сенюк" },
                    { 87, "2A178135-4A29-36D1-34E1-B258CBCF65C1@gachi.com", "2A178135-4A29-36D1-34E1-B258CBCF65C1", "Іоанн ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Романович", (byte)0, "Татарнюк" },
                    { 88, "3E07DBD0-2E94-46EF-6F1F-8E634324A750@gachi.com", "3E07DBD0-2E94-46EF-6F1F-8E634324A750", "Надій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Арсенович", (byte)0, "Корчинський" },
                    { 89, "1964A89F-8B68-81FA-5A19-3E8D7E604C09@gachi.com", "1964A89F-8B68-81FA-5A19-3E8D7E604C09", "Немир ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Арсенович", (byte)0, "Галущинський" },
                    { 90, "7ED017FC-078A-5A37-6BD9-F11D6A6E0ED3@gachi.com", "7ED017FC-078A-5A37-6BD9-F11D6A6E0ED3", "Колодій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Полянович", (byte)0, "Веремій" },
                    { 91, "D5733038-75B9-6CFC-14BE-45E7D2F52536@gachi.com", "D5733038-75B9-6CFC-14BE-45E7D2F52536", "Милодух ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Добромирович", (byte)0, "Костогриз" },
                    { 92, "0304531E-90C3-9C8D-4AC5-D1F0FAFD0CBB@gachi.com", "0304531E-90C3-9C8D-4AC5-D1F0FAFD0CBB", "Уличан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Вітанович", (byte)0, "Охримович" },
                    { 93, "F944CB15-2500-6CD5-01E9-AAB7C1C37CC1@gachi.com", "F944CB15-2500-6CD5-01E9-AAB7C1C37CC1", "Юхим ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Радимович", (byte)0, "Оробець" },
                    { 94, "CF73E0E7-70D8-27F2-2C98-96971EA431DD@gachi.com", "CF73E0E7-70D8-27F2-2C98-96971EA431DD", "Світовид ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Семенович", (byte)0, "Лісовий" },
                    { 95, "0C3787AB-5A5D-570E-04AE-E28714A219F5@gachi.com", "0C3787AB-5A5D-570E-04AE-E28714A219F5", "Біловид ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Семенович", (byte)0, "Гончарук" },
                    { 96, "423FA339-824D-09CC-659E-8C3558037A74@gachi.com", "423FA339-824D-09CC-659E-8C3558037A74", "Цвітан ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Сарматович", (byte)0, "Крижицький" },
                    { 97, "6FEEC903-3FCF-3FB7-9AC1-2BF684F662C0@gachi.com", "6FEEC903-3FCF-3FB7-9AC1-2BF684F662C0", "Ян ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Антонович", (byte)0, "Кирпань" },
                    { 98, "99FC3F40-2E84-67D2-A50E-FAC99B6F91AE@gachi.com", "99FC3F40-2E84-67D2-A50E-FAC99B6F91AE", "Щастислав ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Максимович", (byte)0, "Перебийніс" },
                    { 99, "1533680A-7613-498F-2B1F-EFE88D0F8602@gachi.com", "1533680A-7613-498F-2B1F-EFE88D0F8602", "Єгор ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Фролович", (byte)0, "Черкасенко" },
                    { 100, "675C2EFE-4096-9B8A-7839-CEA053D61595@gachi.com", "675C2EFE-4096-9B8A-7839-CEA053D61595", "Тиміш ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Олегович", (byte)0, "Загребельний" },
                    { 101, "529526F7-46E1-52F4-9B17-94365A9121E2@gachi.com", "529526F7-46E1-52F4-9B17-94365A9121E2", "Гервасій ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Йосипович", (byte)0, "Маринченко" },
                    { 102, "4C8D17D2-A52A-3789-0201-740B8A4F0B6C@gachi.com", "4C8D17D2-A52A-3789-0201-740B8A4F0B6C", "Флор ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Милославович", (byte)0, "Миронюк" },
                    { 103, "60E10532-128F-236E-8098-6CAC90331750@gachi.com", "60E10532-128F-236E-8098-6CAC90331750", "Єгор ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Зорянович", (byte)0, "Чучупак" },
                    { 104, "8595E699-02B4-6EA5-4AF4-3D1764741C6A@gachi.com", "8595E699-02B4-6EA5-4AF4-3D1764741C6A", "Магадар ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Ростиславович", (byte)0, "Чубатенко" },
                    { 105, "F699076B-9EC2-2BFF-3063-38FEEF9D9536@gachi.com", "F699076B-9EC2-2BFF-3063-38FEEF9D9536", "Щедрогост ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Захарович", (byte)0, "Гайденко" },
                    { 106, "226F839A-05A6-0BF7-2A5D-1759B2B79A0A@gachi.com", "226F839A-05A6-0BF7-2A5D-1759B2B79A0A", "Шерлок ", "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", "Арсенович", (byte)0, "Кормош" }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1, 72, new DateTime(2023, 6, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6810), 5, (byte)0 },
                    { 2, 59, new DateTime(2023, 1, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6856), 6, (byte)1 },
                    { 3, 38, new DateTime(2023, 6, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6861), 6, (byte)1 },
                    { 4, 10, new DateTime(2023, 1, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6865), 3, (byte)1 },
                    { 5, 61, new DateTime(2023, 8, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6872), 1, (byte)0 },
                    { 6, 67, new DateTime(2023, 1, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6878), 1, (byte)1 },
                    { 7, 88, new DateTime(2024, 1, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6881), 1, (byte)1 },
                    { 8, 14, new DateTime(2024, 1, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6885), 3, (byte)1 },
                    { 9, 57, new DateTime(2023, 11, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6892), 6, (byte)1 },
                    { 10, 13, new DateTime(2022, 8, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6896), 4, (byte)1 },
                    { 11, 62, new DateTime(2023, 7, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6900), 1, (byte)1 },
                    { 12, 20, new DateTime(2023, 10, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6904), 3, (byte)1 },
                    { 13, 66, new DateTime(2022, 12, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6910), 4, (byte)1 },
                    { 14, 13, new DateTime(2022, 12, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6914), 5, (byte)1 },
                    { 15, 24, new DateTime(2024, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6918), 6, (byte)1 },
                    { 16, 67, new DateTime(2024, 3, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6921), 4, (byte)1 },
                    { 17, 17, new DateTime(2023, 4, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6927), 2, (byte)1 },
                    { 18, 90, new DateTime(2023, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6932), 1, (byte)1 },
                    { 19, 96, new DateTime(2023, 5, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6935), 3, (byte)1 },
                    { 20, 38, new DateTime(2023, 10, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6939), 1, (byte)1 },
                    { 21, 16, new DateTime(2023, 6, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6946), 5, (byte)1 },
                    { 22, 49, new DateTime(2023, 6, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6950), 2, (byte)2 },
                    { 23, 106, new DateTime(2023, 2, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6953), 2, (byte)1 },
                    { 24, 27, new DateTime(2024, 1, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6957), 5, (byte)1 },
                    { 25, 21, new DateTime(2023, 5, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6962), 1, (byte)1 },
                    { 26, 84, new DateTime(2022, 8, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6966), 4, (byte)1 },
                    { 27, 11, new DateTime(2024, 3, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6969), 5, (byte)1 },
                    { 28, 41, new DateTime(2022, 9, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6973), 3, (byte)1 },
                    { 29, 77, new DateTime(2022, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6979), 6, (byte)1 },
                    { 30, 55, new DateTime(2022, 11, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6982), 1, (byte)2 },
                    { 31, 37, new DateTime(2023, 4, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6986), 5, (byte)0 },
                    { 32, 76, new DateTime(2023, 12, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6990), 5, (byte)1 },
                    { 33, 91, new DateTime(2023, 7, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(6996), 5, (byte)0 },
                    { 34, 69, new DateTime(2023, 12, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7001), 5, (byte)1 },
                    { 35, 49, new DateTime(2023, 5, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7004), 6, (byte)1 },
                    { 36, 55, new DateTime(2023, 10, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7008), 2, (byte)1 },
                    { 37, 87, new DateTime(2023, 9, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7014), 5, (byte)1 },
                    { 38, 23, new DateTime(2023, 6, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7018), 2, (byte)1 },
                    { 39, 78, new DateTime(2023, 10, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7022), 2, (byte)1 },
                    { 40, 43, new DateTime(2023, 11, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7026), 6, (byte)1 },
                    { 41, 106, new DateTime(2023, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7031), 4, (byte)1 },
                    { 42, 77, new DateTime(2022, 11, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7035), 4, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 43, 82, new DateTime(2022, 10, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7039), 6, (byte)1 },
                    { 44, 25, new DateTime(2023, 5, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7043), 3, (byte)1 },
                    { 45, 16, new DateTime(2022, 8, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7050), 5, (byte)2 },
                    { 46, 88, new DateTime(2023, 2, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7053), 2, (byte)1 },
                    { 47, 33, new DateTime(2023, 11, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7057), 6, (byte)1 },
                    { 48, 44, new DateTime(2023, 11, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7061), 6, (byte)1 },
                    { 49, 77, new DateTime(2023, 1, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7067), 6, (byte)1 },
                    { 50, 66, new DateTime(2024, 2, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7070), 5, (byte)1 },
                    { 51, 16, new DateTime(2023, 7, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7074), 2, (byte)1 },
                    { 52, 23, new DateTime(2023, 2, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7077), 6, (byte)1 },
                    { 53, 46, new DateTime(2023, 10, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7083), 2, (byte)1 },
                    { 54, 42, new DateTime(2023, 4, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7087), 2, (byte)0 },
                    { 55, 82, new DateTime(2023, 11, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7090), 6, (byte)1 },
                    { 56, 3, new DateTime(2023, 12, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7123), 4, (byte)1 },
                    { 57, 82, new DateTime(2023, 5, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7130), 4, (byte)1 },
                    { 58, 40, new DateTime(2023, 4, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7133), 2, (byte)1 },
                    { 59, 9, new DateTime(2023, 2, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7137), 2, (byte)0 },
                    { 60, 84, new DateTime(2023, 2, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7141), 1, (byte)0 },
                    { 61, 54, new DateTime(2023, 4, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7147), 1, (byte)1 },
                    { 62, 92, new DateTime(2023, 8, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7150), 3, (byte)1 },
                    { 63, 75, new DateTime(2023, 11, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7153), 4, (byte)1 },
                    { 64, 57, new DateTime(2024, 2, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7157), 5, (byte)1 },
                    { 65, 12, new DateTime(2022, 10, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7163), 4, (byte)1 },
                    { 66, 62, new DateTime(2022, 12, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7167), 6, (byte)1 },
                    { 67, 15, new DateTime(2023, 1, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7171), 4, (byte)1 },
                    { 68, 10, new DateTime(2023, 7, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7174), 2, (byte)0 },
                    { 69, 76, new DateTime(2023, 11, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7180), 5, (byte)1 },
                    { 70, 4, new DateTime(2023, 7, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7184), 6, (byte)1 },
                    { 71, 52, new DateTime(2023, 7, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7188), 2, (byte)0 },
                    { 72, 14, new DateTime(2023, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7191), 6, (byte)1 },
                    { 73, 77, new DateTime(2023, 10, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7197), 4, (byte)1 },
                    { 74, 71, new DateTime(2022, 9, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7201), 2, (byte)1 },
                    { 75, 18, new DateTime(2023, 11, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7204), 3, (byte)1 },
                    { 76, 21, new DateTime(2022, 10, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7208), 2, (byte)1 },
                    { 77, 81, new DateTime(2023, 12, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7214), 4, (byte)1 },
                    { 78, 40, new DateTime(2023, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7217), 1, (byte)2 },
                    { 79, 2, new DateTime(2022, 9, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7221), 6, (byte)1 },
                    { 80, 101, new DateTime(2023, 12, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7225), 2, (byte)1 },
                    { 81, 28, new DateTime(2024, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7231), 3, (byte)2 },
                    { 82, 91, new DateTime(2023, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7235), 5, (byte)1 },
                    { 83, 9, new DateTime(2023, 10, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7239), 2, (byte)1 },
                    { 84, 64, new DateTime(2022, 9, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7242), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 85, 5, new DateTime(2022, 8, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7248), 1, (byte)1 },
                    { 86, 42, new DateTime(2023, 5, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7252), 6, (byte)1 },
                    { 87, 101, new DateTime(2023, 7, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7255), 3, (byte)1 },
                    { 88, 22, new DateTime(2023, 3, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7258), 3, (byte)1 },
                    { 89, 18, new DateTime(2023, 12, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7264), 2, (byte)1 },
                    { 90, 49, new DateTime(2024, 1, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7268), 1, (byte)1 },
                    { 91, 46, new DateTime(2023, 8, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7272), 2, (byte)1 },
                    { 92, 13, new DateTime(2023, 6, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7276), 6, (byte)0 },
                    { 93, 96, new DateTime(2023, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7283), 3, (byte)1 },
                    { 94, 85, new DateTime(2024, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7286), 5, (byte)1 },
                    { 95, 46, new DateTime(2022, 8, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7290), 1, (byte)1 },
                    { 96, 43, new DateTime(2023, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7293), 2, (byte)1 },
                    { 97, 74, new DateTime(2022, 9, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7299), 4, (byte)0 },
                    { 98, 44, new DateTime(2023, 10, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7303), 4, (byte)1 },
                    { 99, 102, new DateTime(2023, 11, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7307), 1, (byte)1 },
                    { 100, 72, new DateTime(2023, 7, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7310), 4, (byte)1 },
                    { 101, 92, new DateTime(2023, 10, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7316), 6, (byte)1 },
                    { 102, 62, new DateTime(2023, 6, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7320), 5, (byte)1 },
                    { 103, 65, new DateTime(2024, 2, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7324), 2, (byte)1 },
                    { 104, 40, new DateTime(2023, 7, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7327), 2, (byte)1 },
                    { 105, 75, new DateTime(2023, 5, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7333), 2, (byte)1 },
                    { 106, 35, new DateTime(2024, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7337), 1, (byte)1 },
                    { 107, 22, new DateTime(2023, 3, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7340), 1, (byte)1 },
                    { 108, 50, new DateTime(2022, 8, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7344), 2, (byte)1 },
                    { 109, 76, new DateTime(2023, 7, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7350), 6, (byte)1 },
                    { 110, 7, new DateTime(2023, 8, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7354), 2, (byte)1 },
                    { 111, 92, new DateTime(2024, 3, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7384), 3, (byte)1 },
                    { 112, 75, new DateTime(2022, 12, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7388), 3, (byte)1 },
                    { 113, 37, new DateTime(2023, 9, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7394), 6, (byte)1 },
                    { 114, 19, new DateTime(2023, 1, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7397), 4, (byte)1 },
                    { 115, 105, new DateTime(2023, 1, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7401), 6, (byte)1 },
                    { 116, 64, new DateTime(2023, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7404), 1, (byte)1 },
                    { 117, 43, new DateTime(2023, 4, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7410), 6, (byte)1 },
                    { 118, 49, new DateTime(2023, 7, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7414), 5, (byte)1 },
                    { 119, 10, new DateTime(2022, 9, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7418), 2, (byte)2 },
                    { 120, 20, new DateTime(2022, 12, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7421), 3, (byte)1 },
                    { 121, 77, new DateTime(2023, 11, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7427), 3, (byte)1 },
                    { 122, 61, new DateTime(2024, 2, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7430), 2, (byte)1 },
                    { 123, 7, new DateTime(2022, 10, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7434), 1, (byte)1 },
                    { 124, 70, new DateTime(2023, 2, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7438), 3, (byte)1 },
                    { 125, 10, new DateTime(2023, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7444), 2, (byte)1 },
                    { 126, 36, new DateTime(2023, 6, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7447), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 127, 22, new DateTime(2023, 8, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7451), 6, (byte)1 },
                    { 128, 12, new DateTime(2024, 3, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7455), 6, (byte)2 },
                    { 129, 95, new DateTime(2023, 3, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7461), 4, (byte)1 },
                    { 130, 66, new DateTime(2023, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7466), 4, (byte)1 },
                    { 131, 50, new DateTime(2024, 3, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7469), 2, (byte)1 },
                    { 132, 99, new DateTime(2023, 11, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7472), 6, (byte)1 },
                    { 133, 66, new DateTime(2023, 5, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7479), 2, (byte)1 },
                    { 134, 89, new DateTime(2023, 7, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7482), 4, (byte)1 },
                    { 135, 6, new DateTime(2023, 2, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7486), 1, (byte)0 },
                    { 136, 29, new DateTime(2024, 3, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7489), 6, (byte)2 },
                    { 137, 15, new DateTime(2023, 10, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7495), 1, (byte)1 },
                    { 138, 27, new DateTime(2023, 7, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7499), 3, (byte)0 },
                    { 139, 11, new DateTime(2024, 1, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7503), 1, (byte)1 },
                    { 140, 75, new DateTime(2022, 10, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7507), 5, (byte)1 },
                    { 141, 30, new DateTime(2022, 9, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7513), 2, (byte)1 },
                    { 142, 65, new DateTime(2023, 2, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7516), 6, (byte)1 },
                    { 143, 82, new DateTime(2022, 12, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7520), 6, (byte)1 },
                    { 144, 54, new DateTime(2023, 5, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7523), 6, (byte)1 },
                    { 145, 99, new DateTime(2024, 2, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7529), 4, (byte)1 },
                    { 146, 47, new DateTime(2022, 10, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7533), 4, (byte)1 },
                    { 147, 91, new DateTime(2024, 1, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7536), 1, (byte)0 },
                    { 148, 4, new DateTime(2023, 7, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7540), 5, (byte)1 },
                    { 149, 79, new DateTime(2024, 2, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7545), 3, (byte)1 },
                    { 150, 8, new DateTime(2024, 1, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7549), 4, (byte)2 },
                    { 151, 83, new DateTime(2024, 2, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7552), 5, (byte)1 },
                    { 152, 60, new DateTime(2022, 11, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7556), 3, (byte)1 },
                    { 153, 43, new DateTime(2023, 9, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7561), 6, (byte)1 },
                    { 154, 38, new DateTime(2023, 2, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7565), 4, (byte)1 },
                    { 155, 64, new DateTime(2022, 10, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7569), 4, (byte)2 },
                    { 156, 19, new DateTime(2024, 3, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7573), 1, (byte)0 },
                    { 157, 73, new DateTime(2024, 3, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7579), 6, (byte)1 },
                    { 158, 46, new DateTime(2023, 2, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7582), 6, (byte)0 },
                    { 159, 75, new DateTime(2023, 11, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7614), 2, (byte)1 },
                    { 160, 69, new DateTime(2023, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7618), 1, (byte)1 },
                    { 161, 53, new DateTime(2023, 5, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7624), 6, (byte)1 },
                    { 162, 100, new DateTime(2023, 6, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7628), 3, (byte)1 },
                    { 163, 56, new DateTime(2022, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7631), 2, (byte)1 },
                    { 164, 96, new DateTime(2023, 1, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7634), 2, (byte)1 },
                    { 165, 36, new DateTime(2024, 2, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7640), 2, (byte)1 },
                    { 166, 65, new DateTime(2023, 11, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7644), 2, (byte)0 },
                    { 167, 18, new DateTime(2022, 11, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7647), 4, (byte)1 },
                    { 168, 98, new DateTime(2023, 1, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7651), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 169, 76, new DateTime(2023, 2, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7656), 2, (byte)1 },
                    { 170, 65, new DateTime(2023, 6, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7660), 2, (byte)1 },
                    { 171, 59, new DateTime(2023, 5, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7664), 2, (byte)1 },
                    { 172, 51, new DateTime(2022, 10, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7667), 6, (byte)1 },
                    { 173, 81, new DateTime(2023, 11, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7673), 6, (byte)0 },
                    { 174, 74, new DateTime(2023, 5, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7677), 3, (byte)1 },
                    { 175, 90, new DateTime(2023, 1, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7680), 5, (byte)2 },
                    { 176, 35, new DateTime(2023, 1, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7684), 3, (byte)1 },
                    { 177, 10, new DateTime(2022, 9, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7689), 6, (byte)1 },
                    { 178, 2, new DateTime(2023, 4, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7693), 5, (byte)1 },
                    { 179, 80, new DateTime(2022, 11, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7697), 5, (byte)1 },
                    { 180, 42, new DateTime(2023, 12, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7700), 4, (byte)1 },
                    { 181, 24, new DateTime(2023, 3, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7706), 1, (byte)0 },
                    { 182, 96, new DateTime(2022, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7710), 2, (byte)1 },
                    { 183, 44, new DateTime(2023, 6, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7714), 5, (byte)1 },
                    { 184, 50, new DateTime(2022, 10, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7718), 2, (byte)1 },
                    { 185, 19, new DateTime(2022, 8, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7724), 3, (byte)0 },
                    { 186, 2, new DateTime(2023, 10, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7728), 6, (byte)1 },
                    { 187, 66, new DateTime(2022, 12, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7731), 4, (byte)1 },
                    { 188, 79, new DateTime(2023, 3, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7735), 2, (byte)0 },
                    { 189, 46, new DateTime(2024, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7741), 6, (byte)1 },
                    { 190, 20, new DateTime(2023, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7744), 1, (byte)1 },
                    { 191, 57, new DateTime(2022, 11, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7748), 1, (byte)1 },
                    { 192, 95, new DateTime(2023, 10, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7751), 5, (byte)1 },
                    { 193, 33, new DateTime(2023, 12, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7757), 6, (byte)1 },
                    { 194, 40, new DateTime(2023, 5, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7760), 6, (byte)1 },
                    { 195, 67, new DateTime(2022, 11, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7764), 3, (byte)1 },
                    { 196, 91, new DateTime(2022, 11, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7767), 3, (byte)2 },
                    { 197, 73, new DateTime(2023, 12, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7773), 5, (byte)1 },
                    { 198, 5, new DateTime(2023, 3, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7777), 1, (byte)1 },
                    { 199, 44, new DateTime(2022, 9, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7780), 6, (byte)1 },
                    { 200, 27, new DateTime(2022, 11, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7784), 4, (byte)1 },
                    { 201, 74, new DateTime(2022, 8, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7790), 2, (byte)1 },
                    { 202, 49, new DateTime(2023, 1, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7793), 6, (byte)1 },
                    { 203, 3, new DateTime(2023, 7, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7797), 2, (byte)0 },
                    { 204, 75, new DateTime(2024, 2, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7801), 3, (byte)0 },
                    { 205, 75, new DateTime(2024, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7806), 5, (byte)1 },
                    { 206, 24, new DateTime(2023, 11, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7810), 2, (byte)0 },
                    { 207, 103, new DateTime(2023, 9, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7813), 3, (byte)1 },
                    { 208, 70, new DateTime(2024, 2, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7817), 6, (byte)1 },
                    { 209, 59, new DateTime(2023, 11, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7823), 5, (byte)2 },
                    { 210, 52, new DateTime(2023, 11, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7827), 4, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 211, 96, new DateTime(2022, 9, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7830), 6, (byte)0 },
                    { 212, 93, new DateTime(2023, 12, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7834), 3, (byte)1 },
                    { 213, 87, new DateTime(2024, 2, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7839), 3, (byte)1 },
                    { 214, 20, new DateTime(2022, 12, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7843), 4, (byte)1 },
                    { 215, 50, new DateTime(2023, 3, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7846), 2, (byte)1 },
                    { 216, 64, new DateTime(2022, 9, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7850), 6, (byte)1 },
                    { 217, 59, new DateTime(2023, 3, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7856), 3, (byte)1 },
                    { 218, 73, new DateTime(2024, 2, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7859), 1, (byte)1 },
                    { 219, 93, new DateTime(2023, 3, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7863), 3, (byte)0 },
                    { 220, 28, new DateTime(2023, 8, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7866), 3, (byte)1 },
                    { 221, 45, new DateTime(2022, 12, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7872), 2, (byte)1 },
                    { 222, 75, new DateTime(2023, 3, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7876), 6, (byte)1 },
                    { 223, 29, new DateTime(2023, 9, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7908), 6, (byte)1 },
                    { 224, 22, new DateTime(2023, 5, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7912), 6, (byte)1 },
                    { 225, 82, new DateTime(2022, 12, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7918), 5, (byte)1 },
                    { 226, 77, new DateTime(2022, 10, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7921), 4, (byte)1 },
                    { 227, 33, new DateTime(2024, 2, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7925), 4, (byte)1 },
                    { 228, 62, new DateTime(2023, 12, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7929), 6, (byte)1 },
                    { 229, 97, new DateTime(2023, 11, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7938), 2, (byte)1 },
                    { 230, 2, new DateTime(2023, 11, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7942), 6, (byte)1 },
                    { 231, 104, new DateTime(2023, 8, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7946), 5, (byte)1 },
                    { 232, 34, new DateTime(2023, 2, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7949), 6, (byte)0 },
                    { 233, 23, new DateTime(2022, 11, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7955), 6, (byte)1 },
                    { 234, 29, new DateTime(2023, 3, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7959), 6, (byte)2 },
                    { 235, 82, new DateTime(2023, 3, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7963), 3, (byte)1 },
                    { 236, 2, new DateTime(2022, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7966), 2, (byte)1 },
                    { 237, 44, new DateTime(2024, 2, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7972), 2, (byte)1 },
                    { 238, 10, new DateTime(2023, 4, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7976), 6, (byte)1 },
                    { 239, 60, new DateTime(2023, 8, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7979), 1, (byte)1 },
                    { 240, 51, new DateTime(2023, 8, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7983), 6, (byte)0 },
                    { 241, 83, new DateTime(2024, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7989), 2, (byte)1 },
                    { 242, 77, new DateTime(2022, 10, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7993), 5, (byte)1 },
                    { 243, 75, new DateTime(2022, 9, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(7996), 5, (byte)1 },
                    { 244, 70, new DateTime(2023, 1, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8000), 4, (byte)1 },
                    { 245, 47, new DateTime(2023, 1, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8006), 6, (byte)1 },
                    { 246, 11, new DateTime(2022, 9, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8009), 6, (byte)1 },
                    { 247, 5, new DateTime(2023, 7, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8013), 3, (byte)1 },
                    { 248, 80, new DateTime(2022, 8, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8016), 6, (byte)1 },
                    { 249, 98, new DateTime(2023, 6, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8022), 4, (byte)1 },
                    { 250, 70, new DateTime(2023, 2, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8026), 4, (byte)1 },
                    { 251, 54, new DateTime(2023, 7, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8030), 4, (byte)1 },
                    { 252, 65, new DateTime(2024, 1, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8033), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 253, 33, new DateTime(2023, 7, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8039), 3, (byte)1 },
                    { 254, 95, new DateTime(2023, 9, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8042), 4, (byte)1 },
                    { 255, 91, new DateTime(2023, 4, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8045), 4, (byte)1 },
                    { 256, 46, new DateTime(2024, 2, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8049), 4, (byte)1 },
                    { 257, 37, new DateTime(2024, 1, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8055), 3, (byte)1 },
                    { 258, 76, new DateTime(2023, 5, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8089), 2, (byte)1 },
                    { 259, 20, new DateTime(2024, 1, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8092), 2, (byte)1 },
                    { 260, 26, new DateTime(2023, 1, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8096), 4, (byte)1 },
                    { 261, 80, new DateTime(2023, 8, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8102), 5, (byte)1 },
                    { 262, 73, new DateTime(2023, 6, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8106), 4, (byte)0 },
                    { 263, 57, new DateTime(2023, 2, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8109), 3, (byte)1 },
                    { 264, 26, new DateTime(2024, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8112), 2, (byte)1 },
                    { 265, 73, new DateTime(2024, 2, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8118), 6, (byte)1 },
                    { 266, 7, new DateTime(2023, 8, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8122), 6, (byte)1 },
                    { 267, 78, new DateTime(2023, 7, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8125), 4, (byte)1 },
                    { 268, 45, new DateTime(2023, 3, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8129), 4, (byte)1 },
                    { 269, 44, new DateTime(2024, 2, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8135), 6, (byte)0 },
                    { 270, 59, new DateTime(2023, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8138), 4, (byte)1 },
                    { 271, 31, new DateTime(2022, 12, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8142), 5, (byte)0 },
                    { 272, 16, new DateTime(2023, 8, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8146), 3, (byte)1 },
                    { 273, 20, new DateTime(2023, 3, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8152), 2, (byte)1 },
                    { 274, 27, new DateTime(2023, 3, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8156), 3, (byte)1 },
                    { 275, 18, new DateTime(2023, 1, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8159), 6, (byte)1 },
                    { 276, 106, new DateTime(2022, 11, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8163), 5, (byte)2 },
                    { 277, 39, new DateTime(2023, 2, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8168), 3, (byte)1 },
                    { 278, 103, new DateTime(2023, 11, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8172), 3, (byte)0 },
                    { 279, 103, new DateTime(2024, 3, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8176), 4, (byte)0 },
                    { 280, 34, new DateTime(2022, 10, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8179), 6, (byte)1 },
                    { 281, 93, new DateTime(2023, 12, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8185), 6, (byte)1 },
                    { 282, 59, new DateTime(2023, 10, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8188), 2, (byte)1 },
                    { 283, 28, new DateTime(2023, 4, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8192), 5, (byte)1 },
                    { 284, 79, new DateTime(2024, 2, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8196), 3, (byte)1 },
                    { 285, 5, new DateTime(2022, 9, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8201), 6, (byte)1 },
                    { 286, 97, new DateTime(2023, 4, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8205), 5, (byte)1 },
                    { 287, 105, new DateTime(2023, 4, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8208), 3, (byte)1 },
                    { 288, 38, new DateTime(2023, 8, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8212), 3, (byte)1 },
                    { 289, 68, new DateTime(2024, 2, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8217), 4, (byte)1 },
                    { 290, 85, new DateTime(2023, 1, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8221), 2, (byte)1 },
                    { 291, 89, new DateTime(2023, 7, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8225), 5, (byte)1 },
                    { 292, 19, new DateTime(2023, 6, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8228), 6, (byte)1 },
                    { 293, 13, new DateTime(2023, 9, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8234), 1, (byte)0 },
                    { 294, 64, new DateTime(2023, 4, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8238), 2, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 295, 66, new DateTime(2024, 2, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8241), 3, (byte)1 },
                    { 296, 25, new DateTime(2023, 3, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8245), 5, (byte)1 },
                    { 297, 96, new DateTime(2023, 8, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8252), 4, (byte)1 },
                    { 298, 82, new DateTime(2023, 1, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8255), 3, (byte)2 },
                    { 299, 65, new DateTime(2023, 9, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8259), 6, (byte)1 },
                    { 300, 76, new DateTime(2022, 12, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8263), 3, (byte)0 },
                    { 301, 63, new DateTime(2023, 9, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8268), 6, (byte)2 },
                    { 302, 97, new DateTime(2023, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8272), 1, (byte)1 },
                    { 303, 70, new DateTime(2023, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8275), 1, (byte)1 },
                    { 304, 10, new DateTime(2022, 12, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8279), 4, (byte)1 },
                    { 305, 66, new DateTime(2023, 3, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8285), 4, (byte)1 },
                    { 306, 85, new DateTime(2024, 1, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8288), 1, (byte)1 },
                    { 307, 72, new DateTime(2023, 10, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8292), 3, (byte)1 },
                    { 308, 101, new DateTime(2023, 5, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8295), 3, (byte)1 },
                    { 309, 38, new DateTime(2023, 4, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8301), 1, (byte)1 },
                    { 310, 6, new DateTime(2023, 5, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8305), 1, (byte)1 },
                    { 311, 6, new DateTime(2023, 5, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8309), 6, (byte)1 },
                    { 312, 89, new DateTime(2023, 11, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8312), 6, (byte)0 },
                    { 313, 79, new DateTime(2023, 3, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8318), 4, (byte)1 },
                    { 314, 54, new DateTime(2023, 7, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8321), 4, (byte)1 },
                    { 315, 64, new DateTime(2023, 8, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8325), 3, (byte)1 },
                    { 316, 17, new DateTime(2023, 2, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8328), 2, (byte)1 },
                    { 317, 34, new DateTime(2023, 2, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8334), 3, (byte)1 },
                    { 318, 101, new DateTime(2023, 7, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8384), 6, (byte)1 },
                    { 319, 65, new DateTime(2023, 3, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8389), 3, (byte)1 },
                    { 320, 92, new DateTime(2024, 1, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8393), 1, (byte)1 },
                    { 321, 90, new DateTime(2024, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8398), 6, (byte)1 },
                    { 322, 87, new DateTime(2023, 6, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8402), 3, (byte)1 },
                    { 323, 97, new DateTime(2023, 10, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8405), 2, (byte)0 },
                    { 324, 69, new DateTime(2022, 8, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8409), 1, (byte)1 },
                    { 325, 34, new DateTime(2022, 8, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8415), 2, (byte)1 },
                    { 326, 58, new DateTime(2023, 2, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8418), 1, (byte)1 },
                    { 327, 5, new DateTime(2022, 8, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8422), 3, (byte)0 },
                    { 328, 101, new DateTime(2023, 2, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8426), 3, (byte)1 },
                    { 329, 15, new DateTime(2024, 2, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8432), 5, (byte)1 },
                    { 330, 29, new DateTime(2023, 10, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8435), 3, (byte)1 },
                    { 331, 14, new DateTime(2023, 5, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8439), 4, (byte)1 },
                    { 332, 35, new DateTime(2022, 10, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8442), 1, (byte)1 },
                    { 333, 19, new DateTime(2023, 12, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8447), 3, (byte)1 },
                    { 334, 19, new DateTime(2023, 1, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8451), 2, (byte)1 },
                    { 335, 53, new DateTime(2023, 6, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8455), 4, (byte)1 },
                    { 336, 61, new DateTime(2022, 11, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8458), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 337, 92, new DateTime(2024, 2, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8464), 6, (byte)1 },
                    { 338, 57, new DateTime(2023, 12, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8467), 3, (byte)0 },
                    { 339, 95, new DateTime(2023, 7, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8471), 3, (byte)1 },
                    { 340, 14, new DateTime(2023, 2, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8474), 3, (byte)1 },
                    { 341, 46, new DateTime(2024, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8480), 3, (byte)1 },
                    { 342, 14, new DateTime(2022, 8, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8484), 5, (byte)1 },
                    { 343, 61, new DateTime(2023, 1, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8487), 3, (byte)1 },
                    { 344, 49, new DateTime(2023, 5, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8491), 2, (byte)1 },
                    { 345, 99, new DateTime(2023, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8496), 5, (byte)1 },
                    { 346, 60, new DateTime(2023, 1, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8499), 4, (byte)1 },
                    { 347, 104, new DateTime(2023, 3, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8503), 1, (byte)1 },
                    { 348, 75, new DateTime(2022, 10, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8507), 5, (byte)1 },
                    { 349, 62, new DateTime(2022, 8, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8513), 3, (byte)1 },
                    { 350, 86, new DateTime(2022, 10, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8516), 2, (byte)1 },
                    { 351, 78, new DateTime(2024, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8520), 5, (byte)1 },
                    { 352, 69, new DateTime(2023, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8523), 2, (byte)1 },
                    { 353, 74, new DateTime(2023, 12, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8529), 2, (byte)1 },
                    { 354, 65, new DateTime(2024, 1, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8533), 4, (byte)1 },
                    { 355, 67, new DateTime(2022, 10, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8536), 3, (byte)1 },
                    { 356, 65, new DateTime(2023, 6, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8540), 6, (byte)1 },
                    { 357, 19, new DateTime(2024, 3, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8545), 5, (byte)1 },
                    { 358, 25, new DateTime(2023, 1, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8549), 3, (byte)1 },
                    { 359, 38, new DateTime(2022, 11, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8553), 5, (byte)1 },
                    { 360, 40, new DateTime(2023, 4, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8556), 2, (byte)0 },
                    { 361, 20, new DateTime(2023, 10, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8562), 4, (byte)1 },
                    { 362, 42, new DateTime(2022, 10, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8565), 4, (byte)1 },
                    { 363, 20, new DateTime(2023, 8, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8569), 6, (byte)1 },
                    { 364, 45, new DateTime(2023, 7, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8572), 6, (byte)1 },
                    { 365, 101, new DateTime(2022, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8578), 1, (byte)1 },
                    { 366, 30, new DateTime(2024, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8581), 4, (byte)1 },
                    { 367, 63, new DateTime(2023, 7, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8585), 1, (byte)1 },
                    { 368, 18, new DateTime(2023, 3, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8589), 2, (byte)0 },
                    { 369, 80, new DateTime(2023, 7, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8594), 5, (byte)1 },
                    { 370, 55, new DateTime(2023, 7, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8598), 3, (byte)1 },
                    { 371, 97, new DateTime(2022, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8601), 3, (byte)0 },
                    { 372, 5, new DateTime(2023, 5, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8605), 6, (byte)1 },
                    { 373, 35, new DateTime(2022, 8, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8611), 5, (byte)0 },
                    { 374, 20, new DateTime(2022, 8, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8615), 1, (byte)1 },
                    { 375, 51, new DateTime(2022, 10, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8618), 2, (byte)1 },
                    { 376, 39, new DateTime(2023, 5, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8622), 5, (byte)1 },
                    { 377, 84, new DateTime(2024, 3, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8628), 1, (byte)1 },
                    { 378, 34, new DateTime(2023, 10, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8631), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 379, 79, new DateTime(2023, 9, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8635), 3, (byte)1 },
                    { 380, 78, new DateTime(2023, 3, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8638), 6, (byte)1 },
                    { 381, 32, new DateTime(2022, 12, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8644), 1, (byte)1 },
                    { 382, 99, new DateTime(2022, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8676), 1, (byte)1 },
                    { 383, 4, new DateTime(2024, 1, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8680), 4, (byte)1 },
                    { 384, 17, new DateTime(2023, 4, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8684), 4, (byte)1 },
                    { 385, 29, new DateTime(2022, 12, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8690), 6, (byte)1 },
                    { 386, 23, new DateTime(2023, 8, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8694), 3, (byte)1 },
                    { 387, 91, new DateTime(2023, 11, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8697), 3, (byte)2 },
                    { 388, 7, new DateTime(2023, 8, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8701), 6, (byte)1 },
                    { 389, 30, new DateTime(2023, 8, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8706), 1, (byte)1 },
                    { 390, 70, new DateTime(2023, 5, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8710), 4, (byte)1 },
                    { 391, 81, new DateTime(2022, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8713), 4, (byte)1 },
                    { 392, 40, new DateTime(2024, 2, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8717), 4, (byte)1 },
                    { 393, 6, new DateTime(2022, 12, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8723), 5, (byte)0 },
                    { 394, 24, new DateTime(2022, 12, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8726), 1, (byte)1 },
                    { 395, 100, new DateTime(2024, 2, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8730), 1, (byte)1 },
                    { 396, 102, new DateTime(2023, 6, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8733), 3, (byte)1 },
                    { 397, 7, new DateTime(2024, 1, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8739), 4, (byte)1 },
                    { 398, 75, new DateTime(2023, 1, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8742), 6, (byte)1 },
                    { 399, 2, new DateTime(2024, 2, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8746), 2, (byte)1 },
                    { 400, 73, new DateTime(2023, 1, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8749), 5, (byte)1 },
                    { 401, 91, new DateTime(2023, 7, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8755), 6, (byte)1 },
                    { 402, 17, new DateTime(2022, 10, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8759), 2, (byte)1 },
                    { 403, 3, new DateTime(2022, 9, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8762), 4, (byte)2 },
                    { 404, 26, new DateTime(2024, 1, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8766), 1, (byte)1 },
                    { 405, 59, new DateTime(2023, 3, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8772), 5, (byte)1 },
                    { 406, 68, new DateTime(2024, 3, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8775), 4, (byte)1 },
                    { 407, 12, new DateTime(2022, 9, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8779), 6, (byte)1 },
                    { 408, 96, new DateTime(2023, 9, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8783), 6, (byte)1 },
                    { 409, 38, new DateTime(2023, 6, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8788), 2, (byte)1 },
                    { 410, 62, new DateTime(2024, 1, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8792), 2, (byte)1 },
                    { 411, 43, new DateTime(2024, 2, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8795), 2, (byte)1 },
                    { 412, 8, new DateTime(2023, 1, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8799), 1, (byte)1 },
                    { 413, 72, new DateTime(2023, 4, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8804), 3, (byte)1 },
                    { 414, 92, new DateTime(2023, 12, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8808), 3, (byte)1 },
                    { 415, 55, new DateTime(2023, 9, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8812), 4, (byte)1 },
                    { 416, 19, new DateTime(2023, 5, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8815), 1, (byte)1 },
                    { 417, 106, new DateTime(2023, 3, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8821), 4, (byte)1 },
                    { 418, 86, new DateTime(2024, 2, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8824), 1, (byte)1 },
                    { 419, 82, new DateTime(2024, 3, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8828), 3, (byte)0 },
                    { 420, 87, new DateTime(2023, 8, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8832), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 421, 27, new DateTime(2024, 3, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8838), 2, (byte)1 },
                    { 422, 78, new DateTime(2023, 12, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8841), 4, (byte)1 },
                    { 423, 93, new DateTime(2023, 9, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8845), 5, (byte)1 },
                    { 424, 86, new DateTime(2023, 7, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8849), 2, (byte)1 },
                    { 425, 74, new DateTime(2023, 12, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8855), 4, (byte)1 },
                    { 426, 61, new DateTime(2023, 8, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8858), 1, (byte)1 },
                    { 427, 26, new DateTime(2022, 11, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8862), 2, (byte)2 },
                    { 428, 58, new DateTime(2024, 1, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8865), 6, (byte)1 },
                    { 429, 50, new DateTime(2022, 11, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8871), 2, (byte)1 },
                    { 430, 12, new DateTime(2023, 6, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8874), 4, (byte)1 },
                    { 431, 37, new DateTime(2022, 9, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8878), 1, (byte)2 },
                    { 432, 67, new DateTime(2024, 3, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8882), 3, (byte)1 },
                    { 433, 65, new DateTime(2023, 12, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8887), 5, (byte)1 },
                    { 434, 56, new DateTime(2022, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8891), 6, (byte)0 },
                    { 435, 46, new DateTime(2023, 8, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8895), 5, (byte)1 },
                    { 436, 54, new DateTime(2023, 11, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8898), 1, (byte)0 },
                    { 437, 19, new DateTime(2024, 3, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8904), 1, (byte)1 },
                    { 438, 52, new DateTime(2024, 1, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8908), 2, (byte)1 },
                    { 439, 36, new DateTime(2022, 9, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8911), 1, (byte)1 },
                    { 440, 51, new DateTime(2023, 7, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8915), 5, (byte)0 },
                    { 441, 62, new DateTime(2023, 8, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8921), 6, (byte)1 },
                    { 442, 98, new DateTime(2024, 1, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8925), 6, (byte)2 },
                    { 443, 101, new DateTime(2023, 12, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8928), 3, (byte)0 },
                    { 444, 101, new DateTime(2024, 1, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8932), 1, (byte)1 },
                    { 445, 34, new DateTime(2023, 12, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8938), 5, (byte)2 },
                    { 446, 57, new DateTime(2023, 10, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8970), 3, (byte)1 },
                    { 447, 73, new DateTime(2024, 3, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8974), 1, (byte)2 },
                    { 448, 5, new DateTime(2023, 4, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8978), 5, (byte)1 },
                    { 449, 76, new DateTime(2023, 5, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8984), 1, (byte)1 },
                    { 450, 84, new DateTime(2023, 3, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8987), 1, (byte)1 },
                    { 451, 83, new DateTime(2024, 2, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8991), 1, (byte)1 },
                    { 452, 56, new DateTime(2022, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(8994), 5, (byte)1 },
                    { 453, 105, new DateTime(2023, 9, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9000), 3, (byte)1 },
                    { 454, 56, new DateTime(2023, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9003), 2, (byte)1 },
                    { 455, 41, new DateTime(2023, 1, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9007), 6, (byte)1 },
                    { 456, 74, new DateTime(2023, 9, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9010), 2, (byte)1 },
                    { 457, 80, new DateTime(2023, 4, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9016), 5, (byte)1 },
                    { 458, 68, new DateTime(2023, 12, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9019), 6, (byte)1 },
                    { 459, 52, new DateTime(2023, 3, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9023), 6, (byte)1 },
                    { 460, 66, new DateTime(2023, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9026), 6, (byte)1 },
                    { 461, 35, new DateTime(2023, 7, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9032), 1, (byte)1 },
                    { 462, 88, new DateTime(2023, 8, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9036), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 463, 42, new DateTime(2023, 10, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9040), 2, (byte)1 },
                    { 464, 58, new DateTime(2023, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9044), 1, (byte)0 },
                    { 465, 91, new DateTime(2023, 5, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9049), 2, (byte)1 },
                    { 466, 62, new DateTime(2022, 12, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9053), 2, (byte)1 },
                    { 467, 81, new DateTime(2024, 2, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9056), 1, (byte)1 },
                    { 468, 29, new DateTime(2024, 3, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9060), 3, (byte)1 },
                    { 469, 90, new DateTime(2023, 9, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9066), 6, (byte)1 },
                    { 470, 69, new DateTime(2022, 10, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9069), 1, (byte)1 },
                    { 471, 71, new DateTime(2023, 1, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9073), 4, (byte)1 },
                    { 472, 75, new DateTime(2022, 11, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9076), 3, (byte)1 },
                    { 473, 15, new DateTime(2023, 8, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9082), 3, (byte)1 },
                    { 474, 103, new DateTime(2023, 7, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9085), 1, (byte)1 },
                    { 475, 37, new DateTime(2022, 9, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9089), 3, (byte)1 },
                    { 476, 63, new DateTime(2023, 6, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9093), 3, (byte)2 },
                    { 477, 61, new DateTime(2023, 10, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9098), 1, (byte)1 },
                    { 478, 73, new DateTime(2023, 3, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9102), 2, (byte)1 },
                    { 479, 10, new DateTime(2023, 9, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9105), 5, (byte)1 },
                    { 480, 10, new DateTime(2022, 9, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9109), 2, (byte)1 },
                    { 481, 93, new DateTime(2023, 10, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9115), 4, (byte)1 },
                    { 482, 14, new DateTime(2023, 4, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9118), 5, (byte)1 },
                    { 483, 17, new DateTime(2023, 7, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9122), 3, (byte)1 },
                    { 484, 17, new DateTime(2023, 11, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9125), 4, (byte)1 },
                    { 485, 63, new DateTime(2024, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9132), 1, (byte)1 },
                    { 486, 61, new DateTime(2022, 10, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9135), 5, (byte)1 },
                    { 487, 37, new DateTime(2022, 9, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9139), 6, (byte)1 },
                    { 488, 30, new DateTime(2023, 2, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9142), 2, (byte)1 },
                    { 489, 3, new DateTime(2023, 7, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9148), 5, (byte)1 },
                    { 490, 38, new DateTime(2022, 9, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9151), 3, (byte)1 },
                    { 491, 97, new DateTime(2023, 8, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9155), 1, (byte)1 },
                    { 492, 96, new DateTime(2023, 6, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9159), 6, (byte)1 },
                    { 493, 68, new DateTime(2024, 2, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9164), 1, (byte)1 },
                    { 494, 84, new DateTime(2023, 5, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9168), 2, (byte)1 },
                    { 495, 50, new DateTime(2023, 6, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9172), 1, (byte)1 },
                    { 496, 31, new DateTime(2023, 4, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9175), 5, (byte)1 },
                    { 497, 82, new DateTime(2023, 1, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9181), 3, (byte)1 },
                    { 498, 63, new DateTime(2022, 11, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9184), 5, (byte)1 },
                    { 499, 97, new DateTime(2023, 6, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9188), 5, (byte)1 },
                    { 500, 40, new DateTime(2022, 11, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9191), 1, (byte)0 },
                    { 501, 89, new DateTime(2022, 10, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9197), 5, (byte)1 },
                    { 502, 88, new DateTime(2023, 3, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9201), 1, (byte)1 },
                    { 503, 92, new DateTime(2023, 3, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9204), 2, (byte)1 },
                    { 504, 48, new DateTime(2023, 2, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9207), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 505, 92, new DateTime(2022, 8, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9213), 3, (byte)1 },
                    { 506, 98, new DateTime(2023, 3, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9217), 2, (byte)1 },
                    { 507, 6, new DateTime(2022, 9, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9220), 6, (byte)1 },
                    { 508, 62, new DateTime(2022, 11, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9224), 3, (byte)1 },
                    { 509, 58, new DateTime(2023, 10, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9230), 3, (byte)1 },
                    { 510, 12, new DateTime(2022, 9, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9260), 5, (byte)1 },
                    { 511, 71, new DateTime(2023, 3, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9264), 2, (byte)1 },
                    { 512, 106, new DateTime(2023, 8, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9268), 1, (byte)1 },
                    { 513, 74, new DateTime(2023, 10, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9274), 3, (byte)1 },
                    { 514, 94, new DateTime(2023, 8, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9320), 1, (byte)1 },
                    { 515, 51, new DateTime(2023, 7, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9323), 5, (byte)1 },
                    { 516, 55, new DateTime(2024, 3, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9327), 4, (byte)1 },
                    { 517, 36, new DateTime(2022, 8, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9334), 1, (byte)1 },
                    { 518, 95, new DateTime(2023, 12, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9338), 5, (byte)1 },
                    { 519, 35, new DateTime(2024, 3, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9341), 1, (byte)1 },
                    { 520, 56, new DateTime(2022, 12, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9345), 4, (byte)0 },
                    { 521, 13, new DateTime(2022, 12, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9351), 6, (byte)0 },
                    { 522, 74, new DateTime(2023, 10, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9355), 2, (byte)1 },
                    { 523, 34, new DateTime(2023, 3, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9359), 4, (byte)1 },
                    { 524, 7, new DateTime(2023, 7, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9363), 5, (byte)1 },
                    { 525, 44, new DateTime(2024, 3, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9370), 3, (byte)0 },
                    { 526, 42, new DateTime(2022, 10, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9373), 6, (byte)1 },
                    { 527, 97, new DateTime(2023, 2, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9377), 5, (byte)1 },
                    { 528, 20, new DateTime(2023, 1, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9380), 3, (byte)1 },
                    { 529, 52, new DateTime(2023, 10, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9386), 1, (byte)1 },
                    { 530, 99, new DateTime(2023, 8, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9390), 5, (byte)1 },
                    { 531, 97, new DateTime(2023, 2, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9394), 1, (byte)1 },
                    { 532, 16, new DateTime(2023, 5, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9397), 6, (byte)1 },
                    { 533, 14, new DateTime(2023, 4, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9403), 3, (byte)1 },
                    { 534, 97, new DateTime(2023, 10, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9406), 1, (byte)1 },
                    { 535, 35, new DateTime(2023, 9, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9410), 2, (byte)1 },
                    { 536, 70, new DateTime(2023, 1, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9414), 3, (byte)1 },
                    { 537, 105, new DateTime(2023, 10, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9420), 5, (byte)1 },
                    { 538, 59, new DateTime(2023, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9423), 3, (byte)1 },
                    { 539, 92, new DateTime(2024, 1, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9426), 4, (byte)1 },
                    { 540, 26, new DateTime(2023, 10, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9430), 6, (byte)1 },
                    { 541, 104, new DateTime(2023, 2, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9435), 1, (byte)0 },
                    { 542, 75, new DateTime(2022, 11, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9440), 6, (byte)1 },
                    { 543, 43, new DateTime(2023, 3, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9443), 5, (byte)1 },
                    { 544, 8, new DateTime(2023, 9, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9447), 4, (byte)1 },
                    { 545, 52, new DateTime(2022, 11, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9454), 2, (byte)0 },
                    { 546, 42, new DateTime(2023, 6, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9457), 5, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 547, 57, new DateTime(2022, 12, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9461), 6, (byte)1 },
                    { 548, 93, new DateTime(2023, 11, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9464), 5, (byte)1 },
                    { 549, 49, new DateTime(2022, 11, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9470), 2, (byte)0 },
                    { 550, 63, new DateTime(2023, 4, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9474), 2, (byte)1 },
                    { 551, 31, new DateTime(2022, 12, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9477), 5, (byte)1 },
                    { 552, 58, new DateTime(2023, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9481), 4, (byte)1 },
                    { 553, 7, new DateTime(2023, 2, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9486), 1, (byte)1 },
                    { 554, 59, new DateTime(2023, 5, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9490), 2, (byte)1 },
                    { 555, 50, new DateTime(2024, 3, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9494), 4, (byte)1 },
                    { 556, 41, new DateTime(2023, 5, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9497), 1, (byte)1 },
                    { 557, 80, new DateTime(2023, 12, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9503), 6, (byte)1 },
                    { 558, 64, new DateTime(2023, 12, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9507), 5, (byte)1 },
                    { 559, 94, new DateTime(2024, 2, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9510), 6, (byte)1 },
                    { 560, 74, new DateTime(2024, 1, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9514), 1, (byte)1 },
                    { 561, 102, new DateTime(2022, 8, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9520), 3, (byte)0 },
                    { 562, 78, new DateTime(2023, 7, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9523), 1, (byte)1 },
                    { 563, 82, new DateTime(2023, 10, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9527), 2, (byte)1 },
                    { 564, 11, new DateTime(2022, 9, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9531), 1, (byte)0 },
                    { 565, 38, new DateTime(2023, 10, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9537), 3, (byte)1 },
                    { 566, 27, new DateTime(2023, 3, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9540), 5, (byte)1 },
                    { 567, 75, new DateTime(2023, 2, 22, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9544), 5, (byte)1 },
                    { 568, 15, new DateTime(2024, 3, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9547), 5, (byte)1 },
                    { 569, 48, new DateTime(2022, 12, 10, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9553), 4, (byte)1 },
                    { 570, 67, new DateTime(2022, 10, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9556), 6, (byte)1 },
                    { 571, 5, new DateTime(2023, 12, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9560), 4, (byte)0 },
                    { 572, 39, new DateTime(2023, 4, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9564), 4, (byte)1 },
                    { 573, 76, new DateTime(2022, 11, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9569), 5, (byte)1 },
                    { 574, 9, new DateTime(2023, 7, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9602), 5, (byte)1 },
                    { 575, 77, new DateTime(2024, 2, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9606), 1, (byte)1 },
                    { 576, 56, new DateTime(2023, 9, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9610), 4, (byte)1 },
                    { 577, 52, new DateTime(2022, 11, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9616), 3, (byte)1 },
                    { 578, 27, new DateTime(2023, 10, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9620), 2, (byte)1 },
                    { 579, 103, new DateTime(2022, 9, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9623), 1, (byte)1 },
                    { 580, 24, new DateTime(2023, 12, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9627), 6, (byte)0 },
                    { 581, 99, new DateTime(2024, 3, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9633), 1, (byte)1 },
                    { 582, 42, new DateTime(2023, 6, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9636), 5, (byte)1 },
                    { 583, 85, new DateTime(2023, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9640), 1, (byte)1 },
                    { 584, 47, new DateTime(2023, 3, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9644), 2, (byte)1 },
                    { 585, 97, new DateTime(2023, 9, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9650), 3, (byte)1 },
                    { 586, 95, new DateTime(2023, 6, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9653), 3, (byte)1 },
                    { 587, 103, new DateTime(2023, 8, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9656), 4, (byte)1 },
                    { 588, 102, new DateTime(2022, 11, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9660), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 589, 84, new DateTime(2024, 1, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9665), 3, (byte)1 },
                    { 590, 74, new DateTime(2023, 11, 28, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9669), 6, (byte)1 },
                    { 591, 73, new DateTime(2023, 7, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9673), 2, (byte)1 },
                    { 592, 43, new DateTime(2024, 2, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9676), 1, (byte)1 },
                    { 593, 63, new DateTime(2023, 8, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9682), 1, (byte)1 },
                    { 594, 50, new DateTime(2022, 9, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9685), 2, (byte)1 },
                    { 595, 49, new DateTime(2023, 6, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9689), 4, (byte)2 },
                    { 596, 32, new DateTime(2022, 10, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9692), 6, (byte)1 },
                    { 597, 94, new DateTime(2023, 2, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9698), 5, (byte)1 },
                    { 598, 86, new DateTime(2022, 9, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9702), 6, (byte)1 },
                    { 599, 33, new DateTime(2024, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9706), 2, (byte)1 },
                    { 600, 34, new DateTime(2024, 2, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9709), 3, (byte)1 },
                    { 601, 51, new DateTime(2024, 1, 3, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9715), 6, (byte)1 },
                    { 602, 2, new DateTime(2023, 5, 25, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9718), 6, (byte)1 },
                    { 603, 4, new DateTime(2022, 8, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9722), 3, (byte)1 },
                    { 604, 64, new DateTime(2023, 9, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9725), 5, (byte)1 },
                    { 605, 32, new DateTime(2024, 3, 16, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9731), 5, (byte)1 },
                    { 606, 14, new DateTime(2023, 10, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9735), 2, (byte)1 },
                    { 607, 84, new DateTime(2023, 12, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9738), 5, (byte)1 },
                    { 608, 99, new DateTime(2023, 11, 27, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9742), 4, (byte)1 },
                    { 609, 31, new DateTime(2023, 10, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9748), 5, (byte)1 },
                    { 610, 60, new DateTime(2023, 9, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9751), 5, (byte)1 },
                    { 611, 12, new DateTime(2023, 5, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9755), 5, (byte)1 },
                    { 612, 34, new DateTime(2022, 11, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9758), 1, (byte)1 },
                    { 613, 39, new DateTime(2023, 5, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9764), 1, (byte)1 },
                    { 614, 43, new DateTime(2023, 6, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9768), 6, (byte)1 },
                    { 615, 84, new DateTime(2024, 3, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9771), 4, (byte)1 },
                    { 616, 91, new DateTime(2022, 9, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9775), 4, (byte)1 },
                    { 617, 69, new DateTime(2023, 6, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9781), 6, (byte)2 },
                    { 618, 73, new DateTime(2023, 11, 29, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9784), 3, (byte)2 },
                    { 619, 92, new DateTime(2023, 8, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9788), 5, (byte)0 },
                    { 620, 24, new DateTime(2022, 8, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9791), 5, (byte)1 },
                    { 621, 39, new DateTime(2023, 7, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9797), 6, (byte)0 },
                    { 622, 98, new DateTime(2023, 5, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9801), 4, (byte)1 },
                    { 623, 28, new DateTime(2023, 1, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9804), 3, (byte)1 },
                    { 624, 46, new DateTime(2023, 3, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9808), 5, (byte)1 },
                    { 625, 39, new DateTime(2022, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9813), 2, (byte)1 },
                    { 626, 22, new DateTime(2023, 11, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9817), 5, (byte)1 },
                    { 627, 36, new DateTime(2023, 5, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9821), 4, (byte)1 },
                    { 628, 106, new DateTime(2023, 9, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9824), 1, (byte)1 },
                    { 629, 16, new DateTime(2023, 4, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9830), 5, (byte)1 },
                    { 630, 83, new DateTime(2023, 4, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9834), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 631, 63, new DateTime(2023, 7, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9837), 5, (byte)1 },
                    { 632, 60, new DateTime(2024, 3, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9841), 2, (byte)1 },
                    { 633, 73, new DateTime(2023, 8, 24, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9847), 4, (byte)1 },
                    { 634, 90, new DateTime(2023, 7, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9850), 4, (byte)1 },
                    { 635, 22, new DateTime(2022, 8, 13, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9854), 6, (byte)0 },
                    { 636, 15, new DateTime(2023, 8, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9858), 5, (byte)0 },
                    { 637, 23, new DateTime(2023, 2, 19, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9892), 1, (byte)0 },
                    { 638, 102, new DateTime(2023, 4, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9896), 6, (byte)1 },
                    { 639, 71, new DateTime(2022, 9, 2, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9900), 5, (byte)1 },
                    { 640, 13, new DateTime(2023, 1, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9903), 6, (byte)1 },
                    { 641, 80, new DateTime(2023, 6, 12, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9909), 6, (byte)1 },
                    { 642, 17, new DateTime(2023, 2, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9913), 3, (byte)1 },
                    { 643, 58, new DateTime(2024, 3, 4, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9916), 1, (byte)1 },
                    { 644, 23, new DateTime(2022, 8, 18, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9920), 1, (byte)2 },
                    { 645, 64, new DateTime(2022, 8, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9926), 4, (byte)1 },
                    { 646, 47, new DateTime(2023, 2, 1, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9930), 5, (byte)1 },
                    { 647, 82, new DateTime(2023, 9, 14, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9933), 4, (byte)2 },
                    { 648, 70, new DateTime(2023, 12, 7, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9937), 1, (byte)1 },
                    { 649, 84, new DateTime(2023, 11, 11, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9942), 6, (byte)1 },
                    { 650, 37, new DateTime(2022, 11, 17, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9946), 3, (byte)1 },
                    { 651, 22, new DateTime(2023, 9, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9950), 6, (byte)1 },
                    { 652, 97, new DateTime(2023, 11, 30, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9953), 1, (byte)1 },
                    { 653, 37, new DateTime(2022, 11, 8, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9959), 3, (byte)1 },
                    { 654, 83, new DateTime(2023, 11, 21, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9963), 6, (byte)1 },
                    { 655, 94, new DateTime(2023, 12, 26, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9966), 1, (byte)1 },
                    { 656, 27, new DateTime(2024, 2, 23, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9970), 2, (byte)1 },
                    { 657, 10, new DateTime(2023, 11, 15, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9976), 6, (byte)1 },
                    { 658, 67, new DateTime(2023, 5, 31, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9980), 2, (byte)1 },
                    { 659, 78, new DateTime(2023, 4, 6, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9983), 1, (byte)1 },
                    { 660, 95, new DateTime(2023, 9, 5, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9987), 4, (byte)1 },
                    { 661, 47, new DateTime(2024, 3, 20, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9993), 4, (byte)1 },
                    { 662, 54, new DateTime(2023, 6, 9, 0, 11, 39, 504, DateTimeKind.Local).AddTicks(9996), 2, (byte)0 },
                    { 663, 103, new DateTime(2023, 5, 22, 0, 11, 39, 505, DateTimeKind.Local), 1, (byte)1 },
                    { 664, 94, new DateTime(2024, 1, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3), 1, (byte)1 },
                    { 665, 35, new DateTime(2022, 10, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(9), 4, (byte)1 },
                    { 666, 50, new DateTime(2023, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(12), 4, (byte)0 },
                    { 667, 82, new DateTime(2023, 4, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(16), 4, (byte)1 },
                    { 668, 19, new DateTime(2023, 1, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(19), 5, (byte)1 },
                    { 669, 66, new DateTime(2023, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(25), 1, (byte)1 },
                    { 670, 21, new DateTime(2023, 3, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(29), 6, (byte)2 },
                    { 671, 106, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(33), 3, (byte)0 },
                    { 672, 59, new DateTime(2024, 3, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(37), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 673, 43, new DateTime(2022, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(43), 2, (byte)1 },
                    { 674, 44, new DateTime(2022, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(47), 3, (byte)1 },
                    { 675, 63, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(50), 6, (byte)1 },
                    { 676, 99, new DateTime(2023, 1, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(54), 5, (byte)1 },
                    { 677, 94, new DateTime(2023, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(59), 6, (byte)1 },
                    { 678, 105, new DateTime(2023, 5, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(63), 2, (byte)1 },
                    { 679, 85, new DateTime(2023, 8, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(66), 1, (byte)0 },
                    { 680, 21, new DateTime(2024, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(70), 3, (byte)1 },
                    { 681, 6, new DateTime(2022, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(75), 1, (byte)1 },
                    { 682, 102, new DateTime(2024, 2, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(79), 1, (byte)1 },
                    { 683, 7, new DateTime(2023, 4, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(82), 4, (byte)1 },
                    { 684, 19, new DateTime(2023, 6, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(86), 2, (byte)1 },
                    { 685, 35, new DateTime(2022, 9, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(91), 4, (byte)1 },
                    { 686, 54, new DateTime(2024, 1, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(95), 4, (byte)1 },
                    { 687, 92, new DateTime(2023, 8, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(99), 2, (byte)1 },
                    { 688, 79, new DateTime(2023, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(102), 6, (byte)1 },
                    { 689, 29, new DateTime(2023, 11, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(108), 6, (byte)1 },
                    { 690, 63, new DateTime(2023, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(111), 3, (byte)1 },
                    { 691, 6, new DateTime(2022, 11, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(115), 3, (byte)1 },
                    { 692, 10, new DateTime(2023, 6, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(119), 6, (byte)1 },
                    { 693, 54, new DateTime(2022, 9, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(124), 6, (byte)1 },
                    { 694, 64, new DateTime(2024, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(128), 6, (byte)0 },
                    { 695, 47, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(132), 6, (byte)1 },
                    { 696, 72, new DateTime(2023, 7, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(135), 6, (byte)1 },
                    { 697, 76, new DateTime(2022, 12, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(141), 4, (byte)1 },
                    { 698, 53, new DateTime(2024, 3, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(144), 2, (byte)1 },
                    { 699, 93, new DateTime(2022, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(148), 4, (byte)1 },
                    { 700, 43, new DateTime(2022, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(152), 3, (byte)1 },
                    { 701, 54, new DateTime(2023, 3, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(174), 3, (byte)1 },
                    { 702, 7, new DateTime(2023, 10, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(179), 5, (byte)1 },
                    { 703, 13, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(182), 6, (byte)1 },
                    { 704, 54, new DateTime(2023, 3, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(186), 6, (byte)1 },
                    { 705, 80, new DateTime(2023, 4, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(192), 6, (byte)0 },
                    { 706, 103, new DateTime(2023, 6, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(195), 3, (byte)0 },
                    { 707, 44, new DateTime(2022, 12, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(199), 6, (byte)1 },
                    { 708, 67, new DateTime(2023, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(202), 1, (byte)1 },
                    { 709, 53, new DateTime(2022, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(208), 1, (byte)2 },
                    { 710, 88, new DateTime(2024, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(212), 6, (byte)1 },
                    { 711, 47, new DateTime(2023, 5, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(215), 3, (byte)1 },
                    { 712, 81, new DateTime(2024, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(219), 5, (byte)1 },
                    { 713, 47, new DateTime(2024, 2, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(225), 5, (byte)1 },
                    { 714, 86, new DateTime(2022, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(228), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 715, 14, new DateTime(2022, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(232), 4, (byte)0 },
                    { 716, 70, new DateTime(2023, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(235), 2, (byte)1 },
                    { 717, 93, new DateTime(2023, 7, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(241), 3, (byte)1 },
                    { 718, 79, new DateTime(2023, 7, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(245), 2, (byte)1 },
                    { 719, 26, new DateTime(2022, 10, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(248), 1, (byte)1 },
                    { 720, 69, new DateTime(2022, 12, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(252), 5, (byte)1 },
                    { 721, 13, new DateTime(2023, 3, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(258), 4, (byte)1 },
                    { 722, 47, new DateTime(2023, 3, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(261), 6, (byte)1 },
                    { 723, 73, new DateTime(2023, 7, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(265), 2, (byte)2 },
                    { 724, 55, new DateTime(2023, 6, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(268), 4, (byte)1 },
                    { 725, 68, new DateTime(2022, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(274), 2, (byte)1 },
                    { 726, 40, new DateTime(2023, 8, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(278), 4, (byte)1 },
                    { 727, 54, new DateTime(2022, 11, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(282), 3, (byte)1 },
                    { 728, 85, new DateTime(2023, 4, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(285), 4, (byte)0 },
                    { 729, 97, new DateTime(2022, 10, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(291), 3, (byte)1 },
                    { 730, 80, new DateTime(2022, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(295), 1, (byte)1 },
                    { 731, 34, new DateTime(2023, 11, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(299), 1, (byte)1 },
                    { 732, 89, new DateTime(2023, 7, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(302), 3, (byte)0 },
                    { 733, 103, new DateTime(2022, 10, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(308), 5, (byte)1 },
                    { 734, 2, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(312), 2, (byte)1 },
                    { 735, 71, new DateTime(2022, 11, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(315), 1, (byte)1 },
                    { 736, 23, new DateTime(2023, 9, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(318), 6, (byte)1 },
                    { 737, 29, new DateTime(2023, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(324), 5, (byte)1 },
                    { 738, 96, new DateTime(2023, 11, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(327), 4, (byte)1 },
                    { 739, 68, new DateTime(2024, 1, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(331), 4, (byte)1 },
                    { 740, 31, new DateTime(2022, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(334), 4, (byte)1 },
                    { 741, 69, new DateTime(2023, 5, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(340), 1, (byte)1 },
                    { 742, 81, new DateTime(2022, 12, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(343), 3, (byte)1 },
                    { 743, 89, new DateTime(2024, 2, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(347), 1, (byte)1 },
                    { 744, 69, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(351), 5, (byte)1 },
                    { 745, 30, new DateTime(2022, 11, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(356), 3, (byte)1 },
                    { 746, 100, new DateTime(2024, 1, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(360), 4, (byte)1 },
                    { 747, 100, new DateTime(2023, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(363), 6, (byte)1 },
                    { 748, 101, new DateTime(2024, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(367), 5, (byte)1 },
                    { 749, 89, new DateTime(2024, 1, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(373), 4, (byte)1 },
                    { 750, 21, new DateTime(2023, 2, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(377), 3, (byte)0 },
                    { 751, 58, new DateTime(2024, 1, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(380), 5, (byte)0 },
                    { 752, 34, new DateTime(2023, 1, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(384), 5, (byte)1 },
                    { 753, 41, new DateTime(2023, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(390), 6, (byte)1 },
                    { 754, 76, new DateTime(2023, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(393), 2, (byte)2 },
                    { 755, 4, new DateTime(2023, 6, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(397), 1, (byte)1 },
                    { 756, 15, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(401), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 757, 68, new DateTime(2024, 1, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(406), 2, (byte)1 },
                    { 758, 11, new DateTime(2024, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(410), 1, (byte)1 },
                    { 759, 53, new DateTime(2024, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(413), 6, (byte)0 },
                    { 760, 55, new DateTime(2022, 12, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(417), 6, (byte)1 },
                    { 761, 102, new DateTime(2023, 8, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(423), 5, (byte)1 },
                    { 762, 19, new DateTime(2023, 7, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(426), 5, (byte)1 },
                    { 763, 2, new DateTime(2023, 4, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(430), 5, (byte)1 },
                    { 764, 72, new DateTime(2023, 12, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(433), 5, (byte)1 },
                    { 765, 67, new DateTime(2022, 9, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(477), 4, (byte)1 },
                    { 766, 41, new DateTime(2022, 12, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(481), 2, (byte)1 },
                    { 767, 80, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(485), 1, (byte)1 },
                    { 768, 61, new DateTime(2022, 11, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(488), 6, (byte)1 },
                    { 769, 83, new DateTime(2023, 4, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(494), 3, (byte)1 },
                    { 770, 3, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(498), 4, (byte)1 },
                    { 771, 45, new DateTime(2023, 8, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(501), 2, (byte)2 },
                    { 772, 34, new DateTime(2023, 10, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(505), 3, (byte)1 },
                    { 773, 40, new DateTime(2022, 12, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(511), 1, (byte)0 },
                    { 774, 12, new DateTime(2023, 4, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(514), 5, (byte)1 },
                    { 775, 78, new DateTime(2023, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(518), 5, (byte)1 },
                    { 776, 26, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(521), 5, (byte)1 },
                    { 777, 55, new DateTime(2023, 2, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(527), 6, (byte)1 },
                    { 778, 92, new DateTime(2022, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(531), 5, (byte)1 },
                    { 779, 42, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(535), 1, (byte)1 },
                    { 780, 17, new DateTime(2023, 4, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(538), 1, (byte)1 },
                    { 781, 60, new DateTime(2023, 4, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(544), 6, (byte)1 },
                    { 782, 95, new DateTime(2023, 6, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(548), 4, (byte)1 },
                    { 783, 68, new DateTime(2022, 8, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(551), 1, (byte)1 },
                    { 784, 86, new DateTime(2023, 2, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(555), 2, (byte)1 },
                    { 785, 13, new DateTime(2023, 5, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(561), 3, (byte)1 },
                    { 786, 99, new DateTime(2022, 12, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(564), 6, (byte)1 },
                    { 787, 101, new DateTime(2022, 11, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(568), 4, (byte)1 },
                    { 788, 48, new DateTime(2023, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(571), 2, (byte)2 },
                    { 789, 100, new DateTime(2023, 5, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(577), 3, (byte)1 },
                    { 790, 14, new DateTime(2023, 12, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(581), 2, (byte)0 },
                    { 791, 64, new DateTime(2023, 4, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(584), 5, (byte)1 },
                    { 792, 33, new DateTime(2022, 8, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(588), 6, (byte)0 },
                    { 793, 33, new DateTime(2023, 7, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(593), 6, (byte)1 },
                    { 794, 3, new DateTime(2022, 12, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(597), 2, (byte)1 },
                    { 795, 11, new DateTime(2023, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(600), 4, (byte)1 },
                    { 796, 51, new DateTime(2022, 12, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(604), 4, (byte)1 },
                    { 797, 24, new DateTime(2024, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(610), 4, (byte)1 },
                    { 798, 44, new DateTime(2023, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(613), 5, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 799, 103, new DateTime(2023, 7, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(617), 5, (byte)0 },
                    { 800, 50, new DateTime(2023, 4, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(621), 4, (byte)1 },
                    { 801, 26, new DateTime(2023, 12, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(627), 3, (byte)1 },
                    { 802, 55, new DateTime(2024, 1, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(630), 1, (byte)1 },
                    { 803, 62, new DateTime(2023, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(634), 3, (byte)1 },
                    { 804, 85, new DateTime(2023, 6, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(638), 3, (byte)0 },
                    { 805, 91, new DateTime(2023, 11, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(643), 4, (byte)1 },
                    { 806, 97, new DateTime(2024, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(647), 5, (byte)1 },
                    { 807, 7, new DateTime(2022, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(650), 1, (byte)1 },
                    { 808, 55, new DateTime(2023, 11, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(654), 5, (byte)1 },
                    { 809, 95, new DateTime(2023, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(660), 3, (byte)1 },
                    { 810, 84, new DateTime(2022, 10, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(663), 5, (byte)1 },
                    { 811, 85, new DateTime(2023, 7, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(667), 6, (byte)2 },
                    { 812, 16, new DateTime(2022, 8, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(670), 5, (byte)0 },
                    { 813, 7, new DateTime(2023, 4, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(677), 3, (byte)1 },
                    { 814, 36, new DateTime(2023, 7, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(680), 2, (byte)1 },
                    { 815, 20, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(684), 5, (byte)0 },
                    { 816, 96, new DateTime(2024, 1, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(687), 5, (byte)1 },
                    { 817, 37, new DateTime(2022, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(693), 4, (byte)1 },
                    { 818, 74, new DateTime(2023, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(697), 5, (byte)1 },
                    { 819, 55, new DateTime(2022, 8, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(700), 3, (byte)1 },
                    { 820, 21, new DateTime(2023, 6, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(704), 2, (byte)1 },
                    { 821, 5, new DateTime(2023, 10, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(709), 5, (byte)1 },
                    { 822, 34, new DateTime(2023, 11, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(713), 4, (byte)1 },
                    { 823, 74, new DateTime(2024, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(716), 2, (byte)1 },
                    { 824, 42, new DateTime(2024, 2, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(720), 1, (byte)1 },
                    { 825, 78, new DateTime(2023, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(725), 6, (byte)1 },
                    { 826, 99, new DateTime(2023, 8, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(729), 2, (byte)1 },
                    { 827, 51, new DateTime(2022, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(732), 3, (byte)1 },
                    { 828, 68, new DateTime(2024, 2, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(763), 2, (byte)1 },
                    { 829, 88, new DateTime(2022, 9, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(770), 1, (byte)2 },
                    { 830, 52, new DateTime(2023, 8, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(773), 1, (byte)1 },
                    { 831, 52, new DateTime(2023, 6, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(777), 5, (byte)1 },
                    { 832, 80, new DateTime(2023, 5, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(780), 1, (byte)1 },
                    { 833, 46, new DateTime(2023, 6, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(786), 4, (byte)1 },
                    { 834, 8, new DateTime(2023, 5, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(790), 4, (byte)1 },
                    { 835, 15, new DateTime(2023, 4, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(793), 1, (byte)0 },
                    { 836, 88, new DateTime(2023, 5, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(797), 6, (byte)0 },
                    { 837, 77, new DateTime(2023, 12, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(803), 4, (byte)1 },
                    { 838, 66, new DateTime(2023, 8, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(807), 5, (byte)1 },
                    { 839, 14, new DateTime(2022, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(810), 4, (byte)1 },
                    { 840, 84, new DateTime(2024, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(814), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 841, 63, new DateTime(2023, 9, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(820), 5, (byte)1 },
                    { 842, 10, new DateTime(2023, 3, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(823), 1, (byte)1 },
                    { 843, 41, new DateTime(2023, 8, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(827), 5, (byte)1 },
                    { 844, 35, new DateTime(2024, 2, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(830), 1, (byte)1 },
                    { 845, 89, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(836), 3, (byte)1 },
                    { 846, 34, new DateTime(2024, 1, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(840), 3, (byte)1 },
                    { 847, 11, new DateTime(2022, 11, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(844), 5, (byte)1 },
                    { 848, 57, new DateTime(2022, 9, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(847), 1, (byte)2 },
                    { 849, 10, new DateTime(2023, 7, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(853), 5, (byte)1 },
                    { 850, 54, new DateTime(2023, 6, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(857), 6, (byte)1 },
                    { 851, 33, new DateTime(2024, 3, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(861), 4, (byte)1 },
                    { 852, 15, new DateTime(2023, 6, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(864), 5, (byte)1 },
                    { 853, 32, new DateTime(2023, 7, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(870), 4, (byte)1 },
                    { 854, 51, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(874), 3, (byte)2 },
                    { 855, 89, new DateTime(2023, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(877), 1, (byte)1 },
                    { 856, 25, new DateTime(2022, 8, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(881), 3, (byte)1 },
                    { 857, 88, new DateTime(2023, 6, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(886), 4, (byte)1 },
                    { 858, 33, new DateTime(2024, 2, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(890), 6, (byte)0 },
                    { 859, 26, new DateTime(2023, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(893), 4, (byte)1 },
                    { 860, 17, new DateTime(2022, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(897), 2, (byte)1 },
                    { 861, 60, new DateTime(2023, 3, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(903), 3, (byte)1 },
                    { 862, 13, new DateTime(2023, 12, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(906), 1, (byte)2 },
                    { 863, 79, new DateTime(2023, 3, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(910), 2, (byte)1 },
                    { 864, 102, new DateTime(2022, 12, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(914), 1, (byte)1 },
                    { 865, 10, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(919), 1, (byte)1 },
                    { 866, 83, new DateTime(2023, 6, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(923), 6, (byte)0 },
                    { 867, 28, new DateTime(2022, 12, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(926), 6, (byte)1 },
                    { 868, 72, new DateTime(2024, 1, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(930), 3, (byte)1 },
                    { 869, 39, new DateTime(2023, 3, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(936), 2, (byte)0 },
                    { 870, 65, new DateTime(2023, 4, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(940), 3, (byte)1 },
                    { 871, 103, new DateTime(2023, 8, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(943), 5, (byte)1 },
                    { 872, 10, new DateTime(2023, 2, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(947), 3, (byte)1 },
                    { 873, 70, new DateTime(2023, 8, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(953), 6, (byte)1 },
                    { 874, 61, new DateTime(2023, 2, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(957), 1, (byte)1 },
                    { 875, 19, new DateTime(2023, 8, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(960), 3, (byte)1 },
                    { 876, 68, new DateTime(2023, 10, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(964), 3, (byte)1 },
                    { 877, 76, new DateTime(2022, 12, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(970), 6, (byte)1 },
                    { 878, 53, new DateTime(2023, 11, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(974), 4, (byte)1 },
                    { 879, 42, new DateTime(2023, 3, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(977), 6, (byte)1 },
                    { 880, 81, new DateTime(2023, 12, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(981), 5, (byte)1 },
                    { 881, 6, new DateTime(2023, 4, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(986), 4, (byte)2 },
                    { 882, 9, new DateTime(2023, 4, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(990), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 883, 104, new DateTime(2023, 6, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(993), 3, (byte)1 },
                    { 884, 49, new DateTime(2023, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(997), 3, (byte)0 },
                    { 885, 14, new DateTime(2023, 10, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1003), 1, (byte)0 },
                    { 886, 21, new DateTime(2024, 3, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1007), 6, (byte)0 },
                    { 887, 87, new DateTime(2023, 10, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1010), 5, (byte)1 },
                    { 888, 40, new DateTime(2023, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1013), 5, (byte)1 },
                    { 889, 34, new DateTime(2024, 2, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1019), 1, (byte)1 },
                    { 890, 74, new DateTime(2023, 12, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1023), 3, (byte)1 },
                    { 891, 9, new DateTime(2023, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1027), 6, (byte)1 },
                    { 892, 96, new DateTime(2023, 12, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1059), 6, (byte)1 },
                    { 893, 88, new DateTime(2023, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1066), 1, (byte)1 },
                    { 894, 33, new DateTime(2023, 8, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1069), 6, (byte)1 },
                    { 895, 66, new DateTime(2023, 5, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1073), 6, (byte)1 },
                    { 896, 25, new DateTime(2023, 2, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1076), 6, (byte)1 },
                    { 897, 6, new DateTime(2023, 3, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1082), 1, (byte)0 },
                    { 898, 6, new DateTime(2023, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1086), 3, (byte)1 },
                    { 899, 15, new DateTime(2023, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1089), 3, (byte)1 },
                    { 900, 50, new DateTime(2023, 5, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1093), 1, (byte)1 },
                    { 901, 97, new DateTime(2023, 7, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1099), 4, (byte)1 },
                    { 902, 18, new DateTime(2023, 7, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1102), 6, (byte)1 },
                    { 903, 12, new DateTime(2023, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1106), 5, (byte)1 },
                    { 904, 91, new DateTime(2023, 3, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1110), 5, (byte)2 },
                    { 905, 75, new DateTime(2023, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1115), 3, (byte)1 },
                    { 906, 14, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1119), 3, (byte)1 },
                    { 907, 35, new DateTime(2022, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1122), 5, (byte)1 },
                    { 908, 73, new DateTime(2023, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1126), 2, (byte)1 },
                    { 909, 47, new DateTime(2022, 10, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1132), 3, (byte)0 },
                    { 910, 60, new DateTime(2024, 2, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1135), 5, (byte)1 },
                    { 911, 89, new DateTime(2023, 5, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1139), 4, (byte)0 },
                    { 912, 10, new DateTime(2023, 1, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1142), 1, (byte)1 },
                    { 913, 42, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1148), 2, (byte)1 },
                    { 914, 91, new DateTime(2023, 6, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1152), 6, (byte)1 },
                    { 915, 33, new DateTime(2023, 11, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1155), 3, (byte)2 },
                    { 916, 60, new DateTime(2022, 12, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1159), 4, (byte)1 },
                    { 917, 43, new DateTime(2023, 2, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1165), 6, (byte)1 },
                    { 918, 78, new DateTime(2023, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1168), 3, (byte)1 },
                    { 919, 54, new DateTime(2023, 12, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1171), 4, (byte)1 },
                    { 920, 72, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1175), 3, (byte)1 },
                    { 921, 48, new DateTime(2023, 6, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1181), 2, (byte)1 },
                    { 922, 36, new DateTime(2023, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1184), 5, (byte)1 },
                    { 923, 76, new DateTime(2023, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1188), 1, (byte)1 },
                    { 924, 42, new DateTime(2022, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1191), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 925, 46, new DateTime(2024, 3, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1197), 2, (byte)1 },
                    { 926, 92, new DateTime(2023, 10, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1201), 6, (byte)1 },
                    { 927, 103, new DateTime(2022, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1204), 1, (byte)1 },
                    { 928, 89, new DateTime(2022, 12, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1208), 6, (byte)1 },
                    { 929, 63, new DateTime(2023, 5, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1214), 4, (byte)1 },
                    { 930, 79, new DateTime(2023, 7, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1218), 3, (byte)1 },
                    { 931, 14, new DateTime(2024, 1, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1221), 2, (byte)1 },
                    { 932, 52, new DateTime(2023, 1, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1224), 6, (byte)1 },
                    { 933, 90, new DateTime(2023, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1230), 1, (byte)1 },
                    { 934, 74, new DateTime(2024, 2, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1233), 4, (byte)1 },
                    { 935, 54, new DateTime(2023, 9, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1237), 4, (byte)1 },
                    { 936, 4, new DateTime(2023, 8, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1241), 1, (byte)1 },
                    { 937, 78, new DateTime(2023, 9, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1246), 1, (byte)1 },
                    { 938, 77, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1250), 5, (byte)1 },
                    { 939, 19, new DateTime(2022, 8, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1253), 4, (byte)1 },
                    { 940, 29, new DateTime(2024, 1, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1257), 6, (byte)1 },
                    { 941, 46, new DateTime(2022, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1263), 1, (byte)1 },
                    { 942, 80, new DateTime(2024, 1, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1267), 5, (byte)0 },
                    { 943, 79, new DateTime(2023, 5, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1271), 4, (byte)1 },
                    { 944, 31, new DateTime(2024, 1, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1274), 3, (byte)1 },
                    { 945, 53, new DateTime(2022, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1280), 4, (byte)1 },
                    { 946, 49, new DateTime(2022, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1283), 1, (byte)0 },
                    { 947, 63, new DateTime(2023, 4, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1287), 6, (byte)1 },
                    { 948, 16, new DateTime(2024, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1290), 1, (byte)1 },
                    { 949, 80, new DateTime(2023, 1, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1296), 2, (byte)1 },
                    { 950, 99, new DateTime(2023, 5, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1300), 2, (byte)1 },
                    { 951, 73, new DateTime(2023, 7, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1304), 6, (byte)2 },
                    { 952, 92, new DateTime(2022, 8, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1307), 2, (byte)1 },
                    { 953, 87, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1313), 5, (byte)0 },
                    { 954, 43, new DateTime(2023, 7, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1316), 3, (byte)0 },
                    { 955, 27, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1320), 2, (byte)1 },
                    { 956, 82, new DateTime(2023, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1351), 6, (byte)1 },
                    { 957, 85, new DateTime(2023, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1357), 1, (byte)1 },
                    { 958, 45, new DateTime(2023, 5, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1361), 1, (byte)0 },
                    { 959, 26, new DateTime(2023, 6, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1365), 6, (byte)1 },
                    { 960, 17, new DateTime(2023, 3, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1368), 2, (byte)1 },
                    { 961, 76, new DateTime(2022, 9, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1374), 6, (byte)1 },
                    { 962, 77, new DateTime(2023, 1, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1378), 2, (byte)1 },
                    { 963, 94, new DateTime(2023, 8, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1381), 4, (byte)1 },
                    { 964, 13, new DateTime(2023, 3, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1385), 1, (byte)1 },
                    { 965, 83, new DateTime(2023, 4, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1391), 3, (byte)1 },
                    { 966, 51, new DateTime(2023, 1, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1394), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 967, 44, new DateTime(2023, 1, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1398), 1, (byte)1 },
                    { 968, 53, new DateTime(2024, 1, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1402), 4, (byte)0 },
                    { 969, 34, new DateTime(2023, 3, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1407), 1, (byte)1 },
                    { 970, 97, new DateTime(2023, 5, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1411), 5, (byte)1 },
                    { 971, 81, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1414), 5, (byte)1 },
                    { 972, 101, new DateTime(2023, 6, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1418), 4, (byte)1 },
                    { 973, 20, new DateTime(2023, 5, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1424), 5, (byte)1 },
                    { 974, 61, new DateTime(2024, 2, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1427), 5, (byte)1 },
                    { 975, 47, new DateTime(2024, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1431), 5, (byte)1 },
                    { 976, 26, new DateTime(2023, 7, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1434), 4, (byte)0 },
                    { 977, 89, new DateTime(2023, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1440), 1, (byte)1 },
                    { 978, 22, new DateTime(2023, 4, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1443), 4, (byte)1 },
                    { 979, 45, new DateTime(2023, 7, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1447), 4, (byte)1 },
                    { 980, 83, new DateTime(2022, 10, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1451), 5, (byte)1 },
                    { 981, 66, new DateTime(2023, 5, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1456), 2, (byte)1 },
                    { 982, 92, new DateTime(2023, 10, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1460), 1, (byte)1 },
                    { 983, 24, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1464), 1, (byte)0 },
                    { 984, 35, new DateTime(2022, 11, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1467), 4, (byte)1 },
                    { 985, 44, new DateTime(2023, 5, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1473), 2, (byte)1 },
                    { 986, 3, new DateTime(2023, 2, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1477), 2, (byte)1 },
                    { 987, 23, new DateTime(2022, 10, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1480), 2, (byte)1 },
                    { 988, 84, new DateTime(2023, 3, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1484), 2, (byte)1 },
                    { 989, 22, new DateTime(2023, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1490), 3, (byte)1 },
                    { 990, 15, new DateTime(2023, 12, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1494), 2, (byte)1 },
                    { 991, 47, new DateTime(2023, 3, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1497), 6, (byte)1 },
                    { 992, 76, new DateTime(2022, 12, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1501), 6, (byte)1 },
                    { 993, 8, new DateTime(2023, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1507), 4, (byte)1 },
                    { 994, 85, new DateTime(2023, 6, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1510), 3, (byte)1 },
                    { 995, 78, new DateTime(2023, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1514), 2, (byte)1 },
                    { 996, 14, new DateTime(2022, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1517), 1, (byte)1 },
                    { 997, 71, new DateTime(2022, 12, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1523), 6, (byte)1 },
                    { 998, 19, new DateTime(2023, 5, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1527), 4, (byte)1 },
                    { 999, 43, new DateTime(2024, 1, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1530), 4, (byte)1 },
                    { 1000, 83, new DateTime(2024, 3, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1534), 6, (byte)1 },
                    { 1001, 33, new DateTime(2022, 8, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1539), 3, (byte)1 },
                    { 1002, 13, new DateTime(2023, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1543), 3, (byte)1 },
                    { 1003, 55, new DateTime(2023, 4, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1546), 3, (byte)1 },
                    { 1004, 103, new DateTime(2023, 1, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1550), 5, (byte)1 },
                    { 1005, 8, new DateTime(2022, 11, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1556), 4, (byte)1 },
                    { 1006, 29, new DateTime(2024, 1, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1560), 4, (byte)2 },
                    { 1007, 83, new DateTime(2023, 10, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1563), 3, (byte)1 },
                    { 1008, 44, new DateTime(2022, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1566), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1009, 6, new DateTime(2024, 1, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1573), 1, (byte)0 },
                    { 1010, 87, new DateTime(2024, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1577), 1, (byte)1 },
                    { 1011, 72, new DateTime(2022, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1580), 1, (byte)1 },
                    { 1012, 27, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1584), 4, (byte)1 },
                    { 1013, 40, new DateTime(2023, 11, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1590), 5, (byte)1 },
                    { 1014, 73, new DateTime(2022, 12, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1593), 5, (byte)1 },
                    { 1015, 79, new DateTime(2023, 12, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1597), 3, (byte)1 },
                    { 1016, 81, new DateTime(2023, 12, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1601), 3, (byte)1 },
                    { 1017, 9, new DateTime(2023, 3, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1607), 5, (byte)2 },
                    { 1018, 27, new DateTime(2023, 8, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1610), 5, (byte)1 },
                    { 1019, 100, new DateTime(2023, 11, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1614), 5, (byte)1 },
                    { 1020, 36, new DateTime(2022, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1646), 6, (byte)0 },
                    { 1021, 82, new DateTime(2023, 8, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1652), 4, (byte)2 },
                    { 1022, 51, new DateTime(2023, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1656), 2, (byte)0 },
                    { 1023, 94, new DateTime(2023, 4, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1659), 1, (byte)1 },
                    { 1024, 89, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1663), 5, (byte)1 },
                    { 1025, 88, new DateTime(2023, 2, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1668), 1, (byte)1 },
                    { 1026, 56, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1741), 3, (byte)1 },
                    { 1027, 67, new DateTime(2023, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1744), 4, (byte)1 },
                    { 1028, 59, new DateTime(2023, 6, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1748), 5, (byte)1 },
                    { 1029, 30, new DateTime(2023, 12, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1754), 6, (byte)1 },
                    { 1030, 30, new DateTime(2023, 6, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1757), 2, (byte)1 },
                    { 1031, 44, new DateTime(2023, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1761), 2, (byte)1 },
                    { 1032, 38, new DateTime(2023, 9, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1764), 1, (byte)1 },
                    { 1033, 95, new DateTime(2024, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1770), 1, (byte)0 },
                    { 1034, 85, new DateTime(2023, 5, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1774), 3, (byte)1 },
                    { 1035, 12, new DateTime(2022, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1777), 6, (byte)1 },
                    { 1036, 91, new DateTime(2023, 5, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1781), 5, (byte)1 },
                    { 1037, 74, new DateTime(2023, 4, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1787), 2, (byte)1 },
                    { 1038, 81, new DateTime(2023, 7, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1790), 5, (byte)1 },
                    { 1039, 101, new DateTime(2023, 12, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1794), 5, (byte)2 },
                    { 1040, 6, new DateTime(2023, 2, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1797), 6, (byte)1 },
                    { 1041, 45, new DateTime(2022, 12, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1803), 2, (byte)1 },
                    { 1042, 66, new DateTime(2023, 4, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1807), 2, (byte)1 },
                    { 1043, 85, new DateTime(2023, 2, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1810), 5, (byte)1 },
                    { 1044, 102, new DateTime(2022, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1814), 6, (byte)1 },
                    { 1045, 41, new DateTime(2023, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1820), 3, (byte)1 },
                    { 1046, 12, new DateTime(2023, 2, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1823), 2, (byte)1 },
                    { 1047, 16, new DateTime(2022, 10, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1827), 4, (byte)1 },
                    { 1048, 7, new DateTime(2023, 6, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1830), 4, (byte)1 },
                    { 1049, 72, new DateTime(2023, 12, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1836), 4, (byte)1 },
                    { 1050, 42, new DateTime(2024, 3, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1840), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1051, 37, new DateTime(2023, 9, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1843), 4, (byte)1 },
                    { 1052, 55, new DateTime(2023, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1847), 6, (byte)0 },
                    { 1053, 46, new DateTime(2024, 1, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1853), 6, (byte)1 },
                    { 1054, 93, new DateTime(2022, 12, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1856), 2, (byte)1 },
                    { 1055, 101, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1860), 6, (byte)0 },
                    { 1056, 101, new DateTime(2023, 12, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1864), 4, (byte)1 },
                    { 1057, 49, new DateTime(2023, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1870), 2, (byte)1 },
                    { 1058, 33, new DateTime(2022, 12, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1873), 2, (byte)1 },
                    { 1059, 78, new DateTime(2023, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1877), 4, (byte)1 },
                    { 1060, 87, new DateTime(2024, 2, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1880), 4, (byte)1 },
                    { 1061, 43, new DateTime(2023, 11, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1886), 6, (byte)1 },
                    { 1062, 29, new DateTime(2024, 2, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1889), 4, (byte)1 },
                    { 1063, 79, new DateTime(2023, 5, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1893), 5, (byte)1 },
                    { 1064, 71, new DateTime(2023, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1896), 3, (byte)1 },
                    { 1065, 20, new DateTime(2022, 9, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1902), 3, (byte)1 },
                    { 1066, 32, new DateTime(2023, 6, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1906), 5, (byte)1 },
                    { 1067, 43, new DateTime(2023, 2, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1909), 1, (byte)0 },
                    { 1068, 47, new DateTime(2023, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1912), 2, (byte)0 },
                    { 1069, 11, new DateTime(2022, 10, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1918), 1, (byte)1 },
                    { 1070, 80, new DateTime(2023, 3, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1922), 1, (byte)1 },
                    { 1071, 31, new DateTime(2023, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1925), 1, (byte)2 },
                    { 1072, 49, new DateTime(2022, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1929), 5, (byte)1 },
                    { 1073, 4, new DateTime(2023, 7, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1935), 6, (byte)1 },
                    { 1074, 23, new DateTime(2022, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1939), 1, (byte)0 },
                    { 1075, 106, new DateTime(2022, 10, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1943), 2, (byte)1 },
                    { 1076, 82, new DateTime(2023, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1946), 4, (byte)1 },
                    { 1077, 102, new DateTime(2023, 5, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1952), 5, (byte)1 },
                    { 1078, 25, new DateTime(2022, 11, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1955), 6, (byte)1 },
                    { 1079, 65, new DateTime(2023, 5, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1960), 2, (byte)1 },
                    { 1080, 21, new DateTime(2024, 3, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1963), 3, (byte)1 },
                    { 1081, 17, new DateTime(2023, 12, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1969), 5, (byte)1 },
                    { 1082, 78, new DateTime(2023, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1972), 5, (byte)1 },
                    { 1083, 29, new DateTime(2023, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1976), 4, (byte)1 },
                    { 1084, 94, new DateTime(2023, 7, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(1999), 3, (byte)1 },
                    { 1085, 38, new DateTime(2023, 7, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2006), 1, (byte)1 },
                    { 1086, 101, new DateTime(2024, 2, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2009), 3, (byte)1 },
                    { 1087, 49, new DateTime(2022, 10, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2013), 6, (byte)0 },
                    { 1088, 36, new DateTime(2024, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2017), 5, (byte)1 },
                    { 1089, 27, new DateTime(2022, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2022), 5, (byte)0 },
                    { 1090, 53, new DateTime(2024, 3, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2026), 3, (byte)2 },
                    { 1091, 40, new DateTime(2023, 6, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2030), 1, (byte)1 },
                    { 1092, 95, new DateTime(2022, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2033), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1093, 84, new DateTime(2023, 4, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2039), 2, (byte)1 },
                    { 1094, 70, new DateTime(2022, 12, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2043), 4, (byte)2 },
                    { 1095, 24, new DateTime(2023, 2, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2046), 6, (byte)1 },
                    { 1096, 93, new DateTime(2022, 12, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2049), 3, (byte)1 },
                    { 1097, 43, new DateTime(2024, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2055), 6, (byte)1 },
                    { 1098, 13, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2059), 4, (byte)1 },
                    { 1099, 50, new DateTime(2023, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2062), 3, (byte)0 },
                    { 1100, 32, new DateTime(2023, 5, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2066), 2, (byte)1 },
                    { 1101, 21, new DateTime(2023, 12, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2072), 3, (byte)1 },
                    { 1102, 95, new DateTime(2022, 9, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2076), 4, (byte)1 },
                    { 1103, 23, new DateTime(2024, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2079), 1, (byte)1 },
                    { 1104, 74, new DateTime(2023, 5, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2083), 5, (byte)1 },
                    { 1105, 49, new DateTime(2023, 4, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2089), 3, (byte)1 },
                    { 1106, 13, new DateTime(2023, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2093), 5, (byte)1 },
                    { 1107, 36, new DateTime(2023, 6, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2096), 1, (byte)1 },
                    { 1108, 79, new DateTime(2023, 6, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2100), 4, (byte)1 },
                    { 1109, 34, new DateTime(2024, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2105), 1, (byte)1 },
                    { 1110, 76, new DateTime(2023, 5, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2109), 2, (byte)1 },
                    { 1111, 102, new DateTime(2023, 9, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2112), 1, (byte)0 },
                    { 1112, 46, new DateTime(2023, 5, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2116), 4, (byte)1 },
                    { 1113, 93, new DateTime(2023, 11, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2122), 6, (byte)1 },
                    { 1114, 40, new DateTime(2023, 6, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2125), 1, (byte)1 },
                    { 1115, 36, new DateTime(2023, 3, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2128), 5, (byte)1 },
                    { 1116, 56, new DateTime(2023, 1, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2132), 1, (byte)1 },
                    { 1117, 23, new DateTime(2022, 9, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2138), 3, (byte)1 },
                    { 1118, 74, new DateTime(2022, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2141), 4, (byte)1 },
                    { 1119, 47, new DateTime(2023, 4, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2145), 2, (byte)1 },
                    { 1120, 37, new DateTime(2023, 6, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2148), 3, (byte)1 },
                    { 1121, 47, new DateTime(2022, 11, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2154), 1, (byte)1 },
                    { 1122, 96, new DateTime(2023, 3, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2158), 3, (byte)1 },
                    { 1123, 66, new DateTime(2023, 3, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2161), 2, (byte)1 },
                    { 1124, 5, new DateTime(2023, 4, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2164), 3, (byte)1 },
                    { 1125, 29, new DateTime(2023, 7, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2170), 3, (byte)2 },
                    { 1126, 57, new DateTime(2023, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2173), 2, (byte)1 },
                    { 1127, 103, new DateTime(2023, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2177), 3, (byte)1 },
                    { 1128, 91, new DateTime(2023, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2181), 4, (byte)2 },
                    { 1129, 33, new DateTime(2023, 1, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2186), 5, (byte)1 },
                    { 1130, 41, new DateTime(2023, 5, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2190), 6, (byte)1 },
                    { 1131, 5, new DateTime(2024, 2, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2193), 2, (byte)1 },
                    { 1132, 73, new DateTime(2023, 3, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2197), 4, (byte)1 },
                    { 1133, 77, new DateTime(2022, 11, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2203), 4, (byte)1 },
                    { 1134, 4, new DateTime(2022, 12, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2206), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1135, 87, new DateTime(2022, 12, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2210), 2, (byte)1 },
                    { 1136, 50, new DateTime(2023, 9, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2214), 3, (byte)1 },
                    { 1137, 9, new DateTime(2023, 7, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2219), 1, (byte)1 },
                    { 1138, 56, new DateTime(2023, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2223), 6, (byte)1 },
                    { 1139, 79, new DateTime(2023, 9, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2227), 5, (byte)0 },
                    { 1140, 14, new DateTime(2022, 12, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2230), 2, (byte)1 },
                    { 1141, 46, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2236), 3, (byte)1 },
                    { 1142, 7, new DateTime(2022, 12, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2239), 6, (byte)1 },
                    { 1143, 59, new DateTime(2023, 2, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2243), 1, (byte)1 },
                    { 1144, 61, new DateTime(2023, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2246), 4, (byte)0 },
                    { 1145, 59, new DateTime(2023, 12, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2252), 6, (byte)1 },
                    { 1146, 75, new DateTime(2022, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2256), 4, (byte)0 },
                    { 1147, 84, new DateTime(2023, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2296), 3, (byte)1 },
                    { 1148, 90, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2300), 3, (byte)1 },
                    { 1149, 23, new DateTime(2023, 10, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2306), 5, (byte)1 },
                    { 1150, 99, new DateTime(2023, 4, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2310), 5, (byte)0 },
                    { 1151, 21, new DateTime(2022, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2313), 1, (byte)1 },
                    { 1152, 3, new DateTime(2023, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2317), 6, (byte)1 },
                    { 1153, 48, new DateTime(2022, 11, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2323), 6, (byte)0 },
                    { 1154, 101, new DateTime(2023, 12, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2327), 2, (byte)1 },
                    { 1155, 36, new DateTime(2023, 10, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2330), 1, (byte)1 },
                    { 1156, 12, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2334), 3, (byte)1 },
                    { 1157, 52, new DateTime(2024, 1, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2339), 1, (byte)1 },
                    { 1158, 47, new DateTime(2023, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2343), 4, (byte)2 },
                    { 1159, 12, new DateTime(2024, 3, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2347), 4, (byte)1 },
                    { 1160, 97, new DateTime(2023, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2350), 1, (byte)1 },
                    { 1161, 26, new DateTime(2023, 7, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2356), 6, (byte)1 },
                    { 1162, 105, new DateTime(2022, 10, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2360), 1, (byte)1 },
                    { 1163, 38, new DateTime(2023, 8, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2363), 6, (byte)1 },
                    { 1164, 30, new DateTime(2023, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2367), 3, (byte)0 },
                    { 1165, 61, new DateTime(2023, 8, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2373), 5, (byte)1 },
                    { 1166, 68, new DateTime(2024, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2376), 1, (byte)1 },
                    { 1167, 66, new DateTime(2023, 3, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2380), 6, (byte)1 },
                    { 1168, 83, new DateTime(2023, 2, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2383), 1, (byte)1 },
                    { 1169, 103, new DateTime(2022, 9, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2389), 1, (byte)2 },
                    { 1170, 69, new DateTime(2023, 3, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2393), 2, (byte)1 },
                    { 1171, 79, new DateTime(2023, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2396), 5, (byte)2 },
                    { 1172, 43, new DateTime(2022, 11, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2400), 3, (byte)1 },
                    { 1173, 71, new DateTime(2024, 3, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2406), 4, (byte)1 },
                    { 1174, 102, new DateTime(2023, 4, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2409), 5, (byte)1 },
                    { 1175, 27, new DateTime(2023, 12, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2413), 2, (byte)0 },
                    { 1176, 58, new DateTime(2022, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2416), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1177, 86, new DateTime(2023, 8, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2422), 1, (byte)1 },
                    { 1178, 48, new DateTime(2023, 7, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2426), 2, (byte)1 },
                    { 1179, 85, new DateTime(2023, 7, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2429), 4, (byte)1 },
                    { 1180, 98, new DateTime(2023, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2433), 5, (byte)1 },
                    { 1181, 38, new DateTime(2024, 1, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2439), 3, (byte)1 },
                    { 1182, 67, new DateTime(2022, 12, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2442), 1, (byte)1 },
                    { 1183, 94, new DateTime(2023, 8, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2446), 6, (byte)1 },
                    { 1184, 105, new DateTime(2023, 8, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2450), 3, (byte)1 },
                    { 1185, 17, new DateTime(2023, 9, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2455), 2, (byte)1 },
                    { 1186, 38, new DateTime(2022, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2459), 5, (byte)1 },
                    { 1187, 62, new DateTime(2023, 8, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2463), 3, (byte)0 },
                    { 1188, 38, new DateTime(2023, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2466), 5, (byte)1 },
                    { 1189, 23, new DateTime(2024, 1, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2472), 5, (byte)1 },
                    { 1190, 3, new DateTime(2022, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2476), 1, (byte)1 },
                    { 1191, 20, new DateTime(2024, 1, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2479), 5, (byte)1 },
                    { 1192, 86, new DateTime(2024, 3, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2482), 1, (byte)1 },
                    { 1193, 62, new DateTime(2023, 4, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2488), 1, (byte)1 },
                    { 1194, 47, new DateTime(2023, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2492), 6, (byte)1 },
                    { 1195, 105, new DateTime(2023, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2495), 5, (byte)1 },
                    { 1196, 10, new DateTime(2023, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2499), 4, (byte)0 },
                    { 1197, 3, new DateTime(2022, 8, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2505), 4, (byte)1 },
                    { 1198, 54, new DateTime(2023, 6, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2509), 3, (byte)1 },
                    { 1199, 106, new DateTime(2023, 12, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2512), 3, (byte)1 },
                    { 1200, 42, new DateTime(2023, 11, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2516), 5, (byte)1 },
                    { 1201, 98, new DateTime(2022, 8, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2521), 6, (byte)1 },
                    { 1202, 50, new DateTime(2022, 11, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2525), 3, (byte)1 },
                    { 1203, 98, new DateTime(2023, 7, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2529), 1, (byte)1 },
                    { 1204, 69, new DateTime(2023, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2532), 1, (byte)1 },
                    { 1205, 54, new DateTime(2023, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2537), 5, (byte)1 },
                    { 1206, 85, new DateTime(2023, 6, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2541), 1, (byte)1 },
                    { 1207, 4, new DateTime(2023, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2544), 5, (byte)1 },
                    { 1208, 100, new DateTime(2024, 2, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2548), 3, (byte)1 },
                    { 1209, 55, new DateTime(2023, 2, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2553), 4, (byte)1 },
                    { 1210, 81, new DateTime(2024, 1, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2557), 1, (byte)1 },
                    { 1211, 88, new DateTime(2024, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2587), 2, (byte)1 },
                    { 1212, 106, new DateTime(2022, 10, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2592), 3, (byte)1 },
                    { 1213, 46, new DateTime(2023, 1, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2597), 3, (byte)1 },
                    { 1214, 12, new DateTime(2024, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2601), 2, (byte)1 },
                    { 1215, 69, new DateTime(2023, 6, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2604), 4, (byte)1 },
                    { 1216, 31, new DateTime(2022, 9, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2608), 3, (byte)1 },
                    { 1217, 77, new DateTime(2024, 1, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2613), 6, (byte)1 },
                    { 1218, 6, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2617), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1219, 73, new DateTime(2023, 2, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2621), 1, (byte)1 },
                    { 1220, 71, new DateTime(2022, 8, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2624), 2, (byte)1 },
                    { 1221, 48, new DateTime(2023, 8, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2630), 4, (byte)1 },
                    { 1222, 106, new DateTime(2023, 4, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2634), 1, (byte)1 },
                    { 1223, 60, new DateTime(2023, 2, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2637), 1, (byte)1 },
                    { 1224, 89, new DateTime(2024, 3, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2641), 5, (byte)1 },
                    { 1225, 93, new DateTime(2023, 12, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2647), 3, (byte)1 },
                    { 1226, 94, new DateTime(2022, 10, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2650), 1, (byte)0 },
                    { 1227, 35, new DateTime(2022, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2654), 5, (byte)1 },
                    { 1228, 52, new DateTime(2023, 8, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2658), 6, (byte)1 },
                    { 1229, 56, new DateTime(2023, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2663), 2, (byte)1 },
                    { 1230, 70, new DateTime(2023, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2667), 4, (byte)0 },
                    { 1231, 57, new DateTime(2024, 2, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2670), 2, (byte)1 },
                    { 1232, 50, new DateTime(2023, 9, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2674), 1, (byte)1 },
                    { 1233, 67, new DateTime(2022, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2680), 5, (byte)1 },
                    { 1234, 56, new DateTime(2023, 6, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2683), 6, (byte)1 },
                    { 1235, 16, new DateTime(2023, 8, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2686), 6, (byte)1 },
                    { 1236, 66, new DateTime(2023, 12, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2690), 2, (byte)1 },
                    { 1237, 48, new DateTime(2022, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2695), 6, (byte)1 },
                    { 1238, 39, new DateTime(2022, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2699), 2, (byte)1 },
                    { 1239, 14, new DateTime(2023, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2702), 6, (byte)1 },
                    { 1240, 97, new DateTime(2024, 3, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2706), 3, (byte)1 },
                    { 1241, 44, new DateTime(2023, 6, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2712), 5, (byte)1 },
                    { 1242, 39, new DateTime(2024, 3, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2715), 4, (byte)1 },
                    { 1243, 83, new DateTime(2023, 12, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2719), 1, (byte)2 },
                    { 1244, 4, new DateTime(2023, 8, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2722), 2, (byte)1 },
                    { 1245, 46, new DateTime(2024, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2728), 5, (byte)1 },
                    { 1246, 76, new DateTime(2023, 1, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2732), 4, (byte)1 },
                    { 1247, 64, new DateTime(2023, 1, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2735), 3, (byte)1 },
                    { 1248, 65, new DateTime(2023, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2739), 3, (byte)1 },
                    { 1249, 72, new DateTime(2023, 9, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2744), 1, (byte)1 },
                    { 1250, 71, new DateTime(2022, 11, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2748), 4, (byte)1 },
                    { 1251, 8, new DateTime(2023, 7, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2751), 1, (byte)1 },
                    { 1252, 95, new DateTime(2022, 12, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2755), 6, (byte)1 },
                    { 1253, 4, new DateTime(2023, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2761), 5, (byte)1 },
                    { 1254, 36, new DateTime(2022, 8, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2764), 3, (byte)1 },
                    { 1255, 35, new DateTime(2023, 7, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2768), 4, (byte)1 },
                    { 1256, 66, new DateTime(2022, 10, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2772), 1, (byte)1 },
                    { 1257, 41, new DateTime(2022, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2777), 6, (byte)1 },
                    { 1258, 86, new DateTime(2023, 3, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2781), 3, (byte)1 },
                    { 1259, 21, new DateTime(2023, 2, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2784), 2, (byte)1 },
                    { 1260, 84, new DateTime(2023, 7, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2788), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1261, 104, new DateTime(2023, 4, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2794), 1, (byte)0 },
                    { 1262, 71, new DateTime(2023, 10, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2797), 3, (byte)1 },
                    { 1263, 70, new DateTime(2024, 3, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2801), 1, (byte)0 },
                    { 1264, 12, new DateTime(2024, 1, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2805), 3, (byte)1 },
                    { 1265, 76, new DateTime(2024, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2811), 2, (byte)1 },
                    { 1266, 45, new DateTime(2023, 8, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2814), 4, (byte)2 },
                    { 1267, 54, new DateTime(2023, 5, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2818), 4, (byte)1 },
                    { 1268, 8, new DateTime(2023, 1, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2822), 4, (byte)1 },
                    { 1269, 69, new DateTime(2023, 6, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2827), 1, (byte)1 },
                    { 1270, 81, new DateTime(2023, 12, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2831), 3, (byte)1 },
                    { 1271, 21, new DateTime(2023, 6, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2834), 5, (byte)1 },
                    { 1272, 64, new DateTime(2022, 11, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2838), 1, (byte)1 },
                    { 1273, 42, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2844), 2, (byte)1 },
                    { 1274, 81, new DateTime(2023, 1, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2848), 5, (byte)1 },
                    { 1275, 2, new DateTime(2022, 10, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2878), 5, (byte)1 },
                    { 1276, 50, new DateTime(2023, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2882), 2, (byte)1 },
                    { 1277, 23, new DateTime(2023, 4, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2888), 3, (byte)1 },
                    { 1278, 10, new DateTime(2023, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2892), 3, (byte)0 },
                    { 1279, 60, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2895), 5, (byte)1 },
                    { 1280, 22, new DateTime(2022, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2899), 3, (byte)1 },
                    { 1281, 87, new DateTime(2023, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2905), 5, (byte)1 },
                    { 1282, 72, new DateTime(2023, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2908), 6, (byte)1 },
                    { 1283, 50, new DateTime(2022, 10, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2912), 4, (byte)1 },
                    { 1284, 55, new DateTime(2024, 3, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2915), 2, (byte)1 },
                    { 1285, 73, new DateTime(2022, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2921), 2, (byte)1 },
                    { 1286, 24, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2924), 2, (byte)1 },
                    { 1287, 87, new DateTime(2023, 10, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2928), 1, (byte)1 },
                    { 1288, 78, new DateTime(2023, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2931), 1, (byte)1 },
                    { 1289, 39, new DateTime(2022, 11, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2937), 4, (byte)1 },
                    { 1290, 96, new DateTime(2023, 3, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2941), 4, (byte)1 },
                    { 1291, 48, new DateTime(2022, 12, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2944), 6, (byte)1 },
                    { 1292, 33, new DateTime(2023, 2, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2948), 1, (byte)1 },
                    { 1293, 82, new DateTime(2024, 1, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2953), 5, (byte)1 },
                    { 1294, 94, new DateTime(2022, 9, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2957), 2, (byte)1 },
                    { 1295, 98, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2961), 6, (byte)1 },
                    { 1296, 88, new DateTime(2023, 5, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2964), 3, (byte)1 },
                    { 1297, 3, new DateTime(2022, 10, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2970), 5, (byte)1 },
                    { 1298, 92, new DateTime(2022, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2974), 1, (byte)1 },
                    { 1299, 9, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2977), 1, (byte)1 },
                    { 1300, 51, new DateTime(2023, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2981), 1, (byte)1 },
                    { 1301, 4, new DateTime(2022, 12, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2986), 5, (byte)1 },
                    { 1302, 59, new DateTime(2023, 8, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2990), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1303, 54, new DateTime(2023, 11, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2994), 6, (byte)1 },
                    { 1304, 64, new DateTime(2022, 11, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(2997), 2, (byte)1 },
                    { 1305, 79, new DateTime(2023, 4, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3003), 5, (byte)1 },
                    { 1306, 31, new DateTime(2024, 3, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3007), 1, (byte)1 },
                    { 1307, 76, new DateTime(2022, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3011), 1, (byte)0 },
                    { 1308, 54, new DateTime(2022, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3014), 3, (byte)1 },
                    { 1309, 6, new DateTime(2022, 12, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3021), 5, (byte)1 },
                    { 1310, 5, new DateTime(2024, 1, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3024), 5, (byte)1 },
                    { 1311, 95, new DateTime(2024, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3028), 1, (byte)1 },
                    { 1312, 32, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3032), 1, (byte)1 },
                    { 1313, 16, new DateTime(2023, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3038), 1, (byte)1 },
                    { 1314, 29, new DateTime(2022, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3041), 4, (byte)1 },
                    { 1315, 50, new DateTime(2024, 1, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3045), 1, (byte)0 },
                    { 1316, 71, new DateTime(2022, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3048), 5, (byte)1 },
                    { 1317, 4, new DateTime(2024, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3054), 2, (byte)1 },
                    { 1318, 79, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3058), 3, (byte)1 },
                    { 1319, 87, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3062), 6, (byte)2 },
                    { 1320, 66, new DateTime(2023, 1, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3065), 2, (byte)1 },
                    { 1321, 46, new DateTime(2022, 11, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3071), 4, (byte)0 },
                    { 1322, 96, new DateTime(2023, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3075), 3, (byte)1 },
                    { 1323, 63, new DateTime(2022, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3078), 2, (byte)1 },
                    { 1324, 61, new DateTime(2023, 12, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3082), 2, (byte)1 },
                    { 1325, 22, new DateTime(2022, 9, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3089), 2, (byte)1 },
                    { 1326, 66, new DateTime(2023, 4, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3092), 4, (byte)1 },
                    { 1327, 91, new DateTime(2023, 6, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3096), 1, (byte)1 },
                    { 1328, 76, new DateTime(2023, 4, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3100), 5, (byte)2 },
                    { 1329, 12, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3105), 2, (byte)1 },
                    { 1330, 59, new DateTime(2022, 10, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3109), 4, (byte)1 },
                    { 1331, 84, new DateTime(2023, 1, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3112), 2, (byte)1 },
                    { 1332, 68, new DateTime(2023, 10, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3116), 6, (byte)1 },
                    { 1333, 35, new DateTime(2024, 3, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3122), 6, (byte)1 },
                    { 1334, 101, new DateTime(2024, 3, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3125), 2, (byte)1 },
                    { 1335, 53, new DateTime(2023, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3129), 5, (byte)1 },
                    { 1336, 12, new DateTime(2022, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3133), 3, (byte)1 },
                    { 1337, 55, new DateTime(2023, 7, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3139), 3, (byte)1 },
                    { 1338, 40, new DateTime(2024, 2, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3142), 5, (byte)1 },
                    { 1339, 30, new DateTime(2023, 5, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3173), 5, (byte)1 },
                    { 1340, 89, new DateTime(2022, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3177), 5, (byte)1 },
                    { 1341, 104, new DateTime(2024, 1, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3183), 5, (byte)1 },
                    { 1342, 106, new DateTime(2024, 3, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3186), 4, (byte)1 },
                    { 1343, 21, new DateTime(2022, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3190), 1, (byte)0 },
                    { 1344, 88, new DateTime(2023, 3, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3194), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1345, 40, new DateTime(2023, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3200), 3, (byte)1 },
                    { 1346, 78, new DateTime(2023, 6, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3203), 4, (byte)1 },
                    { 1347, 99, new DateTime(2023, 10, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3207), 4, (byte)0 },
                    { 1348, 69, new DateTime(2022, 11, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3210), 4, (byte)1 },
                    { 1349, 54, new DateTime(2023, 6, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3216), 1, (byte)1 },
                    { 1350, 15, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3219), 5, (byte)1 },
                    { 1351, 89, new DateTime(2023, 8, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3223), 1, (byte)1 },
                    { 1352, 89, new DateTime(2024, 1, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3226), 2, (byte)1 },
                    { 1353, 81, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3232), 1, (byte)1 },
                    { 1354, 64, new DateTime(2024, 2, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3236), 6, (byte)2 },
                    { 1355, 103, new DateTime(2023, 1, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3239), 1, (byte)1 },
                    { 1356, 46, new DateTime(2022, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3243), 6, (byte)1 },
                    { 1357, 76, new DateTime(2024, 2, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3248), 5, (byte)1 },
                    { 1358, 97, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3252), 3, (byte)1 },
                    { 1359, 72, new DateTime(2022, 8, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3255), 6, (byte)1 },
                    { 1360, 57, new DateTime(2023, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3259), 6, (byte)1 },
                    { 1361, 4, new DateTime(2023, 7, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3265), 4, (byte)1 },
                    { 1362, 68, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3269), 4, (byte)1 },
                    { 1363, 76, new DateTime(2023, 1, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3272), 6, (byte)1 },
                    { 1364, 93, new DateTime(2022, 12, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3276), 6, (byte)1 },
                    { 1365, 56, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3282), 4, (byte)0 },
                    { 1366, 43, new DateTime(2023, 12, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3285), 1, (byte)1 },
                    { 1367, 86, new DateTime(2023, 5, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3289), 4, (byte)0 },
                    { 1368, 104, new DateTime(2024, 2, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3292), 2, (byte)1 },
                    { 1369, 98, new DateTime(2023, 4, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3298), 1, (byte)1 },
                    { 1370, 5, new DateTime(2023, 7, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3301), 3, (byte)2 },
                    { 1371, 53, new DateTime(2023, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3305), 2, (byte)1 },
                    { 1372, 55, new DateTime(2024, 2, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3309), 6, (byte)1 },
                    { 1373, 80, new DateTime(2023, 2, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3314), 6, (byte)1 },
                    { 1374, 81, new DateTime(2023, 12, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3318), 4, (byte)0 },
                    { 1375, 25, new DateTime(2023, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3321), 1, (byte)1 },
                    { 1376, 18, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3325), 1, (byte)1 },
                    { 1377, 9, new DateTime(2022, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3331), 3, (byte)1 },
                    { 1378, 64, new DateTime(2023, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3381), 2, (byte)1 },
                    { 1379, 77, new DateTime(2023, 5, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3388), 1, (byte)1 },
                    { 1380, 98, new DateTime(2023, 10, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3395), 6, (byte)2 },
                    { 1381, 46, new DateTime(2024, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3405), 2, (byte)1 },
                    { 1382, 94, new DateTime(2022, 9, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3411), 6, (byte)0 },
                    { 1383, 97, new DateTime(2024, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3417), 6, (byte)1 },
                    { 1384, 55, new DateTime(2022, 12, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3423), 4, (byte)1 },
                    { 1385, 46, new DateTime(2022, 11, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3432), 4, (byte)1 },
                    { 1386, 62, new DateTime(2024, 1, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3441), 5, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1387, 92, new DateTime(2023, 3, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3445), 2, (byte)0 },
                    { 1388, 17, new DateTime(2023, 6, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3449), 6, (byte)1 },
                    { 1389, 53, new DateTime(2023, 4, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3455), 3, (byte)1 },
                    { 1390, 22, new DateTime(2022, 12, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3458), 2, (byte)1 },
                    { 1391, 6, new DateTime(2023, 2, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3462), 5, (byte)1 },
                    { 1392, 50, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3465), 5, (byte)1 },
                    { 1393, 83, new DateTime(2024, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3471), 3, (byte)1 },
                    { 1394, 68, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3475), 5, (byte)1 },
                    { 1395, 83, new DateTime(2024, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3478), 4, (byte)1 },
                    { 1396, 27, new DateTime(2022, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3482), 1, (byte)1 },
                    { 1397, 41, new DateTime(2022, 10, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3487), 2, (byte)1 },
                    { 1398, 102, new DateTime(2023, 9, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3491), 4, (byte)1 },
                    { 1399, 91, new DateTime(2024, 2, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3495), 4, (byte)1 },
                    { 1400, 64, new DateTime(2023, 5, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3499), 2, (byte)1 },
                    { 1401, 103, new DateTime(2023, 6, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3504), 5, (byte)1 },
                    { 1402, 102, new DateTime(2023, 8, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3538), 4, (byte)1 },
                    { 1403, 83, new DateTime(2023, 1, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3543), 2, (byte)0 },
                    { 1404, 97, new DateTime(2022, 11, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3546), 4, (byte)1 },
                    { 1405, 67, new DateTime(2023, 8, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3552), 5, (byte)0 },
                    { 1406, 43, new DateTime(2023, 11, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3556), 4, (byte)1 },
                    { 1407, 44, new DateTime(2022, 9, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3559), 3, (byte)1 },
                    { 1408, 47, new DateTime(2023, 1, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3563), 4, (byte)1 },
                    { 1409, 87, new DateTime(2023, 4, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3569), 1, (byte)1 },
                    { 1410, 8, new DateTime(2023, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3572), 2, (byte)1 },
                    { 1411, 71, new DateTime(2022, 8, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3576), 2, (byte)0 },
                    { 1412, 48, new DateTime(2024, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3580), 6, (byte)1 },
                    { 1413, 98, new DateTime(2023, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3586), 4, (byte)1 },
                    { 1414, 38, new DateTime(2022, 12, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3589), 5, (byte)1 },
                    { 1415, 58, new DateTime(2023, 1, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3593), 5, (byte)0 },
                    { 1416, 23, new DateTime(2022, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3597), 4, (byte)1 },
                    { 1417, 11, new DateTime(2022, 11, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3603), 5, (byte)0 },
                    { 1418, 80, new DateTime(2022, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3607), 3, (byte)1 },
                    { 1419, 30, new DateTime(2024, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3611), 4, (byte)1 },
                    { 1420, 34, new DateTime(2023, 5, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3614), 2, (byte)0 },
                    { 1421, 76, new DateTime(2023, 8, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3620), 2, (byte)1 },
                    { 1422, 53, new DateTime(2023, 12, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3623), 5, (byte)1 },
                    { 1423, 96, new DateTime(2023, 5, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3627), 2, (byte)1 },
                    { 1424, 2, new DateTime(2023, 8, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3630), 2, (byte)1 },
                    { 1425, 52, new DateTime(2023, 10, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3636), 2, (byte)1 },
                    { 1426, 87, new DateTime(2023, 7, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3639), 2, (byte)1 },
                    { 1427, 23, new DateTime(2023, 5, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3643), 1, (byte)1 },
                    { 1428, 22, new DateTime(2023, 6, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3646), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1429, 36, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3652), 1, (byte)1 },
                    { 1430, 52, new DateTime(2023, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3656), 2, (byte)0 },
                    { 1431, 74, new DateTime(2023, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3659), 2, (byte)1 },
                    { 1432, 13, new DateTime(2023, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3663), 2, (byte)1 },
                    { 1433, 23, new DateTime(2023, 10, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3668), 1, (byte)1 },
                    { 1434, 92, new DateTime(2022, 9, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3672), 2, (byte)1 },
                    { 1435, 66, new DateTime(2023, 1, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3675), 2, (byte)1 },
                    { 1436, 62, new DateTime(2023, 5, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3679), 2, (byte)1 },
                    { 1437, 32, new DateTime(2023, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3685), 4, (byte)1 },
                    { 1438, 24, new DateTime(2022, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3688), 2, (byte)1 },
                    { 1439, 48, new DateTime(2023, 8, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3692), 5, (byte)1 },
                    { 1440, 57, new DateTime(2024, 1, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3695), 6, (byte)1 },
                    { 1441, 82, new DateTime(2023, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3701), 3, (byte)1 },
                    { 1442, 58, new DateTime(2022, 12, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3705), 6, (byte)1 },
                    { 1443, 27, new DateTime(2023, 7, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3708), 1, (byte)0 },
                    { 1444, 37, new DateTime(2023, 12, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3712), 2, (byte)1 },
                    { 1445, 36, new DateTime(2022, 9, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3718), 2, (byte)0 },
                    { 1446, 13, new DateTime(2024, 1, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3722), 1, (byte)1 },
                    { 1447, 50, new DateTime(2022, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3725), 2, (byte)1 },
                    { 1448, 37, new DateTime(2022, 8, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3729), 6, (byte)1 },
                    { 1449, 35, new DateTime(2023, 11, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3735), 4, (byte)1 },
                    { 1450, 67, new DateTime(2023, 7, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3738), 5, (byte)1 },
                    { 1451, 96, new DateTime(2022, 8, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3742), 2, (byte)1 },
                    { 1452, 62, new DateTime(2023, 1, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3746), 1, (byte)0 },
                    { 1453, 5, new DateTime(2022, 10, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3753), 3, (byte)1 },
                    { 1454, 30, new DateTime(2023, 7, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3757), 4, (byte)1 },
                    { 1455, 93, new DateTime(2023, 4, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3760), 5, (byte)1 },
                    { 1456, 98, new DateTime(2022, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3764), 5, (byte)1 },
                    { 1457, 54, new DateTime(2022, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3770), 6, (byte)0 },
                    { 1458, 71, new DateTime(2023, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3774), 2, (byte)1 },
                    { 1459, 91, new DateTime(2023, 12, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3777), 4, (byte)1 },
                    { 1460, 73, new DateTime(2023, 6, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3781), 6, (byte)2 },
                    { 1461, 73, new DateTime(2023, 5, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3786), 2, (byte)1 },
                    { 1462, 81, new DateTime(2023, 12, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3790), 6, (byte)1 },
                    { 1463, 34, new DateTime(2023, 4, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3794), 3, (byte)1 },
                    { 1464, 87, new DateTime(2023, 7, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3797), 3, (byte)1 },
                    { 1465, 47, new DateTime(2023, 12, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3803), 2, (byte)1 },
                    { 1466, 103, new DateTime(2023, 1, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3834), 2, (byte)1 },
                    { 1467, 60, new DateTime(2023, 6, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3838), 1, (byte)1 },
                    { 1468, 15, new DateTime(2022, 10, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3842), 3, (byte)1 },
                    { 1469, 25, new DateTime(2024, 3, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3847), 3, (byte)1 },
                    { 1470, 80, new DateTime(2023, 5, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3851), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1471, 14, new DateTime(2024, 1, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3854), 6, (byte)0 },
                    { 1472, 24, new DateTime(2022, 12, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3858), 5, (byte)1 },
                    { 1473, 77, new DateTime(2023, 1, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3863), 5, (byte)1 },
                    { 1474, 85, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3867), 1, (byte)1 },
                    { 1475, 73, new DateTime(2023, 4, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3870), 6, (byte)1 },
                    { 1476, 55, new DateTime(2023, 4, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3874), 2, (byte)1 },
                    { 1477, 49, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3880), 2, (byte)1 },
                    { 1478, 8, new DateTime(2023, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3883), 1, (byte)1 },
                    { 1479, 38, new DateTime(2022, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3887), 1, (byte)1 },
                    { 1480, 91, new DateTime(2023, 9, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3890), 1, (byte)1 },
                    { 1481, 19, new DateTime(2023, 12, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3896), 3, (byte)1 },
                    { 1482, 30, new DateTime(2022, 8, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3899), 5, (byte)0 },
                    { 1483, 2, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3903), 6, (byte)1 },
                    { 1484, 35, new DateTime(2023, 7, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3907), 2, (byte)1 },
                    { 1485, 74, new DateTime(2023, 4, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3913), 3, (byte)1 },
                    { 1486, 31, new DateTime(2023, 11, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3916), 1, (byte)1 },
                    { 1487, 97, new DateTime(2022, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3920), 2, (byte)1 },
                    { 1488, 64, new DateTime(2023, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3924), 4, (byte)1 },
                    { 1489, 34, new DateTime(2023, 7, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3929), 3, (byte)1 },
                    { 1490, 2, new DateTime(2023, 7, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3932), 6, (byte)1 },
                    { 1491, 95, new DateTime(2023, 7, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3936), 6, (byte)1 },
                    { 1492, 58, new DateTime(2023, 6, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3939), 4, (byte)1 },
                    { 1493, 79, new DateTime(2023, 12, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3945), 1, (byte)0 },
                    { 1494, 104, new DateTime(2023, 1, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3949), 1, (byte)1 },
                    { 1495, 4, new DateTime(2023, 7, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3953), 5, (byte)1 },
                    { 1496, 25, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3956), 2, (byte)1 },
                    { 1497, 32, new DateTime(2024, 2, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3962), 5, (byte)0 },
                    { 1498, 51, new DateTime(2023, 12, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3965), 4, (byte)0 },
                    { 1499, 27, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3969), 6, (byte)1 },
                    { 1500, 27, new DateTime(2023, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3973), 3, (byte)1 },
                    { 1501, 14, new DateTime(2024, 1, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3978), 3, (byte)1 },
                    { 1502, 18, new DateTime(2023, 10, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3982), 2, (byte)1 },
                    { 1503, 89, new DateTime(2022, 10, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3986), 3, (byte)1 },
                    { 1504, 57, new DateTime(2023, 7, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3989), 5, (byte)1 },
                    { 1505, 42, new DateTime(2024, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3995), 6, (byte)1 },
                    { 1506, 43, new DateTime(2022, 10, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(3998), 6, (byte)1 },
                    { 1507, 31, new DateTime(2023, 9, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4002), 3, (byte)1 },
                    { 1508, 47, new DateTime(2023, 2, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4005), 1, (byte)1 },
                    { 1509, 80, new DateTime(2023, 4, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4011), 5, (byte)1 },
                    { 1510, 96, new DateTime(2023, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4014), 4, (byte)1 },
                    { 1511, 69, new DateTime(2023, 2, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4018), 1, (byte)0 },
                    { 1512, 96, new DateTime(2023, 7, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4021), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1513, 15, new DateTime(2023, 12, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4027), 4, (byte)1 },
                    { 1514, 83, new DateTime(2023, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4030), 3, (byte)1 },
                    { 1515, 90, new DateTime(2023, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4034), 6, (byte)1 },
                    { 1516, 14, new DateTime(2022, 9, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4037), 1, (byte)1 },
                    { 1517, 39, new DateTime(2023, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4043), 2, (byte)1 },
                    { 1518, 69, new DateTime(2023, 9, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4046), 6, (byte)1 },
                    { 1519, 73, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4050), 1, (byte)0 },
                    { 1520, 6, new DateTime(2023, 4, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4053), 3, (byte)1 },
                    { 1521, 2, new DateTime(2024, 3, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4059), 1, (byte)1 },
                    { 1522, 50, new DateTime(2022, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4063), 1, (byte)1 },
                    { 1523, 46, new DateTime(2023, 3, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4066), 5, (byte)1 },
                    { 1524, 101, new DateTime(2022, 11, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4070), 5, (byte)1 },
                    { 1525, 48, new DateTime(2023, 6, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4076), 2, (byte)1 },
                    { 1526, 22, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4079), 5, (byte)1 },
                    { 1527, 48, new DateTime(2022, 10, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4082), 6, (byte)1 },
                    { 1528, 18, new DateTime(2023, 3, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4086), 3, (byte)1 },
                    { 1529, 53, new DateTime(2022, 10, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4092), 4, (byte)1 },
                    { 1530, 69, new DateTime(2023, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4123), 3, (byte)1 },
                    { 1531, 92, new DateTime(2024, 2, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4127), 6, (byte)1 },
                    { 1532, 53, new DateTime(2023, 4, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4131), 5, (byte)1 },
                    { 1533, 23, new DateTime(2023, 7, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4137), 2, (byte)1 },
                    { 1534, 50, new DateTime(2022, 11, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4140), 4, (byte)1 },
                    { 1535, 49, new DateTime(2024, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4144), 1, (byte)1 },
                    { 1536, 45, new DateTime(2023, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4147), 4, (byte)1 },
                    { 1537, 23, new DateTime(2023, 7, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4153), 4, (byte)1 },
                    { 1538, 91, new DateTime(2023, 4, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4156), 6, (byte)1 },
                    { 1539, 3, new DateTime(2024, 2, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4160), 4, (byte)1 },
                    { 1540, 25, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4163), 6, (byte)1 },
                    { 1541, 66, new DateTime(2022, 11, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4169), 2, (byte)0 },
                    { 1542, 98, new DateTime(2023, 5, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4172), 6, (byte)2 },
                    { 1543, 15, new DateTime(2024, 3, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4176), 4, (byte)1 },
                    { 1544, 18, new DateTime(2023, 2, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4179), 3, (byte)1 },
                    { 1545, 40, new DateTime(2024, 1, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4185), 6, (byte)1 },
                    { 1546, 7, new DateTime(2023, 11, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4189), 2, (byte)1 },
                    { 1547, 72, new DateTime(2023, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4192), 6, (byte)1 },
                    { 1548, 83, new DateTime(2023, 1, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4196), 3, (byte)1 },
                    { 1549, 38, new DateTime(2024, 3, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4201), 2, (byte)1 },
                    { 1550, 37, new DateTime(2023, 5, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4205), 5, (byte)2 },
                    { 1551, 35, new DateTime(2023, 3, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4208), 3, (byte)1 },
                    { 1552, 81, new DateTime(2023, 10, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4212), 1, (byte)1 },
                    { 1553, 50, new DateTime(2023, 5, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4218), 5, (byte)0 },
                    { 1554, 27, new DateTime(2024, 1, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4222), 4, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1555, 57, new DateTime(2022, 9, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4225), 3, (byte)1 },
                    { 1556, 63, new DateTime(2023, 12, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4229), 1, (byte)1 },
                    { 1557, 42, new DateTime(2023, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4235), 5, (byte)1 },
                    { 1558, 87, new DateTime(2023, 4, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4238), 6, (byte)1 },
                    { 1559, 47, new DateTime(2023, 4, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4242), 3, (byte)1 },
                    { 1560, 27, new DateTime(2023, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4245), 3, (byte)1 },
                    { 1561, 38, new DateTime(2023, 9, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4251), 6, (byte)1 },
                    { 1562, 45, new DateTime(2022, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4254), 2, (byte)1 },
                    { 1563, 26, new DateTime(2024, 2, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4258), 5, (byte)0 },
                    { 1564, 21, new DateTime(2023, 1, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4262), 4, (byte)1 },
                    { 1565, 89, new DateTime(2023, 10, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4268), 1, (byte)1 },
                    { 1566, 52, new DateTime(2023, 5, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4271), 3, (byte)1 },
                    { 1567, 14, new DateTime(2022, 8, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4274), 6, (byte)1 },
                    { 1568, 6, new DateTime(2023, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4278), 1, (byte)1 },
                    { 1569, 53, new DateTime(2022, 12, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4283), 6, (byte)1 },
                    { 1570, 16, new DateTime(2023, 9, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4287), 3, (byte)1 },
                    { 1571, 93, new DateTime(2023, 6, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4290), 5, (byte)1 },
                    { 1572, 64, new DateTime(2023, 5, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4294), 5, (byte)2 },
                    { 1573, 87, new DateTime(2023, 12, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4299), 6, (byte)1 },
                    { 1574, 106, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4303), 2, (byte)1 },
                    { 1575, 66, new DateTime(2022, 10, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4307), 6, (byte)0 },
                    { 1576, 81, new DateTime(2023, 5, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4311), 6, (byte)1 },
                    { 1577, 86, new DateTime(2024, 2, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4317), 3, (byte)1 },
                    { 1578, 54, new DateTime(2022, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4320), 6, (byte)1 },
                    { 1579, 6, new DateTime(2023, 10, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4324), 6, (byte)1 },
                    { 1580, 62, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4327), 5, (byte)1 },
                    { 1581, 16, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4333), 5, (byte)1 },
                    { 1582, 2, new DateTime(2023, 11, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4337), 5, (byte)2 },
                    { 1583, 18, new DateTime(2022, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4340), 3, (byte)1 },
                    { 1584, 39, new DateTime(2024, 3, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4344), 1, (byte)1 },
                    { 1585, 105, new DateTime(2023, 1, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4350), 1, (byte)1 },
                    { 1586, 55, new DateTime(2023, 7, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4353), 3, (byte)1 },
                    { 1587, 33, new DateTime(2023, 2, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4357), 4, (byte)1 },
                    { 1588, 92, new DateTime(2022, 10, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4360), 2, (byte)1 },
                    { 1589, 83, new DateTime(2023, 8, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4366), 2, (byte)1 },
                    { 1590, 55, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4370), 6, (byte)1 },
                    { 1591, 27, new DateTime(2022, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4373), 5, (byte)1 },
                    { 1592, 18, new DateTime(2023, 10, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4377), 6, (byte)0 },
                    { 1593, 37, new DateTime(2022, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4383), 3, (byte)1 },
                    { 1594, 15, new DateTime(2022, 10, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4415), 1, (byte)1 },
                    { 1595, 104, new DateTime(2022, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4419), 6, (byte)1 },
                    { 1596, 99, new DateTime(2023, 2, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4423), 5, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1597, 22, new DateTime(2022, 11, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4428), 1, (byte)1 },
                    { 1598, 29, new DateTime(2023, 2, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4432), 5, (byte)1 },
                    { 1599, 14, new DateTime(2023, 6, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4435), 6, (byte)1 },
                    { 1600, 65, new DateTime(2022, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4439), 2, (byte)1 },
                    { 1601, 4, new DateTime(2022, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4445), 2, (byte)1 },
                    { 1602, 68, new DateTime(2023, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4449), 2, (byte)1 },
                    { 1603, 102, new DateTime(2022, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4452), 2, (byte)1 },
                    { 1604, 18, new DateTime(2022, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4455), 2, (byte)1 },
                    { 1605, 18, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4461), 6, (byte)1 },
                    { 1606, 33, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4465), 3, (byte)1 },
                    { 1607, 44, new DateTime(2023, 8, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4468), 1, (byte)1 },
                    { 1608, 37, new DateTime(2023, 10, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4472), 4, (byte)1 },
                    { 1609, 57, new DateTime(2024, 1, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4477), 2, (byte)1 },
                    { 1610, 36, new DateTime(2023, 7, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4481), 5, (byte)1 },
                    { 1611, 3, new DateTime(2022, 9, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4484), 5, (byte)1 },
                    { 1612, 28, new DateTime(2023, 10, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4487), 5, (byte)1 },
                    { 1613, 31, new DateTime(2023, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4493), 3, (byte)1 },
                    { 1614, 36, new DateTime(2023, 3, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4497), 1, (byte)1 },
                    { 1615, 54, new DateTime(2022, 11, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4500), 3, (byte)0 },
                    { 1616, 60, new DateTime(2023, 11, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4504), 1, (byte)0 },
                    { 1617, 17, new DateTime(2023, 10, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4509), 5, (byte)1 },
                    { 1618, 79, new DateTime(2023, 3, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4513), 1, (byte)1 },
                    { 1619, 19, new DateTime(2022, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4516), 4, (byte)1 },
                    { 1620, 68, new DateTime(2023, 8, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4520), 6, (byte)1 },
                    { 1621, 42, new DateTime(2022, 10, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4526), 4, (byte)1 },
                    { 1622, 29, new DateTime(2023, 2, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4530), 3, (byte)1 },
                    { 1623, 9, new DateTime(2023, 5, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4533), 5, (byte)1 },
                    { 1624, 72, new DateTime(2023, 6, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4536), 3, (byte)1 },
                    { 1625, 77, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4542), 5, (byte)1 },
                    { 1626, 78, new DateTime(2023, 4, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4546), 3, (byte)1 },
                    { 1627, 80, new DateTime(2023, 2, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4549), 2, (byte)1 },
                    { 1628, 102, new DateTime(2024, 1, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4553), 1, (byte)1 },
                    { 1629, 30, new DateTime(2023, 7, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4558), 5, (byte)1 },
                    { 1630, 31, new DateTime(2023, 10, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4562), 6, (byte)1 },
                    { 1631, 35, new DateTime(2023, 7, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4565), 6, (byte)1 },
                    { 1632, 36, new DateTime(2023, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4569), 1, (byte)1 },
                    { 1633, 66, new DateTime(2022, 9, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4574), 1, (byte)1 },
                    { 1634, 20, new DateTime(2023, 10, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4578), 3, (byte)0 },
                    { 1635, 39, new DateTime(2023, 7, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4581), 2, (byte)1 },
                    { 1636, 42, new DateTime(2023, 11, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4584), 4, (byte)1 },
                    { 1637, 83, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4590), 4, (byte)1 },
                    { 1638, 18, new DateTime(2022, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4594), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1639, 64, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4598), 2, (byte)0 },
                    { 1640, 95, new DateTime(2024, 1, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4601), 3, (byte)1 },
                    { 1641, 101, new DateTime(2023, 10, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4607), 5, (byte)1 },
                    { 1642, 60, new DateTime(2023, 3, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4611), 5, (byte)2 },
                    { 1643, 62, new DateTime(2024, 2, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4614), 5, (byte)1 },
                    { 1644, 14, new DateTime(2023, 6, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4618), 5, (byte)1 },
                    { 1645, 77, new DateTime(2023, 11, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4624), 5, (byte)1 },
                    { 1646, 104, new DateTime(2023, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4627), 2, (byte)1 },
                    { 1647, 38, new DateTime(2023, 6, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4630), 4, (byte)1 },
                    { 1648, 36, new DateTime(2022, 11, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4634), 4, (byte)0 },
                    { 1649, 85, new DateTime(2022, 10, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4640), 2, (byte)1 },
                    { 1650, 52, new DateTime(2022, 8, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4643), 6, (byte)1 },
                    { 1651, 73, new DateTime(2023, 3, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4647), 2, (byte)1 },
                    { 1652, 13, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4650), 2, (byte)1 },
                    { 1653, 60, new DateTime(2023, 9, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4656), 4, (byte)1 },
                    { 1654, 61, new DateTime(2023, 10, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4660), 5, (byte)0 },
                    { 1655, 77, new DateTime(2022, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4663), 1, (byte)0 },
                    { 1656, 18, new DateTime(2024, 2, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4667), 6, (byte)1 },
                    { 1657, 103, new DateTime(2023, 4, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4673), 6, (byte)1 },
                    { 1658, 30, new DateTime(2023, 11, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4714), 5, (byte)1 },
                    { 1659, 99, new DateTime(2022, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4719), 3, (byte)1 },
                    { 1660, 3, new DateTime(2022, 11, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4722), 6, (byte)1 },
                    { 1661, 2, new DateTime(2023, 7, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4728), 5, (byte)1 },
                    { 1662, 89, new DateTime(2022, 8, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4732), 1, (byte)1 },
                    { 1663, 84, new DateTime(2023, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4736), 6, (byte)1 },
                    { 1664, 27, new DateTime(2023, 5, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4740), 4, (byte)0 },
                    { 1665, 51, new DateTime(2022, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4746), 2, (byte)2 },
                    { 1666, 35, new DateTime(2023, 4, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4749), 5, (byte)1 },
                    { 1667, 96, new DateTime(2024, 3, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4752), 3, (byte)1 },
                    { 1668, 92, new DateTime(2023, 7, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4756), 1, (byte)1 },
                    { 1669, 26, new DateTime(2022, 10, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4762), 4, (byte)1 },
                    { 1670, 46, new DateTime(2024, 2, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4766), 2, (byte)1 },
                    { 1671, 74, new DateTime(2024, 1, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4769), 4, (byte)1 },
                    { 1672, 27, new DateTime(2023, 10, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4772), 5, (byte)1 },
                    { 1673, 70, new DateTime(2024, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4778), 2, (byte)1 },
                    { 1674, 38, new DateTime(2022, 12, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4782), 1, (byte)1 },
                    { 1675, 62, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4785), 4, (byte)1 },
                    { 1676, 10, new DateTime(2022, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4789), 5, (byte)1 },
                    { 1677, 12, new DateTime(2023, 4, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4795), 2, (byte)1 },
                    { 1678, 102, new DateTime(2023, 12, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4798), 4, (byte)1 },
                    { 1679, 102, new DateTime(2023, 6, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4802), 6, (byte)0 },
                    { 1680, 75, new DateTime(2023, 11, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4805), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1681, 62, new DateTime(2022, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4811), 1, (byte)1 },
                    { 1682, 106, new DateTime(2022, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4814), 3, (byte)1 },
                    { 1683, 32, new DateTime(2023, 5, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4818), 1, (byte)1 },
                    { 1684, 87, new DateTime(2022, 12, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4822), 6, (byte)1 },
                    { 1685, 21, new DateTime(2023, 7, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4828), 2, (byte)1 },
                    { 1686, 91, new DateTime(2022, 12, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4832), 3, (byte)0 },
                    { 1687, 8, new DateTime(2023, 3, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4835), 5, (byte)1 },
                    { 1688, 35, new DateTime(2023, 7, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4838), 1, (byte)1 },
                    { 1689, 49, new DateTime(2023, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4844), 6, (byte)1 },
                    { 1690, 7, new DateTime(2023, 10, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4848), 1, (byte)1 },
                    { 1691, 16, new DateTime(2023, 11, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4852), 5, (byte)1 },
                    { 1692, 23, new DateTime(2023, 8, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4855), 2, (byte)1 },
                    { 1693, 63, new DateTime(2023, 3, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4860), 4, (byte)1 },
                    { 1694, 23, new DateTime(2023, 4, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4864), 1, (byte)1 },
                    { 1695, 70, new DateTime(2023, 1, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4868), 5, (byte)0 },
                    { 1696, 5, new DateTime(2023, 3, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4871), 4, (byte)1 },
                    { 1697, 89, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4877), 3, (byte)2 },
                    { 1698, 93, new DateTime(2022, 9, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4881), 4, (byte)1 },
                    { 1699, 18, new DateTime(2022, 10, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4884), 4, (byte)1 },
                    { 1700, 45, new DateTime(2022, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4888), 5, (byte)1 },
                    { 1701, 53, new DateTime(2024, 3, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4895), 6, (byte)2 },
                    { 1702, 26, new DateTime(2022, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4898), 4, (byte)1 },
                    { 1703, 56, new DateTime(2023, 5, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4902), 5, (byte)1 },
                    { 1704, 57, new DateTime(2023, 4, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4906), 4, (byte)1 },
                    { 1705, 87, new DateTime(2023, 9, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4911), 3, (byte)1 },
                    { 1706, 49, new DateTime(2022, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4915), 3, (byte)1 },
                    { 1707, 82, new DateTime(2023, 6, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4919), 1, (byte)1 },
                    { 1708, 48, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4922), 5, (byte)1 },
                    { 1709, 34, new DateTime(2023, 4, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4928), 2, (byte)1 },
                    { 1710, 4, new DateTime(2023, 1, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4932), 5, (byte)1 },
                    { 1711, 91, new DateTime(2022, 12, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4935), 4, (byte)1 },
                    { 1712, 52, new DateTime(2022, 11, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4939), 5, (byte)1 },
                    { 1713, 23, new DateTime(2023, 1, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4945), 3, (byte)1 },
                    { 1714, 44, new DateTime(2023, 12, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4948), 1, (byte)1 },
                    { 1715, 82, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4952), 3, (byte)1 },
                    { 1716, 96, new DateTime(2022, 9, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4955), 5, (byte)1 },
                    { 1717, 17, new DateTime(2023, 10, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4961), 1, (byte)1 },
                    { 1718, 61, new DateTime(2022, 8, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4964), 5, (byte)1 },
                    { 1719, 52, new DateTime(2023, 12, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4968), 2, (byte)1 },
                    { 1720, 9, new DateTime(2023, 2, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(4971), 6, (byte)1 },
                    { 1721, 78, new DateTime(2023, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5005), 4, (byte)1 },
                    { 1722, 35, new DateTime(2022, 8, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5009), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1723, 62, new DateTime(2022, 11, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5013), 2, (byte)1 },
                    { 1724, 12, new DateTime(2022, 10, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5017), 6, (byte)1 },
                    { 1725, 44, new DateTime(2023, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5023), 6, (byte)1 },
                    { 1726, 11, new DateTime(2022, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5026), 4, (byte)1 },
                    { 1727, 40, new DateTime(2024, 1, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5030), 1, (byte)1 },
                    { 1728, 69, new DateTime(2022, 11, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5034), 3, (byte)2 },
                    { 1729, 52, new DateTime(2023, 7, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5039), 3, (byte)1 },
                    { 1730, 104, new DateTime(2023, 6, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5043), 4, (byte)1 },
                    { 1731, 10, new DateTime(2022, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5046), 4, (byte)1 },
                    { 1732, 18, new DateTime(2023, 4, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5050), 4, (byte)1 },
                    { 1733, 73, new DateTime(2023, 8, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5056), 5, (byte)1 },
                    { 1734, 67, new DateTime(2023, 4, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5060), 4, (byte)1 },
                    { 1735, 43, new DateTime(2023, 4, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5063), 3, (byte)0 },
                    { 1736, 101, new DateTime(2024, 3, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5067), 5, (byte)2 },
                    { 1737, 57, new DateTime(2024, 2, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5072), 6, (byte)1 },
                    { 1738, 104, new DateTime(2023, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5076), 3, (byte)1 },
                    { 1739, 87, new DateTime(2022, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5079), 2, (byte)1 },
                    { 1740, 27, new DateTime(2024, 2, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5083), 1, (byte)1 },
                    { 1741, 4, new DateTime(2023, 1, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5088), 5, (byte)1 },
                    { 1742, 66, new DateTime(2024, 3, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5092), 1, (byte)0 },
                    { 1743, 40, new DateTime(2022, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5096), 4, (byte)1 },
                    { 1744, 53, new DateTime(2023, 4, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5099), 4, (byte)1 },
                    { 1745, 47, new DateTime(2023, 9, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5105), 5, (byte)1 },
                    { 1746, 27, new DateTime(2024, 3, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5108), 2, (byte)2 },
                    { 1747, 92, new DateTime(2022, 8, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5112), 1, (byte)1 },
                    { 1748, 51, new DateTime(2023, 12, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5115), 6, (byte)1 },
                    { 1749, 80, new DateTime(2022, 12, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5121), 1, (byte)0 },
                    { 1750, 80, new DateTime(2022, 12, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5125), 3, (byte)1 },
                    { 1751, 42, new DateTime(2022, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5128), 4, (byte)0 },
                    { 1752, 11, new DateTime(2023, 1, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5132), 2, (byte)1 },
                    { 1753, 51, new DateTime(2023, 1, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5137), 1, (byte)1 },
                    { 1754, 69, new DateTime(2024, 2, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5141), 6, (byte)0 },
                    { 1755, 24, new DateTime(2023, 12, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5145), 1, (byte)1 },
                    { 1756, 64, new DateTime(2022, 12, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5149), 1, (byte)1 },
                    { 1757, 90, new DateTime(2024, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5154), 2, (byte)1 },
                    { 1758, 90, new DateTime(2023, 1, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5158), 3, (byte)1 },
                    { 1759, 96, new DateTime(2023, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5161), 1, (byte)1 },
                    { 1760, 28, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5164), 6, (byte)1 },
                    { 1761, 47, new DateTime(2024, 1, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5170), 1, (byte)1 },
                    { 1762, 50, new DateTime(2022, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5173), 1, (byte)1 },
                    { 1763, 46, new DateTime(2022, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5177), 1, (byte)1 },
                    { 1764, 26, new DateTime(2022, 8, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5180), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1765, 79, new DateTime(2024, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5186), 4, (byte)1 },
                    { 1766, 45, new DateTime(2022, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5190), 2, (byte)1 },
                    { 1767, 49, new DateTime(2023, 1, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5194), 5, (byte)1 },
                    { 1768, 71, new DateTime(2023, 6, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5198), 5, (byte)1 },
                    { 1769, 104, new DateTime(2022, 10, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5204), 5, (byte)1 },
                    { 1770, 20, new DateTime(2023, 3, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5208), 3, (byte)0 },
                    { 1771, 5, new DateTime(2023, 5, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5211), 2, (byte)1 },
                    { 1772, 19, new DateTime(2023, 11, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5215), 5, (byte)1 },
                    { 1773, 91, new DateTime(2024, 3, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5221), 5, (byte)1 },
                    { 1774, 72, new DateTime(2022, 11, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5225), 3, (byte)1 },
                    { 1775, 58, new DateTime(2022, 8, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5228), 2, (byte)2 },
                    { 1776, 54, new DateTime(2024, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5232), 5, (byte)0 },
                    { 1777, 58, new DateTime(2022, 10, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5238), 5, (byte)1 },
                    { 1778, 101, new DateTime(2023, 3, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5241), 5, (byte)1 },
                    { 1779, 65, new DateTime(2022, 11, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5245), 5, (byte)1 },
                    { 1780, 46, new DateTime(2024, 2, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5248), 2, (byte)0 },
                    { 1781, 82, new DateTime(2022, 10, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5254), 1, (byte)0 },
                    { 1782, 5, new DateTime(2023, 7, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5257), 3, (byte)2 },
                    { 1783, 10, new DateTime(2024, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5261), 5, (byte)1 },
                    { 1784, 35, new DateTime(2023, 9, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5264), 6, (byte)2 },
                    { 1785, 46, new DateTime(2022, 8, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5303), 1, (byte)1 },
                    { 1786, 71, new DateTime(2022, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5308), 3, (byte)1 },
                    { 1787, 101, new DateTime(2023, 4, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5311), 4, (byte)1 },
                    { 1788, 74, new DateTime(2023, 7, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5315), 1, (byte)0 },
                    { 1789, 102, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5320), 4, (byte)1 },
                    { 1790, 95, new DateTime(2023, 5, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5324), 2, (byte)1 },
                    { 1791, 91, new DateTime(2024, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5328), 1, (byte)1 },
                    { 1792, 47, new DateTime(2022, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5331), 5, (byte)1 },
                    { 1793, 41, new DateTime(2023, 5, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5338), 4, (byte)1 },
                    { 1794, 34, new DateTime(2023, 6, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5341), 4, (byte)1 },
                    { 1795, 28, new DateTime(2024, 2, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5345), 6, (byte)1 },
                    { 1796, 84, new DateTime(2022, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5349), 1, (byte)1 },
                    { 1797, 40, new DateTime(2022, 8, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5354), 6, (byte)1 },
                    { 1798, 81, new DateTime(2022, 8, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5358), 1, (byte)1 },
                    { 1799, 62, new DateTime(2023, 6, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5362), 2, (byte)1 },
                    { 1800, 35, new DateTime(2023, 5, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5365), 2, (byte)1 },
                    { 1801, 26, new DateTime(2023, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5370), 2, (byte)1 },
                    { 1802, 60, new DateTime(2023, 2, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5374), 3, (byte)1 },
                    { 1803, 57, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5377), 5, (byte)1 },
                    { 1804, 23, new DateTime(2023, 11, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5381), 5, (byte)1 },
                    { 1805, 37, new DateTime(2023, 4, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5387), 6, (byte)1 },
                    { 1806, 103, new DateTime(2023, 3, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5391), 3, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1807, 47, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5394), 6, (byte)1 },
                    { 1808, 34, new DateTime(2023, 6, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5398), 6, (byte)1 },
                    { 1809, 51, new DateTime(2022, 11, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5403), 1, (byte)1 },
                    { 1810, 85, new DateTime(2023, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5407), 4, (byte)1 },
                    { 1811, 101, new DateTime(2022, 8, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5411), 4, (byte)1 },
                    { 1812, 62, new DateTime(2022, 11, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5414), 6, (byte)1 },
                    { 1813, 6, new DateTime(2023, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5420), 1, (byte)1 },
                    { 1814, 74, new DateTime(2022, 9, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5423), 1, (byte)1 },
                    { 1815, 33, new DateTime(2023, 2, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5427), 1, (byte)1 },
                    { 1816, 90, new DateTime(2023, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5430), 6, (byte)1 },
                    { 1817, 95, new DateTime(2022, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5436), 3, (byte)1 },
                    { 1818, 96, new DateTime(2022, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5440), 6, (byte)1 },
                    { 1819, 49, new DateTime(2022, 8, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5443), 4, (byte)1 },
                    { 1820, 105, new DateTime(2022, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5447), 6, (byte)1 },
                    { 1821, 88, new DateTime(2023, 3, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5453), 2, (byte)1 },
                    { 1822, 94, new DateTime(2023, 7, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5456), 1, (byte)0 },
                    { 1823, 59, new DateTime(2023, 6, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5460), 2, (byte)0 },
                    { 1824, 22, new DateTime(2023, 11, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5464), 3, (byte)1 },
                    { 1825, 56, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5470), 1, (byte)1 },
                    { 1826, 100, new DateTime(2024, 3, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5473), 1, (byte)1 },
                    { 1827, 17, new DateTime(2022, 9, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5477), 1, (byte)1 },
                    { 1828, 23, new DateTime(2023, 2, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5480), 4, (byte)1 },
                    { 1829, 47, new DateTime(2023, 2, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5486), 3, (byte)1 },
                    { 1830, 71, new DateTime(2024, 1, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5490), 5, (byte)1 },
                    { 1831, 39, new DateTime(2023, 10, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5493), 6, (byte)1 },
                    { 1832, 80, new DateTime(2024, 2, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5497), 1, (byte)1 },
                    { 1833, 47, new DateTime(2022, 12, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5502), 3, (byte)1 },
                    { 1834, 67, new DateTime(2023, 9, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5506), 5, (byte)0 },
                    { 1835, 78, new DateTime(2024, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5510), 3, (byte)1 },
                    { 1836, 34, new DateTime(2022, 11, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5513), 3, (byte)1 },
                    { 1837, 52, new DateTime(2023, 10, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5519), 2, (byte)0 },
                    { 1838, 22, new DateTime(2023, 1, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5523), 2, (byte)1 },
                    { 1839, 48, new DateTime(2023, 12, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5526), 6, (byte)1 },
                    { 1840, 100, new DateTime(2023, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5530), 3, (byte)1 },
                    { 1841, 35, new DateTime(2024, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5536), 1, (byte)0 },
                    { 1842, 58, new DateTime(2022, 10, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5540), 4, (byte)1 },
                    { 1843, 11, new DateTime(2023, 12, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5544), 3, (byte)1 },
                    { 1844, 6, new DateTime(2022, 10, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5547), 1, (byte)1 },
                    { 1845, 60, new DateTime(2024, 3, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5554), 6, (byte)1 },
                    { 1846, 6, new DateTime(2023, 9, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5558), 2, (byte)0 },
                    { 1847, 70, new DateTime(2023, 3, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5561), 2, (byte)1 },
                    { 1848, 3, new DateTime(2023, 2, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5565), 2, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1849, 36, new DateTime(2023, 9, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5602), 4, (byte)1 },
                    { 1850, 34, new DateTime(2022, 10, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5606), 5, (byte)1 },
                    { 1851, 27, new DateTime(2022, 11, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5610), 3, (byte)1 },
                    { 1852, 53, new DateTime(2023, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5614), 5, (byte)1 },
                    { 1853, 8, new DateTime(2023, 9, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5619), 5, (byte)0 },
                    { 1854, 106, new DateTime(2023, 7, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5623), 1, (byte)0 },
                    { 1855, 89, new DateTime(2023, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5627), 3, (byte)1 },
                    { 1856, 30, new DateTime(2022, 12, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5630), 1, (byte)1 },
                    { 1857, 11, new DateTime(2023, 9, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5636), 6, (byte)1 },
                    { 1858, 44, new DateTime(2022, 9, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5639), 5, (byte)1 },
                    { 1859, 23, new DateTime(2023, 1, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5643), 6, (byte)1 },
                    { 1860, 45, new DateTime(2023, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5646), 4, (byte)1 },
                    { 1861, 38, new DateTime(2023, 9, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5652), 4, (byte)0 },
                    { 1862, 70, new DateTime(2023, 11, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5657), 2, (byte)1 },
                    { 1863, 81, new DateTime(2023, 2, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5660), 3, (byte)1 },
                    { 1864, 65, new DateTime(2023, 3, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5664), 3, (byte)1 },
                    { 1865, 87, new DateTime(2023, 10, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5670), 4, (byte)1 },
                    { 1866, 19, new DateTime(2023, 1, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5674), 4, (byte)1 },
                    { 1867, 97, new DateTime(2023, 1, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5678), 2, (byte)1 },
                    { 1868, 46, new DateTime(2022, 11, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5681), 6, (byte)1 },
                    { 1869, 81, new DateTime(2023, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5687), 1, (byte)0 },
                    { 1870, 84, new DateTime(2022, 12, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5691), 4, (byte)1 },
                    { 1871, 63, new DateTime(2023, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5695), 5, (byte)1 },
                    { 1872, 33, new DateTime(2023, 1, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5698), 1, (byte)1 },
                    { 1873, 10, new DateTime(2022, 10, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5704), 2, (byte)0 },
                    { 1874, 7, new DateTime(2022, 12, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5708), 4, (byte)1 },
                    { 1875, 68, new DateTime(2023, 9, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5712), 2, (byte)2 },
                    { 1876, 66, new DateTime(2022, 10, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5715), 3, (byte)1 },
                    { 1877, 39, new DateTime(2023, 7, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5721), 1, (byte)1 },
                    { 1878, 75, new DateTime(2023, 1, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5724), 3, (byte)1 },
                    { 1879, 105, new DateTime(2023, 8, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5727), 1, (byte)1 },
                    { 1880, 41, new DateTime(2022, 12, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5731), 3, (byte)1 },
                    { 1881, 86, new DateTime(2022, 9, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5737), 2, (byte)1 },
                    { 1882, 2, new DateTime(2023, 1, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5740), 3, (byte)1 },
                    { 1883, 71, new DateTime(2023, 3, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5744), 2, (byte)1 },
                    { 1884, 53, new DateTime(2022, 10, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5748), 1, (byte)1 },
                    { 1885, 43, new DateTime(2023, 7, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5753), 5, (byte)1 },
                    { 1886, 13, new DateTime(2024, 1, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5757), 5, (byte)1 },
                    { 1887, 34, new DateTime(2022, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5760), 4, (byte)1 },
                    { 1888, 35, new DateTime(2023, 7, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5764), 1, (byte)1 },
                    { 1889, 57, new DateTime(2023, 12, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5770), 1, (byte)1 },
                    { 1890, 31, new DateTime(2024, 3, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5774), 4, (byte)0 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1891, 88, new DateTime(2024, 3, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5777), 5, (byte)1 },
                    { 1892, 18, new DateTime(2024, 2, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5781), 3, (byte)2 },
                    { 1893, 101, new DateTime(2022, 8, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5787), 3, (byte)1 },
                    { 1894, 91, new DateTime(2023, 12, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5791), 4, (byte)1 },
                    { 1895, 52, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5794), 2, (byte)0 },
                    { 1896, 7, new DateTime(2023, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5798), 6, (byte)1 },
                    { 1897, 89, new DateTime(2024, 2, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5803), 2, (byte)1 },
                    { 1898, 47, new DateTime(2023, 7, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5807), 2, (byte)1 },
                    { 1899, 29, new DateTime(2023, 9, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5811), 1, (byte)1 },
                    { 1900, 75, new DateTime(2023, 9, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5814), 3, (byte)1 },
                    { 1901, 17, new DateTime(2022, 8, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5820), 5, (byte)0 },
                    { 1902, 10, new DateTime(2023, 6, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5823), 1, (byte)1 },
                    { 1903, 26, new DateTime(2023, 9, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5827), 4, (byte)1 },
                    { 1904, 70, new DateTime(2022, 8, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5831), 4, (byte)1 },
                    { 1905, 5, new DateTime(2024, 2, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5837), 2, (byte)1 },
                    { 1906, 42, new DateTime(2022, 8, 11, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5840), 6, (byte)1 },
                    { 1907, 18, new DateTime(2022, 8, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5844), 2, (byte)1 },
                    { 1908, 85, new DateTime(2023, 9, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5848), 5, (byte)1 },
                    { 1909, 35, new DateTime(2023, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5853), 2, (byte)1 },
                    { 1910, 61, new DateTime(2023, 8, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5857), 4, (byte)1 },
                    { 1911, 39, new DateTime(2022, 11, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5860), 4, (byte)0 },
                    { 1912, 95, new DateTime(2022, 9, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5864), 4, (byte)0 },
                    { 1913, 41, new DateTime(2024, 3, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5898), 2, (byte)1 },
                    { 1914, 48, new DateTime(2023, 12, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5902), 4, (byte)1 },
                    { 1915, 55, new DateTime(2023, 1, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5905), 4, (byte)1 },
                    { 1916, 15, new DateTime(2023, 9, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5909), 4, (byte)1 },
                    { 1917, 33, new DateTime(2023, 4, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5914), 5, (byte)1 },
                    { 1918, 97, new DateTime(2023, 7, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5918), 1, (byte)1 },
                    { 1919, 52, new DateTime(2022, 8, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5922), 1, (byte)1 },
                    { 1920, 106, new DateTime(2023, 12, 28, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5926), 6, (byte)1 },
                    { 1921, 75, new DateTime(2023, 8, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5932), 6, (byte)1 },
                    { 1922, 86, new DateTime(2024, 1, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5936), 4, (byte)1 },
                    { 1923, 86, new DateTime(2023, 12, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5939), 6, (byte)1 },
                    { 1924, 70, new DateTime(2023, 11, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5943), 2, (byte)1 },
                    { 1925, 28, new DateTime(2023, 12, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5948), 1, (byte)1 },
                    { 1926, 44, new DateTime(2023, 5, 10, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5952), 6, (byte)1 },
                    { 1927, 58, new DateTime(2024, 1, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5955), 5, (byte)1 },
                    { 1928, 12, new DateTime(2023, 4, 14, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5959), 6, (byte)1 },
                    { 1929, 48, new DateTime(2024, 3, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5965), 3, (byte)1 },
                    { 1930, 12, new DateTime(2024, 1, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5969), 3, (byte)1 },
                    { 1931, 61, new DateTime(2023, 9, 1, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5972), 3, (byte)1 },
                    { 1932, 106, new DateTime(2023, 11, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5976), 6, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1933, 98, new DateTime(2022, 11, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5982), 4, (byte)1 },
                    { 1934, 65, new DateTime(2023, 8, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5986), 2, (byte)0 },
                    { 1935, 35, new DateTime(2022, 9, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5990), 4, (byte)1 },
                    { 1936, 22, new DateTime(2023, 7, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(5994), 6, (byte)0 },
                    { 1937, 103, new DateTime(2022, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6000), 4, (byte)1 },
                    { 1938, 2, new DateTime(2023, 6, 27, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6004), 2, (byte)1 },
                    { 1939, 18, new DateTime(2023, 2, 17, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6007), 6, (byte)1 },
                    { 1940, 102, new DateTime(2023, 9, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6011), 2, (byte)1 },
                    { 1941, 18, new DateTime(2023, 6, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6016), 4, (byte)1 },
                    { 1942, 39, new DateTime(2023, 11, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6020), 6, (byte)1 },
                    { 1943, 95, new DateTime(2023, 10, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6023), 3, (byte)1 },
                    { 1944, 52, new DateTime(2023, 10, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6027), 2, (byte)1 },
                    { 1945, 23, new DateTime(2022, 12, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6033), 6, (byte)1 },
                    { 1946, 57, new DateTime(2022, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6037), 2, (byte)1 },
                    { 1947, 21, new DateTime(2022, 10, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6040), 2, (byte)1 },
                    { 1948, 42, new DateTime(2022, 11, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6044), 5, (byte)1 },
                    { 1949, 40, new DateTime(2023, 11, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6050), 1, (byte)1 },
                    { 1950, 58, new DateTime(2023, 12, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6053), 3, (byte)1 },
                    { 1951, 21, new DateTime(2023, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6057), 6, (byte)1 },
                    { 1952, 38, new DateTime(2024, 1, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6060), 2, (byte)0 },
                    { 1953, 60, new DateTime(2023, 8, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6066), 4, (byte)1 },
                    { 1954, 12, new DateTime(2022, 8, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6069), 1, (byte)1 },
                    { 1955, 9, new DateTime(2023, 3, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6073), 3, (byte)1 },
                    { 1956, 95, new DateTime(2023, 1, 20, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6076), 6, (byte)0 },
                    { 1957, 28, new DateTime(2022, 10, 24, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6082), 3, (byte)1 },
                    { 1958, 22, new DateTime(2023, 12, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6086), 6, (byte)1 },
                    { 1959, 67, new DateTime(2023, 3, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6090), 1, (byte)1 },
                    { 1960, 34, new DateTime(2023, 4, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6093), 1, (byte)1 },
                    { 1961, 64, new DateTime(2022, 10, 13, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6099), 5, (byte)1 },
                    { 1962, 24, new DateTime(2023, 11, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6103), 1, (byte)1 },
                    { 1963, 6, new DateTime(2024, 3, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6107), 6, (byte)1 },
                    { 1964, 76, new DateTime(2023, 8, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6110), 6, (byte)1 },
                    { 1965, 13, new DateTime(2023, 1, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6116), 4, (byte)1 },
                    { 1966, 24, new DateTime(2023, 7, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6120), 4, (byte)0 },
                    { 1967, 62, new DateTime(2023, 1, 23, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6123), 2, (byte)1 },
                    { 1968, 97, new DateTime(2023, 10, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6127), 2, (byte)1 },
                    { 1969, 82, new DateTime(2022, 11, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6133), 4, (byte)2 },
                    { 1970, 10, new DateTime(2023, 2, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6137), 1, (byte)0 },
                    { 1971, 23, new DateTime(2023, 2, 19, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6141), 5, (byte)1 },
                    { 1972, 45, new DateTime(2023, 11, 16, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6144), 2, (byte)0 },
                    { 1973, 46, new DateTime(2022, 9, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6149), 6, (byte)1 },
                    { 1974, 70, new DateTime(2024, 1, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6153), 1, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Helps",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "HelpCategoryId", "Status" },
                values: new object[,]
                {
                    { 1975, 67, new DateTime(2024, 3, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6157), 1, (byte)0 },
                    { 1976, 82, new DateTime(2023, 3, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6160), 3, (byte)0 },
                    { 1977, 84, new DateTime(2022, 9, 6, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6193), 3, (byte)1 },
                    { 1978, 23, new DateTime(2023, 10, 30, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6197), 5, (byte)1 },
                    { 1979, 6, new DateTime(2023, 11, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6201), 6, (byte)1 },
                    { 1980, 22, new DateTime(2023, 12, 12, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6205), 1, (byte)1 },
                    { 1981, 10, new DateTime(2024, 3, 15, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6211), 1, (byte)1 },
                    { 1982, 16, new DateTime(2023, 9, 5, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6215), 6, (byte)1 },
                    { 1983, 23, new DateTime(2023, 9, 25, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6218), 5, (byte)1 },
                    { 1984, 80, new DateTime(2023, 12, 29, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6222), 1, (byte)1 },
                    { 1985, 88, new DateTime(2022, 11, 18, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6227), 3, (byte)1 },
                    { 1986, 75, new DateTime(2024, 2, 9, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6231), 6, (byte)2 },
                    { 1987, 96, new DateTime(2023, 3, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6234), 1, (byte)1 },
                    { 1988, 8, new DateTime(2023, 5, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6238), 1, (byte)1 },
                    { 1989, 64, new DateTime(2024, 2, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6244), 5, (byte)1 },
                    { 1990, 23, new DateTime(2022, 9, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6247), 5, (byte)1 },
                    { 1991, 14, new DateTime(2023, 6, 2, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6251), 5, (byte)1 },
                    { 1992, 55, new DateTime(2023, 12, 4, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6255), 1, (byte)1 },
                    { 1993, 44, new DateTime(2023, 5, 8, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6260), 2, (byte)1 },
                    { 1994, 55, new DateTime(2023, 5, 26, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6264), 3, (byte)0 },
                    { 1995, 59, new DateTime(2023, 8, 31, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6268), 1, (byte)1 },
                    { 1996, 96, new DateTime(2022, 8, 7, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6271), 1, (byte)1 },
                    { 1997, 30, new DateTime(2023, 7, 3, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6278), 5, (byte)0 },
                    { 1998, 12, new DateTime(2023, 4, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6281), 5, (byte)1 },
                    { 1999, 99, new DateTime(2023, 10, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6285), 1, (byte)1 },
                    { 2000, 69, new DateTime(2023, 5, 21, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6288), 4, (byte)1 },
                    { 2001, 25, new DateTime(2023, 7, 22, 0, 11, 39, 505, DateTimeKind.Local).AddTicks(6294), 1, (byte)1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Helps_AuthorId",
                table: "Helps",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Helps_HelpCategoryId",
                table: "Helps",
                column: "HelpCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Helps");

            migrationBuilder.DropTable(
                name: "HelpCategories");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 106);
        }
    }
}
