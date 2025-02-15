﻿using System.ComponentModel.DataAnnotations;

namespace GoodGameDatabase.Web.ViewModels.Game
{
    public class AllGameViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? ReleaseDate { get; set; }

        public string ImageUrl { get; set; } = null!;

        public double Rating { get; set; }

        public int Likes { get; set; }

        public string Description { get; set; }

        public bool SupportsPC { get; set; }

        public bool SupportsPS { get; set; }

        public bool SupportsXbox { get; set; }

        public bool SupportsNintendo { get; set; }

    }
}
