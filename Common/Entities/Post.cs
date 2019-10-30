using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    /// <summary>
    /// the post entities
    /// </summary>
    public class Post
    {
        /// <summary>
        /// the post id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// the title of post
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// contain of post
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// creation date of post
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// update date of post
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// status of the post
        /// true = published
        /// false = pending
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Comments of post
        /// </summary>
        public virtual List<Comment> Comments { get; set; }
    }
}