using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket.Respository.Enums
{
    public enum MovieRating
    {
        Unknown =0,
        Unrestricted = 1,
        ParentalGuidance = 2,
        RestrictedToAdults = 3,
        RestrictedToSpecificGroup = 4,
    }
}
