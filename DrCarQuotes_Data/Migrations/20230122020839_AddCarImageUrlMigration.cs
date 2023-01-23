using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrCarQuotesData.Migrations
{
    /// <inheritdoc />
    public partial class AddCarImageUrlMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://i.ibb.co/ZNt3Xnb/bmw.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://i.ibb.co/Qm4HrKM/audi-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i.ibb.co/cgxsYC4/fiat-2-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://i.ibb.co/Sc1vPQn/toyota-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://i.ibb.co/wLLG760/acura-enclave-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://i.ibb.co/4Y6Yt8s/gmc-1-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://i.ibb.co/1v9dfs8/ford-escape-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://i.ibb.co/1v9dfs8/ford-escape-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://i.ibb.co/Qm4HrKM/audi-1.png");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://i.ibb.co/1bGzSvP/chey-1.png");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 47.312213084312699m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 218.754383944864762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 20.22049426119574m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 132.426705300368855m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 55.328425303505217m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 227.0518083183743818m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 35.548064434046597m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 225.780756725949687m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 36.268546475228598m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 144.0516588985954507m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 54.00160245844272477m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 215.0697211889277317m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 47.300177608197333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 221.693847453098608m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 22.517942901351891m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 141.239631841805552m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 67.0425591562122543m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 201.329030867595497m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 38.379244379994079m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 218.834650964373058m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 20.271804040219893m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 139.775276550244331m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 52.898287504909777m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 233.738187629531762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 48.0581083268548536m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 216.799323109543249m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 47.57549913779744m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 135.744204695398043m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 53.925907007840102m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 223.937305614641835m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 35.216807598526473m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 215.0363692954289796m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 39.890588917431776m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 106.730544434883428m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 70.55578867162842m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 217.630431825183837m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 43.168970444824215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 180.686210896520596m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 32.149347082904349m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 130.940316426195264m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 56.352271561500141m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 247.047874321659869m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 42.00720355425229668m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 243.383744378059158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 36.239036465134924m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 100.708260181699112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 51.346273035944842m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 246.827464512219591m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 48.398029127898824m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 173.163889272636716m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 27.511737590053737m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 141.65121857555347m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 60.942566563730157m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 222.358290528657968m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 45.581692047234909m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 231.320295434432816m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 29.455336531781798m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 107.449138422568247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 51.672976825858211m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 222.760964493615421m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 35.452441524953747m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Price",
                value: 238.604779598875855m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Price",
                value: 26.239520774549831m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Price",
                value: 121.939470605556801m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Price",
                value: 82.101425792673251m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Price",
                value: 211.00479476949796043m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 33.200285367564105m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 258.79952611835248m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 46.230089676210644m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Price",
                value: 139.348438721368637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71,
                column: "Price",
                value: 79.671393156328473m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72,
                column: "Price",
                value: 206.0400476196276946m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 31.723985679556357m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74,
                column: "Price",
                value: 252.876030492711944m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75,
                column: "Price",
                value: 33.27930290874493m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 136.881426910299284m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77,
                column: "Price",
                value: 59.749322416167304m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78,
                column: "Price",
                value: 216.892189908686213m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: 49.918887990502118m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: 178.645396689046043m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: 42.472362718472046m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82,
                column: "Price",
                value: 127.617739471667535m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83,
                column: "Price",
                value: 55.672056091223254m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84,
                column: "Price",
                value: 224.581435702959407m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85,
                column: "Price",
                value: 38.40424746068333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86,
                column: "Price",
                value: 223.0463085542760757m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87,
                column: "Price",
                value: 40.367973831650155m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88,
                column: "Price",
                value: 147.226150488565558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 75.603446634138369m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90,
                column: "Price",
                value: 225.712929878401101m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91,
                column: "Price",
                value: 45.924913950866541m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92,
                column: "Price",
                value: 151.173845687524107m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93,
                column: "Price",
                value: 26.220425772821158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94,
                column: "Price",
                value: 136.332306985426421m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95,
                column: "Price",
                value: 52.291788983395762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 222.0608678807722649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 38.273842180908053m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 98,
                column: "Price",
                value: 252.115817346745131m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 99,
                column: "Price",
                value: 20.775113420593288m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 138.261450201609583m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 63.551331305704126m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 102,
                column: "Price",
                value: 237.533140588395579m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 103,
                column: "Price",
                value: 39.159411402736157m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 104,
                column: "Price",
                value: 253.391337618226808m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 105,
                column: "Price",
                value: 36.129125285080329m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 106,
                column: "Price",
                value: 117.729123624752566m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 107,
                column: "Price",
                value: 51.726816048400115m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 108,
                column: "Price",
                value: 241.0950503040379469m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 109,
                column: "Price",
                value: 30.0458127933345766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 110,
                column: "Price",
                value: 178.21602119414782m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 111,
                column: "Price",
                value: 46.686023189906853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 112,
                column: "Price",
                value: 129.186682795307693m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 113,
                column: "Price",
                value: 49.996071359780354m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 114,
                column: "Price",
                value: 205.598156148391398m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 47.986457261702356m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 116,
                column: "Price",
                value: 153.507487788908444m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 117,
                column: "Price",
                value: 39.459842912190818m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 118,
                column: "Price",
                value: 141.600394045136385m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 119,
                column: "Price",
                value: 80.429939508277224m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 120,
                column: "Price",
                value: 202.653282867009249m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 47.48592402884829m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 122,
                column: "Price",
                value: 188.416322661515414m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 123,
                column: "Price",
                value: 44.386100941566902m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 124,
                column: "Price",
                value: 142.378279911532235m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 125,
                column: "Price",
                value: 67.491508568747318m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 126,
                column: "Price",
                value: 241.576280492288014m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 127,
                column: "Price",
                value: 42.0975722580251598m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 128,
                column: "Price",
                value: 241.223952952185067m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 129,
                column: "Price",
                value: 37.796351782308176m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 130,
                column: "Price",
                value: 121.286328211903058m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 131,
                column: "Price",
                value: 45.0738670428143239m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 132,
                column: "Price",
                value: 224.956194236837793m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 133,
                column: "Price",
                value: 36.492620727785478m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 134,
                column: "Price",
                value: 216.0656476762969168m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 135,
                column: "Price",
                value: 20.989364126882714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 136,
                column: "Price",
                value: 109.31685171127787m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 137,
                column: "Price",
                value: 80.399069135979398m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 138,
                column: "Price",
                value: 241.59472359459734m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 139,
                column: "Price",
                value: 49.375636484103183m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 140,
                column: "Price",
                value: 153.555384848403695m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 141,
                column: "Price",
                value: 26.548975143046855m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 142,
                column: "Price",
                value: 116.114637018853096m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 143,
                column: "Price",
                value: 57.503884324026686m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 144,
                column: "Price",
                value: 228.0994814555809404m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 145,
                column: "Price",
                value: 37.350987442793067m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 146,
                column: "Price",
                value: 219.0664905695719566m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 147,
                column: "Price",
                value: 46.869680012882974m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 148,
                column: "Price",
                value: 101.258970036220788m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 149,
                column: "Price",
                value: 60.467819540049108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 150,
                column: "Price",
                value: 229.773757732949443m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 151,
                column: "Price",
                value: 48.396251365877848m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 202.745034385752412m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 153,
                column: "Price",
                value: 42.207865431686789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 154,
                column: "Price",
                value: 148.416923146328929m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 155,
                column: "Price",
                value: 50.963406996177254m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 156,
                column: "Price",
                value: 200.96222963477404m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 157,
                column: "Price",
                value: 48.239586974067498m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 158,
                column: "Price",
                value: 249.91603329766634m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 159,
                column: "Price",
                value: 25.932398992276828m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 160,
                column: "Price",
                value: 109.392747688688968m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 161,
                column: "Price",
                value: 58.0969297307871488m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 162,
                column: "Price",
                value: 245.923225241794294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 163,
                column: "Price",
                value: 45.720576447401003m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 164,
                column: "Price",
                value: 197.824650504951659m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 165,
                column: "Price",
                value: 29.599617124694926m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 166,
                column: "Price",
                value: 107.886018206489282m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 167,
                column: "Price",
                value: 47.635586621967219m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 168,
                column: "Price",
                value: 229.452920433374382m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 169,
                column: "Price",
                value: 34.95217504206835m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 170,
                column: "Price",
                value: 136.30541081980588m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 171,
                column: "Price",
                value: 30.480620738804783m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 172,
                column: "Price",
                value: 104.436449016990972m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 173,
                column: "Price",
                value: 45.521415497161643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 174,
                column: "Price",
                value: 201.194917025745435m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 175,
                column: "Price",
                value: 30.935855831972602m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 176,
                column: "Price",
                value: 255.607414652539235m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 177,
                column: "Price",
                value: 43.604402494200219m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 178,
                column: "Price",
                value: 140.0294867091936686m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 179,
                column: "Price",
                value: 48.442847865599889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 180,
                column: "Price",
                value: 213.190740150117942m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 49.435332212307563m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 182,
                column: "Price",
                value: 169.313126404552041m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 183,
                column: "Price",
                value: 25.611286032094847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 184,
                column: "Price",
                value: 113.668344469826397m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 185,
                column: "Price",
                value: 46.505885346488097m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 186,
                column: "Price",
                value: 227.132286251869124m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 187,
                column: "Price",
                value: 35.899477885829038m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 188,
                column: "Price",
                value: 238.986657089503318m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 189,
                column: "Price",
                value: 24.0625934495898951m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 190,
                column: "Price",
                value: 139.727494056760661m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 191,
                column: "Price",
                value: 67.41957757954287m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 192,
                column: "Price",
                value: 226.815572387458993m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 193,
                column: "Price",
                value: 39.706005155546814m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 194,
                column: "Price",
                value: 253.199409806083627m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 195,
                column: "Price",
                value: 32.436186601259768m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 196,
                column: "Price",
                value: 114.113363468416866m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 197,
                column: "Price",
                value: 52.747432323346815m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 198,
                column: "Price",
                value: 214.808107533893363m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 199,
                column: "Price",
                value: 39.386252060376002m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 200,
                column: "Price",
                value: 140.0393438201737045m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 201,
                column: "Price",
                value: 30.538501553749943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 202,
                column: "Price",
                value: 134.172935798390643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 203,
                column: "Price",
                value: 75.156796326385153m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 204,
                column: "Price",
                value: 244.14142247789961m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 205,
                column: "Price",
                value: 41.49854255691669m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 206,
                column: "Price",
                value: 203.959002337487739m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 207,
                column: "Price",
                value: 26.647928559804746m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 208,
                column: "Price",
                value: 124.225970124022313m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 209,
                column: "Price",
                value: 73.722811549818661m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 210,
                column: "Price",
                value: 217.324616032377505m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 211,
                column: "Price",
                value: 37.937585404562815m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 212,
                column: "Price",
                value: 234.924743615923036m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 213,
                column: "Price",
                value: 25.670196730949571m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 214,
                column: "Price",
                value: 132.232019442777425m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 215,
                column: "Price",
                value: 80.444194160751197m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 216,
                column: "Price",
                value: 224.691151932871634m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 217,
                column: "Price",
                value: 36.704259384665295m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 218,
                column: "Price",
                value: 194.0938661628172128m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 219,
                column: "Price",
                value: 35.131155242655974m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 220,
                column: "Price",
                value: 123.818540061340551m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 221,
                column: "Price",
                value: 80.361256610343646m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 222,
                column: "Price",
                value: 207.336538450097307m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 223,
                column: "Price",
                value: 40.973090630146111m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 224,
                column: "Price",
                value: 222.681813321389556m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 225,
                column: "Price",
                value: 31.865611754197453m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 226,
                column: "Price",
                value: 108.447409218901367m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 227,
                column: "Price",
                value: 52.74998575952943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 228,
                column: "Price",
                value: 228.515264324873878m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 229,
                column: "Price",
                value: 42.344928543165538m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 230,
                column: "Price",
                value: 145.900338662989125m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 231,
                column: "Price",
                value: 48.114564530796207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 232,
                column: "Price",
                value: 122.447243959420804m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 233,
                column: "Price",
                value: 62.254166591331697m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 234,
                column: "Price",
                value: 220.971497524019145m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 31.637912962151616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 236,
                column: "Price",
                value: 153.928645091440984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 237,
                column: "Price",
                value: 40.223474598326059m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 238,
                column: "Price",
                value: 135.146733731104087m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 239,
                column: "Price",
                value: 75.7526202448608m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 240,
                column: "Price",
                value: 230.262598386074875m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 241,
                column: "Price",
                value: 39.0890418190295578m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 242,
                column: "Price",
                value: 211.387956484132697m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 243,
                column: "Price",
                value: 48.390006900814853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 244,
                column: "Price",
                value: 110.894106118619311m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 245,
                column: "Price",
                value: 83.850192144669471m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 246,
                column: "Price",
                value: 246.167097645729189m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 247,
                column: "Price",
                value: 39.590911982479423m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 248,
                column: "Price",
                value: 226.207124114532496m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 249,
                column: "Price",
                value: 38.966573175440185m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 250,
                column: "Price",
                value: 122.0357469694980866m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 251,
                column: "Price",
                value: 75.635580731811453m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 252,
                column: "Price",
                value: 202.0631210442240914m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 253,
                column: "Price",
                value: 37.475651311293032m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 254,
                column: "Price",
                value: 240.929945231367956m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 255,
                column: "Price",
                value: 26.767191709039829m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 256,
                column: "Price",
                value: 111.794713945992362m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 257,
                column: "Price",
                value: 61.216403658819383m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 258,
                column: "Price",
                value: 232.60088874068124m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 259,
                column: "Price",
                value: 34.14522975446714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 260,
                column: "Price",
                value: 177.590726514963782m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 261,
                column: "Price",
                value: 28.365944002367229m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 262,
                column: "Price",
                value: 118.273165900952893m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 263,
                column: "Price",
                value: 82.238768779890175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 264,
                column: "Price",
                value: 222.956198405177524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 265,
                column: "Price",
                value: 45.909179599188516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 266,
                column: "Price",
                value: 189.472824401537395m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 46.117937798517691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 268,
                column: "Price",
                value: 149.953589630589617m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 269,
                column: "Price",
                value: 84.917749937074708m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 270,
                column: "Price",
                value: 220.327345535622964m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 271,
                column: "Price",
                value: 40.323097740167137m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 272,
                column: "Price",
                value: 210.167679968151146m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 24.88105607374148m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 274,
                column: "Price",
                value: 117.637300602116126m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 275,
                column: "Price",
                value: 72.427920610901002m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 276,
                column: "Price",
                value: 203.624839938563931m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 277,
                column: "Price",
                value: 48.668656402887127m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 278,
                column: "Price",
                value: 164.417602465500098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 279,
                column: "Price",
                value: 29.794787434445861m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 280,
                column: "Price",
                value: 105.27434906453957m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 281,
                column: "Price",
                value: 57.0867439686760961m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 203.732211935399358m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 283,
                column: "Price",
                value: 41.0721302939005536m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 284,
                column: "Price",
                value: 196.342910652848216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 285,
                column: "Price",
                value: 37.452474197917524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 286,
                column: "Price",
                value: 139.780189607952004m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 287,
                column: "Price",
                value: 54.407387397305966m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 288,
                column: "Price",
                value: 203.542675948471014m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 289,
                column: "Price",
                value: 45.176056848167777m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 290,
                column: "Price",
                value: 209.329542652595717m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 291,
                column: "Price",
                value: 36.296856867030545m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 292,
                column: "Price",
                value: 127.192985993914555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 293,
                column: "Price",
                value: 86.483641150852294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 294,
                column: "Price",
                value: 237.497683696960982m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 295,
                column: "Price",
                value: 30.425586224329487m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 296,
                column: "Price",
                value: 210.416904647306649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 297,
                column: "Price",
                value: 43.276083200853143m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 298,
                column: "Price",
                value: 148.651681662749486m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 299,
                column: "Price",
                value: 55.606714424507216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 300,
                column: "Price",
                value: 205.613411067723445m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 301,
                column: "Price",
                value: 48.186551961458063m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 302,
                column: "Price",
                value: 166.451830642600516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 303,
                column: "Price",
                value: 28.501539180998122m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 304,
                column: "Price",
                value: 110.71831453702392m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 305,
                column: "Price",
                value: 64.428867408525465m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 306,
                column: "Price",
                value: 227.401571765455586m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 307,
                column: "Price",
                value: 30.904107826866038m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 308,
                column: "Price",
                value: 172.691212189428787m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 309,
                column: "Price",
                value: 41.795240755999042m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 310,
                column: "Price",
                value: 129.733515384905016m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 311,
                column: "Price",
                value: 53.311506517018994m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 312,
                column: "Price",
                value: 246.307927034715928m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 313,
                column: "Price",
                value: 37.369338410172474m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 314,
                column: "Price",
                value: 180.162955067400738m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 315,
                column: "Price",
                value: 27.839159424953653m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 316,
                column: "Price",
                value: 149.333834064149465m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 317,
                column: "Price",
                value: 57.317617453339889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 318,
                column: "Price",
                value: 246.271631245730518m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 319,
                column: "Price",
                value: 45.792984568764062m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 139.377212722593428m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 321,
                column: "Price",
                value: 20.017907491218857m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 322,
                column: "Price",
                value: 123.538802972374326m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 323,
                column: "Price",
                value: 46.590018825317151m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 324,
                column: "Price",
                value: 234.337988788735643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 325,
                column: "Price",
                value: 38.33521114243551m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 326,
                column: "Price",
                value: 164.828342414629371m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 327,
                column: "Price",
                value: 26.130616565396805m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 328,
                column: "Price",
                value: 146.924646196938054m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 329,
                column: "Price",
                value: 67.568244565557926m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 330,
                column: "Price",
                value: 241.516120648555212m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 331,
                column: "Price",
                value: 41.248578766367384m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 332,
                column: "Price",
                value: 197.143247621437529m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 333,
                column: "Price",
                value: 26.65026383468999m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 122.75410380884612m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 335,
                column: "Price",
                value: 49.457860671625785m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 336,
                column: "Price",
                value: 222.786006644030454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 337,
                column: "Price",
                value: 31.192973912442622m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 338,
                column: "Price",
                value: 259.34561824534538m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 339,
                column: "Price",
                value: 27.495398890749175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 340,
                column: "Price",
                value: 104.0249071335165321m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 341,
                column: "Price",
                value: 75.348163549940213m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 342,
                column: "Price",
                value: 206.385894740597076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 343,
                column: "Price",
                value: 46.2624038626944m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 179.182973492632373m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 345,
                column: "Price",
                value: 22.931160920313772m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 346,
                column: "Price",
                value: 123.353472524713674m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 347,
                column: "Price",
                value: 79.925335603655039m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 348,
                column: "Price",
                value: 235.599972706517068m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 349,
                column: "Price",
                value: 49.345379949378647m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 350,
                column: "Price",
                value: 142.85485342186158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 351,
                column: "Price",
                value: 46.0498489466068811m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 352,
                column: "Price",
                value: 112.369681532519117m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 353,
                column: "Price",
                value: 62.653090817467074m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 354,
                column: "Price",
                value: 237.71413123535137m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 355,
                column: "Price",
                value: 45.972882175012522m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 356,
                column: "Price",
                value: 191.979324361644688m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 357,
                column: "Price",
                value: 28.330091099125522m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 358,
                column: "Price",
                value: 146.560556795619328m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 359,
                column: "Price",
                value: 66.127631354566013m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 360,
                column: "Price",
                value: 242.546750194671449m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 361,
                column: "Price",
                value: 38.193697362495583m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 362,
                column: "Price",
                value: 173.942308206815939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 363,
                column: "Price",
                value: 35.90344386934738m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 364,
                column: "Price",
                value: 107.77654570976722m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 365,
                column: "Price",
                value: 66.425386072216925m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 366,
                column: "Price",
                value: 228.73511188918678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 367,
                column: "Price",
                value: 35.0153736392073515m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 368,
                column: "Price",
                value: 161.708556606386718m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 369,
                column: "Price",
                value: 34.34177811072544m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 370,
                column: "Price",
                value: 116.11385388237692m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 371,
                column: "Price",
                value: 86.36360814122577m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 372,
                column: "Price",
                value: 214.0616192839372723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 373,
                column: "Price",
                value: 42.323989491647058m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 374,
                column: "Price",
                value: 218.37509990444189m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 375,
                column: "Price",
                value: 36.881225916652766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 376,
                column: "Price",
                value: 127.434533867512098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 377,
                column: "Price",
                value: 62.351772738075892m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 378,
                column: "Price",
                value: 243.780811498104491m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 379,
                column: "Price",
                value: 45.985115542053807m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 380,
                column: "Price",
                value: 255.502582080800603m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 381,
                column: "Price",
                value: 38.274448788852314m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 382,
                column: "Price",
                value: 141.91041479918467m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 383,
                column: "Price",
                value: 67.872908480936426m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 384,
                column: "Price",
                value: 207.22686821331184m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 385,
                column: "Price",
                value: 34.0658705126388829m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 386,
                column: "Price",
                value: 142.945561151670862m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 387,
                column: "Price",
                value: 46.00491342321470578m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 388,
                column: "Price",
                value: 127.191904040325061m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 389,
                column: "Price",
                value: 72.0950683669047714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 390,
                column: "Price",
                value: 237.306494859415483m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 391,
                column: "Price",
                value: 40.0818644816486925m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 392,
                column: "Price",
                value: 182.954393062624044m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 393,
                column: "Price",
                value: 29.374873539678602m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 394,
                column: "Price",
                value: 149.483084724495066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 395,
                column: "Price",
                value: 49.478205919638794m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 396,
                column: "Price",
                value: 208.0240180426713636m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 397,
                column: "Price",
                value: 49.984404217780643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 398,
                column: "Price",
                value: 168.52148855780392m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 399,
                column: "Price",
                value: 42.374827135804039m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 400,
                column: "Price",
                value: 103.272486961287067m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 401,
                column: "Price",
                value: 46.345804241003171m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 402,
                column: "Price",
                value: 248.170728095108175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 403,
                column: "Price",
                value: 45.824696284264503m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 404,
                column: "Price",
                value: 237.0790141355833778m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 405,
                column: "Price",
                value: 45.54912700629083m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 406,
                column: "Price",
                value: 115.185781535760306m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 407,
                column: "Price",
                value: 59.918475675342396m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 408,
                column: "Price",
                value: 244.308765122074868m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 409,
                column: "Price",
                value: 48.454023210904148m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 410,
                column: "Price",
                value: 255.711776622587688m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 411,
                column: "Price",
                value: 48.159242907982558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 412,
                column: "Price",
                value: 100.679731857827905m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 413,
                column: "Price",
                value: 51.468477600706892m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 414,
                column: "Price",
                value: 240.76765227937507m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 415,
                column: "Price",
                value: 35.0142264354965921m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 416,
                column: "Price",
                value: 213.77026006719938m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 417,
                column: "Price",
                value: 32.289434239729752m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 418,
                column: "Price",
                value: 127.0278405314420089m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 52.492619742551834m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 420,
                column: "Price",
                value: 248.265292345651955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 421,
                column: "Price",
                value: 47.174952106425066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 422,
                column: "Price",
                value: 228.168384308621536m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 423,
                column: "Price",
                value: 31.43208502233547m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 424,
                column: "Price",
                value: 108.794066841152358m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 425,
                column: "Price",
                value: 55.513630372115466m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 426,
                column: "Price",
                value: 219.279679285649144m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 427,
                column: "Price",
                value: 47.746133985476762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 428,
                column: "Price",
                value: 257.856795563877593m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 429,
                column: "Price",
                value: 47.732606647259851m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 430,
                column: "Price",
                value: 119.412788306188662m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 431,
                column: "Price",
                value: 73.918069855602306m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 432,
                column: "Price",
                value: 222.177856095782508m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 433,
                column: "Price",
                value: 45.703198022060746m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 434,
                column: "Price",
                value: 184.989658093289828m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 435,
                column: "Price",
                value: 25.224335538913624m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 436,
                column: "Price",
                value: 111.869780644958663m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 437,
                column: "Price",
                value: 76.513801884864776m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 438,
                column: "Price",
                value: 238.72221820981881m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 439,
                column: "Price",
                value: 41.740126568999927m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 440,
                column: "Price",
                value: 184.34720978632158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 441,
                column: "Price",
                value: 26.787420476400148m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 442,
                column: "Price",
                value: 105.244026830602589m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 443,
                column: "Price",
                value: 70.303008187596644m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 444,
                column: "Price",
                value: 234.929988600751368m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 445,
                column: "Price",
                value: 44.547131753900723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 446,
                column: "Price",
                value: 171.267017413615874m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 447,
                column: "Price",
                value: 35.694346415731915m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 448,
                column: "Price",
                value: 148.419989071195804m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 449,
                column: "Price",
                value: 62.59466281576631m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 450,
                column: "Price",
                value: 200.0923694113769618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 451,
                column: "Price",
                value: 31.656475614579434m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 452,
                column: "Price",
                value: 252.131920243824076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 453,
                column: "Price",
                value: 31.919492289212337m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 454,
                column: "Price",
                value: 114.94663095285594m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 455,
                column: "Price",
                value: 63.904579276707388m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 456,
                column: "Price",
                value: 218.0421860896729708m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 457,
                column: "Price",
                value: 39.906854705630413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 458,
                column: "Price",
                value: 250.1405199997596m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 459,
                column: "Price",
                value: 41.212063454429293m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 460,
                column: "Price",
                value: 107.559591333818055m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 461,
                column: "Price",
                value: 65.397007550268868m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 462,
                column: "Price",
                value: 223.743291411974594m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 463,
                column: "Price",
                value: 41.657045659362543m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 464,
                column: "Price",
                value: 209.789333999135055m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 465,
                column: "Price",
                value: 45.976057804906889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 466,
                column: "Price",
                value: 116.306191139880355m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 467,
                column: "Price",
                value: 59.957905152789532m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 468,
                column: "Price",
                value: 221.494386320607849m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 469,
                column: "Price",
                value: 34.208896259723188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 470,
                column: "Price",
                value: 161.531267383877678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 471,
                column: "Price",
                value: 43.0936690148565494m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 472,
                column: "Price",
                value: 120.794108617410204m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 473,
                column: "Price",
                value: 59.218863900292379m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 474,
                column: "Price",
                value: 224.266877677546468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 475,
                column: "Price",
                value: 41.189872605540351m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 476,
                column: "Price",
                value: 144.855031606576571m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 477,
                column: "Price",
                value: 41.782037337805137m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 478,
                column: "Price",
                value: 146.128489654418724m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 479,
                column: "Price",
                value: 85.672518648083752m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 480,
                column: "Price",
                value: 244.549942029696266m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 481,
                column: "Price",
                value: 47.0175205295725532m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 482,
                column: "Price",
                value: 217.775556229764057m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 483,
                column: "Price",
                value: 35.685357567081856m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 484,
                column: "Price",
                value: 102.708825762249247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 485,
                column: "Price",
                value: 53.446423885972865m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 486,
                column: "Price",
                value: 227.87711564859984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 487,
                column: "Price",
                value: 36.911207510416437m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 488,
                column: "Price",
                value: 193.22832160991457m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 489,
                column: "Price",
                value: 42.894344679806384m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 490,
                column: "Price",
                value: 104.0293077796880813m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 491,
                column: "Price",
                value: 66.584592997932318m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 492,
                column: "Price",
                value: 206.864995529314119m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 493,
                column: "Price",
                value: 47.127066703571395m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 494,
                column: "Price",
                value: 237.301185919119277m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 495,
                column: "Price",
                value: 30.530930749248804m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 496,
                column: "Price",
                value: 123.876839765813426m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 497,
                column: "Price",
                value: 82.112357778852141m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 498,
                column: "Price",
                value: 236.746155881911488m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 499,
                column: "Price",
                value: 37.237570022772064m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 500,
                column: "Price",
                value: 174.487640603100409m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 501,
                column: "Price",
                value: 46.114371984514323m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 502,
                column: "Price",
                value: 108.0866864542926164m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 503,
                column: "Price",
                value: 55.265259308515297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 241.677252818069144m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 505,
                column: "Price",
                value: 38.0209945884565992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 506,
                column: "Price",
                value: 196.65765291158773m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 507,
                column: "Price",
                value: 40.845961652224076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 508,
                column: "Price",
                value: 142.712501769192667m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 509,
                column: "Price",
                value: 48.0453571313153299m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 510,
                column: "Price",
                value: 249.183336455427934m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 511,
                column: "Price",
                value: 41.982660945815517m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 512,
                column: "Price",
                value: 214.601078779812049m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 513,
                column: "Price",
                value: 32.425674899712032m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 514,
                column: "Price",
                value: 108.803085448367358m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 515,
                column: "Price",
                value: 48.066059514746877m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 516,
                column: "Price",
                value: 235.826813419503241m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 517,
                column: "Price",
                value: 30.706192802189024m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 518,
                column: "Price",
                value: 232.314430518658509m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 519,
                column: "Price",
                value: 43.11063191896678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 520,
                column: "Price",
                value: 103.193330894594267m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 521,
                column: "Price",
                value: 51.909050583867917m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 522,
                column: "Price",
                value: 238.0141722795160838m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 523,
                column: "Price",
                value: 37.0424191415273429m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 524,
                column: "Price",
                value: 142.153237500640933m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 525,
                column: "Price",
                value: 28.650211884108095m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 526,
                column: "Price",
                value: 147.0379069579136617m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 527,
                column: "Price",
                value: 83.472752422416978m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 528,
                column: "Price",
                value: 244.370458395942756m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 529,
                column: "Price",
                value: 31.389680893289215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 530,
                column: "Price",
                value: 183.289798922619065m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 531,
                column: "Price",
                value: 25.463702953363565m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 532,
                column: "Price",
                value: 132.906050365035998m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 533,
                column: "Price",
                value: 59.704973789233984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 534,
                column: "Price",
                value: 229.132148628055465m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 535,
                column: "Price",
                value: 43.866016099643203m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 536,
                column: "Price",
                value: 158.37468082135909m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 537,
                column: "Price",
                value: 47.677444755641149m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 538,
                column: "Price",
                value: 124.667547195758326m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 539,
                column: "Price",
                value: 79.0290439640100723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 540,
                column: "Price",
                value: 244.164350596559275m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 541,
                column: "Price",
                value: 35.625330965034912m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 542,
                column: "Price",
                value: 251.593177246949225m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 543,
                column: "Price",
                value: 20.202014119939771m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 544,
                column: "Price",
                value: 107.874209271725552m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 545,
                column: "Price",
                value: 68.895041062396108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 546,
                column: "Price",
                value: 213.344118773790411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 547,
                column: "Price",
                value: 49.582767575877316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 548,
                column: "Price",
                value: 189.589257049031188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 549,
                column: "Price",
                value: 37.279081831566484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 550,
                column: "Price",
                value: 105.188041027538823m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 54.986767587022404m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 219.848225226098812m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 553,
                column: "Price",
                value: 46.457824159864413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 554,
                column: "Price",
                value: 225.519727444786678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 555,
                column: "Price",
                value: 47.0035749137561556m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 556,
                column: "Price",
                value: 101.253277227857128m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 48.984429229494122m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 558,
                column: "Price",
                value: 216.19789892813848m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 559,
                column: "Price",
                value: 47.351874731702923m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 560,
                column: "Price",
                value: 236.247977674741793m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 561,
                column: "Price",
                value: 34.0183043804610186m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 562,
                column: "Price",
                value: 137.307215243507732m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 563,
                column: "Price",
                value: 72.794949635140322m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 564,
                column: "Price",
                value: 249.390407546383743m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 565,
                column: "Price",
                value: 46.122691800285688m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 566,
                column: "Price",
                value: 163.685620002725867m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 567,
                column: "Price",
                value: 45.995351997859089m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 568,
                column: "Price",
                value: 125.457524098645551m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 569,
                column: "Price",
                value: 76.964039239401336m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 570,
                column: "Price",
                value: 218.644412640415198m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 571,
                column: "Price",
                value: 46.356937192329335m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 572,
                column: "Price",
                value: 212.0637736780615348m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 26.232164857226845m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 574,
                column: "Price",
                value: 130.113976201085953m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 575,
                column: "Price",
                value: 48.921596028905949m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 576,
                column: "Price",
                value: 241.586539717386552m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 577,
                column: "Price",
                value: 48.6787317235408m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 578,
                column: "Price",
                value: 200.832957759993085m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 579,
                column: "Price",
                value: 29.477985983443143m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 580,
                column: "Price",
                value: 134.0697016471379056m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 581,
                column: "Price",
                value: 81.164234004704181m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 582,
                column: "Price",
                value: 225.0747223631072362m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 583,
                column: "Price",
                value: 46.515174577017995m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 584,
                column: "Price",
                value: 142.784594385167824m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 585,
                column: "Price",
                value: 20.107082503805412m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 586,
                column: "Price",
                value: 146.911476126597532m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 587,
                column: "Price",
                value: 70.104054339277838m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 588,
                column: "Price",
                value: 243.245934325529149m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 589,
                column: "Price",
                value: 49.69703392090551m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 590,
                column: "Price",
                value: 197.00235508439342269m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 591,
                column: "Price",
                value: 37.769216091853221m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 142.42316377696752m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 593,
                column: "Price",
                value: 59.321340322355928m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 594,
                column: "Price",
                value: 216.936159610377915m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 595,
                column: "Price",
                value: 36.339223376750037m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 596,
                column: "Price",
                value: 180.466655835237247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 597,
                column: "Price",
                value: 28.425934860518355m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 598,
                column: "Price",
                value: 133.260217842567336m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 599,
                column: "Price",
                value: 47.61775409542068m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 600,
                column: "Price",
                value: 222.58979486129535m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 601,
                column: "Price",
                value: 34.671690285915587m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 602,
                column: "Price",
                value: 198.933949099154944m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 603,
                column: "Price",
                value: 23.717147890855004m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 604,
                column: "Price",
                value: 132.334226526963187m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 605,
                column: "Price",
                value: 52.523471664451092m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 606,
                column: "Price",
                value: 229.572545333792282m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 607,
                column: "Price",
                value: 36.55824952633477m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 608,
                column: "Price",
                value: 209.228170522432m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 609,
                column: "Price",
                value: 46.60347494883926m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 610,
                column: "Price",
                value: 110.718276181661011m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 611,
                column: "Price",
                value: 51.0146108894770952m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 612,
                column: "Price",
                value: 208.245346541876415m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 613,
                column: "Price",
                value: 36.049633877924079m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 614,
                column: "Price",
                value: 198.774871910931026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 615,
                column: "Price",
                value: 48.40134123354141m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 616,
                column: "Price",
                value: 135.132305457178853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 617,
                column: "Price",
                value: 86.185958174983031m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 618,
                column: "Price",
                value: 245.455921818633589m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 619,
                column: "Price",
                value: 42.0661924692636637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 620,
                column: "Price",
                value: 238.792993912534268m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 621,
                column: "Price",
                value: 26.0577973087506066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 622,
                column: "Price",
                value: 111.199834969078812m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 623,
                column: "Price",
                value: 84.961882221320507m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 624,
                column: "Price",
                value: 235.171422718208467m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 625,
                column: "Price",
                value: 37.313480055255474m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 626,
                column: "Price",
                value: 223.980360070635304m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 627,
                column: "Price",
                value: 32.58657406514836m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 628,
                column: "Price",
                value: 131.965392591323707m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 629,
                column: "Price",
                value: 53.251741235359231m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 630,
                column: "Price",
                value: 230.0295172724991775m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 631,
                column: "Price",
                value: 47.826284799493819m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 632,
                column: "Price",
                value: 230.504430763905471m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 633,
                column: "Price",
                value: 45.765240584327981m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 634,
                column: "Price",
                value: 118.480753186781084m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 635,
                column: "Price",
                value: 59.399500050155357m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 636,
                column: "Price",
                value: 239.194255920938697m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 637,
                column: "Price",
                value: 40.0779513516350615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 638,
                column: "Price",
                value: 216.409936754329699m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 639,
                column: "Price",
                value: 36.673578367328208m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 640,
                column: "Price",
                value: 130.590731570609668m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 641,
                column: "Price",
                value: 72.281280551356482m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 642,
                column: "Price",
                value: 221.974461018924686m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 643,
                column: "Price",
                value: 33.091201873183263m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 644,
                column: "Price",
                value: 154.544863219277435m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 645,
                column: "Price",
                value: 35.6802183960724m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 646,
                column: "Price",
                value: 126.345817219835012m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 647,
                column: "Price",
                value: 68.72225474677256m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 648,
                column: "Price",
                value: 233.777310392875506m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 649,
                column: "Price",
                value: 30.0330389027381798m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 650,
                column: "Price",
                value: 202.0281032639937182m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 651,
                column: "Price",
                value: 39.945338318374085m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 652,
                column: "Price",
                value: 118.00984875755246428m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 653,
                column: "Price",
                value: 48.559628453426702m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 654,
                column: "Price",
                value: 203.690197230815456m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 655,
                column: "Price",
                value: 34.798618014324245m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 656,
                column: "Price",
                value: 240.505738199918995m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 657,
                column: "Price",
                value: 37.0483295903935215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 658,
                column: "Price",
                value: 142.246743169664924m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 659,
                column: "Price",
                value: 75.310850480897546m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 660,
                column: "Price",
                value: 221.954944555906271m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 661,
                column: "Price",
                value: 40.908476456808904m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 662,
                column: "Price",
                value: 226.904283783473579m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 663,
                column: "Price",
                value: 25.0945359265416656m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 664,
                column: "Price",
                value: 141.74184365654496m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 665,
                column: "Price",
                value: 45.637765232980374m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 666,
                column: "Price",
                value: 222.78587273015475m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 667,
                column: "Price",
                value: 42.596328135865232m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 668,
                column: "Price",
                value: 253.781171996854409m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 669,
                column: "Price",
                value: 46.0613899365619224m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 670,
                column: "Price",
                value: 122.110892299376879m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 671,
                column: "Price",
                value: 77.186382338801483m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 672,
                column: "Price",
                value: 233.895426058857052m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 673,
                column: "Price",
                value: 31.265066722956369m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 674,
                column: "Price",
                value: 252.488887421421399m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 675,
                column: "Price",
                value: 47.68031086057191m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 676,
                column: "Price",
                value: 110.883797468743211m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 677,
                column: "Price",
                value: 58.651965504097625m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 678,
                column: "Price",
                value: 233.281751878077784m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 679,
                column: "Price",
                value: 33.480360897748913m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 680,
                column: "Price",
                value: 259.170913382055706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 681,
                column: "Price",
                value: 33.919994477373579m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 682,
                column: "Price",
                value: 104.450762391321485m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 683,
                column: "Price",
                value: 83.510889151536986m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 684,
                column: "Price",
                value: 216.868198601532372m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 685,
                column: "Price",
                value: 43.242816107549094m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 686,
                column: "Price",
                value: 174.368869448852449m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 687,
                column: "Price",
                value: 26.717542103594473m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 688,
                column: "Price",
                value: 134.0702961036867458m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 689,
                column: "Price",
                value: 45.644603226898946m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 690,
                column: "Price",
                value: 204.863931498544118m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 691,
                column: "Price",
                value: 33.616298179529874m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 692,
                column: "Price",
                value: 148.025643499177084m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 693,
                column: "Price",
                value: 29.127888694361383m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 694,
                column: "Price",
                value: 102.87681832057583m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 695,
                column: "Price",
                value: 60.827594499239501m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 696,
                column: "Price",
                value: 235.198867913210949m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 697,
                column: "Price",
                value: 43.541255814381543m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 698,
                column: "Price",
                value: 171.950908246216559m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 699,
                column: "Price",
                value: 21.514397860402853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 700,
                column: "Price",
                value: 113.149079316934121m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 701,
                column: "Price",
                value: 81.938865525902789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 702,
                column: "Price",
                value: 245.111132764662179m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 703,
                column: "Price",
                value: 37.751309297206622m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 704,
                column: "Price",
                value: 184.190227872435378m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 705,
                column: "Price",
                value: 40.599531794055211m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 706,
                column: "Price",
                value: 149.112791553556367m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 707,
                column: "Price",
                value: 78.203451326004698m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 708,
                column: "Price",
                value: 209.441404845055214m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 709,
                column: "Price",
                value: 31.675717030034298m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 710,
                column: "Price",
                value: 250.384010508042011m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 711,
                column: "Price",
                value: 39.642379109953611m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 712,
                column: "Price",
                value: 108.548589307070128m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 713,
                column: "Price",
                value: 59.999084381328613m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 714,
                column: "Price",
                value: 247.19529724465873m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 715,
                column: "Price",
                value: 47.130244175501549m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 716,
                column: "Price",
                value: 210.21172818936782m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 717,
                column: "Price",
                value: 42.38486270562343m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 718,
                column: "Price",
                value: 121.267456687956316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 719,
                column: "Price",
                value: 54.787137134790773m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 720,
                column: "Price",
                value: 210.45103762740576m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 721,
                column: "Price",
                value: 33.36222869111254m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 722,
                column: "Price",
                value: 231.0981430892675069m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 723,
                column: "Price",
                value: 21.730270334485833m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 724,
                column: "Price",
                value: 144.224808998480584m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 725,
                column: "Price",
                value: 68.120315499779004m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 726,
                column: "Price",
                value: 217.145906206410198m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 727,
                column: "Price",
                value: 43.151508883726005m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 728,
                column: "Price",
                value: 163.608977375565586m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 729,
                column: "Price",
                value: 44.0292914996220488m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 730,
                column: "Price",
                value: 135.456216981433592m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 731,
                column: "Price",
                value: 69.993611964266794m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 732,
                column: "Price",
                value: 218.683463298752687m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 733,
                column: "Price",
                value: 42.0200338299147268m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 734,
                column: "Price",
                value: 167.753681427848046m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 735,
                column: "Price",
                value: 45.201857569797918m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 736,
                column: "Price",
                value: 100.969771605312178m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 737,
                column: "Price",
                value: 73.30093821228484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 738,
                column: "Price",
                value: 207.0625507479879676m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 739,
                column: "Price",
                value: 36.448967609357316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 740,
                column: "Price",
                value: 238.0482068887910295m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 741,
                column: "Price",
                value: 30.0649468885781552m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 742,
                column: "Price",
                value: 135.925822690620112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 743,
                column: "Price",
                value: 79.764565640042035m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 744,
                column: "Price",
                value: 229.937665031715636m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 745,
                column: "Price",
                value: 36.32660375073399m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 746,
                column: "Price",
                value: 245.98240409608268m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 747,
                column: "Price",
                value: 29.363880285642847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 748,
                column: "Price",
                value: 110.830133729610379m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 749,
                column: "Price",
                value: 79.380838615918086m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 750,
                column: "Price",
                value: 234.996309820913071m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 751,
                column: "Price",
                value: 44.510388495919306m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 752,
                column: "Price",
                value: 230.65686004132312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 753,
                column: "Price",
                value: 32.516912599101606m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 754,
                column: "Price",
                value: 113.49526054683029m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 755,
                column: "Price",
                value: 69.188465860159327m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 756,
                column: "Price",
                value: 217.649697963532178m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 757,
                column: "Price",
                value: 46.282852212562119m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 758,
                column: "Price",
                value: 236.502059357387106m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 759,
                column: "Price",
                value: 20.322039365039785m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 760,
                column: "Price",
                value: 137.800102607539811m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 761,
                column: "Price",
                value: 74.0883032928035384m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 762,
                column: "Price",
                value: 224.642301361235211m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 763,
                column: "Price",
                value: 46.0981965612540652m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 764,
                column: "Price",
                value: 217.880400110652196m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 765,
                column: "Price",
                value: 23.693451080061313m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 766,
                column: "Price",
                value: 105.104386978436785m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 767,
                column: "Price",
                value: 73.045988848071111m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 768,
                column: "Price",
                value: 237.552832045647856m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 769,
                column: "Price",
                value: 36.778496177710807m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 770,
                column: "Price",
                value: 248.0487378946794702m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 771,
                column: "Price",
                value: 26.881267026442267m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 772,
                column: "Price",
                value: 149.793849756077418m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 773,
                column: "Price",
                value: 63.74368655868851m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 774,
                column: "Price",
                value: 215.148101355734848m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 775,
                column: "Price",
                value: 40.765855459203822m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 776,
                column: "Price",
                value: 200.0216827636203301m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 777,
                column: "Price",
                value: 22.0622045559118098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 778,
                column: "Price",
                value: 122.829362234460905m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 779,
                column: "Price",
                value: 74.417524183171392m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 780,
                column: "Price",
                value: 212.50347896349929m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 781,
                column: "Price",
                value: 49.839814845519928m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 782,
                column: "Price",
                value: 157.994847588173219m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 783,
                column: "Price",
                value: 30.907272572000172m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 784,
                column: "Price",
                value: 116.43017787334827m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 785,
                column: "Price",
                value: 54.0163422429467277m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 786,
                column: "Price",
                value: 234.839737573121794m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 787,
                column: "Price",
                value: 39.826420535609615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 788,
                column: "Price",
                value: 186.16222671749992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 789,
                column: "Price",
                value: 44.00571380483187212m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 790,
                column: "Price",
                value: 108.891784573547678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 791,
                column: "Price",
                value: 84.00740693948551063m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 792,
                column: "Price",
                value: 204.586948060235189m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 793,
                column: "Price",
                value: 43.48991604753468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 794,
                column: "Price",
                value: 149.630197939651114m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 795,
                column: "Price",
                value: 46.171520603335236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 796,
                column: "Price",
                value: 119.263721287651513m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 797,
                column: "Price",
                value: 61.248221591260249m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 798,
                column: "Price",
                value: 234.66853986905706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 799,
                column: "Price",
                value: 31.326596952190958m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 800,
                column: "Price",
                value: 144.126415009809611m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 801,
                column: "Price",
                value: 40.249245804583374m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 802,
                column: "Price",
                value: 130.0731846780285074m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 803,
                column: "Price",
                value: 81.968213332651988m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 804,
                column: "Price",
                value: 220.468251444575432m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 805,
                column: "Price",
                value: 43.747199683296632m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 806,
                column: "Price",
                value: 255.0304084463104844m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 807,
                column: "Price",
                value: 28.050076495180134m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 808,
                column: "Price",
                value: 128.399015338318569m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 809,
                column: "Price",
                value: 63.691991017641672m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 810,
                column: "Price",
                value: 247.950917879638516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 811,
                column: "Price",
                value: 43.356571388941574m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 812,
                column: "Price",
                value: 141.585341607692808m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 813,
                column: "Price",
                value: 36.772582852583825m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 814,
                column: "Price",
                value: 115.414177175541017m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 815,
                column: "Price",
                value: 70.665803840062742m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 816,
                column: "Price",
                value: 212.937703951465992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 817,
                column: "Price",
                value: 36.150248077254498m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 818,
                column: "Price",
                value: 214.866454841494104m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 819,
                column: "Price",
                value: 23.180357148141959m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 820,
                column: "Price",
                value: 121.710169593482265m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 821,
                column: "Price",
                value: 58.019791559519739m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 822,
                column: "Price",
                value: 244.689081810765876m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 823,
                column: "Price",
                value: 38.66650619941118m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 824,
                column: "Price",
                value: 226.622402332641766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 825,
                column: "Price",
                value: 48.941350484005204m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 826,
                column: "Price",
                value: 100.487646643222618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 827,
                column: "Price",
                value: 63.76960942224881m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 828,
                column: "Price",
                value: 200.545058041132874m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 829,
                column: "Price",
                value: 43.296178564682582m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 830,
                column: "Price",
                value: 161.994844218883807m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 831,
                column: "Price",
                value: 28.523916793767455m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 832,
                column: "Price",
                value: 149.626873069419275m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 833,
                column: "Price",
                value: 72.6161737183895m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 834,
                column: "Price",
                value: 216.0573387403139672m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 835,
                column: "Price",
                value: 30.132687568698624m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 836,
                column: "Price",
                value: 245.915484616712087m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 837,
                column: "Price",
                value: 44.162417035826955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 838,
                column: "Price",
                value: 120.913077908369618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 839,
                column: "Price",
                value: 56.732473258259256m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 840,
                column: "Price",
                value: 231.594029525220468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 841,
                column: "Price",
                value: 46.617960699319972m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 842,
                column: "Price",
                value: 229.34869094303136m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 843,
                column: "Price",
                value: 41.508967803026566m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 844,
                column: "Price",
                value: 125.136260465565569m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 845,
                column: "Price",
                value: 45.818974235184931m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 846,
                column: "Price",
                value: 231.857981814331236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 847,
                column: "Price",
                value: 37.257197361287194m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 848,
                column: "Price",
                value: 186.708717465664336m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 849,
                column: "Price",
                value: 38.661915589142695m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 850,
                column: "Price",
                value: 113.398418863447901m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 851,
                column: "Price",
                value: 62.648826439934227m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 852,
                column: "Price",
                value: 217.207993926463066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 853,
                column: "Price",
                value: 43.168105541436506m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 854,
                column: "Price",
                value: 186.616185671539852m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 855,
                column: "Price",
                value: 26.0839380991695924m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 856,
                column: "Price",
                value: 131.453648849751367m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 857,
                column: "Price",
                value: 45.777944246820612m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 858,
                column: "Price",
                value: 245.9348692157201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 859,
                column: "Price",
                value: 36.87208085792692m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 860,
                column: "Price",
                value: 147.469366335271399m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 861,
                column: "Price",
                value: 34.136387653134026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 862,
                column: "Price",
                value: 138.568370036828784m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 863,
                column: "Price",
                value: 59.94609274096308m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 864,
                column: "Price",
                value: 222.809177004437643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 865,
                column: "Price",
                value: 36.87391173340273m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 866,
                column: "Price",
                value: 220.934451097056256m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 867,
                column: "Price",
                value: 33.646066302123691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 868,
                column: "Price",
                value: 133.243370820829262m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 869,
                column: "Price",
                value: 59.6647772568524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 870,
                column: "Price",
                value: 232.391502376882615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 871,
                column: "Price",
                value: 40.629291097852382m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 872,
                column: "Price",
                value: 245.217415766576918m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 873,
                column: "Price",
                value: 34.440873820534365m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 874,
                column: "Price",
                value: 102.403104834432306m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 875,
                column: "Price",
                value: 55.812018887405532m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 876,
                column: "Price",
                value: 246.933117033897442m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 877,
                column: "Price",
                value: 32.949346324641172m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 878,
                column: "Price",
                value: 198.529088181297725m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 879,
                column: "Price",
                value: 34.437630035824188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 880,
                column: "Price",
                value: 140.793015929776651m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 881,
                column: "Price",
                value: 49.672117369638042m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 882,
                column: "Price",
                value: 248.918569935953374m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 883,
                column: "Price",
                value: 41.541452553852092m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 884,
                column: "Price",
                value: 171.416326371939628m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 885,
                column: "Price",
                value: 23.196976332107355m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 886,
                column: "Price",
                value: 119.898442638862649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 887,
                column: "Price",
                value: 45.0118416425196411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 888,
                column: "Price",
                value: 207.0103860234840094m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 889,
                column: "Price",
                value: 46.585233364087482m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 890,
                column: "Price",
                value: 138.640179034495718m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 891,
                column: "Price",
                value: 36.486567652097291m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 892,
                column: "Price",
                value: 105.0779202727692139m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 893,
                column: "Price",
                value: 52.156856263612907m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 894,
                column: "Price",
                value: 204.186777601917731m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 895,
                column: "Price",
                value: 39.608665098779175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 896,
                column: "Price",
                value: 189.914110997403529m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 897,
                column: "Price",
                value: 30.692643910225916m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 898,
                column: "Price",
                value: 148.503006295028484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 899,
                column: "Price",
                value: 74.59149561599577m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 900,
                column: "Price",
                value: 231.407406346489386m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 901,
                column: "Price",
                value: 35.127341066202399m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 902,
                column: "Price",
                value: 197.543882055065705m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 903,
                column: "Price",
                value: 21.131606488756266m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 904,
                column: "Price",
                value: 101.495775283467454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 905,
                column: "Price",
                value: 46.104127014961864m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 906,
                column: "Price",
                value: 224.428709746460393m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 907,
                column: "Price",
                value: 48.265453700035008m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 908,
                column: "Price",
                value: 148.336710867285508m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 909,
                column: "Price",
                value: 47.265404952908966m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 910,
                column: "Price",
                value: 104.164575903192195m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 911,
                column: "Price",
                value: 86.307844186004571m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 912,
                column: "Price",
                value: 224.597727681503207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 913,
                column: "Price",
                value: 47.0878569672374899m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 914,
                column: "Price",
                value: 258.266429818478634m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 915,
                column: "Price",
                value: 43.268074618358853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 916,
                column: "Price",
                value: 137.0483222408687595m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 917,
                column: "Price",
                value: 59.849061603623484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 918,
                column: "Price",
                value: 221.865473044986789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 919,
                column: "Price",
                value: 43.03492143713283m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 920,
                column: "Price",
                value: 236.149802820603541m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 921,
                column: "Price",
                value: 40.916913874336961m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 922,
                column: "Price",
                value: 137.262801944100062m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 923,
                column: "Price",
                value: 57.669282300596148m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 924,
                column: "Price",
                value: 203.795756043618021m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 925,
                column: "Price",
                value: 32.897572939228236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 926,
                column: "Price",
                value: 210.386859535186283m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 927,
                column: "Price",
                value: 38.478028587818301m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 928,
                column: "Price",
                value: 133.0240420691036608m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 929,
                column: "Price",
                value: 74.517271236038658m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 930,
                column: "Price",
                value: 206.92146190159966m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 931,
                column: "Price",
                value: 30.499907515145274m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 932,
                column: "Price",
                value: 177.569212985424265m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 933,
                column: "Price",
                value: 30.903492322167089m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 934,
                column: "Price",
                value: 136.770707177140497m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 935,
                column: "Price",
                value: 62.0423968761163329m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 936,
                column: "Price",
                value: 225.922173620345887m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 937,
                column: "Price",
                value: 38.867780420969175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 938,
                column: "Price",
                value: 245.378746306810852m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 939,
                column: "Price",
                value: 33.947427020755828m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 940,
                column: "Price",
                value: 114.697890779216295m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 941,
                column: "Price",
                value: 58.65840895475352m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 942,
                column: "Price",
                value: 214.415091754205138m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 943,
                column: "Price",
                value: 32.787850810728054m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 944,
                column: "Price",
                value: 160.912032328124177m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 945,
                column: "Price",
                value: 28.684732447143108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 946,
                column: "Price",
                value: 113.133987010296498m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 947,
                column: "Price",
                value: 80.72675585997673m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 948,
                column: "Price",
                value: 215.939431597104286m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 949,
                column: "Price",
                value: 48.856260575850134m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 950,
                column: "Price",
                value: 135.0507736723258825m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 951,
                column: "Price",
                value: 23.143401746441349m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 952,
                column: "Price",
                value: 115.828831688621524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 953,
                column: "Price",
                value: 63.478296258899903m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 954,
                column: "Price",
                value: 205.0998118768801654m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 955,
                column: "Price",
                value: 45.865557968052832m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 956,
                column: "Price",
                value: 222.127793051964972m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 957,
                column: "Price",
                value: 38.877868675943716m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 958,
                column: "Price",
                value: 100.201160024193312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 959,
                column: "Price",
                value: 66.838753529674932m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 960,
                column: "Price",
                value: 244.217879245993772m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 961,
                column: "Price",
                value: 40.0190599937092386m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 962,
                column: "Price",
                value: 176.791515969250809m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 963,
                column: "Price",
                value: 31.754800270347511m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 964,
                column: "Price",
                value: 134.0538600347882391m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 965,
                column: "Price",
                value: 49.955099957199597m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 966,
                column: "Price",
                value: 235.392416659020762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 967,
                column: "Price",
                value: 37.245288680577101m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 968,
                column: "Price",
                value: 165.958270416100547m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 969,
                column: "Price",
                value: 45.210603038354801m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 970,
                column: "Price",
                value: 143.956168618595352m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 971,
                column: "Price",
                value: 62.246332997841683m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 972,
                column: "Price",
                value: 222.724126524645384m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 973,
                column: "Price",
                value: 44.421596218810068m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 974,
                column: "Price",
                value: 207.0265541903724427m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 975,
                column: "Price",
                value: 34.0407996203465409m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 976,
                column: "Price",
                value: 143.614495806657989m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 977,
                column: "Price",
                value: 55.560886070130248m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 978,
                column: "Price",
                value: 222.117199918476927m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 979,
                column: "Price",
                value: 30.301858897428214m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 980,
                column: "Price",
                value: 213.993275940850891m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 981,
                column: "Price",
                value: 23.239447042984964m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 982,
                column: "Price",
                value: 110.0532255803295321m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 983,
                column: "Price",
                value: 55.381585289207342m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 984,
                column: "Price",
                value: 230.784058307887228m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 985,
                column: "Price",
                value: 32.791029643582127m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 986,
                column: "Price",
                value: 171.807170074502244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 987,
                column: "Price",
                value: 20.0725455324048245m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 988,
                column: "Price",
                value: 123.0918199062696031m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 989,
                column: "Price",
                value: 72.758203616058158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 990,
                column: "Price",
                value: 201.668394092083431m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 991,
                column: "Price",
                value: 35.389775750856209m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 992,
                column: "Price",
                value: 232.97936390900208m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 993,
                column: "Price",
                value: 21.11447923065215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 994,
                column: "Price",
                value: 127.319302776970446m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 995,
                column: "Price",
                value: 66.749617446465691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 996,
                column: "Price",
                value: 221.03055331283172m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 997,
                column: "Price",
                value: 40.416190569355553m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 998,
                column: "Price",
                value: 153.133838827469114m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 999,
                column: "Price",
                value: 20.818914521939649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Price",
                value: 129.0878093224729904m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Price",
                value: 66.405801442034514m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Price",
                value: 237.0808806931426454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Price",
                value: 40.898688281857917m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Price",
                value: 200.296225707079438m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Price",
                value: 35.0580457925723098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Price",
                value: 112.965941417475469m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Price",
                value: 49.0006382293031435m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Price",
                value: 244.563532684523145m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "Price",
                value: 39.592492715901134m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Price",
                value: 178.958876539907751m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "Price",
                value: 22.633628592665955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "Price",
                value: 137.65944386217216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "Price",
                value: 85.501899854034466m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "Price",
                value: 249.279303990951179m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "Price",
                value: 49.96429296922615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "Price",
                value: 205.599178706991852m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1017,
                column: "Price",
                value: 37.916562439075986m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1018,
                column: "Price",
                value: 104.388047092953156m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1019,
                column: "Price",
                value: 86.892810448827066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1020,
                column: "Price",
                value: 236.744779897927799m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1021,
                column: "Price",
                value: 35.87760503224173m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1022,
                column: "Price",
                value: 235.219721747259491m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1023,
                column: "Price",
                value: 40.735390796954281m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Price",
                value: 106.903724443219891m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1025,
                column: "Price",
                value: 46.776882815410696m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1026,
                column: "Price",
                value: 230.845169160814627m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1027,
                column: "Price",
                value: 43.456832544995708m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1028,
                column: "Price",
                value: 159.189856926869894m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1029,
                column: "Price",
                value: 26.0358056782211914m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1030,
                column: "Price",
                value: 117.768183002447611m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1031,
                column: "Price",
                value: 81.250459743436722m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1032,
                column: "Price",
                value: 217.903212995425433m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1033,
                column: "Price",
                value: 45.949541850077345m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1034,
                column: "Price",
                value: 227.569924556185339m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1035,
                column: "Price",
                value: 39.666325071040207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1036,
                column: "Price",
                value: 116.486673815809562m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1037,
                column: "Price",
                value: 49.162816427559711m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1038,
                column: "Price",
                value: 222.576301580017912m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1039,
                column: "Price",
                value: 30.804503606830411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1040,
                column: "Price",
                value: 217.725795762967123m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1041,
                column: "Price",
                value: 33.897396414047451m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1042,
                column: "Price",
                value: 144.179783375287765m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1043,
                column: "Price",
                value: 55.131360534551783m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1044,
                column: "Price",
                value: 237.855155852640516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1045,
                column: "Price",
                value: 38.446776886304197m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1046,
                column: "Price",
                value: 166.516862198427555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1047,
                column: "Price",
                value: 39.550490234185676m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1048,
                column: "Price",
                value: 139.935279027767618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1049,
                column: "Price",
                value: 52.902844109666976m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1050,
                column: "Price",
                value: 212.109738485789594m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1051,
                column: "Price",
                value: 32.769453826176312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1052,
                column: "Price",
                value: 256.987678092180112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1053,
                column: "Price",
                value: 28.412251193223857m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1054,
                column: "Price",
                value: 127.848714755820081m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1055,
                column: "Price",
                value: 68.940384909002733m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1056,
                column: "Price",
                value: 242.0769669663887414m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1057,
                column: "Price",
                value: 39.32603638009881m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1058,
                column: "Price",
                value: 146.649263654187231m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1059,
                column: "Price",
                value: 40.0155159262226723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1060,
                column: "Price",
                value: 116.192722052783013m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1061,
                column: "Price",
                value: 45.409899007228661m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1062,
                column: "Price",
                value: 206.48410726751199m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1063,
                column: "Price",
                value: 36.269234414848679m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1064,
                column: "Price",
                value: 150.627191612800769m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1065,
                column: "Price",
                value: 45.221177324015416m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1066,
                column: "Price",
                value: 106.392356653915006m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1067,
                column: "Price",
                value: 70.890039700178615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1068,
                column: "Price",
                value: 233.671013877753412m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1069,
                column: "Price",
                value: 41.360612338746654m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1070,
                column: "Price",
                value: 177.0365485406134722m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1071,
                column: "Price",
                value: 33.604993034536369m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1072,
                column: "Price",
                value: 100.403252841589259m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1073,
                column: "Price",
                value: 68.889316768946458m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1074,
                column: "Price",
                value: 213.167429968343185m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1075,
                column: "Price",
                value: 46.789932124356364m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1076,
                column: "Price",
                value: 200.655000636380186m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1077,
                column: "Price",
                value: 39.188786306497616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1078,
                column: "Price",
                value: 105.994370647405065m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1079,
                column: "Price",
                value: 76.224462556480534m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1080,
                column: "Price",
                value: 234.754758469752297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1081,
                column: "Price",
                value: 36.544502384839564m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1082,
                column: "Price",
                value: 213.526692193827008m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1083,
                column: "Price",
                value: 37.273052695772623m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1084,
                column: "Price",
                value: 111.573477718709256m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1085,
                column: "Price",
                value: 85.246750394757665m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1086,
                column: "Price",
                value: 231.358270497223113m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1087,
                column: "Price",
                value: 48.574468428187084m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1088,
                column: "Price",
                value: 168.105674234928431m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1089,
                column: "Price",
                value: 30.288858092964414m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1090,
                column: "Price",
                value: 146.420169097602698m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1091,
                column: "Price",
                value: 54.793372531328409m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1092,
                column: "Price",
                value: 200.704133803441853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1093,
                column: "Price",
                value: 39.252517571826495m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1094,
                column: "Price",
                value: 224.92980647566298m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1095,
                column: "Price",
                value: 47.645886580760585m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Price",
                value: 101.152350924444049m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1097,
                column: "Price",
                value: 80.902006645105355m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1098,
                column: "Price",
                value: 214.695625520521638m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1099,
                column: "Price",
                value: 30.316668003439214m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Price",
                value: 207.0785650203269868m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1101,
                column: "Price",
                value: 24.0583893135122144m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1102,
                column: "Price",
                value: 147.245725807836247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1103,
                column: "Price",
                value: 60.566305461504097m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1104,
                column: "Price",
                value: 234.400384295024396m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1105,
                column: "Price",
                value: 49.631785697757394m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1106,
                column: "Price",
                value: 190.416959111406739m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1107,
                column: "Price",
                value: 47.334019419277512m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1108,
                column: "Price",
                value: 131.184748610619214m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1109,
                column: "Price",
                value: 49.398415520708333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1110,
                column: "Price",
                value: 208.159565176129726m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1111,
                column: "Price",
                value: 45.813050010577464m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1112,
                column: "Price",
                value: 228.872636909028171m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1113,
                column: "Price",
                value: 35.14338224083814m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1114,
                column: "Price",
                value: 126.750981483578948m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1115,
                column: "Price",
                value: 55.0429076681047299m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1116,
                column: "Price",
                value: 249.562277112297315m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1117,
                column: "Price",
                value: 48.0908951851856796m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1118,
                column: "Price",
                value: 136.831803027104178m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1119,
                column: "Price",
                value: 42.751114408662146m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1120,
                column: "Price",
                value: 105.325845134464992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1121,
                column: "Price",
                value: 86.643928399712192m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Price",
                value: 204.0721956284124879m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1123,
                column: "Price",
                value: 38.813387970721906m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1124,
                column: "Price",
                value: 207.273618493039292m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1125,
                column: "Price",
                value: 24.458069290269938m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1126,
                column: "Price",
                value: 136.535512380436781m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1127,
                column: "Price",
                value: 69.858550903744152m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1128,
                column: "Price",
                value: 236.843125482074648m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1129,
                column: "Price",
                value: 49.743404209045439m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1130,
                column: "Price",
                value: 159.14506431364026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1131,
                column: "Price",
                value: 30.524017676896296m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1132,
                column: "Price",
                value: 107.00308622452794649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1133,
                column: "Price",
                value: 72.938546807151296m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1134,
                column: "Price",
                value: 248.744346681022975m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1135,
                column: "Price",
                value: 48.0827948294446479m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1136,
                column: "Price",
                value: 237.0677716282354542m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1137,
                column: "Price",
                value: 38.119919372093353m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1138,
                column: "Price",
                value: 104.416987293627464m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1139,
                column: "Price",
                value: 49.71701844175728m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1140,
                column: "Price",
                value: 218.0115433441370664m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1141,
                column: "Price",
                value: 46.0567989311878937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1142,
                column: "Price",
                value: 205.942809774338943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1143,
                column: "Price",
                value: 40.662647339444636m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1144,
                column: "Price",
                value: 142.816708202550073m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1145,
                column: "Price",
                value: 86.409928004486579m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1146,
                column: "Price",
                value: 212.749184770337899m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1147,
                column: "Price",
                value: 36.688606344211563m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1148,
                column: "Price",
                value: 141.294526387227016m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1149,
                column: "Price",
                value: 30.113656591016502m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1150,
                column: "Price",
                value: 140.504514692271269m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1151,
                column: "Price",
                value: 56.961399854762841m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1152,
                column: "Price",
                value: 222.438267667840588m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1153,
                column: "Price",
                value: 31.16879871306844m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1154,
                column: "Price",
                value: 252.187417470208389m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Price",
                value: 22.809976717466791m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Price",
                value: 145.0589410359144112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Price",
                value: 58.461330457603163m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1158,
                column: "Price",
                value: 244.81086236234299m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1159,
                column: "Price",
                value: 37.569530206932483m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1160,
                column: "Price",
                value: 178.967240594866294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1161,
                column: "Price",
                value: 24.925218347549666m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1162,
                column: "Price",
                value: 111.058456904834733m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Price",
                value: 64.0491126483889314m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1164,
                column: "Price",
                value: 245.135963970957885m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1165,
                column: "Price",
                value: 31.656890265192888m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1166,
                column: "Price",
                value: 215.996050507774237m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1167,
                column: "Price",
                value: 40.197142629873062m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1168,
                column: "Price",
                value: 117.302484666596423m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1169,
                column: "Price",
                value: 65.446349608947453m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1170,
                column: "Price",
                value: 248.24165795414222m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1171,
                column: "Price",
                value: 34.414419005492189m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1172,
                column: "Price",
                value: 259.31493468851067m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1173,
                column: "Price",
                value: 22.875235416045549m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1174,
                column: "Price",
                value: 115.0617869078456032m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1175,
                column: "Price",
                value: 80.148515380266443m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1176,
                column: "Price",
                value: 201.0198589810734937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1177,
                column: "Price",
                value: 49.92815600679013m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1178,
                column: "Price",
                value: 162.900163922973421m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1179,
                column: "Price",
                value: 43.445678474269763m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1180,
                column: "Price",
                value: 140.651350593981423m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1181,
                column: "Price",
                value: 80.99553038306153m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1182,
                column: "Price",
                value: 242.583041964884522m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1183,
                column: "Price",
                value: 33.150015257724082m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1184,
                column: "Price",
                value: 209.842354362338239m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1185,
                column: "Price",
                value: 43.445802099309626m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1186,
                column: "Price",
                value: 113.998062263636637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Price",
                value: 62.907476892519297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Price",
                value: 223.0361437841508098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Price",
                value: 46.0079016642049361m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Price",
                value: 163.5424358891933m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Price",
                value: 45.777459105081643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Price",
                value: 120.950256672796437m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1193,
                column: "Price",
                value: 85.329906109702576m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1194,
                column: "Price",
                value: 245.00393065063185516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1195,
                column: "Price",
                value: 48.497404970049271m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1196,
                column: "Price",
                value: 255.162824356805682m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1197,
                column: "Price",
                value: 28.595841004963201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1198,
                column: "Price",
                value: 126.832665499890416m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1199,
                column: "Price",
                value: 57.472375956464019m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1200,
                column: "Price",
                value: 242.844654668259782m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 46.279341997222329m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 158.201966632840352m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 29.768158042387528m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 141.995625150533389m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 65.828645281861m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 211.398451743884088m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 49.193251211448973m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 155.107565627973576m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 20.524720710426104m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 128.347219815085204m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 68.950225545613854m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 220.625468056404282m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 33.718541330515544m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 168.812254805501621m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 28.353183759357962m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 124.294613478627592m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 52.564270239398005m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 229.938633027424668m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 44.632036712070792m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 216.834133075813179m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 43.823739350033742m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 132.00777001117120746m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 45.152753511595563m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 243.951011015017889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 48.616582237833847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 216.876183365522214m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 35.746069696245156m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 141.756040426183697m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 78.657650505113984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 204.208433272376919m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 36.101832026208276m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 223.0288031685344548m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 42.0164941736424693m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 136.267002843549435m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 63.0798008958199294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 235.255675761143497m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 46.393059973238335m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 235.780926854117438m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 45.451345799729714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 132.987189064662464m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 65.677729964888023m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 241.5693531548448m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 43.459890395029322m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 137.393053878224115m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 34.241222098839026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 142.604787675537453m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 61.237088003763943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 218.0105190393838607m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 46.922915579849732m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 200.721072265171174m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 30.898611813169584m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 108.885987742616506m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 73.777666831417635m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 232.139884378228108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 40.176145857534149m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 197.967254675690476m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 28.150463768023012m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 105.239365807283308m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 76.34134322130823m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 231.973085018968347m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 36.665835651140008m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 62,
                column: "Price",
                value: 152.84431928761212m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 63,
                column: "Price",
                value: 30.448841058912375m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 64,
                column: "Price",
                value: 102.125778560191093m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 65,
                column: "Price",
                value: 53.483814522250033m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 66,
                column: "Price",
                value: 221.177609910391485m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 67,
                column: "Price",
                value: 44.0670765097560064m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 68,
                column: "Price",
                value: 198.552969351141102m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 69,
                column: "Price",
                value: 26.00408786629552549m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 70,
                column: "Price",
                value: 118.114054421375608m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 71,
                column: "Price",
                value: 77.396712355281465m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 72,
                column: "Price",
                value: 202.651890819115896m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 73,
                column: "Price",
                value: 33.800898288333175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 74,
                column: "Price",
                value: 247.723248299249797m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 75,
                column: "Price",
                value: 38.933068817409969m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 76,
                column: "Price",
                value: 116.247076268355203m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 77,
                column: "Price",
                value: 86.655294198377763m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 78,
                column: "Price",
                value: 218.674674299740628m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 79,
                column: "Price",
                value: 35.36333677831504m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 80,
                column: "Price",
                value: 214.352605946224202m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 81,
                column: "Price",
                value: 47.273999005809372m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 82,
                column: "Price",
                value: 130.29082396067557m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 83,
                column: "Price",
                value: 73.492939557469853m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 84,
                column: "Price",
                value: 204.535514191753253m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 85,
                column: "Price",
                value: 40.744777327074152m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 86,
                column: "Price",
                value: 239.894302099425825m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 87,
                column: "Price",
                value: 36.598800523624702m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 88,
                column: "Price",
                value: 126.933764141368876m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 89,
                column: "Price",
                value: 75.695293598126762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 90,
                column: "Price",
                value: 214.0970662165036518m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 91,
                column: "Price",
                value: 40.368817061068294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 92,
                column: "Price",
                value: 231.544277900865104m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 93,
                column: "Price",
                value: 27.384268055429632m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 94,
                column: "Price",
                value: 128.249605787913506m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 95,
                column: "Price",
                value: 63.921557539879442m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 228.66555109605831m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 97,
                column: "Price",
                value: 44.912421510598572m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 98,
                column: "Price",
                value: 219.595314631080325m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 99,
                column: "Price",
                value: 44.961745491919415m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 100,
                column: "Price",
                value: 145.0868844539057108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 101,
                column: "Price",
                value: 57.403857184586686m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 102,
                column: "Price",
                value: 220.883606687579256m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 103,
                column: "Price",
                value: 46.510284285030874m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 104,
                column: "Price",
                value: 151.518308514828271m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 105,
                column: "Price",
                value: 21.0629952742297957m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 106,
                column: "Price",
                value: 108.271964353140494m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 107,
                column: "Price",
                value: 47.65621748797356m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 108,
                column: "Price",
                value: 219.871332267301448m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 109,
                column: "Price",
                value: 37.649634055613443m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 110,
                column: "Price",
                value: 210.52199039139553m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 111,
                column: "Price",
                value: 21.406259605733149m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 112,
                column: "Price",
                value: 121.0956171859889691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 113,
                column: "Price",
                value: 73.49241201482146m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 114,
                column: "Price",
                value: 248.199394787983339m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 115,
                column: "Price",
                value: 44.219078230738937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 116,
                column: "Price",
                value: 210.696082026364626m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 117,
                column: "Price",
                value: 20.870344251453637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 118,
                column: "Price",
                value: 149.371955699996259m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 119,
                column: "Price",
                value: 68.329282119870544m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 120,
                column: "Price",
                value: 225.348976456513488m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 121,
                column: "Price",
                value: 37.117406364918753m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 122,
                column: "Price",
                value: 253.754028877613464m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 123,
                column: "Price",
                value: 37.347662113509736m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 124,
                column: "Price",
                value: 121.465929025688977m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 125,
                column: "Price",
                value: 75.683371606798444m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 126,
                column: "Price",
                value: 247.918860566512478m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 127,
                column: "Price",
                value: 41.385097197490338m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 128,
                column: "Price",
                value: 166.905536222473741m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 129,
                column: "Price",
                value: 20.629354598421608m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 130,
                column: "Price",
                value: 111.628001573270112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 131,
                column: "Price",
                value: 64.0622860964373792m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 132,
                column: "Price",
                value: 201.268720126295163m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 133,
                column: "Price",
                value: 36.888228151292386m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 134,
                column: "Price",
                value: 160.0119160542367084m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 135,
                column: "Price",
                value: 32.477238715912645m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 136,
                column: "Price",
                value: 113.356400133861178m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 137,
                column: "Price",
                value: 63.851865259355898m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 138,
                column: "Price",
                value: 231.978178327748759m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 139,
                column: "Price",
                value: 44.822684943795939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 140,
                column: "Price",
                value: 206.71269665875615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 141,
                column: "Price",
                value: 27.272880175053197m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 142,
                column: "Price",
                value: 141.21142972511661m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 143,
                column: "Price",
                value: 56.792388686099479m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 144,
                column: "Price",
                value: 238.609542681052029m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 145,
                column: "Price",
                value: 37.336030009191887m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 146,
                column: "Price",
                value: 172.494034477493289m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 147,
                column: "Price",
                value: 37.710127446953701m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 148,
                column: "Price",
                value: 124.671884626021558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 149,
                column: "Price",
                value: 75.945615834066696m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 150,
                column: "Price",
                value: 227.189146669807886m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 151,
                column: "Price",
                value: 38.0403106941564859m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 152,
                column: "Price",
                value: 231.550487586331584m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 153,
                column: "Price",
                value: 32.399716102644724m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 154,
                column: "Price",
                value: 100.727415024364755m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 155,
                column: "Price",
                value: 73.251603861089847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 156,
                column: "Price",
                value: 245.569452440867673m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 157,
                column: "Price",
                value: 43.578173824016822m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 158,
                column: "Price",
                value: 245.781414223357566m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 159,
                column: "Price",
                value: 30.407746079361509m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 160,
                column: "Price",
                value: 115.227101705485613m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 161,
                column: "Price",
                value: 64.82554581839654m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 162,
                column: "Price",
                value: 215.968284545751907m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 163,
                column: "Price",
                value: 30.508988602559351m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 164,
                column: "Price",
                value: 198.862873681140686m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 165,
                column: "Price",
                value: 45.349926275693442m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 166,
                column: "Price",
                value: 127.173257189711459m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 167,
                column: "Price",
                value: 54.237702653108108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 168,
                column: "Price",
                value: 243.720181669022321m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 169,
                column: "Price",
                value: 31.814465499829524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 170,
                column: "Price",
                value: 136.223409161274992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 171,
                column: "Price",
                value: 27.545366543293097m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 172,
                column: "Price",
                value: 115.605519353352564m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 173,
                column: "Price",
                value: 86.185240824250962m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 174,
                column: "Price",
                value: 217.4368221184467m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 175,
                column: "Price",
                value: 43.163757830610626m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 176,
                column: "Price",
                value: 209.915860148989059m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 177,
                column: "Price",
                value: 28.660186957005075m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 178,
                column: "Price",
                value: 110.805870425815246m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 179,
                column: "Price",
                value: 51.958430623030325m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 180,
                column: "Price",
                value: 249.00286999885025518m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 181,
                column: "Price",
                value: 47.416189960780843m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 182,
                column: "Price",
                value: 155.891003795487803m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 183,
                column: "Price",
                value: 32.909965374445468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 184,
                column: "Price",
                value: 125.370293516038335m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 185,
                column: "Price",
                value: 85.417677314060745m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 186,
                column: "Price",
                value: 214.265703118652819m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 187,
                column: "Price",
                value: 44.446865531751821m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 188,
                column: "Price",
                value: 188.64724799332093m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 189,
                column: "Price",
                value: 38.672655498072794m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 190,
                column: "Price",
                value: 144.355720621010136m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 191,
                column: "Price",
                value: 59.329540737311349m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 192,
                column: "Price",
                value: 208.053154950497381m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 193,
                column: "Price",
                value: 40.562295414030752m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 194,
                column: "Price",
                value: 143.961311216216316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 195,
                column: "Price",
                value: 44.967492292642286m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 196,
                column: "Price",
                value: 107.366601587999595m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 197,
                column: "Price",
                value: 60.984238213853432m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 198,
                column: "Price",
                value: 237.0431579291017048m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 199,
                column: "Price",
                value: 36.606554924587508m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 200,
                column: "Price",
                value: 135.0216779948487542m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 201,
                column: "Price",
                value: 47.167092018361057m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 202,
                column: "Price",
                value: 108.40320029468397m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 203,
                column: "Price",
                value: 68.944883066523613m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 204,
                column: "Price",
                value: 225.280871340991802m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 205,
                column: "Price",
                value: 37.817935010672118m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 206,
                column: "Price",
                value: 184.0630745626912666m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 207,
                column: "Price",
                value: 41.159865652537243m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 208,
                column: "Price",
                value: 126.0104936080974566m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 209,
                column: "Price",
                value: 46.152424383777245m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 210,
                column: "Price",
                value: 213.816373658684691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 211,
                column: "Price",
                value: 33.186929511434841m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 212,
                column: "Price",
                value: 236.691517978784948m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 213,
                column: "Price",
                value: 43.804147228698233m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 214,
                column: "Price",
                value: 130.169096741360961m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 215,
                column: "Price",
                value: 55.138348853912524m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 216,
                column: "Price",
                value: 200.342244528067492m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 217,
                column: "Price",
                value: 45.290725409909858m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 218,
                column: "Price",
                value: 218.595065501317637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 219,
                column: "Price",
                value: 47.792660390440821m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 220,
                column: "Price",
                value: 146.177710314476235m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 221,
                column: "Price",
                value: 50.459176908351854m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 222,
                column: "Price",
                value: 207.368762775053858m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 223,
                column: "Price",
                value: 47.9472178773616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 224,
                column: "Price",
                value: 255.497853045512838m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 225,
                column: "Price",
                value: 47.984265690241694m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 226,
                column: "Price",
                value: 126.234516320156904m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 227,
                column: "Price",
                value: 83.757490133278364m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 228,
                column: "Price",
                value: 218.950415749281914m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 229,
                column: "Price",
                value: 47.523401727321461m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 230,
                column: "Price",
                value: 183.0173413805351776m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 231,
                column: "Price",
                value: 35.0517303095796876m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 232,
                column: "Price",
                value: 145.643691236272387m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 233,
                column: "Price",
                value: 55.198079599390633m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 234,
                column: "Price",
                value: 227.57914493529184m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 235,
                column: "Price",
                value: 43.567209718063381m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 236,
                column: "Price",
                value: 225.259520056655506m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 237,
                column: "Price",
                value: 31.28050916550259m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 238,
                column: "Price",
                value: 146.97464217787687m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 239,
                column: "Price",
                value: 86.389264944032305m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 240,
                column: "Price",
                value: 223.742566884373813m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 241,
                column: "Price",
                value: 35.859976793614453m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 242,
                column: "Price",
                value: 214.500369705475302m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 243,
                column: "Price",
                value: 37.112379521140145m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 244,
                column: "Price",
                value: 104.70799163981324m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 245,
                column: "Price",
                value: 78.0696948446947359m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 246,
                column: "Price",
                value: 231.384564187111819m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 247,
                column: "Price",
                value: 35.673910072408321m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 248,
                column: "Price",
                value: 217.282342321555047m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 249,
                column: "Price",
                value: 42.674822530688649m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 250,
                column: "Price",
                value: 109.655507142389315m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 251,
                column: "Price",
                value: 75.563346954048454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 252,
                column: "Price",
                value: 227.847231258868995m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 253,
                column: "Price",
                value: 35.356834439470788m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 254,
                column: "Price",
                value: 190.413712705504196m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 255,
                column: "Price",
                value: 44.961330189351482m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 256,
                column: "Price",
                value: 115.634252327301208m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 257,
                column: "Price",
                value: 61.46657250365741m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 258,
                column: "Price",
                value: 241.247209630123117m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 259,
                column: "Price",
                value: 34.908213691297284m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 260,
                column: "Price",
                value: 139.0397444801977025m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 261,
                column: "Price",
                value: 35.927333239601843m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 262,
                column: "Price",
                value: 138.273242683318778m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 263,
                column: "Price",
                value: 62.835451827569694m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 264,
                column: "Price",
                value: 226.380973615968603m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 265,
                column: "Price",
                value: 32.326646009412671m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 266,
                column: "Price",
                value: 169.967171923246957m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 267,
                column: "Price",
                value: 44.699910001337509m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 268,
                column: "Price",
                value: 111.147765271583381m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 269,
                column: "Price",
                value: 59.889043497182121m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 270,
                column: "Price",
                value: 205.768228205517449m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 271,
                column: "Price",
                value: 40.0425962877224003m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 272,
                column: "Price",
                value: 218.827933995772057m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 273,
                column: "Price",
                value: 21.229774223980474m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 274,
                column: "Price",
                value: 121.473527715141388m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 275,
                column: "Price",
                value: 70.143536232106794m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 276,
                column: "Price",
                value: 237.576125208722056m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 277,
                column: "Price",
                value: 40.804460132039694m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 278,
                column: "Price",
                value: 251.169911957563099m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 279,
                column: "Price",
                value: 31.929733003783322m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 280,
                column: "Price",
                value: 129.807584335671109m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 281,
                column: "Price",
                value: 69.967339373189044m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 282,
                column: "Price",
                value: 237.494698851749625m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 283,
                column: "Price",
                value: 48.91186475723106m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 284,
                column: "Price",
                value: 195.188318243601399m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 285,
                column: "Price",
                value: 42.606710456902486m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 286,
                column: "Price",
                value: 129.647862272292569m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 287,
                column: "Price",
                value: 50.892762260199671m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 288,
                column: "Price",
                value: 240.0237341284256778m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 289,
                column: "Price",
                value: 31.114861371348206m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 290,
                column: "Price",
                value: 173.314070838898386m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 291,
                column: "Price",
                value: 34.444689334935491m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 292,
                column: "Price",
                value: 118.57337069878505m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 293,
                column: "Price",
                value: 71.34286086938723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 294,
                column: "Price",
                value: 206.164071653013421m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 295,
                column: "Price",
                value: 46.132318300718343m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 296,
                column: "Price",
                value: 221.925255093854729m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 297,
                column: "Price",
                value: 48.867785420439962m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 298,
                column: "Price",
                value: 121.769496148030404m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 299,
                column: "Price",
                value: 74.416443129036777m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 300,
                column: "Price",
                value: 209.0535603912929153m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 301,
                column: "Price",
                value: 34.187530325966713m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 302,
                column: "Price",
                value: 214.592956733308617m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 303,
                column: "Price",
                value: 43.420007638922519m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 304,
                column: "Price",
                value: 132.597141399262215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 305,
                column: "Price",
                value: 75.0168732911309701m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 306,
                column: "Price",
                value: 231.770944394772706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 307,
                column: "Price",
                value: 30.680856332799061m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 308,
                column: "Price",
                value: 225.959916440955797m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 309,
                column: "Price",
                value: 32.346297267779911m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 310,
                column: "Price",
                value: 110.0345403335700168m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 311,
                column: "Price",
                value: 58.237485563430173m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 312,
                column: "Price",
                value: 241.800667510419244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 313,
                column: "Price",
                value: 46.45388585599892m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 314,
                column: "Price",
                value: 162.422068810014601m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 315,
                column: "Price",
                value: 22.301067738221898m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 316,
                column: "Price",
                value: 145.264848152124894m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 317,
                column: "Price",
                value: 58.212775769449714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 318,
                column: "Price",
                value: 244.882437825613799m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 319,
                column: "Price",
                value: 35.570035638672203m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 320,
                column: "Price",
                value: 138.0714384963911937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 321,
                column: "Price",
                value: 43.723442244831575m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 322,
                column: "Price",
                value: 118.572265483486538m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 323,
                column: "Price",
                value: 55.265792755564064m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 324,
                column: "Price",
                value: 248.178834574867965m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 325,
                column: "Price",
                value: 48.114592803132447m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 326,
                column: "Price",
                value: 228.719199720211212m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 327,
                column: "Price",
                value: 31.729361873790564m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 328,
                column: "Price",
                value: 122.049149461232014m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 329,
                column: "Price",
                value: 85.12840626790163m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 330,
                column: "Price",
                value: 209.867136061788904m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 331,
                column: "Price",
                value: 40.650084257039226m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 332,
                column: "Price",
                value: 150.29173438664998m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 333,
                column: "Price",
                value: 44.865912814691207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 334,
                column: "Price",
                value: 108.517807076750432m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 335,
                column: "Price",
                value: 80.850763588132586m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 336,
                column: "Price",
                value: 227.846823916391445m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 337,
                column: "Price",
                value: 34.271538034719144m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 338,
                column: "Price",
                value: 236.756206730464209m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 339,
                column: "Price",
                value: 42.109306148996385m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 340,
                column: "Price",
                value: 129.498611618209481m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 341,
                column: "Price",
                value: 47.892092533227004m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 342,
                column: "Price",
                value: 201.751632706093864m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 343,
                column: "Price",
                value: 42.311392745724215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 344,
                column: "Price",
                value: 160.358085158595947m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 345,
                column: "Price",
                value: 35.0652272008997558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 346,
                column: "Price",
                value: 139.843345459850126m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 347,
                column: "Price",
                value: 78.814512731890388m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 348,
                column: "Price",
                value: 245.868521376513915m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 349,
                column: "Price",
                value: 34.924768033032949m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 350,
                column: "Price",
                value: 158.857056943904792m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 351,
                column: "Price",
                value: 30.901791756377711m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 352,
                column: "Price",
                value: 134.581778465429653m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 353,
                column: "Price",
                value: 47.351695165724176m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 354,
                column: "Price",
                value: 234.21403727250227m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 355,
                column: "Price",
                value: 48.811387952030482m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 356,
                column: "Price",
                value: 232.673472120514419m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 357,
                column: "Price",
                value: 33.52914828641701m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 358,
                column: "Price",
                value: 121.403799860348852m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 359,
                column: "Price",
                value: 82.379404074861177m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 360,
                column: "Price",
                value: 219.946655458434876m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 361,
                column: "Price",
                value: 33.0538887994624793m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 362,
                column: "Price",
                value: 163.586662371962163m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 363,
                column: "Price",
                value: 20.402119101585304m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 364,
                column: "Price",
                value: 143.802879860789746m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 365,
                column: "Price",
                value: 80.482449696858236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 366,
                column: "Price",
                value: 247.872685217281943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 367,
                column: "Price",
                value: 40.754646387312586m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 368,
                column: "Price",
                value: 205.468943516503496m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 369,
                column: "Price",
                value: 40.895847788960467m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 370,
                column: "Price",
                value: 133.121193964392713m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 371,
                column: "Price",
                value: 56.0978049411553092m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 372,
                column: "Price",
                value: 231.371754839852051m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 373,
                column: "Price",
                value: 46.91492684692199m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 374,
                column: "Price",
                value: 184.093540482490896m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 375,
                column: "Price",
                value: 31.674366511914413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 376,
                column: "Price",
                value: 123.661975960852418m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 377,
                column: "Price",
                value: 75.653526767189054m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 378,
                column: "Price",
                value: 244.846218855251201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 379,
                column: "Price",
                value: 36.80009803749023m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 380,
                column: "Price",
                value: 255.571874648555364m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 381,
                column: "Price",
                value: 25.602863567131569m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 382,
                column: "Price",
                value: 134.625119188931294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 383,
                column: "Price",
                value: 49.680767120777817m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 384,
                column: "Price",
                value: 215.942799071444131m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 385,
                column: "Price",
                value: 44.996548724498244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 386,
                column: "Price",
                value: 204.362060746321313m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 387,
                column: "Price",
                value: 25.142023912613215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 388,
                column: "Price",
                value: 123.105073107481845m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 389,
                column: "Price",
                value: 52.861963701483312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 390,
                column: "Price",
                value: 221.0290538379932389m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 391,
                column: "Price",
                value: 40.737295576444035m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 392,
                column: "Price",
                value: 136.429696015279916m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 393,
                column: "Price",
                value: 34.699329488625331m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 394,
                column: "Price",
                value: 133.347584616926929m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 395,
                column: "Price",
                value: 62.94653099354826m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 396,
                column: "Price",
                value: 219.483187419374786m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 397,
                column: "Price",
                value: 44.31789233628354m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 398,
                column: "Price",
                value: 251.764119423757698m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 399,
                column: "Price",
                value: 43.384954935690351m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 400,
                column: "Price",
                value: 109.501188855523408m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 401,
                column: "Price",
                value: 62.510153984822344m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 402,
                column: "Price",
                value: 245.2565949732142m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 403,
                column: "Price",
                value: 38.585520614273015m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 404,
                column: "Price",
                value: 210.673023995776824m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 405,
                column: "Price",
                value: 28.51816387301097m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 406,
                column: "Price",
                value: 127.760765502223764m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 407,
                column: "Price",
                value: 48.979695046195685m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 408,
                column: "Price",
                value: 215.907804638671826m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 409,
                column: "Price",
                value: 47.78251573853017m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 410,
                column: "Price",
                value: 172.862555109232604m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 411,
                column: "Price",
                value: 27.442657274085551m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 412,
                column: "Price",
                value: 110.248299830566717m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 413,
                column: "Price",
                value: 50.00642737806189297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 414,
                column: "Price",
                value: 227.784870010832245m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 415,
                column: "Price",
                value: 30.571212342316207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 416,
                column: "Price",
                value: 247.95959210865918m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 417,
                column: "Price",
                value: 44.580522015109666m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 418,
                column: "Price",
                value: 134.659034101214288m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 419,
                column: "Price",
                value: 63.264497640776706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 420,
                column: "Price",
                value: 216.235269544703592m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 421,
                column: "Price",
                value: 49.917634140828939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 422,
                column: "Price",
                value: 158.361467410559992m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 423,
                column: "Price",
                value: 42.494453867968856m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 424,
                column: "Price",
                value: 149.999238933145641m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 425,
                column: "Price",
                value: 63.781436629480153m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 426,
                column: "Price",
                value: 213.565748666322963m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 427,
                column: "Price",
                value: 35.858471426775226m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 428,
                column: "Price",
                value: 218.569473198187942m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 429,
                column: "Price",
                value: 41.163017728640696m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 430,
                column: "Price",
                value: 149.487933333681125m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 431,
                column: "Price",
                value: 83.199203168249316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 432,
                column: "Price",
                value: 217.907902336211424m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 433,
                column: "Price",
                value: 30.172044976171389m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 434,
                column: "Price",
                value: 220.832170719057347m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 435,
                column: "Price",
                value: 45.203991639558786m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 436,
                column: "Price",
                value: 111.731235237192289m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 437,
                column: "Price",
                value: 70.0214268186754085m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 438,
                column: "Price",
                value: 241.365745419865923m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 439,
                column: "Price",
                value: 47.601774647582723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 440,
                column: "Price",
                value: 209.700373628476342m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 441,
                column: "Price",
                value: 37.478345226050714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 442,
                column: "Price",
                value: 127.258603312226839m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 443,
                column: "Price",
                value: 65.417120070326925m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 444,
                column: "Price",
                value: 226.614766345312216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 445,
                column: "Price",
                value: 33.462412162439022m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 446,
                column: "Price",
                value: 236.921411160380968m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 447,
                column: "Price",
                value: 23.812912861178743m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 448,
                column: "Price",
                value: 143.368832275619376m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 449,
                column: "Price",
                value: 69.818319196397497m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 450,
                column: "Price",
                value: 224.39983123855472m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 451,
                column: "Price",
                value: 47.104326612992684m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 452,
                column: "Price",
                value: 193.234907643840762m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 453,
                column: "Price",
                value: 24.765342551349477m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 454,
                column: "Price",
                value: 132.586463752166171m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 455,
                column: "Price",
                value: 80.60438536681765m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 456,
                column: "Price",
                value: 243.627385116533413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 457,
                column: "Price",
                value: 34.782206613994003m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 458,
                column: "Price",
                value: 227.0377402104689291m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 459,
                column: "Price",
                value: 48.434032788180137m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 460,
                column: "Price",
                value: 101.386685766949163m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 461,
                column: "Price",
                value: 53.0448834576466378m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 462,
                column: "Price",
                value: 234.480862967269216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 463,
                column: "Price",
                value: 38.21517862215868m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 464,
                column: "Price",
                value: 211.249629081532309m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 465,
                column: "Price",
                value: 46.36144040029691m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 466,
                column: "Price",
                value: 117.249712441655425m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 467,
                column: "Price",
                value: 62.961074627390772m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 468,
                column: "Price",
                value: 232.225348865547775m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 469,
                column: "Price",
                value: 40.0689584836602285m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 470,
                column: "Price",
                value: 224.501876296625704m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 471,
                column: "Price",
                value: 32.760244121476495m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 472,
                column: "Price",
                value: 117.956331400477244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 473,
                column: "Price",
                value: 59.950216719462351m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 474,
                column: "Price",
                value: 201.714586712222258m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 475,
                column: "Price",
                value: 36.961924616631981m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 476,
                column: "Price",
                value: 237.282791499221281m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 477,
                column: "Price",
                value: 38.965081909420997m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 478,
                column: "Price",
                value: 136.865456447321808m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 479,
                column: "Price",
                value: 72.855150661981569m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 480,
                column: "Price",
                value: 216.498593283180679m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 481,
                column: "Price",
                value: 45.353739833958423m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 482,
                column: "Price",
                value: 146.860447571143984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 483,
                column: "Price",
                value: 38.106969669018784m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 484,
                column: "Price",
                value: 148.20347229409719m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 485,
                column: "Price",
                value: 78.304921747909411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 486,
                column: "Price",
                value: 224.247482253023988m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 487,
                column: "Price",
                value: 36.0733715884369188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 488,
                column: "Price",
                value: 167.894594635897429m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 489,
                column: "Price",
                value: 26.190975935497089m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 490,
                column: "Price",
                value: 142.989561729545574m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 491,
                column: "Price",
                value: 56.941722277307639m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 492,
                column: "Price",
                value: 200.695906206307159m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 493,
                column: "Price",
                value: 36.376728050015734m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 494,
                column: "Price",
                value: 155.657405656433025m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 495,
                column: "Price",
                value: 43.868274405412344m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 496,
                column: "Price",
                value: 134.258187578920028m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 497,
                column: "Price",
                value: 51.578546882995351m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 498,
                column: "Price",
                value: 240.171743750591967m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 499,
                column: "Price",
                value: 36.551113231545259m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 500,
                column: "Price",
                value: 196.174586154284888m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 501,
                column: "Price",
                value: 46.392286273237284m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 502,
                column: "Price",
                value: 126.836124198155112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 503,
                column: "Price",
                value: 81.368548596245645m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 504,
                column: "Price",
                value: 241.77758015095814m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 505,
                column: "Price",
                value: 31.659838158344619m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 506,
                column: "Price",
                value: 191.781633293136809m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 507,
                column: "Price",
                value: 48.278760161658012m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 508,
                column: "Price",
                value: 142.453355717986032m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 509,
                column: "Price",
                value: 81.323245916337862m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 510,
                column: "Price",
                value: 219.406805467801673m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 511,
                column: "Price",
                value: 39.318495783553244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 512,
                column: "Price",
                value: 137.899441699679021m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 513,
                column: "Price",
                value: 29.360843374612052m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 514,
                column: "Price",
                value: 138.881657684054724m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 515,
                column: "Price",
                value: 52.27196417695766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 516,
                column: "Price",
                value: 201.716017805121191m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 517,
                column: "Price",
                value: 49.183047440360331m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 518,
                column: "Price",
                value: 194.690080958936357m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 519,
                column: "Price",
                value: 34.706995350946761m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 520,
                column: "Price",
                value: 119.432158314725354m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 521,
                column: "Price",
                value: 78.729899629883402m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 522,
                column: "Price",
                value: 207.800140284530676m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 523,
                column: "Price",
                value: 41.596985358613306m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 524,
                column: "Price",
                value: 135.614642439743926m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 525,
                column: "Price",
                value: 42.793942017756356m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 526,
                column: "Price",
                value: 100.527953359870597m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 527,
                column: "Price",
                value: 85.153605665170717m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 528,
                column: "Price",
                value: 228.472989310308093m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 529,
                column: "Price",
                value: 33.740843899871166m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 530,
                column: "Price",
                value: 213.81545574344706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 531,
                column: "Price",
                value: 25.346884541427057m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 532,
                column: "Price",
                value: 147.783655928040136m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 533,
                column: "Price",
                value: 70.32572014759548m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 534,
                column: "Price",
                value: 224.112704086289797m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 535,
                column: "Price",
                value: 30.889180336485253m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 536,
                column: "Price",
                value: 205.660102586462813m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 537,
                column: "Price",
                value: 20.960465763281655m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 538,
                column: "Price",
                value: 148.88713057506472m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 539,
                column: "Price",
                value: 84.60863018430485m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 540,
                column: "Price",
                value: 220.784289593258461m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 541,
                column: "Price",
                value: 35.615937469820915m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 542,
                column: "Price",
                value: 208.0767111496624469m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 543,
                column: "Price",
                value: 37.908319505684437m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 544,
                column: "Price",
                value: 142.386469920944616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 545,
                column: "Price",
                value: 51.735198769869939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 546,
                column: "Price",
                value: 233.0899476193048558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 547,
                column: "Price",
                value: 43.132497575721357m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 548,
                column: "Price",
                value: 227.447091345166398m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 549,
                column: "Price",
                value: 46.497617275953938m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 550,
                column: "Price",
                value: 116.896342396129537m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 551,
                column: "Price",
                value: 70.0605857102928967m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 552,
                column: "Price",
                value: 205.413237733585822m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 553,
                column: "Price",
                value: 47.101173562914972m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 554,
                column: "Price",
                value: 143.560345976512983m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 555,
                column: "Price",
                value: 22.156700564591401m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 556,
                column: "Price",
                value: 138.802489799394496m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 557,
                column: "Price",
                value: 50.908586546872425m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 558,
                column: "Price",
                value: 218.522674835368778m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 559,
                column: "Price",
                value: 39.128035895721146m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 560,
                column: "Price",
                value: 243.230247095788008m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 561,
                column: "Price",
                value: 44.135228896726514m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 562,
                column: "Price",
                value: 118.533874509485557m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 563,
                column: "Price",
                value: 78.599915132467548m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 564,
                column: "Price",
                value: 244.718708365580358m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 565,
                column: "Price",
                value: 31.988066844671695m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 566,
                column: "Price",
                value: 251.901811737200142m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 567,
                column: "Price",
                value: 34.716923428758912m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 568,
                column: "Price",
                value: 129.0897217900883328m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 569,
                column: "Price",
                value: 78.19287923865064m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 570,
                column: "Price",
                value: 207.955508425146502m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 571,
                column: "Price",
                value: 43.132169892674057m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 572,
                column: "Price",
                value: 229.584643039114536m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 573,
                column: "Price",
                value: 31.908237082997824m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 574,
                column: "Price",
                value: 110.873445963625271m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 575,
                column: "Price",
                value: 72.578091191403076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 576,
                column: "Price",
                value: 228.737837783291456m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 577,
                column: "Price",
                value: 32.454043067194476m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 578,
                column: "Price",
                value: 236.249589521265802m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 579,
                column: "Price",
                value: 36.656595174963073m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 580,
                column: "Price",
                value: 113.64185586505087m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 581,
                column: "Price",
                value: 54.628395020525937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 582,
                column: "Price",
                value: 208.360525906391531m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 583,
                column: "Price",
                value: 37.797007701436102m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 584,
                column: "Price",
                value: 218.238540740240485m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 585,
                column: "Price",
                value: 29.956288110468535m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 586,
                column: "Price",
                value: 130.0151647090850175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 587,
                column: "Price",
                value: 57.902279829015413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 588,
                column: "Price",
                value: 236.736567866707897m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 589,
                column: "Price",
                value: 45.303375675463064m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 590,
                column: "Price",
                value: 142.435130177354604m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 591,
                column: "Price",
                value: 35.897100298845491m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 592,
                column: "Price",
                value: 134.867737392696341m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 593,
                column: "Price",
                value: 57.881173428262035m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 594,
                column: "Price",
                value: 221.255264071440282m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 595,
                column: "Price",
                value: 49.964701718485644m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 596,
                column: "Price",
                value: 141.251214676894973m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 597,
                column: "Price",
                value: 48.363895399088372m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 598,
                column: "Price",
                value: 114.37786255395126m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 599,
                column: "Price",
                value: 55.472616760540707m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 600,
                column: "Price",
                value: 242.429100753874558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 601,
                column: "Price",
                value: 35.122666195512483m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 602,
                column: "Price",
                value: 153.769985435548096m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 603,
                column: "Price",
                value: 31.124994576706411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 604,
                column: "Price",
                value: 115.253028287405115m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 605,
                column: "Price",
                value: 77.410485415779952m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 606,
                column: "Price",
                value: 221.405595261010541m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 607,
                column: "Price",
                value: 46.67075544416369m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 608,
                column: "Price",
                value: 176.698929707010343m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 609,
                column: "Price",
                value: 39.0351979302268368m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 610,
                column: "Price",
                value: 117.564848156883411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 611,
                column: "Price",
                value: 56.128667593434937m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 612,
                column: "Price",
                value: 200.749075900030533m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 613,
                column: "Price",
                value: 31.498623162301312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 614,
                column: "Price",
                value: 153.917560258472834m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 615,
                column: "Price",
                value: 47.596569205923967m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 616,
                column: "Price",
                value: 118.170704553861751m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 617,
                column: "Price",
                value: 72.777802480636239m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 618,
                column: "Price",
                value: 211.391942829832072m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 619,
                column: "Price",
                value: 33.681607947151642m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 620,
                column: "Price",
                value: 176.90176178628236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 621,
                column: "Price",
                value: 31.57694149233943m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 622,
                column: "Price",
                value: 119.0224005525628405m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 623,
                column: "Price",
                value: 68.462368198457751m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 624,
                column: "Price",
                value: 247.90274486854521m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 625,
                column: "Price",
                value: 33.49666677395034m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 626,
                column: "Price",
                value: 223.720601776696079m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 627,
                column: "Price",
                value: 25.798518269253961m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 628,
                column: "Price",
                value: 103.617477540920581m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 629,
                column: "Price",
                value: 52.29914628805955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 630,
                column: "Price",
                value: 211.100505725911398m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 631,
                column: "Price",
                value: 43.98301187763555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 632,
                column: "Price",
                value: 147.521606251819107m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 633,
                column: "Price",
                value: 22.290300705235893m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 634,
                column: "Price",
                value: 141.713506869716315m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 635,
                column: "Price",
                value: 59.989132232236429m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 636,
                column: "Price",
                value: 221.816668054544471m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 637,
                column: "Price",
                value: 40.0142574265275477m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 638,
                column: "Price",
                value: 208.876290561466881m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 639,
                column: "Price",
                value: 36.91420052438278m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 640,
                column: "Price",
                value: 138.158045545510807m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 641,
                column: "Price",
                value: 73.66420381219801m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 642,
                column: "Price",
                value: 234.101558792435924m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 643,
                column: "Price",
                value: 37.884612546514555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 644,
                column: "Price",
                value: 249.577270620767489m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 645,
                column: "Price",
                value: 29.50655924700716m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 646,
                column: "Price",
                value: 122.963700764213781m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 647,
                column: "Price",
                value: 56.493196626584803m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 648,
                column: "Price",
                value: 234.337453858166059m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 649,
                column: "Price",
                value: 35.753674256010188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 650,
                column: "Price",
                value: 206.744526226707043m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 651,
                column: "Price",
                value: 27.513493388321314m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 652,
                column: "Price",
                value: 136.503943820389782m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 653,
                column: "Price",
                value: 85.439055008076166m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 654,
                column: "Price",
                value: 217.352848000719756m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 655,
                column: "Price",
                value: 44.668198677299837m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 656,
                column: "Price",
                value: 255.540584759712846m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 657,
                column: "Price",
                value: 47.466175700544562m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 658,
                column: "Price",
                value: 112.410310407750885m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 659,
                column: "Price",
                value: 80.271056565479859m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 660,
                column: "Price",
                value: 235.90481410253643m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 661,
                column: "Price",
                value: 48.553356139218999m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 662,
                column: "Price",
                value: 219.787212907170222m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 663,
                column: "Price",
                value: 26.140731229926618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 664,
                column: "Price",
                value: 147.849966831776393m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 665,
                column: "Price",
                value: 65.937246676610226m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 666,
                column: "Price",
                value: 208.161577347666895m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 667,
                column: "Price",
                value: 33.718543995125838m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 668,
                column: "Price",
                value: 189.119856578219378m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 669,
                column: "Price",
                value: 45.759866342496482m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 670,
                column: "Price",
                value: 127.111141604145641m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 671,
                column: "Price",
                value: 72.314095236827899m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 672,
                column: "Price",
                value: 222.183505894335373m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 673,
                column: "Price",
                value: 30.567887298931255m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 674,
                column: "Price",
                value: 209.0969778401007297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 675,
                column: "Price",
                value: 24.699093962105501m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 676,
                column: "Price",
                value: 142.0899507520149174m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 677,
                column: "Price",
                value: 66.78568230048322m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 678,
                column: "Price",
                value: 225.845611178348437m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 679,
                column: "Price",
                value: 48.0179547986283485m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 680,
                column: "Price",
                value: 223.840847549470442m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 681,
                column: "Price",
                value: 36.682517688094944m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 682,
                column: "Price",
                value: 120.462627368493914m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 683,
                column: "Price",
                value: 61.396140535969053m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 684,
                column: "Price",
                value: 200.225178125579134m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 685,
                column: "Price",
                value: 44.525109356099879m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 686,
                column: "Price",
                value: 153.59660171623184m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 687,
                column: "Price",
                value: 25.03662286484965m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 688,
                column: "Price",
                value: 140.724741980894516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 689,
                column: "Price",
                value: 57.270327688176159m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 690,
                column: "Price",
                value: 225.750229569319279m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 691,
                column: "Price",
                value: 44.27640667507205m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 692,
                column: "Price",
                value: 170.424316454106888m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 693,
                column: "Price",
                value: 42.599285225263495m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 694,
                column: "Price",
                value: 143.800904523406283m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 695,
                column: "Price",
                value: 63.181585247545079m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 696,
                column: "Price",
                value: 205.796181455251923m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 697,
                column: "Price",
                value: 49.520554316521424m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 698,
                column: "Price",
                value: 139.377194861132775m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 699,
                column: "Price",
                value: 32.470798650437581m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 700,
                column: "Price",
                value: 123.523004808630166m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 701,
                column: "Price",
                value: 45.418507271189487m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 702,
                column: "Price",
                value: 203.140348600210066m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 703,
                column: "Price",
                value: 35.0676766607149277m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 704,
                column: "Price",
                value: 183.50586223217627m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 705,
                column: "Price",
                value: 25.229557241387165m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 706,
                column: "Price",
                value: 105.967292211226076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 707,
                column: "Price",
                value: 45.96551185232894m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 708,
                column: "Price",
                value: 224.0611665283301401m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 709,
                column: "Price",
                value: 35.66001702517167m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 710,
                column: "Price",
                value: 240.560857738112159m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 711,
                column: "Price",
                value: 43.0671584983745864m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 712,
                column: "Price",
                value: 130.150217427507515m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 713,
                column: "Price",
                value: 72.637952625096237m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 714,
                column: "Price",
                value: 215.971276615032615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 715,
                column: "Price",
                value: 40.138051123748647m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 716,
                column: "Price",
                value: 255.606369259747012m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 717,
                column: "Price",
                value: 33.511617692506061m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 718,
                column: "Price",
                value: 123.180889015441604m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 719,
                column: "Price",
                value: 74.938557845361496m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 720,
                column: "Price",
                value: 248.860332698695344m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 721,
                column: "Price",
                value: 44.485587147870378m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 722,
                column: "Price",
                value: 186.14494888366786m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 723,
                column: "Price",
                value: 27.182840032720487m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 724,
                column: "Price",
                value: 137.421281140424753m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 725,
                column: "Price",
                value: 63.0804309762712342m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 726,
                column: "Price",
                value: 201.872451694665323m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 727,
                column: "Price",
                value: 37.794320364761291m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 728,
                column: "Price",
                value: 158.920392823280663m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 729,
                column: "Price",
                value: 48.791450801489333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 730,
                column: "Price",
                value: 140.463713203213655m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 731,
                column: "Price",
                value: 72.24641908924989m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 732,
                column: "Price",
                value: 241.0954344730742223m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 733,
                column: "Price",
                value: 31.968719054059875m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 734,
                column: "Price",
                value: 164.926408074463677m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 735,
                column: "Price",
                value: 24.9405167407343m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 736,
                column: "Price",
                value: 118.242614052292723m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 737,
                column: "Price",
                value: 45.525747413011246m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 738,
                column: "Price",
                value: 221.162338297876635m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 739,
                column: "Price",
                value: 30.917512644922565m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 740,
                column: "Price",
                value: 203.164192171020681m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 741,
                column: "Price",
                value: 42.923578629755326m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 742,
                column: "Price",
                value: 136.559381763962097m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 743,
                column: "Price",
                value: 58.080146926392247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 744,
                column: "Price",
                value: 232.9480520476811m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 745,
                column: "Price",
                value: 34.336490399412942m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 746,
                column: "Price",
                value: 250.763117956746242m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 747,
                column: "Price",
                value: 39.0865645588306376m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 748,
                column: "Price",
                value: 147.796816616725388m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 749,
                column: "Price",
                value: 78.0760572642724249m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 750,
                column: "Price",
                value: 233.405441503592339m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 751,
                column: "Price",
                value: 42.868910871889361m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 752,
                column: "Price",
                value: 237.335976185787568m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 753,
                column: "Price",
                value: 24.515341954001774m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 754,
                column: "Price",
                value: 105.026283294664563m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 755,
                column: "Price",
                value: 52.641354583452484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 756,
                column: "Price",
                value: 210.830912947160098m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 757,
                column: "Price",
                value: 31.252339063712714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 758,
                column: "Price",
                value: 196.0418683958187387m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 759,
                column: "Price",
                value: 42.137528884065914m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 760,
                column: "Price",
                value: 116.914893741479333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 761,
                column: "Price",
                value: 61.571671452788076m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 762,
                column: "Price",
                value: 236.856404163127017m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 763,
                column: "Price",
                value: 32.584481418958881m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 764,
                column: "Price",
                value: 218.739669897857782m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 765,
                column: "Price",
                value: 37.296053901245704m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 766,
                column: "Price",
                value: 115.459065287082365m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 767,
                column: "Price",
                value: 85.681300236279229m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 768,
                column: "Price",
                value: 204.904676570413401m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 769,
                column: "Price",
                value: 40.313787505438877m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 770,
                column: "Price",
                value: 257.822004497109371m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 771,
                column: "Price",
                value: 31.232423142088922m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 772,
                column: "Price",
                value: 114.243639966888656m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 773,
                column: "Price",
                value: 57.675736437300585m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 774,
                column: "Price",
                value: 249.261702872481048m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 775,
                column: "Price",
                value: 46.458949109088478m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 776,
                column: "Price",
                value: 147.671822534893935m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 777,
                column: "Price",
                value: 31.974108617787582m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 778,
                column: "Price",
                value: 103.375791726992379m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 779,
                column: "Price",
                value: 52.828871390896634m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 780,
                column: "Price",
                value: 203.85921525661522m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 781,
                column: "Price",
                value: 37.178891087052194m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 782,
                column: "Price",
                value: 259.0380596577072707m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 783,
                column: "Price",
                value: 24.698756913180129m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 784,
                column: "Price",
                value: 129.0313284475549241m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 785,
                column: "Price",
                value: 82.943325749990708m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 786,
                column: "Price",
                value: 205.0821663369783406m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 787,
                column: "Price",
                value: 39.35587624592368m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 788,
                column: "Price",
                value: 200.192633133117656m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 789,
                column: "Price",
                value: 37.139422156484468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 790,
                column: "Price",
                value: 108.0691021484447555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 791,
                column: "Price",
                value: 68.19425046856234m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 792,
                column: "Price",
                value: 247.824702153630829m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 793,
                column: "Price",
                value: 39.087260875533265m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 794,
                column: "Price",
                value: 206.768101310110426m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 795,
                column: "Price",
                value: 42.0349809797543863m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 796,
                column: "Price",
                value: 122.528838199288483m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 797,
                column: "Price",
                value: 70.70935203801028m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 798,
                column: "Price",
                value: 206.270064024784373m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 799,
                column: "Price",
                value: 42.953824500597822m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 800,
                column: "Price",
                value: 229.602395372617371m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 801,
                column: "Price",
                value: 28.753241699440654m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 802,
                column: "Price",
                value: 104.89644662652247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 803,
                column: "Price",
                value: 66.368456249757315m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 804,
                column: "Price",
                value: 207.224019786807955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 805,
                column: "Price",
                value: 46.0947818145013186m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 806,
                column: "Price",
                value: 147.331238867948381m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 807,
                column: "Price",
                value: 38.749080229796889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 808,
                column: "Price",
                value: 127.284684233462391m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 809,
                column: "Price",
                value: 59.862168056153462m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 810,
                column: "Price",
                value: 231.861866763747926m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 811,
                column: "Price",
                value: 32.73368842067392m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 812,
                column: "Price",
                value: 171.00823615210071216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 813,
                column: "Price",
                value: 24.930593410921919m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 814,
                column: "Price",
                value: 108.637972625091411m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 815,
                column: "Price",
                value: 73.203221220905904m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 816,
                column: "Price",
                value: 241.845507606527939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 817,
                column: "Price",
                value: 47.859187616764574m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 818,
                column: "Price",
                value: 250.549977286172673m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 819,
                column: "Price",
                value: 40.688309120100017m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 820,
                column: "Price",
                value: 101.328994420308236m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 821,
                column: "Price",
                value: 63.835432954788457m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 822,
                column: "Price",
                value: 225.531609086018206m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 823,
                column: "Price",
                value: 30.37860760740589m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 824,
                column: "Price",
                value: 202.485352660244116m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 825,
                column: "Price",
                value: 21.159166115846112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 826,
                column: "Price",
                value: 129.420489489566387m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 827,
                column: "Price",
                value: 49.044922910683493m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 828,
                column: "Price",
                value: 202.648721785915312m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 829,
                column: "Price",
                value: 48.468301742529558m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 830,
                column: "Price",
                value: 206.6221735060123m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 831,
                column: "Price",
                value: 39.461386747889392m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 832,
                column: "Price",
                value: 144.961059824246957m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 833,
                column: "Price",
                value: 49.134085157937955m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 834,
                column: "Price",
                value: 218.219128930611873m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 835,
                column: "Price",
                value: 36.391947981845631m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 836,
                column: "Price",
                value: 217.124446770252913m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 837,
                column: "Price",
                value: 31.382704347632596m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 838,
                column: "Price",
                value: 139.502978452470468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 839,
                column: "Price",
                value: 85.582736373193207m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 840,
                column: "Price",
                value: 216.414964491504172m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 841,
                column: "Price",
                value: 35.0633003615059353m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 842,
                column: "Price",
                value: 209.70059651889856m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 843,
                column: "Price",
                value: 48.148926927824907m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 844,
                column: "Price",
                value: 146.487321967892367m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 845,
                column: "Price",
                value: 60.103992262733887m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 846,
                column: "Price",
                value: 225.828346939928247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 847,
                column: "Price",
                value: 41.168737011400889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 848,
                column: "Price",
                value: 199.813309722442052m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 849,
                column: "Price",
                value: 21.958748785825766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 850,
                column: "Price",
                value: 145.00905041158278297m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 851,
                column: "Price",
                value: 70.680122832700753m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 852,
                column: "Price",
                value: 245.205857273168687m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 853,
                column: "Price",
                value: 30.996483287206216m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 854,
                column: "Price",
                value: 176.0336509776578026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 855,
                column: "Price",
                value: 32.964111997548765m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 856,
                column: "Price",
                value: 112.422458096242054m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 857,
                column: "Price",
                value: 53.230632107845899m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 858,
                column: "Price",
                value: 221.74143291663887m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 859,
                column: "Price",
                value: 49.72373839843827m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 860,
                column: "Price",
                value: 174.631333460105238m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 861,
                column: "Price",
                value: 42.443236498230252m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 862,
                column: "Price",
                value: 149.825489451718862m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 863,
                column: "Price",
                value: 71.0569360828402863m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 864,
                column: "Price",
                value: 248.764677787095121m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 865,
                column: "Price",
                value: 39.247823771352318m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 866,
                column: "Price",
                value: 217.292440632519003m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 867,
                column: "Price",
                value: 44.575283560127439m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 868,
                column: "Price",
                value: 120.0734498511396768m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 869,
                column: "Price",
                value: 51.30396799064842m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 870,
                column: "Price",
                value: 231.607770946456802m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 871,
                column: "Price",
                value: 33.673065098013445m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 872,
                column: "Price",
                value: 199.300849682660012m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 873,
                column: "Price",
                value: 22.681157800785812m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 874,
                column: "Price",
                value: 109.113087833201613m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 875,
                column: "Price",
                value: 71.840950781424394m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 876,
                column: "Price",
                value: 240.7646580994616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 877,
                column: "Price",
                value: 45.368092038802563m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 878,
                column: "Price",
                value: 138.362448800060678m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 879,
                column: "Price",
                value: 36.286714737529251m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 880,
                column: "Price",
                value: 139.222075049138818m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 881,
                column: "Price",
                value: 77.728345931842422m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 882,
                column: "Price",
                value: 226.726219060390866m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 883,
                column: "Price",
                value: 39.660701395002484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 884,
                column: "Price",
                value: 146.757489748739167m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 885,
                column: "Price",
                value: 47.143652800889156m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 886,
                column: "Price",
                value: 133.660046201678889m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 887,
                column: "Price",
                value: 48.273617407557201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 888,
                column: "Price",
                value: 235.440926199206646m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 889,
                column: "Price",
                value: 40.800133006332679m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 890,
                column: "Price",
                value: 245.275585942379094m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 891,
                column: "Price",
                value: 47.716285347754394m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 892,
                column: "Price",
                value: 139.768903202201789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 893,
                column: "Price",
                value: 46.71932901625793m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 894,
                column: "Price",
                value: 219.428399947865023m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 895,
                column: "Price",
                value: 42.308064095322946m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 896,
                column: "Price",
                value: 216.278415993456394m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 897,
                column: "Price",
                value: 28.00184403727337035m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 898,
                column: "Price",
                value: 103.630897559194079m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 899,
                column: "Price",
                value: 71.0172323596931234m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 900,
                column: "Price",
                value: 238.617948307836581m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 901,
                column: "Price",
                value: 35.595204664830544m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 902,
                column: "Price",
                value: 173.315107362569039m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 903,
                column: "Price",
                value: 28.0347862709678695m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 904,
                column: "Price",
                value: 104.676013178262328m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 905,
                column: "Price",
                value: 64.259947321759281m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 906,
                column: "Price",
                value: 229.861785207404303m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 907,
                column: "Price",
                value: 46.249222135609133m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 908,
                column: "Price",
                value: 166.0217362762530588m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 909,
                column: "Price",
                value: 45.0239867797869555m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 910,
                column: "Price",
                value: 139.0548615622461683m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 911,
                column: "Price",
                value: 48.00579534236278323m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 912,
                column: "Price",
                value: 234.435345939585896m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 913,
                column: "Price",
                value: 34.491054302517868m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 914,
                column: "Price",
                value: 147.168221382361071m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 915,
                column: "Price",
                value: 26.46825354906451m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 916,
                column: "Price",
                value: 104.464887569789202m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 917,
                column: "Price",
                value: 77.414041472097812m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 918,
                column: "Price",
                value: 217.931410926779695m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 919,
                column: "Price",
                value: 31.261829208261879m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 920,
                column: "Price",
                value: 259.12349072782675m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 921,
                column: "Price",
                value: 33.906504289720262m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 922,
                column: "Price",
                value: 104.50295272935422m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 923,
                column: "Price",
                value: 68.649485559215083m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 924,
                column: "Price",
                value: 228.614344310288872m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 925,
                column: "Price",
                value: 45.836036172677289m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 926,
                column: "Price",
                value: 225.178290368070658m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 927,
                column: "Price",
                value: 47.970383072928272m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 928,
                column: "Price",
                value: 108.441788490861481m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 929,
                column: "Price",
                value: 45.616310242418906m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 930,
                column: "Price",
                value: 236.166200738965872m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 931,
                column: "Price",
                value: 45.774150101475345m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 932,
                column: "Price",
                value: 161.945633362022461m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 933,
                column: "Price",
                value: 33.143679506635763m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 934,
                column: "Price",
                value: 132.486096388634087m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 935,
                column: "Price",
                value: 58.807121766242001m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 936,
                column: "Price",
                value: 211.28780575527037m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 937,
                column: "Price",
                value: 37.353806307175138m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 938,
                column: "Price",
                value: 146.0531046338870986m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 939,
                column: "Price",
                value: 47.0874627257178912m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 940,
                column: "Price",
                value: 140.0833024851842258m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 941,
                column: "Price",
                value: 86.00557597724031289m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 942,
                column: "Price",
                value: 224.982811994839777m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 943,
                column: "Price",
                value: 34.102595501274413m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 944,
                column: "Price",
                value: 165.387875954133463m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 945,
                column: "Price",
                value: 28.65105583541141m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 946,
                column: "Price",
                value: 132.635372873179122m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 947,
                column: "Price",
                value: 71.355872855235883m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 948,
                column: "Price",
                value: 205.774619028860213m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 949,
                column: "Price",
                value: 36.329416780561892m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 950,
                column: "Price",
                value: 177.527232174978381m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 951,
                column: "Price",
                value: 30.802661220199267m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 952,
                column: "Price",
                value: 118.533538723934748m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 953,
                column: "Price",
                value: 71.233500804044212m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 954,
                column: "Price",
                value: 202.503004073990824m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 955,
                column: "Price",
                value: 49.887775086996324m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 956,
                column: "Price",
                value: 169.195788025790092m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 957,
                column: "Price",
                value: 40.800269869298548m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 958,
                column: "Price",
                value: 133.491207594942776m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 959,
                column: "Price",
                value: 62.884670135042802m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 960,
                column: "Price",
                value: 209.313498801619533m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 961,
                column: "Price",
                value: 46.566378550533419m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 962,
                column: "Price",
                value: 192.381037886087746m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 963,
                column: "Price",
                value: 28.676260310741828m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 964,
                column: "Price",
                value: 126.177894860842257m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 965,
                column: "Price",
                value: 53.949208765931052m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 966,
                column: "Price",
                value: 224.188047293166175m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 967,
                column: "Price",
                value: 43.202802036248636m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 968,
                column: "Price",
                value: 135.0688335369638001m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 969,
                column: "Price",
                value: 40.56326668146203m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 970,
                column: "Price",
                value: 139.233796363319999m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 971,
                column: "Price",
                value: 47.329289705808288m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 972,
                column: "Price",
                value: 209.211705721833457m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 973,
                column: "Price",
                value: 49.148232230911436m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 974,
                column: "Price",
                value: 209.427650781941832m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 975,
                column: "Price",
                value: 44.704099610672706m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 976,
                column: "Price",
                value: 140.523051337623111m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 977,
                column: "Price",
                value: 59.356376331208623m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 978,
                column: "Price",
                value: 204.136428531881126m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 979,
                column: "Price",
                value: 33.413665051497055m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 980,
                column: "Price",
                value: 162.718860414200528m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 981,
                column: "Price",
                value: 22.073507100433473m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 982,
                column: "Price",
                value: 112.453702291860367m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 983,
                column: "Price",
                value: 60.087262838075954m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 984,
                column: "Price",
                value: 211.58565210956614m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 985,
                column: "Price",
                value: 39.899866755256808m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 986,
                column: "Price",
                value: 242.621034206655427m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 987,
                column: "Price",
                value: 48.936095278354681m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 988,
                column: "Price",
                value: 107.995567750069811m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 989,
                column: "Price",
                value: 54.444317426535472m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 990,
                column: "Price",
                value: 219.76615292404838m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 991,
                column: "Price",
                value: 36.703321315345082m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 992,
                column: "Price",
                value: 216.989768587894888m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 993,
                column: "Price",
                value: 46.330672939084469m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 994,
                column: "Price",
                value: 148.55961944737233m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 995,
                column: "Price",
                value: 74.414032487043455m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 996,
                column: "Price",
                value: 240.179017722608171m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 997,
                column: "Price",
                value: 37.490138877899741m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 998,
                column: "Price",
                value: 258.00552909145681069m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 999,
                column: "Price",
                value: 47.554804546029883m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Price",
                value: 130.732960413031291m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Price",
                value: 54.690265757173738m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Price",
                value: 246.839886302098474m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Price",
                value: 43.877927576024842m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Price",
                value: 196.638762100834856m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Price",
                value: 42.596623103362484m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Price",
                value: 149.884826791748619m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Price",
                value: 66.298689535445683m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Price",
                value: 242.277862871366201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1009,
                column: "Price",
                value: 45.928475014160281m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Price",
                value: 228.107770620872158m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1011,
                column: "Price",
                value: 48.842399109265701m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1012,
                column: "Price",
                value: 111.566253292446266m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1013,
                column: "Price",
                value: 76.246041830584146m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1014,
                column: "Price",
                value: 218.0943648594123521m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1015,
                column: "Price",
                value: 48.444608081708724m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1016,
                column: "Price",
                value: 193.812138343291656m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1017,
                column: "Price",
                value: 45.673783271173748m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1018,
                column: "Price",
                value: 145.776137875787939m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1019,
                column: "Price",
                value: 75.912787304676431m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1020,
                column: "Price",
                value: 242.570759221484428m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1021,
                column: "Price",
                value: 44.0636049336161839m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1022,
                column: "Price",
                value: 247.898491083892738m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1023,
                column: "Price",
                value: 44.00442993207436737m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Price",
                value: 126.103591374782369m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1025,
                column: "Price",
                value: 73.365209526219683m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1026,
                column: "Price",
                value: 210.318504272201257m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1027,
                column: "Price",
                value: 33.572565886853938m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1028,
                column: "Price",
                value: 219.905324334872766m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1029,
                column: "Price",
                value: 22.643735186583316m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1030,
                column: "Price",
                value: 136.618038406419991m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1031,
                column: "Price",
                value: 56.37996214700464m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1032,
                column: "Price",
                value: 239.260667156505247m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1033,
                column: "Price",
                value: 41.877555275122418m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1034,
                column: "Price",
                value: 140.989127255591239m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1035,
                column: "Price",
                value: 29.0489067628970253m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1036,
                column: "Price",
                value: 142.21493860164281m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1037,
                column: "Price",
                value: 71.792104928444152m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1038,
                column: "Price",
                value: 232.444311245040614m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1039,
                column: "Price",
                value: 34.447941563465646m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1040,
                column: "Price",
                value: 258.351420108095957m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1041,
                column: "Price",
                value: 43.817975813524188m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1042,
                column: "Price",
                value: 139.579616277369325m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1043,
                column: "Price",
                value: 66.272871057085032m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1044,
                column: "Price",
                value: 241.208838255908122m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1045,
                column: "Price",
                value: 49.693836234017638m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1046,
                column: "Price",
                value: 184.316881191797885m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1047,
                column: "Price",
                value: 46.499599694957748m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1048,
                column: "Price",
                value: 132.00837647385337636m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1049,
                column: "Price",
                value: 72.518210440456913m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1050,
                column: "Price",
                value: 230.264648885698336m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1051,
                column: "Price",
                value: 32.46678916612634m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1052,
                column: "Price",
                value: 165.247567797857454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1053,
                column: "Price",
                value: 27.122298866244629m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1054,
                column: "Price",
                value: 126.130311328984935m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1055,
                column: "Price",
                value: 86.286507749544508m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1056,
                column: "Price",
                value: 248.468130469058366m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1057,
                column: "Price",
                value: 30.641724901711789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1058,
                column: "Price",
                value: 182.164379988814763m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1059,
                column: "Price",
                value: 44.508320095770778m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1060,
                column: "Price",
                value: 117.199428523580986m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1061,
                column: "Price",
                value: 54.500354417869456m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1062,
                column: "Price",
                value: 206.584071791793615m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1063,
                column: "Price",
                value: 45.0192232700262618m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1064,
                column: "Price",
                value: 216.9920524419177m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1065,
                column: "Price",
                value: 26.344900084656426m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1066,
                column: "Price",
                value: 109.956190297295291m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1067,
                column: "Price",
                value: 60.050894742783739m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1068,
                column: "Price",
                value: 212.342668380047005m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1069,
                column: "Price",
                value: 44.325744591563438m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1070,
                column: "Price",
                value: 160.94596595246238m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1071,
                column: "Price",
                value: 26.0389734004595731m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1072,
                column: "Price",
                value: 126.901033533390707m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1073,
                column: "Price",
                value: 76.763214142225052m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1074,
                column: "Price",
                value: 228.208094060573701m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1075,
                column: "Price",
                value: 44.895265571291731m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1076,
                column: "Price",
                value: 173.375316390406975m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1077,
                column: "Price",
                value: 47.377626494735518m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1078,
                column: "Price",
                value: 142.693149839525412m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1079,
                column: "Price",
                value: 69.237353553699333m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1080,
                column: "Price",
                value: 202.1073683201m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1081,
                column: "Price",
                value: 39.705892191298275m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1082,
                column: "Price",
                value: 159.287042950832463m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1083,
                column: "Price",
                value: 31.474755314364839m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1084,
                column: "Price",
                value: 121.0194337271303761m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1085,
                column: "Price",
                value: 53.937008370862118m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1086,
                column: "Price",
                value: 215.649562642621047m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1087,
                column: "Price",
                value: 45.920473946433918m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1088,
                column: "Price",
                value: 238.582702179452536m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1089,
                column: "Price",
                value: 43.186562240275502m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1090,
                column: "Price",
                value: 108.2297747762282m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1091,
                column: "Price",
                value: 58.0187596045790444m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1092,
                column: "Price",
                value: 228.0316306328976598m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1093,
                column: "Price",
                value: 38.854395956669715m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1094,
                column: "Price",
                value: 251.130288246671451m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1095,
                column: "Price",
                value: 38.30848255478953m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Price",
                value: 122.507763676703108m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1097,
                column: "Price",
                value: 72.403876315852847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1098,
                column: "Price",
                value: 229.599827156220911m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1099,
                column: "Price",
                value: 30.448108961787653m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Price",
                value: 201.664360592708612m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1101,
                column: "Price",
                value: 36.721641240060377m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1102,
                column: "Price",
                value: 117.774393041075215m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1103,
                column: "Price",
                value: 71.690678493419791m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1104,
                column: "Price",
                value: 222.168871887027813m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1105,
                column: "Price",
                value: 46.509423472184611m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1106,
                column: "Price",
                value: 194.138374838779332m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1107,
                column: "Price",
                value: 48.875381300360668m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1108,
                column: "Price",
                value: 133.250313306685679m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1109,
                column: "Price",
                value: 57.0666124059774716m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1110,
                column: "Price",
                value: 238.74737095979933m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1111,
                column: "Price",
                value: 35.293766359792516m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1112,
                column: "Price",
                value: 249.698499409431044m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1113,
                column: "Price",
                value: 34.747049596316938m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1114,
                column: "Price",
                value: 133.439980976822858m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1115,
                column: "Price",
                value: 82.956555826089112m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1116,
                column: "Price",
                value: 211.79081729700605m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1117,
                column: "Price",
                value: 38.69004181263244m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1118,
                column: "Price",
                value: 193.216645984677873m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1119,
                column: "Price",
                value: 32.579868907674492m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1120,
                column: "Price",
                value: 108.295065911773851m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1121,
                column: "Price",
                value: 57.809822376675941m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Price",
                value: 213.88901218506283m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1123,
                column: "Price",
                value: 38.523871313900616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1124,
                column: "Price",
                value: 259.694061502767637m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1125,
                column: "Price",
                value: 32.737204796108082m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1126,
                column: "Price",
                value: 143.0283888612364083m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1127,
                column: "Price",
                value: 86.75315340886294m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1128,
                column: "Price",
                value: 211.654086487116958m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1129,
                column: "Price",
                value: 46.0920411039671617m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1130,
                column: "Price",
                value: 142.175321501489886m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1131,
                column: "Price",
                value: 24.0693682771808346m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1132,
                column: "Price",
                value: 102.00350281448007184m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1133,
                column: "Price",
                value: 80.623313813068199m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1134,
                column: "Price",
                value: 222.512820560582863m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1135,
                column: "Price",
                value: 32.441332187384331m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1136,
                column: "Price",
                value: 243.0283446518613028m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1137,
                column: "Price",
                value: 27.149783049010185m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1138,
                column: "Price",
                value: 149.802318005746026m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1139,
                column: "Price",
                value: 69.228736668414116m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1140,
                column: "Price",
                value: 236.285094891736303m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1141,
                column: "Price",
                value: 47.028267811470023m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1142,
                column: "Price",
                value: 206.629738555966462m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1143,
                column: "Price",
                value: 33.3060158590616m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1144,
                column: "Price",
                value: 137.233289166313377m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1145,
                column: "Price",
                value: 72.0790446630458514m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1146,
                column: "Price",
                value: 237.964686090043863m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1147,
                column: "Price",
                value: 40.0418982255891626m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1148,
                column: "Price",
                value: 149.102337772983054m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1149,
                column: "Price",
                value: 26.0208644914436944m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1150,
                column: "Price",
                value: 149.872104120089902m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1151,
                column: "Price",
                value: 79.329707141766018m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1152,
                column: "Price",
                value: 217.165613503513241m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1153,
                column: "Price",
                value: 34.514528123439666m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1154,
                column: "Price",
                value: 190.50528775196878m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Price",
                value: 24.707126091888993m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Price",
                value: 101.988623532893238m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Price",
                value: 69.877881353311682m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1158,
                column: "Price",
                value: 241.646604164721979m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1159,
                column: "Price",
                value: 38.950736387015172m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1160,
                column: "Price",
                value: 146.608469164616647m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1161,
                column: "Price",
                value: 32.259436234082867m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1162,
                column: "Price",
                value: 130.879806037764375m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Price",
                value: 65.439256205551935m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1164,
                column: "Price",
                value: 220.430255776691468m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1165,
                column: "Price",
                value: 48.167702489404832m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1166,
                column: "Price",
                value: 208.416045573006732m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1167,
                column: "Price",
                value: 45.044160258435252m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1168,
                column: "Price",
                value: 121.272150841586789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1169,
                column: "Price",
                value: 82.614663718424454m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1170,
                column: "Price",
                value: 217.905800868792546m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1171,
                column: "Price",
                value: 49.235961250567487m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1172,
                column: "Price",
                value: 146.883466202190456m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1173,
                column: "Price",
                value: 21.98719792854489m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1174,
                column: "Price",
                value: 141.0727173473885462m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1175,
                column: "Price",
                value: 56.602826115613836m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1176,
                column: "Price",
                value: 211.659123234918448m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1177,
                column: "Price",
                value: 30.604615539006402m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1178,
                column: "Price",
                value: 208.97587271470422m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1179,
                column: "Price",
                value: 20.718198030841346m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1180,
                column: "Price",
                value: 107.802357149929847m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1181,
                column: "Price",
                value: 57.768155106829122m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1182,
                column: "Price",
                value: 236.328278149211888m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1183,
                column: "Price",
                value: 30.44720688145343m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1184,
                column: "Price",
                value: 135.845919468406982m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1185,
                column: "Price",
                value: 39.473822798896789m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1186,
                column: "Price",
                value: 136.300143694413448m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Price",
                value: 46.792317898397796m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Price",
                value: 225.207387854385963m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Price",
                value: 36.909375905850226m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Price",
                value: 242.161605427943714m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Price",
                value: 32.754685107467987m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Price",
                value: 144.790460580131518m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1193,
                column: "Price",
                value: 76.202838400701681m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1194,
                column: "Price",
                value: 206.866367587967436m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1195,
                column: "Price",
                value: 43.535407476779521m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1196,
                column: "Price",
                value: 153.633212118220383m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1197,
                column: "Price",
                value: 45.173538278072984m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1198,
                column: "Price",
                value: 148.897200439675708m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1199,
                column: "Price",
                value: 82.0612282955789557m);

            migrationBuilder.UpdateData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1200,
                column: "Price",
                value: 217.407842508679844m);
        }
    }
}
