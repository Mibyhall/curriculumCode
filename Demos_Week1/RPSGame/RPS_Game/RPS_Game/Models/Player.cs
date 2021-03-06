﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace RPS_Game
{
    public class Player
    {
		public int PlayerId { get; set; }
		private string _Name;
		public string Name
		{
			get {return _Name;}
			set { _Name = value; }
		}

		private int _wins;
		public int Wins
		{
			get { return _wins; }
			set { _wins = value; }
		}

		private int _losses;
		public int Losses
		{
			get { return _losses; }
			set { _losses = value; }
		}

		public Player() { }

		private readonly ILogger _logger;
		public Player(string name, ILogger<Player> logger)
		{
			_Name = name;
			_logger = logger;
			_logger.LogInformation("here in player");
		}




	}
}