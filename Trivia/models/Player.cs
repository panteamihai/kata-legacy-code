﻿using System;

namespace trivia.models
{
    public class Player
    {
        public string Name { get; }

        public int Ordinal { get; }

        public Location Location { get; private set; }

        public Player(string name, int ordinal)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException();

            if (ordinal < 0)
                throw new ArgumentException();

            Name = name;

            Ordinal = ordinal;

            Location = Location.Start;
        }

        public void MoveTo(Location location)
        {
            Location = location;
        }

        public override int GetHashCode()
        {
            return unchecked (Name.GetHashCode() * 17 + Ordinal.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (obj is Player player)
                return Name == player.Name && Ordinal == player.Ordinal;

            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
