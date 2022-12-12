using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;

namespace Potluck.Models
{
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=potluck;Uid=root;Pwd=ReasonsILoveYou;");

        public static List<Teammember> GetAllTeammembers()
        {
            return DB.GetAll<Teammember>().ToList();
        }

        public static Teammember GetOneTeammember(int id)
        {
            return DB.Get<Teammember>(id);
        }

        public static Teammember InsertTeammember(Teammember teammember)
        {
            DB.Insert<Teammember>(teammember);
            return teammember;
        }

        public static void DeleteTeammember(int id)
        {
            //DB.Execute("delete from Dish where TeammemberId=@Id", new { Id = id });
            Teammember teammember = new Teammember();
            teammember.Id = id;
            DB.Delete<Teammember>(teammember);
        }

        public static void UpdateTeammember(Teammember teammember)
        {
            DB.Update<Teammember>(teammember);
        }

        //public static List<Dish> GetTeammemberDishs(int id)
        //{
        //    return DB.GetAll<Dish>().Where(x => x.TeammemberID == id).ToList();
        //}

        // Dish
        public static List<Dish> GetAllDishes()
        {
            return DB.GetAll<Dish>().ToList();
        }

        public static Dish GetOneDish(int id)
        {
            return DB.Get<Dish>(id);
        }

        public static Dish InsertDish(Dish dish)
        {
            DB.Insert<Dish>(dish);
            return dish;
        }

        public static void DeleteDish(int id)
        {
            Dish dish = new Dish();
            dish.Id = id;
            DB.Delete<Dish>(dish);
        }

        public static void UpdateDish(Dish dish)
        {
            DB.Update<Dish>(dish);
        }
    }
}
