namespace BigStar.Models
{
	public class CardSource
	{
		private List<CollectibleCard> _cards;
		public CardSource()
		{
			_cards = new List<CollectibleCard>();
			CollectibleCard card;
			card = new CollectibleCard
			{
				ID = 101,
				CardName = "Mingle",
				OriginalPrice = 5.99M,
				AskingPrice = 15.95M,
				ImageURI = "Monster-Mingle-card.png",

			};
			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 102,
				CardName = "Yodel",
				OriginalPrice = 5.99M,
				AskingPrice = 6.95M,
				ImageURI = "Monster-Yodel-card.png",

			};
			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 103,
				CardName = "Squido",
				OriginalPrice = 5.99M,
				AskingPrice = 7.50M,
				ImageURI = "Monster-Squido-card.png",

			};

			_cards.Add(card);

			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 104,
				CardName = "Spook",
				OriginalPrice = 5.99M,
				AskingPrice = 23.50M,
				ImageURI = "Monster-Spook-card.png",

			};

			_cards.Add(card);

			card = new CollectibleCard
			{
				ID = 201,
				CardName = "Violette",
				OriginalPrice = 5.99M,
				AskingPrice = 21.00M,
				ImageURI = "Aliens-Violette-card.png",

			};

			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 202,
				CardName = "Tomolor",
				OriginalPrice = 4.99M,
				AskingPrice = 17.25M,
				ImageURI = "Aliens-Tomolor-card.png",

			};

			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 203,
				CardName = "Celestia Dristi",
				OriginalPrice = 3.99M,
				AskingPrice = 28.95M,
				ImageURI = "Aliens-Celestia-card.png",

			};

			_cards.Add(card);
			card = new CollectibleCard
			{
				ID = 204,
				CardName = "Trisaphron",
				OriginalPrice = 6.99M,
				AskingPrice = 15.00M,
				ImageURI = "Aliens-Trisaphron-card.png",

			};

			_cards.Add(card);
		}

		public List<CollectibleCard> CollectibleCards
		{
			get
			{
				return _cards;
			}
		}
		public List<CollectibleCard> CardsOrderedByName
		{
			get
			{
				return _cards.OrderBy(x => x.CardName).ToList();
			}
		}
		public static Decimal GetOfferPrice(CollectibleCard card, Condition cn) => cn switch
		{
			Condition.Mint => card.AskingPrice,
			Condition.Good => card.AskingPrice * .8M,
			Condition.Played => card.AskingPrice * .5M,
			Condition.Poor => card.AskingPrice * .15M,
			_ => 0

		};



	}
}