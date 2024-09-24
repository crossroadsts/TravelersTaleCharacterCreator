namespace TravelersTaleCharacterCreator;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Fields;
using MigraDoc.Rendering;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.IO;
using PdfSharp.Quality;
using PdfSharp.Snippets.Font;

class Program
{
    static void Main(string[] args)
    {
        BaseCharacter character = new BaseCharacter();
        
        Console.WriteLine("Welcome to Traveler's Tale Character Creator\n\n");

        #region Race Selection

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
        #endregion

        #region Race Proficiencies
        int prof1 = 0;
        int prof2 = 0;
        int prof3 = 0;
        int prof4 = 0;
        int prof5 = 0;

        bool profCheckFailed = true;
        while(profCheckFailed) {
            Console.WriteLine("Select 5 Proficiencies (press enter after each):");
            int profNum = 1;
            foreach (var prof in character.PossibleProficiencies)
            {
                Console.WriteLine(profNum + ": " + prof);
                profNum++;
            }

            prof1 = Convert.ToInt32(Console.ReadLine());
            prof2 = Convert.ToInt32(Console.ReadLine());
            prof3 = Convert.ToInt32(Console.ReadLine());
            prof4 = Convert.ToInt32(Console.ReadLine());
            prof5 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> profs = new(){prof1, prof2, prof3, prof4, prof5};
            profCheckFailed = profs.Count != 5;

            if (profCheckFailed) {
                Console.WriteLine("\nYou can only pick each Proficiency one time.");
            }
        }

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
        #endregion

        #region Vocational Skills

        int voc1 = 0;
        int voc2 = 0;

        bool vocCheckFailed = true;
        while(vocCheckFailed) {
            Console.WriteLine("Select 2 Vocational Skills (press enter after each):");
            foreach (var voc in Enum.GetValues(typeof(VocationalSkillsEnum)))
            {
                Console.WriteLine((int)voc + ": " + voc);
            }

            voc1 = Convert.ToInt32(Console.ReadLine());
            voc2 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> vocs = new(){voc1, voc2};
            vocCheckFailed = vocs.Count != 2;

            if (vocCheckFailed) {
                Console.WriteLine("\nYou can only pick each Vocational Skill one time.");
            }
        }

        List<VocationalSkillsEnum> selectedVocs = new()
        {
            (VocationalSkillsEnum)voc1,
            (VocationalSkillsEnum)voc2,
        };

        foreach (var selectedVoc in selectedVocs)
        {
            switch(selectedVoc) {
                case VocationalSkillsEnum.Farming:
                    character.Farming += 1;
                    break;
                case VocationalSkillsEnum.Science:
                    character.Science += 1;
                    break;
                case VocationalSkillsEnum.Cooking:
                    character.Cooking += 1;
                    break;
                case VocationalSkillsEnum.Medicine:
                    character.Medicine += 1;
                    break;
                case VocationalSkillsEnum.Mechanics:
                    character.Mechanics += 1;
                    break;
                case VocationalSkillsEnum.Technology:
                    character.Technology += 1;
                    break;
                case VocationalSkillsEnum.Carpentry:
                    character.Carpentry += 1;
                    break;
                case VocationalSkillsEnum.Smithing:
                    character.Smithing += 1;
                    break;
                case VocationalSkillsEnum.Mounting:
                    character.Mounting += 1;
                    break;
                case VocationalSkillsEnum.Fishing:
                    character.Fishing += 1;
                    break;
                case VocationalSkillsEnum.Alchemy:
                    character.Alchemy += 1;
                    break;
                case VocationalSkillsEnum.Weaving:
                    character.Weaving += 1;
                    break;
                case VocationalSkillsEnum.Leatherworking:
                    character.Leatherworking += 1;
                    break;
                case VocationalSkillsEnum.Music:
                    character.Music += 1;
                    break;
                case VocationalSkillsEnum.Art:
                    character.Art += 1;
                    break;
                case VocationalSkillsEnum.Botany:
                    character.Botany += 1;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Discipline
        Console.WriteLine("Select a Discipline:");
        foreach (var discipline in Enum.GetValues(typeof(DisciplinesEnum)))
        {
            Console.WriteLine((int)discipline + ": " + discipline);
        }
        int disciplineInput = Convert.ToInt32(Console.ReadLine());
        var disciplineSelection = (DisciplinesEnum)disciplineInput;
        
        switch(disciplineSelection) {
            case DisciplinesEnum.MysticDeathKnight:
                character.Discipline = new MysticDeathKnight();
                break;
            case DisciplinesEnum.MysticPugalist:
                character.Discipline = new MysticPugalist();
                break;
            case DisciplinesEnum.MysticTyrant:
                character.Discipline = new MysticTyrant();
                break;
            case DisciplinesEnum.MysticWarrior:
                character.Discipline = new MysticWarrior();
                break;
            default:
                break;
        }

        int disciplineProf1 = 0;
        int disciplineProf2 = 0;
        int disciplineProf3 = 0;

        bool disciplineProfCheckFailed = true;
        while(disciplineProfCheckFailed) {
            Console.WriteLine("Select 3 Proficiencies (press enter after each):");
            int profNum = 1;
            foreach (var prof in character.PossibleProficiencies)
            {
                Console.WriteLine(profNum + ": " + prof);
                profNum++;
            }

            disciplineProf1 = Convert.ToInt32(Console.ReadLine());
            disciplineProf2 = Convert.ToInt32(Console.ReadLine());
            disciplineProf3 = Convert.ToInt32(Console.ReadLine());

            HashSet<int> profs = new(){disciplineProf1, disciplineProf2, disciplineProf3};
            disciplineProfCheckFailed = profs.Count != 3;

            if (disciplineProfCheckFailed) {
                Console.WriteLine("\nYou can only pick each Proficiency one time.");
            }
        }

        List<ProficienciesEnum> selectedDisciplineProficiencies = new()
        {
            character.Discipline.PossibleProficiencies[disciplineProf1-1],
            character.Discipline.PossibleProficiencies[disciplineProf2-1],
            character.Discipline.PossibleProficiencies[disciplineProf3-1],
        };

        foreach (var selectedProf in selectedDisciplineProficiencies)
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

        #endregion

        #region Roll for XP

        Console.WriteLine("Rolling for XP...");

        int totalXP = RollForXP();

        while (totalXP >= 50) {
            Console.WriteLine("Total XP Remaining: " + totalXP);
            Console.WriteLine("Select a Stat to Level Up (-50 XP):");
            foreach (var coreStat in Enum.GetValues(typeof(CoreStatsEnum)))
            {
                Console.Write((int)coreStat + ": " + coreStat + " - Current Level: ");

                switch(coreStat) {
                    case CoreStatsEnum.Power:
                        Console.Write(character.Power + "\n");
                        break;
                    case CoreStatsEnum.Speed:
                        Console.Write(character.Speed + "\n");
                        break;
                    case CoreStatsEnum.Vigor:
                        Console.Write(character.Vigor + "\n");
                        break;
                    case CoreStatsEnum.Wit:
                        Console.Write(character.Wit + "\n");
                        break;
                    case CoreStatsEnum.Presence:
                        Console.Write(character.Presence + "\n");
                        break;
                    default:
                        break;
                }
            }

            int statInput = Convert.ToInt32(Console.ReadLine());
            var statSelection = (CoreStatsEnum)statInput;

            switch(statSelection) {
                case CoreStatsEnum.Power:
                    if (character.Power < 10) {
                        character.Power += 1;
                        totalXP -= 50;
                    }
                    else {
                        Console.WriteLine("Power is already at Level 10. Pick a different stat.");
                    }
                    break;
                case CoreStatsEnum.Speed:
                    if (character.Speed < 10) {
                        character.Speed += 1;
                        totalXP -= 50;
                    }
                    else {
                        Console.WriteLine("Speed is already at Level 10. Pick a different stat.");
                    }
                    break;
                case CoreStatsEnum.Vigor:
                    if (character.Vigor < 10) {
                        character.Vigor += 1;
                        totalXP -= 50;
                    }
                    else {
                        Console.WriteLine("Vigor is already at Level 10. Pick a different stat.");
                    }
                    break;
                case CoreStatsEnum.Wit:
                    if (character.Wit < 10) {
                        character.Wit += 1;
                        totalXP -= 50;
                    }
                    else {
                        Console.WriteLine("Wit is already at Level 10. Pick a different stat.");
                    }
                    break;
                case CoreStatsEnum.Presence:
                    if (character.Presence < 10) {
                        character.Presence += 1;
                        totalXP -= 50;
                    }
                    else {
                        Console.WriteLine("Presence is already at Level 10. Pick a different stat.");
                    }
                    break;
                default:
                    break;
            }
        }
        
        character.SkillXP = totalXP;
        Console.WriteLine("Remaining XP for your Skill XP Pool: " + character.SkillXP + "\n");
        #endregion

        #region Anima
        Console.WriteLine("Rolling for Anima...");
        character.AnimaStat = RollForAnima();
        Console.WriteLine("Your Anima is: " + character.AnimaStat + "\n");
        #endregion

        //todo: weapon

        //todo: shield

        //todo: armor
        
        #region Wren
        Console.WriteLine("Select a Wren:");
        foreach (var wren in Enum.GetValues(typeof(WrensEnum)))
        {
            Console.WriteLine((int)wren + ": " + wren);
        }
        int wrenInput = Convert.ToInt32(Console.ReadLine());
        var wrenSelection = (WrensEnum)wrenInput;

        switch(wrenSelection) {
            case WrensEnum.Evoker:
                character.Wren = new Evoker();
                break;
            case WrensEnum.Conjuror:
                character.Wren = new Conjuror();
                break;
            case WrensEnum.Enchanter:
                character.Wren = new Enchanter();
                break;
            case WrensEnum.Transmutation:
                character.Wren = new Transmutation();
                break;
            case WrensEnum.Restoration:
                character.Wren = new Restoration();
                break;
            case WrensEnum.Divination:
                character.Wren = new Divination();
                break;
            default:
                break;
        }
        // todo: finish wren
        #endregion

        //todo: melee techniques

        Console.WriteLine("Input Character Name:");
        character.Name = Console.ReadLine();

        GeneratePDF(character);

        Console.WriteLine("Done.");
    }

    static void GeneratePDF(BaseCharacter character)
    {
        File.Copy(Environment.CurrentDirectory + "/resources/TTCharacterSheet2.pdf", Environment.CurrentDirectory + "/output/test_output.pdf", true);
        
        PdfDocument PDFDoc = PdfReader.Open(Environment.CurrentDirectory + "/output/test_output.pdf", PdfDocumentOpenMode.Modify );

        using (PDFDoc)
        {
            if (PDFDoc.AcroForm.Elements.ContainsKey("/NeedAppearances") == false) PDFDoc.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true)); else PDFDoc.AcroForm.Elements["/NeedAppearances"] = new PdfBoolean(true);

            #region Page 1
            PdfTextField currentField = (PdfTextField)PDFDoc.AcroForm.Fields["character_name"];
            currentField.Value = new PdfString(character.Name);

            currentField = (PdfTextField)PDFDoc.AcroForm.Fields["power"];
            currentField.Value = new PdfString(ConvertIntToDiceString(character.Power));

            #endregion

            // todo, generate file name and save somewhere better
            PDFDoc.Save(Environment.CurrentDirectory + "/output/test_output.pdf");
        }
    }

    public static string ConvertIntToDiceString(int val)
    {
        switch(val)
        {
            case 0:
                return "1d4*";
            case 1:
                return "1d4";
            case 2:
                return "2d4";
            case 3:
                return "1d4+1d6";
            case 4:
                return "2d6";
            case 5:
                return "1d6+1d8";
            case 6:
                return "2d8";
            case 7:
                return "1d8+1d10";
            case 8:
                return "2d10";
            case 9:
                return "1d10+1d12";
            case 10:
                return "2d12";
            default:
                return "bad dice val";
        }
    }

    static int RollForXP() 
    {
        Random rnd = new Random();
        int sum = 0;

        for(var i = 0; i < 18; i++)
        {
            sum += rnd.Next(1, 7);
        }

        return sum *= 20;
    }

    static int RollForAnima()
    {
        Random rnd = new Random();
        int sum = 0;

        for(var i = 0; i < 3; i++)
        {
            sum += rnd.Next(1, 7);
        }

        return sum;
    }
}