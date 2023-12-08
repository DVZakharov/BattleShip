using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleShip;

namespace BattleShipTests {
    [TestClass]
    public class BattleShipTests {
        [TestMethod]
        public void Auth_User() {
            AppContext Db = new();
            string login = "admin";
            string password = "789987";
            User authUser = Db.Users.Where(user => user.Login == login && user.Password == password).FirstOrDefault();

            Assert.IsNotNull(authUser);
        }

        [TestMethod]
        public void Reg_User() {
            AppContext Db = new();
            Random rnd = new();
            var userFind = new User();
            string email = "testemail@test.test";
            string login, password;
            do {
                login = "admintest" + rnd.Next(1000);
                password = rnd.Next(99999, 10000001).ToString();
                userFind = Db.Users.Where(user => user.Login == login).FirstOrDefault();
            } while (userFind == null);
            var userReg = new User(login, password, email);

            Db.Users.Add(userReg);
            User authUser = Db.Users.Where(user => user.Login == login && user.Password == password).FirstOrDefault();
            Assert.IsNotNull(authUser);
        }

        [TestMethod]
        public void AttackMap_MapAndXY_MissOrShot() {

        }

        [TestMethod]
        public void ViewStatistic_User_StatWindow() {

        }
    }
}