using System.ComponentModel.DataAnnotations.Schema;

namespace BattleShip {
    [Table("Users")]
    class User {
        public int id { get; set; }
        private string login, password, email;        
        
        public string Login { get =>  login; set => login = value; }
        public string Password { get=>  password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public User() { }

        public User(string login, string email, string password) {
            this.login = login; this.email = email; this.password = password;
        }
    }
}
