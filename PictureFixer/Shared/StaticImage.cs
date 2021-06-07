using System;
using System.ComponentModel.DataAnnotations;

namespace PictureFixer.Shared
{
    public class StaticImage : Image
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string RelativeUrl => $"api/EditableImage/{Id}/contents";

        public DateTime ModifiedAt { get; set; }
    }
}
