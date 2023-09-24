using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaCritique.Data.Migrations
{
    public partial class UpdateMovieTable_AddScenePhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScenePhotoUrl",
                table: "Movies",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3779), "https://flxt.tmsimg.com/assets/p15987_k_h9_ac.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3817), "https://media.cnn.com/api/v1/images/stellar/prod/140702154952-02-forrest-gump-restricted.jpg?q=w_2434,h_1631,x_0,y_0,c_fill" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 23, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3820), "https://i.ytimg.com/vi/2UWD2uxIOis/maxresdefault.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3822), "https://media.cnn.com/api/v1/images/stellar/prod/230213144330-02-titanic-25th-anniversary-restricted.jpg?c=original" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3824), "https://miro.medium.com/v2/resize:fit:1200/1*4-1LWn65DlUF0uBLdIzo2A.jpeg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3828), "https://hop.dartmouth.edu/sites/hop.prod/files/styles/width_960/public/hop/content/gallery-item/image/star-wars-a-new-hope-gallery1.jpg?itok=3IPzJms_" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3830), "https://grist.org/wp-content/uploads/2016/05/gore-on-scissor-lift.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3833), "https://s.abcnews.com/images/Entertainment/GTY_the_sound_of_music_jef_131210_16x9_992.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3835), "https://legendary-digital-network-assets.s3.amazonaws.com/wp-content/uploads/2022/08/23111048/The-Two-Towers-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3838), "https://www.syfy.com/sites/syfy/files/2019/04/mv5botkxmzqymty3nl5bml5banbnxkftztcwmtu4mzczmw._v1_sx1471_cr001471999_al_.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3841), "https://i.ytimg.com/vi/x4mcmymd-5s/maxresdefault.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3843), "https://www.usatoday.com/gcdn/-mm-/b74c719214fb46f112bebb7fdd4e37d42f82f105/c=0-68-1280-791/local/-/media/2015/10/03/USATODAY/USATODAY/635794823832323546-HA-1604.jpg?width=1280&height=723&fit=crop&format=pjpg&auto=webp" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3845), "https://breakinggeek.files.wordpress.com/2015/01/thedarkknightd3176206dsuf4.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 19, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3847), "https://lh3.googleusercontent.com/RwOEZG7GP_aR1XcsYC0huOhVxY7lH4LP4KGUVJR_lrQ5ihPCGddNbjCN0CjmXi343yom_ABfg6CWL70a7778kJ1LJGWCQz3YAHRVgcmMI4JY3zfbLt4vflr1qhZoqzIde8AjwCkb" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3850), "https://i.ytimg.com/vi/2_I70o81fwk/maxresdefault.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3852), "https://cinemontage.org/wp-content/uploads/2017/02/BladeRunner_Feature-678x381.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3857), "https://media.npr.org/assets/img/2012/03/06/2_wide-dc2780d91910f6718c5e23f5f0a7ca3a7ee6c961-s1100-c50.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 22, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3860), "https://images.squarespace-cdn.com/content/v1/5bd4e5708dfc8cb34346c68b/1549963167505-IFYQTEWAHSM2U8S2T6DF/la_la_land_banner.jpg?format=1500w" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 20, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3863), "https://justkillingti.me/wp-content/2016/11/article-2109071-02e5ddd20000044d-817_964x591.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "ScenePhotoUrl" },
                values: new object[] { new DateTime(2023, 9, 21, 17, 14, 45, 239, DateTimeKind.Local).AddTicks(3865), "https://i.kinja-img.com/gawker-media/image/upload/c_fill,f_auto,fl_progressive,g_center,h_675,pg_1,q_80,w_1200/buj0nndhaegv5vje8yox.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScenePhotoUrl",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 9, 23, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2023, 9, 19, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateAdded",
                value: new DateTime(2023, 9, 22, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateAdded",
                value: new DateTime(2023, 9, 20, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateAdded",
                value: new DateTime(2023, 9, 21, 16, 48, 30, 389, DateTimeKind.Local).AddTicks(7771));
        }
    }
}
