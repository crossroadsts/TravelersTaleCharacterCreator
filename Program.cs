namespace TravelersTaleCharacterCreator;

class Program
{
    static void Main(string[] args)
    {
        BaseCharacter character = new BaseCharacter();
        
        Console.WriteLine("Welcome to Traveler's Tale Character Creator\n\n");

        Console.WriteLine("Select a Race:");
        foreach (var race in Enum.GetValues(typeof(RaceEnum)))
        {
            Console.WriteLine((int)race + ": " + race);
        }
        int raceInput = Convert.ToInt32(Console.ReadLine());
        var raceSelection = (RaceEnum)raceInput;

        switch(raceSelection) {
            case RaceEnum.Angelicon:
                Console.WriteLine("Select an Angelicon Type:");
                
                foreach (var angeliconType in Enum.GetValues(typeof(AngeliconType)))
                {
                    Console.WriteLine((int)angeliconType + ": " + angeliconType);
                }
                int angeliconTypeInput = Convert.ToInt32(Console.ReadLine());
                var angeliconTypeSelection = (AngeliconType)angeliconTypeInput;

                character = new Angelicon(angeliconTypeSelection);
                break;
            case RaceEnum.Crystalline:
                character = new Crystalline();
                break;
            case RaceEnum.Dagon:
                character = new Dagon();
                break;
            case RaceEnum.FallenAngelicon:
                Console.WriteLine("Select a Fallen Angelicon Type:");
                
                foreach (var angeliconType in Enum.GetValues(typeof(AngeliconType)))
                {
                    Console.WriteLine((int)angeliconType + ": " + angeliconType);
                }
                int fallenAngeliconTypeInput = Convert.ToInt32(Console.ReadLine());
                var fallenAngeliconTypeSelection = (FallenAngeliconType)fallenAngeliconTypeInput;

                character = new FallenAngelicon(fallenAngeliconTypeSelection);
                break;
            case RaceEnum.Human:
                character = new Human();
                break;
            case RaceEnum.Nitromech:
                character = new Nitromech();
                break;
            case RaceEnum.Shadeling:
                character = new Shadeling();
                break;
            case RaceEnum.Sharkfolk:
                Console.WriteLine("Select a Shark Type:");
                
                foreach (var sharkType in Enum.GetValues(typeof(SharkType)))
                {
                    Console.WriteLine((int)sharkType + ": " + sharkType);
                }
                int sharkTypeInput = Convert.ToInt32(Console.ReadLine());
                var sharkTypeSelection = (SharkType)sharkTypeInput;

                character = new Sharkfolk(sharkTypeSelection);
                break;
            case RaceEnum.Vereni:
                character = new Vereni();
                break;
            case RaceEnum.Vikra:
                character = new Vikra();
                break;
            default:
                break;
        }

        // todo: pick Discipline

        Console.WriteLine("Select 5 Proficiencies (press enter after each):");
        int profNum = 1;
        foreach (var prof in character.PossibleProficiencies)
        {
            Console.WriteLine(profNum + ": " + prof);
            profNum++;
        }

        int prof1 = Convert.ToInt32(Console.ReadLine());
        int prof2 = Convert.ToInt32(Console.ReadLine());
        int prof3 = Convert.ToInt32(Console.ReadLine());
        int prof4 = Convert.ToInt32(Console.ReadLine());
        int prof5 = Convert.ToInt32(Console.ReadLine());

        List<ProficienciesEnum> selectedProficiencies = new()
        {
            character.PossibleProficiencies[prof1-1],
            character.PossibleProficiencies[prof2-1],
            character.PossibleProficiencies[prof3-1],
            character.PossibleProficiencies[prof4-1],
            character.PossibleProficiencies[prof5-1]
        };

        foreach (var selectedProf in selectedProficiencies)
        {
            switch(selectedProf) {
                case ProficienciesEnum.Athletics:
                    character.Athletics += 1;
                    break;
                case ProficienciesEnum.Strength:
                    character.Strength += 1;
                    break;
                case ProficienciesEnum.Intimidation:
                    character.Intimidation += 1;
                    break;
                case ProficienciesEnum.Skulduggery:
                    character.Skulduggery += 1;
                    break;
                case ProficienciesEnum.Stealth:
                    character.Stealth += 1;
                    break;
                case ProficienciesEnum.Acrobatics:
                    character.Acrobatics += 1;
                    break;
                case ProficienciesEnum.Constitution:
                    character.Constitution += 1;
                    break;
                case ProficienciesEnum.Navigation:
                    character.Navigation += 1;
                    break;
                case ProficienciesEnum.Survival:
                    character.Survival += 1;
                    break;
                case ProficienciesEnum.Lore:
                    character.Lore += 1;
                    break;
                case ProficienciesEnum.Perception:
                    character.Perception += 1;
                    break;
                case ProficienciesEnum.Anima:
                    character.Anima += 1;
                    break;
                case ProficienciesEnum.Deduction:
                    character.Deduction += 1;
                    break;
                case ProficienciesEnum.Streetwise:
                    character.Streetwise += 1;
                    break;
                case ProficienciesEnum.Barter:
                    character.Barter += 1;
                    break;
                case ProficienciesEnum.Charm:
                    character.Charm += 1;
                    break;
                case ProficienciesEnum.Rally:
                    character.Rally += 1;
                    break;
                case ProficienciesEnum.Cool:
                    character.Cool += 1;
                    break;
                case ProficienciesEnum.Diplomacy:
                    character.Cool += 1;
                    break;
                default:
                    break;
            }
        }

        // todo: roll for XP

        // todo: pick vocational skills

        // todo: anima?

        Console.WriteLine("Input Character Name:");
        character.Name = Console.ReadLine();

        Console.WriteLine("Done.");
    }
}