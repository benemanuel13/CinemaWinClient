﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaWinClient.Models.ApiModels
{
    public class MemberFilm
    {
        public int MemberFilmID { get; set; }

        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public Member Member { get; set; }

        public int FilmID { get; set; }
        [ForeignKey("FilmID")]
        public Film Film { get; set; }
    }
}
