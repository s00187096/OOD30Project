using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30project_gametracker
{
    public enum GameGenre
    {
Action,
    Platformer,
    Shooter,
	Fighting,
	Beatem_up,
	Stealth,
	Survival,
	Battle_Royale,
	Rhythm,
Action_adventure,
	Survival_Horror,
	Metroidvania,
	Adventure,
	Text_adventures,
	Graphic_adventures,
	Visual_novels,
	Interactive_movie,
	Real_time_3D_adventures,
	Role_playing,
	Action_RPG,
	MMORPG,
	Roguelikes,
	Tactical_RPG,
	Sandbox_RPG,
	JRPG,
	First_person_party_based_RPG,
	Simulation,
	Construction_and_management_simulation,
	Life_simulation,
	Vehicle_simulation,
Strategy,
	//4X,
	Artillery,
	Auto_battler,
	Multiplayer_online_battle_arena,
	Real_time_strategy,
	Real_time_tactics,
	Tower_defense,
	Turn_based_strategy,
	Turn_based_tactics,
	War,
	Grand_strategy_war,
	Sports,
	Racing,
	Competitive,
	Sports_based_fighting,
Other_notable_genres,
Board___or_card,
	Casual,
	Digital_collectible_card,
	Logic,
	MMO,
	Mobile,
	Party,
	Programming,
	Trivia,
	Adver,
	Art,
	Christian,
	Educational,
	Esports,
	Exer,
	Personalized,
	Serious_game
    }
    public class  games:IComparable
    {
        public string Name { get; set; }
        public GameGenre Genre1 { get; set; }
        public GameGenre Genre2 { get; set; }
        public string Format { get; set; }

        
		
		public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
