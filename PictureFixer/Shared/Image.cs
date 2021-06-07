using System;
using System.ComponentModel.DataAnnotations;

namespace PictureFixer.Shared
{
    public interface Image
    {
        int Id { get; set; }

        DateTime CreatedAt { get; set; }

        string RelativeUrl { get; }

        DateTime ModifiedAt { get; set; }
    }
}
