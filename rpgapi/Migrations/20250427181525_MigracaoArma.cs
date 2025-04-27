using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_USUARIOS_TB_USUARIOS_UsuarioOgId",
                table: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIOS_UsuarioOgId",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "Classe",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_USUARIOS");

            migrationBuilder.DropColumn(
                name: "UsuarioOgId",
                table: "TB_USUARIOS");

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Paralizar");

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Fritar");

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Entrar na mente");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "email@gmail.com", new byte[] { 216, 193, 60, 10, 202, 249, 71, 210, 123, 184, 196, 96, 218, 32, 248, 9, 233, 133, 13, 160, 78, 215, 176, 168, 48, 216, 134, 249, 231, 25, 202, 10, 182, 78, 175, 177, 226, 45, 102, 25, 234, 129, 97, 2, 37, 79, 201, 194, 8, 242, 46, 77, 183, 115, 63, 147, 20, 123, 172, 227, 139, 114, 209, 107 }, new byte[] { 53, 195, 238, 197, 152, 250, 32, 91, 127, 9, 181, 185, 74, 49, 66, 126, 206, 84, 214, 237, 199, 220, 50, 165, 197, 238, 9, 160, 28, 40, 200, 13, 235, 227, 26, 226, 28, 242, 143, 28, 169, 194, 149, 218, 67, 212, 197, 168, 68, 237, 51, 222, 18, 121, 208, 133, 69, 131, 110, 62, 4, 149, 232, 180, 151, 149, 173, 113, 117, 20, 200, 83, 12, 35, 237, 12, 51, 162, 50, 186, 200, 251, 49, 240, 77, 13, 50, 222, 233, 76, 15, 240, 209, 73, 139, 64, 50, 8, 68, 91, 228, 55, 144, 111, 239, 177, 57, 175, 63, 203, 171, 187, 151, 152, 156, 208, 229, 109, 122, 208, 149, 61, 145, 175, 188, 114, 89, 148 }, "userAdm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Classe",
                table: "TB_USUARIOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "TB_USUARIOS",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_USUARIOS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioOgId",
                table: "TB_USUARIOS",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Adormecer");

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Congelar");

            migrationBuilder.UpdateData(
                table: "TB_HABILIDADES",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Hipnotizar");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Classe", "Email", "FotoPersonagem", "PasswordHash", "PasswordSalt", "Username", "UsuarioId", "UsuarioOgId" },
                values: new object[] { 0, "seuEmail@gmail.com", null, new byte[] { 242, 134, 154, 219, 42, 53, 198, 14, 166, 32, 27, 4, 199, 51, 98, 82, 200, 147, 240, 201, 134, 94, 154, 235, 44, 71, 221, 210, 67, 134, 55, 135, 80, 13, 95, 216, 105, 19, 53, 114, 68, 152, 101, 78, 127, 180, 191, 227, 134, 154, 44, 4, 156, 89, 61, 183, 166, 231, 215, 189, 116, 167, 172, 215 }, new byte[] { 116, 68, 112, 143, 26, 14, 103, 123, 86, 132, 92, 67, 127, 7, 154, 117, 92, 232, 219, 254, 101, 181, 168, 14, 155, 208, 210, 12, 62, 150, 158, 76, 205, 211, 130, 8, 165, 137, 145, 106, 3, 215, 75, 174, 225, 126, 80, 86, 184, 139, 139, 62, 172, 30, 44, 125, 213, 203, 114, 85, 165, 14, 67, 85, 44, 201, 123, 55, 226, 99, 244, 118, 50, 194, 94, 142, 227, 248, 139, 255, 100, 11, 15, 135, 149, 88, 230, 7, 4, 142, 112, 253, 29, 227, 23, 197, 17, 191, 32, 93, 222, 161, 109, 8, 169, 234, 49, 92, 138, 23, 169, 152, 150, 177, 248, 252, 255, 34, 158, 245, 249, 160, 227, 2, 147, 117, 50, 62 }, "UsuarioAdmin", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIOS_UsuarioOgId",
                table: "TB_USUARIOS",
                column: "UsuarioOgId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_USUARIOS_TB_USUARIOS_UsuarioOgId",
                table: "TB_USUARIOS",
                column: "UsuarioOgId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }
    }
}
