using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAndBoard.Models
{
    public class Note
    {
        /// <summary>
        /// Note Number
        /// </summary>
        /// <value>The note no.</value>
        [Key]
        public int NoteNo { get; set; }

        /// <summary>
        /// Gets or sets the note title.
        /// </summary>
        /// <value>The note title.</value>
        [Required]
        public string NoteTitle { get; set; }

        /// <summary>
        /// Gets or sets the note contents.
        /// </summary>
        /// <value>The note contents.</value>
        [Required]
        public string NoteContents { get; set; }

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        /// <value>My property.</value>
        [Required]
        public string MyProperty { get; set; }

        [Required]
        public int UserNo { get; set; }


        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
