using System;

namespace GameProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlayer player1 = new GamePlayer();
            player1.Id = 1;
            player1.Name = "İrem";
            player1.Surname = "Sarıbıyık";
            player1.DateofBirth = "1996";
           
            GamePlayer player2 = new GamePlayer();
            player2.Id = 2;
            player2.Name = "Görkem";
            player2.Surname = "Sarıbıyık";
            player2.DateofBirth = "1999";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 3;
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignDiscount = "% 50 Discount";

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 4;
            campaign2.CampaignName = "Boxing Day";
            campaign2.CampaignDiscount = "%70 Discount";

            Game game1 = new Game();
            game1.GameId = 5;
            game1.GameName = "The Sims";
            game1.GamePrice = 100;

            Game game2= new Game();
            game2.GameId = 5;
            game2.GameName = "Uncharted";
            game2.GamePrice = 200;

             

            IGamePlayerService gameplayerManager = new GamePlayerManager();
            gameplayerManager.Update(player2);
        
            IGameService gameManager = new GameManager();
            gameManager.Add(game1);

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);

            ILoggerService smsService = new SmsLoggerService();
            ILoggerService databaseService = new DatabaseLoggerService();

            smsService.Log();
            databaseService.Log();
           





        }
    }
}
