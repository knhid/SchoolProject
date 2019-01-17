using System.ComponentModel.DataAnnotations;

namespace LoginAndBoard.Models
{
    public class User
    {
        /// <summary>
        /// User Number
        /// Primarykey
        /// </summary>
        /// <value>The user no.</value>
        [Key] //Primary Key
        public int UserNo { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <value>The name of the user.</value>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>The user identifier.</value>
        [Required]
        public string UserID { get; set; }


        /// <summary>
        /// User Password
        /// </summary>
        /// <value>The user password.</value>
        [Required]
        public string UserPW { get; set; }


        /// <summary>
        /// User Email
        /// </summary>
        /// <value>The user email.</value>
        [Required]
        public string UserEmail { get; set; }
    }
}
