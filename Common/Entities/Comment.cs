using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    /// <summary>
    /// the Comment entity
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// the id of comment
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the author of comment
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// the email writer
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// the comment
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// the creation date of comment
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// the id of the post
        /// </summary>
        public int IdPost { get; set; }

        /// <summary>
        /// the id of the post
        /// </summary>
        public int PostId { get; set; }
    }
}